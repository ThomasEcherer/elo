
importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.FunctionBase.js
//@include lib_sol.common.SordUtils.js
//@include lib_sol.common.Template.js
//@include sol.common.ix.functions.Set.js


var logger = sol.create("sol.Logger", { scope: "holme.common.ix.functions.Set" });

/**
 * Similar to 'sol.common.ix.functions.Set' this function sets values.
 * The difference is a search for a object will be initiated before setting the values.
 * For setting values the original ELO-function will be used. 
 * 
 * Throws an error if none or more than one object is found.
 * This Object will be used as 'sord' parameter for the setting part.
 * 
 * If an error happens on the Search for the object, the 'defaultValue' will be wirtten.
 * 
 * //TODO: Beispiel hinzufügen
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.Config
 * @requires sol.common.SordUtils
 * @requires sol.common.ix.functsion.Set
 * @requires sol.common.Template 
 */
sol.define("holme.common.ix.functions.Set", {
  extend: "sol.common.ix.FunctionBase",
  
  requiredConfig: ["searchConfig", "setConfig", "objId"],
  
  /** 
   * @cfg {Object} searchConfig the Search-Configuration
   * @cfg {String} searchConfig.mask The mask to search for
   * @cfg {Object} searchConfig.objKeysObj The ObjKeys to search for
   * @cfg {String[]} searchConfig.objKeys The ObjKeys of the Object (deliverd by objId) to use for the search
   */
  searchConfig: undefined,

  /**
   * @cfg {Object} setConfig The Set-_Configuration 
   * @see sol.common.Set
   */
  setConfig: undefined,

  /**
   * @cfg {String} objId The Object to set the values to
   */
  objId: undefined, 

  /**
   * @cfg {String} defaultValue If no Entry was found, this value will be written. Default is 'ERROR'
   */
  defaultValue: "ERROR",

  /**
   * @private
   * @property {boolean} errorHappend Indicates if an error happend by searching the object.
   */
  errorHappend: false,

  initialize: function (config) {
    var me = this;

    // templating
    me.$super("sol.common.ix.FunctionBase", "initialize", [config]);    
  },

  /**
   * @returns {boolean} Returns True if no error happend, Returns false otherwise
   */
  process: function () {
    var me = this,
        sord;
    
    logger.info("... search Object ...");    
    try {
      sord = me.searchObject();
    } catch (e) {
      logger.error("An error occured by searching for object", e);
      me.errorHappend = true;
      try {
        me.reportError(e);
      } catch (ex) {
        logger.error("An error occured by reporting the error", ex);
      }
    }

    logger.info(["Object found: {0}", sord]);
    me.setValues(sord);

    return !me.errorHappend;
  },

  /**
   * Reports an error Message by writing the message into the sordmap 'ERRORMSG'
   * @param {Exception|String} error The Error to report
   */
  reportError: function (error) {
    var me = this,
        map;
    
    map = sol.create("sol.common.SordMap", {
      objId: me.objId
    });
    map.read();
    map.setValue(map.getValue("ERRORMSG") + "|" + error);    
    map.write();
  },

  /**
   * @private
   * Search for an Object in ELO.
   * The Search itself is configured in searchConfig
   * 
   * Throws an Exception if none or more than one object was found.
   * 
   * @return {Sord} The Object that was found
   */
  searchObject: function () {
    var me = this,
        fi, fr, docMask, objKeys = [], prop, i, max, sord, value, j, maxj;

    sord = ixConnect.ix().checkoutSord(me.objId, SordC.mbLean, LockC.NO);
    
    docMask = sol.common.SordUtils.getDocMask(me.searchConfig.mask);
    max = docMask.lines.length;

    if (me.searchConfig.objKeysObj) {
      for (prop in me.searchConfig.objKeysObj) {
        logger.info(["prepareSearch with property: {0}", prop]);
        if (me.searchConfig.objKeysObj.hasOwnProperty(prop)) {
          for (i = 0; i < max; i++) {
            if (prop == docMask.lines[i].key) {
              value = sol.create("sol.common.Template", { source: me.searchConfig.objKeysObj[prop] }).applySord(sord);
              logger.info(["Adding '{0}' to ObjKey {1}", value, docMask.lines[i].key]);
              objKeys.push(new ObjKey([value], docMask.lines[i].id, docMask.lines[i].key, 0));
            }
          }
        }
      }
    }

    if (me.searchConfig.objKeys) {      
      maxj = me.searchConfig.objKeys;
      for (j = 0; j < maxj; j++) {
        for (i = 0; i < max; i++) {
          if (me.searchConfig.objKeys[j] == docMask.lines[i].key) {
            objKeys.push(new objKeys(sol.common.SordUtils.getObjKeyValues(sord, me.searchConfig.objKeys[j]), docMask.lines[i].id, docMask.lines[i].key, 0));
          }
        }
      }
    }
    
    fi = new FindInfo();
    fi.findByIndex = new FindByIndex();
    fi.findByIndex.maskId = me.searchConfig.mask;
    fi.findByIndex.objKeys = objKeys;

    try {
      fr = ixConnectAdmin.ix().findFirstSords(fi, 2, SordC.mbAll);

      if (fr.sords.length > 1) {
        throw "More than one object found";
      }
      if (fr.sords.length < 1) {
        throw "No Object found";
      }

      return fr.sords[0];
    } finally {
      if (fr) {
        try {
          ixConnectAdmin.ix().findClose(fr.searchId);
        } catch (e) {
          // ignored
        }
      }
    }
  },

  /**
   * @private
   * Sets the Value into the Object
   * @param {Sord} sord The found object in the previous step. Will be used for templating to set the values
   */
  setValues: function (sord) {
    var me = this,
        mod, tpl, i, max;

    logger.info("Prepare Setting Values");
    max = me.setConfig.entries.length;
    for (i = 0; i < max; i++) {
      if (me.errorHappend) {
        me.setConfig.entries[i].value = me.defaultValue;
      } else {
        tpl = sol.create("sol.common.Template", { source: me.setConfig.entries[i].value });        
        me.setConfig.entries[i].value = tpl.applySord(sord);
      }
    }
    
    logger.info("setting objId");
    me.setConfig.objId = me.objId;
    
    logger.info("calling set Method");    
    mod = sol.create("sol.common.ix.functions.Set", me.setConfig);
    mod.process();
  }

});

/**
 * @member holme.common.ix.functions.Set
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onEnterNode
 */
function onEnterNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onEnterNode_Set", { flowId: wfDiagram.id, nodeId: nodeId });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId), // you might add required properties here
      module;
  
  config.objId = wfDiagram.objId;
  module = sol.create("holme.common.ix.functions.Set", config);

  module.process();

  logger.exit("onEnterNode_Set");
}

/**
 * @member holme.common.ix.functions.Set
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onExitNode
 */
function onExitNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onExitNode_Set", { flowId: wfDiagram.id, nodeId: nodeId });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId), // you might add required properties here
      module;

  config.objId = wfDiagram.objId;
  module = sol.create("holme.common.ix.functions.Set", config);

  module.process();

  logger.exit("onExitNode_Set");
}

/**
 * @member holme.common.ix.functions.Set
 * @method RF_holme_common_function_Set
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.RF_FunctionName
 */
function RF_holme_common_function_Set(ec, configAny) {
  logger.enter("RF_holme_common_function_Set", configAny);
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), // you might add required properties here
      module;

  module = sol.create("holme.common.ix.functions.Set", config);
  module.process();

  logger.exit("RF_holme_common_function_Set");
}
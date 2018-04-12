
importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.FunctionBase.js
//@include lib_sol.common.SordUtils.js

var logger = sol.create("sol.Logger", { scope: "holme.common.ix.functions.InheritToChildren" });

/**
 * Inherits Keywording and Mapping Information from 
 * one Object to its children
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.Config
 * @requires sol.common.ix.FunctionBase
 * @requires sol.common.SordUtils
 */
sol.define("holme.common.ix.functions.InheritToChildren", {
  extend: "sol.common.ix.FunctionBase",

  requiredConfig: ["objId", "fields"],
      
  /** 
   * @cfg {int} objId The Object to inherit from
   */
  objId: undefined,

  /** 
   * @cfg {Object[]} fields (required)
   * Object containing the configuration for the inherited fields:
   *
   *     [ 
   *       { type: "SORD", key: "name" },
   *       { type: "GRP", key: "MY_FIELD", "override": true }
   *     ]
   *
   * Currently only "SORD" and "GRP" are supported as `type`.
   */
  fields: [],

  /**   
   * @cfg {String} mask (optional) The mask to filter the chlidren after
   */
  mask: undefined,

  /**
   * The Object defined with 'objId'
   * @property {Sord} sord
   */
  sord: undefined, 

  initialize: function (config) {
    var me = this;
    me.$super("sol.common.ix.FunctionBase", "initialize", [config]);
    me.sord = ixConnectAdmin.ix().checkoutSord(me.objId, SordC.mbAllIndex, LockC.NO);
  },

  process: function () {
    var me = this,
        fi, fr, idx = 0, i, max;
    
    fi = new FindInfo();
    fi.findChildren = new FindChildren();
    fi.findChildren.parentId = me.objId;
    fi.findChildren.endLevel = -1;
    fi.findOptions = new FindOptions();
    if (me.mask) {
      fi.findByIndex = new FindByIndex();
      fi.findByIndex.maskId = me.mask;
    }    

    try {
      fr = ixConnectAdmin.ix().findFirstSords(fi, 100, SordC.mbLean);
      do {
        if (!fr.sords) {
          logger.error("No Results at all...");
          break;
        }

        if (fr.sords.length > 0) {
          max = fr.sords.length;
          for (i = 0; i < max; i++) {
            me.inheritToChild(fr.sords[i]);
          }
        }
        if (!fr.isMoreResults()) {
          break;
        }
        idx += fr.sords.length;
        fr = ixConnectAdmin.ix().findNextSords(fr.searchId, idx, 100, SordC.mbLean);
      } while (fr.isMoreResults());
    } finally {
      if (fr) {
        try {
          ixConnectAdmin.ix().findClose(fr.searchId);
        } catch (e) { /* ignored */ }
      }
    }    
    
  },

  /**
   * Inherits from the Object to its child
   * @param {Sord} child The Child to inherit to
   */
  inheritToChild: function (child) {
    var me = this,
        parentValue, targetValue, max, i, updates = [], childSord, mapitems, override;
    
    try {      
      max = me.fields.length;
      for (i = 0; i < max; i++) {
        override = (me.fields[i].override === true) ? true : false;
        parentValue = sol.common.SordUtils.getValue(me.sord, me.fields[i]);
        targetValue = sol.common.SordUtils.getValue(child, me.fields[i]);
        if ((targetValue !== parentValue) && override) {          
          me.fields[i].value = parentValue;
          updates.push(me.fields[i]);          
        }
      } 
      
      if (updates.length > 0) {
        childSord = ixConnectAdmin.ix().checkoutSord(child.id, SordC.mbAllIndex, LockC.FORCE);
        mapitems = sol.common.SordUtils.updateSord(childSord, updates);
        ixConnectAdmin.ix().checkinSord(childSord, SordC.mbAllIndex, LockC.YES);
        if (mapitems && (mapitems.length > 0)) {
          ixConnectAdmin.ix().checkinMap(MapDomainC.DOMAIN_SORD, childSord.id, childSord.id, mapitems, LockC.NO);
        }
      } 
      
    } catch (e) {
      logger.error("Error on inherting", e);
    }
  }
 
});

/**
 * @member holme.common.ix.functions.Inherit
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onExitNode
 */
function onExitNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onExitNode_InheritToChildren", { 
    flowId: wfDiagram.id, 
    nodeId: nodeId 
  });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId),
      module;

  config.objId = wfDiagram.objId;
  module = sol.create("holme.common.ix.functions.InheritToChildren", config);
  module.process();

  logger.exit("onExitNode_InheritToChildren");
}

/**
 * @member holme.common.ix.functions.InheritToChildren
 * @method RF_holme_common_function_InheritToChildren
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.RF_FunctionName
 */
function RF_holme_common_function_InheritToChildren(ec, configAny) {
  logger.enter("RF_holme_common_function_InheritToChildren", configAny);
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny),
      module;
  
  module = sol.create("holme.common.ix.functions.InheritToChildren", config);
  module.process();

  logger.exit("RF_holme_common_function_InheritToChildren");
}
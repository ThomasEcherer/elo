
importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.FunctionBase.js
//@include lib_sol.common.SordUtils.js
//@include lib_sol.common.RepoUtils.js
//@include lib_sol.common.Template.js


var logger = sol.create("sol.Logger", { scope: "holme.common.ix.functions.SearchAndSet" });

/**
 * Starts a FindByIndex Search and set its return (objId) into a indexfield
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.Config
 * @requires sol.common.RepoUtils
 * @requires sol.common.SordUtils
 * @requires sol.common.ix.FunctionBase
 * @requires sol.common.Template
 */
sol.define("holme.common.ix.functions.SearchAndSet", {
  extend: "sol.common.ix.FunctionBase",
  
  requiredConfig: ["objId", "mask", "searchKey", "searchValue", "writeKey", "defaultValue"],

  // configuration section //
  /** 
   * @cfg {int} objId The ObjectId of the object to edit. Will be checkedout (mbLean) and checkin after processed
   */
  
  /**
   * @cfg {String} mask The keywording-Mask for the findByIndex-Search
   */

  /**
   * @cfg {String} searchKey The Groupname of the Indexfield, used as filter for findByIndex-Search
   */

  /**
   * @cfg {String} searchValue The content of the indexfield to sarch after by the findByIndex search
   */

  /**
   * @cfg {String} writeKey The Groupname of the indexfield to write the result of the findByIndex-search
   */

  /**
   * @cfg {String} defaultValue The Value to set into the indexfield if the findByIndex Search finds no unique or no result
   */

  // property section //
  /**
   * @private
   * @property {Sord} sord The Object to edit
   */

  initialize: function (config) {
    var me = this;
    me.$super("sol.common.ix.FunctionBase", "initialize", [config]);
    me.sord = ixConnectAdmin.ix().checkoutSord(me.objId, SordC.mbLean, LockC.YES);
    logger.info("befor templateing searchvalue ...", { searchValue: me.searchValue, sord: me.sord });
    me.searchValue = sol.create("sol.common.Template", { source: me.searchValue }).apply(sol.common.ObjectFormatter.format({
      sord: {
        formatter: "sol.common.ObjectFormatter.TemplateSord",
        data: me.sord
      }
    }));
    logger.info("after templateing searchvalue ...", { searchValue: me.searchValue, sord: me.sord });
    if (!me.searchValue || me.searchValue == "") {
      me.searchValue = sol.common.SordUtils.getObjKeyValue(me.sord, me.searchKey);
    }
  },

  /**
   * Starts a FindByIndex Search and set its return (objId) into a indexfield
   */
  process: function () {
    var me = this,
        value;
    try {
      value = me.findByIndex();
      logger.info("Object found...", { value: value });
    } catch (e) {
      logger.error(e);
      logger.info(" Take Defaultvalue ...'", { value: me.defaultValue });
      value = me.defaultValue;
    }

    if (sol.common.SordUtils.objKeyExists(me.sord, me.writeKey)) {
      sol.common.SordUtils.setObjKeyValue(me.sord, me.writeKey, value);
      ixConnectAdmin.ix().checkinSord(me.sord, SordC.mbLean, LockC.YES);
    } else {
      logger.error("Objkey does not exist ... ", { key: me.writeKey });            
    }
  },

  /**
   * Starts a findByIndex Search with settings of the given config. 
   * Filter are: mask = cfg.mask. And the Indexfield (me.searchKey) with the value me.searchValue.
   * 
   * @returns {String} ObjectId of the found Object.
   * @throws {Object} Throws an exception, if result is not unique
   * @throws {Object} Throws an exception, if there is no result
   */
  findByIndex: function () {
    var me = this;
    logger.info("Searching PErsonalakte...", { value: me.searchValue, key: me.searchKey });        
    return sol.common.RepoUtils.getObjIdByIndex( 
      { 
        mask: me.mask, 
        objKeyData: [ 
          { 
            key: me.searchKey, 
            value: me.searchValue 
          } 
        ] 
      } 
    );
  }

});

/**
 * @member holme.common.ix.functions.SearchAndSet
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onExitNode
 */
function onExitNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onExitNode_SearchAndSet", { flowId: wfDiagram.id, nodeId: nodeId });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId), // you might add required properties here
      module;

  config.objId = wfDiagram.objId;
  module = sol.create("holme.common.ix.functions.SearchAndSet", config);
  module.process();

  logger.exit("onExitNode_SearchAndSet");
}

/**
 * @member holme.common.ix.functions.SearchAndSet
 * @method RF_holme_common_function_SearchAndSet
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.RF_FunctionName
 */
function RF_holme_common_function_SearchAndSet(ec, configAny) {
  logger.enter("RF_holme_common_function_SearchAndSet", configAny);
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), // you might add required properties here
      module;

  module = sol.create("holme.common.ix.functions.SearchAndSet", config);
  module.process();

  logger.exit("RF_holme_common_function_SearchAndSet");
}
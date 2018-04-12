
importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.FunctionBase.js
//@include lib_sol.common.SordUtils.js
//@include lib_sol.common.Template.js


var logger = sol.create("sol.Logger", { scope: "holme.common.ix.functions.Inherit" });

/**
 * Inhertis Keywording-Information from one object to another
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.Config
 * @requires sol.common.ix.FunctionsBase
 * @requires sol.common.SordUtils
 * @requires sol.common.Template
 */
sol.define("holme.common.ix.functions.Inherit", {
  extend: "sol.common.ix.FunctionBase",
  
  requiredConfig: ["objId", "source", "target"],

  /**
   * @cfg {String|Int} objId The ObjectID of the the workflow is attached to
   */
  objId: undefined,

  /**
   * @cfg {String} source The Object-Id of the ELO-Object to inherit (read) from
   */
  source: undefined,

  /**
   * @cfg {String} target The Object-Id of the ELO-Object to inherti (write) to
   */
  target: undefined,

  /**
   * @cfg {Object} Object containing the configuration for the inherited fields:
   * 
   * [ 
   *       { type: "SORD", key: "name" },
   *       { type: "GRP", key: "MY_FIELD", "override": true }
   * ]
   */
  fields: undefined,

  /**
   * @property {Sord} sord The ELO-Object the workflow is attached to
   */
  sord: undefined,

  /**
   * @property {Sord} sourceSord The ELO-Object for the source to copy the keywording from
   */
  sourceSord: undefined,

  /**
   * @property {Sord} targetSord The ELO-Object for the target to copy the keywording to
   */
  targetSord: undefined,

  /**
   * @property {Array} updated A List of Field to update
   */
  updates: undefined,

  /**
   * @cfg {String} wfStatusOnUpdate (optional) Text to write into the workflowstatsu if an change happens
   */
  wfStatusOnUpdate: undefined,

  /**
   * @cfg {WFDiagram} wfDiagram The active Workflow
   */
  wfDiagram: undefined,

  initialize: function (config) {
    var me = this;
    logger.enter("...initialize >>");
    me.$super("sol.common.ix.FunctionBase", "initialize", [config]);
    me.sord = ixConnectAdmin.ix().checkoutSord(me.objId, SordC.mbLean, LockC.NO);
    me.updates = [];
    logger.exit("<< initialize...");
  },

  /**
   * Inhertis Keywording-Information from one object to another
   */
  process: function () {
    var me = this,
        updateItems;
    
    //  get the source-Object
    me.source = me.getSource();
    me.sourceSord = ixConnectAdmin.ix().checkoutSord(me.source, SordC.mbLean, LockC.NO);   
    logger.info(["Reading SourceObject (ID={0}) (Sord={1})", me.source, me.sourceSord]);

    //  get the target object
    me.target = me.getTarget();
    me.targetSord = ixConnectAdmin.ix().checkoutSord(me.target, SordC.mbLean, LockC.YES);
    logger.info(["Reading TargetObject (ID={0}) (Sord={1})", me.target, me.targetSord]);
    
    //  prepare heredity
    me.fields.forEach(me.inherit, me);

    //  Update heredity if neccessary
    if (me.updates.length > 0) {
      updateItems = sol.common.SordUtils.updateSord(me.targetSord, me.updates);
      ixConnectAdmin.ix().checkinSord(me.targetSord, SordC.mbAllIndex, LockC.YES);
      if (updateItems && (updateItems.length > 0)) {
        ixConnectAdmin.ix().checkinMap(MapDomainC.DOMAIN_SORD, me.target, me.target, updateItems, LockC.NO);
      }

      //  Set Workflowstatus if an update happend
      if (me.wfStatusOnUpdate) {   
        logger.info(["Write the status '{1}' into the workflow", me.wfStatusOnUpdate]);
        sol.common.WfUtils.setWorkflowStatus(me.wfDiagram, me.wfStatusOnUpdate);

      } 
    } else {
      logger.info("No Updates happend... unlock the object");
      ixConnectAdmin.ix().checkinSord(me.targetSord, SordC.mbOnlyUnlock, LockC.YES);
    }

  },

  /**
   * @private
   * Uses Handlebards to get the 'source'
   * @returns {String} The templated Source
   */
  getSource: function () {
    var me = this, 
        tpl;
    
    tpl = sol.create("sol.common.Template", {
      source: me.source
    });
    return tpl.applySord(me.sord);
  },

  /**
   * @private
   * Uses Handlebars to get the 'target'
   * @returns {String} The tempalted target 
   */
  getTarget: function () {
    var me = this,
        tpl;

    tpl = sol.create("sol.common.Template", {
      source: me.target
    });
    return tpl.applySord(me.sord);
  },

  /**
   * @private
   * Inherits the given Fields from 'source' and writes it to 'target'
   * @param {Object} cfg Configuration
   */
  inherit: function (cfg) {
    var me = this,
        parentValue, targetValue, override, test;

    logger.info(["inherting with cfg {0}", cfg]);
    for (test in cfg) {
      logger.info(["Test - Prop (Name={0}) (Value={1})", test, cfg[test]]);
    }

    try {
      parentValue = sol.common.SordUtils.getValue(me.sourceSord, cfg);
      targetValue = sol.common.SordUtils.getValue(me.targetSord, cfg);
      override = cfg.override ? true : false;
      logger.info(["CheckUpdate on (pValue={0}) (tValue={1}) (override?{2}", parentValue, targetValue, override]);
      if (me.checkUpdate(parentValue, targetValue, override)) {
        cfg.value = parentValue;
        logger.info("Adding Field {0} with value={1} to updateFields", cfg, cfg.value);
        me.updates.push(cfg);
      }
    } catch (ex) {
      me.logger.error("error inheriting", ex);
    }

  },

  /**   
   * @private
   * 
   * Checks if an Field should be updated
   * 
   * @param {String} parentValue Parent value
   * @param {String} targetValue Target value
   * @param {Boolean} override Override value
   * @return {String}
   */
  checkUpdate: function (parentValue, targetValue, override) {
    if (parentValue) {
      parentValue += "";
    }
    if (targetValue) {
      targetValue += "";
    }
    logger.info(["CheckinonUpdate (pVAlue={0}) (tValue={1}) (override={2}) (first={3}) (second={4})", parentValue, targetValue, override, (!targetValue || override),  (parentValue !== targetValue)]);
    return (!targetValue || override) && (parentValue !== targetValue);
  }

});

/**
 * @member holme.common.ix.functions.Inherit
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onEnterNode
 */
function onEnterNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onEnterNode_Inherit", { flowId: wfDiagram.id, nodeId: nodeId });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId), 
      module;
  
  config.objId = wfDiagram.objId;
  config.wfDiagram = wfDiagram;
  module = sol.create("holme.common.ix.functions.Inherit", config);
  module.process();

  logger.exit("onEnterNode_Inherit");
}

/**
 * @member holme.common.ix.functions.Inherit
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onExitNode
 */
function onExitNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onExitNode_Inherit", { flowId: wfDiagram.id, nodeId: nodeId });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId),
      module;

  config.objId = wfDiagram.objId;
  config.wfDiagram = wfDiagram;
  module = sol.create("holme.common.ix.functions.Inherit", config);
  module.process();

  logger.exit("onExitNode_Inherit");
}

/**
 * @member holme.common.ix.functions.Inherit
 * @method RF_holme_common_function_Inherit
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.RF_FunctionName
 */
function RF_holme_common_function_Inherit(ec, configAny) {
  logger.enter("RF_holme_common_function_Inherit", configAny);
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), 
      module;

  module = sol.create("holme.common.ix.functions.Inherit", config);
  module.process();

  logger.exit("RF_holme_common_function_Inherit");
}
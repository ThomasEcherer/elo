
importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.FunctionBase.js
//@include lib_sol.common.WfUtils.js
//@include lib_sol.common.Template.js

var logger = sol.create("sol.Logger", { scope: "holme.common.ix.functions.StartWorkflow" });

/**
 * Starts a Workflow
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.Config
 * @requires sol.common.WfUtils
 * @requires sol.common.ix.FunctionBase
 * @requires sol.common.Template
 */
sol.define("holme.common.ix.functions.StartWorkflow", {
  extend: "sol.common.ix.FunctionBase",
  
  requiredConfig: ["objId", "templFlowId", "flowName"],

  /** 
   * @cfg {int} objId The Object on which the workflow should be started
   */
  objId: undefined,

  /** 
   * @cfg {String} templFlowId Name or ID of the template which should be started
   */
  templFlowId: undefined,

  /** 
   * @cfg {String} flowName Name of the new workflow
   */  
  flowName: undefined,
  
  /**
   * @cfg {String} targetId (optional) If set the the workflow will be started to this objId. Will be templated first.
   */
  targetId: undefined,

  /**
   * @cfg {Number (optional)} prio If specified, the workflow priority will be changed (0=high, 1=medium, 2=low)
   */
  prio: undefined,

  initialize: function (config) {
    var me = this;
    me.$super("sol.common.ix.FunctionBase", "initialize", [config]);
    me.prio = me.prio || 1;
    me.flowName = sol.common.WfUtils.getServiceWfPrefix() + me.flowName;
  },

  /**
   * Starts a Workflow
   */
  process: function () {
    var me = this,
        tpl, sord;
    
    if (me.targetId) {
      sord = ixConnectAdmin.ix().checkoutSord(me.objId, SordC.mbLean, LockC.NO);            
      tpl = sol.create("sol.common.Template", {
        source: me.targetId
      });
      me.targetId = tpl.applySord(sord);
    } else {
      me.targetId = me.objId;
    }

    logger.info(["Starting Workflow (Template={0}) (Name={1}) (objid={2})", me.templFlowId, me.flowName, me.targetId]);
    ixConnectAdmin.ix().startWorkFlow(me.templFlowId, me.flowName, me.targetId);
  }

});

/**
 * @member holme.common.ix.functions.StartWorkflow
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onExitNode
 */
function onExitNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onExitNode_StartWorkflow", { 
    flowId: wfDiagram.id, 
    nodeId: nodeId 
  });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId), 
      module;
  config.objId = wfDiagram.objId;

  module = sol.create("holme.common.ix.functions.StartWorkflow", config);
  module.process();

  logger.exit("onExitNode_StartWorkflow");
}

/**
 * @member holme.common.ix.functions.StartWorkflow
 * @method RF_holme_common_function_StartWorkflow
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.RF_FunctionName
 */
function RF_holme_common_function_StartWorkflow(ec, configAny) {
  logger.enter("RF_holme_common_function_StartWorkflow", configAny);
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny),
      module;

  module = sol.create("holme.common.ix.functions.StartWorkflow", config);
  module.process();

  logger.exit("RF_holme_common_function_StartWorkflow");
}
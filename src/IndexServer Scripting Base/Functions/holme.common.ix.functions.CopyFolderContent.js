
importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.FunctionBase.js
//@include lib_sol.common.IxUtils.js
//@include lib_sol.common.RepoUtils.js


var logger = sol.create("sol.Logger", { scope: "holme.common.ix.functions.CopyFolderContent" });

/**
 * Copies whole folder recursively
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.Config
 * @requires sol.common.IxUtils.js
 * @requires sol.common.ix.FunctionBase
 * @requires sol.common.RepoUtils.js
 */
sol.define("holme.common.ix.functions.CopyFolderContent", {
  extend: "sol.common.ix.FunctionBase",
  
  requiredConfig: ["path"],
    
  /**
   * @cfg {String} path Path to Source to copy from
   */

  /**
   * @property {int} src ObjectID of the Folder of 'path'
   */

  initialize: function (config) {
    var me = this;
    me.$super("sol.common.ix.FunctionBase", "initialize", [config]);
    me.src = sol.common.RepoUtils.getObjId(me.path);
  },

  /**
   * Copies whole folder recursively
   */
  process: function () {
    var me = this;
    sol.common.IxUtils.execute("RF_sol_function_CopyFolderContents", {
      objId: me.objId,
      source: me.src,
      copySourceAcl: false,
      inheritDestinationAcl: true,
      asAdmin: true
    });
  }
});

/**
 * @member holme.common.ix.functions.CopyFolderContent
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onExitNode
 */
function onExitNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onExitNode_CopyFolderContent", { 
    flowId: wfDiagram.id, 
    nodeId: nodeId 
  });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId),
      module;

  config.objId = wfDiagram.objId;
  module = sol.create("holme.common.ix.functions.CopyFolderContent", config);
  module.process();

  logger.exit("onExitNode_CopyFolderContent");
}

/**
 * @member holme.common.ix.functions.CopyFolderContent
 * @method RF_holme_common_function_CopyFolderContent
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.RF_FunctionName
 */
function RF_holme_common_function_CopyFolderContent(ec, configAny) {
  logger.enter("RF_holme_common_function_CopyFolderContent", configAny);
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), 
      module;

  module = sol.create("holme.common.ix.functions.CopyFolderContent", config);
  module.process();

  logger.exit("RF_holme_common_function_CopyFolderContent");
}
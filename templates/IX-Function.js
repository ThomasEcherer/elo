
importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.FunctionBase.js


var logger = sol.create("sol.Logger", { scope: "{{namespace}}.ix.functions.{{className}}" });

/**
 * {{description}}
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.Config
 */
sol.define("{{namespace}}.ix.functions.{{className}}", {
  extend: "sol.common.ix.FunctionBase",
  
  //requiredConfig: [],

  
  /** 
   * @cfg {Type} exampleCfg
   */

  
  /**
   * @private
   * @property {Type} exampleProperty
   */

  initialize: function (config) {
    var me = this;
    me.$super("sol.common.ix.FunctionBase", "initialize", [config]);
    
  },

  /**
   * {{description}}
   */
  process: function () {
    var me = this;
    // do your processing //
  }

  

});

/**
 * @member {{namespace}}.ix.functions.{{className}}
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onEnterNode
 */
function onEnterNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onEnterNode_{{className}}", { flowId: wfDiagram.id, nodeId: nodeId });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId), 
      module;

  
  config.objId = wfDiagram.objId;
  module = sol.create("{{namespace}}.ix.functions.{{className}}", config);

  module.process();

  logger.exit("onEnterNode_{{className}}");
}

/**
 * @member {{namespace}}.ix.functions.{{className}}
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onExitNode
 */
function onExitNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onExitNode_{{className}}", { flowId: wfDiagram.id, nodeId: nodeId });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId),
      module;

  config.objId = wfDiagram.objId;
  module = sol.create("{{namespace}}.ix.functions.{{className}}", config);

  module.process();

  logger.exit("onExitNode_{{className}}");
}

/**
 * @member {{namespace}}.ix.functions.{{className}}
 * @method RF_{{namespaceWithUnderscores}}_function_{{className}}
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.RF_FunctionName
 */
function RF_{{namespaceWithUnderscores}}_function_{{className}}(ec, configAny) {
  logger.enter("RF_{{namespaceWithUnderscores}}_function_{{className}}", configAny);
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), 
      module;

  module = sol.create("{{namespace}}.ix.functions.{{className}}", config);
  module.process();

  logger.exit("RF_{{namespaceWithUnderscores}}_function_{{className}}");
}

importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.ActionBase.js


var logger = sol.create("sol.Logger", { scope: "{{namespace}}.ix.actions.{{className}}" });

/**
 * {{description}}
 * 
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 * 
 * @eloix
 * @requires sol.common.JsonUtils
 * @requires sol.common.SordUtils
 * @requires sol.common.IxUtils
 * @requires sol.common.CounterUtils
 * @requires sol.common.TranslateTerms
 * @requires sol.common.WfUtils
 * @requires sol.common.ix.RfUtils
 * @requires sol.common.ix.ActionBase
 */
sol.define("{{namespace}}.ix.actions.{{className}}", {
  extend: "sol.common.ix.ActionBase",
  
  //requiredConfig: [],

  // configuration section //
  /** 
   * @cfg {Type} exampleCfg
   */

  // property section //
  /**
   * @private
   * @property {Type} exampleProperty
   */

  initialize: function (config) {
    var me = this;
    me.$super("sol.common.ix.ActionBase", "initialize", [config]);
    // do your initialization //
  },

  /**
   * Returns the name of this action.
   * @return {String}
   */
  getName: function () {
    return "{{className}}";
  },

  /**
   * {{description}}
   */
  process: function () {
    var me = this;
    // do your processing //
    me.addErrorEvent("This is just an example, this action has no implementaion yet");
  }

  // add your internal methods //

});

/**
 * @member {{namespace}}.ix.actions.{{className}}
 * @method RF_{{namespaceWithUnderscores}}_action_{{className}}
 * @static
 * @inheritdoc sol.common.ix.ActionBase.RF_FunctionName
 */
function RF_{{namespaceWithUnderscores}}_action_{{className}}(ec, configAny) {
  var config, action, result;

  logger.enter("RF_{{namespaceWithUnderscores}}_action_{{className}}", configAny);
  config = sol.common.ix.RfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny);
  action = sol.create("{{namespace}}.ix.actions.{{className}}", config);
  result = action.execute();

  logger.exit("RF_{{namespaceWithUnderscores}}_action_{{className}}");

  return result;
}
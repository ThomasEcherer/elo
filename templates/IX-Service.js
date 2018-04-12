
importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.ServiceBase.js

var logger = sol.create("sol.Logger", { scope: "{{namespace}}.ix.services.{{className}}" });

/**
 * {{description}}
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.JsonUtils
 * @requires sol.common.ix.RfUtils
 * @requires sol.common.ix.ServiceBase
 */
sol.define("{{namespace}}.ix.services.{{className}}", {
  extend: "sol.common.ix.ServiceBase",

  
  //requiredConfig: [],

  
  // property section //
  /**
   * @private
   * @property {Type} exampleProperty
   */

  initialize: function (config) {
    var me = this;
    me.$super("sol.common.ix.ServiceBase", "initialize", [config]);
    // do your initialization //
  },

  /**
   * {{description}}
   */
  process: function () {
    var me = this;
    
    return { hallo: "welt" };

  }

  

});

/**
 * @member {{namespace}}.ix.services.{{className}}
 * @method RF_{{namespaceWithUnderscores}}_service_{{className}}
 * @static
 * @inheritdoc sol.common.ix.ServiceBase.RF_ServiceBaseName
 */
function RF_{{namespaceWithUnderscores}}_service_{{className}}(ec, configAny) {
  var rfUtils = sol.common.ix.RfUtils,
      config, service, result;

  logger.enter("RF_{{namespaceWithUnderscores}}_service_{{className}}", configAny);

  config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), // you might add required properties here

  //config.ci = ec.ci;
  //config.user = ec.user;

  service= sol.create("{{namespace}}.ix.services.{{className}}", config);
  result = rfUtils.stringify(service.process());

  logger.exit("RF_{{namespaceWithUnderscores}}_service_{{className}}");

  return result;
}
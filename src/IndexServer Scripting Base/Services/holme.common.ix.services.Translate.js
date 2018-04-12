
importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.ServiceBase.js
//@include lib_sol.common.TranslateTerms.js

var logger = sol.create("sol.Logger", { scope: "holme.common.ix.services.Translate" });

/**
 * Translates a key with sol.common.TranslateTerms
 * This is used for elo-forms to translate Texts
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.JsonUtils
 * @requires sol.common.ix.RfUtils
 * @requires sol.common.ix.ServiceBase
 * @requires sol.common.TranslateTerms
 */
sol.define("holme.common.ix.services.Translate", {
  extend: "sol.common.ix.ServiceBase",
  
  requiredConfig: ["resource", "language", "key"],

  /**
   * @property {String} resource Name of t he Resource to load
   */
  resource: undefined,

  /**
   * @property {String} language The language to translate to
   */
  language: undefined,

  /**
   * @property {String} key The Key to translate
   */
  key: undefined,

  initialize: function (config) {
    var me = this;
    me.$super("sol.common.ix.ServiceBase", "initialize", [config]);    
  },

  /**
   * Translates a key with sol.common.TranslateTerms
   * @returns {Object} The translated key as json object
   */
  process: function () {
    var me = this;
    
    sol.common.TranslateTerms.require(me.resource);
    return { value: sol.common.TranslateTerms.getTerm(me.language, me.key) };    
  }

});

/**
 * @member holme.common.ix.services.Translate
 * @method RF_holme_common_service_Translate
 * @static
 * @inheritdoc sol.common.ix.ServiceBase.RF_ServiceBaseName
 */
function RF_holme_common_service_Translate(ec, configAny) {
  var rfUtils = sol.common.ix.RfUtils,
      config, service, result;

  logger.enter("RF_holme_common_service_Translate", configAny);

  config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny);
  service = sol.create("holme.common.ix.services.Translate", config);
  result = rfUtils.stringify(service.process());

  logger.exit("RF_holme_common_service_Translate");

  return result;
}
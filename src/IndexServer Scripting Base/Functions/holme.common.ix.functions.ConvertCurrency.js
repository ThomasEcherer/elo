
importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.FunctionBase.js
//@include lib_sol.common.Template.js
//@include lib_sol.common.IxUtils.js
//@include lib_sol.common.ExceptionUtils.js
//@include lib_sol.common_fx.ix.FxUtils.js


var logger = sol.create("sol.Logger", { scope: "holme.common.ix.functions.ConvertCurrency" });

/**
 * Converts an amount of currency A and sets the result into some field
 * 
 * # Example Configuration for RF-Call
 * 
 * sol.common.IxUtils.execute("RF_holme_common_function_ConvertCurrency",
 *  {
 *    "objId": "3785",
 *	  "useTemplating": "true",
 *	  "amount": "{{sord.objKeys.VALUE_1}}",
 *	  "fromCurrency": "{{sord.objKeys.CURRENCY_1}}",
 *	  "setConfig": {
 *		  "type": "GRP",
 *		  "key": "VALUE_2"
 *    }
 * });
 * 
 * # Example Configuration for WF-Node-USe
 * 
 * {
 *	  "useTemplating": "true",
 *	  "amount": "{{sord.objKeys.VALUE_1}}",
 *	  "fromCurrency": "{{sord.objKeys.CURRENCY_1}}",
 *	  "setConfig": {
 *		  "type": "GRP",
 *		  "key": "VALUE_2"
 *    }
 * }
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.Config
 * @requires sol.common.Template
 * @requires sol.common.IxUtils
 * @requires sol.common_fx.ix.FxUtils
 */
sol.define("holme.common.ix.functions.ConvertCurrency", {
  extend: "sol.common.ix.FunctionBase",
  
  requiredConfig: ["amount", "fromCurrency", "setConfig"],

  /**
   * @cfg
   * @property {String} objId The ID of the Object the workflow is attached to
   */
  objId: undefined,

  /**
   * @cfg
   * @property {Number} amount The Amount to convert ("1337" or "{{sord.objKeys.XXX}}"")
   */
  amount: undefined,

  /**
   * @cfg
   * @property {String} fromCurrency The Currency to convert from. ("USD", "EUR", .. or {{sord.objKeys.XXX}} )
   */
  fromCurrency: undefined,

  /**
   * @cfg
   * @property {String} toCurrency The Currency to convert to ("USD", "EUR", .. or {{sord.objKeys.XXX}} ), Default is "EUR"
   */
  toCurrency: "EUR",

  /**
   * @cfg
   * @property {Object} setConfig The Config to set the converted amount
   * @property {String} setConfig.type Type what to write (SORD|GRP|MAP)
   * @property {String} setConfig.key Name of the Key to write
   */
  setConfig: undefined,

  /**
   * @cfg
   * @property {boolean} useTemplating (optional) Determines if templating should be used
   */
  useTemplating: false,  

  /**
   * @cfg
   * @property {Int|Number} frac (optional) Determines how many digits after the comma the converted value should have. Default is 2
   */
  frac: 2,


  initialize: function (config) {
    var me = this;
    me.$super("sol.common.ix.FunctionBase", "initialize", [config]);    
  },

  /**
   * Converts an amount of currency A and sets the result into some field
   */
  process: function () {
    var me = this;
  
    //  Use Templating 
    if (me.useTemplating) {
      me.templating();
    }

    //  Convert the value
    logger.info(["Converting Amount={0} from Currency {1} into currency {2}", me.amount, me.fromCurrency, me.toCurrency]);
    me.setConfig.value = sol.common_fx.ix.FxUtils.convertAmount(me.amount, me.fromCurrency, me.toCurrency).result;
    me.setConfig.value = me.round(me.setConfig.value, me.frac);
        
    //  Write the converted amount
    logger.info(["Write converted Value {0} into type={1} / key={2}", me.setConfig.value, me.setConfig.type, me.setConfig.key]);
    sol.common.IxUtils.execute("RF_sol_function_Set", { objId: me.objId, entries: [me.setConfig] });
   
  },

  /**
   * @private
   * Uses Templating to get the parameters values
   */
  templating: function () {
    var me = this,
        tpl, sord;

    sord = ixConnectAdmin.ix().checkoutSord(me.objId, SordC.mbLean, LockC.NO);
    
    tpl = sol.create("sol.common.Template", { source: me.amount });    
    me.amount = tpl.applySord(sord);
    
    tpl = sol.create("sol.common.Template", { source: me.fromCurrency });    
    me.fromCurrency = tpl.applySord(sord);
    
    tpl = sol.create("sol.common.Template", { source: me.toCurrency });    
    me.toCurrency = tpl.applySord(sord);
  },

  /**
   * Rounds the value to given number of digits after comma.
   * 
   * @param {number} value The Value to rund
   * @param {number} frac Determines how many digits after the comma are allowed
   * @returns {Number} The rounded value
   */
  round: function (value, frac) {
    return Math.round(Math.pow(10.0, frac) * value) / Math.pow(10.0, frac);
  }

});

/**
 * @member holme.common.ix.functions.ConvertCurrency
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onEnterNode
 */
function onEnterNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onEnterNode_ConvertCurrency", { flowId: wfDiagram.id, nodeId: nodeId });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId), 
      module;

  
  config.objId = wfDiagram.objId;
  module = sol.create("holme.common.ix.functions.ConvertCurrency", config);
  module.process();

  logger.exit("onEnterNode_ConvertCurrency");
}

/**
 * @member holme.common.ix.functions.ConvertCurrency
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onExitNode
 */
function onExitNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onExitNode_ConvertCurrency", { flowId: wfDiagram.id, nodeId: nodeId });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId),
      module;

  config.objId = wfDiagram.objId;
  module = sol.create("holme.common.ix.functions.ConvertCurrency", config);
  module.process();

  logger.exit("onExitNode_ConvertCurrency");
}

/**
 * @member holme.common.ix.functions.ConvertCurrency
 * @method RF_holme_common_function_ConvertCurrency
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.RF_FunctionName
 */
function RF_holme_common_function_ConvertCurrency(ec, configAny) {
  logger.enter("RF_holme_common_function_ConvertCurrency", configAny);
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), 
      module;

  module = sol.create("holme.common.ix.functions.ConvertCurrency", config);
  module.process();

  logger.exit("RF_holme_common_function_ConvertCurrency");
}
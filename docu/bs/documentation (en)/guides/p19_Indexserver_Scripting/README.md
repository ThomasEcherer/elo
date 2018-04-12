<h1>Indexserver scripting </h1>
<p>The following shows some best practice methods for creating functions with the help of the ELO Indexserver.</p>
<h2>IX function (function module)</h2>
<p>Where possible, Indexserver functions should be implemented as <code>sol.common.ix.FunctionBase</code>. This ensures that the implemented function can be called as a workflow module as well as independently via the IX interface.</p>
<pre><code>importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.FunctionBase.js
// further includes

var logger = sol.create(&quot;sol.Logger&quot;, { scope: &quot;{{namespace}}.ix.functions.{{className}}&quot; });

/**
 * {{description}}
 *
 * @author {{author}}, {{company}}
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.Config
 * @requires sol.common.ConfigMixin
 * @requires sol.common.ObjectUtils.js
 * @requires sol.common.StringUtils.js
 * @requires sol.common.JsonUtils.js
 * @requires sol.common.RepoUtils.js
 * @requires sol.common.WfUtils.js
 * @requires sol.common.ix.RfUtils.js
 * @requires sol.common.ix.FunctionBase
 */
sol.define(&quot;{{namespace}}.ix.functions.{{className}}&quot;, {
  extend: &quot;sol.common.ix.FunctionBase&quot;,

  // you might add required configuration here //
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
    me.$super(&quot;sol.common.ix.FunctionBase&quot;, &quot;initialize&quot;, [config]);
    // do your initialization //
  },

  /**
   * {{description}}
   */
  process: function () {
    var me = this;
    // do your processing //
  }

  // add your internal methods //

});

/**
 * @member {{namespace}}.ix.functions.{{className}}
 * @static
 * @inheritdoc sol.common.ix.FunctionBase#onEnterNode
 */
function onEnterNode(ci, userId, wfDiagram, nodeId) {
  logger.enter(&quot;onEnterNode_{{className}}&quot;, { &quot;flowId&quot;: wfDiagram.id, &quot;nodeId&quot;: nodeId });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId), // you might add required properties here
      module;

  // These might be usefull in your class //
  //config.objId = wfDiagram.objId;
  //config.ci = ci;
  module = sol.create(&quot;{{namespace}}.ix.functions.{{className}}&quot;, config);

  module.process();

  logger.exit(&quot;onEnterNode_{{className}}&quot;);
}

/**
 * @member {{namespace}}.ix.functions.{{className}}
 * @static
 * @inheritdoc sol.common.ix.FunctionBase#onExitNode
 */
function onExitNode(ci, userId, wfDiagram, nodeId) {
  logger.enter(&quot;onExitNode_{{className}}&quot;, { &quot;flowId&quot;: wfDiagram.id, &quot;nodeId&quot;: nodeId });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId), // you might add required properties here
      module;

  // These might be usefull in your class //
  //config.objId = wfDiagram.objId;
  //config.ci = ci;
  module = sol.create(&quot;{{namespace}}.ix.functions.{{className}}&quot;, config);

  module.process();

  logger.exit(&quot;onExitNode_{{className}}&quot;);
}

/**
 * @member {{namespace}}.ix.functions.{{className}}
 * @method RF_{{namespaceWithUnderscores}}_function_{{className}}
 * @static
 * @inheritdoc sol.common.ix.FunctionBase#RF_FunctionName
 */
function RF_{{namespaceWithUnderscores}}_function_{{className}}(ec, configAny) {
  logger.enter(&quot;RF_{{namespaceWithUnderscores}}_function_{{className}}&quot;, configAny);
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), // you might add required properties here
      module;

  // These might be usefull in your class //
  //config.ci = ec.ci;
  //config.user = ec.user;

  module = sol.create(&quot;{{namespace}}.ix.functions.{{className}}&quot;, config);
  module.process();

  logger.exit(&quot;RF_{{namespaceWithUnderscores}}_function_{{className}}&quot;);
}
</code></pre>
<h2>IX action</h2>
<pre><code>importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.ActionBase.js
// further includes

var logger = sol.create(&quot;sol.Logger&quot;, { scope: &quot;{{namespace}}.ix.actions.{{className}}&quot; });

/**
 * {{description}}
 * 
 * @author {{author}}, {{company}}
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
sol.define(&quot;{{namespace}}.ix.actions.{{className}}&quot;, {
  extend: &quot;sol.common.ix.ActionBase&quot;,

  // you might add required configuration here //
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
    me.$super(&quot;sol.common.ix.ActionBase&quot;, &quot;initialize&quot;, [config]);
    // do your initialization //
  },

  /**
   * Returns the name of this action.
   * @return {String}
   */
  getName: function () {
    return &quot;{{className}}&quot;;
  },

  /**
   * {{description}}
   */
  process: function () {
    var me = this;
    // do your processing //
    me.addErrorEvent(&quot;This is just an example, this action has no implementaion yet&quot;);
  }

  // add your internal methods //

});

/**
 * @member {{namespace}}.ix.actions.{{className}}
 * @method RF_{{namespaceWithUnderscores}}_action_{{className}}
 * @static
 * @inheritdoc sol.common.ix.ActionBase#RF_FunctionName
 */
function RF_{{namespaceWithUnderscores}}_action_{{className}}(ec, configAny) {
  var config, action, result;

  logger.enter(&quot;RF_{{namespaceWithUnderscores}}_action_{{className}}&quot;, configAny);

  config = sol.common.ix.RfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), // you might add required properties here

  // These might be usefull in your class //
  //config.ci = ec.ci;
  //config.user = ec.user;

  action = sol.create(&quot;{{namespace}}.ix.actions.{{className}}&quot;, config);
  result = action.execute();

  logger.exit(&quot;RF_{{namespaceWithUnderscores}}_action_{{className}}&quot;);

  return result;
}
</code></pre>
<h2>IX service</h2>
<p>Where possible, Indexserver functions that return data or require further processing of data should be implemented as <code>sol.common.ix.ServiceBase</code>. </p>
<pre><code>importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.ServiceBase.js

var logger = sol.create(&quot;sol.Logger&quot;, { scope: &quot;{{namespace}}.ix.services.{{className}}&quot; });

/**
 * {{description}}
 *
 * @author {{author}}, {{company}}
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.JsonUtils
 * @requires sol.common.ix.RfUtils
 * @requires sol.common.ix.ServiceBase
 */
sol.define(&quot;{{namespace}}.ix.services.{{className}}&quot;, {
  extend: &quot;sol.common.ix.ServiceBase&quot;,

  // you might add required configuration here //
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
    me.$super(&quot;sol.common.ix.ServiceBase&quot;, &quot;initialize&quot;, [config]);
    // do your initialization //
  },

  /**
   * {{description}}
   */
  process: function () {
    var me = this;
    // do your processing //
    return { hallo: &quot;welt&quot; };

  }

  // add your internal methods //

});

/**
 * @member {{namespace}}.ix.services.{{className}}
 * @method RF_{{namespaceWithUnderscores}}_service_{{className}}
 * @static
 * @inheritdoc sol.common.ix.ServiceBase#RF_ServiceBaseName
 */
function RF_{{namespaceWithUnderscores}}_service_{{className}}(ec, configAny) {
  var rfUtils = sol.common.ix.RfUtils,
      config, service, result;

  logger.enter(&quot;RF_{{namespaceWithUnderscores}}_service_{{className}}&quot;, configAny);

  config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), // you might add required properties here

  // These might be usefull in your class //
  //config.ci = ec.ci;
  //config.user = ec.user;

  service= sol.create(&quot;{{namespace}}.ix.services.{{className}}&quot;, config);
  result = rfUtils.stringify(service.process());

  logger.exit(&quot;RF_{{namespaceWithUnderscores}}_service_{{className}}&quot;);

  return result;
}
</code></pre>
<h2>Dynamic keyword lists</h2>
<p>Dynamic keyword lists should be implemented with the help of the <code>sol.common.ix.DynKwlDatabaseIterator</code> class. This encapsulates basic requirements for handling databases and is easy to configure.</p>
<pre><code>importPackage(Packages.de.elo.ix.jscript);
importPackage(Packages.de.elo.ix.scripting);

//@include lib_Class.js.js
//@include lib_sol.common.ix.DynKwlDatabaseIterator.js

/**
 * Dynamic keyword list that queries the recipients database.
 *
 * The list of current fields is returned as a table.
 *
 * |Name|Key|Example data|
 * |:-----|:------|:------|
 * |Company Code|COMPANY_NO|122|
 * |Name|COMPANY_NAME|ELO Digital Office GmbH|
 * |Street|COMPANY_ADDRESS_STREET|TuebingerStr. 34|
 * |Zip code|COMPANY_ADDRESS_ZIPCODE|70178|
 * |City|COMPANY_ADDRESS_CITY|Stuttgart|
 * |Country|COMPANY_ADDRESS_COUNTRY|DE|
 *
 * Limits results to COMPANY_NO.
 *
 * @author {{author}}, {{company}}
 * @version 1.00.000
 */
sol.define('sol.invoice.ix.dynkwl.Company', {
  extends: 'sol.common.ix.DynKwlDatabaseIterator',
  /**
   * @cfg
   * @inheritdoc
   */
  tableTitle: 'Company',
  /**
   * @cfg
   * @inheritdoc
   */
  sqlQuery: &quot;select CODE, NAME, STREET, ZIPCODE, CITY, COUNTRY_CODE from sol_invoice_company where CODE like ? OR NAME like ?&quot;,
  /**
   * @cfg
   * @inheritdoc
   */
  sqlParams: [
    {mode: 'STARTS_WITH'},
    {mode: 'CONTAINS'}
  ],
  /**
   * @cfg
   * @inheritdoc
   */
  tableKeyNames: [&quot;COMPANY_CODE&quot;, &quot;COMPANY_NAME&quot;, null, null, null, null],
  //tableKeyNames: [&quot;COMPANY_CODE&quot;, &quot;COMPANY_NAME&quot;, &quot;COMPANY_ADDRESS_STREET&quot;, &quot;COMPANY_ADDRESS_ZIPCODE&quot;, &quot;COMPANY_ADDRESS_CITY&quot;, &quot;COMPANY_ADDRESS_COUNTRY&quot;],
  /**
   * @cfg
   * @inheritdoc
   */
  tableHeaders: [&quot;Nummer&quot;, &quot;Name&quot;, &quot;Stra&szlig;e&quot;, &quot;PLZ&quot;, &quot;Ort&quot;, &quot;Land&quot;]
});

/**
 * @static
 * @member sol.invoice.ix.dynkwl.Company
 * Implements a DynamicKeywordDataProvider for this keyword list that can be used by checkoutKeywordsDynamic.
 * @returns {DynamicKeywordDataProvider}
 */
function getDataIterator() {
  var log = sol.create(&quot;sol.Logger&quot;, {scope: &quot;sol.invoice.ix.dynkwl.Company&quot;}),
    iterator;
  try {
    log.info(&quot;DynamicKeywordList (&quot;);
    iterator = sol.create('sol.invoice.ix.dynkwl.Company', {});
    return new DynamicKeywordDataProvider(iterator);
  } finally {
    log.info(&quot;)getDataIterator&quot;);
  }
}
</code></pre>

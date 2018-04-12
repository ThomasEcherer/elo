<h1>Example: Extended action</h1>
<p><span class="tag_important">The implementation of the &quot;Create contract&quot; function is described in the following. </span></p>
<p>This consists of the following components:</p>
<ul>
<li>Definition of the action</li>
<li>Implementation of a service for determining the available file types</li>
<li>Implementation of the action in the Indexserver</li>
<li>ELO workflow</li>
<li>ELO form</li>
</ul>
<p>The user selects a contract in ELO and clicks &quot;Start approval&quot; on the ribbon. </p>
<p><span class="tag_warning">The action can be triggered without a context. This means that contracts can be created anywhere in ELO as the user does not need to select a parent element.</span></p>
<p>{@img img1.png}</p>
<p>{@img img3.png}</p>
<p>This opens a form in which the user can select who should check the contract next and add optional comments.</p>
<p>{@img img5.png}</p>
<h2>Definition of the action</h2>
<pre><code>{
  &quot;type&quot;: &quot;ADVANCED_ACTION&quot;,
  &quot;ribbon&quot;: {
    &quot;ribbonTab&quot;: {
      &quot;name&quot;: &quot;TAB_SOL_CONTRACT&quot;,
      &quot;text&quot;: &quot;sol.contract.client.ribbon.tabContract&quot;,
      &quot;position&quot;: 95
    },
    &quot;buttongroup&quot;: {
      &quot;name&quot;: &quot;GRP_SOL_CONTRACT_CREATE&quot;,
      &quot;mode&quot;: &quot;big&quot;,
      &quot;text&quot;: &quot;sol.contract.client.ribbon.bandCreate&quot;,
      &quot;position&quot;: 10
    },
    &quot;button&quot;: {
      &quot;name&quot;: &quot;BTN_SOL_CONTRACT_CREATECONTRACT&quot;,
      &quot;text&quot;: &quot;sol.contract.client.ribbon.btnCreateContract&quot;,
      &quot;splitText&quot;: &quot;sol.contract.client.ribbon.btnCreateContractSplit&quot;,
      &quot;tooltipText&quot;: &quot;sol.contract.client.ribbon.btnCreateContract.tooltip&quot;,
      &quot;tooltipTitle&quot;: &quot;&quot;,
      &quot;access&quot;: {
        &quot;document&quot;: true,
        &quot;folder&quot;: true
      },
      &quot;web&quot;: {
        &quot;iconName&quot;: &quot;sol-contract-createcontract&quot;,
        &quot;smallIcon&quot;: &quot;sol-contract-createcontract16&quot;,
        &quot;smallIconHighRes&quot;: &quot;sol-contract-createcontract16-200&quot;,
        &quot;bigIcon&quot;: &quot;sol-contract-createcontract32&quot;,
        &quot;bigIconHighRes&quot;: &quot;sol-contract-createcontract32-200&quot;
      },
      &quot;jc&quot;: {
        &quot;buttonId&quot;: &quot;728&quot;
      },
      &quot;position&quot;: 10,
      &quot;asTile&quot;: true
    }
  },
  &quot;action&quot;: {
    &quot;selectType&quot;: {
      &quot;fct&quot;: &quot;RF_sol_contract_service_GetContractTypes&quot;
    },
    &quot;fct&quot;: &quot;RF_sol_contract_action_CreateContract&quot;,
    &quot;cfgTemplate&quot;: &quot;{\&quot;contractType\&quot;: \&quot;{{type.name}}\&quot;, \&quot;templateId\&quot;: \&quot;{{type.objId}}\&quot; }&quot;,
    &quot;locale&quot;: {
      &quot;errorDlgTitle&quot;: &quot;sol.pubsec.client.file.create.dialog.error.title&quot;,
      &quot;typesDlgTitle&quot;: &quot;sol.contract.client.contract.create.dialog.title&quot;,
      &quot;typesDlgHeader&quot;: &quot;sol.contract.client.contract.create.dialog.header&quot;,
      &quot;typesDlgText&quot;: &quot;sol.contract.client.contract.create.dialog.text&quot;,
      &quot;typesDlgNoTypes&quot;: &quot;sol.contract.client.contract.create.msg.notype&quot;
    }
  }
}
</code></pre>
<h2>Indexserver implementation of the action</h2>
<p>The implementation of the action loads the configuration file in ELO. The client must first select a template ID.  </p>
<p>The form for the first user node that is assigned to the current user is then determined and returned to the client as an event. The client is also instructed to create a goTo for the newly created element.</p>
<pre><code>importPackage(Packages.de.elo.ix.client);
importPackage(Packages.de.elo.ix.jscript);

//@include lib_Class.js
//@include lib_sol.common.Config.js
//@include lib_sol.common.JsonUtils.js
//@include lib_sol.common.SordUtils.js
//@include lib_sol.common.IxUtils.js
//@include lib_sol.common.WfUtils.js
//@include lib_sol.common.CounterUtils.js
//@include lib_sol.common.AclUtils.js
//@include lib_sol.common.RepoUtils.js
//@include lib_sol.common.Template.js
//@include lib_sol.common.TranslateTerms.js
//@include lib_sol.common.ix.RfUtils.js
//@include lib_sol.common.ix.ActionBase.js
//@include lib_sol.common.ix.FunctionBase.js
//@include lib_sol.contract.ix.ContractUtils.js


/**
 * Creates a new new contract.
 * 
 * @eloix
 * @requires sol.common.Config
 * @requires sol.common.JsonUtils
 * @requires sol.common.SordUtils
 * @requires sol.common.IxUtils
 * @requires sol.common.CounterUtils
 * @requires sol.common.AclUtils
 * @requires sol.common.RepoUtils
 * @requires sol.common.Template
 * @requires sol.common.TranslateTerms
 * @requires sol.common.WfUtils
 * @requires sol.common.ix.RfUtils
 * @requires sol.common.ix.ActionBase
 * @requires sol.common.ix.FunctionBase
 * @requires sol.common.ix.functions.CopyFolderContents
 * @requires sol.common.ix.functions.CopySordData
 * @requires sol.common.ContractUtils
 */
sol.define(&quot;sol.contract.ix.actions.CreateContract&quot;, {
  extend: &quot;sol.common.ix.ActionBase&quot;,

  requiredConfig: [&quot;ci&quot;, &quot;user&quot;, &quot;contractType&quot;],

  /** 
   * @cfg {de.elo.ix.client.ClientInfo} ci (required)
   */

  /** 
   * @cfg {de.elo.ix.client.UserInfo} user (required)
   */

  /**
   * @cfg {String} templateId (required)
   * Object ID of the template
   */

  initialize: function (config) {
    var me = this;
    me.$super(&quot;sol.common.ix.ActionBase&quot;, &quot;initialize&quot;, [config]);
    me.config = sol.contract.ix.ContractUtils.loadConfig();
  },

  getName: function () {
    return &quot;CreateContract&quot;;
  },

  process: function () {
    var me = this,
        name, objId, flowId, sord,
        objectType;

    if (!me.templateId) {
      me.addErrorEvent(&quot;sol.contract.ix.actions.CreateContract.error.target&quot;, null, null, me.ci);
      return;
    }

    name = me.buildElementName();

    objId = sol.common.IxUtils.execute(&quot;RF_sol_function_CopyFolderContents&quot;, {
      objId: &quot;0&quot;,
      source: me.templateId,
      copySourceAcl: false,
      inheritDestinationAcl: false,
      name: me.contractType + &quot; - &quot; + me.getTimeStampString(),
      asAdmin: true
    });

    sord = sol.common.RepoUtils.getSord(objId);

    objectType = me.config.objectTypes[0];

    sol.common.SordUtils.setObjKeyValue(sord, me.config.fields.objectType, objectType);
    sol.common.SordUtils.setObjKeyValue(sord, me.config.fields.contractType, me.contractType);
    ixConnect.ix().checkinSord(sord, SordC.mbAllIndex, LockC.NO);

    flowId = me.startMaskStandardWorkflow(objId, { name: name, field: me.config.fields.defaultWorkflow });

    if (flowId) {
      me.addWfDialogEvent(flowId, { objId: objId, title: name });
    }

    me.addGotoIdEvent(objId);
  },

  /**
   * @private
   */
  buildElementName: function () {
    var me = this,
        prefix;

    prefix = me.getLocalizedString(me.ci, me.config.workflows.createContract.workflowPrefixKey);
    return sol.create(&quot;sol.common.Template&quot;, { source: me.config.workflows.createContract.workflowNameTemplate }).apply({ wfPrefix: prefix, contractType: me.contractType });
  },

  /**
   * @private
   */
  getTimeStampString: function () {
    return String(Packages.org.apache.commons.lang.time.DateFormatUtils.format(new java.util.Date(), &quot;yyyyMMddHHmmss&quot;));
  },
});

/**
 * @member sol.contract.ix.actions.CreateContract
 * @method RF_sol_contract_action_CreateContract
 * @static
 * @inheritdoc sol.common.ix.FunctionBase#RF_FunctionName
 */
function RF_sol_contract_action_CreateContract(ec, configAny) {
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny, &quot;contractType&quot;, &quot;templateId&quot;),
      createContract;

  config.ci = ec.ci;
  config.user = ec.user;

  createContract = sol.create(&quot;sol.contract.ix.actions.CreateContract&quot;, config);
  return createContract.execute();
}
</code></pre>
<h2>Indexserver implementation of the service for determining the contract types</h2>
<p>The template for the contract in the configuration area determines the contract type. This template is copied when the contract is created. Predefined metadata and contract file structures can be imported.</p>
<p>{@img img7.png}</p>
<p>Contract files are filed to the chaos folder and moved to the correct position later on in the workflow.</p>
<pre><code>importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.Config.js
//@include lib_sol.common.JsonUtils.js
//@include lib_sol.common.SordUtils.js
//@include lib_sol.common.RepoUtils.js
//@include lib_sol.common.TranslateTerms.js
//@include lib_sol.common.ix.RfUtils.js
//@include lib_sol.common.ix.ServiceBase.js
//@include lib_sol.contract.ix.ContractUtils.js

/**
 * Retrieves the available contract types.
 *
 * @author JHR, ELO Digital Office GmbH
 *
 * @eloix
 * @requires sol.common.Config
 * @requires sol.common.JsonUtils
 * @requires sol.common.SordUtils
 * @requires sol.common.RepoUtils
 * @requires sol.common.TranslateTerms
 * @requires sol.common.ix.RfUtils
 * @requires sol.common.ix.ServiceBase
 * @requires sol.contract.ix.ContractUtils
 */
sol.define(&quot;sol.contract.ix.services.GetContractTypes&quot;, {
  extend: &quot;sol.common.ix.ServiceBase&quot;,

  initialize: function (config) {
    var me = this;
    me.$super(&quot;sol.common.ix.ServiceBase&quot;, &quot;initialize&quot;, [config]);
    me.config = sol.contract.ix.ContractUtils.loadConfig();
  },

  /**
   * Retrieves the data as spezified in the constructor configuration.
   * @returns {String[]} Array with contract types
   */
  process: function () {
    var me = this,
        searchConfig = {},
        contractTemplates;

    searchConfig.includeFolders = true;
    searchConfig.includeDocuments = false;
    searchConfig.includeReferences = true;
    searchConfig.sordZ = SordC.mbAllIndex;

    contractTemplates = sol.common.RepoUtils.findChildren(me.config.templateFolderId, searchConfig);
    return me.convertTemplateSords(contractTemplates);
  },

  /**
   * @private
   * Converts from Sords to Objects
   * @param {de.elo.ix.client.Sord[]} reportTemplateSords
   * @returns {Object[]}
   */
  convertTemplateSords: function (reportTemplateSords) {
    var converted = [];
    if (reportTemplateSords) {
      reportTemplateSords.forEach(function (sord) {
        converted.push({
          objId: sord.id,
          name: sord.name,
          desc: sord.desc
        });
      });
    }
    return converted;
  }
});

/**
 * @member sol.contract.ix.services.GetContractTypes
 * @method RF_sol_common_service_GetContractTypes
 * @static
 * @inheritdoc sol.common.ix.ServiceBase#RF_ServiceBaseName
 */
function RF_sol_contract_service_GetContractTypes(iXSEContext, args) {
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(iXSEContext, arguments.callee.name, args),
      service;

  service = sol.create(&quot;sol.contract.ix.services.GetContractTypes&quot;, config);
  return rfUtils.stringify(service.process());
}
</code></pre>
<h2>ELO workflow</h2>
<p>The first user node contains a form that the user can enter all contract data to. The user can select from the <span
style='font-weight:bold'>OK</span> and <span style='font-weight:bold'>Cancel</span> forwarding options later on. If the user cancels the action, the previously created contract object will be deleted.</p>
<p>{@img img9.png}</p>
<h2>Form</h2>
<p>This list can be extended or changed as much as you wish. ELO Business Solutions use tab groups to modularize the form logic further.</p>
<p>{@img img11.png}</p>
<p>The following example is an illustration of the <code>110_contract_general_all</code> contract template.</p>
<p>{@img img13.png}</p>
<h2>Localization</h2>
<p>All localization keys are stored in properties files. For example, the <code>sol.contract.client.ribbon.btnCreateContract</code> key.</p>

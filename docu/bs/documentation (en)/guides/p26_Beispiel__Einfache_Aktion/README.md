<h1>Example: Simple action</h1>
<p><span class="tag_important">The implementation of the &quot;Approve contract&quot; function is described in the following. </span></p>
<p>This consists of the following components:</p>
<ul>
<li>Definition of the action</li>
<li>Implementation of the action in the Indexserver</li>
<li>ELO workflow</li>
<li>ELO form</li>
</ul>
<p>The user selects a contract in ELO and clicks &quot;Start approval&quot; on the ribbon. </p>
<p>{@img img1.png}</p>
<p>This opens a form in which the user can select who should check the contract next and add optional comments.</p>
<p>{@img img3.png}</p>
<h2>Definition of the action</h2>
<pre><code>{
  &quot;type&quot;: &quot;SIMPLE_ACTION&quot;,
  &quot;ribbon&quot;: {
    &quot;ribbonTab&quot;: {
      &quot;name&quot;: &quot;TAB_SOL_CONTRACT&quot;,
      &quot;text&quot;: &quot;sol.contract.client.ribbon.tabContract&quot;,
      &quot;position&quot;: 95
    },
    &quot;buttongroup&quot;: {
      &quot;name&quot;: &quot;GRP_SOL_EDITCONTRACTS&quot;,
      &quot;mode&quot;: &quot;big&quot;,
      &quot;text&quot;: &quot;sol.contract.client.ribbon.bandEdit&quot;,
      &quot;position&quot;: 20
    },
    &quot;button&quot;: {
      &quot;name&quot;: &quot;BTN_SOL_CONTRACTINITATEAPPROVAL&quot;,
      &quot;text&quot;: &quot;sol.contract.client.ribbon.btnInitiateApproval&quot;,
      &quot;splitText&quot;: &quot;sol.contract.client.ribbon.btnInitiateApprovalSplit&quot;,
      &quot;tooltipText&quot;: &quot;sol.contract.client.ribbon.btnInitiateApproval.tooltip&quot;,
      &quot;tooltipTitle&quot;: &quot;&quot;,
      &quot;access&quot;: {
        &quot;document&quot;: false,
        &quot;folder&quot;: true
      },
      &quot;web&quot;: {
        &quot;smallIcon&quot;: &quot;sol-contract-initateapproval16&quot;,
        &quot;smallIconHighRes&quot;: &quot;sol-contract-initateapproval16-200&quot;,
        &quot;bigIcon&quot;: &quot;sol-contract-initateapproval32&quot;,
        &quot;bigIconHighRes&quot;: &quot;sol-contract-initateapproval32-200&quot;
      },
      &quot;jc&quot;: {
        &quot;buttonId&quot;: &quot;729&quot;
      },
      &quot;position&quot;: 10
    }
  },
  &quot;action&quot;: {
    &quot;fct&quot;: &quot;RF_sol_contract_action_ApproveContract&quot;,
    &quot;cfgTemplate&quot;: &quot;{\&quot;objId\&quot;: \&quot;{{objId}}\&quot; }&quot;
  }
}
</code></pre>
<h2>Indexserver implementation</h2>
<p>The implementation of the action loads the configuration file in ELO and, if the currently selected element is not a contract, searches the parent elements for a contract. This is required as contracts may contain child structures.</p>
<p>The form for the first user node that is assigned to the current user is then determined and returned to the client as an event.</p>
<pre><code>importPackage(Packages.de.elo.ix.client);
importPackage(Packages.de.elo.ix.jscript);

//@include lib_Class.js
//@include lib_sol.common.Config.js
//@include lib_sol.common.JsonUtils.js
//@include lib_sol.common.SordUtils.js
//@include lib_sol.common.IxUtils.js
//@include lib_sol.common.WfUtils.js
//@include lib_sol.common.RepoUtils.js
//@include lib_sol.common.SordTypeUtils.js
//@include lib_sol.common.Template.js
//@include lib_sol.common.TranslateTerms.js
//@include lib_sol.common.ix.RfUtils.js
//@include lib_sol.common.ix.ActionBase.js
//@include lib_sol.common.ix.FunctionBase.js
//@include lib_sol.contract.ix.ContractUtils.js

/**
 * Approve a contract
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
sol.define(&quot;sol.contract.ix.actions.ApproveContract&quot;, {
  extend: &quot;sol.common.ix.ActionBase&quot;,

  requiredConfig: [&quot;ci&quot;, &quot;user&quot;, &quot;objId&quot;],

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
    return &quot;InitateApproval&quot;;
  },

  process: function () {
    var me = this,
        contractSord, contractConfig, contractObjId,
        wfPrefix, wfNumber, wfName,
        flowId;

    contractConfig = sol.contract.ix.ContractUtils.loadConfig();
    contractSord = sol.common.RepoUtils.findObjectTypeInHierarchy(me.objId, contractConfig.objectTypes);
    if (!contractSord) {
      me.addErrorEvent(&quot;sol.contract.client.contract.msg.noContractFoundInHierarchy&quot;, &quot;&quot;, &quot;&quot;, me.ci.language);
      return;
    }

    contractObjId = contractSord.id;

    wfPrefix = me.getLocalizedString(me.ci, contractConfig.workflows.approveContract.workflowPrefixKey);
    wfNumber = me.actionId;
    wfName = sol.create(&quot;sol.common.Template&quot;, { source: contractConfig.workflows.approveContract.workflowNameTemplate }).apply({ wfPrefix: wfPrefix, wfDate: new Date(), wfNumber: wfNumber });

    flowId = me.startWorkflow(contractObjId, contractConfig.workflows.approveContract.workflowTemplateName, wfName);

    me.addWfDialogEvent(flowId, { objId: contractObjId });
  }
});

/**
 * @member sol.contract.ix.actions.ApproveContract
 * @method RF_sol_contract_action_ApproveContract
 * @static
 * @inheritdoc sol.common.ix.FunctionBase#RF_FunctionName
 */
function RF_sol_contract_action_ApproveContract(ec, configAny) {
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny, &quot;objId&quot;),
      approveContract;

  config.ci = ec.ci;
  config.user = ec.user;

  approveContract = sol.create(&quot;sol.contract.ix.actions.ApproveContract&quot;, config);
  return approveContract.execute();
}
</code></pre>
<h2>ELO workflow</h2>
<p>The first user node contains a form that the person approving the contract can enter information to. The user can select from the <span
style='font-weight:bold'>OK</span> and <span style='font-weight:bold'>Cancel</span> forwarding options later on.</p>
<p>{@img img5.png}</p>
<h2>Form</h2>
<p>This list can be extended or changed as much as you wish. ELO Business Solutions use tab groups to modularize the form logic further.</p>
<p>{@img img7.png}</p>
<p>{@img img9.png}</p>
<h2>Localization</h2>
<p>All localization keys, such as <code>sol.contract.client.ribbon.btnInitiateApproval</code>, are stored in properties files.</p>

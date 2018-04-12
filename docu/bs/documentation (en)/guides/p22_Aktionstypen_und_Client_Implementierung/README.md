<h1>Action types and client implementation</h1>
<p>Actions describe the server-side technical process. Additional information may be required to execute an action. These are transferred from the client to the server.</p>
<h2>Simple actions (SIMPLE_ACTION)</h2>
<p>These describe actions that the client does not need to configure preconditions for in advance. In the simplest scenario, an action is started when the user selects an element in the repository.</p>
<p>If the action returns events, the client will then run these.</p>
<blockquote>
<p><span
style='font-style:italic'>Example: The &quot;Contract concluded&quot; function marks a contract as concluded and signed off. To do this, the contract must be selected in ELO. The status of the contract in the workflow, the color of the element and a feed post are set server-side.</p>
</blockquote>
<p>{@img img1.png}</p>
<p><span
style='font-weight:bold'>Below is the excerpt from the <code>action definition</code>:</span></p>
<p>This takes place as an Indexserver action using the <code>registered function</code> <code>RF_sol_contract_action_ContractConcluded</code>. </p>
<p>A <code>cfgTemplate</code> is used to transfer the required information to the action. This must create a valid JSON object which can be used in the action. The object ID of the currently selected element can be accessed in the template using <code>{{objId}}</code> (see also <a
href="#!/guide/p25_Aktionslogik__Server_">action logic</a>).</p>
<pre><code>  &quot;action&quot;: {
    &quot;fct&quot;: &quot;RF_sol_contract_action_ContractConcluded&quot;,
    &quot;cfgTemplate&quot;: &quot;{\&quot;objId\&quot;: \&quot;{{objId}}\&quot; }&quot;
  }
</code></pre>
<h2>Advanced actions (ADVANCED_ACTION)</h2>
<p>Clients can also be instructed to carry out additional steps <span
style='font-weight:bold'>before an action is triggered</span>.</p>
<h3>Select type</h3>
<p>The <code>Create contract</code> function lets the user select from a number of different types of contract. The type that is selected is then transferred to the action.</p>
<p><span class="tag_important">This option enables the user to select the type from a flat list.</span></p>
<p>{@img img3.png}</p>
<p>{@img img5.png}</p>
<p>This requires an Indexserver serive that returns a list (<code>array</code>) of contract types. The name and description are shown in a selection dialog box in the client.</p>
<p>{@img img7.png}</p>
<p>To transfer the values to the action, the selected entry and all data can be accessed in the <code>cfgTemplate</code>. Example: <code>{{type.name}}</code> returns the name of the selected type. Localization information is also required for the type selection dialog box.</p>
<pre><code>{
  &quot;type&quot;: &quot;ADVANCED_ACTION&quot;,
  &quot;ribbon&quot;: {&lt;br&gt;
   &hellip;
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
<h3>Selection of an element in ELO</h3>
<p>The <code>Create document</code> function lets the user select from a number of document templates that are stored in ELO, for example. The element that is selected is then transferred to the action.</p>
<p><span class="tag_important">The tree selection enables the user to select an entry from a subcategory of ELO.</p>
<p>{@img img9.png}</p>
<p>{@img img11.png}</p>
<p>To transfer the values to the action, the selected entry and all data can be accessed in the <code>cfgTemplate</code>. Example: <code>{{tree.objId}}</code> returns the object ID of the selected element. Localization information is also required for the tree selection dialog box.</p>
<pre><code>{
  &quot;type&quot;: &quot;ADVANCED_ACTION&quot;,
  &quot;ribbon&quot;: {
    &hellip;
  },
  &quot;action&quot;: {
    &quot;selectTree&quot;: {
       &quot;rootFromCfgFile&quot;: &quot;ARCPATH:/Administration/Business Solutions/contract/Configuration/contract.Config&quot;,
       &quot;rootFromCfgProperty&quot;: &quot;\&quot;{{config.document.templateFolderId}}\&quot;&quot;
    },
    &quot;fct&quot;: &quot;sol.contract.as.actions.PrepareDocument&quot;,
    &quot;type&quot;: &quot;AS&quot;,
    &quot;solution&quot;: &quot;contract&quot;,
    &quot;cfgTemplate&quot;: &quot;{\&quot;parentId\&quot;: \&quot;{{objId}}\&quot;, \&quot;templateId\&quot;: \&quot;{{tree.objId}}\&quot; }&quot;,
    &quot;locale&quot;: {
      &quot;errorDlgTitle&quot;: &quot;sol.pubsec.client.filecoversheet.dialog.noTemplates&quot;,
      &quot;treeDlgTitle&quot;: &quot;sol.contract.client.document.selectTemplate.title&quot;,
      &quot;treeDlgHeader&quot;: &quot;sol.contract.client.document.selectTemplate.text&quot;
    }
  }
}
</code></pre>
<p>Internal process</p>
<p><span class="tag_warning">The following documentation serves to give users a better understanding of the client-side internal process.</span></p>
<p>Standardizing the internal process means it is possible to provide actions in the ELO Web Client and ELO Java Client without a great deal of implementation work. The <code>sol.common.web.ActionDefinitionUtils</code> class, which registers buttons in the Web Client, for example, passes on the definition of the action to helper functions, which handle preconditions such as type selection.</p>
<p>SIMPLE_ACTION: sol.common.web.ActionHelper#executeSimpleAction
ADVANCED_ACTION: sol.common.web.ActionHelper#executeAdvancedAction</p>
<p>The <code>sol.common.jc.ActionHandler</code> and <code>sol.common.web.ActionHandler</code> classes subsequently execute the ELO Indexserver or ELOas action and takes care of handling the returned events.</p>
<h3>Exceptions</h3>
<p>In special situations, it may be necessary not to trigger an action via the <code>action definition</code>. In such cases, actions can be called directly from scripts. This enables the user to respond to specific requirements. The following examples show how to call actions directly using the ActionHandler. It should be noted that this still processes the returned events.</p>
<p><span
style='font-weight:bold'>Java Client </span></p>
<pre><code>//@include lib_Class.js

sol.define(&quot;sol.pubsec.jc.FilingPlan&quot;, {
  singleton: true,

  startChangeRequest: function (parentId) {
    // specific Java Client scripting  
    sol.common.jc.ActionHandler.execute(&quot;RF_sol_pubsec_action_FilingPlanChangeRequest&quot;, {&quot;objId&quot;: parentId});
  }

});
</code></pre>
<p><span
style='font-weight:bold'>Web Client </span></p>
<pre><code>(function () {
  sol.define(&quot;sol.pubsec.web.FilingPlan&quot;, {
    singleton: true,

    startChangeRequest : function (parentId) {            
      // specific Web Client scripting            
      sol.common.web.ActionHandler.execute(&quot;RF_sol_pubsec_action_FilingPlanChangeRequest&quot;, {&quot;objId&quot;: parentId});
    }
  });
}());
</code></pre>

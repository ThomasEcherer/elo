<h1>Definition (action definition)</h1>
<p>The primary objective of the action concept is that it enables users to do without custom client scripting. This is the only way to ensure that the same function is available in the Web Client and the Java Client.</p>
<p><span class="tag_important">An action therefore does not have a client script. The definition for the ribbon and the button is configured in the Administration folder. This configuration also contains information such as what the client needs to do to execute the action.</span></p>
<p>{@img img1.png}</p>
<h2>Structure of the ribbon in the client</h2>
<p>The Web Client and Java Client load a list of available actions during startup. The ribbon, amongst other things, is created based on the configuration for each action.
<br>
This action is carried out by the sol.common.jc.ActionDefinitionUtils (Java Client) and sol.common.web.ActionDefinitionUtils (Web Client) classes. The Indexserver service <code>sol.common.ix.services.RibbonDefinitionCollector</code> collects all actions. <span
style='font-weight:bold'>This also ensures that all texts </span><a
href="#!/guide/p23_Lokalisierung"><span
style='font-weight:bold'>are localized server-side.</span></p>
<p><span class="tag_warning">This method also improves performance as it is possible to reduce the number of scripts required during startup.</span></p>
<h2>Restricting what users can see</h2>
<p>It is also possible to use ELO permissions to control which functions are available to users on the ribbon. </p>
<p><span class="tag_important">This enables you to define for each action within a solution which group can see the entire contract management tab or just individual solutions.</span></p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>An example:</span><span
style='font-style:italic'> Every user that has read access to the <code>sol.contract.CreateContract</code> function sees the corresponding button on the ribbon.</span></p>
</blockquote>
<h2>Sample configuration for a simple action</h2>
<p>The configuration consists of the underlying client implementation (action type), the definition of the ribbon, and the information for executing the action.</p>
<h3>Action type</h3>
<p>There are various types of actions. There are a number of implementations (<a
href="#!/guide/p22_Aktionstypen_und_Client_Implementierung"><span
style='font-weight:bold'>action types</span></a>) available in the clients. The following example illustrates a <code>SIMPLE_ACTION</code>. An <code>ADVANCED_ACTION</code> can be used for creating a dialog box that enables the user to select a type of action, for example.</p>
<h3>Definition of the ribbon:</h3>
<p>This describes which button, which tab or button groups are required. The concepts are geared toward the scripting possibilities for the Web Client and the Java Client. The following example also shows how interface texts can be <a
href="#!/guide/p23_Lokalisierung">localized</a> using <code>locale keys</code>. </p>
<p>An additional <code>splitText</code> must be specified for the button in the Java Client. This contains a line break in case texts are too long. Example: &quot;Create&lt;br/&gt;contract&quot;.</p>
<h3>Instructions for executing the action</h3>
<p>The client executes the action when the user clicks the button. The corresponding handler is evaluated based on the action type. Refer to the documentation on <a
href="#!/guide/p22_Aktionstypen_und_Client_Implementierung">action types</a> for more information.</p>
<h3>Example of an Indexserver action</h3>
<p><span class="tag_important">There will also be an interface for configuring the actions in the foreseeable future so that users will no longer need to process JSON objects.</span></p>
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
<h3>Example of an ELOas action</h3>
<p>If an action is implemented as an ELOas rule, this must be specified in the definition using <span
style='font-weight:bold'>&quot;type&quot;: &quot;AS&quot;</span>. </p>
<p>As different ELOas instances can be responsible for different rules, the name of the solution is also required. The Web Client and Java Client search for an ELOas configuration (<code>as.config</code>) within the corresponding solution package. If there is no specific ELOas configuration in the solution package then the <code>Common</code> package is always used. </p>
<p>{@img img3.png}</p>
<pre><code>{
  &quot;type&quot;: &quot;ADVANCED_ACTION&quot;,
  &quot;ribbon&quot;: {
    &hellip;
  },
  &quot;action&quot;: {
    &quot;fct&quot;: &quot;sol.contract.as.actions.PrepareDocument&quot;,
    &quot;type&quot;: &quot;AS&quot;,
    &quot;solution&quot;: &quot;contract&quot;,
    &quot;cfgTemplate&quot;: &quot;{\&quot;parentId\&quot;: \&quot;{{objId}}\&quot;, \&quot;templateId\&quot;: \&quot;{{tree.objId}}\&quot; }&quot;,
    &hellip;
  }
}
</code></pre>

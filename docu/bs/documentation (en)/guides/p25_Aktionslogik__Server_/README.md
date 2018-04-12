<h1>Action logic (server)</h1>
<p>The actual action logic is implemented as an Indexserver script or ELOas rule. The <code>sol.common.ix.ActionBase</code> and <code>sol.common.as.ActionBase</code> classes provide a base implementation that contains basic functions. <span
style='font-weight:bold'>Where possible, logic should always be implemented server-side. </span></p>
<p>Each action should only implement the basic requirements such as creating a folder that the workflow can be started on. The actual technical sequence of functions, such as writing a feed post, changing the color of a node, or starting a process for entering additional data, has to be implemented in the workflow diagram via function modules. </p>
<p><span class="tag_important">There is an example of how an action is implemented in the guidelines for <a
href="#!/guide/p19_Indexserver_Scripting">Indexserver scripting</a></span>.</p>
<h2>Implementation of an action in the Indexserver</h2>
<p>Indexserver actions can be easily implemented with the help of the <code>sol.common.ix.ActionBase</code> class. This provides basic functions for handling clients. The <code>getName</code> and <code>process</code> functions must be implemented. The <code>process</code> code is called internally by the action once it has been triggered.</p>
<p><span class="tag_important">Clients can then call the Indexserver action via <code>registered functions</code>. The Indexserver programming guide contains further information on this.</span></p>
<p>The following is an abstracted implementation of the <span
style='font-weight:bold;font-style:italic'>Approve contract</span> function with which a user form is shown in the client.</p>
<pre><code>sol.define(&quot;sol.contract.ix.actions.ApproveContract&quot;, {
  extend: &quot;sol.common.ix.ActionBase&quot;,

  getName: function () {
    return &quot;InitateApproval&quot;;
  },

  process: function () {
    var me = this,
        flowId;

    flowId = me.startWorkflow(me.objId, &quot;sol.contract.ix.actions.ApproveContract&quot;, &quot;Approval Workflow&quot;);

    me.addWfDialogEvent(flowId, { objId: me.objId });
  }
});

function RF_sol_contract_action_ApproveContract(ec, configAny) {
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny, &quot;objId&quot;),
      approveContract;

  approveContract = sol.create(&quot;sol.contract.ix.actions.ApproveContract&quot;, config);
  return approveContract.execute();
}
</code></pre>
<h3>Access to values that are transferred by the clients.</h3>
<p>Clients transfer a number of configuration values for the action, such as the object ID of the currently selected element. The <code>cfgTemplate</code> of the <code>action definition</code> controls which information the client transfers to the action (see also <a
href="#!/guide/p22_Aktionstypen_und_Client_Implementierung">action types</a>). </p>
<p>At this point, the Indexserver Scripting API works with any objects that need to be converted in Java Script. This is carried out by the <code>sol.common.ix.RfUtils#parseAndCheckParams</code> helper function. Configuration values are subsequently transferred when the (<code>sol.create</code>) class is instantiated.</p>
<p>These are available in the object when the action is implemented (e.g. in the <code>process</code> function). (See also <a
href="#!/guide/p13_Klassenframework">class framework</a>). The object ID that is transferred can be accessed via <code>this.objId</code>, for example.</p>
<p><span class="tag_important">This means that the client can transfer arbitrary values to the action so that an action can be used for different buttons.</span></p>
<h3>Returning client events</h3>
<table><thead><tr><td>Name</td><td>Utility function</td><td>Description</td></tr></thead><tbody><tr><td>Show form in the dialog box</td><td>sol.common.ActionBase#addWfDialogEvent</td><td>The current user node can be determined with the help of the workflow ID. <br />The client then shows the user form in a dialog box.</td></tr><tr><td>Show website in dialog box</td><td>sol.common.ActionBase#addUrlDialogEvent</td><td>For more complex scenarios, the client can be instructed to show a website via a dialog box.<br />This can be helpful for loading ELO apps or integrating external developments.</td></tr><tr><td>Call another action</td><td>sol.common.ActionBase#addActionEvent</td><td>It may be necessary to concatenate actions in exceptions. <br />In this case, the client calls another action when the last one is completed. <br />This mechanism is used for actions such as creating documents from templates.</td></tr><tr><td>Reload an entry</td><td>sol.common.ActionBase#addRefreshEvent</td><td>Instructs the client to refresh an element.</td></tr><tr><td>Call goTo for an event</td><td>sol.common.ActionBase#addGotoIdEvent</td><td>Instructs the client to trigger a goTo in the repository. The newly created element is displayed in most cases.</td></tr><tr><td>Call goTo for a task</td><td>sol.common.ActionBase#addGotoTaskEvent</td><td>Instructs the client to trigger a task.</td></tr><tr><td>Returns an error</td><td>sol.common.ActionBase#addErrorEvent</td><td>Returns an error message.</td></tr><tr><td>Show feedback</td><td>sol.common.ActionBase#addFeedbackEvent</td><td>Instructs the client to show a (temporary) status message</td></tr></tbody></table>

<p><span
style='font-weight:bold'>The process is then as follows:</span></p>
<ol>
<li>The client calls the <code>RF_sol_contract_action_ApproveContract</code> <code>registered function</code>.</li>
<li>This generates a <code>sol.contract.ix.actions.ApproveContract</code> action object and calls <code>execute()</code>.</li>
<li>The <code>execute()</code> function prepares everything for executing the action, calls the actual implementation <code>process()</code> and prepares the data for transfer to the client. All events that have been added are also collected and returned at this point.</li>
</ol>
<p>The <code>sol.commonActionBase</code> class documentation contains a list of the <code>ActionBase</code> functions.</p>

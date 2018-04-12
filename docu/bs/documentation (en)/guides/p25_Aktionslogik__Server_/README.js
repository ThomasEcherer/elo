Ext.data.JsonP.p25_Aktionslogik__Server_({"guide":"<h1 id='p25_Aktionslogik__Server_-section-action-logic-%28server%29'>Action logic (server)</h1>\n\n\n<p>The actual action logic is implemented as an Indexserver script or ELOas rule. The <code><a href=\"#!/api/sol.common.ix.ActionBase\" rel=\"sol.common.ix.ActionBase\" class=\"docClass\">sol.common.ix.ActionBase</a></code> and <code><a href=\"#!/api/sol.common.as.ActionBase\" rel=\"sol.common.as.ActionBase\" class=\"docClass\">sol.common.as.ActionBase</a></code> classes provide a base implementation that contains basic functions. <span\nstyle='font-weight:bold'>Where possible, logic should always be implemented server-side. </span></p>\n\n\n<p>Each action should only implement the basic requirements such as creating a folder that the workflow can be started on. The actual technical sequence of functions, such as writing a feed post, changing the color of a node, or starting a process for entering additional data, has to be implemented in the workflow diagram via function modules. </p>\n\n\n<p><span class=\"tag_important\">There is an example of how an action is implemented in the guidelines for <a\nhref=\"#!/guide/p19_Indexserver_Scripting\">Indexserver scripting</a></span>.</p>\n\n\n<h2 id='p25_Aktionslogik__Server_-section-implementation-of-an-action-in-the-indexserver'>Implementation of an action in the Indexserver</h2>\n\n\n<p>Indexserver actions can be easily implemented with the help of the <code><a href=\"#!/api/sol.common.ix.ActionBase\" rel=\"sol.common.ix.ActionBase\" class=\"docClass\">sol.common.ix.ActionBase</a></code> class. This provides basic functions for handling clients. The <code>getName</code> and <code>process</code> functions must be implemented. The <code>process</code> code is called internally by the action once it has been triggered.</p>\n\n\n<p><span class=\"tag_important\">Clients can then call the Indexserver action via <code>registered functions</code>. The Indexserver programming guide contains further information on this.</span></p>\n\n\n<p>The following is an abstracted implementation of the <span\nstyle='font-weight:bold;font-style:italic'>Approve contract</span> function with which a user form is shown in the client.</p>\n\n\n<pre><code><a href=\"#!/api/sol-static-method-define\" rel=\"sol-static-method-define\" class=\"docClass\">sol.define</a>(&quot;sol.contract.ix.actions.ApproveContract&quot;, {\n  extend: &quot;<a href=\"#!/api/sol.common.ix.ActionBase\" rel=\"sol.common.ix.ActionBase\" class=\"docClass\">sol.common.ix.ActionBase</a>&quot;,\n\n  getName: function () {\n    return &quot;InitateApproval&quot;;\n  },\n\n  process: function () {\n    var me = this,\n        flowId;\n\n    flowId = me.startWorkflow(me.objId, &quot;sol.contract.ix.actions.ApproveContract&quot;, &quot;Approval Workflow&quot;);\n\n    me.addWfDialogEvent(flowId, { objId: me.objId });\n  }\n});\n\nfunction RF_sol_contract_action_ApproveContract(ec, configAny) {\n  var rfUtils = <a href=\"#!/api/sol.common.ix.RfUtils\" rel=\"sol.common.ix.RfUtils\" class=\"docClass\">sol.common.ix.RfUtils</a>,\n      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny, &quot;objId&quot;),\n      approveContract;\n\n  approveContract = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(&quot;sol.contract.ix.actions.ApproveContract&quot;, config);\n  return approveContract.execute();\n}\n</code></pre>\n\n\n<h3 id='p25_Aktionslogik__Server_-section-access-to-values-that-are-transferred-by-the-clients.'>Access to values that are transferred by the clients.</h3>\n\n\n<p>Clients transfer a number of configuration values for the action, such as the object ID of the currently selected element. The <code>cfgTemplate</code> of the <code>action definition</code> controls which information the client transfers to the action (see also <a\nhref=\"#!/guide/p22_Aktionstypen_und_Client_Implementierung\">action types</a>). </p>\n\n\n<p>At this point, the Indexserver Scripting API works with any objects that need to be converted in Java Script. This is carried out by the <code><a href=\"#!/api/sol.common.ix.RfUtils-method-parseAndCheckParams\" rel=\"sol.common.ix.RfUtils-method-parseAndCheckParams\" class=\"docClass\">sol.common.ix.RfUtils.parseAndCheckParams</a></code> helper function. Configuration values are subsequently transferred when the (<code><a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a></code>) class is instantiated.</p>\n\n\n<p>These are available in the object when the action is implemented (e.g. in the <code>process</code> function). (See also <a\nhref=\"#!/guide/p13_Klassenframework\">class framework</a>). The object ID that is transferred can be accessed via <code>this.objId</code>, for example.</p>\n\n\n<p><span class=\"tag_important\">This means that the client can transfer arbitrary values to the action so that an action can be used for different buttons.</span></p>\n\n\n<h3 id='p25_Aktionslogik__Server_-section-returning-client-events'>Returning client events</h3>\n\n\n<table><thead><tr><td>Name</td><td>Utility function</td><td>Description</td></tr></thead><tbody><tr><td>Show form in the dialog box</td><td><a href=\"#!/api/sol.common.ActionBase-method-addWfDialogEvent\" rel=\"sol.common.ActionBase-method-addWfDialogEvent\" class=\"docClass\">sol.common.ActionBase.addWfDialogEvent</a></td><td>The current user node can be determined with the help of the workflow ID. <br />The client then shows the user form in a dialog box.</td></tr><tr><td>Show website in dialog box</td><td><a href=\"#!/api/sol.common.ActionBase-method-addUrlDialogEvent\" rel=\"sol.common.ActionBase-method-addUrlDialogEvent\" class=\"docClass\">sol.common.ActionBase.addUrlDialogEvent</a></td><td>For more complex scenarios, the client can be instructed to show a website via a dialog box.<br />This can be helpful for loading ELO apps or integrating external developments.</td></tr><tr><td>Call another action</td><td><a href=\"#!/api/sol.common.ActionBase-method-addActionEvent\" rel=\"sol.common.ActionBase-method-addActionEvent\" class=\"docClass\">sol.common.ActionBase.addActionEvent</a></td><td>It may be necessary to concatenate actions in exceptions. <br />In this case, the client calls another action when the last one is completed. <br />This mechanism is used for actions such as creating documents from templates.</td></tr><tr><td>Reload an entry</td><td><a href=\"#!/api/sol.common.ActionBase-method-addRefreshEvent\" rel=\"sol.common.ActionBase-method-addRefreshEvent\" class=\"docClass\">sol.common.ActionBase.addRefreshEvent</a></td><td>Instructs the client to refresh an element.</td></tr><tr><td>Call goTo for an event</td><td><a href=\"#!/api/sol.common.ActionBase-method-addGotoIdEvent\" rel=\"sol.common.ActionBase-method-addGotoIdEvent\" class=\"docClass\">sol.common.ActionBase.addGotoIdEvent</a></td><td>Instructs the client to trigger a goTo in the repository. The newly created element is displayed in most cases.</td></tr><tr><td>Call goTo for a task</td><td>sol.common.ActionBase#addGotoTaskEvent</td><td>Instructs the client to trigger a task.</td></tr><tr><td>Returns an error</td><td><a href=\"#!/api/sol.common.ActionBase-method-addErrorEvent\" rel=\"sol.common.ActionBase-method-addErrorEvent\" class=\"docClass\">sol.common.ActionBase.addErrorEvent</a></td><td>Returns an error message.</td></tr><tr><td>Show feedback</td><td><a href=\"#!/api/sol.common.ActionBase-method-addFeedbackEvent\" rel=\"sol.common.ActionBase-method-addFeedbackEvent\" class=\"docClass\">sol.common.ActionBase.addFeedbackEvent</a></td><td>Instructs the client to show a (temporary) status message</td></tr></tbody></table>\n\n\n\n\n<p><span\nstyle='font-weight:bold'>The process is then as follows:</span></p>\n\n\n<ol>\n<li>The client calls the <code>RF_sol_contract_action_ApproveContract</code> <code>registered function</code>.</li>\n<li>This generates a <code>sol.contract.ix.actions.ApproveContract</code> action object and calls <code>execute()</code>.</li>\n<li>The <code>execute()</code> function prepares everything for executing the action, calls the actual implementation <code>process()</code> and prepares the data for transfer to the client. All events that have been added are also collected and returned at this point.</li>\n</ol>\n\n\n<p>The <code>sol.commonActionBase</code> class documentation contains a list of the <code>ActionBase</code> functions.</p>\n\n","title":"Action logic (server)"});
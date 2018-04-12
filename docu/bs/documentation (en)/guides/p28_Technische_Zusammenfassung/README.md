<h1>Technical summary</h1>
<p>A number of helper and handler classes ensure that the action concept is implemented properly. The following summarizes the process to give you a general overview.</p>
<h2>Client startup</h2>
<p>An action is described via an <code>action definition</code>. This definition contains information for the ribbon as well as for executing the action. The sol.common.jc.ActionDefinitionUtils (Java Client) and sol.common.web.ActionDefinitionUtils (Web Client) classes build the ribbon with the help of the <code>sol.common.ix.services.RibbonDefinitionCollector</code> service.</p>
<h2>Executing an action in the client</h2>
<p>The <code>ActionDefinitionUtils</code> transfers information for executing an action to the <code>ActionHelper</code>. This executes preconditions and then calls the action handler. There are currently two implementations available:</p>
<p><span
style='font-weight:bold'>SIMPLE_ACTION</span>: sol.common.web.ActionHelper#executeSimpleAction
<span
style='font-weight:bold'>ADVANCED_ACTION</span>: sol.common.web.ActionHelper#executeAdvancedAction</p>
<p>The <code>sol.common.jc.ActionHandler</code> and <code>sol.common.web.ActionHandler</code> classes subsequently execute the ELO Indexserver or ELOas action and takes care of handling the returned events.</p>
<h2>Server implementation</h2>
<p>The action logic is implemented as an Indexserver script or ELOas rule. The <code>sol.common.ix.ActionBase</code> and <code>sol.common.as.ActionBase</code> classes provide helper functions as well as a base implementation. The client calls the underlying <code>registered function</code> or ELOas rule. </p>
<p>An action can start a workflow on the server to model the technical process. The action can also return events server-side which the client then has to process once they are running.</p>

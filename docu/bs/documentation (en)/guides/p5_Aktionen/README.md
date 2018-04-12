<h1>Actions</h1>
<p>The primary objective of actions is to modularize interaction with the user. Actions are generally called via a function (e.g. a button). An action can also instruct the client what to do next.</p>
<p><span class="tag_important">The main objective of the action concept is to do without client scripting as far as possible and provide functions in the ELO Web Client and the ELO Java Client.</span></p>
<p>Actions are mainly functions that are available as buttons on the ribbon. This can be functions such as <span
style='font-weight:bold'>Create contract</span>, <span style='font-weight:
bold'>Create file</span>, <span style='font-weight:bold'>Conclude contract</span> or <span
style='font-weight:bold'>Create document from template</span>. The following figures shows ten different actions from the contract management solution.</p>
<p>{@img img1.png}</p>
<p>The entire process from starting the client to completion of an action is as follows:</p>
<h3>Definition and process client-side:</h3>
<p>During startup, all available actions are determined and the ribbon is set up. <a
href="#!/guide/p21_Definition__Action_definition_">Configuration objects (action definitions)</a> that deliver the information to the client that is necessary for triggering an action are used for this purpose.</p>
<p>The client calls the action when the user clicks a button on the ribbon, for example. This is then implemented server-side as a function in the ELO Indexserver or ELOas. When the action is completed, the server returns a series of <a
href="#!/guide/">events</a> instructing the client what to do next. The client will then run these.</p>
<p>There are various options in the client for collecting information. For example, when the &quot;Create contract&quot; action is executed, the users will be shown a list of contract types to select from. See also <a
href="#!/guide/p22_Aktionstypen_und_Client_Implementierung">action types</a>.</p>
<h3>Definition and process server-side:</h3>
<p>The core function of the action (implementation in Indexserver and ELOas) is to trigger <span
style='font-weight:bold'>basic tasks</span> such as <span
style='font-weight:bold'>creating a new element</span> in ELO and checking the conditions. A workflow is then triggered for the new element, mapping the technical process with the help of <a
href="#!/guide/p6_Funktionsbausteine">function modules</a>.</p>
<p><span class="tag_warning">This way, the user can see what the action does without having to refer to the code. This is also the only way to ensure <span
style='font-weight:bold'>that extensions of functions and bug fixes can be implemented without any problem later on. It also means that the user can configure the technical process.</span></span></p>
<p>After the workflow is triggered, the action then compiles a list of <a
href="#!/guide/">events</a> instructing the client what to do next. These events were standardized and are available in the Java Client and the Web Client.</p>
<h3>Import example</h3>
<p><span class="tag_important">To summarize, an action can be said to consist of a description of what is to be done (action definition), an Indexserver or ELOas script, and a workflow.</span></p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> The <span style='font-weight:bold;
font-style:italic'>Create file</span> action creates a folder at the desired location and sets the short name, A workflow is then started. The client then receives the information to show a specific form and trigger a <code>goTo</code> to the newly created file.</span></p>
<p>{@img img3.png}</p>
</blockquote>
<h2>Limitations of the action concept</h2>
<p>The objective of the action concept is to offer functions that work for all clients. This is not possible with Intray functions, for example.</p>

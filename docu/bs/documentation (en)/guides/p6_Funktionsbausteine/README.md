<h1>Function modules</h1>
<p>The logic used must be implemented with the help of ELO function modules. The general aim is to avoid using client-side scripting as far as possible.</p>
<p>As a general rule, <span
style='font-weight:bold'>function modules must be implemented in the Indexserver</span> unless you are dealing with CPU-intensive tasks or tasks that take a long time</span>, as these are more likely to be prone to errors. In cases such as these, you should use an <span
style='font-weight:bold'>ELOas rule</span>. Import and export operations as well as timed actions should also be implemented as ELOas rules.</p>
<h2>ELO Indexserver function modules</h2>
<p>A simple way to implement function modules in the Indexserver is to use the <code>sol.common.ix.FunctionBase</code> class. This provides all the necessary basic functions. </p>
<p>When designing modules, it is important to take into consideration that they can be called as a node in a workflow or as a registered function. Depending on the usage scenario (e.g. <code>ChangeUser</code>), a registered function may not make sense.</p>
<p><span class="tag_important"><span
style='font-weight:bold'>You will find an example of how a function module can be implemented</span> in the guidelines for <a
href="#!/guide/p19_Indexserver_Scripting">Indexserver scripting.</a></span></p>
<h3>Calling via a workflow node</h3>
<p>IX function modules can be used as start or end scripts in a workflow node. To ensure a uniform appearance and keep the process transparent, it is advisable to add a separate distribution node for each function call and assign a separate icon. You should use the following naming convention:</p>
<pre><code>{module name} : { action description }
E.g.: CHANGECOLOR : Unprocessed invoice
</code></pre>
<p>The <span
style='font-weight:bold'>module configuration</span> takes place in the comments field of the workflow node. The scripting documentation for the function modules provides the available config options. As a general rule, you do not need to set the <code>objId</code> variable in the workflow node as this can be derived from the active workflow.</p>
<p>{@img img1.png}</p>
<p><span class="tag_caution"><span
style='font-weight:bold;color:#C00000'>Security note: </span><span
style='font-weight:bold'>Make sure that you assign a separate node to each function module and that they cannot be called via a user node (exception: Service accounts such as ELOas)! Otherwise, users are able to change the configuration via ELO default functions when passing forward the workflow.</span></span></p>
<h3>Call as a registered function via the IX API</h3>
<p>It is also possible to call function modules via registered functions. The <code>execute</code> helper function in the <code>IxUtils</code> is available for this. Unlike when calling a function via a workflow node, the <code>objId</code> must be transferred as the context of the element is not known.</p>
<pre><code>sol.common.IxUtils.execute('RF_sol_function_ChangeColor', {
  objId: &quot;4711&quot;,
  color: &quot;blue&quot;
});
</code></pre>
<h3>Excerpt of available IX function modules</h3>
<p>The following is an excerpt of the available IX function modules in the Common package:</p>
<table><thead><tr><td><span
style='font-weight:bold'>Name of the class</span></td><td><span
style='font-weight:bold'>Description</span></td></tr></thead><tbody><tr><td>    sol.common.ix.functions.ApplyDynKwl</td><td><span
style='font-weight:bold'>Import metadata from dynamic keyword list</span><br />Queries values from a dynamic keyword list and saves them to the current entry.<br /></td></tr><tr><td>    sol.common.ix.functions.Blackening</td><td><span
style='font-weight:bold'>Black out text</span><br />Blacks out parts of documents. <br />Version control should be disabled.</td></tr><tr><td>    sol.common.ix.functions.ChangeColor</td><td><span
style='font-weight:bold'>Change color of element</span><br />Changes the color of an element. </td></tr><tr><td>    sol.common.ix.functions.ChangeRights</td><td><span
style='font-weight:bold'>Edit user permissions</span></td></tr><tr><td>    sol.common.ix.functions.ChangeUser</td><td><span
style='font-weight:bold'>Change owner of the successor node</span><br />Sets the owner of a successor node following a <a
href="#!/guide/p20_Roles__Benutzer_dynamisch_ermitteln">role configuration</a>.</td></tr><tr><td>    sol.common.ix.functions.CheckMandatoryFields</td><td><span
style='font-weight:bold'>Check multiple mandatory fields</span><br />Option to check multiple values in a workflow.</td></tr><tr><td>    sol.common.ix.functions.CopyFolderContents</td><td><span
style='font-weight:bold'>Copy folder contents from template</span><br />Copies the entire folder contents from a template.</td></tr><tr><td>    sol.common.ix.functions.CopySordData</td><td><span
style='font-weight:bold'>Copy metadata from a template</span><br />Copies all metadata from a template to the current element.</td></tr><tr><td>    sol.common.ix.functions.CreateFromTemplate</td><td><span
style='font-weight:bold'>Creates a document from a template</span></td></tr><tr><td>    sol.common.ix.functions.Delete</td><td><span
style='font-weight:bold'>Delete entry</span><br />Deletes an entry (document/folder).</td></tr><tr><td>    sol.common.ix.functions.FeedComment</td><td><span
style='font-weight:bold'>Write feed comment</span><br />Writes a feed comment.</td></tr><tr><td>    sol.common.ix.functions.GenerateIdentifier</td><td><span
style='font-weight:bold'>Reference and name generator</span><br />Makes it easier to implement file references and name generators.</td></tr><tr><td>    sol.common.ix.functions.Inherit</td><td><span
style='font-weight:bold'>Inherits metadata from parent element</span></td></tr><tr><td>    sol.common.ix.functions.IsoDate</td><td><span
style='font-weight:bold'>Set the current ISO date as the status</span><br />Writes the current date to a metafield.</td></tr><tr><td>    sol.common.ix.functions.Move</td><td><span
style='font-weight:bold'>Move element</span><br />Moves an element in ELO to a different location.</td></tr><tr><td>    sol.common.ix.functions.Notify</td><td><span
style='font-weight:bold'>Triggers an ELOas rule for sending e-mails</span></td></tr><tr><td>    sol.common.ix.functions.RemoveAcl</td><td><span
style='font-weight:bold'>Remove permissions</span><br />Removes certain permissions to the entry and optionally saves these to a map field. Acts recursively (optional).</td></tr><tr><td>    sol.common.ix.functions.RestoreAcl</td><td><span
style='font-weight:bold'>Restore permissions</span><br />Restores the permissions to the entry based on the stored values.</td></tr><tr><td>    sol.common.ix.functions.Set</td><td><span
style='font-weight:bold'>Set value</span><br />Changes index values, workflow map, or map values. This module enables more complex mapping of sol.common.ix.functions.Status.</td></tr><tr><td>    sol.common.ix.functions.Status</td><td><span
style='font-weight:bold'>Change status</span><br />Changes the status of a metafield. <br />An ID can be classified with the help of a keyword list.</td></tr><tr><td>    sol.common.ix.functions.UserToIndex</td><td><span
style='font-weight:bold'>Write the current user name to the index field</span><br /></td></tr></tbody></table>

<h2>ELOas function modules</h2>
<table><thead><tr><td><span
style='font-weight:bold'>Name of the class</span></td><td><span
style='font-weight:bold'>Description</span></td></tr></thead><tbody><tr><td>    sol.common.as.functions.SendMail</td><td><span
style='font-weight:bold'>Send e-mail</span><br />Send e-mail based on a template.<br /></td></tr><tr><td>    sol.common.as.functions.OfficeConverter</td><td><span
style='font-weight:bold'>Convert Office documents</span><br />Save Office documents such as <span
style='font-style:italic'>*.docx</span> in other formats.</td></tr></tbody></table>

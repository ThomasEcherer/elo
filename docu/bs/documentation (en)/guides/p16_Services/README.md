<h1>Services</h1>
<p>Services provide functions that may need to be processed further depending on what the clients return. This could be something like collecting information in the system or checking various information.</p>
<p>Unlike <a
href="#!/guide/p6_Funktionsbausteine">function modules</a>, services are mainly called as a registered function via the IX interface and have no function as a workflow module.</p>
<p><span class="tag_important"><span
style='font-weight:bold'>You will find an example of how a service can be implemented</span> in the guidelines for <a
href="#!/guide/p19_Indexserver_Scripting">Indexserver scripting</a>.</span></p>
<p>{@img img1.png}</p>
<h2>ELO Indexserver services</h2>
<h3>Call as a registered function via the IX API</h3>
<p>Services {{SERVIC}} can be called via registered functions. The <code>execute</code> helper function in the <code>IxUtils</code> is available for this. </p>
<pre><code>var data = sol.common.IxUtils.execute('RF_custom_services_MyService', {
  // Configuration of the service
});
</code></pre>
<h3>Excerpt of available IX services</h3>
<table><thead><tr><td><span
style='font-weight:bold'>Name of the class</span></td><td><span
style='font-weight:bold'>Description</span></td></tr></thead><tbody><tr><td>    sol.common.ix.services.ActionDefinitionCollector</td><td><span
style='font-weight:bold'>Returns a list of all action definitions</span><br />See also <a
href="#!/guide/p21_Definition__Action_definition_">Definition (action definition)</a>.</td></tr><tr><td>    sol.common.ix.services.ChildrenDataCollector</td><td><span
style='font-weight:bold'>Collects data in condensed form</span><br />Collects data in condensed form to provide information faster to dashboards.</td></tr><tr><td>    sol.common.ix.services.DownloadFileContent</td><td><span
style='font-weight:bold'>Download file content</span></td></tr><tr><td>    sol.common.ix.services.ExecuteAsAction</td><td><span
style='font-weight:bold'>Execute ELOas rule</span><br />This enables components without DMZ to access ELOas.</td></tr><tr><td>    sol.common.ix.services.GetBusinessSolutionConfigs</td><td><span
style='font-weight:bold'>Determines all configuration files of a solution</span></td></tr><tr><td>    sol.common.ix.services.GetConfig</td><td><span
style='font-weight:bold'>Reads a JSON configuration</span></td></tr><tr><td>    sol.common.ix.services.GetWorkflowMetadata</td><td><span
style='font-weight:bold'>Collects metadata for a workflow for ELO apps</span></td></tr><tr><td>    sol.common.ix.services.KwlDataCollector</td><td><span
style='font-weight:bold'>Collect data for keyword lists and dynamic keyword lists</span></td></tr><tr><td>    sol.common.ix.services.ScriptVersionReportCreate</td><td><span
style='font-weight:bold'>Create script version list</span><br />Creates a list of version information for the scripts in the repository including the <span
style='font-style:italic'>MD5</span> file.</td></tr><tr><td>    sol.common.ix.services.ScriptVersionReportValidate</td><td><span
style='font-weight:bold'>Compares the script version list</span><br />Compares the <span
style='font-style:italic'>CreateJsonScriptVersionList</span> version list against the current status in the repository and generates an HTML report.</td></tr><tr><td>    sol.common.ix.services.UploadFileContent</td><td><span
style='font-weight:bold'>Upload file content for an existing file</span></td></tr></tbody></table>

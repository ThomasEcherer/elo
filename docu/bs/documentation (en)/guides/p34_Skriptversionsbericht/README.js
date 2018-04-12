Ext.data.JsonP.p34_Skriptversionsbericht({"guide":"<h1 id='p34_Skriptversionsbericht-section-script-version-report'>Script version report</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/p34_Skriptversionsbericht-section-create-report'>Create report</a>\n </li>\n<li>2. <a href='#!/guide/p34_Skriptversionsbericht-section-compare-reports'>Compare reports</a>\n </li>\n</ul></div>\n\n\n<p><span class=\"tag_important\">The following concepts require the <span\nstyle='font-weight:bold;font-style:italic'>development</span> module.</span></p>\n\n\n<p>Script version reports can be used to save the status of all scripts below a folder to a report file. </p>\n\n\n<p><p><img src=\"guides/p34_Skriptversionsbericht/img1.png\" alt=\"\" width=\"751\" height=\"160\"></p></p>\n\n\n<h2 id='p34_Skriptversionsbericht-section-create-report'>Create report</h2>\n\n\n<p>First you need to select a folder in the Administration folder that contains the scripts you require for the report.</p>\n\n\n<p><p><img src=\"guides/p34_Skriptversionsbericht/img3.png\" alt=\"\" width=\"382\" height=\"202\"></p></p>\n\n\n<p>The <span\nstyle='font-weight:bold;font-style:italic'>Generate report</span> function is then used to create a report in a <span\nstyle='font-style:italic'>.json</span> file.</p>\n\n\n<pre><code>{\n  &quot;date&quot;: &quot;20151020183324&quot;,\n  &quot;files&quot;: [\n    {\n      &quot;refPath&quot;: &quot;&para;Administration&para;Business Solutions&para;common&para;.eloinst&quot;,\n      &quot;name&quot;: &quot;build&quot;,\n      &quot;filehash&quot;: &quot;A9D8F20B2851A4951AFAF49C533AD35E&quot;,\n      &quot;guid&quot;: &quot;(5CA093FB-21E1-F65D-FEAD-E9527CE77D52)&quot;,\n      &quot;version&quot;: &quot;&quot;,\n      &quot;editor&quot;: &quot;Michael Weiler&quot;,\n      &quot;date&quot;: &quot;20151013163422&quot;,\n      &quot;deleted&quot;: false\n    },\n    {\n      &quot;refPath&quot;: &quot;&para;Administration&para;Business Solutions&para;common&para;.eloinst&quot;,\n      &quot;name&quot;: &quot;install&quot;,\n      &quot;filehash&quot;: &quot;4562909FE6EF6631AA68742FF289C9B2&quot;,\n      &quot;guid&quot;: &quot;(1E508032-1228-3A91-3E37-338355A72FFA)&quot;,\n      &quot;version&quot;: &quot;&quot;,\n      &quot;editor&quot;: &quot;Michael Weiler&quot;,\n      &quot;date&quot;: &quot;20151016101939&quot;,\n      &quot;deleted&quot;: false\n    },\n    // &hellip;\n}\n</code></pre>\n\n\n<h2 id='p34_Skriptversionsbericht-section-compare-reports'>Compare reports</h2>\n\n\n<p>The report can be used later on to check the current status against the report file. The <span\nstyle='font-weight:bold;font-style:italic'>Validate report</span> function on the ribbon of the Java Client can be used for this. </p>\n\n\n<p>This opens a dialog box for selecting the previously created JSON report file. A list of all scripts is shown at the end including a separation of which files have been modified and which are still in their original form. You can compare files by their hash values.</p>\n\n\n<p>Clicking the script name will take you straight to the script.</p>\n\n\n<p><p><img src=\"guides/p34_Skriptversionsbericht/img5.png\" alt=\"\" width=\"1257\" height=\"677\"></p></p>\n\n","title":"Script version report"});
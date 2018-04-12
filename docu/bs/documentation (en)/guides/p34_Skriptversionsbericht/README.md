<h1>Script version report</h1>
<p><span class="tag_important">The following concepts require the <span
style='font-weight:bold;font-style:italic'>development</span> module.</span></p>
<p>Script version reports can be used to save the status of all scripts below a folder to a report file. </p>
<p>{@img img1.png}</p>
<h2>Create report</h2>
<p>First you need to select a folder in the Administration folder that contains the scripts you require for the report.</p>
<p>{@img img3.png}</p>
<p>The <span
style='font-weight:bold;font-style:italic'>Generate report</span> function is then used to create a report in a <span
style='font-style:italic'>.json</span> file.</p>
<pre><code>{
  &quot;date&quot;: &quot;20151020183324&quot;,
  &quot;files&quot;: [
    {
      &quot;refPath&quot;: &quot;&para;Administration&para;Business Solutions&para;common&para;.eloinst&quot;,
      &quot;name&quot;: &quot;build&quot;,
      &quot;filehash&quot;: &quot;A9D8F20B2851A4951AFAF49C533AD35E&quot;,
      &quot;guid&quot;: &quot;(5CA093FB-21E1-F65D-FEAD-E9527CE77D52)&quot;,
      &quot;version&quot;: &quot;&quot;,
      &quot;editor&quot;: &quot;Michael Weiler&quot;,
      &quot;date&quot;: &quot;20151013163422&quot;,
      &quot;deleted&quot;: false
    },
    {
      &quot;refPath&quot;: &quot;&para;Administration&para;Business Solutions&para;common&para;.eloinst&quot;,
      &quot;name&quot;: &quot;install&quot;,
      &quot;filehash&quot;: &quot;4562909FE6EF6631AA68742FF289C9B2&quot;,
      &quot;guid&quot;: &quot;(1E508032-1228-3A91-3E37-338355A72FFA)&quot;,
      &quot;version&quot;: &quot;&quot;,
      &quot;editor&quot;: &quot;Michael Weiler&quot;,
      &quot;date&quot;: &quot;20151016101939&quot;,
      &quot;deleted&quot;: false
    },
    // &hellip;
}
</code></pre>
<h2>Compare reports</h2>
<p>The report can be used later on to check the current status against the report file. The <span
style='font-weight:bold;font-style:italic'>Validate report</span> function on the ribbon of the Java Client can be used for this. </p>
<p>This opens a dialog box for selecting the previously created JSON report file. A list of all scripts is shown at the end including a separation of which files have been modified and which are still in their original form. You can compare files by their hash values.</p>
<p>Clicking the script name will take you straight to the script.</p>
<p>{@img img5.png}</p>

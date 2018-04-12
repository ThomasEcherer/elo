<h1>Templates</h1>
<p>Templates can be used to define a generic approach when creating e-mails, file references, configuration files, or other data in ELO. The value are replaced with metadata (or other data) at runtime.</p>
<p><span
style='font-weight:bold'>Templates are an essential component of solutions as they can be adapted to meet different requirements. For example, all names should be written with the help of templates. </span></p>
<p>The <a
href="http://handlebarsjs.com/">handlebars.js</a> Open Source Project provides the basis for templating.</p>
<p>Templating is widely used in ELO Business Solutions, such as ...</p>
<ul>
<li><span
style='font-weight:bold'>...creating filing paths.</span> The configuration of individual solutions contains a powerful tool for creating filing paths.</li>
<li><span
style='font-weight:bold'>...generating short name and file references.</span> File references are subject to different company/official requirements. Templates allow you to quickly change the reference.</li>
<li><span
style='font-weight:bold'>...generating export documents.</span> You can use templates to adapt export data sets, such as in XML or CSV format, to the requirements of the target system.</li>
<li><span
style='font-weight:bold'>...generating PDF documents.</span> Apache FOP is increasingly used to generate PDF documents. This method is ideally suited for use with templates.</li>
</ul>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> The file reference is composed of the filing plan reference and a counter. The file reference is stored to the <code>FILING_PLAN_REFERENCE</code> metadata field. Indexserver Sord objects can only be used to a limited extent for templates as the data structure of objKeys is partly nested. The </span><a
href="#!/guide/p30_Object_Formatter__Objekte_transformieren"><span
style='font-style:italic'>object formatter</span></a><span style='font-style:
italic'> transforms objects into a structure that is easy to use.</span></p>
</blockquote>
<pre><code>{{sord.objKeys.FILING_PLAN_REFERENCE}}-{{count &quot;TEST&quot;}}
</code></pre>
<blockquote>
<p><span
style='font-style:italic'>If the current element were to set the filing plan reference </span><span
style='font-weight:bold;font-style:italic'>12.10</span><span style='font-style:
italic'> in the metadata, the result would be as follows:</span></p>
</blockquote>
<pre><code>12.10-1
12.10-2
12.10-3
...
</code></pre>
<p><span
style='font-style:italic'>handlebars</span> use helpers, which enables users to modularize functions such as the Indexserver counter in templates. In the example above, a <code>TEST</code> number range is transferred to the <code>count</code> helper. The Indexserver then creates a counter and increments by one every time it is used.</p>
<p>The <code>sol.common.Template</code> class contains a detailed description as well as several examples of the function.</p>
<p>Simple example</p>
<p>The following example shows how the <code>sol.common.Template</code> mechanism can be used:</p>
<pre><code>var tpl = sol.create('sol.common.Template', {
    source = 'Hello {{name}}.'
});

var result = tpl.apply({
  name: 'Marcus'
});

// result = Hello Marcus.
</code></pre>
<h2>Example using a Sord object</h2>
<p>Templates can also be filed to the repository as text files. First, the template must be loaded using a GUID or ARCPATH reference. </p>
<p>An existing Sord can then be transformed into a template Sord using the object formatter and then set into a template:</p>
<pre><code>var tpl = sol.create('sol.common.Template', {});

// load data from a text file in ELO
tpl.load('GUID');

// accessing objKey properties is difficult.
// use sol.common.ObjectFormatter to get an easy to use sord object.
var data = sol.common.ObjectFormatter.format({
  sord: {
    formatter: 'sol.common.ObjectFormatter.TemplateSord',
    data: sord
});

var result = tpl.apply(data);
</code></pre>

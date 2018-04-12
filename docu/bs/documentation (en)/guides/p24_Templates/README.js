Ext.data.JsonP.p24_Templates({"guide":"<h1 id='p24_Templates-section-templates'>Templates</h1>\n\n\n<p>Templates can be used to define a generic approach when creating e-mails, file references, configuration files, or other data in ELO. The value are replaced with metadata (or other data) at runtime.</p>\n\n\n<p><span\nstyle='font-weight:bold'>Templates are an essential component of solutions as they can be adapted to meet different requirements. For example, all names should be written with the help of templates. </span></p>\n\n\n<p>The <a\nhref=\"http://handlebarsjs.com/\">handlebars.js</a> Open Source Project provides the basis for templating.</p>\n\n\n<p>Templating is widely used in ELO Business Solutions, such as ...</p>\n\n\n<ul>\n<li><span\nstyle='font-weight:bold'>...creating filing paths.</span> The configuration of individual solutions contains a powerful tool for creating filing paths.</li>\n<li><span\nstyle='font-weight:bold'>...generating short name and file references.</span> File references are subject to different company/official requirements. Templates allow you to quickly change the reference.</li>\n<li><span\nstyle='font-weight:bold'>...generating export documents.</span> You can use templates to adapt export data sets, such as in XML or CSV format, to the requirements of the target system.</li>\n<li><span\nstyle='font-weight:bold'>...generating PDF documents.</span> Apache FOP is increasingly used to generate PDF documents. This method is ideally suited for use with templates.</li>\n</ul>\n\n\n<blockquote>\n<p><span\nstyle='font-weight:bold;font-style:italic'>Example:</span><span\nstyle='font-style:italic'> The file reference is composed of the filing plan reference and a counter. The file reference is stored to the <code>FILING_PLAN_REFERENCE</code> metadata field. Indexserver Sord objects can only be used to a limited extent for templates as the data structure of objKeys is partly nested. The </span><a\nhref=\"#!/guide/p30_Object_Formatter__Objekte_transformieren\"><span\nstyle='font-style:italic'>object formatter</span></a><span style='font-style:\nitalic'> transforms objects into a structure that is easy to use.</span></p>\n</blockquote>\n\n\n<pre><code>{{sord.objKeys.FILING_PLAN_REFERENCE}}-{{count &quot;TEST&quot;}}\n</code></pre>\n\n\n<blockquote>\n<p><span\nstyle='font-style:italic'>If the current element were to set the filing plan reference </span><span\nstyle='font-weight:bold;font-style:italic'>12.10</span><span style='font-style:\nitalic'> in the metadata, the result would be as follows:</span></p>\n</blockquote>\n\n\n<pre><code>12.10-1\n12.10-2\n12.10-3\n...\n</code></pre>\n\n\n<p><span\nstyle='font-style:italic'>handlebars</span> use helpers, which enables users to modularize functions such as the Indexserver counter in templates. In the example above, a <code>TEST</code> number range is transferred to the <code>count</code> helper. The Indexserver then creates a counter and increments by one every time it is used.</p>\n\n\n<p>The <code><a href=\"#!/api/sol.common.Template\" rel=\"sol.common.Template\" class=\"docClass\">sol.common.Template</a></code> class contains a detailed description as well as several examples of the function.</p>\n\n\n<p>Simple example</p>\n\n\n<p>The following example shows how the <code><a href=\"#!/api/sol.common.Template\" rel=\"sol.common.Template\" class=\"docClass\">sol.common.Template</a></code> mechanism can be used:</p>\n\n\n<pre><code>var tpl = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>('<a href=\"#!/api/sol.common.Template\" rel=\"sol.common.Template\" class=\"docClass\">sol.common.Template</a>', {\n    source = 'Hello {{name}}.'\n});\n\nvar result = tpl.apply({\n  name: 'Marcus'\n});\n\n// result = Hello Marcus.\n</code></pre>\n\n\n<h2 id='p24_Templates-section-example-using-a-sord-object'>Example using a Sord object</h2>\n\n\n<p>Templates can also be filed to the repository as text files. First, the template must be loaded using a GUID or ARCPATH reference. </p>\n\n\n<p>An existing Sord can then be transformed into a template Sord using the object formatter and then set into a template:</p>\n\n\n<pre><code>var tpl = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>('<a href=\"#!/api/sol.common.Template\" rel=\"sol.common.Template\" class=\"docClass\">sol.common.Template</a>', {});\n\n// load data from a text file in ELO\ntpl.load('GUID');\n\n// accessing objKey properties is difficult.\n// use <a href=\"#!/api/sol.common.ObjectFormatter\" rel=\"sol.common.ObjectFormatter\" class=\"docClass\">sol.common.ObjectFormatter</a> to get an easy to use sord object.\nvar data = <a href=\"#!/api/sol.common.ObjectFormatter-method-format\" rel=\"sol.common.ObjectFormatter-method-format\" class=\"docClass\">sol.common.ObjectFormatter.format</a>({\n  sord: {\n    formatter: '<a href=\"#!/api/sol.common.ObjectFormatter.TemplateSord\" rel=\"sol.common.ObjectFormatter.TemplateSord\" class=\"docClass\">sol.common.ObjectFormatter.TemplateSord</a>',\n    data: sord\n});\n\nvar result = tpl.apply(data);\n</code></pre>\n\n","title":"Templates"});
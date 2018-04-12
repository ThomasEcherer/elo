Ext.data.JsonP.p43_Logging({"guide":"<h1 id='p43_Logging-section-logging'>Logging</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/p43_Logging-section-example-of-use'>Example of use</a>\n </li>\n<li>2. <a href='#!/guide/p43_Logging-section-logging-functions'>Logging functions</a>\n </li>\n</ul></div>\n\n\n<p>The <code><a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a></code> helper class is used for standardizing logging of solutions. The helper class provides the following functions:</p>\n\n\n<ul>\n<li>Standardized output for all types</li>\n<li>Predefined scope that is included in the log output</li>\n<li>String formatting options to assign values to log outputs</li>\n<li>Adding further information to the log by transferring a JS object</li>\n<li>Logging execution times of functions</li>\n</ul>\n\n\n<p><span class=\"tag_important\">The <code><a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a></code> class provides an exact description of the logging options. Alternatively, you can also use the <code>log</code> standard logger that is available in scripting.</span></p>\n\n\n<h2 id='p43_Logging-section-example-of-use'>Example of use</h2>\n\n\n<p>First of all, you need to create an instance of the logger class:</p>\n\n\n<pre><code>var logger = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(&quot;<a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a>&quot;, { scope: 'custom.ix.MyClass' });\n</code></pre>\n\n\n<p><span class=\"tag_important\"><span\nstyle='font-weight:bold'>In the case of implementations within an own class, which were created using the class framework</span>, the logger is instantiated in the <code>initialize</code> function of <code><a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a></code>. If no logger is available, it is necessary to check whether the <code>initialize</code> function of the <code><a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a></code> superclass was also called for own <code>initialize</code> functions.</span></p>\n\n\n<p>The following examples show how a logger is used. You can refer to the <code><a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a></code> class documentation for detailed information.</p>\n\n\n<pre><code>logger.info('Searching for elements...');\n// [custom.ix.MyClass] Searching for elements... :\n\nlogger.info('Searching for elements...', { parentId: 123 });\n// [custom.ix.MyClass] Searching for elements... : {&quot;parentId&quot;:123}\n\nlogger.info(['Searching for elements of parentId: {0}', 123]);\n// [custom.ix.MyClass] Searching for elements of parentId: 123 :\n\nlogger.info(['Searching for elements of parentId: {0}', 123], {userName: 'Administrator'});\n// [custom.ix.MyClass] Searching for elements of parentId: 123 : {&quot;userName&quot;:&quot;Administrator&quot;}\n</code></pre>\n\n\n<h2 id='p43_Logging-section-logging-functions'>Logging functions</h2>\n\n\n<p><span class=\"tag_important\">It is especially important to identify which function calls are expensive to improve performance. For this reason, function calls are logged with <code>me.logger.enter</code> and <code>me.logger.exit</code>. In debugging mode, the execution time is determined based on the function name transferred.</span></p>\n\n\n<pre><code>myFunction: function() {\n  var me = this;\n  me.logger.enter(&quot;my.Function&quot;, { param: &quot;abc&quot; });  // Object optional\n  // function code belongs here.\n  me.logger.exit(&quot;my.Function&quot;, { result: &quot;xyz&quot;});  // Object optional\n}\n\n// [custom.ix.MyClass] ENTER my.Function : {&quot;param&quot;:&quot;abc&quot;}\n// [custom.ix.MyClass] EXIT my.Function : 313ms : {&quot;result&quot;:&quot;xyz&quot;}\n</code></pre>\n\n","title":"Logging"});
<h1>Logging</h1>
<p>The <code>sol.Logger</code> helper class is used for standardizing logging of solutions. The helper class provides the following functions:</p>
<ul>
<li>Standardized output for all types</li>
<li>Predefined scope that is included in the log output</li>
<li>String formatting options to assign values to log outputs</li>
<li>Adding further information to the log by transferring a JS object</li>
<li>Logging execution times of functions</li>
</ul>
<p><span class="tag_important">The <code>sol.Logger</code> class provides an exact description of the logging options. Alternatively, you can also use the <code>log</code> standard logger that is available in scripting.</span></p>
<h2>Example of use</h2>
<p>First of all, you need to create an instance of the logger class:</p>
<pre><code>var logger = sol.create(&quot;sol.Logger&quot;, { scope: 'custom.ix.MyClass' });
</code></pre>
<p><span class="tag_important"><span
style='font-weight:bold'>In the case of implementations within an own class, which were created using the class framework</span>, the logger is instantiated in the <code>initialize</code> function of <code>sol.Base</code>. If no logger is available, it is necessary to check whether the <code>initialize</code> function of the <code>sol.Base</code> superclass was also called for own <code>initialize</code> functions.</p>
<p>The following examples show how a logger is used. You can refer to the <code>sol.Logger</code> class documentation for detailed information.</p>
<pre><code>logger.info('Searching for elements...');
// [custom.ix.MyClass] Searching for elements... :

logger.info('Searching for elements...', { parentId: 123 });
// [custom.ix.MyClass] Searching for elements... : {&quot;parentId&quot;:123}

logger.info(['Searching for elements of parentId: {0}', 123]);
// [custom.ix.MyClass] Searching for elements of parentId: 123 :

logger.info(['Searching for elements of parentId: {0}', 123], {userName: 'Administrator'});
// [custom.ix.MyClass] Searching for elements of parentId: 123 : {&quot;userName&quot;:&quot;Administrator&quot;}
</code></pre>
<h2>Logging functions</h2>
<p><span class="tag_important">It is especially important to identify which function calls are expensive to improve performance. For this reason, function calls are logged with <code>me.logger.enter</code> and <code>me.logger.exit</code>. In debugging mode, the execution time is determined based on the function name transferred.</span></p>
<pre><code>myFunction: function() {
  var me = this;
  me.logger.enter(&quot;my.Function&quot;, { param: &quot;abc&quot; });  // Object optional
  // function code belongs here.
  me.logger.exit(&quot;my.Function&quot;, { result: &quot;xyz&quot;});  // Object optional
}

// [custom.ix.MyClass] ENTER my.Function : {&quot;param&quot;:&quot;abc&quot;}
// [custom.ix.MyClass] EXIT my.Function : 313ms : {&quot;result&quot;:&quot;xyz&quot;}
</code></pre>

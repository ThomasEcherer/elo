<h1>Web performance</h1>
<p>The guidelines on <a
href="#!/guide/p40_JS_Performance">JS performance</a> also apply here. In web environments, there are other particularities that need to be taken into account because of the browser rendering engine.</p>
<h2>Web applications are single-threaded</h2>
<p><span class="tag_warning">Code that is executed during the layout process or during rendering must be optimized. For this reason, it is recommendable to avoid complex tasks or pass them to a background worker.</span></p>
<p>If you do not use a web worker, the entire application will run in a thread. This includes rendering, layout, and the entire JS execution. </p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> If the JS function takes several seconds to run, the entire interface will freeze during this time. If ELO apps are embedded in web applications, the application to be embedded will also freeze. For example, the Invoice cockpit would also cause the Web Client to stall when conducting expensive statistical evaluations.</p>
</blockquote>
<h2>Using the Indexserver API</h2>
<p><span class="tag_warning">If IX functions are used, <span
style='font-weight:bold'>these must also be called asynchronously</span> as otherwise the UI thread will also be blocked until the Indexserver replies.</span></p>
<pre><code>api.IX.ix().checkoutSord(&quot;123&quot;, api.CONST.SORD.mbAll, api.CONST.LOCK.NO, 
    function(sord) {
      // success
    }, function() {
      // failure
    });
</code></pre>
<h2>CSS performance</h2>
<p>CSS selectors are read from right to left. It is important to note in this case that the following selectors return and post-filter all <code>span elements</code> of the current website:</p>
<pre><code>.invoices div.invoice span {
   font-size: 12px;
}
</code></pre>
<p>It is better to use a more restrictive filter in this case:</p>
<pre><code>div.invoice span.title {
   font-size: 12px;
}
</code></pre>
<h2>Reducing DOM access</h2>
<p><span class="tag_warning">Accessing the browser DOM is extremely expensive. If multiple elements are added to the website during one cycle, these must be put together <span
style='font-weight:bold'>before</span> they are added to the DOM. This is the only way to prevent the browser from triggering the rendering process during every DOM operation.</span></p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> A string builder implementation in JS is used to build a table in combination with a loop.When the operations are completed, the table can be written to the DOM. </span></p>
</blockquote>
<pre><code>var tableBuilder= ['&lt;table unselectable=&quot;on&quot;&gt;'];
for (var i=0; i&lt;10000; i++) { 
   tableBuilder.push('&lt;tr&gt;
   tableBuilder.push('  &lt;td&gt;1&lt;/td&gt;
   tableBuilder.push('  &lt;td&gt;2&lt;/td&gt;
   tableBuilder.push('&lt;/tr&gt;'); 
} 
tableBuilder.push('&lt;/table&gt;');

var table = tableBuilder.join(&quot;&quot;);
document.getElementById('myTableContainer').innerHTML = table;
</code></pre>

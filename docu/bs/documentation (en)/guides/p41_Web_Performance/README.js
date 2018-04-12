Ext.data.JsonP.p41_Web_Performance({"guide":"<h1 id='p41_Web_Performance-section-web-performance'>Web performance</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/p41_Web_Performance-section-web-applications-are-single-threaded'>Web applications are single-threaded</a>\n </li>\n<li>2. <a href='#!/guide/p41_Web_Performance-section-using-the-indexserver-api'>Using the Indexserver API</a>\n </li>\n<li>3. <a href='#!/guide/p41_Web_Performance-section-css-performance'>CSS performance</a>\n </li>\n<li>4. <a href='#!/guide/p41_Web_Performance-section-reducing-dom-access'>Reducing DOM access</a>\n </li>\n</ul></div>\n\n\n<p>The guidelines on <a\nhref=\"#!/guide/p40_JS_Performance\">JS performance</a> also apply here. In web environments, there are other particularities that need to be taken into account because of the browser rendering engine.</p>\n\n\n<h2 id='p41_Web_Performance-section-web-applications-are-single-threaded'>Web applications are single-threaded</h2>\n\n\n<p><span class=\"tag_warning\">Code that is executed during the layout process or during rendering must be optimized. For this reason, it is recommendable to avoid complex tasks or pass them to a background worker.</span></p>\n\n\n<p>If you do not use a web worker, the entire application will run in a thread. This includes rendering, layout, and the entire JS execution. </p>\n\n\n<blockquote>\n<p><span\nstyle='font-weight:bold;font-style:italic'>Example:</span><span\nstyle='font-style:italic'> If the JS function takes several seconds to run, the entire interface will freeze during this time. If ELO apps are embedded in web applications, the application to be embedded will also freeze. For example, the Invoice cockpit would also cause the Web Client to stall when conducting expensive statistical evaluations.</span></p>\n</blockquote>\n\n\n<h2 id='p41_Web_Performance-section-using-the-indexserver-api'>Using the Indexserver API</h2>\n\n\n<p><span class=\"tag_warning\">If IX functions are used, <span\nstyle='font-weight:bold'>these must also be called asynchronously</span> as otherwise the UI thread will also be blocked until the Indexserver replies.</span></p>\n\n\n<pre><code>api.IX.ix().checkoutSord(&quot;123&quot;, api.CONST.SORD.mbAll, api.CONST.LOCK.NO, \n    function(sord) {\n      // success\n    }, function() {\n      // failure\n    });\n</code></pre>\n\n\n<h2 id='p41_Web_Performance-section-css-performance'>CSS performance</h2>\n\n\n<p>CSS selectors are read from right to left. It is important to note in this case that the following selectors return and post-filter all <code>span elements</code> of the current website:</p>\n\n\n<pre><code>.invoices div.invoice span {\n   font-size: 12px;\n}\n</code></pre>\n\n\n<p>It is better to use a more restrictive filter in this case:</p>\n\n\n<pre><code>div.invoice span.title {\n   font-size: 12px;\n}\n</code></pre>\n\n\n<h2 id='p41_Web_Performance-section-reducing-dom-access'>Reducing DOM access</h2>\n\n\n<p><span class=\"tag_warning\">Accessing the browser DOM is extremely expensive. If multiple elements are added to the website during one cycle, these must be put together <span\nstyle='font-weight:bold'>before</span> they are added to the DOM. This is the only way to prevent the browser from triggering the rendering process during every DOM operation.</span></p>\n\n\n<blockquote>\n<p><span\nstyle='font-weight:bold;font-style:italic'>Example:</span><span\nstyle='font-style:italic'> A string builder implementation in JS is used to build a table in combination with a loop.When the operations are completed, the table can be written to the DOM. </span></p>\n</blockquote>\n\n\n<pre><code>var tableBuilder= ['&lt;table unselectable=&quot;on&quot;&gt;'];\nfor (var i=0; i&lt;10000; i++) { \n   tableBuilder.push('&lt;tr&gt;\n   tableBuilder.push('  &lt;td&gt;1&lt;/td&gt;\n   tableBuilder.push('  &lt;td&gt;2&lt;/td&gt;\n   tableBuilder.push('&lt;/tr&gt;'); \n} \ntableBuilder.push('&lt;/table&gt;');\n\nvar table = tableBuilder.join(&quot;&quot;);\ndocument.getElementById('myTableContainer').innerHTML = table;\n</code></pre>\n\n","title":"Web performance"});
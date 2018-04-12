<h1>Web Client scripting</h1>
<p>Web Client scripts should contain a self-executing anonymous function that contains the entire file content. This ensures that variables are defined locally, for example.</p>
<pre><code>(function () {

  var myVar = 'test';

}());
</code></pre>
<p>If global variables are accessed within a script, these can be transferred as parameters to the anonymous function. This improves performance when used frequently as local variables can be accessed faster than global variables.</p>
<pre><code>(function (window, document) {

  var myVar = document.getElementById('123');

}(window, document));
</code></pre>
<p>Another advantage is that local variable names can be minified. Example:</p>
<pre><code>(function(a,b){var c=b.getElementById('123');}(window,document));
</code></pre>

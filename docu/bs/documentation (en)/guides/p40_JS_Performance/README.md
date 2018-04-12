<h1>JS performance</h1>
<h2>Optimizing loops</h2>
<p>JS calculates the array length every time when iterating through loops. In the case of longer arrays, the maximum number should therefore be saved in a variable.</p>
<p>Expensive calculations and DOM operations should also be made outside of loops:</p>
<pre><code>var names = ['George', 'Ringo', 'Paul', 'John', &hellip;&hellip;&hellip;];

for(var i=0, var length = names.length; i &lt; length; i++){ 
   doSomethingWith(names[i]); 
}
</code></pre>
<h2>Avoiding eval ()</h2>
<p><span class="tag_warning">The Javascript function <code>eval()</code> should not be used as this call must be compiled at runtime. This is expensive and bears additional security risks.</span></p>
<h2>Iterating on cache entries</h2>
Iterating through object properties is approximately six times slower than iterating on a simple array. If maps are used to cache objects, you should use a parallel array in case you need to access all entries later on:</p>
<p><span
style='font-weight:bold'>Bad <code>for/in</code>: </span></p>
<pre><code>for (var guid in sordMap) {
    if (!sordMap.hasOwnProperty(guid)) continue;

    // do something with sordMap[guid];
}
</code></pre>
<p><span
style='font-weight:bold'>Better <code>for/i</code>:</span></p>
<pre><code>var length;
for(var i=0, length=sordList.length; i &lt; j; i++){ 
   var sord = sordList[i]; 
}
</code></pre>
<h2>Iterating through object properties</h2>
<p>If you regularly iterate over all properties of a dynamically generated object, it is recommended to create a list with the added properties when creating an object instead of <code>for (attName in obj)</code>. Iteration then takes place on the list of properties:</p>
<pre><code>var obj = {
  _attrs = ['name', 'ort'],
  name: 'Max',
  ort: 'Stuttgart'
};

var length;
for(var i=0, length=obj._attrs.length; i &lt; j; i++){ 
   var attr = obj._attrs[i];
   var val = obj[attr]; 
}
</code></pre>
<h2>Converting numbers</h2>
<p>If JS strings are converted into numbers, no major difference in performance is identified between <code>parseInt()</code>, <code>parseFloat()</code> or <code>number()</code>. You can use the function that returns the desired result in this case.</p>

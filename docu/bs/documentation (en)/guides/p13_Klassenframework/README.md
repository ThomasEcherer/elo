<h1>class framework</h1>
<p><code>sol.ClassManager</code></span></span> provides a detailed description of the class framework.</p>
<p>To modularize JavaScript classes, a JS class framework was developed that is similar to object relational programming and implements basic concepts such as inheritance, mixins and singletons. These techniques can be used to describe basic functions in a base class and use different implementations of a base class.</p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> The class <code>sol.common.ix.DynKwlDatabaseIterator</code> provides a base implementation for dynamic keyword lists {{DYNLST}}, which is implemented by different lists. An example of this is <code>sol.invoice.ix.dynkwl.Company</code></span> for </span><span
style='font-weight:bold;font-style:italic'>ELO Business Solutions Invoice</span></p>
</blockquote>
<p>The advantage of this is that it is possible to derive an own class and modify the implementation. </p>
<p><span class="tag_caution">Consultants or developers that work with ELO Business Solutions are instructed not to modify any core functions to ensure that they can be updated. You should only add extensions by modifying the class!</span></p>
<p>The <code>sol.ClassManager</code> class manages all class definitions and makes it possible to create class instances. </p>
<h2>Class model</h2>
<p>The following simple example illustrates the advantages of a JavaScript class framework. You can refer to the <code>sol.ClassManager</code> documentation for detailed examples.</p>
<p>{@img img1.png}</p>
<h2>Business Solutions Common API</h2>
<p>The Common API is offered through various classes. It includes functions and config properties that can be used. </p>
<p><span class="tag_caution">Internal functions are declared as <code>@private</code> or <code>@protected</code>  in the JavaScript documentation. These <span
style='font-weight:bold'>may not be used in scripts</span> as continuous refactoring can alter the internal class structure. If internal class functions are overridden or used, the function can no longer be guaranteed to work properly. Consultants or developers that work with ELO Business Solutions are therefore instructed only to use the methods and properties that are defined as <code>@public</code> in the class documentation.</p>
<h2>Class documentation</h2>
<p>Classes and functions must be documented in accordance with the specifications of the <a
href="https://github.com/senchalabs/jsduck"><span style='font-weight:bold;
font-style:italic'>JSDuck</span></a> documentation platform. This is used for mapping object relational concepts into JS. </p>
<p><span class="tag_important">The <a
href="#!/guide/">JS documentation</a> guide provides more information on documenting JS files </span>.</p>
<h2>Class definitions</h2>
<p>Classes are defined with the help of the <code>sol.define</code> function. The following example illustrates this:</p>
<pre><code>sol.define(&quot;custom.solution.BaseModule&quot;, {
  requiredConfig: ['name'],
  initialize: function (config) {
    var me = this;
    me.$super(&quot;sol.Base&quot;, &quot;initialize&quot;, arguments);
  },
  doSth: function () {  }
});

sol.define(&quot;custom.solution.Module2&quot;, {
  extend: &quot;custom.solution.BaseModule&quot;,
  doSthDifferent: function () {  }
});
</code></pre>
<h2>Creating a class</h2>
<p>A class instance can be created using <code>sol.create</code>. The advantage of this is that functions of the superclass can be overridden, even when a class is being instantiated.</p>
<pre><code>var myModule = sol.create(&quot;custom.solution.Module2&quot;, {
  name: &quot;My first module&quot;,
  doSth: function() { 
    // implement custom doSth function
  }
});
</code></pre>
<p>Config properties can be used to define values that must be entered when instantiating a class. In object relational models, this would correspond to a list of parameters that are passed to the class constructor. The base implementation <code>sol.Base</code> is also responsible for ensuring that all config properties defined in <code>requiredConfig</code> are transferred. Otherwise, it throws an exception.</p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> The <code>sol.common.ix.DynKwlDatabaseIterator</code> class has a series of mandatory configs that are required to trigger database queries. These include <code>sqlQuery</code>, <code>tableHeaders</code> and <code>tableKeyNames</code></span></p>
</blockquote>
<p>{@img img3.png}</p>
<h2>Pitfalls</h2>
<p>A class can be defined with the help of the <code>sol.define</code> function. Using prototypes means that the object instance contains static functions <span
style='font-weight:bold'>and properties</span>. This means that you may only define constants or static values at the class level.</p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> If an array is added to the class definition, the same instance of the array is available in all class instances that are created.</span><span
style='font-weight:bold;font-style:italic'> If you do not want this, you need to create the array in the </span><span
style='font-style:italic'><code>initialize</code></span><span style='font-weight:bold;
font-style:italic'> function of the class.</span></p>
</blockquote>
<p>Unlike object oriented programming languages such as Java, local properties with identical names can override those of the prototypes. </p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> The value</span><span
style='font-weight:bold;font-style:italic'> not set </span><span
style='font-style:italic'> is defined for a <code>name</code> property in the class definition. The <code>setName()</code> function sets the name at the instance level. The static name is not changed in this case as the local variable takes precedence. However, if you extend a defined array to class level, it applies for all other classes as you have not created a new array instance at the level of the class being instantiated.</span></p>
</blockquote>
<p><span class="tag_important">The documentation for <code>so.ClassManager</code> contains several examples in the chapter <span
style='font-style:italic'>Class Properties and Prototyping</span></span></p>

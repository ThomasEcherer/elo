<h1>ELOas scripting</h1>
<p>You should use as little code as possible in your own rules when developing ELOas rules. Functions should be passed to own modules.</p>
<h2>Template for JavaScript</h2>
<pre><code>// Java includes -&gt; important: leave first line empty

/**
 * Code documentation
 *
 * @author Max Mustermann, ELO Digital Office GmbH
 * @version X
 *
 * @requires my.namespace.MySuperclass
 * @requires my.namespace.MyMixin
 */
sol.define(&quot;my.namespace.MyClass&quot;, {
  singleton: true,
  extend: 'my.namespace.MySuperclass',
  mixins: ['my.namespace.MyMixin'],

  // properties section

  // optional
  initialize: function (config) {

  },

  // implementation section
  process: function() {}
});
</code></pre>
<h2>Template for ELOas rules</h2>
<pre><code>&lt;ruleset&gt;
  &lt;base&gt;
    &lt;name&gt;my.namespace.RuleName&lt;/name&gt;
    &lt;search&gt;
      &lt;name&gt;&quot;DIRECT&quot;&lt;/name&gt;
      &lt;value&gt;&quot;&quot;&lt;/value&gt;
      &lt;mask&gt;0&lt;/mask&gt;
      &lt;max&gt;200&lt;/max&gt;
    &lt;/search&gt;
    &lt;interval&gt;1H&lt;/interval&gt;
  &lt;/base&gt;
&lt;rule&gt;
  &lt;name&gt;Regel1&lt;/name&gt;
  &lt;condition&gt;&lt;/condition&gt;
  &lt;script&gt;
    EM_WRITE_CHANGED = false;

    var logger = sol.create(&quot;sol.Logger&quot;, { scope: &quot;my.namespace.RuleName&quot; });
    logger.enter(&quot;RuleName&quot;);

    // your code, e.g. calling superclass
    my.namespace.MyClass.process();

    logger.exit(&quot;RuleName&quot;);
  &lt;/script&gt;
&lt;/rule&gt;
&lt;rule&gt;
  &lt;name&gt;Global Error Rule&lt;/name&gt;
  &lt;condition&gt;OnError&lt;/condition&gt;
  &lt;script&gt;&lt;/script&gt;
&lt;/rule&gt;
&lt;/ruleset&gt;
</code></pre>

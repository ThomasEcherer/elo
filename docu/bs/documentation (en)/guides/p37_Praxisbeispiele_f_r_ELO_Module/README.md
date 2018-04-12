<h1>Practical examples for ELO modules</h1>
<p>Modularizing functions using own JS classes enables you to extend and document functions. The following shows several templates for creating new JS classes as well as utility classes.</p>
<h2>New JS class</h2>
<pre><code>//@include lib_Class.js.js

/**
 * Class documentation here
 *
 * @author {NAME}, ELO Digital Office GmbH
 * @version 1.0
 */
sol.define(&quot;sol.common.ClassName&quot;, {

  /** 
   * @cfg {String} objId
   */
  objId: undefined,

  /**
   * @property {Number} myProperty
   */
  myProperty: 123,

  initialize: function (config) {
    var me = this;
    me.$super(&quot;initialize&quot;, [config]);
  }

});
</code></pre>
<h2>Utility classes as singletons</h2>
<pre><code>//@include lib_Class.js.js

/**
 * @singleton
 *
 * Class documentation here
 *
 * @author {NAME}, ELO Digital Office GmbH
 * @version 1.0
 */
sol.define(&quot;sol.common.ClassName&quot;, {
  singleton: true,

});
</code></pre>

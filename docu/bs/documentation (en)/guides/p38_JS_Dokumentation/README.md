<h1>JS documentation</h1>
<p><span
style='font-weight:bold'>The documentation tool standard</span><a
href="https://github.com/senchalabs/jsduck/wiki"><span style='font-weight:bold;
font-style:italic'>JSDuck</span></a> is used as the basis for documenting the JS classes. When compares with other standards, this is the best method for mapping object relational approaches of the <a
href="#!/guide/p13_Klassenframework">class framework</a>.</p>
<p>The markdown syntax (md) provides extended documentation mechanisms. This describes the definition of headers and code blocks. Some examples:</p>
<pre><code># Header 1
## Header 2

    // Code, indented 4 characters
    var x = 0;
</code></pre>
<h2>Class documentation</h2>
<p>Classes should be documented with a description of the general function as well as several examples of how this class can be used. It is important to specify the version number and the name of the programmer:</p>
<pre><code>/**
 * Basic description of this class
 *
 * # Usage scenario 1
 *
 *     var tpl = sol.create('sol.common.Template', {
 *     });
 *
 * @author Name, Company
 * @version 1.0
 */
</code></pre>
<p>It is not necessary to document the inheritance and the class name with <code>@extend</code> and <code>@class</code>. Private functions and attributes must be marked with <code>@private</code>.</p>
<p>If classes expect a series of config parameters during instantiation, these must be marked with <code>@config</code>.</p>
<h2>Dependencies in other JS classes</h2>
<p>If a script has dependencies in other JS classes, these should be stored in the class description using the <code>@requires</code> tab.</p>
<h2>Functionality in ELO modules</h2>
<p>Programmers encounter different scripting environments when developing solutions. For example, ELOas, Java Client and Indexserver use the Rhino engine for running JS, whereas web applications use a browser such as Google Chrome. </p>
<pre><code>@eloall   // All ELO components and applications
@eloix    // ELO Indexserver
@eloas    // ELO Automation Services
@elojc    // ELO Java Client
@eloweb   // ELO Web Client
</code></pre>
<h2>Whole example</h2>
<pre><code>/**
 * Basic description of this class
 *
 * # Usage scenario 1
 *
 *     var tpl = sol.create('sol.common.Template', {
 *         source = 'Hello {{name}}.'
 *     });
 *
 *     var result = tpl.apply({
 *       name: 'Marcus'
 *     });
 *
 * @author Name, Company
 * @version 1.0
 *
 * @eloix
 * @eloas
 * @elojc
 * @requires handlebars.js
 */
sol.define(&quot;sol.common.Template&quot;, {

  /**
   * @cfg {String} source
   * Template source as a string.
   */
  source: 'not defined',

  /**
  * @private
  * Compiles the template string.
  */
  compile: function () {  },

  /**
   * Loads the template string from an ELO document
   * @param {String} ELO object ID
   */
  load: function (objId) {  },
});
</code></pre>

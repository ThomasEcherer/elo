Ext.data.JsonP.p38_JS_Dokumentation({"guide":"<h1 id='p38_JS_Dokumentation-section-js-documentation'>JS documentation</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/p38_JS_Dokumentation-section-class-documentation'>Class documentation</a>\n </li>\n<li>2. <a href='#!/guide/p38_JS_Dokumentation-section-dependencies-in-other-js-classes'>Dependencies in other JS classes</a>\n </li>\n<li>3. <a href='#!/guide/p38_JS_Dokumentation-section-functionality-in-elo-modules'>Functionality in ELO modules</a>\n </li>\n<li>4. <a href='#!/guide/p38_JS_Dokumentation-section-whole-example'>Whole example</a>\n </li>\n</ul></div>\n\n\n<p><span\nstyle='font-weight:bold'>The documentation tool standard</span><a\nhref=\"https://github.com/senchalabs/jsduck/wiki\"><span style='font-weight:bold;\nfont-style:italic'>JSDuck</span></a> is used as the basis for documenting the JS classes. When compares with other standards, this is the best method for mapping object relational approaches of the <a\nhref=\"#!/guide/p13_Klassenframework\">class framework</a>.</p>\n\n\n<p>The markdown syntax (md) provides extended documentation mechanisms. This describes the definition of headers and code blocks. Some examples:</p>\n\n\n<pre><code># Header 1\n## Header 2\n\n    // Code, indented 4 characters\n    var x = 0;\n</code></pre>\n\n\n<h2 id='p38_JS_Dokumentation-section-class-documentation'>Class documentation</h2>\n\n\n<p>Classes should be documented with a description of the general function as well as several examples of how this class can be used. It is important to specify the version number and the name of the programmer:</p>\n\n\n<pre><code>/**\n * Basic description of this class\n *\n * # Usage scenario 1\n *\n *     var tpl = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>('<a href=\"#!/api/sol.common.Template\" rel=\"sol.common.Template\" class=\"docClass\">sol.common.Template</a>', {\n *     });\n *\n * @author Name, Company\n * @version 1.0\n */\n</code></pre>\n\n\n<p>It is not necessary to document the inheritance and the class name with <code>@extend</code> and <code>@class</code>. Private functions and attributes must be marked with <code>@private</code>.</p>\n\n\n<p>If classes expect a series of config parameters during instantiation, these must be marked with <code>@config</code>.</p>\n\n\n<h2 id='p38_JS_Dokumentation-section-dependencies-in-other-js-classes'>Dependencies in other JS classes</h2>\n\n\n<p>If a script has dependencies in other JS classes, these should be stored in the class description using the <code>@requires</code> tab.</p>\n\n\n<h2 id='p38_JS_Dokumentation-section-functionality-in-elo-modules'>Functionality in ELO modules</h2>\n\n\n<p>Programmers encounter different scripting environments when developing solutions. For example, ELOas, Java Client and Indexserver use the Rhino engine for running JS, whereas web applications use a browser such as Google Chrome. </p>\n\n\n<pre><code>@eloall   // All ELO components and applications\n@eloix    // ELO Indexserver\n@eloas    // ELO Automation Services\n@elojc    // ELO Java Client\n@eloweb   // ELO Web Client\n</code></pre>\n\n\n<h2 id='p38_JS_Dokumentation-section-whole-example'>Whole example</h2>\n\n\n<pre><code>/**\n * Basic description of this class\n *\n * # Usage scenario 1\n *\n *     var tpl = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>('<a href=\"#!/api/sol.common.Template\" rel=\"sol.common.Template\" class=\"docClass\">sol.common.Template</a>', {\n *         source = 'Hello {{name}}.'\n *     });\n *\n *     var result = tpl.apply({\n *       name: 'Marcus'\n *     });\n *\n * @author Name, Company\n * @version 1.0\n *\n * @eloix\n * @eloas\n * @elojc\n * @requires handlebars.js\n */\n<a href=\"#!/api/sol-static-method-define\" rel=\"sol-static-method-define\" class=\"docClass\">sol.define</a>(&quot;<a href=\"#!/api/sol.common.Template\" rel=\"sol.common.Template\" class=\"docClass\">sol.common.Template</a>&quot;, {\n\n  /**\n   * @cfg {String} source\n   * Template source as a string.\n   */\n  source: 'not defined',\n\n  /**\n  * @private\n  * Compiles the template string.\n  */\n  compile: function () {  },\n\n  /**\n   * Loads the template string from an ELO document\n   * @param {String} ELO object ID\n   */\n  load: function (objId) {  },\n});\n</code></pre>\n\n","title":"JS documentation"});
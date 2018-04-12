<h1>Java Client scripting</h1>
<p>You should generally avoid using client-side scripting in Java Client scripting. Actions such as creating folders should be implemented using IX functions so that they are also available in the Web Client.</p>
<p>Java Client scripts should also be combined into <code>main</code> classes to give you central access to the classes used.</p>
<h2>Combining all scripts into a main class</h2>
<p>Required scripts are combined into a <span
style='font-weight:bold'><code>main</code></span> class. This makes debugging easier and enables you to properly integrate all <code>include</code> calls.</p>
<p>Here is an example using the <code>sol.common.jc.Main</code> class:</p>
<pre><code>importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.Json.js
//@include lib_sol.common.Compatibility.js
//@include lib_sol.common.IxUtils.js
//@include lib_sol.common.Config.js
//@include lib_sol.common.jc.Functions.js
//@include lib_sol.common.jc.Ribbon.js

/**
 * @class sol.common.jc.Main
 * @singleton
 *
 * Contructs the JavaClient script.
 * Contains all necessary includes.
 *
 * # JavaClient resource files
 *
 * The resource files contain the text translation for the supported languages.
 *
 * - text_sol.common.client (default file with english texts)
 * - text_sol.common.client_DE
 *
 * # Scriptbutton Overview
 *
 * - Common-&gt;VersionsReport  Generate Report : 900
 * - Common-&gt;VersionsReport  Validate Report : 901
 *
 * @author Business Solutions, ELO Digital Office GmbH
 * @version 1.0
 *
 * @requires sol.common.Json
 * @requires sol.common.jc.Functions
 * @requires sol.common.jc.Ribbon
 */
</code></pre>

Ext.data.JsonP.sol_common_Locale({"tagname":"class","name":"sol.common.Locale","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"requires":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"lib_sol.common.Locale.js","href":"lib_sol.common.Locale.html#sol-common-Locale"}],"author":[{"tagname":"author","name":"MW, ELO Digital Office GmbH","email":null}],"version":["1.0"],"eloall":true,"aliases":{},"alternateClassNames":[],"extends":"sol.Base","mixins":[],"requires":[],"uses":[],"members":[{"name":"requiredConfig","tagname":"cfg","owner":"sol.Base","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"decimalFormatSymbols","tagname":"property","owner":"sol.common.Locale","id":"property-decimalFormatSymbols","meta":{}},{"name":"decimalSeparator","tagname":"property","owner":"sol.common.Locale","id":"property-decimalSeparator","meta":{}},{"name":"groupingSeparator","tagname":"property","owner":"sol.common.Locale","id":"property-groupingSeparator","meta":{}},{"name":"language","tagname":"property","owner":"sol.common.Locale","id":"property-language","meta":{}},{"name":"locale","tagname":"property","owner":"sol.common.Locale","id":"property-locale","meta":{}},{"name":"logger","tagname":"property","owner":"sol.Base","id":"property-logger","meta":{"protected":true}},{"name":"profileOpts","tagname":"property","owner":"sol.common.Locale","id":"property-profileOpts","meta":{}},{"name":"requiredProperties","tagname":"property","owner":"sol.common.Locale","id":"property-requiredProperties","meta":{"private":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"formatDecimal","tagname":"method","owner":"sol.common.Locale","id":"method-formatDecimal","meta":{}},{"name":"getDefaultDateFormat","tagname":"method","owner":"sol.common.Locale","id":"method-getDefaultDateFormat","meta":{"private":true}},{"name":"getDefaultDecimalSeparator","tagname":"method","owner":"sol.common.Locale","id":"method-getDefaultDecimalSeparator","meta":{}},{"name":"getDefaultGroupingSeparator","tagname":"method","owner":"sol.common.Locale","id":"method-getDefaultGroupingSeparator","meta":{}},{"name":"initialize","tagname":"method","owner":"sol.Base","id":"method-initialize","meta":{"private":true}},{"name":"javaCharToJsString","tagname":"method","owner":"sol.common.Locale","id":"method-javaCharToJsString","meta":{"private":true}},{"name":"normalizeDateFormat","tagname":"method","owner":"sol.common.Locale","id":"method-normalizeDateFormat","meta":{"private":true}},{"name":"read","tagname":"method","owner":"sol.common.Locale","id":"method-read","meta":{}}],"code_type":"ext_define","id":"class-sol.common.Locale","short_doc":"Helper class for reading a users locale settings. ...","classIcon":"icon-class","superclasses":["sol.Base"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><strong>sol.common.Locale</strong></div></div><h4>Files</h4><div class='dependency'><a href='source/lib_sol.common.Locale.html#sol-common-Locale' target='_blank'>lib_sol.common.Locale.js</a></div></pre><div class='doc-contents'><p>Helper class for reading a users locale settings.</p>\n\n<pre><code>var locale = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>('<a href=\"#!/api/sol.common.Locale\" rel=\"sol.common.Locale\" class=\"docClass\">sol.common.Locale</a>', {\n  ec: ec\n});\n\n// read user profile opts and default values\nlocale.read();\n\n// access properties of the locale object\nvar lang = locale.language;\n</code></pre>\n      <p class='version-tag'>Version: <b>1.0</b></p>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div id='cfg-requiredConfig' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-decimalFormatSymbols' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Locale'>sol.common.Locale</span><br/><a href='source/lib_sol.common.Locale.html#sol-common-Locale-property-decimalFormatSymbols' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Locale-property-decimalFormatSymbols' class='name expandable'>decimalFormatSymbols</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div><div id='property-decimalSeparator' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Locale'>sol.common.Locale</span><br/><a href='source/lib_sol.common.Locale.html#sol-common-Locale-property-decimalSeparator' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Locale-property-decimalSeparator' class='name expandable'>decimalSeparator</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div><div id='property-groupingSeparator' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Locale'>sol.common.Locale</span><br/><a href='source/lib_sol.common.Locale.html#sol-common-Locale-property-groupingSeparator' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Locale-property-groupingSeparator' class='name expandable'>groupingSeparator</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div><div id='property-language' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Locale'>sol.common.Locale</span><br/><a href='source/lib_sol.common.Locale.html#sol-common-Locale-property-language' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Locale-property-language' class='name expandable'>language</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'>ISO language code of this user. ...</div><div class='long'><p>ISO language code of this user.</p>\n\n<pre><code>language = \"de\"\n</code></pre>\n</div></div></div><div id='property-locale' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Locale'>sol.common.Locale</span><br/><a href='source/lib_sol.common.Locale.html#sol-common-Locale-property-locale' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Locale-property-locale' class='name expandable'>locale</a> : java.util.Locale<span class=\"signature\"></span></div><div class='description'><div class='short'><p>Java locale object for this users language.</p>\n</div><div class='long'><p>Java locale object for this users language.</p>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>Logger for this class instance. ...</div><div class='long'><p>Logger for this class instance. This logger is created by <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a>.</p>\n\n<p>Please see <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a> class documentation for more information.</p>\n</div></div></div><div id='property-profileOpts' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Locale'>sol.common.Locale</span><br/><a href='source/lib_sol.common.Locale.html#sol-common-Locale-property-profileOpts' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Locale-property-profileOpts' class='name expandable'>profileOpts</a> : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Settings from this users profileOpts database. ...</div><div class='long'><p>Settings from this users profileOpts database.</p>\n<ul><li><span class='pre'>useDefaultDateFormat</span> : Object<div class='sub-desc'><p>Is true if default date format should be used.</p>\n</div></li><li><span class='pre'>dateFormat</span> : Object<div class='sub-desc'><p>Java Client date format entered by the user.</p>\n</div></li><li><span class='pre'>useDefaultSystemSeparator</span> : Object<div class='sub-desc'><p>Is true if default separator format should be used.</p>\n</div></li><li><span class='pre'>decimalSeparator</span> : Object<div class='sub-desc'><p>Separator setting from the Java Client that was entered by the user.</p>\n</div></li><li><span class='pre'>thousandSeparator</span> : Object<div class='sub-desc'><p>Thousand Separator setting from the Java Client that was entered by the user.</p>\n</div></li></ul></div></div></div><div id='property-requiredProperties' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Locale'>sol.common.Locale</span><br/><a href='source/lib_sol.common.Locale.html#sol-common-Locale-property-requiredProperties' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Locale-property-requiredProperties' class='name expandable'>requiredProperties</a> : Array<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'> ...</div><div class='long'>\n<p>Defaults to: <code>[&quot;ec&quot;]</code></p></div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-formatDecimal' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Locale'>sol.common.Locale</span><br/><a href='source/lib_sol.common.Locale.html#sol-common-Locale-method-formatDecimal' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Locale-method-formatDecimal' class='name expandable'>formatDecimal</a>( <span class='pre'>decimal, params</span> ) : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Formats a decimal number ...</div><div class='long'><p>Formats a decimal number</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>decimal</span> : String<div class='sub-desc'><p>Decimal</p>\n</div></li><li><span class='pre'>params</span> : Object<div class='sub-desc'><p>Parameters</p>\n<ul><li><span class='pre'>minimumFractionDigits</span> : Number<div class='sub-desc'><p>Minimum fraction digits</p>\n</div></li><li><span class='pre'>maximumFractionDigits</span> : Number<div class='sub-desc'><p>Maximum fraction digits</p>\n</div></li><li><span class='pre'>groupingUsed</span> : Boolean<div class='sub-desc'><p>Grouping used</p>\n</div></li></ul></div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'><p>Formatted decimal</p>\n</div></li></ul></div></div></div><div id='method-getDefaultDateFormat' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Locale'>sol.common.Locale</span><br/><a href='source/lib_sol.common.Locale.html#sol-common-Locale-method-getDefaultDateFormat' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Locale-method-getDefaultDateFormat' class='name expandable'>getDefaultDateFormat</a>( <span class='pre'></span> ) : String<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>reads the defaults date format from the java locale class. ...</div><div class='long'><p>reads the defaults date format from the java locale class.</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'><p>date result</p>\n</div></li></ul></div></div></div><div id='method-getDefaultDecimalSeparator' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Locale'>sol.common.Locale</span><br/><a href='source/lib_sol.common.Locale.html#sol-common-Locale-method-getDefaultDecimalSeparator' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Locale-method-getDefaultDecimalSeparator' class='name expandable'>getDefaultDecimalSeparator</a>( <span class='pre'></span> ) : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns the default decimal separator ...</div><div class='long'><p>Returns the default decimal separator</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'><p>default decimal separator</p>\n</div></li></ul></div></div></div><div id='method-getDefaultGroupingSeparator' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Locale'>sol.common.Locale</span><br/><a href='source/lib_sol.common.Locale.html#sol-common-Locale-method-getDefaultGroupingSeparator' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Locale-method-getDefaultGroupingSeparator' class='name expandable'>getDefaultGroupingSeparator</a>( <span class='pre'></span> ) : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns the default grouping separator ...</div><div class='long'><p>Returns the default grouping separator</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'><p>default grouping separator</p>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul></div></div></div><div id='method-javaCharToJsString' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Locale'>sol.common.Locale</span><br/><a href='source/lib_sol.common.Locale.html#sol-common-Locale-method-javaCharToJsString' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Locale-method-javaCharToJsString' class='name expandable'>javaCharToJsString</a>( <span class='pre'>javaChar</span> ) : String<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'> ...</div><div class='long'>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>javaChar</span> : Char<div class='sub-desc'><p>java character</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'><p>java character</p>\n</div></li></ul></div></div></div><div id='method-normalizeDateFormat' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Locale'>sol.common.Locale</span><br/><a href='source/lib_sol.common.Locale.html#sol-common-Locale-method-normalizeDateFormat' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Locale-method-normalizeDateFormat' class='name expandable'>normalizeDateFormat</a>( <span class='pre'>dateFormat</span> ) : String<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'> ...</div><div class='long'>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>dateFormat</span> : Object<div class='sub-desc'><p>Java Client date format entered by the user.</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'><p>date result</p>\n</div></li></ul></div></div></div><div id='method-read' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Locale'>sol.common.Locale</span><br/><a href='source/lib_sol.common.Locale.html#sol-common-Locale-method-read' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Locale-method-read' class='name expandable'>read</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Reads and processes locale specific data from the elo profile opts database and java locale defaults. ...</div><div class='long'><p>Reads and processes locale specific data from the elo profile opts database and java locale defaults.</p>\n</div></div></div></div></div></div></div>","meta":{"eloall":true}});
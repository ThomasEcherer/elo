Ext.data.JsonP.sol_common_DecimalUtils({"tagname":"class","name":"sol.common.DecimalUtils","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"uses":true,"members":true,"code_type":true,"singleton":true},"files":[{"filename":"lib_sol.common.DecimalUtils.js","href":"lib_sol.common.DecimalUtils.html#sol-common-DecimalUtils"}],"author":[{"tagname":"author","name":"MW, ELO Digital Office GmbH","email":null}],"requires":["decimal-light","moment"],"aliases":{},"alternateClassNames":[],"extends":"sol.Base","mixins":[],"uses":[],"members":[{"name":"requiredConfig","tagname":"cfg","owner":"sol.Base","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"logger","tagname":"property","owner":"sol.Base","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"configureDecimals","tagname":"method","owner":"sol.common.DecimalUtils","id":"method-configureDecimals","meta":{}},{"name":"initialize","tagname":"method","owner":"sol.Base","id":"method-initialize","meta":{"private":true}},{"name":"replaceAll","tagname":"method","owner":"sol.common.DecimalUtils","id":"method-replaceAll","meta":{"private":true}},{"name":"toDecimal","tagname":"method","owner":"sol.common.DecimalUtils","id":"method-toDecimal","meta":{}}],"code_type":"ext_define","singleton":true,"id":"class-sol.common.DecimalUtils","short_doc":"Utils for handling decimals. ...","classIcon":"icon-singleton","superclasses":["sol.Base"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><strong>sol.common.DecimalUtils</strong></div></div><h4>Requires</h4><div class='dependency'>decimal-light</div><div class='dependency'>moment</div><h4>Files</h4><div class='dependency'><a href='source/lib_sol.common.DecimalUtils.html#sol-common-DecimalUtils' target='_blank'>lib_sol.common.DecimalUtils.js</a></div></pre><div class='doc-contents'><p>Utils for handling decimals.</p>\n\n<p>Uses decimal.js-light.\nPlease refer to the official documentation of decimal.js-light for further information:\nhttp://mikemcl.github.io/decimal.js-light/</p>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div id='cfg-requiredConfig' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>Logger for this class instance. ...</div><div class='long'><p>Logger for this class instance. This logger is created by <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a>.</p>\n\n<p>Please see <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a> class documentation for more information.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-configureDecimals' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.DecimalUtils'>sol.common.DecimalUtils</span><br/><a href='source/lib_sol.common.DecimalUtils.html#sol-common-DecimalUtils-method-configureDecimals' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.DecimalUtils-method-configureDecimals' class='name expandable'>configureDecimals</a>( <span class='pre'>config</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Configure Decimals ...</div><div class='long'><p>Configure Decimals</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>Configuration</p>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul></div></div></div><div id='method-replaceAll' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.DecimalUtils'>sol.common.DecimalUtils</span><br/><a href='source/lib_sol.common.DecimalUtils.html#sol-common-DecimalUtils-method-replaceAll' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.DecimalUtils-method-replaceAll' class='name expandable'>replaceAll</a>( <span class='pre'>str, target, replacement</span> ) : String<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Replaces every occurrence of a substring with another string ...</div><div class='long'><p>Replaces every occurrence of a substring with another string</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>str</span> : String<div class='sub-desc'><p>Input string</p>\n</div></li><li><span class='pre'>target</span> : String<div class='sub-desc'><p>String to replace</p>\n</div></li><li><span class='pre'>replacement</span> : String<div class='sub-desc'><p>Replacement string</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'><p>String</p>\n</div></li></ul></div></div></div><div id='method-toDecimal' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.DecimalUtils'>sol.common.DecimalUtils</span><br/><a href='source/lib_sol.common.DecimalUtils.html#sol-common-DecimalUtils-method-toDecimal' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.DecimalUtils-method-toDecimal' class='name expandable'>toDecimal</a>( <span class='pre'>value, params</span> ) : Decimal<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns a Decimal ...</div><div class='long'><p>Returns a Decimal</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>value</span> : String<div class='sub-desc'><p>Value</p>\n</div></li><li><span class='pre'>params</span> : Object<div class='sub-desc'><p>parameters</p>\n<ul><li><span class='pre'>type</span> : String<div class='sub-desc'><p>Type</p>\n</div></li><li><span class='pre'>thousandsSeparator</span> : String<div class='sub-desc'><p>Thousands separator</p>\n</div></li><li><span class='pre'>decimalSeparator</span> : String<div class='sub-desc'><p>Decimal separator</p>\n</div></li></ul></div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Decimal</span><div class='sub-desc'>\n</div></li></ul></div></div></div></div></div></div></div>","meta":{"singleton":true}});
Ext.data.JsonP.sol_common_web_ActionDefinitionUtils({"tagname":"class","name":"sol.common.web.ActionDefinitionUtils","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"uses":true,"members":true,"code_type":true,"singleton":true},"files":[{"filename":"sol.common.web.ActionDefinitionUtils.js","href":"sol.common.web.ActionDefinitionUtils.html#sol-common-web-ActionDefinitionUtils"}],"requires":["sol.common.IxUtils"],"aliases":{},"alternateClassNames":[],"extends":"sol.Base","mixins":[],"uses":[],"members":[{"name":"requiredConfig","tagname":"cfg","owner":"sol.Base","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"TAB_CONST","tagname":"property","owner":"sol.common.web.ActionDefinitionUtils","id":"property-TAB_CONST","meta":{"private":true}},{"name":"logger","tagname":"property","owner":"sol.Base","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"buildRibbonFromDefinition","tagname":"method","owner":"sol.common.web.ActionDefinitionUtils","id":"method-buildRibbonFromDefinition","meta":{"private":true}},{"name":"initialize","tagname":"method","owner":"sol.Base","id":"method-initialize","meta":{"private":true}},{"name":"initializeRibbon","tagname":"method","owner":"sol.common.web.ActionDefinitionUtils","id":"method-initializeRibbon","meta":{}}],"code_type":"ext_define","singleton":true,"id":"class-sol.common.web.ActionDefinitionUtils","short_doc":"This class loads ELO Business Solutions action definitions and creates the ribbon, button groups and buttons. ...","classIcon":"icon-singleton","superclasses":["sol.Base"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><strong>sol.common.web.ActionDefinitionUtils</strong></div></div><h4>Requires</h4><div class='dependency'><a href='#!/api/sol.common.IxUtils' rel='sol.common.IxUtils' class='docClass'>sol.common.IxUtils</a></div><h4>Files</h4><div class='dependency'><a href='source/sol.common.web.ActionDefinitionUtils.html#sol-common-web-ActionDefinitionUtils' target='_blank'>sol.common.web.ActionDefinitionUtils.js</a></div></pre><div class='doc-contents'><p>This class loads ELO Business Solutions action definitions and creates the ribbon, button groups and buttons.</p>\n\n<p>This class is automatically called during client startup.</p>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div id='cfg-requiredConfig' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-TAB_CONST' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.web.ActionDefinitionUtils'>sol.common.web.ActionDefinitionUtils</span><br/><a href='source/sol.common.web.ActionDefinitionUtils.html#sol-common-web-ActionDefinitionUtils-property-TAB_CONST' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.web.ActionDefinitionUtils-property-TAB_CONST' class='name expandable'>TAB_CONST</a> : Object<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'> ...</div><div class='long'>\n<p>Defaults to: <code>{HOME: {name: &quot;START&quot;, position: 1000}, DOCUMENT: {name: &quot;EXTENDED&quot;, position: 2000}, ARCHIVE: {}, VIEW: {name: &quot;VIEW&quot;, position: 3000}, WORKFLOW: {name: &quot;TASK&quot;, position: 4000}, INTRAY: {}, SEARCH: {name: &quot;SEARCH&quot;, position: 6000}}</code></p></div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>Logger for this class instance. ...</div><div class='long'><p>Logger for this class instance. This logger is created by <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a>.</p>\n\n<p>Please see <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a> class documentation for more information.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-buildRibbonFromDefinition' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.web.ActionDefinitionUtils'>sol.common.web.ActionDefinitionUtils</span><br/><a href='source/sol.common.web.ActionDefinitionUtils.html#sol-common-web-ActionDefinitionUtils-method-buildRibbonFromDefinition' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.web.ActionDefinitionUtils-method-buildRibbonFromDefinition' class='name expandable'>buildRibbonFromDefinition</a>( <span class='pre'>defs</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Builds the web client ribbon based on ribbon button/ group/ tab definitions given by RF_sol_common_services_ActionDef...</div><div class='long'><p>Builds the web client ribbon based on ribbon button/ group/ tab definitions given by RF_sol_common_services_ActionDefinitionCollector.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>defs</span> : Object[]<div class='sub-desc'><p>action/ ribbon definition</p>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul></div></div></div><div id='method-initializeRibbon' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.web.ActionDefinitionUtils'>sol.common.web.ActionDefinitionUtils</span><br/><a href='source/sol.common.web.ActionDefinitionUtils.html#sol-common-web-ActionDefinitionUtils-method-initializeRibbon' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.web.ActionDefinitionUtils-method-initializeRibbon' class='name expandable'>initializeRibbon</a>( <span class='pre'>contect</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Initializes ribbon buttons, groups and tabs for ELO Business Solutions. ...</div><div class='long'><p>Initializes ribbon buttons, groups and tabs for ELO Business Solutions.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>contect</span> : Object<div class='sub-desc'><p>. The current script scope.</p>\n</div></li></ul></div></div></div></div></div></div></div>","meta":{"singleton":true}});
Ext.data.JsonP.sol_common_jc_ActionHandler({"tagname":"class","name":"sol.common.jc.ActionHandler","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"uses":true,"members":true,"code_type":true,"singleton":true},"files":[{"filename":"lib_sol.common.jc.ActionHandler.js","href":"lib_sol.common.jc.ActionHandler.html#sol-common-jc-ActionHandler"}],"author":[{"tagname":"author","name":"PZ, ELO Digital Office GmbH","email":null}],"version":["1.03.000"],"elojc":true,"requires":["sol.common.IxUtils","sol.common.JsonUtils","sol.common.ObjectUtils"],"aliases":{},"alternateClassNames":[],"extends":"sol.Base","mixins":[],"uses":[],"members":[{"name":"requiredConfig","tagname":"cfg","owner":"sol.Base","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"logger","tagname":"property","owner":"sol.Base","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"execute","tagname":"method","owner":"sol.common.jc.ActionHandler","id":"method-execute","meta":{}},{"name":"executeAS","tagname":"method","owner":"sol.common.jc.ActionHandler","id":"method-executeAS","meta":{}},{"name":"handleEvents","tagname":"method","owner":"sol.common.jc.ActionHandler","id":"method-handleEvents","meta":{"private":true}},{"name":"initialize","tagname":"method","owner":"sol.Base","id":"method-initialize","meta":{"private":true}}],"code_type":"ext_define","singleton":true,"id":"class-sol.common.jc.ActionHandler","short_doc":"This class provides utility functions to call IX or AS functions and handle the response in a standardized way. ...","classIcon":"icon-singleton","superclasses":["sol.Base"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><strong>sol.common.jc.ActionHandler</strong></div></div><h4>Requires</h4><div class='dependency'><a href='#!/api/sol.common.IxUtils' rel='sol.common.IxUtils' class='docClass'>sol.common.IxUtils</a></div><div class='dependency'><a href='#!/api/sol.common.JsonUtils' rel='sol.common.JsonUtils' class='docClass'>sol.common.JsonUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ObjectUtils' rel='sol.common.ObjectUtils' class='docClass'>sol.common.ObjectUtils</a></div><h4>Files</h4><div class='dependency'><a href='source/lib_sol.common.jc.ActionHandler.html#sol-common-jc-ActionHandler' target='_blank'>lib_sol.common.jc.ActionHandler.js</a></div></pre><div class='doc-contents'><p>This class provides utility functions to call IX or AS functions and handle the response in a standardized way.</p>\n\n<p>Following example shows executing an Index Server action.</p>\n\n<pre><code><a href=\"#!/api/sol.common.jc.ActionHandler-method-execute\" rel=\"sol.common.jc.ActionHandler-method-execute\" class=\"docClass\">sol.common.jc.ActionHandler.execute</a>('RF_sol_pubsec_functions_CreateFile', {\n    objId: '123'\n  }, function ( result ) {\n    // handle resultObj returned by the action\n  });\n</code></pre>\n\n<h1>Supported events</h1>\n\n<ul>\n<li>REFRESH</li>\n<li>GOTO</li>\n<li>DIALOG</li>\n<li>ERROR</li>\n<li>ACTION</li>\n<li>FEEDBACK</li>\n</ul>\n\n\n<h1>Conditional events</h1>\n\n<p>It is possible for actions to declare the events as conditional.\nTherefor they have to declare a <code>ON</code> attribute (see <a href=\"#!/api/sol.common.ActionBase\" rel=\"sol.common.ActionBase\" class=\"docClass\">sol.common.ActionBase</a>).</p>\n      <p class='version-tag'>Version: <b>1.03.000</b></p>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div id='cfg-requiredConfig' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>Logger for this class instance. ...</div><div class='long'><p>Logger for this class instance. This logger is created by <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a>.</p>\n\n<p>Please see <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a> class documentation for more information.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-execute' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.jc.ActionHandler'>sol.common.jc.ActionHandler</span><br/><a href='source/lib_sol.common.jc.ActionHandler.html#sol-common-jc-ActionHandler-method-execute' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.jc.ActionHandler-method-execute' class='name expandable'>execute</a>( <span class='pre'>registeredFunctionName, [params], [callback]</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Executes a IX registered function and handles the response in a standardized way. ...</div><div class='long'><p>Executes a IX registered function and handles the response in a standardized way.</p>\n\n<p>Depricated feature:\nIf special handling is needed a custom callback can be spezified as parameter.\nThis callback get's the result Object of the registered function as only parameter.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>registeredFunctionName</span> : String<div class='sub-desc'>\n</div></li><li><span class='pre'>params</span> : Object (optional)<div class='sub-desc'><p>The configuration object which will be send to the registered function</p>\n</div></li><li><span class='pre'>callback</span> : Function (optional)<div class='sub-desc'><p>Should not be used, due to client interoperability</p>\n</div></li></ul></div></div></div><div id='method-executeAS' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.jc.ActionHandler'>sol.common.jc.ActionHandler</span><br/><a href='source/lib_sol.common.jc.ActionHandler.html#sol-common-jc-ActionHandler-method-executeAS' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.jc.ActionHandler-method-executeAS' class='name expandable'>executeAS</a>( <span class='pre'>solutionName, ruleName, [param2Obj], [callback], [async]</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Executes an ELOas ruleset and handles the response in a standardized way. ...</div><div class='long'><p>Executes an ELOas ruleset and handles the response in a standardized way.</p>\n\n<p>If spezial handling is needed a custom callback can be spezified as parameter.\nThis callback get's the result Object of the registered function as only parameter.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>solutionName</span> : String<div class='sub-desc'><p>Name used to determine the ELOas configuration (see <a href=\"#!/api/sol.common.Config-method-loadEloAsConfig\" rel=\"sol.common.Config-method-loadEloAsConfig\" class=\"docClass\">loadEloAsConfig</a>)</p>\n</div></li><li><span class='pre'>ruleName</span> : String<div class='sub-desc'><p>Rule name</p>\n</div></li><li><span class='pre'>param2Obj</span> : Object (optional)<div class='sub-desc'><p>The configuration object which will be send to the ELOas rule as PARAM2 (JSON String)</p>\n</div></li><li><span class='pre'>callback</span> : Function (optional)<div class='sub-desc'><p>Should not be used anymore, due to client interoperability</p>\n</div></li><li><span class='pre'>async</span> : Boolean (optional)<div class='sub-desc'><p>Not supported anymore, due to client interoperability</p>\n</div></li></ul></div></div></div><div id='method-handleEvents' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.jc.ActionHandler'>sol.common.jc.ActionHandler</span><br/><a href='source/lib_sol.common.jc.ActionHandler.html#sol-common-jc-ActionHandler-method-handleEvents' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.jc.ActionHandler-method-handleEvents' class='name expandable'>handleEvents</a>( <span class='pre'>events</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'> ...</div><div class='long'>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>events</span> : Array<div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul></div></div></div></div></div></div></div>","meta":{"elojc":true,"singleton":true}});
Ext.data.JsonP.sol_common_monitoring_as_executors_SimpleExecutor({"tagname":"class","name":"sol.common_monitoring.as.executors.SimpleExecutor","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"lib_sol.common_monitoring.as.executors.SimpleExecutor.js","href":"lib_sol.common_monitoring.as.executors.SimpleExecutor.html#sol-common_monitoring-as-executors-SimpleExecutor"}],"author":[{"tagname":"author","name":"PZ, ELO Digital Office GmbH","email":null}],"version":["1.01.000"],"eloas":true,"requires":["sol.common.DateUtils","sol.common.IxUtils","sol.common.ObjectFormatter","sol.common.ObjectUtils","sol.common.SordUtils","sol.common.Template","sol.common.TranslateTerms","sol.common.WfUtils"],"aliases":{},"alternateClassNames":[],"extends":"sol.Base","mixins":[],"uses":[],"members":[{"name":"requiredConfig","tagname":"cfg","owner":"sol.Base","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"user","tagname":"cfg","owner":"sol.common_monitoring.as.executors.SimpleExecutor","id":"cfg-user","meta":{}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"ACTIONS","tagname":"property","owner":"sol.common_monitoring.as.executors.SimpleExecutor","id":"property-ACTIONS","meta":{"private":true}},{"name":"_todayIso","tagname":"property","owner":"sol.common_monitoring.as.executors.SimpleExecutor","id":"property-_todayIso","meta":{"private":true}},{"name":"_userConnectionCache","tagname":"property","owner":"sol.common_monitoring.as.executors.SimpleExecutor","id":"property-_userConnectionCache","meta":{"private":true}},{"name":"logger","tagname":"property","owner":"sol.Base","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"buildName","tagname":"method","owner":"sol.common_monitoring.as.executors.SimpleExecutor","id":"method-buildName","meta":{"private":true}},{"name":"dispose","tagname":"method","owner":"sol.common_monitoring.as.executors.SimpleExecutor","id":"method-dispose","meta":{}},{"name":"eveluateActionProperty","tagname":"method","owner":"sol.common_monitoring.as.executors.SimpleExecutor","id":"method-eveluateActionProperty","meta":{"private":true}},{"name":"execute","tagname":"method","owner":"sol.common_monitoring.as.executors.SimpleExecutor","id":"method-execute","meta":{}},{"name":"executeAction","tagname":"method","owner":"sol.common_monitoring.as.executors.SimpleExecutor","id":"method-executeAction","meta":{"private":true}},{"name":"getConnection","tagname":"method","owner":"sol.common_monitoring.as.executors.SimpleExecutor","id":"method-getConnection","meta":{"private":true}},{"name":"initialize","tagname":"method","owner":"sol.common_monitoring.as.executors.SimpleExecutor","id":"method-initialize","meta":{"private":true}}],"code_type":"ext_define","id":"class-sol.common_monitoring.as.executors.SimpleExecutor","short_doc":"This executor can be used to start simple tasks. ...","classIcon":"icon-class","superclasses":["sol.Base"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><strong>sol.common_monitoring.as.executors.SimpleExecutor</strong></div></div><h4>Requires</h4><div class='dependency'><a href='#!/api/sol.common.DateUtils' rel='sol.common.DateUtils' class='docClass'>sol.common.DateUtils</a></div><div class='dependency'><a href='#!/api/sol.common.IxUtils' rel='sol.common.IxUtils' class='docClass'>sol.common.IxUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ObjectFormatter' rel='sol.common.ObjectFormatter' class='docClass'>sol.common.ObjectFormatter</a></div><div class='dependency'><a href='#!/api/sol.common.ObjectUtils' rel='sol.common.ObjectUtils' class='docClass'>sol.common.ObjectUtils</a></div><div class='dependency'><a href='#!/api/sol.common.SordUtils' rel='sol.common.SordUtils' class='docClass'>sol.common.SordUtils</a></div><div class='dependency'><a href='#!/api/sol.common.Template' rel='sol.common.Template' class='docClass'>sol.common.Template</a></div><div class='dependency'><a href='#!/api/sol.common.TranslateTerms' rel='sol.common.TranslateTerms' class='docClass'>sol.common.TranslateTerms</a></div><div class='dependency'><a href='#!/api/sol.common.WfUtils' rel='sol.common.WfUtils' class='docClass'>sol.common.WfUtils</a></div><h4>Files</h4><div class='dependency'><a href='source/lib_sol.common_monitoring.as.executors.SimpleExecutor.html#sol-common_monitoring-as-executors-SimpleExecutor' target='_blank'>lib_sol.common_monitoring.as.executors.SimpleExecutor.js</a></div></pre><div class='doc-contents'><p>This executor can be used to start simple tasks.</p>\n\n<p>That an action can be executed it has to define a type. Supported types are:</p>\n\n<ul>\n<li>workflows: <code>type=\"WORKFLOW\"</code> (starts a workflow)</li>\n<li>technical workflows: <code>type=\"TECHNICAL_WORKFLOW\"</code> (starts a workflow and deletes it after execution if the workflow is already finished, i.e. does not contain any user nodes)</li>\n<li>reminder: <code>type=\"REMINDER\"</code> (creates a reminder)</li>\n<li>function modules: <code>type=\"FUNCTION\"</code> (executes a function with the objId of the current object as only parameter)</li>\n</ul>\n\n\n<h1>Enhancement</h1>\n\n<p>An analyzer can enhance a context object with additional information.\nSome properties in the action definition can use those information to dynamically change the configuration property.</p>\n\n<p>The following action properties can use those enhancement:</p>\n\n<ul>\n<li>WORKFLOW / TECHNICAL_WORKFLOW : user</li>\n<li>WORKFLOW / TECHNICAL_WORKFLOW : templateId</li>\n<li>WORKFLOW / TECHNICAL_WORKFLOW : nameTemplate</li>\n<li>REMINDER : user</li>\n<li>REMINDER : nameTemplate</li>\n</ul>\n\n\n<h1>Configuration</h1>\n\n<p>Depending on the type, the action needs additional information:</p>\n\n<pre><code>{\n  type: \"WORKFLOW\",\n  user: \"Administrator\", // optional, if none is defined, the during initialization set user will be user\n  templateId: \"NameOrIdOfTheWorkflowTemplate\",\n  nameTemplate: \"{{translate 'wfPrefix'}}: {{sord.name}}\" // optional, default is the name of the sord\n}\n\n{\n  type: \"TECHNICAL_WORKFLOW\",\n  user: \"Administrator\", // optional, if none is defined, the during initialization set user will be user\n  templateId: \"{{ctx.TemplateNameReadFromFieldByValueAnalyzer}}\", // enhancement example\n  nameTemplate: \"{{translate 'wfPrefix'}}: {{sord.name}}\" // optional, default is the name of the sord\n}\n\n{\n  type: \"REMINDER\",\n  user: \"Administrator\", // optional, if none is defined, the during initialization set user will be user\n  nameTemplate: \"Erinnerung: {{sord.objKeys.CONTRACT_NAME}}\" // optional, default is the name of the sord\n}\n\n{\n  type: \"FUNCTION\",                        // only one of `module`, `direct` or `regfct` will be used, priority order is `regfct` -&gt; `direct` -&gt; `module`\n  module: \"my.namespace.MyFunctionModule\"  // tries to create a module with this name and calls its `process` function (module and its dependencies have to be included)\n  direct: \"my.direct.Rule\"                 // calls a direct function with this name\n  regfct: \"RF_my_Function\"                 // calls a registered function with this name\n}\n</code></pre>\n\n<h1>Initialization example:</h1>\n\n<pre><code>var executor = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(\"<a href=\"#!/api/sol.common_monitoring.as.executors.SimpleExecutor\" rel=\"sol.common_monitoring.as.executors.SimpleExecutor\" class=\"docClass\">sol.common_monitoring.as.executors.SimpleExecutor</a>\", {\n  user: \"Administrator\" // The default user if an action specifies none\n});\n</code></pre>\n      <p class='version-tag'>Version: <b>1.01.000</b></p>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div id='cfg-requiredConfig' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n</div></div></div><div id='cfg-user' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.executors.SimpleExecutor'>sol.common_monitoring.as.executors.SimpleExecutor</span><br/><a href='source/lib_sol.common_monitoring.as.executors.SimpleExecutor.html#sol-common_monitoring-as-executors-SimpleExecutor-cfg-user' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.executors.SimpleExecutor-cfg-user' class='name expandable'>user</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'><p>(optional) If set, this user will be used for all actions (but will be overridden, if an action itself defines a user)</p>\n</div><div class='long'><p>(optional) If set, this user will be used for all actions (but will be overridden, if an action itself defines a user)</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-ACTIONS' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.executors.SimpleExecutor'>sol.common_monitoring.as.executors.SimpleExecutor</span><br/><a href='source/lib_sol.common_monitoring.as.executors.SimpleExecutor.html#sol-common_monitoring-as-executors-SimpleExecutor-property-ACTIONS' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.executors.SimpleExecutor-property-ACTIONS' class='name expandable'>ACTIONS</a> : Object<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Lookup object for the different functions supported by this executor. ...</div><div class='long'><p>Lookup object for the different functions supported by this executor.\nAll functions will be called with a <code>de.elo.ix.client.Sord</code> as first, an object (representing the action which should be executed) as second parameter and an context object possibly containing additional informations.</p>\n</div></div></div><div id='property-_todayIso' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.executors.SimpleExecutor'>sol.common_monitoring.as.executors.SimpleExecutor</span><br/><a href='source/lib_sol.common_monitoring.as.executors.SimpleExecutor.html#sol-common_monitoring-as-executors-SimpleExecutor-property-_todayIso' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.executors.SimpleExecutor-property-_todayIso' class='name expandable'>_todayIso</a> : String<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'><p>The current date cached as ISO string</p>\n</div><div class='long'><p>The current date cached as ISO string</p>\n</div></div></div><div id='property-_userConnectionCache' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.executors.SimpleExecutor'>sol.common_monitoring.as.executors.SimpleExecutor</span><br/><a href='source/lib_sol.common_monitoring.as.executors.SimpleExecutor.html#sol-common_monitoring-as-executors-SimpleExecutor-property-_userConnectionCache' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.executors.SimpleExecutor-property-_userConnectionCache' class='name expandable'>_userConnectionCache</a> : Object<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Caches user specific connections ...</div><div class='long'><p>Caches user specific connections</p>\n<p>Defaults to: <code>{}</code></p></div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>Logger for this class instance. ...</div><div class='long'><p>Logger for this class instance. This logger is created by <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a>.</p>\n\n<p>Please see <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a> class documentation for more information.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-buildName' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.executors.SimpleExecutor'>sol.common_monitoring.as.executors.SimpleExecutor</span><br/><a href='source/lib_sol.common_monitoring.as.executors.SimpleExecutor.html#sol-common_monitoring-as-executors-SimpleExecutor-method-buildName' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.executors.SimpleExecutor-method-buildName' class='name expandable'>buildName</a>( <span class='pre'>sord, ctx, [nameTemplate]</span> ) : String<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Builds the name from a template using the sord data. ...</div><div class='long'><p>Builds the name from a template using the sord data. Fallback is <code>sord.name</code>.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>sord</span> : de.elo.ix.client.Sord<div class='sub-desc'>\n</div></li><li><span class='pre'>ctx</span> : Object<div class='sub-desc'>\n</div></li><li><span class='pre'>nameTemplate</span> : String (optional)<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-dispose' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.executors.SimpleExecutor'>sol.common_monitoring.as.executors.SimpleExecutor</span><br/><a href='source/lib_sol.common_monitoring.as.executors.SimpleExecutor.html#sol-common_monitoring-as-executors-SimpleExecutor-method-dispose' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.executors.SimpleExecutor-method-dispose' class='name expandable'>dispose</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Performes cleanup. ...</div><div class='long'><p>Performes cleanup. Closes all opened user connections.</p>\n</div></div></div><div id='method-eveluateActionProperty' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.executors.SimpleExecutor'>sol.common_monitoring.as.executors.SimpleExecutor</span><br/><a href='source/lib_sol.common_monitoring.as.executors.SimpleExecutor.html#sol-common_monitoring-as-executors-SimpleExecutor-method-eveluateActionProperty' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.executors.SimpleExecutor-method-eveluateActionProperty' class='name expandable'>eveluateActionProperty</a>( <span class='pre'>value, sord, ctx</span> ) : String<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Retrieves the value from a action using handlebars applying the sord and the context. ...</div><div class='long'><p>Retrieves the value from a action using handlebars applying the sord and the context.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>value</span> : String<div class='sub-desc'>\n</div></li><li><span class='pre'>sord</span> : de.elo.ix.client.Sord<div class='sub-desc'>\n</div></li><li><span class='pre'>ctx</span> : Object<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-execute' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.executors.SimpleExecutor'>sol.common_monitoring.as.executors.SimpleExecutor</span><br/><a href='source/lib_sol.common_monitoring.as.executors.SimpleExecutor.html#sol-common_monitoring-as-executors-SimpleExecutor-method-execute' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.executors.SimpleExecutor-method-execute' class='name expandable'>execute</a>( <span class='pre'>sord, results, ctx</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Evaluates a result set and executes actions if the results contain any. ...</div><div class='long'><p>Evaluates a result set and executes actions if the results contain any.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>sord</span> : de.elo.ix.client.Sord<div class='sub-desc'>\n</div></li><li><span class='pre'>results</span> : Object[]<div class='sub-desc'>\n</div></li><li><span class='pre'>ctx</span> : Object<div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-executeAction' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.executors.SimpleExecutor'>sol.common_monitoring.as.executors.SimpleExecutor</span><br/><a href='source/lib_sol.common_monitoring.as.executors.SimpleExecutor.html#sol-common_monitoring-as-executors-SimpleExecutor-method-executeAction' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.executors.SimpleExecutor-method-executeAction' class='name expandable'>executeAction</a>( <span class='pre'>sord, action, ctx</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Executes an individual action. ...</div><div class='long'><p>Executes an individual action.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>sord</span> : de.elo.ix.client.Sord<div class='sub-desc'>\n</div></li><li><span class='pre'>action</span> : Object<div class='sub-desc'>\n</div></li><li><span class='pre'>ctx</span> : Object<div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-getConnection' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.executors.SimpleExecutor'>sol.common_monitoring.as.executors.SimpleExecutor</span><br/><a href='source/lib_sol.common_monitoring.as.executors.SimpleExecutor.html#sol-common_monitoring-as-executors-SimpleExecutor-method-getConnection' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.executors.SimpleExecutor-method-getConnection' class='name expandable'>getConnection</a>( <span class='pre'>user</span> ) : de.elo.ix.client.IXConnection<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Retrieves a connection for a specific user, using an internal cache. ...</div><div class='long'><p>Retrieves a connection for a specific user, using an internal cache.\nIf no user is defined, it returns the standard connection.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>user</span> : String<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>de.elo.ix.client.IXConnection</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.executors.SimpleExecutor'>sol.common_monitoring.as.executors.SimpleExecutor</span><br/><a href='source/lib_sol.common_monitoring.as.executors.SimpleExecutor.html#sol-common_monitoring-as-executors-SimpleExecutor-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.executors.SimpleExecutor-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul><p>Overrides: <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a></p></div></div></div></div></div></div></div>","meta":{"eloas":true}});
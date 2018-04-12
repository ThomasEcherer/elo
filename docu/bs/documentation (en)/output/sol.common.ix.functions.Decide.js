Ext.data.JsonP.sol_common_ix_functions_Decide({"tagname":"class","name":"sol.common.ix.functions.Decide","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"sol.common.ix.functions.Decide.js","href":"sol.common.ix.functions.Decide.html#sol-common-ix-functions-Decide"}],"author":[{"tagname":"author","name":"MW, ELO Digital Office GmbH","email":null}],"version":["1.1"],"eloix":true,"requires":["sol.common.WfUtils","sol.common.ix.FunctionBase","sol.common.ix.RfUtils"],"aliases":{},"alternateClassNames":[],"extends":"sol.common.ix.FunctionBase","mixins":[],"uses":[],"members":[{"name":"falseStatus","tagname":"cfg","owner":"sol.common.ix.functions.Decide","id":"cfg-falseStatus","meta":{}},{"name":"objId","tagname":"cfg","owner":"sol.common.ix.FunctionBase","id":"cfg-objId","meta":{}},{"name":"requiredConfig","tagname":"cfg","owner":"sol.common.ix.functions.Decide","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"trueStatus","tagname":"cfg","owner":"sol.common.ix.functions.Decide","id":"cfg-trueStatus","meta":{}},{"name":"wfDiagram","tagname":"cfg","owner":"sol.common.ix.functions.Decide","id":"cfg-wfDiagram","meta":{"required":true}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"logger","tagname":"property","owner":"sol.common.ix.FunctionBase","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"checkAndWrite","tagname":"method","owner":"sol.common.ix.functions.Decide","id":"method-checkAndWrite","meta":{"private":true}},{"name":"initialize","tagname":"method","owner":"sol.common.ix.FunctionBase","id":"method-initialize","meta":{"private":true}},{"name":"process","tagname":"method","owner":"sol.common.ix.functions.Decide","id":"method-process","meta":{}},{"name":"onExitNode","tagname":"method","owner":"sol.common.ix.functions.Decide","id":"static-method-onExitNode","meta":{"static":true}}],"code_type":"ext_define","id":"class-sol.common.ix.functions.Decide","short_doc":"Makes a decision on field values by regular expressions and sets the workflow status\n\nExample\n\n{\n  \"checks\": [\n    { ...","classIcon":"icon-class","superclasses":["sol.Base","sol.common.ix.FunctionBase"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='docClass'>sol.common.ix.FunctionBase</a><div class='subclass '><strong>sol.common.ix.functions.Decide</strong></div></div></div><h4>Requires</h4><div class='dependency'><a href='#!/api/sol.common.WfUtils' rel='sol.common.WfUtils' class='docClass'>sol.common.WfUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='docClass'>sol.common.ix.FunctionBase</a></div><div class='dependency'><a href='#!/api/sol.common.ix.RfUtils' rel='sol.common.ix.RfUtils' class='docClass'>sol.common.ix.RfUtils</a></div><h4>Files</h4><div class='dependency'><a href='source/sol.common.ix.functions.Decide.html#sol-common-ix-functions-Decide' target='_blank'>sol.common.ix.functions.Decide.js</a></div></pre><div class='doc-contents'><p>Makes a decision on field values by regular expressions and sets the workflow status</p>\n\n<h1>Example</h1>\n\n<pre><code>{\n  \"checks\": [\n    { \"type\": \"GRP\", \"key\": \"PROJECT_NO\", \"regex\": \"^AB(\\\\d+)$\", \"writeMatches\": [{ \"type\": \"GRP\", \"key\": \"COMPANY_NAME\" }] },\n    { \"type\": \"GRP\", \"key\": \"PROJECT_NAME\", \"regex\": \"My(Project)\", \"writeMatches\": [{ \"type\": \"GRP\", \"key\": \"VENDOR_NAME\" }] }\n  ],\n  \"trueStatus\": \"TRUE\",\n  \"falseStatus\": \"FALSE\"\n}\n</code></pre>\n      <p class='version-tag'>Version: <b>1.1</b></p>\n</div><div class='members'><div class='members-section'><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Required config options</h3><div id='cfg-wfDiagram' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Decide'>sol.common.ix.functions.Decide</span><br/><a href='source/sol.common.ix.functions.Decide.html#sol-common-ix-functions-Decide-cfg-wfDiagram' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Decide-cfg-wfDiagram' class='name expandable'>wfDiagram</a> : de.elo.ix.client.wfDiagram<span class=\"signature\"><span class='required' >required</span></span></div><div class='description'><div class='short'><p>The workflow which should be checked.</p>\n</div><div class='long'><p>The workflow which should be checked.</p>\n</div></div></div></div><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Optional config options</h3><div id='cfg-falseStatus' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Decide'>sol.common.ix.functions.Decide</span><br/><a href='source/sol.common.ix.functions.Decide.html#sol-common-ix-functions-Decide-cfg-falseStatus' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Decide-cfg-falseStatus' class='name expandable'>falseStatus</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Status value for ´false´ ...</div><div class='long'><p>Status value for ´false´</p>\n<p>Defaults to: <code>FALSE</code></p></div></div></div><div id='cfg-objId' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='defined-in docClass'>sol.common.ix.FunctionBase</a><br/><a href='source/lib_sol.common.ix.FunctionBase.html#sol-common-ix-FunctionBase-cfg-objId' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.FunctionBase-cfg-objId' class='name expandable'>objId</a> : string<span class=\"signature\"></span></div><div class='description'><div class='short'><p>Object ID for the element</p>\n</div><div class='long'><p>Object ID for the element</p>\n</div></div></div><div id='cfg-requiredConfig' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Decide'>sol.common.ix.functions.Decide</span><br/><a href='source/sol.common.ix.functions.Decide.html#sol-common-ix-functions-Decide-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Decide-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n<p>Defaults to: <code>[&quot;wfDiagram&quot;, &quot;nodeId&quot;, &quot;checks&quot;]</code></p><p>Overrides: <a href=\"#!/api/sol.Base-cfg-requiredConfig\" rel=\"sol.Base-cfg-requiredConfig\" class=\"docClass\">sol.Base.requiredConfig</a></p></div></div></div><div id='cfg-trueStatus' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Decide'>sol.common.ix.functions.Decide</span><br/><a href='source/sol.common.ix.functions.Decide.html#sol-common-ix-functions-Decide-cfg-trueStatus' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Decide-cfg-trueStatus' class='name expandable'>trueStatus</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Status value for ´true´ ...</div><div class='long'><p>Status value for ´true´</p>\n<p>Defaults to: <code>TRUE</code></p></div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='defined-in docClass'>sol.common.ix.FunctionBase</a><br/><a href='source/lib_sol.common.ix.FunctionBase.html#sol-common-ix-FunctionBase-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.FunctionBase-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>The logger for the module</p>\n</div><div class='long'><p>The logger for the module</p>\n<p>Overrides: <a href=\"#!/api/sol.Base-property-logger\" rel=\"sol.Base-property-logger\" class=\"docClass\">sol.Base.logger</a></p></div></div></div></div></div><div class='members-section'><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Instance methods</h3><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-checkAndWrite' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Decide'>sol.common.ix.functions.Decide</span><br/><a href='source/sol.common.ix.functions.Decide.html#sol-common-ix-functions-Decide-method-checkAndWrite' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Decide-method-checkAndWrite' class='name expandable'>checkAndWrite</a>( <span class='pre'></span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'> ...</div><div class='long'>\n</div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='defined-in docClass'>sol.common.ix.FunctionBase</a><br/><a href='source/lib_sol.common.ix.FunctionBase.html#sol-common-ix-FunctionBase-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.FunctionBase-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul><p>Overrides: <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a></p></div></div></div><div id='method-process' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Decide'>sol.common.ix.functions.Decide</span><br/><a href='source/sol.common.ix.functions.Decide.html#sol-common-ix-functions-Decide-method-process' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Decide-method-process' class='name expandable'>process</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Perform the checks. ...</div><div class='long'><p>Perform the checks.</p>\n<p>Overrides: <a href=\"#!/api/sol.common.ix.FunctionBase-method-process\" rel=\"sol.common.ix.FunctionBase-method-process\" class=\"docClass\">sol.common.ix.FunctionBase.process</a></p></div></div></div></div><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Static methods</h3><div id='static-method-onExitNode' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Decide'>sol.common.ix.functions.Decide</span><br/><a href='source/sol.common.ix.functions.Decide.html#sol-common-ix-functions-Decide-static-method-onExitNode' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Decide-static-method-onExitNode' class='name expandable'>onExitNode</a>( <span class='pre'>clInfo, userId, wFDiagram, nodeId</span> )<span class=\"signature\"><span class='static' >static</span></span></div><div class='description'><div class='short'>This function is called after a workflow node is deactivated. ...</div><div class='long'><p>This function is called after a workflow node is deactivated.</p>\n\n<p>The configuration for this function can be defined in the comments section of each workflow node and should be valid js.\nFor more information on using this function please refer to the functions documentation.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>clInfo</span> : de.elo.ix.client.ClientInfo<div class='sub-desc'><p>object with language, country and ticket</p>\n</div></li><li><span class='pre'>userId</span> : number<div class='sub-desc'><p>The calling users ID</p>\n</div></li><li><span class='pre'>wFDiagram</span> : de.elo.ix.client.WFDiagram<div class='sub-desc'>\n</div></li><li><span class='pre'>nodeId</span> : number<div class='sub-desc'><p>The deactivated node ID</p>\n</div></li></ul></div></div></div></div></div></div></div>","meta":{"eloix":true}});
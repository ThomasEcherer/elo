Ext.data.JsonP.sol_common_ix_functions_ChangeColor({"tagname":"class","name":"sol.common.ix.functions.ChangeColor","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"sol.common.ix.functions.ChangeColor.js","href":"sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor"}],"author":[{"tagname":"author","name":"Pascal Zipfel, ELO Digital Office GmbH","email":null}],"version":["1.0"],"eloix":true,"requires":["sol.Logger","sol.common.JsonUtils","sol.common.WfUtils","sol.common.ix.FunctionBase","sol.common.ix.RfUtils"],"aliases":{},"alternateClassNames":[],"extends":"sol.common.ix.FunctionBase","mixins":[],"uses":[],"members":[{"name":"color","tagname":"cfg","owner":"sol.common.ix.functions.ChangeColor","id":"cfg-color","meta":{}},{"name":"objId","tagname":"cfg","owner":"sol.common.ix.functions.ChangeColor","id":"cfg-objId","meta":{"required":true}},{"name":"requiredConfig","tagname":"cfg","owner":"sol.common.ix.functions.ChangeColor","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"restore","tagname":"cfg","owner":"sol.common.ix.functions.ChangeColor","id":"cfg-restore","meta":{}},{"name":"save","tagname":"cfg","owner":"sol.common.ix.functions.ChangeColor","id":"cfg-save","meta":{}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"colorCache","tagname":"property","owner":"sol.common.ix.functions.ChangeColor","id":"property-colorCache","meta":{"private":true}},{"name":"logger","tagname":"property","owner":"sol.common.ix.FunctionBase","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"getColor","tagname":"method","owner":"sol.common.ix.functions.ChangeColor","id":"method-getColor","meta":{"private":true}},{"name":"getColors","tagname":"method","owner":"sol.common.ix.functions.ChangeColor","id":"method-getColors","meta":{"private":true}},{"name":"initialize","tagname":"method","owner":"sol.common.ix.FunctionBase","id":"method-initialize","meta":{"private":true}},{"name":"process","tagname":"method","owner":"sol.common.ix.functions.ChangeColor","id":"method-process","meta":{}},{"name":"restoreFromMap","tagname":"method","owner":"sol.common.ix.functions.ChangeColor","id":"method-restoreFromMap","meta":{"private":true}},{"name":"saveToMap","tagname":"method","owner":"sol.common.ix.functions.ChangeColor","id":"method-saveToMap","meta":{"private":true}},{"name":"RF_sol_function_ChangeColor","tagname":"method","owner":"sol.common.ix.functions.ChangeColor","id":"static-method-RF_sol_function_ChangeColor","meta":{"static":true}},{"name":"onEnterNode","tagname":"method","owner":"sol.common.ix.functions.ChangeColor","id":"static-method-onEnterNode","meta":{"static":true}},{"name":"onExitNode","tagname":"method","owner":"sol.common.ix.functions.ChangeColor","id":"static-method-onExitNode","meta":{"static":true}}],"code_type":"ext_define","id":"class-sol.common.ix.functions.ChangeColor","short_doc":"Changes the color of an archive element. ...","classIcon":"icon-class","superclasses":["sol.Base","sol.common.ix.FunctionBase"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='docClass'>sol.common.ix.FunctionBase</a><div class='subclass '><strong>sol.common.ix.functions.ChangeColor</strong></div></div></div><h4>Requires</h4><div class='dependency'><a href='#!/api/sol.Logger' rel='sol.Logger' class='docClass'>sol.Logger</a></div><div class='dependency'><a href='#!/api/sol.common.JsonUtils' rel='sol.common.JsonUtils' class='docClass'>sol.common.JsonUtils</a></div><div class='dependency'><a href='#!/api/sol.common.WfUtils' rel='sol.common.WfUtils' class='docClass'>sol.common.WfUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='docClass'>sol.common.ix.FunctionBase</a></div><div class='dependency'><a href='#!/api/sol.common.ix.RfUtils' rel='sol.common.ix.RfUtils' class='docClass'>sol.common.ix.RfUtils</a></div><h4>Files</h4><div class='dependency'><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor' target='_blank'>sol.common.ix.functions.ChangeColor.js</a></div></pre><div class='doc-contents'><p>Changes the color of an archive element.</p>\n\n<p>Additionally the old color can be saved to a map field, from where is can be restored later</p>\n\n<pre><code>{ color: \"red\", save: \"OLD_COLOR\" }\n{ color: \"blue\", restore: \"OLD_COLOR\" }\n</code></pre>\n\n<p><code>save</code> and <code>restore</code> are both optional, but if <code>restore</code> is defined, it always wins over <code>color</code>.\nIf there is no color found in the map field <code>OLD_COLOR</code> the <code>color</code> will be used as fallback.</p>\n\n<h1>As workflow node</h1>\n\n<p><code>ObjId</code> is set based on the element that the workflow is attached to.\nFollowing configuration should be applied to the comments field.</p>\n\n<pre><code>{\n  \"color\": \"blue\"\n}\n</code></pre>\n\n<h1>As IX function call</h1>\n\n<p>In addition to the workflow node configuration the objId must be passed.</p>\n\n<pre><code><a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a>(\"RF_sol_function_ChangeColor\", {\n  objId: \"4711\",\n  color: \"blue\"\n});\n</code></pre>\n      <p class='version-tag'>Version: <b>1.0</b></p>\n</div><div class='members'><div class='members-section'><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Required config options</h3><div id='cfg-objId' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.ChangeColor'>sol.common.ix.functions.ChangeColor</span><br/><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor-cfg-objId' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.ChangeColor-cfg-objId' class='name expandable'>objId</a> : String<span class=\"signature\"><span class='required' >required</span></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n<p>Overrides: <a href=\"#!/api/sol.common.ix.FunctionBase-cfg-objId\" rel=\"sol.common.ix.FunctionBase-cfg-objId\" class=\"docClass\">sol.common.ix.FunctionBase.objId</a></p></div></div></div></div><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Optional config options</h3><div id='cfg-color' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.ChangeColor'>sol.common.ix.functions.ChangeColor</span><br/><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor-cfg-color' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.ChangeColor-cfg-color' class='name expandable'>color</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'><p>Tries to find a color which was defined in ELO</p>\n</div><div class='long'><p>Tries to find a color which was defined in ELO</p>\n</div></div></div><div id='cfg-requiredConfig' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.ChangeColor'>sol.common.ix.functions.ChangeColor</span><br/><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.ChangeColor-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n<p>Defaults to: <code>[&quot;objId&quot;]</code></p><p>Overrides: <a href=\"#!/api/sol.Base-cfg-requiredConfig\" rel=\"sol.Base-cfg-requiredConfig\" class=\"docClass\">sol.Base.requiredConfig</a></p></div></div></div><div id='cfg-restore' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.ChangeColor'>sol.common.ix.functions.ChangeColor</span><br/><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor-cfg-restore' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.ChangeColor-cfg-restore' class='name expandable'>restore</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'><p>Restores the old color from a map filed</p>\n</div><div class='long'><p>Restores the old color from a map filed</p>\n</div></div></div><div id='cfg-save' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.ChangeColor'>sol.common.ix.functions.ChangeColor</span><br/><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor-cfg-save' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.ChangeColor-cfg-save' class='name expandable'>save</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'><p>Saves the old color to a map field</p>\n</div><div class='long'><p>Saves the old color to a map field</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-colorCache' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.ChangeColor'>sol.common.ix.functions.ChangeColor</span><br/><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor-property-colorCache' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.ChangeColor-property-colorCache' class='name expandable'>colorCache</a> : de.elo.ix.client.ColorData[]<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='defined-in docClass'>sol.common.ix.FunctionBase</a><br/><a href='source/lib_sol.common.ix.FunctionBase.html#sol-common-ix-FunctionBase-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.FunctionBase-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>The logger for the module</p>\n</div><div class='long'><p>The logger for the module</p>\n<p>Overrides: <a href=\"#!/api/sol.Base-property-logger\" rel=\"sol.Base-property-logger\" class=\"docClass\">sol.Base.logger</a></p></div></div></div></div></div><div class='members-section'><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Instance methods</h3><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-getColor' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.ChangeColor'>sol.common.ix.functions.ChangeColor</span><br/><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor-method-getColor' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.ChangeColor-method-getColor' class='name expandable'>getColor</a>( <span class='pre'>color</span> ) : de.elo.ix.client.ColorData<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'> ...</div><div class='long'>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>color</span> : String|Number<div class='sub-desc'><p>Name or ID of the color</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>de.elo.ix.client.ColorData</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-getColors' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.ChangeColor'>sol.common.ix.functions.ChangeColor</span><br/><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor-method-getColors' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.ChangeColor-method-getColors' class='name expandable'>getColors</a>( <span class='pre'></span> ) : de.elo.ix.client.ColorData[]<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'> ...</div><div class='long'>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>de.elo.ix.client.ColorData[]</span><div class='sub-desc'><p>colorCache</p>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='defined-in docClass'>sol.common.ix.FunctionBase</a><br/><a href='source/lib_sol.common.ix.FunctionBase.html#sol-common-ix-FunctionBase-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.FunctionBase-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul><p>Overrides: <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a></p></div></div></div><div id='method-process' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.ChangeColor'>sol.common.ix.functions.ChangeColor</span><br/><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor-method-process' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.ChangeColor-method-process' class='name expandable'>process</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Changes the color of the element. ...</div><div class='long'><p>Changes the color of the element.</p>\n<p>Overrides: <a href=\"#!/api/sol.common.ix.FunctionBase-method-process\" rel=\"sol.common.ix.FunctionBase-method-process\" class=\"docClass\">sol.common.ix.FunctionBase.process</a></p></div></div></div><div id='method-restoreFromMap' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.ChangeColor'>sol.common.ix.functions.ChangeColor</span><br/><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor-method-restoreFromMap' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.ChangeColor-method-restoreFromMap' class='name expandable'>restoreFromMap</a>( <span class='pre'></span> ) : String<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'> ...</div><div class='long'>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-saveToMap' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.ChangeColor'>sol.common.ix.functions.ChangeColor</span><br/><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor-method-saveToMap' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.ChangeColor-method-saveToMap' class='name expandable'>saveToMap</a>( <span class='pre'>color</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'> ...</div><div class='long'>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>color</span> : String<div class='sub-desc'>\n</div></li></ul></div></div></div></div><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Static methods</h3><div id='static-method-RF_sol_function_ChangeColor' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.ChangeColor'>sol.common.ix.functions.ChangeColor</span><br/><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor-static-method-RF_sol_function_ChangeColor' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.ChangeColor-static-method-RF_sol_function_ChangeColor' class='name expandable'>RF_sol_function_ChangeColor</a>( <span class='pre'>Execution, args</span> )<span class=\"signature\"><span class='static' >static</span></span></div><div class='description'><div class='short'>This function can be called from an application by invoking the API function \"executeRegisteredFunction\" or by using\n...</div><div class='long'><p>This function can be called from an application by invoking the API function \"executeRegisteredFunction\" or by using\n<a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a> which internally handles the Any-Object conversion.</p>\n\n<p>All configuration params should be passed as a configuration object to the args param.</p>\n\n<pre><code><a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a>('RF_FunctionName', {\n  configParam1: 'myParam'\n});\n</code></pre>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>Execution</span> : de.elo.ix.client.IXServerEventsContext<div class='sub-desc'><p>context</p>\n</div></li><li><span class='pre'>args</span> : Object<div class='sub-desc'><p>Argument array sent by the client application.</p>\n</div></li></ul></div></div></div><div id='static-method-onEnterNode' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.ChangeColor'>sol.common.ix.functions.ChangeColor</span><br/><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor-static-method-onEnterNode' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.ChangeColor-static-method-onEnterNode' class='name expandable'>onEnterNode</a>( <span class='pre'>clInfo, userId, wFDiagram, nodeId</span> )<span class=\"signature\"><span class='static' >static</span></span></div><div class='description'><div class='short'>This function is called before a workflow node is activated. ...</div><div class='long'><p>This function is called before a workflow node is activated.</p>\n\n<p>The configuration for this function can be defined in the comments section of each workflow node and should be valid js.\nFor more information on using this function please refer to the functions documentation.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>clInfo</span> : de.elo.ix.client.ClientInfo<div class='sub-desc'><p>object with language, country and ticket</p>\n</div></li><li><span class='pre'>userId</span> : number<div class='sub-desc'><p>The calling users ID</p>\n</div></li><li><span class='pre'>wFDiagram</span> : de.elo.ix.client.WFDiagram<div class='sub-desc'>\n</div></li><li><span class='pre'>nodeId</span> : number<div class='sub-desc'><p>The activated node ID</p>\n</div></li></ul></div></div></div><div id='static-method-onExitNode' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.ChangeColor'>sol.common.ix.functions.ChangeColor</span><br/><a href='source/sol.common.ix.functions.ChangeColor.html#sol-common-ix-functions-ChangeColor-static-method-onExitNode' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.ChangeColor-static-method-onExitNode' class='name expandable'>onExitNode</a>( <span class='pre'>clInfo, userId, wFDiagram, nodeId</span> )<span class=\"signature\"><span class='static' >static</span></span></div><div class='description'><div class='short'>This function is called after a workflow node is deactivated. ...</div><div class='long'><p>This function is called after a workflow node is deactivated.</p>\n\n<p>The configuration for this function can be defined in the comments section of each workflow node and should be valid js.\nFor more information on using this function please refer to the functions documentation.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>clInfo</span> : de.elo.ix.client.ClientInfo<div class='sub-desc'><p>object with language, country and ticket</p>\n</div></li><li><span class='pre'>userId</span> : number<div class='sub-desc'><p>The calling users ID</p>\n</div></li><li><span class='pre'>wFDiagram</span> : de.elo.ix.client.WFDiagram<div class='sub-desc'>\n</div></li><li><span class='pre'>nodeId</span> : number<div class='sub-desc'><p>The deactivated node ID</p>\n</div></li></ul></div></div></div></div></div></div></div>","meta":{"eloix":true}});
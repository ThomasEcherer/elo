Ext.data.JsonP.sol_common_ix_functions_CopyFolderContents({"tagname":"class","name":"sol.common.ix.functions.CopyFolderContents","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"sol.common.ix.functions.CopyFolderContents.js","href":"sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents"}],"author":[{"tagname":"author","name":"JHR, ELO Digital Office GmbH","email":null}],"version":["1.02.003"],"eloix":true,"requires":["sol.Logger","sol.common.JsonUtils","sol.common.ObjectUtils","sol.common.ix.FunctionBase","sol.common.ix.RfUtils"],"aliases":{},"alternateClassNames":[],"extends":"sol.common.ix.FunctionBase","mixins":[],"uses":[],"members":[{"name":"copyOnlyBaseElement","tagname":"cfg","owner":"sol.common.ix.functions.CopyFolderContents","id":"cfg-copyOnlyBaseElement","meta":{}},{"name":"copyOnlyWorkversion","tagname":"cfg","owner":"sol.common.ix.functions.CopyFolderContents","id":"cfg-copyOnlyWorkversion","meta":{}},{"name":"copySourceAcl","tagname":"cfg","owner":"sol.common.ix.functions.CopyFolderContents","id":"cfg-copySourceAcl","meta":{}},{"name":"inheritDestinationAcl","tagname":"cfg","owner":"sol.common.ix.functions.CopyFolderContents","id":"cfg-inheritDestinationAcl","meta":{}},{"name":"name","tagname":"cfg","owner":"sol.common.ix.functions.CopyFolderContents","id":"cfg-name","meta":{}},{"name":"objId","tagname":"cfg","owner":"sol.common.ix.functions.CopyFolderContents","id":"cfg-objId","meta":{"required":true}},{"name":"requiredConfig","tagname":"cfg","owner":"sol.common.ix.functions.CopyFolderContents","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"sleepTime","tagname":"cfg","owner":"sol.common.ix.functions.CopyFolderContents","id":"cfg-sleepTime","meta":{}},{"name":"source","tagname":"cfg","owner":"sol.common.ix.functions.CopyFolderContents","id":"cfg-source","meta":{"required":true}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"logger","tagname":"property","owner":"sol.common.ix.FunctionBase","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"initialize","tagname":"method","owner":"sol.common.ix.functions.CopyFolderContents","id":"method-initialize","meta":{"private":true}},{"name":"process","tagname":"method","owner":"sol.common.ix.functions.CopyFolderContents","id":"method-process","meta":{}},{"name":"RF_sol_function_CopyFolderContents","tagname":"method","owner":"sol.common.ix.functions.CopyFolderContents","id":"static-method-RF_sol_function_CopyFolderContents","meta":{"static":true}},{"name":"onEnterNode","tagname":"method","owner":"sol.common.ix.functions.CopyFolderContents","id":"static-method-onEnterNode","meta":{"static":true}},{"name":"onExitNode","tagname":"method","owner":"sol.common.ix.functions.CopyFolderContents","id":"static-method-onExitNode","meta":{"static":true}}],"code_type":"ext_define","id":"class-sol.common.ix.functions.CopyFolderContents","short_doc":"Copies whole folder recursively. ...","classIcon":"icon-class","superclasses":["sol.Base","sol.common.ix.FunctionBase"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='docClass'>sol.common.ix.FunctionBase</a><div class='subclass '><strong>sol.common.ix.functions.CopyFolderContents</strong></div></div></div><h4>Requires</h4><div class='dependency'><a href='#!/api/sol.Logger' rel='sol.Logger' class='docClass'>sol.Logger</a></div><div class='dependency'><a href='#!/api/sol.common.JsonUtils' rel='sol.common.JsonUtils' class='docClass'>sol.common.JsonUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ObjectUtils' rel='sol.common.ObjectUtils' class='docClass'>sol.common.ObjectUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='docClass'>sol.common.ix.FunctionBase</a></div><div class='dependency'><a href='#!/api/sol.common.ix.RfUtils' rel='sol.common.ix.RfUtils' class='docClass'>sol.common.ix.RfUtils</a></div><h4>Files</h4><div class='dependency'><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents' target='_blank'>sol.common.ix.functions.CopyFolderContents.js</a></div></pre><div class='doc-contents'><p>Copies whole folder recursively.</p>\n\n<h1>As IX function call</h1>\n\n<pre><code><a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a>(\"RF_sol_function_CopyFolderContents\" {\n  objId: 123,\n  source: 1233,\n  copySourceAcl: false,\n  inheritDestinationAcl: true\n});\n</code></pre>\n\n<ul>\n<li><h1>Node configuration example:</h1>\n\n<p>  {\n    \"source\": \"ARCPATH:/MyTemplates/MyTemplate1\"\n  }</p></li>\n</ul>\n\n      <p class='version-tag'>Version: <b>1.02.003</b></p>\n</div><div class='members'><div class='members-section'><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Required config options</h3><div id='cfg-objId' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.CopyFolderContents'>sol.common.ix.functions.CopyFolderContents</span><br/><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents-cfg-objId' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.CopyFolderContents-cfg-objId' class='name expandable'>objId</a> : Number<span class=\"signature\"><span class='required' >required</span></span></div><div class='description'><div class='short'><p>ObjectId of destination folder</p>\n</div><div class='long'><p>ObjectId of destination folder</p>\n<p>Overrides: <a href=\"#!/api/sol.common.ix.FunctionBase-cfg-objId\" rel=\"sol.common.ix.FunctionBase-cfg-objId\" class=\"docClass\">sol.common.ix.FunctionBase.objId</a></p></div></div></div><div id='cfg-source' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.CopyFolderContents'>sol.common.ix.functions.CopyFolderContents</span><br/><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents-cfg-source' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.CopyFolderContents-cfg-source' class='name expandable'>source</a> : Number<span class=\"signature\"><span class='required' >required</span></span></div><div class='description'><div class='short'><p>ObjectId of source folder which content should be copied</p>\n</div><div class='long'><p>ObjectId of source folder which content should be copied</p>\n</div></div></div></div><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Optional config options</h3><div id='cfg-copyOnlyBaseElement' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.CopyFolderContents'>sol.common.ix.functions.CopyFolderContents</span><br/><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents-cfg-copyOnlyBaseElement' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.CopyFolderContents-cfg-copyOnlyBaseElement' class='name expandable'>copyOnlyBaseElement</a> : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Copy only the base element ...</div><div class='long'><p>Copy only the base element</p>\n<p>Defaults to: <code>false</code></p></div></div></div><div id='cfg-copyOnlyWorkversion' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.CopyFolderContents'>sol.common.ix.functions.CopyFolderContents</span><br/><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents-cfg-copyOnlyWorkversion' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.CopyFolderContents-cfg-copyOnlyWorkversion' class='name expandable'>copyOnlyWorkversion</a> : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Copy only the work version ...</div><div class='long'><p>Copy only the work version</p>\n<p>Defaults to: <code>true</code></p></div></div></div><div id='cfg-copySourceAcl' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.CopyFolderContents'>sol.common.ix.functions.CopyFolderContents</span><br/><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents-cfg-copySourceAcl' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.CopyFolderContents-cfg-copySourceAcl' class='name expandable'>copySourceAcl</a> : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Copies the ACL of parent element when set ...</div><div class='long'><p>Copies the ACL of parent element when set</p>\n<p>Defaults to: <code>false</code></p></div></div></div><div id='cfg-inheritDestinationAcl' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.CopyFolderContents'>sol.common.ix.functions.CopyFolderContents</span><br/><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents-cfg-inheritDestinationAcl' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.CopyFolderContents-cfg-inheritDestinationAcl' class='name expandable'>inheritDestinationAcl</a> : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Inherits the ACL of the destination element when set ...</div><div class='long'><p>Inherits the ACL of the destination element when set</p>\n<p>Defaults to: <code>true</code></p></div></div></div><div id='cfg-name' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.CopyFolderContents'>sol.common.ix.functions.CopyFolderContents</span><br/><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents-cfg-name' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.CopyFolderContents-cfg-name' class='name expandable'>name</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'><p>If set, the new elements name will set to this, instead of the sources name</p>\n</div><div class='long'><p>If set, the new elements name will set to this, instead of the sources name</p>\n</div></div></div><div id='cfg-requiredConfig' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.CopyFolderContents'>sol.common.ix.functions.CopyFolderContents</span><br/><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.CopyFolderContents-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n<p>Defaults to: <code>[&quot;objId&quot;, &quot;source&quot;]</code></p><p>Overrides: <a href=\"#!/api/sol.Base-cfg-requiredConfig\" rel=\"sol.Base-cfg-requiredConfig\" class=\"docClass\">sol.Base.requiredConfig</a></p></div></div></div><div id='cfg-sleepTime' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.CopyFolderContents'>sol.common.ix.functions.CopyFolderContents</span><br/><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents-cfg-sleepTime' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.CopyFolderContents-cfg-sleepTime' class='name expandable'>sleepTime</a> : Number<span class=\"signature\"></span></div><div class='description'><div class='short'>The time in ms to recheck, if the process has finished. ...</div><div class='long'><p>The time in ms to recheck, if the process has finished.\nFor longer running copy processes this value can be increased to reduce the number of polling requests.</p>\n<p>Defaults to: <code>200</code></p></div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='defined-in docClass'>sol.common.ix.FunctionBase</a><br/><a href='source/lib_sol.common.ix.FunctionBase.html#sol-common-ix-FunctionBase-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.FunctionBase-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>The logger for the module</p>\n</div><div class='long'><p>The logger for the module</p>\n<p>Overrides: <a href=\"#!/api/sol.Base-property-logger\" rel=\"sol.Base-property-logger\" class=\"docClass\">sol.Base.logger</a></p></div></div></div></div></div><div class='members-section'><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Instance methods</h3><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.CopyFolderContents'>sol.common.ix.functions.CopyFolderContents</span><br/><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.CopyFolderContents-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'></div></li></ul><p>Overrides: <a href=\"#!/api/sol.common.ix.FunctionBase-method-initialize\" rel=\"sol.common.ix.FunctionBase-method-initialize\" class=\"docClass\">sol.common.ix.FunctionBase.initialize</a></p></div></div></div><div id='method-process' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.CopyFolderContents'>sol.common.ix.functions.CopyFolderContents</span><br/><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents-method-process' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.CopyFolderContents-method-process' class='name expandable'>process</a>( <span class='pre'></span> ) : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Copies whole folder recursively. ...</div><div class='long'><p>Copies whole folder recursively.</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'><p>The objId of the copied folder</p>\n</div></li></ul><p>Overrides: <a href=\"#!/api/sol.common.ix.FunctionBase-method-process\" rel=\"sol.common.ix.FunctionBase-method-process\" class=\"docClass\">sol.common.ix.FunctionBase.process</a></p></div></div></div></div><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Static methods</h3><div id='static-method-RF_sol_function_CopyFolderContents' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.CopyFolderContents'>sol.common.ix.functions.CopyFolderContents</span><br/><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents-static-method-RF_sol_function_CopyFolderContents' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.CopyFolderContents-static-method-RF_sol_function_CopyFolderContents' class='name expandable'>RF_sol_function_CopyFolderContents</a>( <span class='pre'>Execution, args</span> )<span class=\"signature\"><span class='static' >static</span></span></div><div class='description'><div class='short'>This function can be called from an application by invoking the API function \"executeRegisteredFunction\" or by using\n...</div><div class='long'><p>This function can be called from an application by invoking the API function \"executeRegisteredFunction\" or by using\n<a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a> which internally handles the Any-Object conversion.</p>\n\n<p>All configuration params should be passed as a configuration object to the args param.</p>\n\n<pre><code><a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a>('RF_FunctionName', {\n  configParam1: 'myParam'\n});\n</code></pre>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>Execution</span> : de.elo.ix.client.IXServerEventsContext<div class='sub-desc'><p>context</p>\n\n</div></li><li><span class='pre'>args</span> : Object<div class='sub-desc'><p>Argument array sent by the client application.</p>\n\n</div></li></ul></div></div></div><div id='static-method-onEnterNode' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.CopyFolderContents'>sol.common.ix.functions.CopyFolderContents</span><br/><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents-static-method-onEnterNode' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.CopyFolderContents-static-method-onEnterNode' class='name expandable'>onEnterNode</a>( <span class='pre'>clInfo, userId, wFDiagram, nodeId</span> )<span class=\"signature\"><span class='static' >static</span></span></div><div class='description'><div class='short'>This function is called before a workflow node is activated. ...</div><div class='long'><p>This function is called before a workflow node is activated.</p>\n\n<p>The configuration for this function can be defined in the comments section of each workflow node and should be valid js.\nFor more information on using this function please refer to the functions documentation.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>clInfo</span> : de.elo.ix.client.ClientInfo<div class='sub-desc'><p>object with language, country and ticket</p>\n\n</div></li><li><span class='pre'>userId</span> : number<div class='sub-desc'><p>The calling users ID</p>\n\n</div></li><li><span class='pre'>wFDiagram</span> : de.elo.ix.client.WFDiagram<div class='sub-desc'>\n</div></li><li><span class='pre'>nodeId</span> : number<div class='sub-desc'><p>The activated node ID</p>\n\n</div></li></ul></div></div></div><div id='static-method-onExitNode' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.CopyFolderContents'>sol.common.ix.functions.CopyFolderContents</span><br/><a href='source/sol.common.ix.functions.CopyFolderContents.html#sol-common-ix-functions-CopyFolderContents-static-method-onExitNode' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.CopyFolderContents-static-method-onExitNode' class='name expandable'>onExitNode</a>( <span class='pre'>clInfo, userId, wFDiagram, nodeId</span> )<span class=\"signature\"><span class='static' >static</span></span></div><div class='description'><div class='short'>This function is called after a workflow node is deactivated. ...</div><div class='long'><p>This function is called after a workflow node is deactivated.</p>\n\n<p>The configuration for this function can be defined in the comments section of each workflow node and should be valid js.\nFor more information on using this function please refer to the functions documentation.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>clInfo</span> : de.elo.ix.client.ClientInfo<div class='sub-desc'><p>object with language, country and ticket</p>\n\n</div></li><li><span class='pre'>userId</span> : number<div class='sub-desc'><p>The calling users ID</p>\n\n</div></li><li><span class='pre'>wFDiagram</span> : de.elo.ix.client.WFDiagram<div class='sub-desc'>\n</div></li><li><span class='pre'>nodeId</span> : number<div class='sub-desc'><p>The deactivated node ID</p>\n\n</div></li></ul></div></div></div></div></div></div></div>","meta":{"eloix":true}});
Ext.data.JsonP.sol_common_ix_functions_Move({"tagname":"class","name":"sol.common.ix.functions.Move","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"sol.common.ix.functions.Move.js","href":"sol.common.ix.functions.Move.html#sol-common-ix-functions-Move"}],"author":[{"tagname":"author","name":"PZ, ELO Digital Office GmbH","email":null}],"version":["1.03.000"],"eloix":true,"requires":["sol.common.JsonUtils","sol.common.ObjectFormatter","sol.common.RepoUtils","sol.common.SordUtils","sol.common.Template","sol.common.UserUtils","sol.common.WfUtils","sol.common.ix.FunctionBase","sol.common.ix.RfUtils"],"aliases":{},"alternateClassNames":[],"extends":"sol.common.ix.FunctionBase","mixins":[],"uses":[],"members":[{"name":"adjustRights","tagname":"cfg","owner":"sol.common.ix.functions.Move","id":"cfg-adjustRights","meta":{}},{"name":"objId","tagname":"cfg","owner":"sol.common.ix.functions.Move","id":"cfg-objId","meta":{"required":true}},{"name":"path","tagname":"cfg","owner":"sol.common.ix.functions.Move","id":"cfg-path","meta":{}},{"name":"refOldParentId","tagname":"cfg","owner":"sol.common.ix.functions.Move","id":"cfg-refOldParentId","meta":{}},{"name":"referenceIds","tagname":"cfg","owner":"sol.common.ix.functions.Move","id":"cfg-referenceIds","meta":{}},{"name":"referencePaths","tagname":"cfg","owner":"sol.common.ix.functions.Move","id":"cfg-referencePaths","meta":{}},{"name":"requiredConfig","tagname":"cfg","owner":"sol.common.ix.functions.Move","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"rightsConfig","tagname":"cfg","owner":"sol.common.ix.functions.Move","id":"cfg-rightsConfig","meta":{}},{"name":"sordType","tagname":"cfg","owner":"sol.common.ix.functions.Move","id":"cfg-sordType","meta":{}},{"name":"targetId","tagname":"cfg","owner":"sol.common.ix.functions.Move","id":"cfg-targetId","meta":{}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"logger","tagname":"property","owner":"sol.common.ix.FunctionBase","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"initialize","tagname":"method","owner":"sol.common.ix.FunctionBase","id":"method-initialize","meta":{"private":true}},{"name":"process","tagname":"method","owner":"sol.common.ix.functions.Move","id":"method-process","meta":{}},{"name":"RF_sol_function_Move","tagname":"method","owner":"sol.common.ix.functions.Move","id":"static-method-RF_sol_function_Move","meta":{"static":true}},{"name":"onEnterNode","tagname":"method","owner":"sol.common.ix.functions.Move","id":"static-method-onEnterNode","meta":{"static":true}},{"name":"onExitNode","tagname":"method","owner":"sol.common.ix.functions.Move","id":"static-method-onExitNode","meta":{"static":true}}],"code_type":"ext_define","id":"class-sol.common.ix.functions.Move","short_doc":"Moves an archive element to a new location. ...","classIcon":"icon-class","superclasses":["sol.Base","sol.common.ix.FunctionBase"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='docClass'>sol.common.ix.FunctionBase</a><div class='subclass '><strong>sol.common.ix.functions.Move</strong></div></div></div><h4>Requires</h4><div class='dependency'><a href='#!/api/sol.common.JsonUtils' rel='sol.common.JsonUtils' class='docClass'>sol.common.JsonUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ObjectFormatter' rel='sol.common.ObjectFormatter' class='docClass'>sol.common.ObjectFormatter</a></div><div class='dependency'><a href='#!/api/sol.common.RepoUtils' rel='sol.common.RepoUtils' class='docClass'>sol.common.RepoUtils</a></div><div class='dependency'><a href='#!/api/sol.common.SordUtils' rel='sol.common.SordUtils' class='docClass'>sol.common.SordUtils</a></div><div class='dependency'><a href='#!/api/sol.common.Template' rel='sol.common.Template' class='docClass'>sol.common.Template</a></div><div class='dependency'><a href='#!/api/sol.common.UserUtils' rel='sol.common.UserUtils' class='docClass'>sol.common.UserUtils</a></div><div class='dependency'><a href='#!/api/sol.common.WfUtils' rel='sol.common.WfUtils' class='docClass'>sol.common.WfUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='docClass'>sol.common.ix.FunctionBase</a></div><div class='dependency'><a href='#!/api/sol.common.ix.RfUtils' rel='sol.common.ix.RfUtils' class='docClass'>sol.common.ix.RfUtils</a></div><h4>Files</h4><div class='dependency'><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move' target='_blank'>sol.common.ix.functions.Move.js</a></div></pre><div class='doc-contents'><p>Moves an archive element to a new location. Alternatively only references can be created without moving.</p>\n\n<p>The path string can contain static parts as well as dynamic parts.\nDynamic parts are in [handlebars] (http://handlebarsjs.com/) syntax (see also <a href=\"#!/api/sol.common.Template\" rel=\"sol.common.Template\" class=\"docClass\">sol.common.Template</a>)\nand have access to the sord object in form of a <a href=\"#!/api/sol.common.ObjectFormatter.TemplateSord\" rel=\"sol.common.ObjectFormatter.TemplateSord\" class=\"docClass\">TemplateSord</a>.</p>\n\n<p>Please note that handlebars does html-escaping by default if used double-curlies {{ sord.name }}. Therefore trippe-curlies should be used {{{ sord.name }}} since that prevents escaping strings.</p>\n\n<h1>As workflow node</h1>\n\n<p>ObjId is set based on the element that the workflow is attached to.\nFollowing configuration should be applied to the comments field.</p>\n\n<pre><code>{\n  \"path\": \"¶Invoice¶Archive¶{{{substring sord.objKeys.INVOICE_DATE 0 4}}}¶{{{substring sord.objKeys.VENDOR_NAME 0 1}}}¶{{{sord.objKeys.VENDOR_NAME}}}\",\n  \"rightsConfig\": { \"mode\": \"ADD\", \"inherit\": true }\n}\n</code></pre>\n\n<h1>As IX function call</h1>\n\n<p>In addition to the workflow node configuration the objId must be passed.</p>\n\n<pre><code><a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a>(\"RF_sol_function_Move\", {\n  \"objId\": \"4711\",\n  \"path\": \"¶Invoice¶Archive¶{{{substring sord.objKeys.INVOICE_DATE 0 4}}}¶{{{substring sord.objKeys.VENDOR_NAME 0 1}}}¶{{{sord.objKeys.VENDOR_NAME}}}\",\n  \"adjustRights\": true\n});\n</code></pre>\n\n<p>Move move object and keep reference on old location</p>\n\n<pre><code><a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a>(\"RF_sol_function_Move\", {\n  \"objId\": \"4711\",\n  \"path\": \"¶Invoice¶Archive¶{{{substring sord.objKeys.INVOICE_DATE 0 4}}}¶{{{substring sord.objKeys.VENDOR_NAME 0 1}}}¶{{{sord.objKeys.VENDOR_NAME}}}\",\n  \"refOldParentId\": true\n});\n</code></pre>\n\n<p>Set multiple references without moving</p>\n\n<pre><code><a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a>(\"RF_sol_function_Move\", {\n  \"objId\": \"4711\",\n  \"referenceIds\": [\"1815\", \"1816\", \"1817\"]\n});\n\n<a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a>(\"RF_sol_function_Move\", {\n  \"objId\": \"4711\",\n  \"referencePaths\": [\"¶Invoice¶Archive¶{{substring sord.objKeys.INVOICE_DATE 0 4}}¶{{substring sord.objKeys.VENDOR_NAME 0 1}}¶{{sord.objKeys.VENDOR_NAME}}\",\n                    \"¶Invoice¶Backup¶{{substring sord.objKeys.INVOICE_DATE 0 4}}¶{{substring sord.objKeys.VENDOR_NAME 0 1}}¶{{sord.objKeys.VENDOR_NAME}}\"]\n});\n</code></pre>\n      <p class='version-tag'>Version: <b>1.03.000</b></p>\n</div><div class='members'><div class='members-section'><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Required config options</h3><div id='cfg-objId' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Move'>sol.common.ix.functions.Move</span><br/><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move-cfg-objId' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Move-cfg-objId' class='name expandable'>objId</a> : String<span class=\"signature\"><span class='required' >required</span></span></div><div class='description'><div class='short'><p>ObjId, GUID or ARCPATH</p>\n</div><div class='long'><p>ObjId, GUID or ARCPATH</p>\n<p>Overrides: <a href=\"#!/api/sol.common.ix.FunctionBase-cfg-objId\" rel=\"sol.common.ix.FunctionBase-cfg-objId\" class=\"docClass\">sol.common.ix.FunctionBase.objId</a></p></div></div></div></div><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Optional config options</h3><div id='cfg-adjustRights' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Move'>sol.common.ix.functions.Move</span><br/><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move-cfg-adjustRights' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Move-cfg-adjustRights' class='name expandable'>adjustRights</a> : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'><p>If true, the rights will be inherited from the parent</p>\n</div><div class='long'><p>If true, the rights will be inherited from the parent</p>\n</div></div></div><div id='cfg-path' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Move'>sol.common.ix.functions.Move</span><br/><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move-cfg-path' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Move-cfg-path' class='name expandable'>path</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Either path or targetId has to be defined; targetId has priority; exception: if there are referenceIds or referencePa...</div><div class='long'><p>Either <code>path</code> or <code>targetId</code> has to be defined; <code>targetId</code> has priority; exception: if there are <code>referenceIds</code> or <code>referencePaths</code> are defined, in that case the original will not be moved;</p>\n</div></div></div><div id='cfg-refOldParentId' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Move'>sol.common.ix.functions.Move</span><br/><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move-cfg-refOldParentId' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Move-cfg-refOldParentId' class='name expandable'>refOldParentId</a> : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'><p>If set, a reference to original position will be created after move</p>\n</div><div class='long'><p>If set, a reference to original position will be created after move</p>\n</div></div></div><div id='cfg-referenceIds' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Move'>sol.common.ix.functions.Move</span><br/><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move-cfg-referenceIds' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Move-cfg-referenceIds' class='name expandable'>referenceIds</a> : String[]<span class=\"signature\"></span></div><div class='description'><div class='short'><p>If set, references will be created</p>\n</div><div class='long'><p>If set, references will be created</p>\n</div></div></div><div id='cfg-referencePaths' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Move'>sol.common.ix.functions.Move</span><br/><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move-cfg-referencePaths' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Move-cfg-referencePaths' class='name expandable'>referencePaths</a> : String[]<span class=\"signature\"></span></div><div class='description'><div class='short'><p>If set, references will be created</p>\n</div><div class='long'><p>If set, references will be created</p>\n</div></div></div><div id='cfg-requiredConfig' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Move'>sol.common.ix.functions.Move</span><br/><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Move-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n<p>Defaults to: <code>[&quot;objId&quot;]</code></p><p>Overrides: <a href=\"#!/api/sol.Base-cfg-requiredConfig\" rel=\"sol.Base-cfg-requiredConfig\" class=\"docClass\">sol.Base.requiredConfig</a></p></div></div></div><div id='cfg-rightsConfig' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Move'>sol.common.ix.functions.Move</span><br/><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move-cfg-rightsConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Move-cfg-rightsConfig' class='name expandable'>rightsConfig</a> : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Rights that will be set to the workflow object and it's children\n\nExample:\n\n{ \"inherit\": true, \"users\": [\"user1\"], \"r...</div><div class='long'><p>Rights that will be set to the workflow object and it's children</p>\n\n<p>Example:</p>\n\n<pre><code>{ \"inherit\": true, \"users\": [\"user1\"], \"rights\": { \"r\": true } }\n</code></pre>\n\n<p>The ACL will be inherited from the parent object and in addition the read right for the user \"user1\" will be set.</p>\n</div></div></div><div id='cfg-sordType' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Move'>sol.common.ix.functions.Move</span><br/><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move-cfg-sordType' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Move-cfg-sordType' class='name expandable'>sordType</a> : String|Number<span class=\"signature\"></span></div><div class='description'><div class='short'>Name or ID of a sord type for the newly created elements. ...</div><div class='long'><p>Name or ID of a sord type for the newly created elements. Fallback is the IX standard behaviour.</p>\n</div></div></div><div id='cfg-targetId' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Move'>sol.common.ix.functions.Move</span><br/><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move-cfg-targetId' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Move-cfg-targetId' class='name expandable'>targetId</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Either path or targetId has to be defined; targetId has priority; exception: if there are referenceIds or referencePa...</div><div class='long'><p>Either <code>path</code> or <code>targetId</code> has to be defined; <code>targetId</code> has priority; exception: if there are <code>referenceIds</code> or <code>referencePaths</code> are defined, in that case the original will not be moved;</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='defined-in docClass'>sol.common.ix.FunctionBase</a><br/><a href='source/lib_sol.common.ix.FunctionBase.html#sol-common-ix-FunctionBase-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.FunctionBase-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>The logger for the module</p>\n</div><div class='long'><p>The logger for the module</p>\n<p>Overrides: <a href=\"#!/api/sol.Base-property-logger\" rel=\"sol.Base-property-logger\" class=\"docClass\">sol.Base.logger</a></p></div></div></div></div></div><div class='members-section'><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Instance methods</h3><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='defined-in docClass'>sol.common.ix.FunctionBase</a><br/><a href='source/lib_sol.common.ix.FunctionBase.html#sol-common-ix-FunctionBase-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.FunctionBase-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul><p>Overrides: <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a></p></div></div></div><div id='method-process' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Move'>sol.common.ix.functions.Move</span><br/><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move-method-process' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Move-method-process' class='name expandable'>process</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Moves the element to a new location or set references. ...</div><div class='long'><p>Moves the element to a new location or set references.</p>\n<p>Overrides: <a href=\"#!/api/sol.common.ix.FunctionBase-method-process\" rel=\"sol.common.ix.FunctionBase-method-process\" class=\"docClass\">sol.common.ix.FunctionBase.process</a></p></div></div></div></div><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Static methods</h3><div id='static-method-RF_sol_function_Move' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Move'>sol.common.ix.functions.Move</span><br/><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move-static-method-RF_sol_function_Move' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Move-static-method-RF_sol_function_Move' class='name expandable'>RF_sol_function_Move</a>( <span class='pre'>Execution, args</span> )<span class=\"signature\"><span class='static' >static</span></span></div><div class='description'><div class='short'>This function can be called from an application by invoking the API function \"executeRegisteredFunction\" or by using\n...</div><div class='long'><p>This function can be called from an application by invoking the API function \"executeRegisteredFunction\" or by using\n<a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a> which internally handles the Any-Object conversion.</p>\n\n<p>All configuration params should be passed as a configuration object to the args param.</p>\n\n<pre><code><a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a>('RF_FunctionName', {\n  configParam1: 'myParam'\n});\n</code></pre>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>Execution</span> : de.elo.ix.client.IXServerEventsContext<div class='sub-desc'><p>context</p>\n\n</div></li><li><span class='pre'>args</span> : Object<div class='sub-desc'><p>Argument array sent by the client application.</p>\n\n</div></li></ul></div></div></div><div id='static-method-onEnterNode' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Move'>sol.common.ix.functions.Move</span><br/><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move-static-method-onEnterNode' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Move-static-method-onEnterNode' class='name expandable'>onEnterNode</a>( <span class='pre'>clInfo, userId, wFDiagram, nodeId</span> )<span class=\"signature\"><span class='static' >static</span></span></div><div class='description'><div class='short'>This function is called before a workflow node is activated. ...</div><div class='long'><p>This function is called before a workflow node is activated.</p>\n\n<p>The configuration for this function can be defined in the comments section of each workflow node and should be valid js.\nFor more information on using this function please refer to the functions documentation.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>clInfo</span> : de.elo.ix.client.ClientInfo<div class='sub-desc'><p>object with language, country and ticket</p>\n\n</div></li><li><span class='pre'>userId</span> : number<div class='sub-desc'><p>The calling users ID</p>\n\n</div></li><li><span class='pre'>wFDiagram</span> : de.elo.ix.client.WFDiagram<div class='sub-desc'>\n</div></li><li><span class='pre'>nodeId</span> : number<div class='sub-desc'><p>The activated node ID</p>\n\n</div></li></ul></div></div></div><div id='static-method-onExitNode' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.functions.Move'>sol.common.ix.functions.Move</span><br/><a href='source/sol.common.ix.functions.Move.html#sol-common-ix-functions-Move-static-method-onExitNode' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.functions.Move-static-method-onExitNode' class='name expandable'>onExitNode</a>( <span class='pre'>clInfo, userId, wFDiagram, nodeId</span> )<span class=\"signature\"><span class='static' >static</span></span></div><div class='description'><div class='short'>This function is called after a workflow node is deactivated. ...</div><div class='long'><p>This function is called after a workflow node is deactivated.</p>\n\n<p>The configuration for this function can be defined in the comments section of each workflow node and should be valid js.\nFor more information on using this function please refer to the functions documentation.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>clInfo</span> : de.elo.ix.client.ClientInfo<div class='sub-desc'><p>object with language, country and ticket</p>\n\n</div></li><li><span class='pre'>userId</span> : number<div class='sub-desc'><p>The calling users ID</p>\n\n</div></li><li><span class='pre'>wFDiagram</span> : de.elo.ix.client.WFDiagram<div class='sub-desc'>\n</div></li><li><span class='pre'>nodeId</span> : number<div class='sub-desc'><p>The deactivated node ID</p>\n\n</div></li></ul></div></div></div></div></div></div></div>","meta":{"eloix":true}});
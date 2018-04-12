Ext.data.JsonP.sol_common_sig_as_functions_CreateDocumentToSign({"tagname":"class","name":"sol.common_sig.as.functions.CreateDocumentToSign","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"lib_sol.common_sig.as.functions.CreateDocumentToSign.js","href":"lib_sol.common_sig.as.functions.CreateDocumentToSign.html#sol-common_sig-as-functions-CreateDocumentToSign"}],"author":[{"tagname":"author","name":"PZ, ELO Digital Office GmbH","email":null}],"version":["1.0"],"eloix":true,"requires":["handlebars","moment","sol.common.IxUtils","sol.common.JsonUtils","sol.common.ObjectFormatter","sol.common.ObjectUtils","sol.common.RepoUtils","sol.common.SordMap","sol.common.SordUtils","sol.common.StringUtils","sol.common.Template","sol.common.WfUtils","sol.common.as.FunctionBase","sol.common.as.Utils","sol.common.as.functions.OfficeConverter"],"aliases":{},"alternateClassNames":[],"extends":"sol.common.as.FunctionBase","mixins":[],"uses":[],"members":[{"name":"documentBasePath","tagname":"cfg","owner":"sol.common_sig.as.functions.CreateDocumentToSign","id":"cfg-documentBasePath","meta":{}},{"name":"documentTypeSource","tagname":"cfg","owner":"sol.common_sig.as.functions.CreateDocumentToSign","id":"cfg-documentTypeSource","meta":{}},{"name":"objId","tagname":"cfg","owner":"sol.common_sig.as.functions.CreateDocumentToSign","id":"cfg-objId","meta":{"required":true}},{"name":"requiredConfig","tagname":"cfg","owner":"sol.common_sig.as.functions.CreateDocumentToSign","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"userSource","tagname":"cfg","owner":"sol.common_sig.as.functions.CreateDocumentToSign","id":"cfg-userSource","meta":{"required":true}},{"name":"wfNameTemplate","tagname":"cfg","owner":"sol.common_sig.as.functions.CreateDocumentToSign","id":"cfg-wfNameTemplate","meta":{"required":true}},{"name":"wfTemplate","tagname":"cfg","owner":"sol.common_sig.as.functions.CreateDocumentToSign","id":"cfg-wfTemplate","meta":{"required":true}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"logger","tagname":"property","owner":"sol.common.as.FunctionBase","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"convertToPdf","tagname":"method","owner":"sol.common_sig.as.functions.CreateDocumentToSign","id":"method-convertToPdf","meta":{"private":true}},{"name":"execute","tagname":"method","owner":"sol.common.as.FunctionBase","id":"method-execute","meta":{}},{"name":"getTemplateArcPath","tagname":"method","owner":"sol.common_sig.as.functions.CreateDocumentToSign","id":"method-getTemplateArcPath","meta":{"private":true}},{"name":"initialize","tagname":"method","owner":"sol.common.as.FunctionBase","id":"method-initialize","meta":{"private":true}},{"name":"process","tagname":"method","owner":"sol.common_sig.as.functions.CreateDocumentToSign","id":"method-process","meta":{}}],"code_type":"ext_define","id":"class-sol.common_sig.as.functions.CreateDocumentToSign","short_doc":"Checks whether a document and user are specified, copies the doc into the parent object and starts the workflow to si...","classIcon":"icon-class","superclasses":["sol.Base","sol.common.as.FunctionBase"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><a href='#!/api/sol.common.as.FunctionBase' rel='sol.common.as.FunctionBase' class='docClass'>sol.common.as.FunctionBase</a><div class='subclass '><strong>sol.common_sig.as.functions.CreateDocumentToSign</strong></div></div></div><h4>Requires</h4><div class='dependency'>handlebars</div><div class='dependency'>moment</div><div class='dependency'><a href='#!/api/sol.common.IxUtils' rel='sol.common.IxUtils' class='docClass'>sol.common.IxUtils</a></div><div class='dependency'><a href='#!/api/sol.common.JsonUtils' rel='sol.common.JsonUtils' class='docClass'>sol.common.JsonUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ObjectFormatter' rel='sol.common.ObjectFormatter' class='docClass'>sol.common.ObjectFormatter</a></div><div class='dependency'><a href='#!/api/sol.common.ObjectUtils' rel='sol.common.ObjectUtils' class='docClass'>sol.common.ObjectUtils</a></div><div class='dependency'><a href='#!/api/sol.common.RepoUtils' rel='sol.common.RepoUtils' class='docClass'>sol.common.RepoUtils</a></div><div class='dependency'><a href='#!/api/sol.common.SordMap' rel='sol.common.SordMap' class='docClass'>sol.common.SordMap</a></div><div class='dependency'><a href='#!/api/sol.common.SordUtils' rel='sol.common.SordUtils' class='docClass'>sol.common.SordUtils</a></div><div class='dependency'><a href='#!/api/sol.common.StringUtils' rel='sol.common.StringUtils' class='docClass'>sol.common.StringUtils</a></div><div class='dependency'><a href='#!/api/sol.common.Template' rel='sol.common.Template' class='docClass'>sol.common.Template</a></div><div class='dependency'><a href='#!/api/sol.common.WfUtils' rel='sol.common.WfUtils' class='docClass'>sol.common.WfUtils</a></div><div class='dependency'><a href='#!/api/sol.common.as.FunctionBase' rel='sol.common.as.FunctionBase' class='docClass'>sol.common.as.FunctionBase</a></div><div class='dependency'><a href='#!/api/sol.common.as.Utils' rel='sol.common.as.Utils' class='docClass'>sol.common.as.Utils</a></div><div class='dependency'>sol.common.as.functions.OfficeConverter</div><h4>Files</h4><div class='dependency'><a href='source/lib_sol.common_sig.as.functions.CreateDocumentToSign.html#sol-common_sig-as-functions-CreateDocumentToSign' target='_blank'>lib_sol.common_sig.as.functions.CreateDocumentToSign.js</a></div></pre><div class='doc-contents'><p>Checks whether a document and user are specified, copies the doc into the parent object and starts the workflow to sign it.</p>\n\n<p>The User will be set on the workflow node with the kay <code>sol.common_sig.wf.user.signDocument</code>.</p>\n\n<p>If <code>documentBasePath</code> and <code>documentTypeSource</code> are defined, this function will copy a template to the target specified by <code>objId</code>.\nIf neither of those are defined, the finction will try to convert and sign the element specified by <code>objId</code>.</p>\n      <p class='version-tag'>Version: <b>1.0</b></p>\n</div><div class='members'><div class='members-section'><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Required config options</h3><div id='cfg-objId' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_sig.as.functions.CreateDocumentToSign'>sol.common_sig.as.functions.CreateDocumentToSign</span><br/><a href='source/lib_sol.common_sig.as.functions.CreateDocumentToSign.html#sol-common_sig-as-functions-CreateDocumentToSign-cfg-objId' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_sig.as.functions.CreateDocumentToSign-cfg-objId' class='name expandable'>objId</a> : String<span class=\"signature\"><span class='required' >required</span></span></div><div class='description'><div class='short'>This is either the id of the target (in case documentBasePath and documentTypeSource are definied) or the id of the d...</div><div class='long'><p>This is either the id of the target (in case <code>documentBasePath</code> and <code>documentTypeSource</code> are definied) or the id of the document which should be signed.</p>\n<p>Overrides: <a href=\"#!/api/sol.common.as.FunctionBase-cfg-objId\" rel=\"sol.common.as.FunctionBase-cfg-objId\" class=\"docClass\">sol.common.as.FunctionBase.objId</a></p></div></div></div><div id='cfg-userSource' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_sig.as.functions.CreateDocumentToSign'>sol.common_sig.as.functions.CreateDocumentToSign</span><br/><a href='source/lib_sol.common_sig.as.functions.CreateDocumentToSign.html#sol-common_sig-as-functions-CreateDocumentToSign-cfg-userSource' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_sig.as.functions.CreateDocumentToSign-cfg-userSource' class='name expandable'>userSource</a> : Object<span class=\"signature\"><span class='required' >required</span></span></div><div class='description'><div class='short'><p>Definition where the signing user should be read from (see <a href=\"#!/api/sol.common.SordUtils-method-getValue\" rel=\"sol.common.SordUtils-method-getValue\" class=\"docClass\">sol.common.SordUtils.getValue</a> for object definition)</p>\n</div><div class='long'><p>Definition where the signing user should be read from (see <a href=\"#!/api/sol.common.SordUtils-method-getValue\" rel=\"sol.common.SordUtils-method-getValue\" class=\"docClass\">sol.common.SordUtils.getValue</a> for object definition)</p>\n</div></div></div><div id='cfg-wfNameTemplate' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_sig.as.functions.CreateDocumentToSign'>sol.common_sig.as.functions.CreateDocumentToSign</span><br/><a href='source/lib_sol.common_sig.as.functions.CreateDocumentToSign.html#sol-common_sig-as-functions-CreateDocumentToSign-cfg-wfNameTemplate' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_sig.as.functions.CreateDocumentToSign-cfg-wfNameTemplate' class='name expandable'>wfNameTemplate</a> : String<span class=\"signature\"><span class='required' >required</span></span></div><div class='description'><div class='short'><p>The template for the name of the started workflow (in handlebars syntax: <code>sord</code> and <code>wfDate</code> are available)</p>\n</div><div class='long'><p>The template for the name of the started workflow (in handlebars syntax: <code>sord</code> and <code>wfDate</code> are available)</p>\n</div></div></div><div id='cfg-wfTemplate' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_sig.as.functions.CreateDocumentToSign'>sol.common_sig.as.functions.CreateDocumentToSign</span><br/><a href='source/lib_sol.common_sig.as.functions.CreateDocumentToSign.html#sol-common_sig-as-functions-CreateDocumentToSign-cfg-wfTemplate' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_sig.as.functions.CreateDocumentToSign-cfg-wfTemplate' class='name expandable'>wfTemplate</a> : String<span class=\"signature\"><span class='required' >required</span></span></div><div class='description'><div class='short'><p>The name of the workflow template which should be started</p>\n</div><div class='long'><p>The name of the workflow template which should be started</p>\n</div></div></div></div><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Optional config options</h3><div id='cfg-documentBasePath' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_sig.as.functions.CreateDocumentToSign'>sol.common_sig.as.functions.CreateDocumentToSign</span><br/><a href='source/lib_sol.common_sig.as.functions.CreateDocumentToSign.html#sol-common_sig-as-functions-CreateDocumentToSign-cfg-documentBasePath' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_sig.as.functions.CreateDocumentToSign-cfg-documentBasePath' class='name expandable'>documentBasePath</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'><p>(optional) ARCPATH with the documents which could be signed</p>\n</div><div class='long'><p>(optional) ARCPATH with the documents which could be signed</p>\n</div></div></div><div id='cfg-documentTypeSource' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_sig.as.functions.CreateDocumentToSign'>sol.common_sig.as.functions.CreateDocumentToSign</span><br/><a href='source/lib_sol.common_sig.as.functions.CreateDocumentToSign.html#sol-common_sig-as-functions-CreateDocumentToSign-cfg-documentTypeSource' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_sig.as.functions.CreateDocumentToSign-cfg-documentTypeSource' class='name expandable'>documentTypeSource</a> : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>(optional) Definition where the selected document type should be read from (see sol.common.SordUtils.getValue for obj...</div><div class='long'><p>(optional) Definition where the selected document type should be read from (see <a href=\"#!/api/sol.common.SordUtils-method-getValue\" rel=\"sol.common.SordUtils-method-getValue\" class=\"docClass\">sol.common.SordUtils.getValue</a> for object definition)</p>\n</div></div></div><div id='cfg-requiredConfig' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_sig.as.functions.CreateDocumentToSign'>sol.common_sig.as.functions.CreateDocumentToSign</span><br/><a href='source/lib_sol.common_sig.as.functions.CreateDocumentToSign.html#sol-common_sig-as-functions-CreateDocumentToSign-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_sig.as.functions.CreateDocumentToSign-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n<p>Defaults to: <code>[&quot;objId&quot;, &quot;wfTemplate&quot;, &quot;wfNameTemplate&quot;, &quot;userSource&quot;]</code></p><p>Overrides: <a href=\"#!/api/sol.Base-cfg-requiredConfig\" rel=\"sol.Base-cfg-requiredConfig\" class=\"docClass\">sol.Base.requiredConfig</a></p></div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.as.FunctionBase' rel='sol.common.as.FunctionBase' class='defined-in docClass'>sol.common.as.FunctionBase</a><br/><a href='source/lib_sol.common.as.FunctionBase.html#sol-common-as-FunctionBase-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.as.FunctionBase-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>The logger for the module</p>\n</div><div class='long'><p>The logger for the module</p>\n<p>Overrides: <a href=\"#!/api/sol.Base-property-logger\" rel=\"sol.Base-property-logger\" class=\"docClass\">sol.Base.logger</a></p></div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-convertToPdf' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_sig.as.functions.CreateDocumentToSign'>sol.common_sig.as.functions.CreateDocumentToSign</span><br/><a href='source/lib_sol.common_sig.as.functions.CreateDocumentToSign.html#sol-common_sig-as-functions-CreateDocumentToSign-method-convertToPdf' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_sig.as.functions.CreateDocumentToSign-method-convertToPdf' class='name expandable'>convertToPdf</a>( <span class='pre'>sord</span> ) : String<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Converts a document to a PDF. ...</div><div class='long'><p>Converts a document to a PDF.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>sord</span> : de.elo.ix.client.Sord<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'><p>The objId of the converted document or '-1' if there was an error</p>\n</div></li></ul></div></div></div><div id='method-execute' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.as.FunctionBase' rel='sol.common.as.FunctionBase' class='defined-in docClass'>sol.common.as.FunctionBase</a><br/><a href='source/lib_sol.common.as.FunctionBase.html#sol-common-as-FunctionBase-method-execute' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.as.FunctionBase-method-execute' class='name expandable'>execute</a>( <span class='pre'></span> ) : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Execution of the function module ...</div><div class='long'><p>Execution of the function module</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-getTemplateArcPath' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_sig.as.functions.CreateDocumentToSign'>sol.common_sig.as.functions.CreateDocumentToSign</span><br/><a href='source/lib_sol.common_sig.as.functions.CreateDocumentToSign.html#sol-common_sig-as-functions-CreateDocumentToSign-method-getTemplateArcPath' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_sig.as.functions.CreateDocumentToSign-method-getTemplateArcPath' class='name expandable'>getTemplateArcPath</a>( <span class='pre'>documentType, basePath</span> ) : String<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'> ...</div><div class='long'>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>documentType</span> : String<div class='sub-desc'>\n</div></li><li><span class='pre'>basePath</span> : String<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.as.FunctionBase' rel='sol.common.as.FunctionBase' class='defined-in docClass'>sol.common.as.FunctionBase</a><br/><a href='source/lib_sol.common.as.FunctionBase.html#sol-common-as-FunctionBase-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.as.FunctionBase-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul><p>Overrides: <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a></p></div></div></div><div id='method-process' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_sig.as.functions.CreateDocumentToSign'>sol.common_sig.as.functions.CreateDocumentToSign</span><br/><a href='source/lib_sol.common_sig.as.functions.CreateDocumentToSign.html#sol-common_sig-as-functions-CreateDocumentToSign-method-process' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_sig.as.functions.CreateDocumentToSign-method-process' class='name expandable'>process</a>( <span class='pre'></span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Creates a document to sign and starts the signing workflow. ...</div><div class='long'><p>Creates a document to sign and starts the signing workflow.</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'>\n</div></li></ul><p>Overrides: <a href=\"#!/api/sol.common.as.FunctionBase-method-process\" rel=\"sol.common.as.FunctionBase-method-process\" class=\"docClass\">sol.common.as.FunctionBase.process</a></p></div></div></div></div></div></div></div>","meta":{"eloix":true}});
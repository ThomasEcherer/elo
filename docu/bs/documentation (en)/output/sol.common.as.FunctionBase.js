Ext.data.JsonP.sol_common_as_FunctionBase({"tagname":"class","name":"sol.common.as.FunctionBase","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"requires":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"lib_sol.common.as.FunctionBase.js","href":"lib_sol.common.as.FunctionBase.html#sol-common-as-FunctionBase"}],"abstract":true,"eloix":true,"aliases":{},"alternateClassNames":[],"extends":"sol.Base","mixins":[],"requires":[],"uses":[],"members":[{"name":"objId","tagname":"cfg","owner":"sol.common.as.FunctionBase","id":"cfg-objId","meta":{}},{"name":"requiredConfig","tagname":"cfg","owner":"sol.Base","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"logger","tagname":"property","owner":"sol.common.as.FunctionBase","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"execute","tagname":"method","owner":"sol.common.as.FunctionBase","id":"method-execute","meta":{}},{"name":"initialize","tagname":"method","owner":"sol.common.as.FunctionBase","id":"method-initialize","meta":{"private":true}},{"name":"process","tagname":"method","owner":"sol.common.as.FunctionBase","id":"method-process","meta":{"abstract":true}}],"code_type":"ext_define","id":"class-sol.common.as.FunctionBase","short_doc":"Basic operations used by elo business solutions are modularized as ELOas function modules. ...","classIcon":"icon-class","superclasses":["sol.Base"],"subclasses":["sol.common.as.ExporterBase","sol.common.as.functions.CreateSignedPdf","sol.common.as.functions.Export","sol.common.as.functions.SendMail","sol.common_sig.as.functions.CreateDocumentToSign"],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><strong>sol.common.as.FunctionBase</strong></div></div><h4>Subclasses</h4><div class='dependency'><a href='#!/api/sol.common.as.ExporterBase' rel='sol.common.as.ExporterBase' class='docClass'>sol.common.as.ExporterBase</a></div><div class='dependency'><a href='#!/api/sol.common.as.functions.CreateSignedPdf' rel='sol.common.as.functions.CreateSignedPdf' class='docClass'>sol.common.as.functions.CreateSignedPdf</a></div><div class='dependency'><a href='#!/api/sol.common.as.functions.Export' rel='sol.common.as.functions.Export' class='docClass'>sol.common.as.functions.Export</a></div><div class='dependency'><a href='#!/api/sol.common.as.functions.SendMail' rel='sol.common.as.functions.SendMail' class='docClass'>sol.common.as.functions.SendMail</a></div><div class='dependency'><a href='#!/api/sol.common_sig.as.functions.CreateDocumentToSign' rel='sol.common_sig.as.functions.CreateDocumentToSign' class='docClass'>sol.common_sig.as.functions.CreateDocumentToSign</a></div><h4>Files</h4><div class='dependency'><a href='source/lib_sol.common.as.FunctionBase.html#sol-common-as-FunctionBase' target='_blank'>lib_sol.common.as.FunctionBase.js</a></div></pre><div class='doc-contents'><p>Basic operations used by elo business solutions are modularized as ELOas function modules.</p>\n\n<p>Implementations should allow using functions in different ways:\n  - As a workflow node\n  - Executed within ELOas Scripts</p>\n\n<h1>Implementing a function</h1>\n\n<p>A function must extend the class FunctionBase.</p>\n\n<pre><code><a href=\"#!/api/sol-static-method-define\" rel=\"sol-static-method-define\" class=\"docClass\">sol.define</a>(\"custom.solution.as.function.MyFunction\", {\n  extends: \"<a href=\"#!/api/sol.common.as.FunctionBase\" rel=\"sol.common.as.FunctionBase\" class=\"docClass\">sol.common.as.FunctionBase</a>\",\n\n  requiredConfig: [\"objId\", \"myParam\"],\n\n  initialize: function (config) {\n    var me = this;\n    me.$super(\"<a href=\"#!/api/sol.common.ix.FunctionBase\" rel=\"sol.common.ix.FunctionBase\" class=\"docClass\">sol.common.ix.FunctionBase</a>\", \"initialize\", [config]);\n  },\n\n  process: function() {\n    // function logic goes here\n    var me = this;\n    me.myParam;\n  },\n});\n</code></pre>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div id='cfg-objId' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.as.FunctionBase'>sol.common.as.FunctionBase</span><br/><a href='source/lib_sol.common.as.FunctionBase.html#sol-common-as-FunctionBase-cfg-objId' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.as.FunctionBase-cfg-objId' class='name expandable'>objId</a> : string<span class=\"signature\"></span></div><div class='description'><div class='short'><p>Object ID for the element</p>\n</div><div class='long'><p>Object ID for the element</p>\n</div></div></div><div id='cfg-requiredConfig' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-logger' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.as.FunctionBase'>sol.common.as.FunctionBase</span><br/><a href='source/lib_sol.common.as.FunctionBase.html#sol-common-as-FunctionBase-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.as.FunctionBase-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>The logger for the module</p>\n</div><div class='long'><p>The logger for the module</p>\n<p>Overrides: <a href=\"#!/api/sol.Base-property-logger\" rel=\"sol.Base-property-logger\" class=\"docClass\">sol.Base.logger</a></p></div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-execute' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.as.FunctionBase'>sol.common.as.FunctionBase</span><br/><a href='source/lib_sol.common.as.FunctionBase.html#sol-common-as-FunctionBase-method-execute' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.as.FunctionBase-method-execute' class='name expandable'>execute</a>( <span class='pre'></span> ) : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Execution of the function module ...</div><div class='long'><p>Execution of the function module</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.as.FunctionBase'>sol.common.as.FunctionBase</span><br/><a href='source/lib_sol.common.as.FunctionBase.html#sol-common-as-FunctionBase-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.as.FunctionBase-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul><p>Overrides: <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a></p></div></div></div><div id='method-process' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.as.FunctionBase'>sol.common.as.FunctionBase</span><br/><a href='source/lib_sol.common.as.FunctionBase.html#sol-common-as-FunctionBase-method-process' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.as.FunctionBase-method-process' class='name expandable'>process</a>( <span class='pre'></span> )<span class=\"signature\"><span class='abstract' >abstract</span></span></div><div class='description'><div class='short'>Implementation of function modules' process. ...</div><div class='long'><p>Implementation of function modules' process.\nThis function must be implemented by the child class and should contain the logic of the function module.</p>\n</div></div></div></div></div></div></div>","meta":{"eloix":true,"abstract":true}});
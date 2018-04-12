Ext.data.JsonP.sol_common_ix_services_GetWorkflowMetadata({"tagname":"class","name":"sol.common.ix.services.GetWorkflowMetadata","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"sol.common.ix.services.GetWorkflowMeta.js","href":"sol.common.ix.services.GetWorkflowMeta.html#sol-common-ix-services-GetWorkflowMetadata"}],"author":[{"tagname":"author","name":"PZ, ELO Digital Office GmbH","email":null}],"version":["1.0"],"eloix":true,"requires":["sol.common.WfUtils","sol.common.ix.RfUtils"],"aliases":{},"alternateClassNames":[],"extends":"sol.common.ix.ServiceBase","mixins":[],"uses":[],"members":[{"name":"flowId","tagname":"cfg","owner":"sol.common.ix.services.GetWorkflowMetadata","id":"cfg-flowId","meta":{}},{"name":"inclFinished","tagname":"cfg","owner":"sol.common.ix.services.GetWorkflowMetadata","id":"cfg-inclFinished","meta":{}},{"name":"objId","tagname":"cfg","owner":"sol.common.ix.ServiceBase","id":"cfg-objId","meta":{}},{"name":"requiredConfig","tagname":"cfg","owner":"sol.common.ix.services.GetWorkflowMetadata","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"data","tagname":"property","owner":"sol.common.ix.ServiceBase","id":"property-data","meta":{}},{"name":"logger","tagname":"property","owner":"sol.common.ix.ServiceBase","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"checkMandatoryProperties","tagname":"method","owner":"sol.common.ix.ServiceBase","id":"method-checkMandatoryProperties","meta":{"protected":true}},{"name":"containsClassName","tagname":"method","owner":"sol.common.ix.ServiceBase","id":"method-containsClassName","meta":{}},{"name":"initialize","tagname":"method","owner":"sol.common.ix.ServiceBase","id":"method-initialize","meta":{"private":true}},{"name":"prefillMetadata","tagname":"method","owner":"sol.common.ix.ServiceBase","id":"method-prefillMetadata","meta":{"protected":true}},{"name":"process","tagname":"method","owner":"sol.common.ix.services.GetWorkflowMetadata","id":"method-process","meta":{}},{"name":"RF_sol_common_service_GetWorkflowMetadata","tagname":"method","owner":"sol.common.ix.services.GetWorkflowMetadata","id":"static-method-RF_sol_common_service_GetWorkflowMetadata","meta":{"static":true}}],"code_type":"ext_define","id":"class-sol.common.ix.services.GetWorkflowMetadata","short_doc":"Retrieves some metadata of a workflow. ...","classIcon":"icon-class","superclasses":["sol.Base","sol.common.ix.ServiceBase"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><a href='#!/api/sol.common.ix.ServiceBase' rel='sol.common.ix.ServiceBase' class='docClass'>sol.common.ix.ServiceBase</a><div class='subclass '><strong>sol.common.ix.services.GetWorkflowMetadata</strong></div></div></div><h4>Requires</h4><div class='dependency'><a href='#!/api/sol.common.WfUtils' rel='sol.common.WfUtils' class='docClass'>sol.common.WfUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ix.RfUtils' rel='sol.common.ix.RfUtils' class='docClass'>sol.common.ix.RfUtils</a></div><h4>Files</h4><div class='dependency'><a href='source/sol.common.ix.services.GetWorkflowMeta.html#sol-common-ix-services-GetWorkflowMetadata' target='_blank'>sol.common.ix.services.GetWorkflowMeta.js</a></div></pre><div class='doc-contents'><p>Retrieves some metadata of a workflow.</p>\n\n<h1>As IX service call</h1>\n\n<pre><code><a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a>('RF_sol_common_service_GetWorkflowMetadata', {\n  flowId: \"4711\"\n});\n</code></pre>\n\n<p>Returns the workflow metadata:</p>\n\n<pre><code>{\n  flowId: 4711,            // the workflow id\n  name: \"Musterflow\",      // the workflow name\n  objId: \"0815\",           // the objId\n  objName: \"Testdoc\",      // the objects name\n  status: \"SUCCESS\",       // the workflow status\n  templateId: 23,          // the template id\n  templateName: \"Muster\",  // the template name\n  ownerId: 0,              // the owner id\n  ownerName: \"Admin\",      // the owner name\n  activeNodes: [           // a list of all active nodes\n    {\n      nodeId: 1,           // id of the active node\n      nodeName: \"node 1\",  // name of the active node\n      userId: 0,           // id of the node user\n      userName: \"Admin\"    // name of the node user\n    }\n  ]\n}\n</code></pre>\n      <p class='version-tag'>Version: <b>1.0</b></p>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div id='cfg-flowId' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.services.GetWorkflowMetadata'>sol.common.ix.services.GetWorkflowMetadata</span><br/><a href='source/sol.common.ix.services.GetWorkflowMeta.html#sol-common-ix-services-GetWorkflowMetadata-cfg-flowId' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.services.GetWorkflowMetadata-cfg-flowId' class='name expandable'>flowId</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div><div id='cfg-inclFinished' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.services.GetWorkflowMetadata'>sol.common.ix.services.GetWorkflowMetadata</span><br/><a href='source/sol.common.ix.services.GetWorkflowMeta.html#sol-common-ix-services-GetWorkflowMetadata-cfg-inclFinished' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.services.GetWorkflowMetadata-cfg-inclFinished' class='name expandable'>inclFinished</a> : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>(optional) ...</div><div class='long'><p>(optional)</p>\n<p>Defaults to: <code>true</code></p></div></div></div><div id='cfg-objId' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.ServiceBase' rel='sol.common.ix.ServiceBase' class='defined-in docClass'>sol.common.ix.ServiceBase</a><br/><a href='source/lib_sol.common.ix.ServiceBase.html#sol-common-ix-ServiceBase-cfg-objId' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.ServiceBase-cfg-objId' class='name expandable'>objId</a> : string<span class=\"signature\"></span></div><div class='description'><div class='short'><p>Object ID for the element</p>\n</div><div class='long'><p>Object ID for the element</p>\n</div></div></div><div id='cfg-requiredConfig' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.services.GetWorkflowMetadata'>sol.common.ix.services.GetWorkflowMetadata</span><br/><a href='source/sol.common.ix.services.GetWorkflowMeta.html#sol-common-ix-services-GetWorkflowMetadata-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.services.GetWorkflowMetadata-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n<p>Defaults to: <code>[&quot;flowId&quot;]</code></p><p>Overrides: <a href=\"#!/api/sol.Base-cfg-requiredConfig\" rel=\"sol.Base-cfg-requiredConfig\" class=\"docClass\">sol.Base.requiredConfig</a></p></div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-data' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.ServiceBase' rel='sol.common.ix.ServiceBase' class='defined-in docClass'>sol.common.ix.ServiceBase</a><br/><a href='source/lib_sol.common.ix.ServiceBase.html#sol-common-ix-ServiceBase-property-data' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.ServiceBase-property-data' class='name expandable'>data</a> : Object<span class=\"signature\"></span></div><div class='description'><div class='short'><p>(optional)\nHas to be in a specific form (see <a href=\"#!/api/sol.common.SordUtils-method-updateSord\" rel=\"sol.common.SordUtils-method-updateSord\" class=\"docClass\">sol.common.SordUtils.updateSord</a>).</p>\n</div><div class='long'><p>(optional)\nHas to be in a specific form (see <a href=\"#!/api/sol.common.SordUtils-method-updateSord\" rel=\"sol.common.SordUtils-method-updateSord\" class=\"docClass\">sol.common.SordUtils.updateSord</a>).</p>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.ServiceBase' rel='sol.common.ix.ServiceBase' class='defined-in docClass'>sol.common.ix.ServiceBase</a><br/><a href='source/lib_sol.common.ix.ServiceBase.html#sol-common-ix-ServiceBase-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.ServiceBase-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>The logger for the service</p>\n</div><div class='long'><p>The logger for the service</p>\n<p>Overrides: <a href=\"#!/api/sol.Base-property-logger\" rel=\"sol.Base-property-logger\" class=\"docClass\">sol.Base.logger</a></p></div></div></div></div></div><div class='members-section'><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Instance methods</h3><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-checkMandatoryProperties' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.ServiceBase' rel='sol.common.ix.ServiceBase' class='defined-in docClass'>sol.common.ix.ServiceBase</a><br/><a href='source/lib_sol.common.ix.ServiceBase.html#sol-common-ix-ServiceBase-method-checkMandatoryProperties' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.ServiceBase-method-checkMandatoryProperties' class='name expandable'>checkMandatoryProperties</a>( <span class='pre'></span> )<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>Checks if all mandatory properties have been set. ...</div><div class='long'><p>Checks if all mandatory properties have been set.</p>\n</div></div></div><div id='method-containsClassName' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.ServiceBase' rel='sol.common.ix.ServiceBase' class='defined-in docClass'>sol.common.ix.ServiceBase</a><br/><a href='source/lib_sol.common.ix.ServiceBase.html#sol-common-ix-ServiceBase-method-containsClassName' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.ServiceBase-method-containsClassName' class='name expandable'>containsClassName</a>( <span class='pre'>classNames</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Checks wether an array contains the class name ...</div><div class='long'><p>Checks wether an array contains the class name</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>classNames</span> : Array<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.ServiceBase' rel='sol.common.ix.ServiceBase' class='defined-in docClass'>sol.common.ix.ServiceBase</a><br/><a href='source/lib_sol.common.ix.ServiceBase.html#sol-common-ix-ServiceBase-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.ServiceBase-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul><p>Overrides: <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a></p></div></div></div><div id='method-prefillMetadata' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.common.ix.ServiceBase' rel='sol.common.ix.ServiceBase' class='defined-in docClass'>sol.common.ix.ServiceBase</a><br/><a href='source/lib_sol.common.ix.ServiceBase.html#sol-common-ix-ServiceBase-method-prefillMetadata' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.ServiceBase-method-prefillMetadata' class='name expandable'>prefillMetadata</a>( <span class='pre'>objId</span> )<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>Initializes the metadata of an element (defined by objId) from the internal data object. ...</div><div class='long'><p>Initializes the metadata of an element (defined by <code>objId</code>) from the internal <code>data</code> object.</p>\n\n<p>The <code>data</code> property has to be in a specific <a href=\"#!/api/sol.common.ix.ServiceBase-property-data\" rel=\"sol.common.ix.ServiceBase-property-data\" class=\"docClass\">form</a>.\nIf there is no data object no prefilling will be performed.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>objId</span> : String<div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-process' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.services.GetWorkflowMetadata'>sol.common.ix.services.GetWorkflowMetadata</span><br/><a href='source/sol.common.ix.services.GetWorkflowMeta.html#sol-common-ix-services-GetWorkflowMetadata-method-process' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.services.GetWorkflowMetadata-method-process' class='name expandable'>process</a>( <span class='pre'></span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Retrieves the metadata ...</div><div class='long'><p>Retrieves the metadata</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'>\n</div></li></ul><p>Overrides: <a href=\"#!/api/sol.common.ix.ServiceBase-method-process\" rel=\"sol.common.ix.ServiceBase-method-process\" class=\"docClass\">sol.common.ix.ServiceBase.process</a></p></div></div></div></div><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Static methods</h3><div id='static-method-RF_sol_common_service_GetWorkflowMetadata' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ix.services.GetWorkflowMetadata'>sol.common.ix.services.GetWorkflowMetadata</span><br/><a href='source/sol.common.ix.services.GetWorkflowMeta.html#sol-common-ix-services-GetWorkflowMetadata-static-method-RF_sol_common_service_GetWorkflowMetadata' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ix.services.GetWorkflowMetadata-static-method-RF_sol_common_service_GetWorkflowMetadata' class='name expandable'>RF_sol_common_service_GetWorkflowMetadata</a>( <span class='pre'>Execution, args</span> )<span class=\"signature\"><span class='static' >static</span></span></div><div class='description'><div class='short'>This service can be called from an application by invoking the API function \"executeRegisteredFunction\" or by using\ns...</div><div class='long'><p>This service can be called from an application by invoking the API function \"executeRegisteredFunction\" or by using\n<a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a> which internally handles the Any-Object conversion.</p>\n\n<p>All configuration params should be passed as a configuration object to the args param.</p>\n\n<pre><code><a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a>('RF_ServiceBaseName', {\n  configParam1: 'myParam'\n});\n</code></pre>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>Execution</span> : de.elo.ix.client.IXServerEventsContext<div class='sub-desc'><p>context</p>\n</div></li><li><span class='pre'>args</span> : Object<div class='sub-desc'><p>Argument array sent by the client application.</p>\n</div></li></ul></div></div></div></div></div></div></div>","meta":{"eloix":true}});
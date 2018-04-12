Ext.data.JsonP.sol_common_monitoring_as_Monitor({"tagname":"class","name":"sol.common_monitoring.as.Monitor","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"lib_sol.common_monitoring.as.Monitor.js","href":"lib_sol.common_monitoring.as.Monitor.html#sol-common_monitoring-as-Monitor"}],"author":[{"tagname":"author","name":"PZ, ELO Digital Office GmbH","email":null}],"version":["1.02.000"],"eloas":true,"requires":["sol.commom.DateUtils","sol.common.ObjectUtils"],"aliases":{},"alternateClassNames":[],"extends":"sol.Base","mixins":[],"uses":[],"members":[{"name":"analyzer","tagname":"cfg","owner":"sol.common_monitoring.as.Monitor","id":"cfg-analyzer","meta":{}},{"name":"collector","tagname":"cfg","owner":"sol.common_monitoring.as.Monitor","id":"cfg-collector","meta":{}},{"name":"executor","tagname":"cfg","owner":"sol.common_monitoring.as.Monitor","id":"cfg-executor","meta":{}},{"name":"requiredConfig","tagname":"cfg","owner":"sol.common_monitoring.as.Monitor","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"logger","tagname":"property","owner":"sol.Base","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"checkComponents","tagname":"method","owner":"sol.common_monitoring.as.Monitor","id":"method-checkComponents","meta":{"private":true}},{"name":"checkInterface","tagname":"method","owner":"sol.common_monitoring.as.Monitor","id":"method-checkInterface","meta":{"private":true}},{"name":"close","tagname":"method","owner":"sol.common_monitoring.as.Monitor","id":"method-close","meta":{}},{"name":"disposeComponent","tagname":"method","owner":"sol.common_monitoring.as.Monitor","id":"method-disposeComponent","meta":{"private":true}},{"name":"initialize","tagname":"method","owner":"sol.Base","id":"method-initialize","meta":{"private":true}},{"name":"run","tagname":"method","owner":"sol.common_monitoring.as.Monitor","id":"method-run","meta":{}}],"code_type":"ext_define","id":"class-sol.common_monitoring.as.Monitor","short_doc":"Main class of the monitoring module. ...","classIcon":"icon-class","superclasses":["sol.Base"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><strong>sol.common_monitoring.as.Monitor</strong></div></div><h4>Requires</h4><div class='dependency'>sol.commom.DateUtils</div><div class='dependency'><a href='#!/api/sol.common.ObjectUtils' rel='sol.common.ObjectUtils' class='docClass'>sol.common.ObjectUtils</a></div><h4>Files</h4><div class='dependency'><a href='source/lib_sol.common_monitoring.as.Monitor.html#sol-common_monitoring-as-Monitor' target='_blank'>lib_sol.common_monitoring.as.Monitor.js</a></div></pre><div class='doc-contents'><p>Main class of the monitoring module.</p>\n\n<p>A monitor instance can be reused, but should be disposed via <code>close</code> method after last use.</p>\n\n<p>The monitor needs three components to perform the different tasks.\nAll components can define an optional 'dispose' function (with no parameter and no return value), which will be used by the monitor to clean up after the run.</p>\n\n<h1>Collector</h1>\n\n<p>Responsible for collecting the working set</p>\n\n<h2>Interface</h2>\n\n<ul>\n<li>hasMoreResults () : Boolean</li>\n<li>getResults () : de.elo.ix.client.Sord[]</li>\n<li>postProcess (de.elo.ix.client.Sord sord, Object[] results, Object ctx)</li>\n<li>getContext () : Object (optional, can return a prefilled context, if not implemented, the analyzers start with an empty context object)</li>\n</ul>\n\n\n<h1>Analyzer</h1>\n\n<h2>Interface</h2>\n\n<p>Responsible for performing the analysis and determining the necessary actions.</p>\n\n<ul>\n<li>analyze (de.elo.ix.client.Sord sord, Object ctx) : Object[]</li>\n</ul>\n\n\n<h1>Executor</h1>\n\n<p>Responsible for executing the actions.</p>\n\n<h2>Interface</h2>\n\n<ul>\n<li>execute (de.elo.ix.client.Sord sord, Object[] results, Object ctx)</li>\n</ul>\n\n\n<h1>Inter module dependencies</h1>\n\n<p>The object array returned by the analyzer modules <code>analyze</code> method will be handed over to the executor modules <code>execute</code> method and should therefor contain the needed properties.\nThe same objects will after execution be handed over to the collector modules <code>postProcess</code> method. The executor can enhance the result data further if needed.</p>\n\n<p>Each module is responsible for ensuring the consistency of the data it gets, because the monitor has no way of knowing, which modules play well together.</p>\n\n<h1>Module orchestration</h1>\n\n<ol>\n<li>Use <code>collector.getResults</code> to collect the first batch of Sord objects</li>\n<li>Iterate over batch</li>\n<li>Use <code>analyzer.analyze()</code> to check each Sord</li>\n<li>Use <code>executor.execute()</code> to execute potential actions</li>\n<li>Use <code>collector.postProcess()</code> to perform potential post processing</li>\n<li>Repeat from beginning until there are no results left</li>\n<li>Cleanup modules via <code>dispose()</code></li>\n</ol>\n\n\n<h1>Usage:</h1>\n\n<pre><code>var nextRunCollector = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(\"<a href=\"#!/api/sol.common_monitoring.as.collectors.NextRunCollector\" rel=\"sol.common_monitoring.as.collectors.NextRunCollector\" class=\"docClass\">sol.common_monitoring.as.collectors.NextRunCollector</a>\", { ... });\nvar retentionAnalyzer = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(\"<a href=\"#!/api/sol.common_monitoring.as.analyzers.RetentionAnalyzer\" rel=\"sol.common_monitoring.as.analyzers.RetentionAnalyzer\" class=\"docClass\">sol.common_monitoring.as.analyzers.RetentionAnalyzer</a>\", { ... });\nvar simpleExecutor = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(\"<a href=\"#!/api/sol.common_monitoring.as.executors.SimpleExecutor\" rel=\"sol.common_monitoring.as.executors.SimpleExecutor\" class=\"docClass\">sol.common_monitoring.as.executors.SimpleExecutor</a>\", { ... });\n\nvar monitor = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(\"<a href=\"#!/api/sol.common_monitoring.as.Monitor\" rel=\"sol.common_monitoring.as.Monitor\" class=\"docClass\">sol.common_monitoring.as.Monitor</a>\", {\n  collector: nextRunCollector,\n  analyzer: retentionAnalyzer,\n  executor: simpleExecutor\n});\nmonitor.run();\nmonitor.close();\n</code></pre>\n      <p class='version-tag'>Version: <b>1.02.000</b></p>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div id='cfg-analyzer' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.Monitor'>sol.common_monitoring.as.Monitor</span><br/><a href='source/lib_sol.common_monitoring.as.Monitor.html#sol-common_monitoring-as-Monitor-cfg-analyzer' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.Monitor-cfg-analyzer' class='name expandable'>analyzer</a> : Object<span class=\"signature\"></span></div><div class='description'><div class='short'><p>The component responsible for performing the analysis and determining the necessary actions</p>\n</div><div class='long'><p>The component responsible for performing the analysis and determining the necessary actions</p>\n</div></div></div><div id='cfg-collector' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.Monitor'>sol.common_monitoring.as.Monitor</span><br/><a href='source/lib_sol.common_monitoring.as.Monitor.html#sol-common_monitoring-as-Monitor-cfg-collector' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.Monitor-cfg-collector' class='name expandable'>collector</a> : Object<span class=\"signature\"></span></div><div class='description'><div class='short'><p>The component responsible for collecting the working set</p>\n</div><div class='long'><p>The component responsible for collecting the working set</p>\n</div></div></div><div id='cfg-executor' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.Monitor'>sol.common_monitoring.as.Monitor</span><br/><a href='source/lib_sol.common_monitoring.as.Monitor.html#sol-common_monitoring-as-Monitor-cfg-executor' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.Monitor-cfg-executor' class='name expandable'>executor</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'><p>The component responsible for executing the actions</p>\n</div><div class='long'><p>The component responsible for executing the actions</p>\n</div></div></div><div id='cfg-requiredConfig' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.Monitor'>sol.common_monitoring.as.Monitor</span><br/><a href='source/lib_sol.common_monitoring.as.Monitor.html#sol-common_monitoring-as-Monitor-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.Monitor-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n<p>Defaults to: <code>[&quot;collector&quot;, &quot;analyzer&quot;, &quot;executor&quot;]</code></p><p>Overrides: <a href=\"#!/api/sol.Base-cfg-requiredConfig\" rel=\"sol.Base-cfg-requiredConfig\" class=\"docClass\">sol.Base.requiredConfig</a></p></div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>Logger for this class instance. ...</div><div class='long'><p>Logger for this class instance. This logger is created by <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a>.</p>\n\n<p>Please see <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a> class documentation for more information.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-checkComponents' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.Monitor'>sol.common_monitoring.as.Monitor</span><br/><a href='source/lib_sol.common_monitoring.as.Monitor.html#sol-common_monitoring-as-Monitor-method-checkComponents' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.Monitor-method-checkComponents' class='name expandable'>checkComponents</a>( <span class='pre'></span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Checks all components if they implement the correct interface. ...</div><div class='long'><p>Checks all components if they implement the correct interface.</p>\n<h3 class='pa'>Throws</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>InitializationException</p>\n</div></li></ul></div></div></div><div id='method-checkInterface' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.Monitor'>sol.common_monitoring.as.Monitor</span><br/><a href='source/lib_sol.common_monitoring.as.Monitor.html#sol-common_monitoring-as-Monitor-method-checkInterface' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.Monitor-method-checkInterface' class='name expandable'>checkInterface</a>( <span class='pre'>component, name, functions</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Checks a component if it implements the correct interface. ...</div><div class='long'><p>Checks a component if it implements the correct interface.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>component</span> : Array<div class='sub-desc'><p>Component</p>\n</div></li><li><span class='pre'>name</span> : String<div class='sub-desc'><p>Name</p>\n</div></li><li><span class='pre'>functions</span> : Array<div class='sub-desc'><p>Functions</p>\n</div></li></ul><h3 class='pa'>Throws</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>InitializationException</p>\n</div></li></ul></div></div></div><div id='method-close' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.Monitor'>sol.common_monitoring.as.Monitor</span><br/><a href='source/lib_sol.common_monitoring.as.Monitor.html#sol-common_monitoring-as-Monitor-method-close' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.Monitor-method-close' class='name expandable'>close</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>This function should be used, to cleanup after using the monitor. ...</div><div class='long'><p>This function should be used, to cleanup after using the monitor.</p>\n</div></div></div><div id='method-disposeComponent' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.Monitor'>sol.common_monitoring.as.Monitor</span><br/><a href='source/lib_sol.common_monitoring.as.Monitor.html#sol-common_monitoring-as-Monitor-method-disposeComponent' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.Monitor-method-disposeComponent' class='name expandable'>disposeComponent</a>( <span class='pre'>component, name</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Cleans up a component if it defines a dispose function. ...</div><div class='long'><p>Cleans up a component if it defines a <code>dispose</code> function.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>component</span> : Object<div class='sub-desc'><p>The component</p>\n</div></li><li><span class='pre'>name</span> : String<div class='sub-desc'><p>The name of the component</p>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul></div></div></div><div id='method-run' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common_monitoring.as.Monitor'>sol.common_monitoring.as.Monitor</span><br/><a href='source/lib_sol.common_monitoring.as.Monitor.html#sol-common_monitoring-as-Monitor-method-run' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common_monitoring.as.Monitor-method-run' class='name expandable'>run</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Main method execute the monitor. ...</div><div class='long'><p>Main method execute the monitor.</p>\n</div></div></div></div></div></div></div>","meta":{"eloas":true}});
Ext.data.JsonP.sol_dev_install_FileLogger({"tagname":"class","name":"sol.dev.install.FileLogger","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"requires":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"lib_sol.dev.install.Installer.js","href":"lib_sol.dev.install.Installer.html#sol-dev-install-FileLogger"}],"aliases":{},"alternateClassNames":[],"extends":"sol.dev.install.LoggerBase","mixins":[],"requires":[],"uses":[],"members":[{"name":"requiredConfig","tagname":"cfg","owner":"sol.Base","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"tempDir","tagname":"cfg","owner":"sol.dev.install.FileLogger","id":"cfg-tempDir","meta":{}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"logger","tagname":"property","owner":"sol.Base","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"finalize","tagname":"method","owner":"sol.dev.install.FileLogger","id":"method-finalize","meta":{}},{"name":"getCurrentTimeStamp","tagname":"method","owner":"sol.dev.install.LoggerBase","id":"method-getCurrentTimeStamp","meta":{"private":true}},{"name":"getLogFolderId","tagname":"method","owner":"sol.dev.install.LoggerBase","id":"method-getLogFolderId","meta":{"private":true}},{"name":"initialize","tagname":"method","owner":"sol.dev.install.LoggerBase","id":"method-initialize","meta":{"private":true}},{"name":"log","tagname":"method","owner":"sol.dev.install.FileLogger","id":"method-log","meta":{}}],"code_type":"ext_define","id":"class-sol.dev.install.FileLogger","classIcon":"icon-class","superclasses":["sol.Base","sol.dev.install.LoggerBase"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><a href='#!/api/sol.dev.install.LoggerBase' rel='sol.dev.install.LoggerBase' class='docClass'>sol.dev.install.LoggerBase</a><div class='subclass '><strong>sol.dev.install.FileLogger</strong></div></div></div><h4>Files</h4><div class='dependency'><a href='source/lib_sol.dev.install.Installer.html#sol-dev-install-FileLogger' target='_blank'>lib_sol.dev.install.Installer.js</a></div></pre><div class='doc-contents'><p>File logger</p>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div id='cfg-requiredConfig' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n</div></div></div><div id='cfg-tempDir' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.dev.install.FileLogger'>sol.dev.install.FileLogger</span><br/><a href='source/lib_sol.dev.install.Installer.html#sol-dev-install-FileLogger-cfg-tempDir' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.dev.install.FileLogger-cfg-tempDir' class='name expandable'>tempDir</a> : java.io.File<span class=\"signature\"></span></div><div class='description'><div class='short'><p>Temp directory</p>\n</div><div class='long'><p>Temp directory</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>Logger for this class instance. ...</div><div class='long'><p>Logger for this class instance. This logger is created by <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a>.</p>\n\n<p>Please see <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a> class documentation for more information.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-finalize' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.dev.install.FileLogger'>sol.dev.install.FileLogger</span><br/><a href='source/lib_sol.dev.install.Installer.html#sol-dev-install-FileLogger-method-finalize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.dev.install.FileLogger-method-finalize' class='name expandable'>finalize</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Finalize the log file ...</div><div class='long'><p>Finalize the log file</p>\n<p>Overrides: <a href=\"#!/api/sol.dev.install.LoggerBase-method-finalize\" rel=\"sol.dev.install.LoggerBase-method-finalize\" class=\"docClass\">sol.dev.install.LoggerBase.finalize</a></p></div></div></div><div id='method-getCurrentTimeStamp' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.dev.install.LoggerBase' rel='sol.dev.install.LoggerBase' class='defined-in docClass'>sol.dev.install.LoggerBase</a><br/><a href='source/lib_sol.dev.install.Installer.html#sol-dev-install-LoggerBase-method-getCurrentTimeStamp' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.dev.install.LoggerBase-method-getCurrentTimeStamp' class='name expandable'>getCurrentTimeStamp</a>( <span class='pre'>format</span> ) : String<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Returns a time stamp of the current time ...</div><div class='long'><p>Returns a time stamp of the current time</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>format</span> : String<div class='sub-desc'><p>Format of the timestamp.</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-getLogFolderId' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.dev.install.LoggerBase' rel='sol.dev.install.LoggerBase' class='defined-in docClass'>sol.dev.install.LoggerBase</a><br/><a href='source/lib_sol.dev.install.Installer.html#sol-dev-install-LoggerBase-method-getLogFolderId' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.dev.install.LoggerBase-method-getLogFolderId' class='name expandable'>getLogFolderId</a>( <span class='pre'></span> ) : String<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Determinates the log folder ID ...</div><div class='long'><p>Determinates the log folder ID</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'><p>Log folder ID</p>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.dev.install.LoggerBase' rel='sol.dev.install.LoggerBase' class='defined-in docClass'>sol.dev.install.LoggerBase</a><br/><a href='source/lib_sol.dev.install.Installer.html#sol-dev-install-LoggerBase-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.dev.install.LoggerBase-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul><p>Overrides: <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a></p></div></div></div><div id='method-log' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.dev.install.FileLogger'>sol.dev.install.FileLogger</span><br/><a href='source/lib_sol.dev.install.Installer.html#sol-dev-install-FileLogger-method-log' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.dev.install.FileLogger-method-log' class='name expandable'>log</a>( <span class='pre'>message</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Writes a message into the log file ...</div><div class='long'><p>Writes a message into the log file</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>message</span> : Object<div class='sub-desc'>\n</div></li></ul><p>Overrides: <a href=\"#!/api/sol.dev.install.LoggerBase-method-log\" rel=\"sol.dev.install.LoggerBase-method-log\" class=\"docClass\">sol.dev.install.LoggerBase.log</a></p></div></div></div></div></div></div></div>","meta":{}});
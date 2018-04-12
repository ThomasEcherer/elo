Ext.data.JsonP.sol_common_SordTypeUtils({"tagname":"class","name":"sol.common.SordTypeUtils","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"uses":true,"members":true,"code_type":true,"singleton":true},"files":[{"filename":"lib_sol.common.SordTypeUtils.js","href":"lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils"}],"author":[{"tagname":"author","name":"MW, ELO Digital Office GmbH","email":null}],"version":["1.0"],"eloas":true,"eloix":true,"requires":["sol.common.FileUtils","sol.common.RepoUtils","sol.common.Template"],"aliases":{},"alternateClassNames":[],"extends":"sol.Base","mixins":[],"uses":[],"members":[{"name":"requiredConfig","tagname":"cfg","owner":"sol.Base","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"logger","tagname":"property","owner":"sol.Base","id":"property-logger","meta":{"protected":true}},{"name":"sordTypeIconConfigs","tagname":"property","owner":"sol.common.SordTypeUtils","id":"property-sordTypeIconConfigs","meta":{"private":true}},{"name":"sordTypeIconExtensions","tagname":"property","owner":"sol.common.SordTypeUtils","id":"property-sordTypeIconExtensions","meta":{"private":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"buildSordType","tagname":"method","owner":"sol.common.SordTypeUtils","id":"method-buildSordType","meta":{"private":true}},{"name":"createSordType","tagname":"method","owner":"sol.common.SordTypeUtils","id":"method-createSordType","meta":{}},{"name":"determinateSordTypeKind","tagname":"method","owner":"sol.common.SordTypeUtils","id":"method-determinateSordTypeKind","meta":{}},{"name":"exportSordType","tagname":"method","owner":"sol.common.SordTypeUtils","id":"method-exportSordType","meta":{}},{"name":"exportSordTypes","tagname":"method","owner":"sol.common.SordTypeUtils","id":"method-exportSordTypes","meta":{}},{"name":"getSordTypeId","tagname":"method","owner":"sol.common.SordTypeUtils","id":"method-getSordTypeId","meta":{}},{"name":"getSordTypes","tagname":"method","owner":"sol.common.SordTypeUtils","id":"method-getSordTypes","meta":{}},{"name":"initialize","tagname":"method","owner":"sol.Base","id":"method-initialize","meta":{"private":true}},{"name":"insertSordTypeIntoCache","tagname":"method","owner":"sol.common.SordTypeUtils","id":"method-insertSordTypeIntoCache","meta":{"private":true}},{"name":"readSordTypes","tagname":"method","owner":"sol.common.SordTypeUtils","id":"method-readSordTypes","meta":{"private":true}},{"name":"setSordType","tagname":"method","owner":"sol.common.SordTypeUtils","id":"method-setSordType","meta":{}},{"name":"sordTypeExists","tagname":"method","owner":"sol.common.SordTypeUtils","id":"method-sordTypeExists","meta":{}}],"code_type":"ext_define","singleton":true,"id":"class-sol.common.SordTypeUtils","classIcon":"icon-singleton","superclasses":["sol.Base"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><strong>sol.common.SordTypeUtils</strong></div></div><h4>Requires</h4><div class='dependency'><a href='#!/api/sol.common.FileUtils' rel='sol.common.FileUtils' class='docClass'>sol.common.FileUtils</a></div><div class='dependency'><a href='#!/api/sol.common.RepoUtils' rel='sol.common.RepoUtils' class='docClass'>sol.common.RepoUtils</a></div><div class='dependency'><a href='#!/api/sol.common.Template' rel='sol.common.Template' class='docClass'>sol.common.Template</a></div><h4>Files</h4><div class='dependency'><a href='source/lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils' target='_blank'>lib_sol.common.SordTypeUtils.js</a></div></pre><div class='doc-contents'><p>This class provides basic functionality for sord types.</p>\n      <p class='version-tag'>Version: <b>1.0</b></p>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div id='cfg-requiredConfig' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>Logger for this class instance. ...</div><div class='long'><p>Logger for this class instance. This logger is created by <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a>.</p>\n\n<p>Please see <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a> class documentation for more information.</p>\n</div></div></div><div id='property-sordTypeIconConfigs' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.SordTypeUtils'>sol.common.SordTypeUtils</span><br/><a href='source/lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils-property-sordTypeIconConfigs' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.SordTypeUtils-property-sordTypeIconConfigs' class='name expandable'>sordTypeIconConfigs</a> : Object<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div><div id='property-sordTypeIconExtensions' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.SordTypeUtils'>sol.common.SordTypeUtils</span><br/><a href='source/lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils-property-sordTypeIconExtensions' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.SordTypeUtils-property-sordTypeIconExtensions' class='name expandable'>sordTypeIconExtensions</a> : Array<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'> ...</div><div class='long'>\n<p>Defaults to: <code>[&quot;bmp&quot;, &quot;ico&quot;, &quot;jpg&quot;, &quot;png&quot;]</code></p></div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-buildSordType' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.SordTypeUtils'>sol.common.SordTypeUtils</span><br/><a href='source/lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils-method-buildSordType' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.SordTypeUtils-method-buildSordType' class='name expandable'>buildSordType</a>( <span class='pre'>id, name, iconFileData, disabledIconFileData, linkIconFileData, extensions</span> ) : de.elo.ix.client.SordType<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Build sord type ...</div><div class='long'><p>Build sord type</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>id</span> : String<div class='sub-desc'>\n</div></li><li><span class='pre'>name</span> : String<div class='sub-desc'>\n</div></li><li><span class='pre'>iconFileData</span> : de.elo.ix.client.FileData<div class='sub-desc'>\n</div></li><li><span class='pre'>disabledIconFileData</span> : de.elo.ix.client.FileData<div class='sub-desc'>\n</div></li><li><span class='pre'>linkIconFileData</span> : de.elo.ix.client.FileData<div class='sub-desc'>\n</div></li><li><span class='pre'>extensions</span> : Array<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>de.elo.ix.client.SordType</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-createSordType' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.SordTypeUtils'>sol.common.SordTypeUtils</span><br/><a href='source/lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils-method-createSordType' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.SordTypeUtils-method-createSordType' class='name expandable'>createSordType</a>( <span class='pre'>id, name, kind, iconFileDataArray, disabledIconFileDataArray, linkIconFileDataArray, extensions, force</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Create sord type ...</div><div class='long'><p>Create sord type</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>id</span> : String<div class='sub-desc'><p>ID</p>\n</div></li><li><span class='pre'>name</span> : String<div class='sub-desc'><p>Name</p>\n</div></li><li><span class='pre'>kind</span> : String<div class='sub-desc'><p>, e.g. \"FOLDER\", \"DOCUMENT\"</p>\n</div></li><li><span class='pre'>iconFileDataArray</span> : Array<div class='sub-desc'><p>Array of file data for icons</p>\n</div></li><li><span class='pre'>disabledIconFileDataArray</span> : Array<div class='sub-desc'><p>Array of file data for disabled icons</p>\n</div></li><li><span class='pre'>linkIconFileDataArray</span> : Array<div class='sub-desc'><p>Array of file data for link icons</p>\n</div></li><li><span class='pre'>extensions</span> : Array<div class='sub-desc'>\n</div></li><li><span class='pre'>force</span> : Array<div class='sub-desc'><p>Force</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'><p>If true the sord type was installed</p>\n</div></li></ul></div></div></div><div id='method-determinateSordTypeKind' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.SordTypeUtils'>sol.common.SordTypeUtils</span><br/><a href='source/lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils-method-determinateSordTypeKind' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.SordTypeUtils-method-determinateSordTypeKind' class='name expandable'>determinateSordTypeKind</a>( <span class='pre'>id</span> ) : undefined<span class=\"signature\"></span></div><div class='description'><div class='short'>Determinates the sord type kind (folder/document) of a sord type ...</div><div class='long'><p>Determinates the sord type kind (folder/document) of a sord type</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>id</span> : type<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>undefined</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-exportSordType' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.SordTypeUtils'>sol.common.SordTypeUtils</span><br/><a href='source/lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils-method-exportSordType' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.SordTypeUtils-method-exportSordType' class='name expandable'>exportSordType</a>( <span class='pre'>name, iconExtension, baseDirPath, exportConfig</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Export a sord types icons ...</div><div class='long'><p>Export a sord types icons</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>name</span> : String<div class='sub-desc'><p>Name of the sord type</p>\n</div></li><li><span class='pre'>iconExtension</span> : String<div class='sub-desc'><p>Icon extension</p>\n</div></li><li><span class='pre'>baseDirPath</span> : String<div class='sub-desc'><p>Path of the destination folder</p>\n</div></li><li><span class='pre'>exportConfig</span> : Boolean<div class='sub-desc'><p>the configuration to a JSON file</p>\n</div></li></ul></div></div></div><div id='method-exportSordTypes' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.SordTypeUtils'>sol.common.SordTypeUtils</span><br/><a href='source/lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils-method-exportSordTypes' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.SordTypeUtils-method-exportSordTypes' class='name expandable'>exportSordTypes</a>( <span class='pre'>names, dirPath</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Export a sord type to the file system ...</div><div class='long'><p>Export a sord type to the file system</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>names</span> : Array<div class='sub-desc'><p>Names of the sord type</p>\n</div></li><li><span class='pre'>dirPath</span> : String<div class='sub-desc'><p>Path of the destination folder</p>\n</div></li></ul></div></div></div><div id='method-getSordTypeId' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.SordTypeUtils'>sol.common.SordTypeUtils</span><br/><a href='source/lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils-method-getSordTypeId' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.SordTypeUtils-method-getSordTypeId' class='name expandable'>getSordTypeId</a>( <span class='pre'>name</span> ) : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns the sord type ID ...</div><div class='long'><p>Returns the sord type ID</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>name</span> : String<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'><p>Sord type ID</p>\n</div></li></ul></div></div></div><div id='method-getSordTypes' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.SordTypeUtils'>sol.common.SordTypeUtils</span><br/><a href='source/lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils-method-getSordTypes' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.SordTypeUtils-method-getSordTypes' class='name expandable'>getSordTypes</a>( <span class='pre'></span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns the sord types ...</div><div class='long'><p>Returns the sord types</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul></div></div></div><div id='method-insertSordTypeIntoCache' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.SordTypeUtils'>sol.common.SordTypeUtils</span><br/><a href='source/lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils-method-insertSordTypeIntoCache' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.SordTypeUtils-method-insertSordTypeIntoCache' class='name expandable'>insertSordTypeIntoCache</a>( <span class='pre'>id, name</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Inserts a sord type into the local sord types cache ...</div><div class='long'><p>Inserts a sord type into the local sord types cache</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>id</span> : String<div class='sub-desc'>\n</div></li><li><span class='pre'>name</span> : String<div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-readSordTypes' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.SordTypeUtils'>sol.common.SordTypeUtils</span><br/><a href='source/lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils-method-readSordTypes' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.SordTypeUtils-method-readSordTypes' class='name expandable'>readSordTypes</a>( <span class='pre'></span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Reads the sord types ...</div><div class='long'><p>Reads the sord types</p>\n</div></div></div><div id='method-setSordType' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.SordTypeUtils'>sol.common.SordTypeUtils</span><br/><a href='source/lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils-method-setSordType' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.SordTypeUtils-method-setSordType' class='name expandable'>setSordType</a>( <span class='pre'>objId, sordTypeName</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Set sord type ...</div><div class='long'><p>Set sord type</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>objId</span> : String<div class='sub-desc'><p>Object ID</p>\n</div></li><li><span class='pre'>sordTypeName</span> : String<div class='sub-desc'><p>Sord type name</p>\n</div></li></ul></div></div></div><div id='method-sordTypeExists' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.SordTypeUtils'>sol.common.SordTypeUtils</span><br/><a href='source/lib_sol.common.SordTypeUtils.html#sol-common-SordTypeUtils-method-sordTypeExists' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.SordTypeUtils-method-sordTypeExists' class='name expandable'>sordTypeExists</a>( <span class='pre'>name</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Checks wether a sord type exists ...</div><div class='long'><p>Checks wether a sord type exists</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>name</span> : String<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div></div></div></div></div>","meta":{"eloas":true,"eloix":true,"singleton":true}});
Ext.data.JsonP.sol_common_Cache({"tagname":"class","name":"sol.common.Cache","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"requires":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"lib_sol.common.Cache.js","href":"lib_sol.common.Cache.html#sol-common-Cache"}],"author":[{"tagname":"author","name":"PZ, ELO Digital Office GmbH","email":null}],"version":["1.03.000"],"eloix":true,"eloas":true,"elojc":true,"aliases":{},"alternateClassNames":[],"extends":"sol.Base","mixins":[],"requires":[],"uses":[],"members":[{"name":"requiredConfig","tagname":"cfg","owner":"sol.Base","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"logger","tagname":"property","owner":"sol.Base","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"clear","tagname":"method","owner":"sol.common.Cache","id":"method-clear","meta":{}},{"name":"containsKey","tagname":"method","owner":"sol.common.Cache","id":"method-containsKey","meta":{}},{"name":"elements","tagname":"method","owner":"sol.common.Cache","id":"method-elements","meta":{}},{"name":"get","tagname":"method","owner":"sol.common.Cache","id":"method-get","meta":{}},{"name":"initialize","tagname":"method","owner":"sol.common.Cache","id":"method-initialize","meta":{"private":true}},{"name":"isEmpty","tagname":"method","owner":"sol.common.Cache","id":"method-isEmpty","meta":{}},{"name":"keys","tagname":"method","owner":"sol.common.Cache","id":"method-keys","meta":{}},{"name":"put","tagname":"method","owner":"sol.common.Cache","id":"method-put","meta":{}},{"name":"putAll","tagname":"method","owner":"sol.common.Cache","id":"method-putAll","meta":{}},{"name":"remove","tagname":"method","owner":"sol.common.Cache","id":"method-remove","meta":{}},{"name":"size","tagname":"method","owner":"sol.common.Cache","id":"method-size","meta":{}},{"name":"values","tagname":"method","owner":"sol.common.Cache","id":"method-values","meta":{}}],"code_type":"ext_define","id":"class-sol.common.Cache","short_doc":"A threadsafe cache implementation. ...","classIcon":"icon-class","superclasses":["sol.Base"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><strong>sol.common.Cache</strong></div></div><h4>Files</h4><div class='dependency'><a href='source/lib_sol.common.Cache.html#sol-common-Cache' target='_blank'>lib_sol.common.Cache.js</a></div></pre><div class='doc-contents'><p>A threadsafe cache implementation.</p>\n\n<p>The cache holds key-value pairs.\nKeys should be strings, whereas values could be arbitary objects.</p>\n      <p class='version-tag'>Version: <b>1.03.000</b></p>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div id='cfg-requiredConfig' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>Logger for this class instance. ...</div><div class='long'><p>Logger for this class instance. This logger is created by <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a>.</p>\n\n<p>Please see <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a> class documentation for more information.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-clear' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Cache'>sol.common.Cache</span><br/><a href='source/lib_sol.common.Cache.html#sol-common-Cache-method-clear' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Cache-method-clear' class='name expandable'>clear</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Removes all of the mappings from the cache. ...</div><div class='long'><p>Removes all of the mappings from the cache.</p>\n</div></div></div><div id='method-containsKey' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Cache'>sol.common.Cache</span><br/><a href='source/lib_sol.common.Cache.html#sol-common-Cache-method-containsKey' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Cache-method-containsKey' class='name expandable'>containsKey</a>( <span class='pre'>key</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Tests if the specified object is a key in the cache. ...</div><div class='long'><p>Tests if the specified object is a key in the cache.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>key</span> : String<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-elements' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Cache'>sol.common.Cache</span><br/><a href='source/lib_sol.common.Cache.html#sol-common-Cache-method-elements' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Cache-method-elements' class='name expandable'>elements</a>( <span class='pre'></span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns an enumeration of the values in the cache. ...</div><div class='long'><p>Returns an enumeration of the values in the cache.</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>An <code>java.util.Enumeration</code> of all values</p>\n</div></li></ul></div></div></div><div id='method-get' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Cache'>sol.common.Cache</span><br/><a href='source/lib_sol.common.Cache.html#sol-common-Cache-method-get' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Cache-method-get' class='name expandable'>get</a>( <span class='pre'>key</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns the value for the specified key from the cache, or null if the chache contains no mapping for the key. ...</div><div class='long'><p>Returns the value for the specified key from the cache, or null if the chache contains no mapping for the key.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>key</span> : String<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Cache'>sol.common.Cache</span><br/><a href='source/lib_sol.common.Cache.html#sol-common-Cache-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Cache-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul><p>Overrides: <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a></p></div></div></div><div id='method-isEmpty' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Cache'>sol.common.Cache</span><br/><a href='source/lib_sol.common.Cache.html#sol-common-Cache-method-isEmpty' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Cache-method-isEmpty' class='name expandable'>isEmpty</a>( <span class='pre'></span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns true if the chache contains no key-value pairs. ...</div><div class='long'><p>Returns <code>true</code> if the chache contains no key-value pairs.</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-keys' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Cache'>sol.common.Cache</span><br/><a href='source/lib_sol.common.Cache.html#sol-common-Cache-method-keys' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Cache-method-keys' class='name expandable'>keys</a>( <span class='pre'></span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns an enumeration of all keys in the cache. ...</div><div class='long'><p>Returns an enumeration of all keys in the cache.</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>An <code>java.util.Enumeration</code> of all keys</p>\n</div></li></ul></div></div></div><div id='method-put' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Cache'>sol.common.Cache</span><br/><a href='source/lib_sol.common.Cache.html#sol-common-Cache-method-put' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Cache-method-put' class='name expandable'>put</a>( <span class='pre'>key, value</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Inserts the specified key-value pair into the cache. ...</div><div class='long'><p>Inserts the specified key-value pair into the cache.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>key</span> : String<div class='sub-desc'>\n</div></li><li><span class='pre'>value</span> : Object<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>The previous value associated with the key, or null if there was no mapping before</p>\n</div></li></ul></div></div></div><div id='method-putAll' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Cache'>sol.common.Cache</span><br/><a href='source/lib_sol.common.Cache.html#sol-common-Cache-method-putAll' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Cache-method-putAll' class='name expandable'>putAll</a>( <span class='pre'>data</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Inserts all key-value pairs specified by an object into the cache. ...</div><div class='long'><p>Inserts all key-value pairs specified by an object into the cache. Existing mappings will be replaced.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>data</span> : Object<div class='sub-desc'><p>Property names will be used as keys and the associated values as values.</p>\n</div></li></ul></div></div></div><div id='method-remove' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Cache'>sol.common.Cache</span><br/><a href='source/lib_sol.common.Cache.html#sol-common-Cache-method-remove' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Cache-method-remove' class='name expandable'>remove</a>( <span class='pre'>key</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Removes the key (and its corresponding value) from the cache. ...</div><div class='long'><p>Removes the key (and its corresponding value) from the cache.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>key</span> : String<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>The previous value associated with the key, or null if there was no value for the key</p>\n</div></li></ul></div></div></div><div id='method-size' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Cache'>sol.common.Cache</span><br/><a href='source/lib_sol.common.Cache.html#sol-common-Cache-method-size' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Cache-method-size' class='name expandable'>size</a>( <span class='pre'></span> ) : Number<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns the number of key-value pairs in the cache. ...</div><div class='long'><p>Returns the number of key-value pairs in the cache.</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>Number</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-values' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.Cache'>sol.common.Cache</span><br/><a href='source/lib_sol.common.Cache.html#sol-common-Cache-method-values' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.Cache-method-values' class='name expandable'>values</a>( <span class='pre'></span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns a collection view of the values contained in the cache. ...</div><div class='long'><p>Returns a collection view of the values contained in the cache.</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>An <code>java.util.Collection</code> of all values</p>\n</div></li></ul></div></div></div></div></div></div></div>","meta":{"eloas":true,"eloix":true,"elojc":true}});
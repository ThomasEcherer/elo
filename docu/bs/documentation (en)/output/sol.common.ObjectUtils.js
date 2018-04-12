Ext.data.JsonP.sol_common_ObjectUtils({"tagname":"class","name":"sol.common.ObjectUtils","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"requires":true,"uses":true,"members":true,"code_type":true,"singleton":true},"files":[{"filename":"lib_sol.common.ObjectUtils.js","href":"lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils"}],"author":[{"tagname":"author","name":"PZ, ELO Digital Office GmbH","email":null}],"version":["1.1"],"eloall":true,"aliases":{},"alternateClassNames":[],"extends":"sol.Base","mixins":[],"requires":[],"uses":[],"members":[{"name":"requiredConfig","tagname":"cfg","owner":"sol.Base","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"_toStringFunction","tagname":"property","owner":"sol.common.ObjectUtils","id":"property-_toStringFunction","meta":{"private":true}},{"name":"logger","tagname":"property","owner":"sol.Base","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"arrayFind","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-arrayFind","meta":{}},{"name":"clone","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-clone","meta":{}},{"name":"findObjInArray","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-findObjInArray","meta":{"private":true}},{"name":"forEach","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-forEach","meta":{}},{"name":"getObjectFromArray","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-getObjectFromArray","meta":{}},{"name":"getProp","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-getProp","meta":{}},{"name":"getPropsOfObj","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-getPropsOfObj","meta":{}},{"name":"getValues","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-getValues","meta":{}},{"name":"initialize","tagname":"method","owner":"sol.Base","id":"method-initialize","meta":{"private":true}},{"name":"isArray","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-isArray","meta":{}},{"name":"isBlank","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-isBlank","meta":{}},{"name":"isDate","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-isDate","meta":{}},{"name":"isEmpty","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-isEmpty","meta":{}},{"name":"isFunction","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-isFunction","meta":{}},{"name":"isJavaObject","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-isJavaObject","meta":{}},{"name":"isNumber","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-isNumber","meta":{}},{"name":"isObject","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-isObject","meta":{}},{"name":"isRegExp","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-isRegExp","meta":{}},{"name":"isString","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-isString","meta":{}},{"name":"map","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-map","meta":{}},{"name":"merge","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-merge","meta":{}},{"name":"mergeObjects","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-mergeObjects","meta":{}},{"name":"type","tagname":"method","owner":"sol.common.ObjectUtils","id":"method-type","meta":{}}],"code_type":"ext_define","singleton":true,"id":"class-sol.common.ObjectUtils","classIcon":"icon-singleton","superclasses":["sol.Base"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><strong>sol.common.ObjectUtils</strong></div></div><h4>Files</h4><div class='dependency'><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils' target='_blank'>lib_sol.common.ObjectUtils.js</a></div></pre><div class='doc-contents'><p>This class contains convenience methods for working with java script basic types and objects.</p>\n      <p class='version-tag'>Version: <b>1.1</b></p>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div id='cfg-requiredConfig' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-_toStringFunction' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-property-_toStringFunction' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-property-_toStringFunction' class='name expandable'>_toStringFunction</a> : Function<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'><p>Reference to Object.prototype.toString</p>\n</div><div class='long'><p>Reference to Object.prototype.toString</p>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>Logger for this class instance. ...</div><div class='long'><p>Logger for this class instance. This logger is created by <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a>.</p>\n\n<p>Please see <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a> class documentation for more information.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-arrayFind' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-arrayFind' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-arrayFind' class='name expandable'>arrayFind</a>( <span class='pre'>a, val, customProp, customCallback</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns the first object of an array whose property \"id\" has the value val. ...</div><div class='long'><p>Returns the first object of an array whose property \"id\" has the value val.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>a</span> : Array<div class='sub-desc'><p>array containing the objects</p>\n</div></li><li><span class='pre'>val</span> : Any<div class='sub-desc'><p>value to search for</p>\n</div></li><li><span class='pre'>customProp</span> : String<div class='sub-desc'><p>custom property name, if the property is not \"id\"</p>\n</div></li><li><span class='pre'>customCallback</span> : Function<div class='sub-desc'><p>custom callback for Array.find function</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>found object or undefined. false if a is not an Array\nRhino 1.7R5 does not implement Array.prototype.find. arrayFind takes is place in this case</p>\n</div></li></ul></div></div></div><div id='method-clone' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-clone' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-clone' class='name expandable'>clone</a>( <span class='pre'>o</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Clones an object. ...</div><div class='long'><p>Clones an object.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>o</span> : Object<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-findObjInArray' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-findObjInArray' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-findObjInArray' class='name expandable'>findObjInArray</a>( <span class='pre'>a, val, customProp, customCallback</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'> ...</div><div class='long'>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>a</span> : Object<div class='sub-desc'></div></li><li><span class='pre'>val</span> : Object<div class='sub-desc'></div></li><li><span class='pre'>customProp</span> : Object<div class='sub-desc'></div></li><li><span class='pre'>customCallback</span> : Object<div class='sub-desc'></div></li></ul></div></div></div><div id='method-forEach' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-forEach' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-forEach' class='name expandable'>forEach</a>( <span class='pre'>arr, callback, context</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Function ´forEach´ that works in Rhino and Nashorn ...</div><div class='long'><p>Function ´forEach´ that works in Rhino and Nashorn</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>arr</span> : Array<div class='sub-desc'><p>Array</p>\n</div></li><li><span class='pre'>callback</span> : Function<div class='sub-desc'><p>Callback</p>\n</div></li><li><span class='pre'>context</span> : Object<div class='sub-desc'><p>Context</p>\n</div></li></ul></div></div></div><div id='method-getObjectFromArray' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-getObjectFromArray' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-getObjectFromArray' class='name expandable'>getObjectFromArray</a>( <span class='pre'>arr, keyPropName</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Converts an array of objects to an object ...</div><div class='long'><p>Converts an array of objects to an object</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>arr</span> : Array<div class='sub-desc'>\n</div></li><li><span class='pre'>keyPropName</span> : keyPropName<div class='sub-desc'><p>name of the property key for the new key</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-getProp' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-getProp' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-getProp' class='name expandable'>getProp</a>( <span class='pre'>object, path, customPropName</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>gets a property from an object by traversing the passed path. ...</div><div class='long'><p>gets a property from an <code>object</code> by traversing the passed <code>path</code>.\nif the property is inside an object which is inside an array, the array must contain\na property called <code>id</code> containing the corresponding part of the <code>path</code>.\ne.g. y = { x: [ {id: \"test\", myniceprop: 42} ] }\nif you want to retrieve \"myniceprop\", you would call getProp(y, \"x.test.myniceprop\")\nnote: this is also a better way to get a property from an object with probably uninitialized preceding properties\noptional: if passed a <code>customPropName</code>, getProp will use the name as the array-object-property name\ne.g. y = { x: [ {<strong>ID: \"test\", myniceprop: 42} ] }    -->  getProp(y, \"x.test.myniceprop\", \"</strong>ID\")</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>object</span> : Object<div class='sub-desc'></div></li><li><span class='pre'>path</span> : Object<div class='sub-desc'></div></li><li><span class='pre'>customPropName</span> : Object<div class='sub-desc'></div></li></ul></div></div></div><div id='method-getPropsOfObj' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-getPropsOfObj' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-getPropsOfObj' class='name expandable'>getPropsOfObj</a>( <span class='pre'>o, include, exclude</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns an object containing only specific properties of the input object. ...</div><div class='long'><p>Returns an object containing only specific properties of the input object.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>o</span> : Object<div class='sub-desc'><p>input object</p>\n</div></li><li><span class='pre'>include</span> : Array<div class='sub-desc'><p>array containing all properties to include as strings. Empty array includes all properties.</p>\n</div></li><li><span class='pre'>exclude</span> : Array<div class='sub-desc'><p>array containing all properties to exclude. Empty array means exclude nothing from include. If values are defined in include and exclude, they are excluded.</p>\n</div></li></ul></div></div></div><div id='method-getValues' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-getValues' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-getValues' class='name expandable'>getValues</a>( <span class='pre'>o</span> ) : Array<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns the values of an Object ...</div><div class='long'><p>Returns the values of an Object</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>o</span> : Object<div class='sub-desc'><p>Object</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Array</span><div class='sub-desc'><p>Array</p>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul></div></div></div><div id='method-isArray' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-isArray' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-isArray' class='name expandable'>isArray</a>( <span class='pre'>o</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Checks, if an object is a JavaScript Array ...</div><div class='long'><p>Checks, if an object is a JavaScript Array</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>o</span> : Object<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-isBlank' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-isBlank' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-isBlank' class='name expandable'>isBlank</a>( <span class='pre'>o</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Checks, if an object is blank. ...</div><div class='long'><p>Checks, if an object is blank. Works for Array (only contains ) and String, all other types always return <code>false</code>.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>o</span> : Object<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-isDate' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-isDate' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-isDate' class='name expandable'>isDate</a>( <span class='pre'>o</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Checks, if an object is a JavaScript Date ...</div><div class='long'><p>Checks, if an object is a JavaScript Date</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>o</span> : Object<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-isEmpty' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-isEmpty' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-isEmpty' class='name expandable'>isEmpty</a>( <span class='pre'>o</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Checks, if an Object is empty. ...</div><div class='long'><p>Checks, if an Object is empty.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>o</span> : Object<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-isFunction' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-isFunction' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-isFunction' class='name expandable'>isFunction</a>( <span class='pre'>o</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Checks, if an object is a JavaScript Function ...</div><div class='long'><p>Checks, if an object is a JavaScript Function</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>o</span> : Object<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-isJavaObject' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-isJavaObject' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-isJavaObject' class='name expandable'>isJavaObject</a>( <span class='pre'>o</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Checks, if an object is a Java (Rhino) object ...</div><div class='long'><p>Checks, if an object is a Java (Rhino) object</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>o</span> : Object<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-isNumber' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-isNumber' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-isNumber' class='name expandable'>isNumber</a>( <span class='pre'>o</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Checks, if an object is a JavaScript Number ...</div><div class='long'><p>Checks, if an object is a JavaScript Number</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>o</span> : Object<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-isObject' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-isObject' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-isObject' class='name expandable'>isObject</a>( <span class='pre'>o</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Checks, if an object is a JavaScript object ...</div><div class='long'><p>Checks, if an object is a JavaScript object</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>o</span> : Object<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-isRegExp' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-isRegExp' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-isRegExp' class='name expandable'>isRegExp</a>( <span class='pre'>o</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Checks, if an object is a JavaScript regular expression ...</div><div class='long'><p>Checks, if an object is a JavaScript regular expression</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>o</span> : Object<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-isString' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-isString' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-isString' class='name expandable'>isString</a>( <span class='pre'>o</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Checks, if an object is a JavaScript String ...</div><div class='long'><p>Checks, if an object is a JavaScript String</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>o</span> : Object<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-map' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-map' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-map' class='name expandable'>map</a>( <span class='pre'>arr, callback, context</span> ) : Array<span class=\"signature\"></span></div><div class='description'><div class='short'>Function ´map´ that works in Rhino and Nashorn ...</div><div class='long'><p>Function ´map´ that works in Rhino and Nashorn</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>arr</span> : Array<div class='sub-desc'><p>Array</p>\n</div></li><li><span class='pre'>callback</span> : Function<div class='sub-desc'><p>Callback</p>\n</div></li><li><span class='pre'>context</span> : Object<div class='sub-desc'><p>Context</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Array</span><div class='sub-desc'><p>Array</p>\n</div></li></ul></div></div></div><div id='method-merge' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-merge' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-merge' class='name expandable'>merge</a>( <span class='pre'>custom, base, [log], [path], [assignCallback], [recursionCheck]</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Merges all properties in base into custom. ...</div><div class='long'><p>Merges all properties in base into custom. Existing properties in custom will be preserved, but only\nif they match the type of the property in base. Otherwise the property of base will be used\nand a log will be written to array parameter log.</p>\n\n<p>This function does not support functions. It does support Array, Object and Date and creates a clone from it.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>custom</span> : Object<div class='sub-desc'><p>The object containing all merged data (object will be altered)</p>\n</div></li><li><span class='pre'>base</span> : Object<div class='sub-desc'><p>The object from which will be copied to the <code>custom</code> object</p>\n</div></li><li><span class='pre'>log</span> : String[] (optional)<div class='sub-desc'><p>Logging messages will be pushed to this array</p>\n<p>Defaults to: <code>[]</code></p></div></li><li><span class='pre'>path</span> : String (optional)<div class='sub-desc'><p>Startpath/objectname, used for logging</p>\n<p>Defaults to: <code>&#39;&#39;</code></p></div></li><li><span class='pre'>assignCallback</span> : Function (optional)<div class='sub-desc'><p>Will be called for every property assignment (if set, this function has to take care of the assignment itself)</p>\n</div></li><li><span class='pre'>recursionCheck</span> : Function (optional)<div class='sub-desc'><p>This function is called for every property and decides if the property has to be merged recursively (returns <code>true</code>) or not (returns <code>false</code>)</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>The merged object (<code>custom</code>)</p>\n</div></li></ul></div></div></div><div id='method-mergeObjects' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-mergeObjects' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-mergeObjects' class='name expandable'>mergeObjects</a>( <span class='pre'>base, [mergeList], [preserveCustom], [path], [assignCallback], [recursionCheck]</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Merges a list of objects. ...</div><div class='long'><p>Merges a list of objects.</p>\n\n<p>The <code>base</code> object is the first object in the merging chain.\nProperties from the <code>mergeList</code> objects will be added to the base object.\nIf there is already a property in the base object, it will only be overwritten, if the types match.</p>\n\n<pre><code>var o1 = { a: \"hello\", b: \"world\" };\nvar o2 = { b: \"developer\", c: \"foobar\" };\nvar merged = sol.common.ObjectUtils.mergeObject(o1, [o2]);  // merged =&gt; { a: \"hello\", b: \"developer\", c: \"foobar\" }\n</code></pre>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>base</span> : Object<div class='sub-desc'>\n</div></li><li><span class='pre'>mergeList</span> : Object[] (optional)<div class='sub-desc'>\n</div></li><li><span class='pre'>preserveCustom</span> : Boolean (optional)<div class='sub-desc'><p>If <code>true</code>, all objects from <code>mergeList</code> will be cloned. Otherwise the merge process will work directly on the objects and may alter them</p>\n<p>Defaults to: <code>false</code></p></div></li><li><span class='pre'>path</span> : String (optional)<div class='sub-desc'><p>Startpath/objectname, used for logging</p>\n</div></li><li><span class='pre'>assignCallback</span> : Function (optional)<div class='sub-desc'><p>Will be called for every property assignment (if set, this function has to take care of the assignment itself)</p>\n</div></li><li><span class='pre'>recursionCheck</span> : Function (optional)<div class='sub-desc'><p>This function is called for every property and decides if the property has to be merged recursively (returns <code>true</code>) or not (returns <code>false</code>)</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>The merged object</p>\n</div></li></ul></div></div></div><div id='method-type' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.ObjectUtils'>sol.common.ObjectUtils</span><br/><a href='source/lib_sol.common.ObjectUtils.html#sol-common-ObjectUtils-method-type' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.ObjectUtils-method-type' class='name expandable'>type</a>( <span class='pre'>val, should</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>returns a variables real type. ...</div><div class='long'><p>returns a variables real type. (typeof + null, nan, array, date, javaobject, regexp,...)\njavastrings are reported as a normal string. Best practice: Always String() values this function reports as \"string\"</p>\n\n<p>e.g. type(123, \"number\") => true\n     type([]) => \"array\"</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>val</span> : Object<div class='sub-desc'><p>the value to typecheck</p>\n</div></li><li><span class='pre'>should</span> : Object<div class='sub-desc'><p>the typename which should match</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>returns Boolean if <code>should</code> is defined (true if determined type equals <code>should</code>, false if not). otherwise returns the determined type</p>\n</div></li></ul></div></div></div></div></div></div></div>","meta":{"eloall":true,"singleton":true}});
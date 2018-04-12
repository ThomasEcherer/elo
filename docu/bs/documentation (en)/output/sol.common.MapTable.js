Ext.data.JsonP.sol_common_MapTable({"tagname":"class","name":"sol.common.MapTable","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"requires":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"lib_sol.common.Map.js","href":"lib_sol.common.Map.html#sol-common-MapTable"}],"author":[{"tagname":"author","name":"MW, ELO Digital Office GmbH","email":null}],"version":["1.1"],"eloix":true,"eloas":true,"elojc":true,"aliases":{},"alternateClassNames":[],"extends":"sol.Base","mixins":[],"requires":[],"uses":[],"members":[{"name":"columnNames","tagname":"cfg","owner":"sol.common.MapTable","id":"cfg-columnNames","meta":{"required":true}},{"name":"endOfTableIndicatorColumnName","tagname":"cfg","owner":"sol.common.MapTable","id":"cfg-endOfTableIndicatorColumnName","meta":{}},{"name":"initEmpty","tagname":"cfg","owner":"sol.common.MapTable","id":"cfg-initEmpty","meta":{}},{"name":"map","tagname":"cfg","owner":"sol.common.MapTable","id":"cfg-map","meta":{"required":true}},{"name":"read","tagname":"cfg","owner":"sol.common.MapTable","id":"cfg-read","meta":{}},{"name":"requiredConfig","tagname":"cfg","owner":"sol.Base","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"reset","tagname":"cfg","owner":"sol.common.MapTable","id":"cfg-reset","meta":{}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"logger","tagname":"property","owner":"sol.Base","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"appendRow","tagname":"method","owner":"sol.common.MapTable","id":"method-appendRow","meta":{}},{"name":"checkState","tagname":"method","owner":"sol.common.MapTable","id":"method-checkState","meta":{}},{"name":"getDisplayIndex","tagname":"method","owner":"sol.common.MapTable","id":"method-getDisplayIndex","meta":{}},{"name":"getLength","tagname":"method","owner":"sol.common.MapTable","id":"method-getLength","meta":{}},{"name":"getNumValue","tagname":"method","owner":"sol.common.MapTable","id":"method-getNumValue","meta":{}},{"name":"getValue","tagname":"method","owner":"sol.common.MapTable","id":"method-getValue","meta":{}},{"name":"hasNextRow","tagname":"method","owner":"sol.common.MapTable","id":"method-hasNextRow","meta":{}},{"name":"initialize","tagname":"method","owner":"sol.Base","id":"method-initialize","meta":{"private":true}},{"name":"insertRow","tagname":"method","owner":"sol.common.MapTable","id":"method-insertRow","meta":{}},{"name":"nextRow","tagname":"method","owner":"sol.common.MapTable","id":"method-nextRow","meta":{}},{"name":"removeRow","tagname":"method","owner":"sol.common.MapTable","id":"method-removeRow","meta":{}},{"name":"reset","tagname":"method","owner":"sol.common.MapTable","id":"method-reset","meta":{}},{"name":"setNumValue","tagname":"method","owner":"sol.common.MapTable","id":"method-setNumValue","meta":{}},{"name":"setValue","tagname":"method","owner":"sol.common.MapTable","id":"method-setValue","meta":{}},{"name":"shift","tagname":"method","owner":"sol.common.MapTable","id":"method-shift","meta":{}},{"name":"write","tagname":"method","owner":"sol.common.MapTable","id":"method-write","meta":{}}],"code_type":"ext_define","id":"class-sol.common.MapTable","short_doc":"Represents map data as table\n\nvar sordMap = sol.create(\"sol.common.SordMap\", { objId: objId });\nvar sordMapTable = so...","classIcon":"icon-class","superclasses":["sol.Base"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><strong>sol.common.MapTable</strong></div></div><h4>Files</h4><div class='dependency'><a href='source/lib_sol.common.Map.html#sol-common-MapTable' target='_blank'>lib_sol.common.Map.js</a></div></pre><div class='doc-contents'><p>Represents map data as table</p>\n\n<pre><code>var sordMap = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(\"<a href=\"#!/api/sol.common.SordMap\" rel=\"sol.common.SordMap\" class=\"docClass\">sol.common.SordMap</a>\", { objId: objId });\nvar sordMapTable = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(\"<a href=\"#!/api/sol.common.MapTable\" rel=\"sol.common.MapTable\" class=\"docClass\">sol.common.MapTable</a>\", { map: sordMap, columnNames: [\"INVOICE_TAX_NET_AMOUNT\", \"INVOICE_TAX_AMOUNT\", \"INVOICE_TAX_RATE\"] });\nif (sordMapTable.hasNextRow()) {\n  sordMapTable.nextRow();\n  var value = sordMapTable.getNumValue(\"INVOICE_TAX_RATE\");\n  if (value == 0) {\n    sordMapTable.removeRow();\n  }\n}\nsordMapTable.write();\n</code></pre>\n      <p class='version-tag'>Version: <b>1.1</b></p>\n</div><div class='members'><div class='members-section'><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Required config options</h3><div id='cfg-columnNames' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-cfg-columnNames' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-cfg-columnNames' class='name expandable'>columnNames</a> : Array<span class=\"signature\"><span class='required' >required</span></span></div><div class='description'><div class='short'><p>Column names</p>\n</div><div class='long'><p>Column names</p>\n</div></div></div><div id='cfg-map' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-cfg-map' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-cfg-map' class='name expandable'>map</a> : <a href=\"#!/api/sol.common.Map\" rel=\"sol.common.Map\" class=\"docClass\">sol.common.Map</a><span class=\"signature\"><span class='required' >required</span></span></div><div class='description'><div class='short'><p>Map object</p>\n</div><div class='long'><p>Map object</p>\n</div></div></div></div><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Optional config options</h3><div id='cfg-endOfTableIndicatorColumnName' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-cfg-endOfTableIndicatorColumnName' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-cfg-endOfTableIndicatorColumnName' class='name expandable'>endOfTableIndicatorColumnName</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'><p>(optional)\nEnd of table indicator column name</p>\n</div><div class='long'><p>(optional)\nEnd of table indicator column name</p>\n</div></div></div><div id='cfg-initEmpty' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-cfg-initEmpty' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-cfg-initEmpty' class='name expandable'>initEmpty</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'><p>(optional)\nProvides an empty table</p>\n</div><div class='long'><p>(optional)\nProvides an empty table</p>\n</div></div></div><div id='cfg-read' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-cfg-read' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-cfg-read' class='name expandable'>read</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'>(optional)\nRead the map values ...</div><div class='long'><p>(optional)\nRead the map values</p>\n<p>Defaults to: <code>true</code></p></div></div></div><div id='cfg-requiredConfig' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n</div></div></div><div id='cfg-reset' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-cfg-reset' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-cfg-reset' class='name expandable'>reset</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'>(optional)\nReset the table iterator ...</div><div class='long'><p>(optional)\nReset the table iterator</p>\n<p>Defaults to: <code>true</code></p></div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-logger' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>Logger for this class instance. ...</div><div class='long'><p>Logger for this class instance. This logger is created by <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a>.</p>\n\n<p>Please see <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a> class documentation for more information.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-appendRow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-appendRow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-appendRow' class='name expandable'>appendRow</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Appends a row at the end of the table ...</div><div class='long'><p>Appends a row at the end of the table</p>\n</div></div></div><div id='method-checkState' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-checkState' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-checkState' class='name expandable'>checkState</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Checks the current row ...</div><div class='long'><p>Checks the current row</p>\n</div></div></div><div id='method-getDisplayIndex' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-getDisplayIndex' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-getDisplayIndex' class='name expandable'>getDisplayIndex</a>( <span class='pre'></span> ) : Number<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns the index number ...</div><div class='long'><p>Returns the index number</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>Number</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-getLength' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-getLength' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-getLength' class='name expandable'>getLength</a>( <span class='pre'></span> ) : Number<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns the table length ...</div><div class='long'><p>Returns the table length</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>Number</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-getNumValue' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-getNumValue' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-getNumValue' class='name expandable'>getNumValue</a>( <span class='pre'>columnName</span> ) : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns a number value ...</div><div class='long'><p>Returns a number value</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>columnName</span> : String<div class='sub-desc'><p>Column name</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-getValue' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-getValue' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-getValue' class='name expandable'>getValue</a>( <span class='pre'>columnName</span> ) : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns a value ...</div><div class='long'><p>Returns a value</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>columnName</span> : String<div class='sub-desc'><p>Column name</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-hasNextRow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-hasNextRow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-hasNextRow' class='name expandable'>hasNextRow</a>( <span class='pre'></span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>True if the table has a next row ...</div><div class='long'><p>True if the table has a next row</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul></div></div></div><div id='method-insertRow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-insertRow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-insertRow' class='name expandable'>insertRow</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Inserts a row after the current row ...</div><div class='long'><p>Inserts a row after the current row</p>\n</div></div></div><div id='method-nextRow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-nextRow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-nextRow' class='name expandable'>nextRow</a>( <span class='pre'></span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Moves the row pointer to the next row ...</div><div class='long'><p>Moves the row pointer to the next row</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-removeRow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-removeRow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-removeRow' class='name expandable'>removeRow</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Deletes the current row ...</div><div class='long'><p>Deletes the current row</p>\n</div></div></div><div id='method-reset' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-reset' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-reset' class='name expandable'>reset</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Resets the iterator ...</div><div class='long'><p>Resets the iterator</p>\n</div></div></div><div id='method-setNumValue' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-setNumValue' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-setNumValue' class='name expandable'>setNumValue</a>( <span class='pre'>columnName, value</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Sets a number value ...</div><div class='long'><p>Sets a number value</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>columnName</span> : String<div class='sub-desc'><p>Column name</p>\n</div></li><li><span class='pre'>value</span> : String<div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-setValue' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-setValue' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-setValue' class='name expandable'>setValue</a>( <span class='pre'>columnName, value</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Sets a value ...</div><div class='long'><p>Sets a value</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>columnName</span> : String<div class='sub-desc'><p>Column name</p>\n</div></li><li><span class='pre'>value</span> : String<div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-shift' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-shift' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-shift' class='name expandable'>shift</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Removes the first row and resets the table ...</div><div class='long'><p>Removes the first row and resets the table</p>\n</div></div></div><div id='method-write' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.common.MapTable'>sol.common.MapTable</span><br/><a href='source/lib_sol.common.Map.html#sol-common-MapTable-method-write' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.common.MapTable-method-write' class='name expandable'>write</a>( <span class='pre'></span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Writes the data ...</div><div class='long'><p>Writes the data</p>\n</div></div></div></div></div></div></div>","meta":{"eloas":true,"eloix":true,"elojc":true}});
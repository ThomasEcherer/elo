Ext.data.JsonP.sol_connector_xml_DocumentImporter({"tagname":"class","name":"sol.connector_xml.DocumentImporter","autodetected":{"aliases":true,"alternateClassNames":true,"extends":true,"mixins":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"lib_sol.connector_xml.DocumentImporter.js","href":"lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter"}],"author":[{"tagname":"author","name":"PZ, ELO Digital Office GmbH","email":null}],"version":["1.02.002"],"requires":["sol.common.RepoUtils","sol.connector_xml.Utils"],"aliases":{},"alternateClassNames":[],"extends":"sol.Base","mixins":[],"uses":[],"members":[{"name":"container","tagname":"cfg","owner":"sol.connector_xml.DocumentImporter","id":"cfg-container","meta":{}},{"name":"converter","tagname":"cfg","owner":"sol.connector_xml.DocumentImporter","id":"cfg-converter","meta":{}},{"name":"files","tagname":"cfg","owner":"sol.connector_xml.DocumentImporter","id":"cfg-files","meta":{"required":true}},{"name":"importErrorAction","tagname":"cfg","owner":"sol.connector_xml.DocumentImporter","id":"cfg-importErrorAction","meta":{"required":true}},{"name":"importSuccessAction","tagname":"cfg","owner":"sol.connector_xml.DocumentImporter","id":"cfg-importSuccessAction","meta":{"required":true}},{"name":"requiredConfig","tagname":"cfg","owner":"sol.Base","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"sord","tagname":"cfg","owner":"sol.connector_xml.DocumentImporter","id":"cfg-sord","meta":{}},{"name":"xsd","tagname":"cfg","owner":"sol.connector_xml.DocumentImporter","id":"cfg-xsd","meta":{}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"CONTAINER_IMPORTER","tagname":"property","owner":"sol.connector_xml.DocumentImporter","id":"property-CONTAINER_IMPORTER","meta":{}},{"name":"PLAIN_IMPORTER","tagname":"property","owner":"sol.connector_xml.DocumentImporter","id":"property-PLAIN_IMPORTER","meta":{}},{"name":"config","tagname":"property","owner":"sol.connector_xml.DocumentImporter","id":"property-config","meta":{"private":true}},{"name":"documentBuilder","tagname":"property","owner":"sol.connector_xml.DocumentImporter","id":"property-documentBuilder","meta":{"private":true}},{"name":"impl","tagname":"property","owner":"sol.connector_xml.DocumentImporter","id":"property-impl","meta":{"private":true}},{"name":"importer","tagname":"property","owner":"sol.connector_xml.DocumentImporter","id":"property-importer","meta":{"private":true}},{"name":"logger","tagname":"property","owner":"sol.connector_xml.DocumentImporter","id":"property-logger","meta":{"private":true}},{"name":"name","tagname":"property","owner":"sol.connector_xml.DocumentImporter","id":"property-name","meta":{}},{"name":"utils","tagname":"property","owner":"sol.connector_xml.DocumentImporter","id":"property-utils","meta":{"private":true}},{"name":"validator","tagname":"property","owner":"sol.connector_xml.DocumentImporter","id":"property-validator","meta":{"private":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"getInstance","tagname":"method","owner":"sol.connector_xml.DocumentImporter","id":"method-getInstance","meta":{}},{"name":"initialize","tagname":"method","owner":"sol.Base","id":"method-initialize","meta":{"private":true}},{"name":"preprocessFilePaths","tagname":"method","owner":"sol.connector_xml.DocumentImporter","id":"method-preprocessFilePaths","meta":{"private":true}},{"name":"process","tagname":"method","owner":"sol.connector_xml.DocumentImporter","id":"method-process","meta":{}},{"name":"readXmlData","tagname":"method","owner":"sol.connector_xml.DocumentImporter","id":"method-readXmlData","meta":{"private":true}},{"name":"validate","tagname":"method","owner":"sol.connector_xml.DocumentImporter","id":"method-validate","meta":{}},{"name":"writeMetadata","tagname":"method","owner":"sol.connector_xml.DocumentImporter","id":"method-writeMetadata","meta":{"private":true}}],"code_type":"ext_define","id":"class-sol.connector_xml.DocumentImporter","short_doc":"Contains the DocumentImporter functions\n\nThe importer is used to process XML files and import files into the archive. ...","classIcon":"icon-class","superclasses":["sol.Base"],"subclasses":[],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Hierarchy</h4><div class='subclass first-child'><a href='#!/api/sol.Base' rel='sol.Base' class='docClass'>sol.Base</a><div class='subclass '><strong>sol.connector_xml.DocumentImporter</strong></div></div><h4>Requires</h4><div class='dependency'><a href='#!/api/sol.common.RepoUtils' rel='sol.common.RepoUtils' class='docClass'>sol.common.RepoUtils</a></div><div class='dependency'><a href='#!/api/sol.connector_xml.Utils' rel='sol.connector_xml.Utils' class='docClass'>sol.connector_xml.Utils</a></div><h4>Files</h4><div class='dependency'><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter' target='_blank'>lib_sol.connector_xml.DocumentImporter.js</a></div></pre><div class='doc-contents'><p>Contains the DocumentImporter functions</p>\n\n<p>The importer is used to process XML files and import files into the archive.\nThe XML extraction is controlled by a configuration object.</p>\n\n<h2>Usage</h2>\n\n<pre><code>var targetId = ... ,\n    config = ... ,\n    xml = new java.io.File( ... ),\n    importer = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(\"<a href=\"#!/api/sol.connector_xml.DocumentImporter\" rel=\"sol.connector_xml.DocumentImporter\" class=\"docClass\">sol.connector_xml.DocumentImporter</a>\", config);\n\nif (importer.validate(xml)) {\n  importer.process(xml, targetId);\n}\n</code></pre>\n\n<h2>Configuration</h2>\n\n<p>The configuration consists of several properties/sections, which will be described below.</p>\n\n<h3>xsd</h3>\n\n<p>This contains an Array with GUIDs of XSD files in the archive. They're optional, but if none are defined the validation will always return true.</p>\n\n<h3>container</h3>\n\n<p>If this is set to true, the files should be imported into a new subfolder of the target folder (this is not implemented yet, so far only container=false will work)</p>\n\n<h3>sord</h3>\n\n<p>Only required, in container mode ans specifies the mask of the new container (also not implemented yet)</p>\n\n<h3>importSuccessAction</h3>\n\n<p>Defines, what happens to the XML file in case of import success.\nFurther documentation an the options/ the structure of the instriction see <a href=\"#!/api/sol.connector_xml.Utils-method-handleImportAction\" rel=\"sol.connector_xml.Utils-method-handleImportAction\" class=\"docClass\">Utils.handleImportAction</a></p>\n\n<h3>importErrorAction</h3>\n\n<p>Defines, what happens to the XML file in case of import error.\nFurther documentation an the options/ the structure of the instriction see <a href=\"#!/api/sol.connector_xml.Utils-method-handleImportAction\" rel=\"sol.connector_xml.Utils-method-handleImportAction\" class=\"docClass\">Utils.handleImportAction</a></p>\n\n<h3>files</h3>\n\n<p>This object holds configurations for the informations needed to import the files from the filesystem to the archive.</p>\n\n<ul>\n<li>xpath: Path to the file nodes inside the XML</li>\n<li>useRelativePaths: if set to <code>true</code> paths will be evaluated relative to the XML file</li>\n<li>importSuccessAction: Action for the files in case of success (see <a href=\"#!/api/sol.connector_xml.Utils-method-handleImportAction\" rel=\"sol.connector_xml.Utils-method-handleImportAction\" class=\"docClass\">Utils.handleImportAction</a>)</li>\n<li>importErrorAction: Action for the files in case of error (see <a href=\"#!/api/sol.connector_xml.Utils-method-handleImportAction\" rel=\"sol.connector_xml.Utils-method-handleImportAction\" class=\"docClass\">Utils.handleImportAction</a>)</li>\n<li>values: This object contains the XPaths for reading the file information from the file node.</li>\n</ul>\n\n\n<p>Each value has a describing object:</p>\n\n<pre><code>{ xpath: \"comment\", converter: \"defaultComment\" }\n</code></pre>\n\n<p>xpath: XPath inside the file node\nconverter: (optional) for documentation see <a href=\"#!/api/sol.connector_xml.Importer\" rel=\"sol.connector_xml.Importer\" class=\"docClass\">sol.connector_xml.Importer</a></p>\n\n<p>This are the values which will be read from the file nodes:</p>\n\n<h4>FILE_PATH</h4>\n\n<p>The file system path of the file</p>\n\n<h4>FILE_MASK</h4>\n\n<p>The mask which should be set after import</p>\n\n<h4>FILE_NAME</h4>\n\n<p>The name for the archive element</p>\n\n<h4>FILE_COMMENT</h4>\n\n<p>The comment for the archive element</p>\n\n<h4>FILE_VERSION</h4>\n\n<p>The version for the archive element</p>\n\n<h3>converter</h3>\n\n<p>For documentation see <a href=\"#!/api/sol.connector_xml.Importer\" rel=\"sol.connector_xml.Importer\" class=\"docClass\">sol.connector_xml.Importer</a> and <a href=\"#!/api/sol.connector_xml.Converter\" rel=\"sol.connector_xml.Converter\" class=\"docClass\">Converter</a></p>\n\n<h2>Configuration example</h2>\n\n<pre><code>{\n  xsd: [{ name: \"XSD Name\", guid: \"(04089DB6-E667-EDDE-DB86-5FCB6E5F4DFB)\" }],  //optional\n  container: false,\n  sord: {   //only for container=true\n    mask: \"Eingangsrechnung\"\n  },\n  importSuccessAction: \"rename:imported\", //[delete|move:SUBFOLDER|rename:SUFFIX], default is delete\n  importErrorAction: \"rename:error\", //[delete|move:ARCPATH|rename:SUFFIX], default in delete\n  files: {\n    xpath: \"/import/file\",\n    importSuccessAction: \"rename:imported\", //[delete|move:SUBFOLDER|rename:SUFFIX], default is delete\n    importErrorAction: \"rename:error\", //[delete|move:ARCPATH|rename:SUFFIX], default in delete\n    values: {\n      \"FILE_PATH\": { xpath: \"path\" },\n      \"FILE_MASK\": { xpath: \"mask\", converter: \"defaultMask\" },\n      \"FILE_NAME\": { xpath: \"name\" },\n      \"FILE_COMMENT\": { xpath: \"comment\", converter: \"defaultComment\" },\n      \"FILE_VERSION\": { xpath: \"version\", converter: \"defaultVersion\" }\n    }\n  },\n  converter: [\n    { name: \"defaultMask\", type: \"DefaultConverter\", defaultValue: \"Basic Entry\" },\n    { name: \"defaultComment\", type: \"DefaultConverter\", defaultValue: \"standard import\" },\n    { name: \"defaultVersion\", type: \"DefaultConverter\", defaultValue: \"0.8.15\" }\n  ]\n}\n</code></pre>\n\n<h1>Metadata import</h1>\n\n<p>The <code>DocumentImporter</code> can import metadata as well.</p>\n\n<p>At this point only metadata import is only supported in <code>container</code> mode.\nTo import metadata to the newly generated container, the configuration has to define a <code>mapping</code> (see <a href=\"#!/api/sol.connector_xml.Importer\" rel=\"sol.connector_xml.Importer\" class=\"docClass\">sol.connector_xml.Importer</a> for configuration).</p>\n      <p class='version-tag'>Version: <b>1.02.002</b></p>\n</div><div class='members'><div class='members-section'><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Required config options</h3><div id='cfg-files' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-cfg-files' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-cfg-files' class='name expandable'>files</a> : Object<span class=\"signature\"><span class='required' >required</span></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div><div id='cfg-importErrorAction' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-cfg-importErrorAction' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-cfg-importErrorAction' class='name expandable'>importErrorAction</a> : Object<span class=\"signature\"><span class='required' >required</span></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div><div id='cfg-importSuccessAction' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-cfg-importSuccessAction' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-cfg-importSuccessAction' class='name expandable'>importSuccessAction</a> : Object<span class=\"signature\"><span class='required' >required</span></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div></div><div class='subsection'><div class='definedBy'>Defined By</div><h4 class='members-subtitle'>Optional config options</h3><div id='cfg-container' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-cfg-container' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-cfg-container' class='name expandable'>container</a> : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div><div id='cfg-converter' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-cfg-converter' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-cfg-converter' class='name expandable'>converter</a> : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div><div id='cfg-requiredConfig' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n</div></div></div><div id='cfg-sord' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-cfg-sord' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-cfg-sord' class='name expandable'>sord</a> : Object<span class=\"signature\"></span></div><div class='description'><div class='short'><p>required if 'container'= true</p>\n</div><div class='long'><p>required if 'container'= true</p>\n</div></div></div><div id='cfg-xsd' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-cfg-xsd' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-cfg-xsd' class='name expandable'>xsd</a> : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-CONTAINER_IMPORTER' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-property-CONTAINER_IMPORTER' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-property-CONTAINER_IMPORTER' class='name expandable'>CONTAINER_IMPORTER</a> : Object<span class=\"signature\"></span></div><div class='description'><div class='short'><p>Creates a subfolder and imports all files (from one XML) into that folder.</p>\n</div><div class='long'><p>Creates a subfolder and imports all files (from one XML) into that folder.</p>\n</div></div></div><div id='property-PLAIN_IMPORTER' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-property-PLAIN_IMPORTER' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-property-PLAIN_IMPORTER' class='name expandable'>PLAIN_IMPORTER</a> : Object<span class=\"signature\"></span></div><div class='description'><div class='short'><p>The plain importer just puts all files plain into a folder.</p>\n</div><div class='long'><p>The plain importer just puts all files plain into a folder.</p>\n</div></div></div><div id='property-config' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-property-config' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-property-config' class='name expandable'>config</a> : Object<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div><div id='property-documentBuilder' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-property-documentBuilder' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-property-documentBuilder' class='name expandable'>documentBuilder</a> : Object<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div><div id='property-impl' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-property-impl' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-property-impl' class='name expandable'>impl</a> : Object<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Contains the implementations for the differant importer strategies. ...</div><div class='long'><p>Contains the implementations for the differant importer strategies.</p>\n\n<p>An importer needs to have the following structure:</p>\n\n<pre><code>my_importer: {\n  name: \"importer name\",\n  process: function (parentId, fileData, successAction, errorAction) {\n    ...\n  }\n}\n</code></pre>\n\n<p>The process method should return an Object containing two arrays (<code>objIds</code> and <code>errors</code>).</p>\n\n<p>If the import is in container mode, a containerId will be returned as well.</p>\n</div></div></div><div id='property-importer' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-property-importer' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-property-importer' class='name expandable'>importer</a> : Function<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div><div id='property-logger' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-property-logger' class='name expandable'>logger</a> : Object<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n<p>Overrides: <a href=\"#!/api/sol.Base-property-logger\" rel=\"sol.Base-property-logger\" class=\"docClass\">sol.Base.logger</a></p></div></div></div><div id='property-name' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-property-name' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-property-name' class='name expandable'>name</a> : String<span class=\"signature\"></span></div><div class='description'><div class='short'>The name of ths importer. ...</div><div class='long'><p>The name of ths importer.</p>\n<p>Defaults to: <code>&quot;PLAIN_IMPORTER&quot;</code></p></div></div></div><div id='property-utils' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-property-utils' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-property-utils' class='name expandable'>utils</a> : Object<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div><div id='property-validator' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-property-validator' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-property-validator' class='name expandable'>validator</a> : Object<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>\n</div><div class='long'>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-getInstance' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-method-getInstance' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-method-getInstance' class='name expandable'>getInstance</a>( <span class='pre'>config</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Returns the correct importer implementation based on a given configuration. ...</div><div class='long'><p>Returns the correct importer implementation based on a given configuration.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><a href='#!/api/sol.Base' rel='sol.Base' class='defined-in docClass'>sol.Base</a><br/><a href='source/lib_Class.html#sol-Base-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul></div></div></div><div id='method-preprocessFilePaths' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-method-preprocessFilePaths' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-method-preprocessFilePaths' class='name expandable'>preprocessFilePaths</a>( <span class='pre'>xmlFile, fileData</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Preprocessing of the file paths. ...</div><div class='long'><p>Preprocessing of the file paths.\nIf <code>useRelativePaths</code> is set to <code>true</code>, this evaluates the relative (from the XML) paths to the files to absulute paths.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>xmlFile</span> : java.io.File<div class='sub-desc'>\n</div></li><li><span class='pre'>fileData</span> : Object[]<div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-process' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-method-process' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-method-process' class='name expandable'>process</a>( <span class='pre'>parentId, fileData, successAction, errorAction, timestamp, mask</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Starts the import. ...</div><div class='long'><p>Starts the import.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>parentId</span> : String<div class='sub-desc'><p>ID of the target folder</p>\n</div></li><li><span class='pre'>fileData</span> : Object<div class='sub-desc'><p>Description of the files</p>\n</div></li><li><span class='pre'>successAction</span> : String<div class='sub-desc'><p>Action string which specifies the behaviour in an success case</p>\n</div></li><li><span class='pre'>errorAction</span> : String<div class='sub-desc'><p>Action string which specifies the behaviour in an error case</p>\n</div></li><li><span class='pre'>timestamp</span> : String<div class='sub-desc'><p>A timestamp for possible rename actions</p>\n</div></li><li><span class='pre'>mask</span> : String<div class='sub-desc'><p>Doc mask</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>Returns an object containing an array with objIds, an array with errors (if there have been any) and an objId of the container</p>\n</div></li></ul></div></div></div><div id='method-readXmlData' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-method-readXmlData' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-method-readXmlData' class='name expandable'>readXmlData</a>( <span class='pre'></span> ) : java.io.File[]<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Parses the XML file and reads the data according to the configuration. ...</div><div class='long'><p>Parses the XML file and reads the data according to the configuration.</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>java.io.File[]</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-validate' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-method-validate' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-method-validate' class='name expandable'>validate</a>( <span class='pre'>xml</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Validation against the schema which is defined in the config ...</div><div class='long'><p>Validation against the schema which is defined in the config</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>xml</span> : java.io.File<div class='sub-desc'><p>The XML file that should be validated</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-writeMetadata' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.connector_xml.DocumentImporter'>sol.connector_xml.DocumentImporter</span><br/><a href='source/lib_sol.connector_xml.DocumentImporter.html#sol-connector_xml-DocumentImporter-method-writeMetadata' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.connector_xml.DocumentImporter-method-writeMetadata' class='name expandable'>writeMetadata</a>( <span class='pre'>xml, params</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Imports metadata for a container from the xml file. ...</div><div class='long'><p>Imports metadata for a container from the xml file.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>xml</span> : java.io.File<div class='sub-desc'>\n</div></li><li><span class='pre'>params</span> : Object<div class='sub-desc'><p>This should be the result of the importer process function</p>\n</div></li></ul></div></div></div></div></div></div></div>","meta":{}});
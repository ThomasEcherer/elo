Ext.data.JsonP.wf({"tagname":"class","name":"wf","autodetected":{},"files":[{"filename":"wf_ Workflow Utils.js","href":"wf_ Workflow Utils.html#wf"}],"singleton":true,"members":[{"name":"changeAllUsers","tagname":"method","owner":"wf","id":"method-changeAllUsers","meta":{}},{"name":"changeNodeUser","tagname":"method","owner":"wf","id":"method-changeNodeUser","meta":{}},{"name":"confirmFlowFromZip","tagname":"method","owner":"wf","id":"method-confirmFlowFromZip","meta":{}},{"name":"copyNodeUser","tagname":"method","owner":"wf","id":"method-copyNodeUser","meta":{}},{"name":"createExport","tagname":"method","owner":"wf","id":"method-createExport","meta":{}},{"name":"createFlowFromZip","tagname":"method","owner":"wf","id":"method-createFlowFromZip","meta":{}},{"name":"createOrConfirmFlowFromZip","tagname":"method","owner":"wf","id":"method-createOrConfirmFlowFromZip","meta":{}},{"name":"createWFReport","tagname":"method","owner":"wf","id":"method-createWFReport","meta":{}},{"name":"exportRemoteFlow","tagname":"method","owner":"wf","id":"method-exportRemoteFlow","meta":{}},{"name":"fillFooter","tagname":"method","owner":"wf","id":"method-fillFooter","meta":{}},{"name":"fillHeader","tagname":"method","owner":"wf","id":"method-fillHeader","meta":{}},{"name":"fillNode","tagname":"method","owner":"wf","id":"method-fillNode","meta":{}},{"name":"fillNodes","tagname":"method","owner":"wf","id":"method-fillNodes","meta":{}},{"name":"fillStandardProps","tagname":"method","owner":"wf","id":"method-fillStandardProps","meta":{}},{"name":"fillupFlow","tagname":"method","owner":"wf","id":"method-fillupFlow","meta":{}},{"name":"formatIsoDate","tagname":"method","owner":"wf","id":"method-formatIsoDate","meta":{}},{"name":"getNodeByName","tagname":"method","owner":"wf","id":"method-getNodeByName","meta":{}},{"name":"getNodeProperties","tagname":"method","owner":"wf","id":"method-getNodeProperties","meta":{}},{"name":"getSuccessor","tagname":"method","owner":"wf","id":"method-getSuccessor","meta":{}},{"name":"processRemoteWorkflow","tagname":"method","owner":"wf","id":"method-processRemoteWorkflow","meta":{}},{"name":"readActiveWorkflow","tagname":"method","owner":"wf","id":"method-readActiveWorkflow","meta":{}},{"name":"readWorkflow","tagname":"method","owner":"wf","id":"method-readWorkflow","meta":{}},{"name":"returnRemoteFlow","tagname":"method","owner":"wf","id":"method-returnRemoteFlow","meta":{}},{"name":"sanitize","tagname":"method","owner":"wf","id":"method-sanitize","meta":{}},{"name":"startRemoteFlow","tagname":"method","owner":"wf","id":"method-startRemoteFlow","meta":{}},{"name":"startWorkflow","tagname":"method","owner":"wf","id":"method-startWorkflow","meta":{}},{"name":"storeReport","tagname":"method","owner":"wf","id":"method-storeReport","meta":{}},{"name":"unlockWorkflow","tagname":"method","owner":"wf","id":"method-unlockWorkflow","meta":{}},{"name":"writeWorkflow","tagname":"method","owner":"wf","id":"method-writeWorkflow","meta":{}}],"alternateClassNames":[],"aliases":{},"id":"class-wf","classIcon":"icon-singleton","superclasses":[],"subclasses":[],"mixedInto":[],"mixins":[],"parentMixins":[],"requires":[],"uses":[],"html":"<div><pre class=\"hierarchy\"><h4>Files</h4><div class='dependency'><a href='source/wf_ Workflow Utils.html#wf' target='_blank'>wf_ Workflow Utils.js</a></div></pre><div class='doc-contents'>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-changeAllUsers' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-changeAllUsers' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-changeAllUsers' class='name expandable'>changeAllUsers</a>( <span class='pre'>oldUser, newUser</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Ersetzt den angegebenen Benutzer. ...</div><div class='long'><p>Ersetzt den angegebenen Benutzer.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>oldUser</span> : String<div class='sub-desc'><p>Aktueller Benutzer</p>\n</div></li><li><span class='pre'>newUser</span> : String<div class='sub-desc'><p>Neuer Benutzer</p>\n</div></li></ul></div></div></div><div id='method-changeNodeUser' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-changeNodeUser' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-changeNodeUser' class='name expandable'>changeNodeUser</a>( <span class='pre'>nodeName, nodeUserName</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Setzt den angegebenen Knoten-Benutzer im angegebenen Workflow-Knoten. ...</div><div class='long'><p>Setzt den angegebenen Knoten-Benutzer im angegebenen Workflow-Knoten.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>nodeName</span> : String<div class='sub-desc'><p>Knotenname</p>\n</div></li><li><span class='pre'>nodeUserName</span> : String<div class='sub-desc'><p>Knotenbenutzer</p>\n</div></li></ul></div></div></div><div id='method-confirmFlowFromZip' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-confirmFlowFromZip' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-confirmFlowFromZip' class='name expandable'>confirmFlowFromZip</a>( <span class='pre'>flowData, hasError, errorMessage</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Leitet einen Workflow aus der ZIP-Datei weiter. ...</div><div class='long'><p>Leitet einen Workflow aus der ZIP-Datei weiter.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>flowData</span> : Object<div class='sub-desc'><p>Workflow-Daten</p>\n</div></li><li><span class='pre'>hasError</span> : Boolean<div class='sub-desc'><p>Fehlermeldung vorhanden</p>\n</div></li><li><span class='pre'>errorMessage</span> : String<div class='sub-desc'><p>Fehlermeldung</p>\n</div></li></ul></div></div></div><div id='method-copyNodeUser' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-copyNodeUser' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-copyNodeUser' class='name expandable'>copyNodeUser</a>( <span class='pre'>sourceNodeName, destinationNodeName</span> ) : Object.copyNodeUser.user<span class=\"signature\"></span></div><div class='description'><div class='short'>Kopiert den Knotenbenutzer vom Quellknoten in den Zielknoten. ...</div><div class='long'><p>Kopiert den Knotenbenutzer vom Quellknoten in den Zielknoten.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>sourceNodeName</span> : type<div class='sub-desc'>\n</div></li><li><span class='pre'>destinationNodeName</span> : type<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object.copyNodeUser.user</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-createExport' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-createExport' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-createExport' class='name expandable'>createExport</a>( <span class='pre'>node, flowData, isReturn</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Exportiert den angegebenen Workflow-Knoten. ...</div><div class='long'><p>Exportiert den angegebenen Workflow-Knoten.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>node</span> : WFNode<div class='sub-desc'><p>Workflow-Knoten</p>\n</div></li><li><span class='pre'>flowData</span> : Object<div class='sub-desc'><p>Workflow-Daten</p>\n</div></li><li><span class='pre'>isReturn</span> : Boolean<div class='sub-desc'><p>Zurückgeben</p>\n</div></li></ul></div></div></div><div id='method-createFlowFromZip' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-createFlowFromZip' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-createFlowFromZip' class='name expandable'>createFlowFromZip</a>( <span class='pre'>flowData, hasError, errorMessage</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Erstellt einen Workflow aus der ZIP-Datei. ...</div><div class='long'><p>Erstellt einen Workflow aus der ZIP-Datei.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>flowData</span> : Object<div class='sub-desc'><p>Workflow-Daten</p>\n</div></li><li><span class='pre'>hasError</span> : Boolean<div class='sub-desc'><p>Fehler vorhanden</p>\n</div></li><li><span class='pre'>errorMessage</span> : String<div class='sub-desc'><p>Fehlermeldung</p>\n</div></li></ul></div></div></div><div id='method-createOrConfirmFlowFromZip' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-createOrConfirmFlowFromZip' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-createOrConfirmFlowFromZip' class='name expandable'>createOrConfirmFlowFromZip</a>( <span class='pre'>flowData, hasError, errorMessage</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Erstellt oder leitet einen Workflow weiter aus der ZIP-Datei. ...</div><div class='long'><p>Erstellt oder leitet einen Workflow weiter aus der ZIP-Datei.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>flowData</span> : Object<div class='sub-desc'><p>Workflow-Daten</p>\n</div></li><li><span class='pre'>hasError</span> : Boolean<div class='sub-desc'><p>Fehler vorhanden</p>\n</div></li><li><span class='pre'>errorMessage</span> : String<div class='sub-desc'><p>Fehlermeldung</p>\n</div></li></ul></div></div></div><div id='method-createWFReport' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-createWFReport' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-createWFReport' class='name expandable'>createWFReport</a>( <span class='pre'>node, sord</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Erstellt einen Workflow-Report für den angegebenen Workflow-Knoten. ...</div><div class='long'><p>Erstellt einen Workflow-Report für den angegebenen Workflow-Knoten.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>node</span> : WFNode<div class='sub-desc'><p>Workflow-Knoten</p>\n</div></li><li><span class='pre'>sord</span> : Sord<div class='sub-desc'><p>Verschlagwortung eines Archiveintrags</p>\n</div></li></ul></div></div></div><div id='method-exportRemoteFlow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-exportRemoteFlow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-exportRemoteFlow' class='name expandable'>exportRemoteFlow</a>( <span class='pre'>node, props</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Exportiert einen Remote Workflow-Knoten. ...</div><div class='long'><p>Exportiert einen Remote Workflow-Knoten.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>node</span> : WFNode<div class='sub-desc'><p>Workflow-Knoten</p>\n</div></li><li><span class='pre'>props</span> : Object<div class='sub-desc'><p>Workflow-Properties</p>\n</div></li></ul></div></div></div><div id='method-fillFooter' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-fillFooter' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-fillFooter' class='name expandable'>fillFooter</a>( <span class='pre'>text</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Fügt die abschließende HTML-Zeile im angegebenen Text ein. ...</div><div class='long'><p>Fügt die abschließende HTML-Zeile im angegebenen Text ein.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>text</span> : String<div class='sub-desc'><p>Text</p>\n</div></li></ul></div></div></div><div id='method-fillHeader' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-fillHeader' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-fillHeader' class='name expandable'>fillHeader</a>( <span class='pre'>text, flow</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Fügt die Anfangs HTML-Zeilen im angegebenen Text ein. ...</div><div class='long'><p>Fügt die Anfangs HTML-Zeilen im angegebenen Text ein.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>text</span> : String<div class='sub-desc'><p>Text</p>\n</div></li><li><span class='pre'>flow</span> : WFDiagram<div class='sub-desc'><p>Workflow-Diagramm</p>\n</div></li></ul></div></div></div><div id='method-fillNode' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-fillNode' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-fillNode' class='name expandable'>fillNode</a>( <span class='pre'>text, node, line</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Setzt die Eigenschaften im angegebenen Workflow-Knoten. ...</div><div class='long'><p>Setzt die Eigenschaften im angegebenen Workflow-Knoten.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>text</span> : String<div class='sub-desc'><p>Text</p>\n</div></li><li><span class='pre'>node</span> : WFNode<div class='sub-desc'><p>Workflow-Knoten</p>\n</div></li><li><span class='pre'>line</span> : Number<div class='sub-desc'><p>Zeile</p>\n</div></li></ul></div></div></div><div id='method-fillNodes' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-fillNodes' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-fillNodes' class='name expandable'>fillNodes</a>( <span class='pre'>text, flow</span> ) : undefined<span class=\"signature\"></span></div><div class='description'><div class='short'>Setzt den Text in allen Workflow-Knoten im angegebenen Workflow. ...</div><div class='long'><p>Setzt den Text in allen Workflow-Knoten im angegebenen Workflow.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>text</span> : String<div class='sub-desc'><p>Text</p>\n</div></li><li><span class='pre'>flow</span> : WFDiagram<div class='sub-desc'><p>Workflow</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>undefined</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-fillStandardProps' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-fillStandardProps' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-fillStandardProps' class='name expandable'>fillStandardProps</a>( <span class='pre'>node, props, flowData</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Setzt die Standard-Properties im angegebenen Workflow-Knoten. ...</div><div class='long'><p>Setzt die Standard-Properties im angegebenen Workflow-Knoten.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>node</span> : WFNode<div class='sub-desc'><p>Workflow-Knoten</p>\n</div></li><li><span class='pre'>props</span> : Object<div class='sub-desc'><p>Workflow-Properties</p>\n</div></li><li><span class='pre'>flowData</span> : Object<div class='sub-desc'><p>Workflow-Daten</p>\n</div></li></ul></div></div></div><div id='method-fillupFlow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-fillupFlow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-fillupFlow' class='name expandable'>fillupFlow</a>( <span class='pre'>flow, flowId, objId, sourceWaitId, newOwner, returnTo, flowObjId</span> ) : undefined<span class=\"signature\"></span></div><div class='description'><div class='short'>Setzt die angegebenen Knoten-Eigenschaften. ...</div><div class='long'><p>Setzt die angegebenen Knoten-Eigenschaften.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>flow</span> : WFDiagram<div class='sub-desc'><p>Workflow</p>\n</div></li><li><span class='pre'>flowId</span> : String<div class='sub-desc'><p>Workflow-ID</p>\n</div></li><li><span class='pre'>objId</span> : String<div class='sub-desc'><p>ID des Archiveintrags</p>\n</div></li><li><span class='pre'>sourceWaitId</span> : Number<div class='sub-desc'><p>ID des Nachfolgerknotens</p>\n</div></li><li><span class='pre'>newOwner</span> : Number<div class='sub-desc'><p>Neuer Eigentümer</p>\n</div></li><li><span class='pre'>returnTo</span> : Number<div class='sub-desc'>\n</div></li><li><span class='pre'>flowObjId</span> : Number<div class='sub-desc'>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>undefined</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-formatIsoDate' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-formatIsoDate' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-formatIsoDate' class='name expandable'>formatIsoDate</a>( <span class='pre'>isoDate</span> ) : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Liefert das formattierte ISO-Datum zurück. ...</div><div class='long'><p>Liefert das formattierte ISO-Datum zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>isoDate</span> : String<div class='sub-desc'><p>ISO-Datum</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'><p>formattiertes ISO-Datum</p>\n</div></li></ul></div></div></div><div id='method-getNodeByName' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-getNodeByName' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-getNodeByName' class='name expandable'>getNodeByName</a>( <span class='pre'>wfDiagram, nodeName</span> ) : WFNode<span class=\"signature\"></span></div><div class='description'><div class='short'>Liefert den Workflow-Knoten mit dem angegebenen Namen zurück. ...</div><div class='long'><p>Liefert den Workflow-Knoten mit dem angegebenen Namen zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>wfDiagram</span> : WFDiagram<div class='sub-desc'><p>Workflow-Diagramm</p>\n</div></li><li><span class='pre'>nodeName</span> : String<div class='sub-desc'><p>Knotenname</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>WFNode</span><div class='sub-desc'><p>Workflowknoten</p>\n</div></li></ul></div></div></div><div id='method-getNodeProperties' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-getNodeProperties' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-getNodeProperties' class='name expandable'>getNodeProperties</a>( <span class='pre'>node</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Liefert die Properties des angegebenen Workflow-Knotens zurück. ...</div><div class='long'><p>Liefert die Properties des angegebenen Workflow-Knotens zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>node</span> : WFNode<div class='sub-desc'><p>Workflow-Knoten</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>Knoten-Eigenschaften</p>\n</div></li></ul></div></div></div><div id='method-getSuccessor' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-getSuccessor' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-getSuccessor' class='name expandable'>getSuccessor</a>( <span class='pre'>node</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Liefert den Nachfolgerknoten des angegebenen Workflow-Knotens zurück. ...</div><div class='long'><p>Liefert den Nachfolgerknoten des angegebenen Workflow-Knotens zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>node</span> : WFNode<div class='sub-desc'><p>Workflow-Knoten</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>Knoten-Nachfolger</p>\n</div></li></ul></div></div></div><div id='method-processRemoteWorkflow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-processRemoteWorkflow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-processRemoteWorkflow' class='name expandable'>processRemoteWorkflow</a>( <span class='pre'>node</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Bearbeitet einen Remote Workflow Knoten. ...</div><div class='long'><p>Bearbeitet einen Remote Workflow Knoten.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>node</span> : WFNode<div class='sub-desc'><p>Workflow-Knoten</p>\n</div></li></ul></div></div></div><div id='method-readActiveWorkflow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-readActiveWorkflow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-readActiveWorkflow' class='name expandable'>readActiveWorkflow</a>( <span class='pre'>withLock</span> ) : WFDiagram<span class=\"signature\"></span></div><div class='description'><div class='short'>Liefert den aktiven Workflow mit der eingegebenen ID zurück. ...</div><div class='long'><p>Liefert den aktiven Workflow mit der eingegebenen ID zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>withLock</span> : Boolean<div class='sub-desc'><p>Workflow-Sperre setzen</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>WFDiagram</span><div class='sub-desc'><p>Workflow-Diagramm</p>\n</div></li></ul></div></div></div><div id='method-readWorkflow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-readWorkflow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-readWorkflow' class='name expandable'>readWorkflow</a>( <span class='pre'>workflowId, withLock</span> ) : WFDiagram<span class=\"signature\"></span></div><div class='description'><div class='short'>Liefert den Workflow mit der angegebenen ID zurück. ...</div><div class='long'><p>Liefert den Workflow mit der angegebenen ID zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>workflowId</span> : String<div class='sub-desc'><p>Workflow-ID</p>\n</div></li><li><span class='pre'>withLock</span> : Boolean<div class='sub-desc'><p>Workflow-Sperre setzen</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>WFDiagram</span><div class='sub-desc'><p>Workflow-Diagramm</p>\n</div></li></ul></div></div></div><div id='method-returnRemoteFlow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-returnRemoteFlow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-returnRemoteFlow' class='name expandable'>returnRemoteFlow</a>( <span class='pre'>node, props</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Gibt den angegebenen Workflow-Knoten zurück. ...</div><div class='long'><p>Gibt den angegebenen Workflow-Knoten zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>node</span> : WFNode<div class='sub-desc'><p>Workflow-Knoten</p>\n</div></li><li><span class='pre'>props</span> : Object<div class='sub-desc'><p>Workflow-Properties</p>\n</div></li></ul></div></div></div><div id='method-sanitize' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-sanitize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-sanitize' class='name expandable'>sanitize</a>( <span class='pre'>text</span> ) : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Liefert einen String aus dem angegebenen Text zurück. ...</div><div class='long'><p>Liefert einen String aus dem angegebenen Text zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>text</span> : Object<div class='sub-desc'><p>Text</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-startRemoteFlow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-startRemoteFlow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-startRemoteFlow' class='name expandable'>startRemoteFlow</a>( <span class='pre'>node, props</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Startet einen Workflow mit den angegebenen Daten. ...</div><div class='long'><p>Startet einen Workflow mit den angegebenen Daten.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>node</span> : WFNode<div class='sub-desc'><p>Workflow-Knoten</p>\n</div></li><li><span class='pre'>props</span> : Object<div class='sub-desc'><p>Workflow-Properties</p>\n</div></li></ul></div></div></div><div id='method-startWorkflow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-startWorkflow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-startWorkflow' class='name expandable'>startWorkflow</a>( <span class='pre'>templateName, flowName, objectId</span> ) : Number<span class=\"signature\"></span></div><div class='description'><div class='short'>Startet einen neuen Workflow mit den angegebenen Daten. ...</div><div class='long'><p>Startet einen neuen Workflow mit den angegebenen Daten.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>templateName</span> : String<div class='sub-desc'><p>Workflow-Vorlage</p>\n</div></li><li><span class='pre'>flowName</span> : String<div class='sub-desc'><p>Workflow-Name</p>\n</div></li><li><span class='pre'>objectId</span> : String<div class='sub-desc'><p>Objekt-ID</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Number</span><div class='sub-desc'><p>ID des neuen Workflows</p>\n</div></li></ul></div></div></div><div id='method-storeReport' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-storeReport' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-storeReport' class='name expandable'>storeReport</a>( <span class='pre'>text, sord</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Speichert den Report für den angegebenen Archiveintrag. ...</div><div class='long'><p>Speichert den Report für den angegebenen Archiveintrag.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>text</span> : String<div class='sub-desc'><p>Text</p>\n</div></li><li><span class='pre'>sord</span> : Sord<div class='sub-desc'><p>Verschlagwortung eines Archiveintrags</p>\n</div></li></ul></div></div></div><div id='method-unlockWorkflow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-unlockWorkflow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-unlockWorkflow' class='name expandable'>unlockWorkflow</a>( <span class='pre'>wfDiagram</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Entsperrt den angegebenen Workflow. ...</div><div class='long'><p>Entsperrt den angegebenen Workflow.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>wfDiagram</span> : WFDiagram<div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-writeWorkflow' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='wf'>wf</span><br/><a href='source/wf_ Workflow Utils.html#wf-method-writeWorkflow' target='_blank' class='view-source'>view source</a></div><a href='#!/api/wf-method-writeWorkflow' class='name expandable'>writeWorkflow</a>( <span class='pre'>wfDiagram</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Speichert den angegebenen Workflow. ...</div><div class='long'><p>Speichert den angegebenen Workflow.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>wfDiagram</span> : WFDiagram<div class='sub-desc'><p>Workflow-Diagramm</p>\n</div></li></ul></div></div></div></div></div></div></div>","meta":{"singleton":true}});
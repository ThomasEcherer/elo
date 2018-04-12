Ext.data.JsonP.NotifyCallback({"tagname":"class","name":"NotifyCallback","autodetected":{},"files":[{"filename":"notifyCallback.js","href":"notifyCallback.html#NotifyCallback"}],"members":[{"name":"beforeSend","tagname":"method","owner":"NotifyCallback","id":"method-beforeSend","meta":{}},{"name":"filterTask","tagname":"method","owner":"NotifyCallback","id":"method-filterTask","meta":{}},{"name":"formatMessage","tagname":"method","owner":"NotifyCallback","id":"method-formatMessage","meta":{}},{"name":"getMailUser","tagname":"method","owner":"NotifyCallback","id":"method-getMailUser","meta":{}},{"name":"getSubject","tagname":"method","owner":"NotifyCallback","id":"method-getSubject","meta":{}},{"name":"getTableLine","tagname":"method","owner":"NotifyCallback","id":"method-getTableLine","meta":{}}],"alternateClassNames":[],"aliases":{},"id":"class-NotifyCallback","classIcon":"icon-class","superclasses":[],"subclasses":[],"mixedInto":[],"mixins":[],"parentMixins":[],"requires":[],"uses":[],"html":"<div><pre class=\"hierarchy\"><h4>Files</h4><div class='dependency'><a href='source/notifyCallback.html#NotifyCallback' target='_blank'>notifyCallback.js</a></div></pre><div class='doc-contents'>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-beforeSend' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='NotifyCallback'>NotifyCallback</span><br/><a href='source/notifyCallback.html#NotifyCallback-method-beforeSend' target='_blank' class='view-source'>view source</a></div><a href='#!/api/NotifyCallback-method-beforeSend' class='name expandable'>beforeSend</a>( <span class='pre'>text</span> ) : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Diese Funktion wird vor dem Versenden ausgeführt. ...</div><div class='long'><p>Diese Funktion wird vor dem Versenden ausgeführt.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>text</span> : String<div class='sub-desc'><p>Text</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-filterTask' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='NotifyCallback'>NotifyCallback</span><br/><a href='source/notifyCallback.html#NotifyCallback-method-filterTask' target='_blank' class='view-source'>view source</a></div><a href='#!/api/NotifyCallback-method-filterTask' class='name expandable'>filterTask</a>( <span class='pre'>task</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Meldet zurück, ob die angegebene Aufgabe die Filterkriterien erfüllt. ...</div><div class='long'><p>Meldet zurück, ob die angegebene Aufgabe die Filterkriterien erfüllt.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>task</span> : Object<div class='sub-desc'><p>Aufgabe</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'><p>Aufgabe erfüllt die Filterkriterien</p>\n</div></li></ul></div></div></div><div id='method-formatMessage' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='NotifyCallback'>NotifyCallback</span><br/><a href='source/notifyCallback.html#NotifyCallback-method-formatMessage' target='_blank' class='view-source'>view source</a></div><a href='#!/api/NotifyCallback-method-formatMessage' class='name expandable'>formatMessage</a>( <span class='pre'>template, node, sord, properties</span> ) : unresolved<span class=\"signature\"></span></div><div class='description'><div class='short'>Liefert das formattierte Message zurück. ...</div><div class='long'><p>Liefert das formattierte Message zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>template</span> : Object<div class='sub-desc'><p>Vorlage</p>\n</div></li><li><span class='pre'>node</span> : Object<div class='sub-desc'><p>Workflow-Knoten</p>\n</div></li><li><span class='pre'>sord</span> : Sord<div class='sub-desc'><p>Verschlagwortung des Archiveintrags</p>\n</div></li><li><span class='pre'>properties</span> : Sord<div class='sub-desc'><p>Properties</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>unresolved</span><div class='sub-desc'>\n</div></li></ul></div></div></div><div id='method-getMailUser' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='NotifyCallback'>NotifyCallback</span><br/><a href='source/notifyCallback.html#NotifyCallback-method-getMailUser' target='_blank' class='view-source'>view source</a></div><a href='#!/api/NotifyCallback-method-getMailUser' class='name expandable'>getMailUser</a>( <span class='pre'>userName</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Liefert den E-Mail Benutzer zurück. ...</div><div class='long'><p>Liefert den E-Mail Benutzer zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>userName</span> : String<div class='sub-desc'><p>Benutzername</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>E-Mail Benutzer</p>\n</div></li></ul></div></div></div><div id='method-getSubject' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='NotifyCallback'>NotifyCallback</span><br/><a href='source/notifyCallback.html#NotifyCallback-method-getSubject' target='_blank' class='view-source'>view source</a></div><a href='#!/api/NotifyCallback-method-getSubject' class='name expandable'>getSubject</a>( <span class='pre'>node, sord, properties</span> ) : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Liefert den Betreff aus den angegebenen Daten zurück. ...</div><div class='long'><p>Liefert den Betreff aus den angegebenen Daten zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>node</span> : Object<div class='sub-desc'><p>Workflow-Knoten</p>\n</div></li><li><span class='pre'>sord</span> : Sord<div class='sub-desc'><p>Archiveintrag</p>\n</div></li><li><span class='pre'>properties</span> : Object<div class='sub-desc'><p>Properties</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'><p>Betreff</p>\n</div></li></ul></div></div></div><div id='method-getTableLine' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='NotifyCallback'>NotifyCallback</span><br/><a href='source/notifyCallback.html#NotifyCallback-method-getTableLine' target='_blank' class='view-source'>view source</a></div><a href='#!/api/NotifyCallback-method-getTableLine' class='name expandable'>getTableLine</a>( <span class='pre'>task</span> ) : Object<span class=\"signature\"></span></div><div class='description'><div class='short'>Liefert eine Tabellenzeile zurück. ...</div><div class='long'><p>Liefert eine Tabellenzeile zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>task</span> : Object<div class='sub-desc'><p>Aufgabe</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Object</span><div class='sub-desc'><p>Tabellenzeile</p>\n</div></li></ul></div></div></div></div></div></div></div>","meta":{}});
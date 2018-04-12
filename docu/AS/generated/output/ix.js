Ext.data.JsonP.ix({"tagname":"class","name":"ix","autodetected":{},"files":[{"filename":"ix_ IndexServer Functions.js","href":"ix_ IndexServer Functions.html#ix"}],"singleton":true,"members":[{"name":"addAttachment","tagname":"method","owner":"ix","id":"method-addAttachment","meta":{}},{"name":"addDocument","tagname":"method","owner":"ix","id":"method-addDocument","meta":{}},{"name":"addFeedComment","tagname":"method","owner":"ix","id":"method-addFeedComment","meta":{}},{"name":"backgroundJobLoop","tagname":"method","owner":"ix","id":"method-backgroundJobLoop","meta":{}},{"name":"collectChildren","tagname":"method","owner":"ix","id":"method-collectChildren","meta":{}},{"name":"createSubPath","tagname":"method","owner":"ix","id":"method-createSubPath","meta":{}},{"name":"deleteOldDocs","tagname":"method","owner":"ix","id":"method-deleteOldDocs","meta":{}},{"name":"deleteSord","tagname":"method","owner":"ix","id":"method-deleteSord","meta":{}},{"name":"downloadAsString","tagname":"method","owner":"ix","id":"method-downloadAsString","meta":{}},{"name":"downloadDocument","tagname":"method","owner":"ix","id":"method-downloadDocument","meta":{}},{"name":"findEntry","tagname":"method","owner":"ix","id":"method-findEntry","meta":{}},{"name":"getFulltext","tagname":"method","owner":"ix","id":"method-getFulltext","meta":{}},{"name":"getIndexValueByName","tagname":"method","owner":"ix","id":"method-getIndexValueByName","meta":{}},{"name":"getKeyByName","tagname":"method","owner":"ix","id":"method-getKeyByName","meta":{}},{"name":"getLoginCount","tagname":"method","owner":"ix","id":"method-getLoginCount","meta":{}},{"name":"lookupDocType","tagname":"method","owner":"ix","id":"method-lookupDocType","meta":{}},{"name":"lookupIndex","tagname":"method","owner":"ix","id":"method-lookupIndex","meta":{}},{"name":"lookupIndexByLine","tagname":"method","owner":"ix","id":"method-lookupIndexByLine","meta":{}},{"name":"lookupIndexByLine2","tagname":"method","owner":"ix","id":"method-lookupIndexByLine2","meta":{}},{"name":"moveToPath","tagname":"method","owner":"ix","id":"method-moveToPath","meta":{}},{"name":"setIndexValueByName","tagname":"method","owner":"ix","id":"method-setIndexValueByName","meta":{}}],"alternateClassNames":[],"aliases":{},"id":"class-ix","classIcon":"icon-singleton","superclasses":[],"subclasses":[],"mixedInto":[],"mixins":[],"parentMixins":[],"requires":[],"uses":[],"html":"<div><pre class=\"hierarchy\"><h4>Files</h4><div class='dependency'><a href='source/ix_ IndexServer Functions.html#ix' target='_blank'>ix_ IndexServer Functions.js</a></div></pre><div class='doc-contents'>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-addAttachment' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-addAttachment' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-addAttachment' class='name expandable'>addAttachment</a>( <span class='pre'>objId, file</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Fügt an das angegebene Archivdokument eine neue\nDateianbindung (Attachment) hinzu. ...</div><div class='long'><p>Fügt an das angegebene Archivdokument eine neue\nDateianbindung (Attachment) hinzu.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>objId</span> : String<div class='sub-desc'><p>ObjektId des Zieldokuments</p>\n</div></li><li><span class='pre'>file</span> : File<div class='sub-desc'><p>Datei mit dem neuen Anhang</p>\n</div></li></ul></div></div></div><div id='method-addDocument' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-addDocument' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-addDocument' class='name expandable'>addDocument</a>( <span class='pre'>sord, file</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Fügt an das übergebene Verschlagwortungsobjekt\neine neue Dateiversion an. ...</div><div class='long'><p>Fügt an das übergebene Verschlagwortungsobjekt\neine neue Dateiversion an. Der Aufrufer muss\nsicherstellen, dass es sich um ein ELO Dokument\nund nicht um einen Ordner handelt.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>sord</span> : Sord<div class='sub-desc'><p>Verschlagwortung des Zieldokuments</p>\n</div></li><li><span class='pre'>file</span> : File<div class='sub-desc'><p>Datei mit der neuen Dokumentenversion</p>\n</div></li></ul></div></div></div><div id='method-addFeedComment' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-addFeedComment' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-addFeedComment' class='name expandable'>addFeedComment</a>( <span class='pre'>eloObjectGuid, user, comment</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Fügt einen Skript-Kommentar im Feed eines Ordners oder Dokuments\nhinzu. ...</div><div class='long'><p>Fügt einen Skript-Kommentar im Feed eines Ordners oder Dokuments\nhinzu.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>eloObjectGuid</span> : String<div class='sub-desc'><p>ELO Objekt GUID (nicht die objid) des Eintrags</p>\n</div></li><li><span class='pre'>user</span> : String<div class='sub-desc'><p>ELO Anwender</p>\n</div></li><li><span class='pre'>comment</span> : String<div class='sub-desc'><p>Text der in den Feed eingetragen werden soll, kein HTML Text</p>\n</div></li></ul></div></div></div><div id='method-backgroundJobLoop' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-backgroundJobLoop' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-backgroundJobLoop' class='name expandable'>backgroundJobLoop</a>( <span class='pre'>navInfo, procInfo</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Startet einen Hintergrundprozess mit den angegebenen Daten und\nwartet auf die Prozessbeendung. ...</div><div class='long'><p>Startet einen Hintergrundprozess mit den angegebenen Daten und\nwartet auf die Prozessbeendung.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>navInfo</span> : NavigationInfo<div class='sub-desc'><p>Navigationsinformation</p>\n</div></li><li><span class='pre'>procInfo</span> : ProcessInfo<div class='sub-desc'><p>Prozessinformation</p>\n</div></li></ul></div></div></div><div id='method-collectChildren' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-collectChildren' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-collectChildren' class='name expandable'>collectChildren</a>( <span class='pre'>parentId, withRefs</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Lädt die maximal ersten 1000 Nachfolgereinträge\neines ELO Ordners. ...</div><div class='long'><p>Lädt die maximal ersten 1000 Nachfolgereinträge\neines ELO Ordners.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>parentId</span> : String<div class='sub-desc'><p>ELO ObjektId der Ordners</p>\n</div></li><li><span class='pre'>withRefs</span> : Boolean<div class='sub-desc'><p>Lädt nur Haupteinträge oder auch Referenzen</p>\n</div></li></ul></div></div></div><div id='method-createSubPath' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-createSubPath' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-createSubPath' class='name expandable'>createSubPath</a>( <span class='pre'>startId, destPath, folderMask</span> ) : Number<span class=\"signature\"></span></div><div class='description'><div class='short'>Erzeugt, beginnend mit einem Startordner, den angegebenen\nUnterpfad mit der angegebenen Maske. ...</div><div class='long'><p>Erzeugt, beginnend mit einem Startordner, den angegebenen\nUnterpfad mit der angegebenen Maske.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>startId</span> : String<div class='sub-desc'><p>ID des Startordners</p>\n</div></li><li><span class='pre'>destPath</span> : String<div class='sub-desc'><p>Unterpfad, beginnend ab dem Startordner</p>\n</div></li><li><span class='pre'>folderMask</span> : String<div class='sub-desc'><p>Maske für neu anzulegende Ordner</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Number</span><div class='sub-desc'><p>ID des neuen Pfades</p>\n</div></li></ul></div></div></div><div id='method-deleteOldDocs' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-deleteOldDocs' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-deleteOldDocs' class='name expandable'>deleteOldDocs</a>( <span class='pre'>deleteFinally</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Löscht alle Dokumente mit überschrittenen Verfallsdatum. ...</div><div class='long'><p>Löscht alle Dokumente mit überschrittenen Verfallsdatum.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>deleteFinally</span> : Boolean<div class='sub-desc'><p>Dauerhaft entfernen</p>\n</div></li></ul></div></div></div><div id='method-deleteSord' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-deleteSord' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-deleteSord' class='name expandable'>deleteSord</a>( <span class='pre'>parentId, objId</span> ) : Boolean<span class=\"signature\"></span></div><div class='description'><div class='short'>Löscht einen Eintrag oder eine Referenz. ...</div><div class='long'><p>Löscht einen Eintrag oder eine Referenz.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>parentId</span> : String<div class='sub-desc'><p>ID des Vorgängerknotens</p>\n</div></li><li><span class='pre'>objId</span> : String<div class='sub-desc'><p>Zielknoten</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Boolean</span><div class='sub-desc'><p>Löschen erfolgreich</p>\n</div></li></ul></div></div></div><div id='method-downloadAsString' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-downloadAsString' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-downloadAsString' class='name expandable'>downloadAsString</a>( <span class='pre'>sord</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Lädt die Arbeitsversion eines ELO Dokuments und gibt den Inhalt als String zurück. ...</div><div class='long'><p>Lädt die Arbeitsversion eines ELO Dokuments und gibt den Inhalt als String zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>sord</span> : String<div class='sub-desc'><p>ELO Verschlagwortungsobjekt</p>\n</div></li></ul></div></div></div><div id='method-downloadDocument' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-downloadDocument' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-downloadDocument' class='name expandable'>downloadDocument</a>( <span class='pre'>pathAndFileName, sord</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Lädt die Arbeitsversion eines ELO Dokuments in eine lokale Datei. ...</div><div class='long'><p>Lädt die Arbeitsversion eines ELO Dokuments in eine lokale Datei.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>pathAndFileName</span> : String<div class='sub-desc'><p>vollständiger lokaler Pfad für die zu lesende Datei</p>\n</div></li><li><span class='pre'>sord</span> : String<div class='sub-desc'><p>ELO Verschlagwortungsobjekt</p>\n</div></li></ul></div></div></div><div id='method-findEntry' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-findEntry' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-findEntry' class='name expandable'>findEntry</a>( <span class='pre'>maskNo, groupName, value</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Sucht einen Eintrag mit der angegebenen Maskennummer\nund Indexzeileninhalt. ...</div><div class='long'><p>Sucht einen Eintrag mit der angegebenen Maskennummer\nund Indexzeileninhalt.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>maskNo</span> : String<div class='sub-desc'><p>gesuchte Maske</p>\n</div></li><li><span class='pre'>groupName</span> : String<div class='sub-desc'><p>Name der zu durchsuchenden Indexzeile</p>\n</div></li><li><span class='pre'>value</span> : String<div class='sub-desc'><p>Gesuchter Indexwert</p>\n</div></li></ul></div></div></div><div id='method-getFulltext' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-getFulltext' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-getFulltext' class='name expandable'>getFulltext</a>( <span class='pre'>objId</span> ) : String<span class=\"signature\"></span></div><div class='description'><div class='short'>Gibt den Volltext eines ELO Dokuments in einem String zurück. ...</div><div class='long'><p>Gibt den Volltext eines ELO Dokuments in einem String zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>objId</span> : String<div class='sub-desc'><p>ELO Dokument zu dem der Volltext gelesen werden soll</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>String</span><div class='sub-desc'><p>Volltextinhalt</p>\n</div></li></ul></div></div></div><div id='method-getIndexValueByName' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-getIndexValueByName' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-getIndexValueByName' class='name expandable'>getIndexValueByName</a>( <span class='pre'>sord, name</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Liest aus einem ELO Sord Objekt den Inhalt einer\nIndexzeile mit dem angegebenen Namen ...</div><div class='long'><p>Liest aus einem ELO Sord Objekt den Inhalt einer\nIndexzeile mit dem angegebenen Namen</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>sord</span> : Sord<div class='sub-desc'><p>ELO Verschlagwortungsobjekt</p>\n</div></li><li><span class='pre'>name</span> : String<div class='sub-desc'><p>Gruppenname der Indexzeile</p>\n</div></li></ul></div></div></div><div id='method-getKeyByName' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-getKeyByName' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-getKeyByName' class='name expandable'>getKeyByName</a>( <span class='pre'>sord, name</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Liest aus einem ELO Sord Objekt das ObjKey-Objekt einer\nIndexzeile mit dem angegebenen Namen. ...</div><div class='long'><p>Liest aus einem ELO Sord Objekt das ObjKey-Objekt einer\nIndexzeile mit dem angegebenen Namen.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>sord</span> : Sord<div class='sub-desc'><p>ELO Verschlagwortungsobjekt</p>\n</div></li><li><span class='pre'>name</span> : String<div class='sub-desc'><p>Gruppenname der Indexzeile</p>\n</div></li></ul></div></div></div><div id='method-getLoginCount' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-getLoginCount' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-getLoginCount' class='name expandable'>getLoginCount</a>( <span class='pre'></span> ) : Number<span class=\"signature\"></span></div><div class='description'><div class='short'>Ermittelt die Anzahl der aktuell angemeldeten Anwender sowie\nder in der letzten Stunde und des laufenden Tags maximal...</div><div class='long'><p>Ermittelt die Anzahl der aktuell angemeldeten Anwender sowie\nder in der letzten Stunde und des laufenden Tags maximal\nangemeldeten Anwender.</p>\n\n<p>Diese Funktion muss regelmäßig aufgerufen werden wenn die\nStunden und Tageswerte benötigt werden (z.B. alle 5 Minuten).</p>\n<h3 class='pa'>Returns</h3><ul><li><span class='pre'>Number</span><div class='sub-desc'><p>Anzahl der aktuell angemeldeten Anwender</p>\n</div></li></ul></div></div></div><div id='method-lookupDocType' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-lookupDocType' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-lookupDocType' class='name expandable'>lookupDocType</a>( <span class='pre'>filename</span> ) : DocType<span class=\"signature\"></span></div><div class='description'><div class='short'>Ermittelt den ELO DocType aus der Datei-Extension\naus der ELO Konfiguration. ...</div><div class='long'><p>Ermittelt den ELO DocType aus der Datei-Extension\naus der ELO Konfiguration.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>filename</span> : String<div class='sub-desc'><p>Dateiname aus der den Dateityp gelesen wird.</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>DocType</span><div class='sub-desc'><p>Dateityp</p>\n</div></li></ul></div></div></div><div id='method-lookupIndex' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-lookupIndex' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-lookupIndex' class='name expandable'>lookupIndex</a>( <span class='pre'>archivePath</span> ) : Number<span class=\"signature\"></span></div><div class='description'><div class='short'>Liefert die ID des Archiveintrags mit dem angegebenen Pfades zurück. ...</div><div class='long'><p>Liefert die ID des Archiveintrags mit dem angegebenen Pfades zurück.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>archivePath</span> : String<div class='sub-desc'><p>Pfad des Archiveintrags</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Number</span><div class='sub-desc'><p>ID des Archiveintrags</p>\n</div></li></ul></div></div></div><div id='method-lookupIndexByLine' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-lookupIndexByLine' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-lookupIndexByLine' class='name expandable'>lookupIndexByLine</a>( <span class='pre'>maskId, groupName, value</span> ) : Number<span class=\"signature\"></span></div><div class='description'><div class='short'>Ermittelt die ELO ObjektId zu einem gesuchten Eintrag aus Maskennummer\nund Indexzeile ...</div><div class='long'><p>Ermittelt die ELO ObjektId zu einem gesuchten Eintrag aus Maskennummer\nund Indexzeile</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>maskId</span> : String<div class='sub-desc'><p>gesuchte Maske</p>\n</div></li><li><span class='pre'>groupName</span> : String<div class='sub-desc'><p>Name der Indexzeile</p>\n</div></li><li><span class='pre'>value</span> : String<div class='sub-desc'><p>Inhalt der Indexzeile</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Number</span><div class='sub-desc'><p>ID des Archiveintrags</p>\n</div></li></ul></div></div></div><div id='method-lookupIndexByLine2' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-lookupIndexByLine2' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-lookupIndexByLine2' class='name expandable'>lookupIndexByLine2</a>( <span class='pre'>maskId, groupName1, groupName2, value1, value2</span> ) : Number<span class=\"signature\"></span></div><div class='description'><div class='short'>Ermittelt die ELO ObjektId zu einem gesuchten Eintrag aus Maskennummer\nund zwei Indexzeilen. ...</div><div class='long'><p>Ermittelt die ELO ObjektId zu einem gesuchten Eintrag aus Maskennummer\nund zwei Indexzeilen.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>maskId</span> : String<div class='sub-desc'><p>gesuchte Maske</p>\n</div></li><li><span class='pre'>groupName1</span> : String<div class='sub-desc'><p>Name der ersten Indexzeile</p>\n</div></li><li><span class='pre'>groupName2</span> : String<div class='sub-desc'><p>Name der zweiten Indexzeile</p>\n</div></li><li><span class='pre'>value1</span> : String<div class='sub-desc'><p>Inhalt der ersten Indexzeile</p>\n</div></li><li><span class='pre'>value2</span> : String<div class='sub-desc'><p>Inhalt der zweiten Indexzeile</p>\n</div></li></ul><h3 class='pa'>Returns</h3><ul><li><span class='pre'>Number</span><div class='sub-desc'><p>ID des Archiveintrags</p>\n</div></li></ul></div></div></div><div id='method-moveToPath' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-moveToPath' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-moveToPath' class='name expandable'>moveToPath</a>( <span class='pre'>sordId, newPathId</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Verschiebt alle Dateien der Dokumenten-Untereinträge\neines ELO Ordners in einen anderen Speicherpfad. ...</div><div class='long'><p>Verschiebt alle Dateien der Dokumenten-Untereinträge\neines ELO Ordners in einen anderen Speicherpfad.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>sordId</span> : String<div class='sub-desc'><p>ELO ObjektId des Startordners</p>\n</div></li><li><span class='pre'>newPathId</span> : Number<div class='sub-desc'><p>ELO Pfadnummer für die verschobenen Dateien</p>\n</div></li></ul></div></div></div><div id='method-setIndexValueByName' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='ix'>ix</span><br/><a href='source/ix_ IndexServer Functions.html#ix-method-setIndexValueByName' target='_blank' class='view-source'>view source</a></div><a href='#!/api/ix-method-setIndexValueByName' class='name expandable'>setIndexValueByName</a>( <span class='pre'>sord, name, value</span> )<span class=\"signature\"></span></div><div class='description'><div class='short'>Sucht in einem Sord Objekt nach einer Indexzeile\nmit dem angegebenen Namen und füllt das Data Feld\nmit dem angegebene...</div><div class='long'><p>Sucht in einem Sord Objekt nach einer Indexzeile\nmit dem angegebenen Namen und füllt das Data Feld\nmit dem angegebenen Wert.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>sord</span> : Sord<div class='sub-desc'><p>Verschlagwortungsobjekt - Indexserver Sord Objekt</p>\n</div></li><li><span class='pre'>name</span> : String<div class='sub-desc'><p>Gruppenname der Indexzeile</p>\n</div></li><li><span class='pre'>value</span> : String<div class='sub-desc'><p>Einzutragender Wert</p>\n</div></li></ul></div></div></div></div></div></div></div>","meta":{"singleton":true}});
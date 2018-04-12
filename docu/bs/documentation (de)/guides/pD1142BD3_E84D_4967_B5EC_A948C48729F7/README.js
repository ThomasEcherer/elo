Ext.data.JsonP.pD1142BD3_E84D_4967_B5EC_A948C48729F7({"guide":"<h1 id='pD1142BD3_E84D_4967_B5EC_A948C48729F7-section-hilfsklassen'>Hilfsklassen</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/pD1142BD3_E84D_4967_B5EC_A948C48729F7-section-%C3%9Cbergreifende-kompatibilit%C3%A4t-von-skripten'>Übergreifende Kompatibilität von Skripten</a>\n </li>\n<li>2. <a href='#!/guide/pD1142BD3_E84D_4967_B5EC_A948C48729F7-section-utility-klassen'>Utility-Klassen</a>\n </li>\n<li>3. <a href='#!/guide/pD1142BD3_E84D_4967_B5EC_A948C48729F7-section-funktionsklassen'>Funktionsklassen</a>\n </li>\n</ul></div>\n\n<p>Das Modul <span\nstyle='font-weight:bold;font-style:italic'>Business Solutions Common</span> stellt eine Reihe von Hilfsklassen zur Verfügung, die für unterschiedliche Zwecke eingesetzt werden können.</p>\n\n<p>Im Folgenden soll eine Auswahl an Klassen erwähnt werden. Die genaue Beschreibung und Anzahl aller Hilfsklassen  findet sich in der Scripting-Dokumentation.</p>\n\n<h2 id='pD1142BD3_E84D_4967_B5EC_A948C48729F7-section-%C3%9Cbergreifende-kompatibilit%C3%A4t-von-skripten'>Übergreifende Kompatibilität von Skripten</h2>\n\n<p>Um eine übergreifende Kompatibilität von ELO-API-Aufrufen zu gewährleisten, wird ab ELO Version 9.03 einheitlich bspw. die Variable <code>ixConnect</code> für die Indexserver-Connection im Scripting gesetzt.</p>\n\n<h2 id='pD1142BD3_E84D_4967_B5EC_A948C48729F7-section-utility-klassen'>Utility-Klassen</h2>\n\n<p>Utility-Klassen sind Singletons und können ohne Instanziierung verwendet werden.</p>\n\n<table><thead><tr><td><span\nstyle='font-weight:bold'>Name der Klasse</span></td><td><span\nstyle='font-weight:bold'>Beschreibung</span></td></tr></thead><tbody><tr><td>    <a href=\"#!/api/sol.common.AclUtils\" rel=\"sol.common.AclUtils\" class=\"docClass\">sol.common.AclUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Umgang mit Berechtigungen in ELO</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.as.BarcodeUtils\" rel=\"sol.common.as.BarcodeUtils\" class=\"docClass\">sol.common.as.BarcodeUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für die Verwendung von QR-Code und Barcodes</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.as.Utils\" rel=\"sol.common.as.Utils\" class=\"docClass\">sol.common.as.Utils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für die Vereinfachung von ELO AS Regeln</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.as.PdfUtils\" rel=\"sol.common.as.PdfUtils\" class=\"docClass\">sol.common.as.PdfUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Umgang mit PDF-Dokumenten</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.AsUtils\" rel=\"sol.common.AsUtils\" class=\"docClass\">sol.common.AsUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Umgang mit ELOas-Aufrufen</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.AsyncUtils\" rel=\"sol.common.AsyncUtils\" class=\"docClass\">sol.common.AsyncUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen um asynchrone Aufrufe zu synchronisieren</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.CounterUtils\" rel=\"sol.common.CounterUtils\" class=\"docClass\">sol.common.CounterUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für die Verwendung von Countern</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.DateUtils\" rel=\"sol.common.DateUtils\" class=\"docClass\">sol.common.DateUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Umgang mit Datumsformaten</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.ExceptionUtils\" rel=\"sol.common.ExceptionUtils\" class=\"docClass\">sol.common.ExceptionUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Umgang mit Index Server Exceptions</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.ExecUtils\" rel=\"sol.common.ExecUtils\" class=\"docClass\">sol.common.ExecUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Umgang mit lokalen Systemressourcen</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.FileUtils\" rel=\"sol.common.FileUtils\" class=\"docClass\">sol.common.FileUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Umgang mit lokalen und temporären Dateien</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.HttpUtils\" rel=\"sol.common.HttpUtils\" class=\"docClass\">sol.common.HttpUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen um Inhalte externer http-Quellen abzufragen</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.ix.DynKwlUtils\" rel=\"sol.common.ix.DynKwlUtils\" class=\"docClass\">sol.common.ix.DynKwlUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für dynamische Stichwortlisten</span><br />Vereinfacht das Befüllen von Daten mithilfe von dynamischen Stichwortlisten.</td></tr><tr><td>    <a href=\"#!/api/sol.common.ix.RfUtils\" rel=\"sol.common.ix.RfUtils\" class=\"docClass\">sol.common.ix.RfUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für die Implementierung von Registered Functions</span><br />Vereinfacht u.a. das Parsen und Überprüfen von übergebenen Parameter-Werten.</td></tr><tr><td>    <a href=\"#!/api/sol.common.IxUtils\" rel=\"sol.common.IxUtils\" class=\"docClass\">sol.common.IxUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Indexserver-Aufruf</span><br />Vereinfacht es u.a. Registered Functions aufzurufen.</td></tr><tr><td>    <a href=\"#!/api/sol.common.JsonUtils\" rel=\"sol.common.JsonUtils\" class=\"docClass\">sol.common.JsonUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Umgang mit JSON-Daten</span><br />Vereinfacht das Serialisieren von JSON-Daten.</td></tr><tr><td>    <a href=\"#!/api/sol.common.ObjectUtils\" rel=\"sol.common.ObjectUtils\" class=\"docClass\">sol.common.ObjectUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Umgang mit JS-Objekten</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.RepoUtils\" rel=\"sol.common.RepoUtils\" class=\"docClass\">sol.common.RepoUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Zugriff auf ELO-Elemente</span><br />Vereinfacht den Zugriff auf Elemente im ELO-Archiv.</td></tr><tr><td>    <a href=\"#!/api/sol.common.SordTypeUtils\" rel=\"sol.common.SordTypeUtils\" class=\"docClass\">sol.common.SordTypeUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Umgang mit Sord-Objekttypen</span><br /></td></tr><tr><td>    <a href=\"#!/api/sol.common.SordUtils\" rel=\"sol.common.SordUtils\" class=\"docClass\">sol.common.SordUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Umgang mit Sord-Objekten</span><br />Vereinfacht den Zugriff auf Informationen des Sords.</td></tr><tr><td>    <a href=\"#!/api/sol.common.StringUtils\" rel=\"sol.common.StringUtils\" class=\"docClass\">sol.common.StringUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Umgang mit Zeichenketten</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.TranslateTerms\" rel=\"sol.common.TranslateTerms\" class=\"docClass\">sol.common.TranslateTerms</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für die Lokalisierung von Lösungen</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.UserUtils\" rel=\"sol.common.UserUtils\" class=\"docClass\">sol.common.UserUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Umgang mit Benutzerprofilen</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.WfUtils\" rel=\"sol.common.WfUtils\" class=\"docClass\">sol.common.WfUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Umgang mit Workflows</span><br />Vereinfacht den Zugriff auf Workflow-Knoten und ermöglicht es, diese zu bearbeiten.</td></tr><tr><td>    <a href=\"#!/api/sol.common.XmlUtils\" rel=\"sol.common.XmlUtils\" class=\"docClass\">sol.common.XmlUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für den Aufbau von XML-Datenstrukturen aus JS-Objekten</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.ZipUtils\" rel=\"sol.common.ZipUtils\" class=\"docClass\">sol.common.ZipUtils</a></td><td><span\nstyle='font-weight:bold'>Hilfsfunktionen für die Verwendung und Erstellung von ZIP-Dateien</span></td></tr></tbody></table>\n\n\n<h2 id='pD1142BD3_E84D_4967_B5EC_A948C48729F7-section-funktionsklassen'>Funktionsklassen</h2>\n\n<p>Funktionsklassen erfordern eine Instanziierung mit dem gewünschten Kontext.</p>\n\n<table><thead><tr><td><span\nstyle='font-weight:bold'>Name der Klasse</span></td><td><span\nstyle='font-weight:bold'>Beschreibung</span></td></tr></thead><tbody><tr><td>    <a href=\"#!/api/sol.common.as.Mail\" rel=\"sol.common.as.Mail\" class=\"docClass\">sol.common.as.Mail</a></td><td><span\nstyle='font-weight:bold'>Hilft beim Versenden von E-Mails</span></td></tr><tr><td>    sol.common.as.OfficeDocument</td><td><span\nstyle='font-weight:bold'>Klasse zur Verwendung von Office-Dokumenten in ELOas</span><br />Enthält Implementierungen für Excel, Word, PowerPoint, Visio und Mapi.</td></tr><tr><td>    <a href=\"#!/api/sol.common.Config\" rel=\"sol.common.Config\" class=\"docClass\">sol.common.Config</a></td><td><span\nstyle='font-weight:bold'>Klasse zum Lesen und Schreiben von JSON-Konfigurationsdateien</span></td></tr><tr><td>    <a href=\"#!/api/sol.common.Locale\" rel=\"sol.common.Locale\" class=\"docClass\">sol.common.Locale</a></td><td><span\nstyle='font-weight:bold'>Klasse zum Auslesen der User Locales</span><br />Liefert Informationen, um benutzerspezifische Informationen zu laden, bspw. die Sprache oder die Dezimal-Separatoren.</td></tr><tr><td>    <a href=\"#!/api/sol.common.SordMap\" rel=\"sol.common.SordMap\" class=\"docClass\">sol.common.SordMap</a></td><td><span\nstyle='font-weight:bold'>Klasse zum Lesen und Schreiben von Map-Daten</span><br />Hilft beim Auslesen und Schreiben von Map-Daten für ein Sord-Objekt.</td></tr><tr><td>    <a href=\"#!/api/sol.common.UserProfile\" rel=\"sol.common.UserProfile\" class=\"docClass\">sol.common.UserProfile</a></td><td><span\nstyle='font-weight:bold'>Klasse zum Auslesen der Benutzerinformationen</span><br />Hilft beim Auslesen der Benutzereigenschaften aus dem User-Profil.</td></tr></tbody></table>\n\n\n\n","title":"Hilfsklassen"});
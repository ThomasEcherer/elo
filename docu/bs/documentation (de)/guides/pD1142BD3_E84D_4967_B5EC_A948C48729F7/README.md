# Hilfsklassen

Das Modul <span
style='font-weight:bold;font-style:italic'>Business Solutions Common</span> stellt eine Reihe von Hilfsklassen zur Verfügung, die für unterschiedliche Zwecke eingesetzt werden können.

Im Folgenden soll eine Auswahl an Klassen erwähnt werden. Die genaue Beschreibung und Anzahl aller Hilfsklassen  findet sich in der Scripting-Dokumentation.

## Übergreifende Kompatibilität von Skripten

Um eine übergreifende Kompatibilität von ELO-API-Aufrufen zu gewährleisten, wird ab ELO Version 9.03 einheitlich bspw. die Variable `ixConnect` für die Indexserver-Connection im Scripting gesetzt. 

## Utility-Klassen

Utility-Klassen sind Singletons und können ohne Instanziierung verwendet werden.

<table><thead><tr><td><span
style='font-weight:bold'>Name der Klasse</span></td><td><span
style='font-weight:bold'>Beschreibung</span></td></tr></thead><tbody><tr><td>    sol.common.AclUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Umgang mit Berechtigungen in ELO</span></td></tr><tr><td>    sol.common.as.BarcodeUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für die Verwendung von QR-Code und Barcodes</span></td></tr><tr><td>    sol.common.as.Utils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für die Vereinfachung von ELO AS Regeln</span></td></tr><tr><td>    sol.common.as.PdfUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Umgang mit PDF-Dokumenten</span></td></tr><tr><td>    sol.common.AsUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Umgang mit ELOas-Aufrufen</span></td></tr><tr><td>    sol.common.AsyncUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen um asynchrone Aufrufe zu synchronisieren</span></td></tr><tr><td>    sol.common.CounterUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für die Verwendung von Countern</span></td></tr><tr><td>    sol.common.DateUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Umgang mit Datumsformaten</span></td></tr><tr><td>    sol.common.ExceptionUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Umgang mit Index Server Exceptions</span></td></tr><tr><td>    sol.common.ExecUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Umgang mit lokalen Systemressourcen</span></td></tr><tr><td>    sol.common.FileUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Umgang mit lokalen und temporären Dateien</span></td></tr><tr><td>    sol.common.HttpUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen um Inhalte externer http-Quellen abzufragen</span></td></tr><tr><td>    sol.common.ix.DynKwlUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für dynamische Stichwortlisten</span><br />Vereinfacht das Befüllen von Daten mithilfe von dynamischen Stichwortlisten.</td></tr><tr><td>    sol.common.ix.RfUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für die Implementierung von Registered Functions</span><br />Vereinfacht u.a. das Parsen und Überprüfen von übergebenen Parameter-Werten.</td></tr><tr><td>    sol.common.IxUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Indexserver-Aufruf</span><br />Vereinfacht es u.a. Registered Functions aufzurufen.</td></tr><tr><td>    sol.common.JsonUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Umgang mit JSON-Daten</span><br />Vereinfacht das Serialisieren von JSON-Daten.</td></tr><tr><td>    sol.common.ObjectUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Umgang mit JS-Objekten</span></td></tr><tr><td>    sol.common.RepoUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Zugriff auf ELO-Elemente</span><br />Vereinfacht den Zugriff auf Elemente im ELO-Archiv.</td></tr><tr><td>    sol.common.SordTypeUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Umgang mit Sord-Objekttypen</span><br /></td></tr><tr><td>    sol.common.SordUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Umgang mit Sord-Objekten</span><br />Vereinfacht den Zugriff auf Informationen des Sords.</td></tr><tr><td>    sol.common.StringUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Umgang mit Zeichenketten</span></td></tr><tr><td>    sol.common.TranslateTerms</td><td><span
style='font-weight:bold'>Hilfsfunktionen für die Lokalisierung von Lösungen</span></td></tr><tr><td>    sol.common.UserUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Umgang mit Benutzerprofilen</span></td></tr><tr><td>    sol.common.WfUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Umgang mit Workflows</span><br />Vereinfacht den Zugriff auf Workflow-Knoten und ermöglicht es, diese zu bearbeiten.</td></tr><tr><td>    sol.common.XmlUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für den Aufbau von XML-Datenstrukturen aus JS-Objekten</span></td></tr><tr><td>    sol.common.ZipUtils</td><td><span
style='font-weight:bold'>Hilfsfunktionen für die Verwendung und Erstellung von ZIP-Dateien</span></td></tr></tbody></table>

## Funktionsklassen

Funktionsklassen erfordern eine Instanziierung mit dem gewünschten Kontext.

<table><thead><tr><td><span
style='font-weight:bold'>Name der Klasse</span></td><td><span
style='font-weight:bold'>Beschreibung</span></td></tr></thead><tbody><tr><td>    sol.common.as.Mail</td><td><span
style='font-weight:bold'>Hilft beim Versenden von E-Mails</span></td></tr><tr><td>    sol.common.as.OfficeDocument</td><td><span
style='font-weight:bold'>Klasse zur Verwendung von Office-Dokumenten in ELOas</span><br />Enthält Implementierungen für Excel, Word, PowerPoint, Visio und Mapi.</td></tr><tr><td>    sol.common.Config</td><td><span
style='font-weight:bold'>Klasse zum Lesen und Schreiben von JSON-Konfigurationsdateien</span></td></tr><tr><td>    sol.common.Locale</td><td><span
style='font-weight:bold'>Klasse zum Auslesen der User Locales</span><br />Liefert Informationen, um benutzerspezifische Informationen zu laden, bspw. die Sprache oder die Dezimal-Separatoren.</td></tr><tr><td>    sol.common.SordMap</td><td><span
style='font-weight:bold'>Klasse zum Lesen und Schreiben von Map-Daten</span><br />Hilft beim Auslesen und Schreiben von Map-Daten für ein Sord-Objekt.</td></tr><tr><td>    sol.common.UserProfile</td><td><span
style='font-weight:bold'>Klasse zum Auslesen der Benutzerinformationen</span><br />Hilft beim Auslesen der Benutzereigenschaften aus dem User-Profil.</td></tr></tbody></table>


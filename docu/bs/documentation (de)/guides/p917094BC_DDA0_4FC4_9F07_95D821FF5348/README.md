# Lösungsarchitektur

## Modularisierung

Lösungen werden inklusive der gesamten Konfiguration und aller Skripte in Paketen zusammengefasst. Dies hilft, bei der gegebenen Vielzahl an Skripten und Vorlagen den Überblick zu behalten und bildet den Namespace entsprechend ab.

Ein Paket sollte alle Skripte, Konfigurationen und Vorlagen enthalten, die von der Lösung benötigt werden. Somit kann die gesamte Lösung abschließend in ein Installationspaket gepackt und einfach auf unterschiedliche Systeme übertragen werden.

Lösungsübergreifende Funktionen sollten dabei in eigenen Paketen zusammengefasst werden, um wiederverwendbar zu sein. Bspw. finden sich <a
href="#!/guide/p0B6BCC8E_42D0_4EAE_BC44_F13016A4F81D">Aktionen</a> oder <a
href="#!/guide/p375A5383_1983_41BE_8BC4_B145CFACA792">dynamische Stichwortlisten</a> im Paket <span
style='font-weight:bold;font-style:italic'>common</span>, während der <a
href="#!/guide/">XML-Importer</a> im Paket <span
style='font-weight:bold;font-style:italic'>connector_xml</span> anzutreffen ist.

Im Folgenden werden Modularisierungsaspekte anhand der Lösung für den Rechnungseingang erläutert. Dabei stehen unterschiedliche Module (bspw. <span
style='font-weight:bold;font-style:italic'>common</span>, <span
style='font-weight:bold;font-style:italic'>connector_xml </span>oder <span
style='font-weight:bold;font-style:italic'>invoice</span>) zur Verfügung. Jedes Modul kann über die Installationsanleitung der Dokumentation einer Lösung installiert werden.

{@img img1.png Business Solutions 
—global 
e Checklist 
e Common 
common_tx 
common_monitoring 
common_signature 
connector_dx 
connector_xml 
contact 
development 
development_internal 
invoice 
D eloinst 
keywording forms 
D Configuration 
ELOapps 
D ELOas Base 
ELOwf Base 
D IndexServer Scripting Base}

Die Untergliederung der Module richtet sich im Kern nach der Gliederung des Ordners <span
style='font-weight:bold;font-style:italic'>Administration</span>. Jede ELO-Komponente erhält hier ihren eigenen Bereich. Skripte des Moduls werden anschließend dort abgelegt und an die Originalstelle referenziert. Während der Installation geschieht das durch das Installationspaket.

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Indexserver-Skripte werden im Standard unter </span><span
style='font-weight:bold;font-style:italic'>Administration\Index Server Scripting Base\All\</span><span
style='font-style:italic'> abgelegt. Da Lösungen aus einer Vielzahl von Skripten bestehen, werden diese für die E-Akte unter </span><span
style='font-weight:bold;font-style:italic'>Administration\Business Solutions\invoice\Index Server Scripting Base\</span><span
style='font-style:italic'> abgelegt und nach </span><span style='font-weight:
bold;font-style:italic'>Administration\Index Server Scripting Base\All\business solutions\</span><span
style='font-style:italic'> verlinkt. Entwickler haben somit schnell einen Überblick, welche Lösung welche Skripte beinhaltet.</span>

Der Aufbau der Unterstruktur eines Pakets ist erweiterbar, sollte jedoch einem Namensschema folgen.

<table><thead><tr><td><span
style='font-weight:bold'>Name des Ordners</span></td><td><span
style='font-weight:bold'>Beschreibung</span></td><td><span
style='font-weight:bold'>Namespace</span></td></tr></thead><tbody><tr><td>.eloinst</td><td><span
style='font-weight:bold'>Konfiguration für die Erstellung von Installationspaketen</span></td><td></td></tr><tr><td>.keywording forms</td><td><span
style='font-weight:bold'>Von der Lösung benötigte Verschlagwortungsmasken</span><br />Für jede Verschlagwortungsmaske sollte ein Ordner /  leeres Dokument angelegt werden, welches die Maske trägt, damit diese beim Im-/ Export übertragen wird.</td><td></td></tr><tr><td>All</td><td><span
style='font-weight:bold'>Skripte für alle ELO-Module</span><br />Diese Skripte werden in alle Scripting-Verzeichnisse der ELO-Komponenten referenziert.</td><td>    sol.invoice</td></tr><tr><td>All Rhino</td><td><span
style='font-weight:bold'>Skripte für alle ELO-Module, welche auf der Rhino-Engine aufsetzen</span><br />Diese Skripte werden in alle Scripting-Verzeichnisse der betroffenen Module referenziert, bspw. für ELOas, Java Client, Indexserver.</td><td>    sol.invoice</td></tr><tr><td>Configuration</td><td><span
style='font-weight:bold'>Konfigurationsdateien für ein Lösungspaket</span></td><td>    sol.invoice</td></tr><tr><td>Resources</td><td><span
style='font-weight:bold'>Ressourcen der Lösung</span><br />Hier können benötigte Dateien, bspw. Bilder oder Templates, abgelegt werden.</td><td>    </td></tr><tr><td>ELOapps</td><td><span
style='font-weight:bold'>Skripte für die ELO-Apps</span></td><td>    sol.invoice.apps</td></tr><tr><td>ELOas Base</td><td><span
style='font-weight:bold'>Skripte für den ELOas</span></td><td>    sol.invoice.as</td></tr><tr><td>ELOwf Base</td><td><span
style='font-weight:bold'>Vorlagen und Skripte für den Formular-Workflow</span></td><td>    sol.invoice.wf</td></tr><tr><td>Index Server Scripting Base</td><td><span
style='font-weight:bold'>Skripte für den Indexserver</span></td><td>    sol.invoice.ix</td></tr><tr><td>Java Client Scripting Base</td><td><span
style='font-weight:bold'>Skripte für den Java Client</span></td><td>    sol.invoice.jc</td></tr><tr><td>Webclient Scripting Base</td><td><span
style='font-weight:bold'>Skripte für den Web Client</span></td><td>    sol.invoice.web</td></tr></tbody></table>

## Metadaten für ein Modul

Module sollten mit der Verschlagwortungsmaske <span
style='font-weight:bold;font-style:italic'>ELO Business Solution</span> abgelegt werden. Dies erlaubt die zusätzliche Angabe einer Versionsnummer und einer <span
style='font-style:italic'>build</span>-Nummer, die während der Erstellung von <a
href="#!/guide/p0A73BAFE_D273_48DC_8AAB_55939E71BB61">Installationspaketen</a> hochgezählt wird.

{@img img3.png Verschlagwortung 
M a skenauswahl 
Akte Struktur 
Basic Entry 
Eingangsrechnung 
O Business 
ELO user Entry 
ELOScnpts 
Folder 
Laufmappe 
Teilakte Personal 
Vorgang 
Basis Zusatztext 
Kurzbezeichnung 
Ablagedatum 
Optio nen 
commod 
Berechtigungen 
Änderu n gs chronik 
Wettere Infos 
Admin istrator 
Aktuelle Version 
Bearbeiter 
1809201s 1148 
Stichwortliste automatisch au Mappen O}

## Namensgebung von Dateien im Archiv

Die Namensgebung von Skripten erlaubt, zusätzliche Bibliotheksfunktionen (bspw. Hilfsklassen) von verwendbaren Implementierungen (bspw. dynamischen Stichwortlisten, Aktionen oder Services) zu trennen.

Klassen, die inkludiert werden dürfen, sollten hier `lib_` als Präfix tragen. Da alle Klassen später unterhalb des Ordners <span
style='font-weight:bold;font-style:italic'>Administration\Index Server Scripting Base</span> referenziert werden, sollte zusätzlich der Namespace mit in den Skriptnamen aufgenommen werden.

<table><thead><tr><td><span
style='font-weight:bold'>Anwendungsfall</span></td><td><span
style='font-weight:bold'>Schema</span></td></tr></thead><tbody><tr><td>Endgültige Implementierungen<br />(bspw. Aktionen)</td><td>Namespace.Klassenname</td></tr><tr><td>Bibliotheksklassen<br />(bspw. Hilfsklassen)</td><td>lib_Namespace.Klassenname</td></tr></tbody></table>

Einige Beispiele aus der Lösung <span
style='font-style:italic'>Business Solutions Invoice</span> (Untereinträge von <span
style='font-weight:bold;font-style:italic'>Administration\Business Solutions\invoice\Index Server Scripting Base</span>):

{@img img5.png IndexServer Scripting aase 
Dynamic Keyword Lists 
sol invoice ix dynkwl Currency 
sol invoice ix dynkwl Item 
sol invoiceix dynkwl Project 
sol invoice ix dynkwl TermsOfPayment 
sol invoice ix dynkwl TradeCharge 
sol invoice ix dynkwl Units 
Func tions 
sol invoice ix functions Changel_lser 
sol invoice ix functions CreateApprovaINodes 
sol invoice ix functions DefauttVaIues 
sol invoiceix functions ExchangeRates 
lib sol invoice Converter 
lib sol invoice Currency 
lib solinvoiceix Invoice}

## Modularisierung von Konfigurationen/ Erweiterungen

ELO Business Solution stellen für jedes Paket sogenannte &quot;<span
style='font-weight:bold;font-style:italic'>Custom Pakete</span>&quot; bereit. Ein Custom Paket enthält dabei alle notwendigen Konfigurationsmöglichkeiten einer Lösung. Dies erlaubt es die Code-Basis von der Konfiguration zu trennen um zukünftige Updates einzuspielen.

{@img img7.png „ Business Solution Custom 
contract 
„ Business Solutions 
_global 
Checklist 
common 
e 
common fx 
e 
common_monitoring 
e 
common_signature 
e 
connector 
connector_xml}
{@img img9.png Involce 
invoice [Default connectorsl 
invoice [DocXtractor connectorsl}

<span class="tag_important">Für jedes Paket gibt es, falls sinnvoll, ein Custom Paket. Sollten diese Pakete nicht auf den Installationsseiten verlinkt sein müssen diese nicht installiert werden. Sie können aber über die Einzeldownloads (Supportweb) bezogen werden.</span>



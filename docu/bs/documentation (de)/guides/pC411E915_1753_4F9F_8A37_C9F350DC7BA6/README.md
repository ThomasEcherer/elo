# Erweitern von ELO Business Solutions/ Support

<span class="tag_caution">Erweiterungen und Funktionsänderungen dürfen nicht in den JavaScript-Klassen der <span
style='font-style:italic'>Business Solutions</span>-Pakete vorgenommen werden. Hierzu stehen gesonderte Custom-Pakete bereit. Änderungen an den Kernkomponenten verhindern die Updatefähigkeit einer Lösung. In diesem Fall erlischt auch der Supportanspruch.</span>

<span
style='font-style:italic'>Business Solutions</span> implementieren unterschiedliche Konzepte, um bestehende Logik anzupassen. Wenden Sie sich bei Fragen bitte an das<span
style='font-style:italic'> Business Solutions</span>-Team.

## Einsatz von Custom-Paketen

Eine Lösung ist in unterschiedliche Pakete eingeteilt, welche wiederum zusätzlich Custom-Pakete enthalten. Mithilfe dieser Custom-Pakete kann eine Lösung hinsichtlich der Konfiguration oder bspw. verfügbaren Aktentypen angepasst werden. Sind die Developer Tools installiert kann aus jedem Custom Paket zusätzlich eine Installationsdatei erzeugt werden. Somit lassen sich alle Änderungen für einen Kunden bequem vom Entwicklungssystem zum Kunden transportieren.

{@img img1.png „ Business Solution Custom 
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
{@img img3.png Involce 
invoice [Default connectorsl 
invoice [DocXtractor connectorsl}

<span class="tag_important">Tipp: Mithilfe von Custom-Paketen können zudem Standard-Konfigurationen für unterschiedliche Anwendungsfälle geschaffen werden. Bspw. &quot;Vertragsmanagement - Immobilienverwaltung&quot;.</span>

In einem Custom-Paket findet sich meist ein komplettes Abbild der Konfiguration. Nachfolgend am Beispiel des Invoice-Custom-Paketes. Konfigurationsdateien sind dabei leer und tragen lediglich die Änderungen zur Basiskonfiguration. 

{@img img5.png Involce 
eloinst 
Configuration 
Dashboard-Data 
Export Templates 
as config 
sohinvoicæconfig 
sohinvoiceExportConfig 
sohinvoice]nvoiceXmllmpoNConfig 
soLinvoiceLocalizedKwlsconfig 
soLinvoiceWorkflowUserRolesconfig 
ELOapps 
ELOwf Base 
Invoice Templates}

Die Konfigurationsseiten der Lösung visualisieren diesen Vorgang und zeigen an, für welche Einstellungen Änderungen vorgenommen worden sind. Nachfolgend am Beispiel der Konfiguration sol.invoice.config.

{@img img7.png Invoice Config 
General 
General settings 
Default 
Default 
Default 
XML import 
General 
user interface 
Workflow 
/Invoice/Entry 
Expert mode 
Initial filing path 
Filing path in the repository 
Filing path invoice templates 
File invoice as a container 
O 
0 sord_objKeys. VENDOR_NAME 0 
Solutions Custom/invoiceycontiguration/lnvoice Templates}

## Erweiterungen von JavaScript-Klassen

Weiterentwicklungen sollten dabei ebenfalls in das Custom-Paket gelegt werden, damit diese mit dem gleichen Mechanismus portiert werden können.

Skripte/ Änderungen sollten anschließend an die entsprechenden Stellen referenziert werden. Dies ermöglicht auch das Erstellen eigener Installationspakete, um vom <span
style='font-style:italic'>Business Solutions</span>-Standard abweichende Änderungen in das System einzuspielen.

JavaScript-Klassen müssen in einem eigenen Namespace liegen, bspw. `partner.invoice.ix`  
Siehe hierzu auch <a
href="#!/guide/p225231D5_0733_4F82_8228_A54C4A60E920">Namespaces</a>.

<span class="tag_caution">Der Namespace<span
style='font-weight:bold'> `sol`</span> darf nur von <span style='font-style:
italic'>Business Solutions</span> verwendet werden. Eigene Klassen in diesem Namespace kollidieren eventuell mit Änderungen zukünftiger Versionen.</span>

## Änderungen an technischen Abläufen

Technische Abläufe werden in <span
style='font-style:italic'>Business Solutions</span> soweit sinnvoll mithilfe von Workflow-Funktionsbausteinen realisiert. Ist eine eigene Logik gewünscht, kann der Workflow an die Projektanforderung angepasst werden.

Funktionsbausteine tragen hierzu eine Konfiguration im Knoten-Kommentar und können auch leicht entfernt werden. 
Siehe hierzu auch <a
href="#!/guide/pADD870BA_9AA2_4900_8D6B_FA0FB26D9BEC">Funktionsbausteine</a>.

Soll nach der Extraktion von ZUGFeRD-Daten bspw. kein Feed-Beitrag geschrieben werden, kann der markierte Knoten einfach entfernt werden. Ist eine andere Nachricht erwünscht, legen Sie eine eigene Sprachdatei in das Verzeichnis <span
style='font-weight:bold;font-style:italic'>Administration\Localization\custom\</span> und passen Sie die Knotenkonfiguration entsprechend an.

{@img img9.png STATUS: 1 Data analysis 
FEEOCOMMENT : start invoice approval 
CHANGECOLOR : Unprocessed invoice 
r•e::' ZUGFeR0 
ELO Service 
ZUGFeRO data extracted? 
INVOICE DATACOLLECT10N-ZUGFeRD 
OOCXtractor? 
FEEOCOMMENT : 
ELO WF STATUS-OX ENAaLED 
FEEOCOMMENT : ZUGFeR0 
ox export 
ELO Service 
STATUS : 2 Formal check 
OX Rejected? 
ox Doc CLASS-InvoiceJReject 
DEFAULTVALUES : Apply defaults 
CHANGEUSER : Formal check 
OX response 
ELO Service}

Reichen die bestehenden Funktionsbausteine nicht aus um die Anforderungen hinreichend abzudecken, können eigene Funktionsbausteine geschrieben werden. 

<span class="tag_important">Es empfiehlt sich den Workflow zu kopieren und den neuen Namen in der Konfiguration des Custom-Pakets zu hinterlegen. Für alle technischen Workflows steht hierfür eine Einstellung zur Verfügung.</span>

## Formularbausteine erweitern

<span class="tag_important">Ab ELO 10.01 können Formulare der Business Solutions direkt im Formulardesigner bearbeitet werden. Änderungen werden dabei automatisch im Custom-Paket abgelegt und sind weitgehend Updatefähig.</span>

Formulare können einfach erweitert werden. Änderungen an den<span
style='font-style:italic'> Business Solutions</span>-Formularen sollten jedoch in einem eigenen Template vorgenommen werden. Klonen Sie hierzu das bestehende Template, platzieren Sie es in ein eigenes Modul und referenzieren Sie es in das Formular.

{@img img11.png Formulardesigner 
Formular 
Formulare 
eloinvoice 
test 
Template 
Tabelle 
EI Tab-Gruppe 
Aktualisieren 
Preview 
Schließen 
a-usteir,e einfügen 
Neues Template anlegen 
S','5tem 
Zu dem aktuell ausgewählten Formular wird nun ein neues Template angelegt. 
Verwenden Sie nur Buchstaben, Ziffern und den Unterstrich, der Name darf 
keine Umlaute oder Sonderzeichen enthalten und maximal 30 Zeichen lang 
sein. Ein Punkt "_" wird als Separator für Mobile Ansichten verwendet und 
sollte deshlab nicht Teil des Namens sein. 
Kopieren von 
Template Name 
inv03 vendor au 
custom03 vendor a 
inv04_in'Æice date appr_mobile}

## Logik bestehender JS-Klassen erweitern

Trifft eine Klasse nicht die Projektanforderungen, erzeugen Sie eine Sub-Klasse und überschreiben die gewünschten Properties/ Funktionen. Dies ist hilfreich, falls bspw. SQL-Abfragen der bereitgestellten Stichwortlisten modifiziert werden müssen.

## Bugfixes

Fehler gefunden? Dieser darf selbstverständlich behoben werden. Änderungen bitte über den Support an das <span
style='font-style:italic'>Business Solutions</span>-Team weiterleiten, damit wir diesen auch im Kernprodukt beheben können. Das <span
style='font-style:italic'>Business Solutions</span>-Team freut sich über jegliche Verbesserungsvorschläge! :)

## Änderung an Business Solutions JavaScript-Dateien

In einigen Fällen sind Änderungen an Basis-Klassen notwendig um mit vertretbarem Aufwand Anpassungen vorzunehmen. Beispiele hierfür sind bspw. <span
style='font-weight:bold'>vorhandene Dynamische Stichwortlisten</span>.

Einzelne Dateien können ebenfalls im Custom Paket überschrieben werden. In diesem Fall muss wie folgt vorgegangen werden.

1.   Kopieren Sie das gewünschte Script vom Basis-Paket in das Custom Paket an die selbe Stelle. (Bspw. `Business Solutions\contract\Index Server Scripting Base\sol.contract.MyDynKwl` nach `Business Solutions\contract\Index Server Scripting Base\sol.contract.MyDynKwl`.
2.   Prüfen Sie ob in der Installationsroutine des Custom-Pakets die Referenzen ebenfalls angelegt werden. (`.eloinst\install`)
3.   Referenzieren Sie das Custom-Script an die richtige Stelle (Bspw. `Administration\Index Server Scripting Base\business solutions\`) und entfernen die Referenz aus dem Original-Paket.

Installationspakete ab Version 1.02.002 (oder mit den Developer-Tools ab Version 1.02.002 erstellte Pakete) erkennen dies und behandeln Referenzen aus dem Custom Paket priorisiert. Wird ein Update ausgeführt wird das zugehörige Script aus dem Basis-Paket nicht in den entsprechenden Bereich referenziert. Beim Einspielen eines Individuellen Custom-Pakets nimmt das Setup während der Installation ebenfalls Schritt 3 vor und entfernt die Referenz des Scripts aus dem Basispaket.

<span class="tag_caution">Änderungen an internen Klassen der <span
style='font-style:italic'>Business Solutions</span>-Module sind nicht erwünscht und sorgen für einen erhöhten Aufwand in der Projektrealisierung. Technologie-Module wie bspw. <span
style='font-weight:bold;font-style:italic'>common</span>,<span
style='font-weight:bold;font-style:italic'> connector</span> etc. dürfen keinesfalls verändert werden, da diese ebenfalls Abhängigkeiten zu anderen <span
style='font-style:italic'>Business Solutions</span> aufweisen. Sollten dennoch Änderungen an den Basisklassen der Lösung erforderlich sein, führt dies zu Problemen mit Updatefähigkeit und Support. In diesem Fall muss eine Änderungshistorie der Klassen gepflegt werden, damit bei Updates der frühere Zustand wiederhergestellt werden kann.</span>

<span class="tag_important">Es empfiehlt sich, modifizierte Klassen ebenfalls mit einer Farbe zu markieren (bspw. rot).</span>







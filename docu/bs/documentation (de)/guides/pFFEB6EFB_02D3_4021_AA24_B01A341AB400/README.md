# Prozesslogik & Best Practices

Die Prozesslogik der Lösung beschreibt einen Best-Practice-Ansatz, wie Prozesse im Unternehmen modelliert werden können. Im Kern profitieren somit neue Kunden von Optimierungen bestehender Projekte und starten mit einer soliden Ausgangsbasis.

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Im Rechnungseingangsumfeld zeichnet sich der Rechnungsumlauf meist durch die Schritte </span><span
style='font-weight:bold;font-style:italic'>Automatische Datenextraktion</span><span
style='font-style:italic'>,</span><span style='font-weight:bold;font-style:
italic'>  Formelle Prüfung</span><span style='font-style:italic'>,</span><span
style='font-weight:bold;font-style:italic'> Fachliche Freigabe </span><span
style='font-style:italic'>und</span><span style='font-weight:bold;font-style:
italic'> Vorkontierung</span><span style='font-style:italic'> aus, bevor die Rechnung an das ERP-System übergeben wird. Um diesen Prozess optimal im Standard zu unterstützen, wurden eine Reihe technischer Konzepte implementiert. </span>

Da es aufgrund unterschiedlicher Anforderungen im Unternehmen kaum möglich ist, einen für alle Anwendungsfälle passenden standardisierten Prozess zu entwerfen, wurden Mechanismen geschaffen, die es ermöglichen, schnell und modular Änderungen am Prozessablauf durch ELO-Bordmittel vorzunehmen.

## Modularisierung von Workflow-Formularen

Die gesamte Datenerfassung, sei es über Dialoge im Client oder eine Freigabe bspw. im Rahmen des Rechnungseingangsprozesses, findet mithilfe von ELOwf-Formularen statt. Diese werden in kleine Bausteine mit unterschiedlichen Ausprägungen gesplittet und können für unterschiedliche Anwendungsszenarien zusammengestellt werden.

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Im Rechnungseingangsumfeld sollen für die </span><span
style='font-weight:bold;font-style:italic'>Formelle Prüfung</span><span
style='font-style:italic'> alle Kreditordaten angezeigt werden. Jedoch werden für den Freigabeschritt lediglich die Kreditornummer und der Kreditorname benötigt. Hierfür gibt es mehrere Kreditor-Bausteine die in den einzelnen Anwendungsfällen eingesetzt werden können.</span>

{@img img1.png New line 
New column 
Kreditornummer 
Delete row 
Delete column 
Input 
T Text 
Kreditorname 
Editor 
Marker 
Button 
Insert Content 
Steuernummer 
Selection 
Combo 
Delete 
Connect 
Disconnect 
Properties of the selected cell 
cut 
Insert 
B save 
Apply 
Cancel 
Table 
Field type 
Variable name 
Keyword list 
Group name 
Display 
Tooltip 
Validation 
Formula 
Character count 
Form columns 
Input 
VENDOR_NO 
V Autofill 
Only list Values allowed 
input100 
Read-on Iy 
Straße & Hausnummer 
Land / PLZ / Ort 
ust. 
08}

Formulare setzen sich dabei aus einer Reihe von Bausteinen zusammen. Über den ELOwf-Formulardesigner können diese Bausteine nicht nur einfach angepasst, sondern auch zu einem Gesamtformular zusammengeführt werden.

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Besteht in einem Projekt die Anforderung, dass die Buchhaltung während des Rechnungsumlaufs zusätzlich Projektdaten zur Rechnung erfassen soll, kann dieser Baustein mit wenigen Mausklicks dem Formular hinzugefügt werden.</span>

{@img img3.png Edit tab group 
Tab ID 
Tabs 
S 14 UStG 
nting 
Add component 
rm design 
inv02_company_aII 
inv03 vendor all 
inv06 due all 
Start element}

## Prozessdokumentation über den Feed

Die <span
style='font-weight:bold;font-style:italic'>ELO Social Components</span> bieten eine neue Form der Kollaboration innerhalb laufender Prozesse. Mit dem Dokumentenfeed steht eine einfache Möglichkeit bereit, nach den Prinzipien des Enterprise 2.0 zu kommunizieren.  Diese Art der Dokumentation von Prozessen sorgt für ein ultimatives Maß an Transparenz.

Ziel ist es, den Benutzern in chronologischer Form den bisherigen Ablauf zu illustrieren und ihnen die Möglichkeit zu geben, kollaborativ einzugreifen.

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Eine Rechnung befindet sich im Umlauf. Der Benutzer </span><span
style='font-weight:bold;font-style:italic'>Lagneaux</span><span
style='font-style:italic'> gibt die Rechnung frei, jedoch erfolgt die Bezahlung erst zu einem späteren Zeitpunkt, wodurch die Skontofrist verpasst wurde.</span>

{@img img5.png Lagneaux hat die Rechnung bezahlt. 
Rechnungsbetrag: 2035,05 E. 
Verpasste Skonto: 40,00 É 
8. Jul. 2014, 9:20 Uhr 
Nils Mosbach 
Nachstes Mal bitte auf Einhaltung der 
Skonto-Frist achten. 
vor einer Stunde 
Schreiben Sie einen Kommentar 
Lagneaux hat die Rechnung freigegeben. 
zugehörige Bestellung: PO 2015010322. 
8. Jul. 2014, 9:20 Uhr 
Schreiben Sie einen Kommentar 
Lag neaux}


## Funktionsbausteine

Funktionsbausteine ermöglichen es, technische Abläufe in den Prozess zu integrieren, um somit auf Kundenanforderungen schneller eingehen zu können. So kann bspw. das Schreiben eines Feed-Beitrags über Funktionsbausteine ohne großen Aufwand direkt im Prozess durch Hinzufügen eines eigenen Bausteins <span
style='font-weight:bold;font-style:italic'>Feed-Ereignis schreiben</span> realisiert werden.

Für kleine Anpassungen der Prozesslogik kann somit auf Scripting verzichtet werden, da Funktionen konfiguriert werden können.

Im Standard stehen eine Vielzahl von Bausteinen zur Verfügung, bspw. <span
style='font-weight:bold;font-style:italic'>Schwärzung einbrennen</span>, <span
style='font-weight:bold;font-style:italic'>Elementfarbe ändern</span> oder <span
style='font-weight:bold;font-style:italic'>Metadaten übernehmen</span>.






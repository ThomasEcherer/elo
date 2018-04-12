# Lokalisierung

Lokalisierung ist ein wichtiges Hilfsmittel ELO Business Solutions in mehreren Ländern anzubieten oder Multinationalen Konzernen die Möglichkeit zu geben Auslandsniederlassungen mit der gleichen Lösung zu versorgen.

<span class="tag_warning">Die Übersetzungstabellen bieten in ELO einen altbewährten Mechanismus einzelne Wörter zu lokalisieren. Dieser Mechanismus kommt in den ELO Business Solutions nicht zum Einsatz. Vielmehr wurden neue Möglichkeiten geschaffen die auf Basis von sogenannten Properties-Dateien optimal mit Übersetzungsbüros einsetzbar sind.</span>

## Lokalisierung durch Sprachdateien über den Index Server

Im Administrations-Ordner befindet sich ab ELO Version 9.3 zusätzlich die Möglichkeit properties-Dateien direkt im Archiv abzulegen. Diese sind im Ordner `Localization` zu hinterlegen. 

{@img img1.png oc alization 
custom 
system 
text sol contract 
text sol contract DE}

Standard-Komponenten wie bspw. die ELO Business Solutions finden sich im Ordner `system`. Dieser darf nicht zu Anpassungen der Lösungen oder für eigene Projekte eingesetzt werden. Business Partner können eigene Lokalisierungsinformationen im Ordner `custom` hinterlegen.

Der Vorteil hierin liegt in der Priorität wie die Lokalisierung geladen wird. Somit ist es möglich Übersetzungen des Ordners `system` im `custom` Ordner zu überschrieben. Die Funktion <span
style='font-weight:bold'>Akte anlegen</span> kann somit einfach in <span
style='font-weight:bold'>Dossier anlegen</span> umbenannt werden um somit auch auf Schweizer Verhältnisse einzugehen.

Properties Dateien sind dabei lediglich Schlüssel-Wert-Zuweisungen. Die hinterlegten Schlüssel können anschließend als <span
style='font-weight:bold'>locale keys</span> verwendet werden.

{@img img3.png Quick Edit 
Ak tuelle Bearbeitung 
Clients 
sol. contract. cl i ent. solution. name—Vertragsmanagement 
sol. contract. cl i ent. ri bbon. tabContract—Verträge 
sol. contract. cl i ent. ri bbon. bandCreate—4nl egen 
sol. contract. cl i ent. ribbon . bandEdit—3earbei ten 
sol. contract. cl i ent. ribbon . bandReports—8eri chte 
sol. contract. cl i ent. ribbon. bandDocuments—Dokumente 
Vergleich 
Auschecken 
2 
3 
4 
5 
6 
7 
8 
9 
13}

Nachfolgend sollten einige Verwendungsmöglichkeiten erläutert werden.

### Workflows

Workflow-Knoten können ebenfalls über locale keys Lokalisiert werden. Hierzu dient das Feld `Übersetzungsvariable` wo die Schlüssel hinterlegt werden können.

{@img img5.png Workflowdesigner 
Vorlagen 
solcontactcompanycreate 
solcontactcontactcreate 
solcontactcontactlistcreate 
soLcontract contract approval 
soLcontractcontractcancelNegotiatior 
solcontractcontractconclude 
sol.contractcontractcreate 
solcontractcontractnegotiate 
solcontractcontracttermnation 
solcontractdocumentcreate 
soLhrdocumentcreate 
Workflow-Vorlage bearbeiten 
sol.contract.contract.create 
Eigentümer 
Data entry 
Eigentümer 
create 
MOVE : contract 
GENERATOR : contract no. 
GENERATOR : short description 
FEED : contract created 
Cancel 
DELETE : temporary record 
Knotenbezeichnung 
Interne Bezeichnung 
Data entry 
Ubersetzungsvariable 
sol.contractnode.dataEntry 
Bezeichnung beim Weiterleiten 
Übersetzungsvariable 
Eskalationsmanagement 
Weitere Optionen 
Übernehmen 
Abbrechen 
Neu 
Versionen (1) 
Laden 
POE-Ausgabe 
Kopieren 
Berechtigungen 
Speichern 
Löschen 
O Vorlage-ID: 107, Version: 111 (Arbeitsversion), Knoten-ID: 1}

<span class="tag_important">Der Workflow-Name kann über den Start-Knoten lokalisiert werden.</span>

### Verschlagwortungsmasken

Die AdminConsole bietet für das Maskendesign zusätzlich eine Vielzahl von Lokalisierungsoptionen an. Beispielsweise für den Namen einer Verschlagwortungsmaske.

<span class="tag_caution">Achtung: Maskennamen werden zwar übersetzt im Client angezeigt ein Zugriff über die Index Server API ist aber nur durch Angabe des Namens (Keywording form name) möglich. Aus diesem Grund ist es notwendig stets den <span
style='font-weight:bold'>Original-Namen</span> und einen <span
style='font-weight:bold'>locale key</span> anzugeben.</span>

{@img img7.png ELO Administration Console Keywording forms contract 
selected keywording form Contract 
Contict 
rding 
Contrect 
an tract. mask.antract 
En c O' ption 
HR Occum 
'v@rtægyS t 
antract. 
antract. 
ent antents to full 
thor function 
Short narne 
ref r 
for 
ument Status 
System CO I o r 
n activated / Alphabeti.l 
ENO ENCRYPTION) 
OK 
x 
colle 
Contrect 
ELO a 
ELO a 
Ela 
ELO u 
El_cscriptE 
Folder 
cu ion 
Sta n d a rd 
ENO WORKFLOW) 
Keywoæing form 
form 
Filing 
L ifet i m 
Filing def 
ument rights 
8 
Apply 
rights 
ontract. m in 
u 
Enable quick p 
Folder 
in the 
Folder form 
u}

{@img img9.png ELO Administration Console Keywording forms contract 
x•OeAdd or edit index fields for keywording form. 
• Contract 
Field i nfo r 
Solution Type 
n ut length 
OK 
Delete 
x 
x 
Min. input length 
n put type 
CODE 
COMPANY 
tu m 
El_liinei_ 
Ve rt styp 
'v@rhgltnis}

### Formularen

Formulare lassen sich durch die Lokalisiserungsmechanismen des Index Servers vollständig in unterschiedlichen Sprachen anbieten. Hierzu müssen lediglich die<span
style='font-weight:bold'> locale keys</span> im Formular hinterlegt werden.

Dies erlaubt es die Titelleisten der Tab-Gruppen zu übersetzen, 

{@img img11.png Tab-Gruppe bearbeiten 
Tab-ID 
Tabs 
Uberschrift 
contract form 
Baustein hinzufügen 
Startelement 
110 contract_general all 
111 contract company all 
120 contract_partner all 
130 contract data all 
140 contract_proJect all 
150 contract duration all 
160 contract subjectmatte 
180 contract_paymentplan}

… oder beliebige Texte im Formular.

{@img img13.png Neue Zeile 
Neue Spalte 
Tabelle 
sol. 
Zeile löschen 
Spalte löschen 
— Eingabe 
Datum 
T Text 
Editor 
Markierung 
Schalter 
Inhalteinfügen 
Auswahl 
Combo 
Link 
Löschen 
verbinden 
Trennen 
Ausschneiden 
Kopieren 
Einfügen 
Speichern 
Übernehmet 
X Abbrechen 
Syste m 
Eigenschaften der ausgewählten Zelle 
Feldty p 
Text 
Variablenname 
Stichwortllste 
URL 
Darstellung 
Tooltip 
Validierung 
Validation message 
Formel 
Tastenkürzel 
sol.contractform_type 
sol. contract_form_ relation 
sol. contract.form filingLocation 
sol.contractform_status}

## Lokalisierung von Client-Scripting

Für die Lokalisierung von Scripten im Client stehen unterschiedliche Konzepte bereit.

### Java Client Scripting

Lokalisierungen im Java Client sind durch Standard-Mechanismen im Java Client möglich. Hierzu muss die Sprachdatei (Properties-Datei) im Scripting Base Ordner des Java Clients abgelegt werden.

Über das Java Client Scripting kann anschließend auf Locale keys einer Datei zugegriffen werden.

<span class="tag_important">Hier kommt nicht der Lokalisierungsmechanismus des Index Servers zum Einsatz. Die Dateien unterhalb des Lokalization-Ordners können aber in das Java Client Scripting Base Verzeichnis referenziert werden. Somit stehen sie in beiden Umgebungen zur Verfügung.</span>

### Web Client Scripting

Im Web Client Scripting muss vom Script angegeben werden, welche Lokalisierungen benötigt werden. Hierzu dient die Funktion `api.require`. Der Web Client ruft beim Start anschließend den Lokalisierungsmechanismus des Index Servers  auf und lädt die benötigten Informationen. Weitere Informationen zum Web Client Scripting können der Web Client API Dokumentation entnommen werden.

    api.require({
        locales: ['sol.contract.client']
    }, function (localesObject) {
        console.log('requirements are fulfilled');
    });

Dieser Mechanismus stellt sicher, dass lediglich Schlüssel geladen werden die vom Scripting auch benötigt werden.

## Lokalisierte Stichwortlisten

Für die Lokalisierung von Stichwortlisten stellen die ELO Business Solutions einen eigenen Lokalisierungsmechanismus bereit. Dabei wird jedem Stichwort ein zugehöriger Schlüssel zugewiesen. Das Stichwort wird an den Client anschließend lokalisiert zurückgegeben.

Folgende Abbildung zeigt das am Beispiel der Belegart in der ELO Business Solution Invoice. Der Schlüssel `D1` steht hier für `Mahnung 1`.

{@img img15.png Rechnungsdaten 
o 
S 14 UStG 
0027 
2 - Formelle Prüfung 
IN - Rechnung 
Schlüssel Beschreibung 
IN 
Mahnung I 
Positionsdaten 
umsatzsteuerkonform nach S 14 UStG 
Allgemein 
Bezeichnung 
Beleg art 
Ma nda nt 
Kunden AG Mitte 
Mandant 
Buchungskreis 
Mahnung 2 
Gutschrift 
Kreditor}

In die Metadaten des Objektes wird eine Kombination aus beiden Werten geschrieben. In diesem Beispiel `D1 - Mahnung 1`. Im Scripting kann anschließend der Schlüssel extrahiert werden und sprachunabhängige Operationen ausgelöst werden.

Zugrunde liegt eine <span
style='font-weight:bold'>Dynamische Stichwortliste</span>, welche die Schlüssel-Wert-Paare aus einer Konfiguration lädt und beispielsweise im Formular oder Client anbietet.

Eine Konfigurationsoberfläche erleichtert dabei das Hinzufügen und umbenennen von Stichworten.

{@img img17.png ELO invoice 
DOKUMENT 
ANSICHT 
Archiv 
Aufgaben 
Klemmbrett 
Bearbeitung 
Suche 
Nils Mosbach • 
START 
AUFGABEN 
Nach Funktion suchen 
sol.invoice.LocaIizedKwIs.Config 
Localized Keyword List Config 
Speichern unter 
LocalizedKwtsConfig QuickEdit Dokument Feed 
Speichem 
Business Solutions 
Common 
Common fx 
common_monitoring 
Connector dx 
Connector xml 
development 
t» development internal 
eloinst 
keywording forms 
Configurat'on 
as config 
sol invoice Config 
sol invoice ExportConfig 
sol invoice InvoiceXmIImportConfig 
sol invoice LocaIizedKwIs Config 
sol invoiceWorkflowlJserRoIes Config 
Dashboard-Data 
Eine lokalisierte Stichwortliste besteht aus einer Anzahl von allgemeinen Schlüsselbezeichnungen mit dazu passenden lokalisierten Textvwerten_ Der Schlüssel wird 
hierbei test vergeben, während der Wert als Lokalisierungsschlüssel hinterlegt ist. 
Titel Spaltenwert 
sol.invoice.localizedKwlstatus.headecvalue 
status 
docTy pe 
StichMWthste: status 
Tabellen Titel 
Spaltenüberschritten 
Schüssel 
sol.invoice.localizedKwlstatustableTitle 
Titel Spaltenschlüssel 
sol.invoice.localizedKwlstatus.headeckey 
solinvoiceIocaIizedKwIstatus entry manuaIEntry}

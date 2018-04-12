Ext.data.JsonP.p266BAF7F_7C89_416B_BF92_86FDD2C09E94({"guide":"<h1 id='p266BAF7F_7C89_416B_BF92_86FDD2C09E94-section-lokalisierung'>Lokalisierung</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/p266BAF7F_7C89_416B_BF92_86FDD2C09E94-section-lokalisierung-durch-sprachdateien-%C3%BCber-den-index-server'>Lokalisierung durch Sprachdateien über den Index Server</a>\n </li>\n<li>2. <a href='#!/guide/p266BAF7F_7C89_416B_BF92_86FDD2C09E94-section-lokalisierung-von-client-scripting'>Lokalisierung von Client-Scripting</a>\n </li>\n<li>3. <a href='#!/guide/p266BAF7F_7C89_416B_BF92_86FDD2C09E94-section-lokalisierte-stichwortlisten'>Lokalisierte Stichwortlisten</a>\n </li>\n</ul></div>\n\n<p>Lokalisierung ist ein wichtiges Hilfsmittel ELO Business Solutions in mehreren Ländern anzubieten oder Multinationalen Konzernen die Möglichkeit zu geben Auslandsniederlassungen mit der gleichen Lösung zu versorgen.</p>\n\n<p><span class=\"tag_warning\">Die Übersetzungstabellen bieten in ELO einen altbewährten Mechanismus einzelne Wörter zu lokalisieren. Dieser Mechanismus kommt in den ELO Business Solutions nicht zum Einsatz. Vielmehr wurden neue Möglichkeiten geschaffen die auf Basis von sogenannten Properties-Dateien optimal mit Übersetzungsbüros einsetzbar sind.</span></p>\n\n<h2 id='p266BAF7F_7C89_416B_BF92_86FDD2C09E94-section-lokalisierung-durch-sprachdateien-%C3%BCber-den-index-server'>Lokalisierung durch Sprachdateien über den Index Server</h2>\n\n<p>Im Administrations-Ordner befindet sich ab ELO Version 9.3 zusätzlich die Möglichkeit properties-Dateien direkt im Archiv abzulegen. Diese sind im Ordner <code>Localization</code> zu hinterlegen.</p>\n\n<p><p><img src=\"guides/p266BAF7F_7C89_416B_BF92_86FDD2C09E94/img1.png\" alt=\"oc alization\ncustom\nsystem\ntext sol contract\ntext sol contract DE\" width=\"232\" height=\"113\"></p></p>\n\n<p>Standard-Komponenten wie bspw. die ELO Business Solutions finden sich im Ordner <code>system</code>. Dieser darf nicht zu Anpassungen der Lösungen oder für eigene Projekte eingesetzt werden. Business Partner können eigene Lokalisierungsinformationen im Ordner <code>custom</code> hinterlegen.</p>\n\n<p>Der Vorteil hierin liegt in der Priorität wie die Lokalisierung geladen wird. Somit ist es möglich Übersetzungen des Ordners <code>system</code> im <code>custom</code> Ordner zu überschrieben. Die Funktion <span\nstyle='font-weight:bold'>Akte anlegen</span> kann somit einfach in <span\nstyle='font-weight:bold'>Dossier anlegen</span> umbenannt werden um somit auch auf Schweizer Verhältnisse einzugehen.</p>\n\n<p>Properties Dateien sind dabei lediglich Schlüssel-Wert-Zuweisungen. Die hinterlegten Schlüssel können anschließend als <span\nstyle='font-weight:bold'>locale keys</span> verwendet werden.</p>\n\n<p><p><img src=\"guides/p266BAF7F_7C89_416B_BF92_86FDD2C09E94/img3.png\" alt=\"Quick Edit\nAk tuelle Bearbeitung\nClients\nsol. contract. cl i ent. solution. name—Vertragsmanagement\nsol. contract. cl i ent. ri bbon. tabContract—Verträge\nsol. contract. cl i ent. ri bbon. bandCreate—4nl egen\nsol. contract. cl i ent. ribbon . bandEdit—3earbei ten\nsol. contract. cl i ent. ribbon . bandReports—8eri chte\nsol. contract. cl i ent. ribbon. bandDocuments—Dokumente\nVergleich\nAuschecken\n2\n3\n4\n5\n6\n7\n8\n9\n13\" width=\"768\" height=\"216\"></p></p>\n\n<p>Nachfolgend sollten einige Verwendungsmöglichkeiten erläutert werden.</p>\n\n<h3 id='p266BAF7F_7C89_416B_BF92_86FDD2C09E94-section-workflows'>Workflows</h3>\n\n<p>Workflow-Knoten können ebenfalls über locale keys Lokalisiert werden. Hierzu dient das Feld <code>Übersetzungsvariable</code> wo die Schlüssel hinterlegt werden können.</p>\n\n<p><p><img src=\"guides/p266BAF7F_7C89_416B_BF92_86FDD2C09E94/img5.png\" alt=\"Workflowdesigner\nVorlagen\nsolcontactcompanycreate\nsolcontactcontactcreate\nsolcontactcontactlistcreate\nsoLcontract contract approval\nsoLcontractcontractcancelNegotiatior\nsolcontractcontractconclude\nsol.contractcontractcreate\nsolcontractcontractnegotiate\nsolcontractcontracttermnation\nsolcontractdocumentcreate\nsoLhrdocumentcreate\nWorkflow-Vorlage bearbeiten\nsol.contract.contract.create\nEigentümer\nData entry\nEigentümer\ncreate\nMOVE : contract\nGENERATOR : contract no.\nGENERATOR : short description\nFEED : contract created\nCancel\nDELETE : temporary record\nKnotenbezeichnung\nInterne Bezeichnung\nData entry\nUbersetzungsvariable\nsol.contractnode.dataEntry\nBezeichnung beim Weiterleiten\nÜbersetzungsvariable\nEskalationsmanagement\nWeitere Optionen\nÜbernehmen\nAbbrechen\nNeu\nVersionen (1)\nLaden\nPOE-Ausgabe\nKopieren\nBerechtigungen\nSpeichern\nLöschen\nO Vorlage-ID: 107, Version: 111 (Arbeitsversion), Knoten-ID: 1\" width=\"1304\" height=\"613\"></p></p>\n\n<p><span class=\"tag_important\">Der Workflow-Name kann über den Start-Knoten lokalisiert werden.</span></p>\n\n<h3 id='p266BAF7F_7C89_416B_BF92_86FDD2C09E94-section-verschlagwortungsmasken'>Verschlagwortungsmasken</h3>\n\n<p>Die AdminConsole bietet für das Maskendesign zusätzlich eine Vielzahl von Lokalisierungsoptionen an. Beispielsweise für den Namen einer Verschlagwortungsmaske.</p>\n\n<p><span class=\"tag_caution\">Achtung: Maskennamen werden zwar übersetzt im Client angezeigt ein Zugriff über die Index Server API ist aber nur durch Angabe des Namens (Keywording form name) möglich. Aus diesem Grund ist es notwendig stets den <span\nstyle='font-weight:bold'>Original-Namen</span> und einen <span\nstyle='font-weight:bold'>locale key</span> anzugeben.</span></p>\n\n<p><p><img src=\"guides/p266BAF7F_7C89_416B_BF92_86FDD2C09E94/img7.png\" alt=\"ELO Administration Console Keywording forms contract\nselected keywording form Contract\nContict\nrding\nContrect\nan tract. mask.antract\nEn c O&#39; ption\nHR Occum\n&#39;v@rtægyS t\nantract.\nantract.\nent antents to full\nthor function\nShort narne\nref r\nfor\nument Status\nSystem CO I o r\nn activated / Alphabeti.l\nENO ENCRYPTION)\nOK\nx\ncolle\nContrect\nELO a\nELO a\nEla\nELO u\nEl_cscriptE\nFolder\ncu ion\nSta n d a rd\nENO WORKFLOW)\nKeywoæing form\nform\nFiling\nL ifet i m\nFiling def\nument rights\n8\nApply\nrights\nontract. m in\nu\nEnable quick p\nFolder\nin the\nFolder form\nu\" width=\"1201\" height=\"725\"></p></p>\n\n<p><p><img src=\"guides/p266BAF7F_7C89_416B_BF92_86FDD2C09E94/img9.png\" alt=\"ELO Administration Console Keywording forms contract\nx•OeAdd or edit index fields for keywording form.\n• Contract\nField i nfo r\nSolution Type\nn ut length\nOK\nDelete\nx\nx\nMin. input length\nn put type\nCODE\nCOMPANY\ntu m\nEl_liinei_\nVe rt styp\n&#39;v@rhgltnis\" width=\"1200\" height=\"314\"></p></p>\n\n<h3 id='p266BAF7F_7C89_416B_BF92_86FDD2C09E94-section-formularen'>Formularen</h3>\n\n<p>Formulare lassen sich durch die Lokalisiserungsmechanismen des Index Servers vollständig in unterschiedlichen Sprachen anbieten. Hierzu müssen lediglich die<span\nstyle='font-weight:bold'> locale keys</span> im Formular hinterlegt werden.</p>\n\n<p>Dies erlaubt es die Titelleisten der Tab-Gruppen zu übersetzen,</p>\n\n<p><p><img src=\"guides/p266BAF7F_7C89_416B_BF92_86FDD2C09E94/img11.png\" alt=\"Tab-Gruppe bearbeiten\nTab-ID\nTabs\nUberschrift\ncontract form\nBaustein hinzufügen\nStartelement\n110 contract_general all\n111 contract company all\n120 contract_partner all\n130 contract data all\n140 contract_proJect all\n150 contract duration all\n160 contract subjectmatte\n180 contract_paymentplan\" width=\"805\" height=\"501\"></p></p>\n\n<p>… oder beliebige Texte im Formular.</p>\n\n<p><p><img src=\"guides/p266BAF7F_7C89_416B_BF92_86FDD2C09E94/img13.png\" alt=\"Neue Zeile\nNeue Spalte\nTabelle\nsol.\nZeile löschen\nSpalte löschen\n— Eingabe\nDatum\nT Text\nEditor\nMarkierung\nSchalter\nInhalteinfügen\nAuswahl\nCombo\nLink\nLöschen\nverbinden\nTrennen\nAusschneiden\nKopieren\nEinfügen\nSpeichern\nÜbernehmet\nX Abbrechen\nSyste m\nEigenschaften der ausgewählten Zelle\nFeldty p\nText\nVariablenname\nStichwortllste\nURL\nDarstellung\nTooltip\nValidierung\nValidation message\nFormel\nTastenkürzel\nsol.contractform_type\nsol. contract_form_ relation\nsol. contract.form filingLocation\nsol.contractform_status\" width=\"1197\" height=\"409\"></p></p>\n\n<h2 id='p266BAF7F_7C89_416B_BF92_86FDD2C09E94-section-lokalisierung-von-client-scripting'>Lokalisierung von Client-Scripting</h2>\n\n<p>Für die Lokalisierung von Scripten im Client stehen unterschiedliche Konzepte bereit.</p>\n\n<h3 id='p266BAF7F_7C89_416B_BF92_86FDD2C09E94-section-java-client-scripting'>Java Client Scripting</h3>\n\n<p>Lokalisierungen im Java Client sind durch Standard-Mechanismen im Java Client möglich. Hierzu muss die Sprachdatei (Properties-Datei) im Scripting Base Ordner des Java Clients abgelegt werden.</p>\n\n<p>Über das Java Client Scripting kann anschließend auf Locale keys einer Datei zugegriffen werden.</p>\n\n<p><span class=\"tag_important\">Hier kommt nicht der Lokalisierungsmechanismus des Index Servers zum Einsatz. Die Dateien unterhalb des Lokalization-Ordners können aber in das Java Client Scripting Base Verzeichnis referenziert werden. Somit stehen sie in beiden Umgebungen zur Verfügung.</span></p>\n\n<h3 id='p266BAF7F_7C89_416B_BF92_86FDD2C09E94-section-web-client-scripting'>Web Client Scripting</h3>\n\n<p>Im Web Client Scripting muss vom Script angegeben werden, welche Lokalisierungen benötigt werden. Hierzu dient die Funktion <code>api.require</code>. Der Web Client ruft beim Start anschließend den Lokalisierungsmechanismus des Index Servers  auf und lädt die benötigten Informationen. Weitere Informationen zum Web Client Scripting können der Web Client API Dokumentation entnommen werden.</p>\n\n<pre><code>api.require({\n    locales: ['sol.contract.client']\n}, function (localesObject) {\n    console.log('requirements are fulfilled');\n});\n</code></pre>\n\n<p>Dieser Mechanismus stellt sicher, dass lediglich Schlüssel geladen werden die vom Scripting auch benötigt werden.</p>\n\n<h2 id='p266BAF7F_7C89_416B_BF92_86FDD2C09E94-section-lokalisierte-stichwortlisten'>Lokalisierte Stichwortlisten</h2>\n\n<p>Für die Lokalisierung von Stichwortlisten stellen die ELO Business Solutions einen eigenen Lokalisierungsmechanismus bereit. Dabei wird jedem Stichwort ein zugehöriger Schlüssel zugewiesen. Das Stichwort wird an den Client anschließend lokalisiert zurückgegeben.</p>\n\n<p>Folgende Abbildung zeigt das am Beispiel der Belegart in der ELO Business Solution Invoice. Der Schlüssel <code>D1</code> steht hier für <code>Mahnung 1</code>.</p>\n\n<p><p><img src=\"guides/p266BAF7F_7C89_416B_BF92_86FDD2C09E94/img15.png\" alt=\"Rechnungsdaten\no\nS 14 UStG\n0027\n2 - Formelle Prüfung\nIN - Rechnung\nSchlüssel Beschreibung\nIN\nMahnung I\nPositionsdaten\numsatzsteuerkonform nach S 14 UStG\nAllgemein\nBezeichnung\nBeleg art\nMa nda nt\nKunden AG Mitte\nMandant\nBuchungskreis\nMahnung 2\nGutschrift\nKreditor\" width=\"685\" height=\"317\"></p></p>\n\n<p>In die Metadaten des Objektes wird eine Kombination aus beiden Werten geschrieben. In diesem Beispiel <code>D1 - Mahnung 1</code>. Im Scripting kann anschließend der Schlüssel extrahiert werden und sprachunabhängige Operationen ausgelöst werden.</p>\n\n<p>Zugrunde liegt eine <span\nstyle='font-weight:bold'>Dynamische Stichwortliste</span>, welche die Schlüssel-Wert-Paare aus einer Konfiguration lädt und beispielsweise im Formular oder Client anbietet.</p>\n\n<p>Eine Konfigurationsoberfläche erleichtert dabei das Hinzufügen und umbenennen von Stichworten.</p>\n\n<p><p><img src=\"guides/p266BAF7F_7C89_416B_BF92_86FDD2C09E94/img17.png\" alt=\"ELO invoice\nDOKUMENT\nANSICHT\nArchiv\nAufgaben\nKlemmbrett\nBearbeitung\nSuche\nNils Mosbach •\nSTART\nAUFGABEN\nNach Funktion suchen\nsol.invoice.LocaIizedKwIs.Config\nLocalized Keyword List Config\nSpeichern unter\nLocalizedKwtsConfig QuickEdit Dokument Feed\nSpeichem\nBusiness Solutions\nCommon\nCommon fx\ncommon_monitoring\nConnector dx\nConnector xml\ndevelopment\nt» development internal\neloinst\nkeywording forms\nConfigurat&#39;on\nas config\nsol invoice Config\nsol invoice ExportConfig\nsol invoice InvoiceXmIImportConfig\nsol invoice LocaIizedKwIs Config\nsol invoiceWorkflowlJserRoIes Config\nDashboard-Data\nEine lokalisierte Stichwortliste besteht aus einer Anzahl von allgemeinen Schlüsselbezeichnungen mit dazu passenden lokalisierten Textvwerten_ Der Schlüssel wird\nhierbei test vergeben, während der Wert als Lokalisierungsschlüssel hinterlegt ist.\nTitel Spaltenwert\nsol.invoice.localizedKwlstatus.headecvalue\nstatus\ndocTy pe\nStichMWthste: status\nTabellen Titel\nSpaltenüberschritten\nSchüssel\nsol.invoice.localizedKwlstatustableTitle\nTitel Spaltenschlüssel\nsol.invoice.localizedKwlstatus.headeckey\nsolinvoiceIocaIizedKwIstatus entry manuaIEntry\" width=\"1553\" height=\"518\"></p></p>\n","title":"Lokalisierung"});
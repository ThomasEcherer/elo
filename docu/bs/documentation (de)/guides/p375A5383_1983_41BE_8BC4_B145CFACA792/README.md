# Dynamische Stichwortlisten

Dynamische Stichwortlisten stellen einen Standard dar, Daten aus externen Systemen für die Verschlagwortung oder Dateneingabe in ELO zu verwenden. Diese Funktionalität steht clientübergreifend zur Verfügung und kann in der Maskenkonfiguration (für Indexfelder) oder im Formular (für Map-Felder) hinterlegt werden.

<span
style='font-weight:bold'>An dieser Stelle wird auf die Dokumentation der dynamischen Stichwortlisten verwiesen. Für Business Solutions wurde hierzu eine Hilfsklasse entwickelt, die Stichwortlisten einfacher erstellen lässt.</span>

## Grundlegendes

Eine dynamische Stichwortliste erhält vom Client anschließend benötigte Filterkriterien und benutzt diese, um mithilfe einer Datenbankabfrage treffende Ergebnisse zu liefern. Zurückgegeben wird eine Tabelle mit den Daten sowie weiteren Informationen, wie bspw. dem ELO-Feldbezeichner, Spaltennamen, Tabellennamen etc. 

<span
style='font-weight:bold'>Beispiel:</span>

<table><thead><tr><td><span
style='font-weight:bold'>Nummer</span></td><td><span
style='font-weight:bold'>Name</span></td><td><span
style='font-weight:bold'>Straße</span></td><td><span
style='font-weight:bold'>Land</span></td></tr></thead><tbody><tr><td><span
style='font-weight:bold'>VENDOR_NO</span></td><td><span
style='font-weight:bold'>VENDOR_NAME</span></td><td><span
style='font-weight:bold'>VENDOR_ADRESS_STREET</span></td><td><span
style='font-weight:bold'>VENDOR_ADRESS_COUNTRY</span></td></tr><tr><td>1001</td><td>MVM Musterhafter</td><td>MusterStr. 12</td><td>DE</td></tr><tr><td>1002</td><td>Lieferant GmbH</td><td>Lieferantenstraße 20</td><td></td></tr></tbody></table>

ELO Java Client, ELO Web Client sowie ELOwf implementieren dieses Konzept und bieten eine tabellarische Auswahl an Daten an. Wählt der Benutzer eine Spalte aus, werden alle Daten nach den ELO-Feldbezeichnern übernommen.

{@img img1.png Aufgaben 
ELO invoice 
START 
Archiv 
p Suche 
» Formelle Prüf X 
DOKUMENT 
Administrator • 
Workflow anzeigen 
Gl Feed 
ANSICHT 
AUFGABEN 
Buchungsdaten 
Mandant 
Datei einfügen 
Kunden AG Mitte 
Rechnungsdaten 
Buchungskreis 
Kreditor 
Straße Hausnummer 
Land / Ort 
List ldNr 
Rechnungsdaten 
Rechnungsnummer 
S 14 UStG 
Aufgaben 
Klemmbrett 
/ Bearbeitung 
X Mein ELO 
Nummer 
1001 
1002 
Name 
MVM Musterhafter 
Versicherungsverein Musterstadt 
Lieferant GmbH 
Kreditorname MVM Musterhafter Versicherungs verein Mus tea 
coaAOEPPxxx 
Steuernummer Ost. IdNr. 
620/35903 
OE 273627722 
München 
Straße 
Musterstr 12 
Liefer antenstr a ße 
Land PLZ 
12245 
80333 
Ort 
Musterstadt 
München 
IBAN 
OE18 6036 
2013 0453 
4087 00 
Sachbearbeiter/ Bes teuer 
471102 
Nicht weiterleiten, nur Zwischenspeichern 
Speichem Drucken 
Nächster Bearbeitungsschritt 
Weiter zur Freigabe Abgabe Clearing}

## Definition einer Stichwortliste

Dynamische Stichwortlisten {{DYNLST}} können mithilfe der Klasse `sol.common.ix.DynKwlDatabaseIterator` definiert werden. Diese stellt alle grundlegenden Funktionen bereit und kann lediglich über Konfigurationswerte definiert werden. <span
style='font-weight:bold'>In den Richtlinien zum </span><a
href="#!/guide/p948E2AF9_BBE2_4705_BB95_04478A9C7638"><span
style='font-weight:bold'>Indexserver-Scripting</span></a><span
style='font-weight:bold'> findet sich ein vollständiges Beispiel.</span>

### Rahmendefinition

Als Grundvoraussetzung muss das Gerüst der Tabelle definiert werden. Dieses setzt auch aus dem Namen `tableTitle` (wird auch im Client angezeigt), den Spaltennamen `tableHeaders` sowie den ELO Feldbezeichnern `tableKeyNames` zusammen. Feldbezeichner werden von den Clients ausgewertet, um entsprechende Metadaten/Map-Daten zu identifizieren und zu befüllen.

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Folgendes Beispiel definiert eine dynamische Stichwortliste für das Befüllen einer Tabellenzeile im ELOwf:</span>

    sol.define('sol.invoice.ix.dynkwl.TradeCharge', {
        extend: 'sol.common.ix.DynKwlDatabaseIterator',
    
        tableTitle: 'Zuschläge',
        sqlQuery: "select code, description from sol_invoice_trade_charge where language = ? AND (code like ? OR description like ?) order by description",
        sqlParams: [
            { valueType: 'LANGUAGE' },
            { mode: 'STARTS_WITH' },
            { mode: 'CONTAINS' }
        ],
        tableKeyNames: ["IX_MAP_INVOICE_TRADE_CHARGE_CODE{i}", "IX_MAP_INVOICE_TRADE_CHARGE_DESC{i}"],
        tableHeaders: ["Code", "Bezeichnung"]
    });

Im Standard können Indexfelder durch die Angabe des Feldnamens befüllt werden. Sollen Map-Felder befüllt werden, muss das Präfix `IX_MAP` zusätzlich vorangeschrieben werden:

        // Befüllen von Indexfeldern nach Gruppenfeldnamen
        tableKeyNames: ["VENDOR_NAME", "VENDOR_NO"],
    
        // Befüllen von Mapfeldern
        tableKeyNames: ["IX_MAP_INVOICE_PURCHASER_NO", "IX_MAP_INVOICE_PURCHASER_NAME"],
    
        // Befüllen einer Map-Tabellen-Zeile
        // {i} wird vom ELOwf durch den aktuellen Tabellenindex ersetzt
        tableKeyNames: ["IX_MAP_INVOICE_TRADE_CHARGE_CODE{i}", "IX_MAP_INVOICE_TRADE_CHARGE_DESC{i}"],

### Datenbankabfrage

Die Datenbankabfrage kann in Form eines Prepared-SQL-Statements mithilfe der Property `sqlQuery` definiert werden und sollte Platzhalter &quot;`?`&quot; enthalten. Diese Platzhalter werden zur Laufzeit mithilfe der `sqlParams` aufgelöst. Dabei muss das `sqlParams`-Array exakt die gleiche Anzahl Elemente beinhalten wie Platzhalter vorhanden sind.

Zur Verfügung stehen: 

*   `mode` - Beschreibt den Vergleichsmodus, bspw. `STARTS_WITH` oder `CONTAINS`.
*   `name` - Beschreibt den Namen des Gruppen-/ Map-Felds, das vom Client übergeben wurde. Falls kein Name gesetzt wurde, wird die aktuelle Eingabe (Filterwert) des Benutzers verwendet.
*   `message` - Definiert eine Fehlermeldung, falls das Feld noch nicht befüllt wurde. Diese Meldung wird im Client ausgegeben.

Als Besonderheit kann optional mithilfe eines `valueType`-Parameters auf Systemeigenschaften zugegriffen werden, bspw. gibt `LANGUAGE` die aktuelle Benutzersprache zurück.

Einige weitere <span
style='font-weight:bold'>Beispiele:</span>

        sqlQuery: "select CODE, NAME, STREET, ZIPCODE, CITY, COUNTRY_CODE from sol_invoice_company where CODE like ? OR NAME like ?",
        sqlParams: [
          {mode: 'STARTS_WITH'},
          {mode: 'CONTAINS'}
        ],
  
        sqlQuery: "select NO, NAME from sol_invoice_costobject where COMPANY_CODE = ? AND (NO like ? or NAME like ?) order by NAME",
        sqlParams: [
          { name: 'COMPANY_CODE', message: 'Wählen Sie einen Mandanten aus' },
          { mode: 'STARTS_WITH' },
          { mode: 'CONTAINS' }
        ],


## Beispiele

### Dynamische Stichwortlisten in der Maskendefinition

Dynamische Stichwortlisten können in der Maskendefinition für jedes Feld hinterlegt werden, bei dem die Liste eingeblendet werden soll. Hierzu wird der Skriptname der Liste im Archiv hinterlegt. Fängt der Benutzer in dem Feld an zu tippen, wird der aktuelle Feldwert als <span
style='font-weight:bold'>Filterwert</span> an die Stichwortliste übermittelt.

{@img img3.png hinzufügen oder bearbeiten für die Maske. 
• Eingangsrechnung 
Feldi nfo 
itorn u m m er 
und Hausnumme 
x 
Status 
konform 
Buch u 
Ust- IdNr. 
x Ein g. Selgnge 
OK 
Gru 
EingaSelÉnge 
Quick Info 
Quick 
DynamiÆhe Stichwortliste 
COMPANY CODE}

### Befüllen von Indexfeldern in einem ELOwf-Formular

Das Befüllen von Indexfeldern erfolgt über die Angabe der Stichwortliste <span
style='font-weight:bold;font-style:italic'>Keyword</span>. In diesem Fall ermittelt ELOwf die zugrundeliegende Stichwortliste über die Maskendefinition des angegebenen Gruppennamens.

{@img img5.png Mandant 
Buchungskreis 
Mandant 
Feldtvp 
Variablenname 
Stichwortliste 
Gruppenname 
Eigenschaften der ausgewählten Zelle 
Eingabe 
COMPANY CODE 
Autofill 
Nur Listenwerte erlaubt}

### Befüllen einer Tabellenzeile in einem ELOwf-Formular

Sollen Daten in eine Tabellenzeile von ELOwf geschrieben werden, muss der Skriptname der Stichwortliste hinterlegt werden. Zusätzlich muss eine Liste der zu übermittelnden Filter belegt werden, bspw.: `IX_GRP_COMPANY_CODE,IX_GRP_VENDOR_NO`. Sollen Werte aus der aktuellen Tabellenzeile übernommen werden,  müssen diese mit einem `{i}` angegeben werden: `IX_MAP_INVOICE_TRADE_CHARGE_CODE{i}`

{@img img7.png Zahlungsbedingungen 
Zahlungsziel (Tage) Skonto in % Zahlungsziel 
Weitere Zeile 
S kontobet rag 
Rechnungsbetrag 
als Fälligkeit 
Eigenschaften der ausgewählten Zelle 
Feldtvp 
Variablenname 
Stichwortliste 
Skriptname 
Filter 
Eingabe 
Dynamc Keyword Map 
sol.inv&ce.ix.dynkwI.TermsOfPaynu 
Autofill 
Nur Listenwerte erlaubt}

## Weitere Einsatzbereiche von Dynamischen Stichwortlisten

Weiterführend können dynamische Stichwortlisten auch dazu verwendet werden Elemente aus ELO anzubieten. Hierzu gibt die Klasse `sol.common.ix.DynKwlSearchIterator` eine Basis Implementierung. Sollen Kindelemente eines Ordners zurückgegeben werden kann die Klasse `sol.common.ix.DynKwlFindChildrenIterator` eingesetzt werden.

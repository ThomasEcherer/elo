# Object Formatter: Objekte transformieren

ELO Indexserver-Objekte stellen eine gute Möglichkeit dar, Daten in unterschiedliche Umgebungen zu transportieren. Je nach Anwendungsszenario ist der Aufbau der Datenstruktur jedoch möglicherweise nicht optimal. 

Dies ist bspw. der Fall, wenn in Cockpits mit AngularJS eine große Menge von Daten für statistische Auswertungen geladen werden soll oder wenn Templates direkt auf Metadaten zugreifen müssen. 

Eine Beschreibung inkl. weiterer Beispiele kann der Klasse `sol.common.ObjectFormatter` entnommen werden.

Diese Klasse übernimmt hierfür die Transformation der Indexserver-Objekte in andere Formate. Im Kern stehen zwei Objektstrukturen für <span
style='font-weight:bold'>statistische Auswertungen</span> und für die Verwendung in <span
style='font-weight:bold'>Templates</span> zur Verfügung. Transformiert werden können bspw. Sord- und Task-Objekte.

<table><thead><tr><td><span
style='font-weight:bold'>Indexserver-Objekt</span></td><td><span
style='font-weight:bold'>Für Templates</span></td><td><span
style='font-weight:bold'>Für statistische Auswertungen</span></td></tr></thead><tbody><tr><td>    de.elo.ix.client.Sord</td><td>    sol.common.ObjectFormatter.TemplateSord</td><td>    sol.common.ObjectFormatter.StatisticSord</td></tr><tr><td>    de.elo.ix.client.UserTask</td><td>    sol.common.ObjectFormatter.TemplateTask</td><td>    sol.common.ObjectFormatter.StatisticTask</td></tr></tbody></table>

## Beispiel einer Transformation

Im Folgenden wird exemplarisch ein Auszug des Indexserver-Sord-Objekts gegeben. Man beachte die verschachtelte Array-Struktur bspw. der `objKeys` :

    ixSord  = {
      "id": "7572",
      "maskName": "Incoming invoice",
      "name": "Invoice 0000",
      "IDateIso": "20150720142400",
      "XDateIso": "",
      "objKeys": [{
        name: "VENDOR_NAME", data: ["Weiler KG"],
      }],
    }

Ein speziell für die Verwendung in Templates angepasstes Objekt ('Template Sord') sieht folgendermaßen aus:

    templateSord  = {
      "id": "7572",
      "maskName": "Incoming invoice",
      "name": "Invoice 0000",
      "IDateIso": "20150720142400",
      "XDateIso": "",
      "objKeys": {
        "VENDOR_NAME": "Weiler KG",
        "INVOICE_DATE": "20150601162415",
        "INVOICE_CASH_DISCOUNT_AMOUNT": 554
      }
    }

Dank der Transformation kann bspw. in Templates (Word, E-Mail, Aktenzeichen etc.) ein einfacher Zugriff auf `objKeys` erreicht werden:

    {{templateSord.objKeys.VENDOR_NAME}}

Performance und Datenmengen

Werden große Datenmengen vom Indexserver abgeholt, bietet der Sord Formatter zusätzlich die Möglichkeit Objekte zu verkleinern. In diesem Fall werden lediglich die benötigten Attribute und Metadaten übermittelt, was einen nicht unerheblichen Anteil an Traffic einspart.
> 
> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Im Rechnungseingangscockpit können potentiell bis zu 10.000 Rechnungen angezeigt werden. Dies kann Datenmengen von über 60 MB produzieren. Werden selektiv nur die im Cockpit benötigten Daten übertragen, reduziert sich die Datenmenge auf unter 4-5 MB.</span>

# Templates

Bei der Erzeugung von E-Mails, Aktenzeichen, Konfigurationsdateien oder sonstigen Daten in ELO kann mithilfe von Templates ein generischer Ansatz definiert werden. Werte werden anschließend zur Laufzeit bspw. durch Metadaten ersetzt.

<span
style='font-weight:bold'>Templates sind dabei ein essentieller Bestandteil von Lösungen, da sie Anpassbarkeit und Flexibilität gewährleisten. So sollten bspw. alle Bezeichnungen mithilfe von Templates beschrieben werden. </span>

Die Grundlage für das Templating liefert das Open Source-Projekt <a
href="http://handlebarsjs.com/">handlebars.js </a>

Templating kommt in vielen Stellen der ELO Business Solutions zum Einsatz. u.a. bei dem …

*   <span
style='font-weight:bold'>… Aufbau von Ablagepfaden.</span> Hier steht in der Konfiguration einzelner Lösung ein mächtiges Instrument zur Verfügung Ablagepfade aufzubauen.
*   <span
style='font-weight:bold'>… Generieren von Kurzbezeichnungen und Aktenzeichen.</span> Aktenzeichen unterliegen unterschiedlichen unternehmerischen/ behördlichen Anforderungen. Durch Templates kann das Zeichen schnell angepasst werden.
*   <span
style='font-weight:bold'>… Erzeugen von Export-Dokumenten.</span> Export-Datensätze bspw. in Form von XML oder CSV können mit Templates an die Anforderungen des Zielsystems angepasst werden.
*   <span
style='font-weight:bold'>… Erzeugen von PDF-Dokumenten.</span> Für die Erzeugung von PDF-Dokumenten wird verstärkt auf Apache FOP gesetzt. Diese Vorgehensweise lässt sich ideal mit Templates kombinieren.

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Das Aktenzeichen setzt sich aus dem Aktenplanzeichen und einem Zähler zusammen. Das Aktenzeichen wird im Metadatenfeld `FILING_PLAN_REFERENCE` gespeichert. Sord-Objekte des Index Servers lassen sich nur bedingt für Templates einsetzen, da hier eine teils verschachtelte Datenstruktur von objKeys vorliegt. Der </span><a
href="#!/guide/pCD2692F9_F8F1_41E8_9DF7_EFC5B4F7B6CC"><span
style='font-style:italic'>Object Formatter</span></a><span style='font-style:
italic'> erlaubt es dabei Objekte in einen einfach zu verwendenden Objektaufbau zu transformieren.</span>

    {{sord.objKeys.FILING_PLAN_REFERENCE}}-{{count "TEST"}}

> <span
style='font-style:italic'>Hätte das aktuelle Element in den Metadaten das Aktenplanzeichen (FILING_PLAN_REFERENCE) </span><span
style='font-weight:bold;font-style:italic'>12.10</span><span style='font-style:
italic'> gesetzt, ergäbe sich folgendes Resultat:</span>

    12.10-1
    12.10-2
    12.10-3
    ...

Vorteilhaft in <span
style='font-style:italic'>handlebars</span> ist die Verwendung sogenannter 'Helper'. Diese ermöglichen es, Anwendungsfunktionalität wie bspw. die Indexserver-Counter in Templates zu modularisieren. So wird im obigen Beispiel dem Helper `count` ein Nummernkreis `TEST` übergeben. Der Indexserver legt hierfür nun einen Counter an und zählt diesen bei jeder Verwendung um eins hoch.

Eine erweiterte Beschreibung inklusive einiger Beispiele der Funktionalität kann der Klasse `sol.common.Template` entnommen werden.

Einfaches Beispiel

Folgendes Beispiel veranschaulicht eine einfache Verwendung des Template-Mechanismus der Klasse `sol.common.Template` :

    var tpl = sol.create('sol.common.Template', {
        source = 'Hello {{name}}.'
    });
    
    var result = tpl.apply({
      name: 'Marcus'
    });
    
    // result = Hello Marcus.

## Erweitertes Beispiel anhand eines Sord-Objekts

Templates können auch als Text-Dateien im Archiv abgelegt werden. Hierfür muss das Template anhand einer GUID oder ARCPATH-Referenz geladen werden. 

Anschließend kann über den Object Formatter ein bestehendes Sord in ein Template-Sord transformiert und im Template gesetzt werden:

    var tpl = sol.create('sol.common.Template', {});
    
    // load data from a text file in ELO
    tpl.load('GUID');
    
    // accessing objKey properties is difficult.
    // use sol.common.ObjectFormatter to get an easy to use sord object.
    var data = sol.common.ObjectFormatter.format({
      sord: {
        formatter: 'sol.common.ObjectFormatter.TemplateSord',
        data: sord
    });
    
    var result = tpl.apply(data);

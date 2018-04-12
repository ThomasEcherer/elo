# Aktionen

Primärer Zweck von Aktionen ist es, die Interaktion mit dem Benutzer zu modularisieren. Eine Aktion wird meist über eine Funktion (z.B. einen Button) im Client aufgerufen. Eine Aktion kann dabei dem Client Informationen zurückgeben, wie weiter verfahren werden soll.

<span class="tag_important">Primäres Ziel des Aktionen-Konzeptes ist es auf Client-Scripting weitgehend zu verzichten und somit Funktionalitäten im ELO Web Client und ELO Java Client bereitzustellen.</span>

Aktionen sind meist Funktionen, welche sich als Buttons in der Multifunktionsleiste wiederfinden. Die kann beispielsweise die Funktion<span
style='font-weight:bold'> Vertrag anlegen</span>, <span style='font-weight:
bold'>Akte anlegen</span>, <span style='font-weight:bold'>Vertrag abschließen</span> oder <span
style='font-weight:bold'>Dokument aus Vorlage erzeugen</span> sein. Nachfolgende Abbildung zeigt zehn unterschiedliche Aktionen aus dem Vertragsmanagement.

{@img img1.png ELO contract 
VERTRÄGE 
Freigabe 
einleiten 
DOKUMENT 
ANSICHT 
AUFGABEN 
Nach Funktion suchen 
START 
Vertrag 
9 
Vertrag 
abgeschlossen 
Dokument 
erze ugen 
Deckblatt 
erstellen 
Dokumente 
Kündigung 
einleiten 
Etikett 
erstellen 
vertrage 
Zahlungsplan 
Verhandlung 
abgebr ochen 
Berichte 
Bearbeiten}

Der Gesamtablauf vom Client-Start bis zum Abschluss einer Aktion zeigt sich wie folgt:

### Definition und Ablauf auf Client Seite:

Während des Client Starts werden alle verfügbaren Aktionen ermittelt und die Multifunktionsleiste aufgebaut. Hierzu dienen <a
href="#!/guide/pD8CAD36E_33B3_4E82_A858_DE22E790DC9B">Konfigurationsobjekte (Action definitions)</a> die dem Client zusätzlich alle Informationen mitgeben was notwendig ist, um eine Aktion auszulösen.

Betätigt der Anwender einen Button bspw. aus der Multifunktionsleiste ruft der Client die Aktion auf. Diese wird auf der Serverseite als Funktion im ELO Index Server oder ELO AS implementiert. Nach Ablauf der Aktion werden vom Server eine Reihe von <a
href="#!/guide/">Events</a> zurückgeben wie abschließend weiter verfahren werden soll. Diese werden von Client anschließend ausgeführt.

Im Client stehen verschiedene Möglichkeiten bereit Informationen für Aktionen zu sammeln. So wird beispielsweise bei der Aktion Vertrag anlegen eine Liste von Vertragstypen eingeblendet aus welcher der Anwender auswählen kann. Siehe hierzu auch <a
href="#!/guide/p5D40D60D_8A08_4E78_9785_7C705958C275">Aktionstypen</a>.

### Definition und Ablauf auf Server Seite:

Die Kernaufgabe der Aktion (IX und AS Implementierung) sieht vor, <span
style='font-weight:bold'>grundlegende Aufgaben</span> wie <span
style='font-weight:bold'>das Anlegen eines neues Elements</span> in ELO und das Prüfen von Bedingungen auszulösen. Auf dem neu angelegten Element wir anschließend ein Workflow gestartet, der den gesamten Technischen Prozess mithilfe von <a
href="#!/guide/pADD870BA_9AA2_4900_8D6B_FA0FB26D9BEC">Funktionsbausteinen</a> abbildet.

<span class="tag_warning">Für jedermann ist so stets ersichtlich was eine Aktion im Kern erledigt, ohne einen Blick in den Code zu werfen. Zudem kann nur so gewährleistet werden, <span
style='font-weight:bold'>dass Funktionserweiterungen und Bugfixes später ohne große Probleme eingespielt werden können. Zudem gibt es jedermann die Möglichkeit den technischen Ablauf zu konfigurieren.</span></span>

Nach dem Start des Workflows wird von der Aktion anschließend eine Liste von <a
href="#!/guide/">Events</a> zusammengestellt wie der Client weiter verfahren soll. Diese Events wurden vorab standardisiert und stehen im Java Client sowie Web Client zur Verfügung.

### Beispiel

<span class="tag_important">Zusammenfassend setzt sich eine Aktion aus einer Beschreibung was zu tun ist (Action definition), einem Index Server oder ELO AS Script sowie einem Workflow zusammen.</span>

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Die Aktion </span><span style='font-weight:bold;
font-style:italic'>Akte anlegen</span><span style='font-style:italic'> erstellt einen Ordner an der gewünschten Stelle und setzt die Kurzbezeichnung. Anschließend wird ein Workflow gestartet. Dem Client wird anschließend mitgeteilt, dass ein spezifisches Formular angezeigt und ein `Goto` auf die neu erstellte Akte ausgelöst werden soll.</span>

{@img img3.png}

## Grenzen des Aktionen-Konzeptes

Das Aktionen Konzept hat sich das Ziel gesetzt Clientübergreifend Funktionalitäten anzubieten. Das ist u.a. bei Postbox-Funktionen nicht möglich.








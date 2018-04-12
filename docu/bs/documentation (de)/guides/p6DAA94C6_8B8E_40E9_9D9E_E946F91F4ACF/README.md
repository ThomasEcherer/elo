# Aktionslogik (Server)

Die eigentliche Aktionslogik wird dabei als Indexserver-Skript oder ELOas-Regel implementiert. Hierzu liefert die Klasse `sol.common.ix.ActionBase` sowie `sol.common.as.ActionBase` eine Basisimplementierung, die Grundfunktionalitäten beinhaltet. <span
style='font-weight:bold'>Dabei ist zu beachten, dass jegliche Logik, soweit möglich, auf der Serverseite zu implementieren ist. </span>

Jede Aktion sollte dabei lediglich die Grundanforderungen wie bspw. das Anlegen eines Ordners, auf dem der Workflow gestartet werden kann, implementieren. Der eigentliche technische Ablauf von Funktionen, wie bspw. einen Feed-Kommentar schreiben, die Farbe des Knotens ändern, oder eine erweiterte Datenerfassung einleiten, muss im Workflow-Diagramm über Funktionsbausteine realisiert werden. 

<span class="tag_important">Eine Beispielimplementierung einer Aktion kann den Richtlinien zum <a
href="#!/guide/p948E2AF9_BBE2_4705_BB95_04478A9C7638">Indexserver-Scripting</a> entnommen werden.</span>

## Implementierung einer Aktion im Indexserver

Index Server Aktionen können einfach mithilfe der Klasse `sol.common.ix.ActionBase` implementiert werden. Diese stellt grundlegende Funktionen für den Umgang mit Clients zur Verfügung. Implementiert werden müssen die Funktionen `getName` und `process`. Dabei wird `process` von der Aktion intern aufgerufen, nachdem diese ausgelöst wurde.

<span class="tag_important">Clients können die Index Server Aktion anschließend über `Registered Funktions` aufrufen. Weitere Information hierzu gibt das Index Server Programmierhandbuch.</span>

Eine abstrahierte Implementierung der Funktion <span
style='font-weight:bold;font-style:italic'>Vertrag freigeben</span> bei der im Client ein Benutzerformular angezeigt werden soll zeigt sich wie folgt.

    sol.define("sol.contract.ix.actions.ApproveContract", {
      extend: "sol.common.ix.ActionBase",
         
      getName: function () {
        return "InitateApproval";
      },
      
      process: function () {
        var me = this,
            flowId;
             
        flowId = me.startWorkflow(me.objId, "sol.contract.ix.actions.ApproveContract", "Approval Workflow");
        
        me.addWfDialogEvent(flowId, { objId: me.objId });
      }
    });

    function RF_sol_contract_action_ApproveContract(ec, configAny) {
      var rfUtils = sol.common.ix.RfUtils,
          config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny, "objId"),
          approveContract;
        
      approveContract = sol.create("sol.contract.ix.actions.ApproveContract", config);
      return approveContract.execute();
    }

### Zugriff auf Werte die von Clients übergeben werden.

Clients übergeben eine Reihe von Konfigurations-Werten für die Aktion wie bspw. die Objekt-ID des aktuell selektierten Elements. Welche Informationen vom Client an die Aktion übergeben werden wird über das `cfgTemplate` der `Action definition` gesteuert (Siehe auch <a
href="#!/guide/p5D40D60D_8A08_4E78_9785_7C705958C275">Aktionstypen</a>). 

Die Scripting API des Index Server arbeitet an dieser Stelle mit Any-Objekten die in Java Script umgewandelt werden müssen. Dies übernimmt eine Hilfsfunktion `sol.common.ix.RfUtils#parseAndCheckParams`. Konfigurationswerte werden anschließend beim Instanziieren der Klasse (`sol.create`) übergeben.

In der Implementierung der Aktion (bspw. in der `process`-Funktion) stehen diese werden dann im Objekt zur Verfügung (Siehe auch <a
href="#!/guide/p78A42722_9D6B_45AE_884B_B847AE864468">Klassenframework</a>). Auf die übergebene Objekt-Id kann bspw. über `this.objId` zugegriffen werden.

<span class="tag_important">Vom Client können hier somit beliebige Werte an die Aktion übergeben werden. Dies erlaubt es eine Aktion für unterschiedliche Buttons zu verwenden.</span>

### Client Events zurückgeben

<table><thead><tr><td>Name</td><td>Hilfsfunktion</td><td>Beschreibung</td></tr></thead><tbody><tr><td>Formular im Dialog anzeigen</td><td>sol.common.ActionBase#addWfDialogEvent</td><td>Mithilfe der gestarteten Workflow Id kann der aktuelle Benutzerknoten ermittelt werden. <br />Der Client zeigt anschließend in einem Dialog das Benutzerformular an.</td></tr><tr><td>Webseite im Dialog anzeigen</td><td>sol.common.ActionBase#addUrlDialogEvent</td><td>Für komplexere Szenarien kann der Client angewiesen werden eine beliebige Webseite über einen Dialog anzuzeigen.<br />Dies kann hilfreich sein um bspw. ELO Apps zu laden oder externe Entwicklungen einzubinden.</td></tr><tr><td>App im Dialog anzeigen</td><td>sol.common.ActionBase#addAppDialogEvent</td><td>Nutzt intern den selben Mechanismus wie sol.common.ActionBase#addUrlDialogEvent kapselt aber das Zusammenbauen der App-URL, vereinfacht also die benutzung des Dialog-Events für Apps.<br />`(ab 1.02.002)`</td></tr><tr><td>Weitere Aktion aufrufen</td><td>sol.common.ActionBase#addActionEvent</td><td>In Sonderfällen kann es notwendig sein Aktionen zu verketten. <br />In diesem Fall ruft der Client nach vollständiger Abarbeitung einer Aktion eine weitere Aktion auf. <br />Dieser Mechanismus kommt u.a. beim Erzeugen von Dokumenten aus Vorlagen zum Einsatz.</td></tr><tr><td>Einen Eintrag neu laden</td><td>sol.common.ActionBase#addRefreshEvent</td><td>Löst im Client einen Refresh eines Elementes aus.</td></tr><tr><td>Goto auf einen Eintrag aufrufen</td><td>sol.common.ActionBase#addGotoIdEvent</td><td>Weißt den Client an ein Goto im Archiv auszulösen. In den meisten Fällen wird hier das neu angelegte Element zur Anzeige gebracht.</td></tr><tr><td>Goto auf eine Aufgabe aufrufen</td><td>sol.common.ActionBase#addGotoWfTaskEvent</td><td>Weißt den Client an ein Goto auf eine (Workflow-) Aufgabe auszulösen.</td></tr><tr><td>Einen Fehler zurückgeben</td><td>sol.common.ActionBase#addErrorEvent</td><td>Gibt eine Fehlermeldung zurück.</td></tr><tr><td>Ein Feedback anzeigen</td><td>sol.common.ActionBase#addFeedbackEvent</td><td>Veranlasst den Client eine (temporäre) Statusnachricht anzuzeigen</td></tr></tbody></table>


<span
style='font-weight:bold'>Der Ablauf zeigt sich später wie folgt:</span>

1.   Vom Client wird die `Registered Function` `RF_sol_contract_action_ApproveContract` aufgerufen.
2.   Diese erzeugt ein Objekt der Aktion `sol.contract.ix.actions.ApproveContract` und ruft `execute()` auf.
3.   Die Funktion `execute()` bereitet alles für das Ausführen der Aktion vor, ruft die eigentliche Implementierung `process()` auf und bereitet die Daten für eine Übergabe an den Client auf. An dieser Stelle werden auch alle hinzugefügten Events gesammelt und zurückgegeben.

Eine Auflistung der Funktionen von `ActionBase` kann der Klassendokumentation `sol.common.ActionBase` entnommen werden.

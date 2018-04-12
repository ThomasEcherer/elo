# Definition (Action definition)

Das primäre Ziel des Aktionen-Konzeptes liegt in dem Verzicht auf individuelles Clientscripting. Nur so kann sichergestellt werden, dass im Web Client sowie Java Client die gleiche Funktionalität zur Verfügung steht.

<span class="tag_important">Eine Aktion besitzt daher kein Client Scripting. Die Definition der Multifunktionsleiste (Ribbon) sowie des Buttons erfolgt über eine Konfiguration im Administrationsordner. Diese Konfiguration enthält ebenfalls Informationen wie der Client vorzugehen hat um die Aktion auszuführen.</span>

{@img img1.png}

## Aufbau der Multifunktionsleiste im Client

Während des Client Starts wird vom Java Client und Web Client eine Liste von verfügbaren Aktionen geladen. Auf Basis der zugrundeliegenden Konfiguration einer jeden Aktion wird anschließend u.a. die Multifunktionsleiste aufgebaut.
<br>
Diese Operation wird von der Klasse sol.common.jc.ActionDefinitionUtils (Java Client) bzw. sol.common.web.ActionDefinitionUtils (Web Client) durchgeführt. Das Sammeln aller Aktionen wird von dem Index Server <a
href="#!/guide/p4A156A44_F024_4918_BE64_496EA6C348F2">Service</a> `sol.common.ix.services.RibbonDefinitionCollector` vorgenommen. <span
style='font-weight:bold'>Dieser sorgt zusätzlich für eine serverseitige </span><a
href="#!/guide/p266BAF7F_7C89_416B_BF92_86FDD2C09E94"><span
style='font-weight:bold'>Lokalisierung</span></a><span style='font-weight:bold'> aller Texte.</span>

<span class="tag_warning">Diese Vorgehensweise trägt zusätzlich zu einer Optimierung Performance bei, da während des Clientstarts die Anzahl von benötigten Scripten reduziert werden kann.</span>

## Einschränken der Sichtbarkeit für unterschiedliche Anwender

Mithilfe der ELO Berechtigungen kann zusätzlich gesteuert werden, welcher Anwender welche Funktionen in der Multifunktionsleiste angeboten bekommt. 

<span class="tag_important">Somit lässt sich für jede Aktion einer Lösung fein granular definieren, welche Gruppe bspw. das gesamte Tab Vertragsmanagement oder lediglich einzelne Funktionen sehen darf.</span>

> <span
style='font-weight:bold;font-style:italic'>Ein Beispiel:</span><span
style='font-style:italic'> Jeder Anwender, der Leserechte auf die Funktion `sol.contract.CreateContract` besitzt bekommt auch den zugehörigen Button im Ribbon eingeblendet.</span>

## Beispiel-Konfiguration einer einfachen Aktion

Die Konfiguration setzt sich aus der zugrundeliegenden Client Implementierung (Aktions-Typ), der Definition der Multifunktionsleiste (Ribbon) sowie den Informationen für das Ausführen der Aktion zusammen.

### Aktionstyp

Aktionen können unterschiedlicher Natur sein. Um auf Sonderfälle gezielt einzugehen, stehen in den Clients eine Reihe von Implementierungen (<a
href="#!/guide/p5D40D60D_8A08_4E78_9785_7C705958C275"><span
style='font-weight:bold'>Aktionstypen</span></a>) bereit. Nachfolgendes Beispiel zeigt eine einfache Aktion `SIMPLE_ACTION`. Mithilfe einer `ADVANCED_ACTION` kann beispielsweise bevor die Aktion ausgelöst wurde noch ein Dialog zur Typ-Auswahl angeboten werden.

### Definition der Multifunktionsleiste:

Hier wird beschrieben welcher Button, welche Reiter oder Button-Gruppen benötigt werden. Die Konzepte orientieren sich dabei an den Scripting-Möglichkeiten von Web Client und Java Client. Nachfolgendes Beispiel zeigt zudem wie Oberflächen-Texte unter Angabe von `locale keys` <a
href="#!/guide/p266BAF7F_7C89_416B_BF92_86FDD2C09E94">lokalisiert</a> werden können. 

Als Besonderheit muss für den Web Client zusätzlich ein `splitText` für den Button angegeben werden. Dieser enthält einen Zeilenumbruch, falls Texte zu lang werden. Bspw: &quot;Vertrag&lt;br/&gt;anlegen&quot;.

### Anweisungen zum Ausführen der Aktion

Klickt der Anwender auf einen Button wird vom Client zu definierte Aktion ausgeführt. Auf Basis des Aktionstyps wird der zugehörige Handler ausgewertet. Weitere Informationen können der Dokumentation zu <a
href="#!/guide/p5D40D60D_8A08_4E78_9785_7C705958C275">Aktionstypen</a> entnommen werden.

### Abhängige Aktionen
Ab der Version 1.03.000 werden die Aktions-Definitionen ein weiteres Property 'requiredModules' unterstützen.
Hier kann eine Liste von Modulen definiert werden, welche installiert sein müssen. Sollte eines der benötigten Module fehlen, wird der Button nicht an den Client ausgeliefert.

So wird es möglich Aktionen zu definieren, welche von Drittmodulen abhängig sind, ohne dass es zu Fehlern kommt, sollten diese Module nicht installiert sein.

Die Aktion im folgenden Beispiel wird nur an die Clients ausgeliefert, wenn das Modul `common_monitoring` installiert ist.

    {
      "type": "SIMPLE_ACTION",
      "ribbon": {
        …
      },
      "action": {
        "fct": "RF_sol_example_action_RegisterUpdate",
        "cfgTemplate": "{\"objId\": \"{{objId}}\" }",
        "requiredModules": ["common_monitoring"]
      }
    }
    
<span class="tag_important">Die Abhängigkeit zum Basis Paket (`common`) sollte nie extra angegeben werden, da die Existenz implizit garantiert ist.</span>
    

### Beispiel einer Index Server Aktion

<span class="tag_important">In absehbarer Zeit wird es für die Konfiguration der Aktionen ebenfalls eine Oberfläche geben, sodass auf das Bearbeiten von JSON-Objekten verzichtet werden kann.</span>

    {
      "type": "SIMPLE_ACTION",
      "ribbon": {
        "ribbonTab": {
          "name": "TAB_SOL_CONTRACT",
          "text": "sol.contract.client.ribbon.tabContract",
          "position": 95
        },
        "buttongroup": {
          "name": "GRP_SOL_EDITCONTRACTS",
          "mode": "big",
          "text": "sol.contract.client.ribbon.bandEdit",
          "position": 20
        },
        "button": {
          "name": "BTN_SOL_CONTRACTINITATEAPPROVAL",
          "text": "sol.contract.client.ribbon.btnInitiateApproval",
          "splitText": "sol.contract.client.ribbon.btnInitiateApprovalSplit",
          "tooltipText": "sol.contract.client.ribbon.btnInitiateApproval.tooltip",
          "access": {
            "document": false,
            "folder": true
          },
          "web": {
            "smallIcon": "sol-contract-initateapproval16",
            "smallIconHighRes": "sol-contract-initateapproval16-200",
            "bigIcon": "sol-contract-initateapproval32",
            "bigIconHighRes": "sol-contract-initateapproval32-200"
          },
          "jc": {
            "buttonId": "729"
          },
          "position": 10
        }
      },
      "action": {
        "fct": "RF_sol_contract_action_ApproveContract",
        "cfgTemplate": "{\"objId\": \"{{objId}}\" }"
      }
    }

### Beispiel einer ELO AS Aktion

Wird eine Aktion als AS Regel implementiert muss dies in der Definition durch <span
style='font-weight:bold'>&quot;type&quot;: &quot;AS&quot;</span> hinterlegt werden. 

Da unterschiedliche AS Instanzen für unterschiedliche Regeln zuständig sein können wird zudem der Name der Lösung benötigt. Der Web Client und Java Client versucht dabei innerhalb des Lösungspaketes eine AS-Konfiguration (`as.config`) zu finden. Findet sich im Lösungspaket keine spezifische ELO AS Konfiguration wird stets die des `common`-Paketes verwendet. 

{@img img3.png Administr ation 
Business Solutions 
_global 
eloinst 
keywording forms 
All 
All Rhino 
Configurat'on 
as config}

    {
      "type": "ADVANCED_ACTION",
      "ribbon": {
        …
      },
      "action": {
        "fct": "sol.contract.as.actions.PrepareDocument",
        "type": "AS",
        "solution": "contract",
        "cfgTemplate": "{\"parentId\": \"{{objId}}\", \"templateId\": \"{{tree.objId}}\" }",
        …
      }
    }




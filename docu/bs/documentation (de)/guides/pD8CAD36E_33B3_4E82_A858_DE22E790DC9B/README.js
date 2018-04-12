Ext.data.JsonP.pD8CAD36E_33B3_4E82_A858_DE22E790DC9B({"guide":"<h1 id='pD8CAD36E_33B3_4E82_A858_DE22E790DC9B-section-definition-%28action-definition%29'>Definition (Action definition)</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/pD8CAD36E_33B3_4E82_A858_DE22E790DC9B-section-aufbau-der-multifunktionsleiste-im-client'>Aufbau der Multifunktionsleiste im Client</a>\n </li>\n<li>2. <a href='#!/guide/pD8CAD36E_33B3_4E82_A858_DE22E790DC9B-section-einschr%C3%A4nken-der-sichtbarkeit-f%C3%BCr-unterschiedliche-anwender'>Einschränken der Sichtbarkeit für unterschiedliche Anwender</a>\n </li>\n<li>3. <a href='#!/guide/pD8CAD36E_33B3_4E82_A858_DE22E790DC9B-section-beispiel-konfiguration-einer-einfachen-aktion'>Beispiel-Konfiguration einer einfachen Aktion</a>\n </li>\n</ul></div>\n\n<p>Das primäre Ziel des Aktionen-Konzeptes liegt in dem Verzicht auf individuelles Clientscripting. Nur so kann sichergestellt werden, dass im Web Client sowie Java Client die gleiche Funktionalität zur Verfügung steht.</p>\n\n<p><span class=\"tag_important\">Eine Aktion besitzt daher kein Client Scripting. Die Definition der Multifunktionsleiste (Ribbon) sowie des Buttons erfolgt über eine Konfiguration im Administrationsordner. Diese Konfiguration enthält ebenfalls Informationen wie der Client vorzugehen hat um die Aktion auszuführen.</span></p>\n\n<p><p><img src=\"guides/pD8CAD36E_33B3_4E82_A858_DE22E790DC9B/img1.png\" alt=\"\" width=\"1292\" height=\"1068\"></p></p>\n\n<h2 id='pD8CAD36E_33B3_4E82_A858_DE22E790DC9B-section-aufbau-der-multifunktionsleiste-im-client'>Aufbau der Multifunktionsleiste im Client</h2>\n\n<p>Während des Client Starts wird vom Java Client und Web Client eine Liste von verfügbaren Aktionen geladen. Auf Basis der zugrundeliegenden Konfiguration einer jeden Aktion wird anschließend u.a. die Multifunktionsleiste aufgebaut.\n<br>\nDiese Operation wird von der Klasse <a href=\"#!/api/sol.common.jc.ActionDefinitionUtils\" rel=\"sol.common.jc.ActionDefinitionUtils\" class=\"docClass\">sol.common.jc.ActionDefinitionUtils</a> (Java Client) bzw. <a href=\"#!/api/sol.common.web.ActionDefinitionUtils\" rel=\"sol.common.web.ActionDefinitionUtils\" class=\"docClass\">sol.common.web.ActionDefinitionUtils</a> (Web Client) durchgeführt. Das Sammeln aller Aktionen wird von dem Index Server <a\nhref=\"#!/guide/p4A156A44_F024_4918_BE64_496EA6C348F2\">Service</a> <code>sol.common.ix.services.RibbonDefinitionCollector</code> vorgenommen. <span\nstyle='font-weight:bold'>Dieser sorgt zusätzlich für eine serverseitige </span><a\nhref=\"#!/guide/p266BAF7F_7C89_416B_BF92_86FDD2C09E94\"><span\nstyle='font-weight:bold'>Lokalisierung</span></a><span style='font-weight:bold'> aller Texte.</span></p>\n\n<p><span class=\"tag_warning\">Diese Vorgehensweise trägt zusätzlich zu einer Optimierung Performance bei, da während des Clientstarts die Anzahl von benötigten Scripten reduziert werden kann.</span></p>\n\n<h2 id='pD8CAD36E_33B3_4E82_A858_DE22E790DC9B-section-einschr%C3%A4nken-der-sichtbarkeit-f%C3%BCr-unterschiedliche-anwender'>Einschränken der Sichtbarkeit für unterschiedliche Anwender</h2>\n\n<p>Mithilfe der ELO Berechtigungen kann zusätzlich gesteuert werden, welcher Anwender welche Funktionen in der Multifunktionsleiste angeboten bekommt.</p>\n\n<p><span class=\"tag_important\">Somit lässt sich für jede Aktion einer Lösung fein granular definieren, welche Gruppe bspw. das gesamte Tab Vertragsmanagement oder lediglich einzelne Funktionen sehen darf.</span></p>\n\n<blockquote><p><span\nstyle='font-weight:bold;font-style:italic'>Ein Beispiel:</span><span\nstyle='font-style:italic'> Jeder Anwender, der Leserechte auf die Funktion <code>sol.contract.CreateContract</code> besitzt bekommt auch den zugehörigen Button im Ribbon eingeblendet.</span></p></blockquote>\n\n<h2 id='pD8CAD36E_33B3_4E82_A858_DE22E790DC9B-section-beispiel-konfiguration-einer-einfachen-aktion'>Beispiel-Konfiguration einer einfachen Aktion</h2>\n\n<p>Die Konfiguration setzt sich aus der zugrundeliegenden Client Implementierung (Aktions-Typ), der Definition der Multifunktionsleiste (Ribbon) sowie den Informationen für das Ausführen der Aktion zusammen.</p>\n\n<h3 id='pD8CAD36E_33B3_4E82_A858_DE22E790DC9B-section-aktionstyp'>Aktionstyp</h3>\n\n<p>Aktionen können unterschiedlicher Natur sein. Um auf Sonderfälle gezielt einzugehen, stehen in den Clients eine Reihe von Implementierungen (<a\nhref=\"#!/guide/p5D40D60D_8A08_4E78_9785_7C705958C275\"><span\nstyle='font-weight:bold'>Aktionstypen</span></a>) bereit. Nachfolgendes Beispiel zeigt eine einfache Aktion <code>SIMPLE_ACTION</code>. Mithilfe einer <code>ADVANCED_ACTION</code> kann beispielsweise bevor die Aktion ausgelöst wurde noch ein Dialog zur Typ-Auswahl angeboten werden.</p>\n\n<h3 id='pD8CAD36E_33B3_4E82_A858_DE22E790DC9B-section-definition-der-multifunktionsleiste%3A'>Definition der Multifunktionsleiste:</h3>\n\n<p>Hier wird beschrieben welcher Button, welche Reiter oder Button-Gruppen benötigt werden. Die Konzepte orientieren sich dabei an den Scripting-Möglichkeiten von Web Client und Java Client. Nachfolgendes Beispiel zeigt zudem wie Oberflächen-Texte unter Angabe von <code>locale keys</code> <a\nhref=\"#!/guide/p266BAF7F_7C89_416B_BF92_86FDD2C09E94\">lokalisiert</a> werden können.</p>\n\n<p>Als Besonderheit muss für den Web Client zusätzlich ein <code>splitText</code> für den Button angegeben werden. Dieser enthält einen Zeilenumbruch, falls Texte zu lang werden. Bspw: &quot;Vertrag&lt;br/&gt;anlegen&quot;.</p>\n\n<h3 id='pD8CAD36E_33B3_4E82_A858_DE22E790DC9B-section-anweisungen-zum-ausf%C3%BChren-der-aktion'>Anweisungen zum Ausführen der Aktion</h3>\n\n<p>Klickt der Anwender auf einen Button wird vom Client zu definierte Aktion ausgeführt. Auf Basis des Aktionstyps wird der zugehörige Handler ausgewertet. Weitere Informationen können der Dokumentation zu <a\nhref=\"#!/guide/p5D40D60D_8A08_4E78_9785_7C705958C275\">Aktionstypen</a> entnommen werden.</p>\n\n<h3 id='pD8CAD36E_33B3_4E82_A858_DE22E790DC9B-section-abh%C3%A4ngige-aktionen'>Abhängige Aktionen</h3>\n\n<p>Ab der Version 1.03.000 werden die Aktions-Definitionen ein weiteres Property 'requiredModules' unterstützen.\nHier kann eine Liste von Modulen definiert werden, welche installiert sein müssen. Sollte eines der benötigten Module fehlen, wird der Button nicht an den Client ausgeliefert.</p>\n\n<p>So wird es möglich Aktionen zu definieren, welche von Drittmodulen abhängig sind, ohne dass es zu Fehlern kommt, sollten diese Module nicht installiert sein.</p>\n\n<p>Die Aktion im folgenden Beispiel wird nur an die Clients ausgeliefert, wenn das Modul <code>common_monitoring</code> installiert ist.</p>\n\n<pre><code>{\n  \"type\": \"SIMPLE_ACTION\",\n  \"ribbon\": {\n    …\n  },\n  \"action\": {\n    \"fct\": \"RF_sol_example_action_RegisterUpdate\",\n    \"cfgTemplate\": \"{\\\"objId\\\": \\\"{{objId}}\\\" }\",\n    \"requiredModules\": [\"common_monitoring\"]\n  }\n}\n</code></pre>\n\n<p><span class=\"tag_important\">Die Abhängigkeit zum Basis Paket (<code>common</code>) sollte nie extra angegeben werden, da die Existenz implizit garantiert ist.</span></p>\n\n<h3 id='pD8CAD36E_33B3_4E82_A858_DE22E790DC9B-section-beispiel-einer-index-server-aktion'>Beispiel einer Index Server Aktion</h3>\n\n<p><span class=\"tag_important\">In absehbarer Zeit wird es für die Konfiguration der Aktionen ebenfalls eine Oberfläche geben, sodass auf das Bearbeiten von JSON-Objekten verzichtet werden kann.</span></p>\n\n<pre><code>{\n  \"type\": \"SIMPLE_ACTION\",\n  \"ribbon\": {\n    \"ribbonTab\": {\n      \"name\": \"TAB_SOL_CONTRACT\",\n      \"text\": \"sol.contract.client.ribbon.tabContract\",\n      \"position\": 95\n    },\n    \"buttongroup\": {\n      \"name\": \"GRP_SOL_EDITCONTRACTS\",\n      \"mode\": \"big\",\n      \"text\": \"sol.contract.client.ribbon.bandEdit\",\n      \"position\": 20\n    },\n    \"button\": {\n      \"name\": \"BTN_SOL_CONTRACTINITATEAPPROVAL\",\n      \"text\": \"sol.contract.client.ribbon.btnInitiateApproval\",\n      \"splitText\": \"sol.contract.client.ribbon.btnInitiateApprovalSplit\",\n      \"tooltipText\": \"sol.contract.client.ribbon.btnInitiateApproval.tooltip\",\n      \"access\": {\n        \"document\": false,\n        \"folder\": true\n      },\n      \"web\": {\n        \"smallIcon\": \"sol-contract-initateapproval16\",\n        \"smallIconHighRes\": \"sol-contract-initateapproval16-200\",\n        \"bigIcon\": \"sol-contract-initateapproval32\",\n        \"bigIconHighRes\": \"sol-contract-initateapproval32-200\"\n      },\n      \"jc\": {\n        \"buttonId\": \"729\"\n      },\n      \"position\": 10\n    }\n  },\n  \"action\": {\n    \"fct\": \"RF_sol_contract_action_ApproveContract\",\n    \"cfgTemplate\": \"{\\\"objId\\\": \\\"{{objId}}\\\" }\"\n  }\n}\n</code></pre>\n\n<h3 id='pD8CAD36E_33B3_4E82_A858_DE22E790DC9B-section-beispiel-einer-elo-as-aktion'>Beispiel einer ELO AS Aktion</h3>\n\n<p>Wird eine Aktion als AS Regel implementiert muss dies in der Definition durch <span\nstyle='font-weight:bold'>&quot;type&quot;: &quot;AS&quot;</span> hinterlegt werden.</p>\n\n<p>Da unterschiedliche AS Instanzen für unterschiedliche Regeln zuständig sein können wird zudem der Name der Lösung benötigt. Der Web Client und Java Client versucht dabei innerhalb des Lösungspaketes eine AS-Konfiguration (<code>as.config</code>) zu finden. Findet sich im Lösungspaket keine spezifische ELO AS Konfiguration wird stets die des <code>common</code>-Paketes verwendet.</p>\n\n<p><p><img src=\"guides/pD8CAD36E_33B3_4E82_A858_DE22E790DC9B/img3.png\" alt=\"Administr ation\nBusiness Solutions\n_global\neloinst\nkeywording forms\nAll\nAll Rhino\nConfigurat&#39;on\nas config\" width=\"295\" height=\"220\"></p></p>\n\n<pre><code>{\n  \"type\": \"ADVANCED_ACTION\",\n  \"ribbon\": {\n    …\n  },\n  \"action\": {\n    \"fct\": \"sol.contract.as.actions.PrepareDocument\",\n    \"type\": \"AS\",\n    \"solution\": \"contract\",\n    \"cfgTemplate\": \"{\\\"parentId\\\": \\\"{{objId}}\\\", \\\"templateId\\\": \\\"{{tree.objId}}\\\" }\",\n    …\n  }\n}\n</code></pre>\n","title":"Definition (Action definition)"});
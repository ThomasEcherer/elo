# Services

Services stellen Funktionen bereit, deren Rückgaben von Clients eventuell weiterverarbeitet werden müssen. Dies könnte bspw. das Sammeln von Informationen im System oder das Überprüfen verschiedener Sachverhalte darstellen.

Services können daher verglichen mit <a
href="#!/guide/pADD870BA_9AA2_4900_8D6B_FA0FB26D9BEC">Funktionsbausteinen</a> hauptsächlich als Registered Function über die IX-Schnittstelle aufgerufen werden und haben keinen Einsatzzweck als Workflow-Baustein.

<span class="tag_important"><span
style='font-weight:bold'>Ein Beispiel wie ein Service implementiert werden kann,</span> findet sich in den Richtlinien zum <a
href="#!/guide/p948E2AF9_BBE2_4705_BB95_04478A9C7638">Indexserver-Scripting</a>.</span>

{@img img1.png}

## ELO Indexserver-Services 

### Aufruf über die IX-API als Registered Function

Services {{SERVIC}} können über Registered Functions aufgerufen werden. Hierzu steht eine Hilfsfunktion `execute` in den `IxUtils` zur Verfügung. 

    var data = sol.common.IxUtils.execute('RF_custom_services_MyService', {
      // Konfiguration des Services
    });
    
### Auszug der verfügbaren IX-Services

<table><thead><tr><td><span
style='font-weight:bold'>Name der Klasse</span></td><td><span
style='font-weight:bold'>Beschreibung</span></td></tr></thead><tbody><tr><td>    sol.common.ix.services.ActionDefinitionCollector</td><td><span
style='font-weight:bold'>Liefert eine Liste aller Action Definitions</span><br />Siehe auch <a
href="#!/guide/pD8CAD36E_33B3_4E82_A858_DE22E790DC9B">Definition (Action definition)</a>.</td></tr><tr><td>    sol.common.ix.services.ChildrenDataCollector</td><td><span
style='font-weight:bold'>Daten in kompakter Form sammeln</span><br />Sammelt Daten in kompakter Form, um Dashboards performanter mit Informationen zu versorgen.</td></tr><tr><td>    sol.common.ix.services.DownloadFileContent</td><td><span
style='font-weight:bold'>Dateiinhalt herunterladen</span></td></tr><tr><td>    sol.common.ix.services.ExecuteAsAction</td><td><span
style='font-weight:bold'>AS Regel ausführen</span><br />Dies erlaubt es Komponenten ohne DMZ auf den ELO AS zuzugreifen.</td></tr><tr><td>    sol.common.ix.services.GetBusinessSolutionConfigs</td><td><span
style='font-weight:bold'>Ermittelt alle Konfigurationsdateien einer Lösung</span></td></tr><tr><td>    sol.common.ix.services.GetConfig</td><td><span
style='font-weight:bold'>Liest eine JSON-Konfiguration</span></td></tr><tr><td>    sol.common.ix.services.GetWorkflowMetadata</td><td><span
style='font-weight:bold'>Sammelt Metadaten zu einem Workflow für ELO Apps</span></td></tr><tr><td>    sol.common.ix.services.KwlDataCollector</td><td><span
style='font-weight:bold'>Daten für Stichwortlisten und dynamische Stichwortlisten sammeln</span></td></tr><tr><td>    sol.common.ix.services.ScriptVersionReportCreate</td><td><span
style='font-weight:bold'>Versionsliste von Skripten erzeugen</span><br />Erzeugt eine Auflistung von Versionsinformationen der Skripte im Archiv, inkl. der Datei <span
style='font-style:italic'>MD5</span>.</td></tr><tr><td>    sol.common.ix.services.ScriptVersionReportValidate</td><td><span
style='font-weight:bold'>Versionsliste der Skripte abgleichen</span><br />Vergleicht die Versionsliste von <span
style='font-style:italic'>CreateJsonScriptVersionList</span> mit dem aktuellen Stand im Archiv und generiert einen HTML-Report.</td></tr><tr><td>    sol.common.ix.services.UploadFileContent</td><td><span
style='font-weight:bold'>Dateiinhalt zu bestehender Datei hochladen</span></td></tr></tbody></table>



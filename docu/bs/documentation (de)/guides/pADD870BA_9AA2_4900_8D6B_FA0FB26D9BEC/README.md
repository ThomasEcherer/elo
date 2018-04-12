# Funktionsbausteine

Verwendete Logik muss mithilfe von ELO-Funktionsbausteinen implementiert werden. Die Prämisse sieht vor, soweit wie möglich auf clientseitiges Scripting zu verzichten.

Grundlegend <span
style='font-weight:bold'>müssen Funktionsbausteine im Indexserver implementiert werden</span>, es sei denn es handelt sich um <span
style='font-weight:bold'>lastintensive oder langläufige</span> Aufgaben, die potentiell fehleranfällig sind. In diesem Fall ist eine<span
style='font-weight:bold'> ELOas-Regel</span> vorzuziehen. Import- und Export-Operationen sowie zeitlich gesteuerte Aktionen sind ebenfalls als AS-Regeln zu implementieren.

## ELO Indexserver-Funktionsbausteine

Funktionsbausteine können im Indexserver vereinfacht mit der Klasse `sol.common.ix.FunctionBase` implementiert werden. Diese stellt alle benötigten Grundfunktionen zur Verfügung. 

Bei der Konzeption eines Bausteins muss darauf geachtet werden, dass dieser wahlweise im Workflow als Knoten, aber auch über einen eigenen Registered Function-Aufruf aufgerufen werden kann. Je nach Anwendungsfall (bspw. bei `ChangeUser`) kann eine Registered Function dennoch nicht sinnvoll sein und kann vernachlässigt werden.

<span class="tag_important"><span
style='font-weight:bold'>Ein Beispiel wie ein Funktionsbaustein implementiert werden kann</span>, findet sich in den Richtlinien zum <a
href="#!/guide/p948E2AF9_BBE2_4705_BB95_04478A9C7638">Indexserver-Scripting</a>.</span>

### Aufruf über einen Workflow-Knoten

IX-Funktionsbausteine können als Start- oder Ende-Skript in Workflow-Knoten verwendet werden. Um ein einheitliches Bild zu erlangen und den Prozessablauf transparent zu halten, empfiehlt es sich, für jeden Funktionsaufruf einen eigenen Verteilungsknoten einzufügen und diesem ein entsprechendes Icon zu geben. Das Namensschema sollte sich wie folgt halten:

    {Module Name} : { Aktionsbeschreibung }
    Bsp.: CHANGECOLOR : Unprocessed invoice

Die <span
style='font-weight:bold'>Konfiguration des Bausteins</span> erfolgt anschließend über das Bemerkungs-Feld des Workflow-Knotens. Die Scripting-Dokumentation der Funktionsbausteine gibt die hier verfügbaren Config-Options. Grundlegend gilt, dass im Workflow-Knoten die Variable `objId` nicht gesetzt werden muss, da diese sich aus dem laufenden Workflow ableiten lässt.

{@img img1.png Versionen (I) 
Kopieren 
Berechtigungen 
FEEOCOMMENT : 
Start invoice approval 
CHANGECOLOR . 
• Unprocessed invo- 
r•e::' ZUGFeR0 
ELO Service 
ZUGFeRO Daten ausgelesen? 
AVOICE DATACOLLECT10N-ZUGFeRD 
FEEOCOMMENT : ZUGFeRD 
STATUS : 2 Formal check 
DEFAULTVALUES : Apply defaults 
CHANGEUSER : Formal check 
Übersetzungsvariable 
Ende-Skript 
SOL common tx functions ChangeCoIor 
Status 
Bemerkungen 
"color" "blue- )}


<span class="tag_caution"><span
style='font-weight:bold;color:#C00000'>Sicherheitshinweis: </span><span
style='font-weight:bold'>Bitte beachten Sie, dass Funktionsbausteine einen eigenen Knoten erhalten müssen und nicht über Benutzerknoten aufgerufen werden dürfen (Ausnahme: Service Accounts, bspw. ELOas)! Andernfalls können Benutzer beim Weiterleiten über ELO-Standard-Funktionalität die Konfiguration ändern.</span></span>

### Aufruf über die IX-API als Registered Function

Funktionsbausteine können ebenfalls über Registered Functions aufgerufen werden. Hierzu steht eine Hilfsfunktion `execute` in den `IxUtils` zur Verfügung. Verglichen mit dem Aufruf über einen Workflow-Knoten muss die Variable `objId` übergeben werden, da der Element-Kontext hier nicht bekannt ist.

    sol.common.IxUtils.execute('RF_sol_function_ChangeColor', {
      objId: "4711",
      color: "blue"
    });

### Auszug der verfügbaren IX-Funktionsbausteine

Im Folgenden wird ein Auszug der verfügbaren IX-Funktionsbausteine des Common-Pakets gegeben:

<table><thead><tr><td><span
style='font-weight:bold'>Name der Klasse</span></td><td><span
style='font-weight:bold'>Beschreibung</span></td></tr></thead><tbody><tr><td>    sol.common.ix.functions.ApplyDynKwl</td><td><span
style='font-weight:bold'>Metadaten aus Dynamischer Stichwortliste übernehmen</span><br />Fragt Werte von einer Dynamischen Stichwortliste an und speichert diese im aktuellen Eintrag.<br /></td></tr><tr><td>    sol.common.ix.functions.Blackening</td><td><span
style='font-weight:bold'>Schwärzung einbrennen</span><br />Brennt alle auf dem Dokument aufgebrachten Schwärzungen ein. <br />Versionskontrolle sollte ausgeschaltet sein.</td></tr><tr><td>    sol.common.ix.functions.ChangeColor</td><td><span
style='font-weight:bold'>Elementfarbe ändern</span><br />Ändert die Farbe eines Elements. </td></tr><tr><td>    sol.common.ix.functions.ChangeRights</td><td><span
style='font-weight:bold'>Benutzerrechte bearbeiten</span></td></tr><tr><td>    sol.common.ix.functions.ChangeUser</td><td><span
style='font-weight:bold'>Anwender des Folgeknotens ändern</span><br />Setzt den Anwender eines Folgeknotens nach einer <a
href="#!/guide/pBF712FB9_2914_4724_8DD8_A0139928B62D">Rollenkonfiguration</a>.</td></tr><tr><td>    sol.common.ix.functions.CheckMandatoryFields</td><td><span
style='font-weight:bold'>Mehrere Pflichtfelder prüfen</span><br />Entscheidungsmöglichkeit im Workflow auf mehrere Werte zu prüfen.</td></tr><tr><td>    sol.common.ix.functions.CopyFolderContents</td><td><span
style='font-weight:bold'>Verzeichnisinhalt aus Template übernehmen</span><br />Kopiert den gesamten Verzeichnisinhalt aus einem Template.</td></tr><tr><td>    sol.common.ix.functions.CopySordData</td><td><span
style='font-weight:bold'>Metadaten aus Template übernehmen</span><br />Kopiert alle Metadaten aus einem Template in das aktuelle Element.</td></tr><tr><td>    sol.common.ix.functions.CreateFromTemplate</td><td><span
style='font-weight:bold'>Erzeugt ein Dokument aus einem Template</span></td></tr><tr><td>    sol.common.ix.functions.Delete</td><td><span
style='font-weight:bold'>Eintrag löschen</span><br />Löscht einen Eintrag (Dokument / Ordner).</td></tr><tr><td>    sol.common.ix.functions.FeedComment</td><td><span
style='font-weight:bold'>Feed-Ereignis schreiben</span><br />Schreibt ein Prozessereignis in den Feed.</td></tr><tr><td>    sol.common.ix.functions.GenerateIdentifier</td><td><span
style='font-weight:bold'>Zeichen und Bezeichnungsgenerator</span><br />Erleichtert die Implementierung von Aktenzeichen und Bezeichnungsgeneratoren.</td></tr><tr><td>    sol.common.ix.functions.Inherit</td><td><span
style='font-weight:bold'>Erbt Metadaten vom Elternelement</span></td></tr><tr><td>    sol.common.ix.functions.IsoDate</td><td><span
style='font-weight:bold'>Aktuelles ISO-Datum als Status setzen</span><br />Schreibt das aktuelle Datum in ein Metafeld.</td></tr><tr><td>    sol.common.ix.functions.Move</td><td><span
style='font-weight:bold'>Element verschieben</span><br />Verschiebt ein Element in ELO an einen anderen Ort.</td></tr><tr><td>    sol.common.ix.functions.Notify</td><td><span
style='font-weight:bold'>Triggert eine ELO AS Regel um E-Mails zu versenden</span></td></tr><tr><td>    sol.common.ix.functions.RemoveAcl</td><td><span
style='font-weight:bold'>Berechtigungen entfernen</span><br />Entfernt bestimmte Berechtigungen vom Eintrag und speichert diese optional in ein Map-Feld. Agiert optional rekursiv.</td></tr><tr><td>    sol.common.ix.functions.RestoreAcl</td><td><span
style='font-weight:bold'>Berechtigungen wiederherstellen</span><br />Stellt die Berechtigungen für den Eintrag anhand des gespeicherten Wertes wieder her.</td></tr><tr><td>    sol.common.ix.functions.Set</td><td><span
style='font-weight:bold'>Wert setzen</span><br />Ändert Indexwerte, sowie Workflow-Map oder Map-Werte. Dieser Baustein ist eine komplexere Darstellung von sol.common.ix.functions.Status.</td></tr><tr><td>    sol.common.ix.functions.Status</td><td><span
style='font-weight:bold'>Status ändern</span><br />Ändert den Status eines Metafelds. <br />Dabei kann optional eine ID mithilfe einer Stichwortliste aufgelöst werden.</td></tr><tr><td>    sol.common.ix.functions.UserToIndex</td><td><span
style='font-weight:bold'>Aktuellen Benutzernamen in Indexfeld schreiben</span><br /></td></tr></tbody></table>
    

## ELOas-Funktionsbausteine

<table><thead><tr><td><span
style='font-weight:bold'>Name der Klasse</span></td><td><span
style='font-weight:bold'>Beschreibung</span></td></tr></thead><tbody><tr><td>    sol.common.as.functions.SendMail</td><td><span
style='font-weight:bold'>E-Mail versenden</span><br />Versenden einer E-Mail anhand eines Templates.<br /></td></tr><tr><td>    sol.common.as.functions.OfficeConverter</td><td><span
style='font-weight:bold'>Office-Dokumente konvertieren</span><br />Speichern von Office-Dokumenten wie bspw.<span
style='font-style:italic'> *.docx</span> in anderen Formaten.</td></tr></tbody></table>

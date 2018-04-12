# Installationspakete

<span class="tag_important">Die folgenden Konzepte benötigen das Modul <span
style='font-weight:bold;font-style:italic'>development</span>.</span>

Lösungen setzen sich aus verschiedenen Skripten, Konfigurationen, verwendeten Farben, Verschlagwortungsmasken etc. zusammen. Um diese schnell in ein neues System einspielen zu können, werden Installationspakete geschnürt, die alle benötigten Informationen enthalten. Diese Pakete tragen die Dateiendung <span
style='font-style:italic'>.eloinst</span>

Um Entwicklern das Erstellen von Installationspaketen zu vereinfachen, wurden einige einfache Mechanismen geschaffen, die Informationen für die <span
style='font-weight:bold'>Erstellung des Pakets</span> (build) und <span
style='font-weight:bold'>Aktionen beim Einspielen des Pakets</span> (install) über eine Konfiguration beschreiben können.

Unterhalb eines Lösungspakets (hier am Beispiel von <span
style='font-style:italic'>Business Solutions Invoice</span>) können in einem Ordner <span
style='font-style:italic'>.eloinst</span> Konfigurationen für das Installationspaket abgelegt werden. Diese müssen den Namenskonventionen <span
style='font-style:italic'>build</span> und <span style='font-style:italic'>install</span> folgen.

{@img img1.png Administration 
t:» _temp 
Business Solutions 
common 
elonst 
build 
Install 
C:' keywordng forms 
t) All Rhino 
t" Configuraticn 
C' Documentation}

## Installationsprozess

Die gesamte Installation wird durch die Klasse `sol.common.jc.SolutionInstaller` abgewickelt. Diese importiert zuerst den im Exportsatz enthaltenen Archivbereich. Da es sich hierbei um einen Standard-Archivexport/-import handelt, werden Masken, Stichwortlisten etc. ebenfalls übernommen. Anschließend werden im Exportsatz enthaltene Workflows importiert.

Abschließend werden Operationen ausgeführt, welche in der Konfiguration für den Installationsprozess hinterlegt wurden. Dies bezieht sich bspw. auf das Referenzieren von Elementen im Archiv oder das Hinzufügen von Farben.

## Konfiguration

Für die Konfiguration der Installationspakete stehen zusätzliche Apps bereit, die Oberflächen für die build- und install-JSON-Dateien anbieten. 

<span class="tag_important">Werden diese nicht angezeigt, fehlt eventuell die <span
style='font-style:italic'>ClientInfo</span>-Konfiguration im App-Manager des ELOwf, welche die GUID der Konfigurationsdatei im Archiv mit der zugehörigen App verknüpft.</span>

### Build

Die <span
style='font-style:italic'>Build</span>-Konfiguration enthält Informationen, welche Informationen aus dem bestehenden Archiv exportiert werden sollen. Dies bezieht sich bspw. auf das Verzeichnis für einen Archivexport oder eine Liste der gewünschten Workflows.

Eine genaue Beschreibung der einzelnen Funktionen kann der Konfigurations-App entnommen werden. Ein Beispiel für die Datei <span
style='font-weight:bold;font-style:italic'>build.json</span> zeigt sich wie folgt:

    {
      "setupName": "sol.invoice",
      "installConfigRepoPath": "ARCPATH:/Administration/Business solutions/invoice/.eloinst/install",    
      "exportRepoPath": "ARCPATH:/Administration/Business Solutions/invoice",
      "workflowTemplates1": ["ELOinvoice"]
    }


### Install

Die <span
style='font-style:italic'>Install</span>-Konfiguration enthält Operationen, die während der Installation ausgeführt werden sollen. Der häufigste Anwendungsfall ist hierbei das Referenzieren der Skripte aus dem Ordner <span
style='font-style:italic'>Administration\Business Solutions\</span> in die entsprechenden Ordner der ELO-Komponenten (bspw. ELOas). 

Eine genaue Beschreibung der einzelnen Funktionen kann der Konfigurations-App entnommen werden. Ein Beispiel für die Datei <span
style='font-weight:bold;font-style:italic'>install.json</span> zeigt sich wie folgt:

    {
      "setupName": "sol.common",
      "users": [  { "name": "user1", "type": "User" }  ],
      "colors": [  { "name": "color1", "rgb": "255" }  ],
      "refChildren":  [{ 
                          "source": "{{bsFolderPath}}/common/All",
                          "destinations": ["{{administrationFolderPath}}/ELOwf Base/Webapp",
                                            "{{administrationFolderPath}}/ELOas Base/JavaScript",
                                            "{{ixScriptingBaseFolderPath}}/_ALL/business_solutions",
                                            "{{jcScriptingBaseFolderPath}}/business_solutions",
                                            "{{bsFolderPath}}/common/ELOapps/Modules/sol.common.01"]
                        }, { 
                          "source": "{{bsFolderPath}}/common/ELOas Base",
                          "destinations": ["{{administrationFolderPath}}/ELOas Base"]
                        }, {
                          "source": "{{bsFolderPath}}/common/IndexServer Scripting Base",
                          "destinations": ["{{ixScriptingBaseFolderPath}}/_ALL/business_solutions"],
                          "ignoreSubfolders": true
                        }],
      "asConfigDialog": {  "configDestination": "{{bsFolderPath}}/common/Configuration/as.config"  },
      "reloads": {  "ix": true,  "apps": true  },
      "instAppModules": ["sol.common.01"]
    }

## Erstellen eines Installationspakets

Ein Installationspaket kann abschließend über die Funktion <span
style='font-weight:bold;font-style:italic'>Build setup package</span> erstellt werden. Der Client bietet einen <span
style='font-weight:bold;font-style:italic'>Speichern unter</span>-Dialog mit der erzeugten <span
style='font-style:italic'>.eloinst</span>-Datei an.

{@img img3.png ELO 
- BS Invoice (Nils Mosbach) 
DOKUMENT 
AUFGABEN 
WERKZEUGE 
DEVELOPMENT 
RECHNU 
Goto I d 
Tools 
Generate Validate 
report 
report 
Versions report 
auild Setup auild debug 
Package Setup Package 
Setup}

## Einspielen eines Installationspakets

<span
style='font-style:italic'>.eloinst</span>-Pakete können am einfachsten per Drag&amp;Drop in den Java Client eingespielt werden. Hierzu muss zuvor eine Anmeldung als Administrator erfolgt sein.

## Bereitstellen von Installationspaketen über eine Webseite

Alternativ können Pakete auch über <span
style='font-style:italic'>elodms://</span>-Links auf einer Webseite angeboten werden. Dabei muss der <span
style='font-weight:bold'>absolute </span>Pfad des Installationspakets base64-codiert (`BASE64ENCODEDURL`) übergeben werden:

    elodms://im/BASE64ENCODEDURL

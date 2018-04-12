Ext.data.JsonP.p0A73BAFE_D273_48DC_8AAB_55939E71BB61({"guide":"<h1 id='p0A73BAFE_D273_48DC_8AAB_55939E71BB61-section-installationspakete'>Installationspakete</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/p0A73BAFE_D273_48DC_8AAB_55939E71BB61-section-installationsprozess'>Installationsprozess</a>\n </li>\n<li>2. <a href='#!/guide/p0A73BAFE_D273_48DC_8AAB_55939E71BB61-section-konfiguration'>Konfiguration</a>\n </li>\n<li>3. <a href='#!/guide/p0A73BAFE_D273_48DC_8AAB_55939E71BB61-section-erstellen-eines-installationspakets'>Erstellen eines Installationspakets</a>\n </li>\n<li>4. <a href='#!/guide/p0A73BAFE_D273_48DC_8AAB_55939E71BB61-section-einspielen-eines-installationspakets'>Einspielen eines Installationspakets</a>\n </li>\n<li>5. <a href='#!/guide/p0A73BAFE_D273_48DC_8AAB_55939E71BB61-section-bereitstellen-von-installationspaketen-%C3%BCber-eine-webseite'>Bereitstellen von Installationspaketen über eine Webseite</a>\n </li>\n</ul></div>\n\n<p><span class=\"tag_important\">Die folgenden Konzepte benötigen das Modul <span\nstyle='font-weight:bold;font-style:italic'>development</span>.</span></p>\n\n<p>Lösungen setzen sich aus verschiedenen Skripten, Konfigurationen, verwendeten Farben, Verschlagwortungsmasken etc. zusammen. Um diese schnell in ein neues System einspielen zu können, werden Installationspakete geschnürt, die alle benötigten Informationen enthalten. Diese Pakete tragen die Dateiendung <span\nstyle='font-style:italic'>.eloinst</span></p>\n\n<p>Um Entwicklern das Erstellen von Installationspaketen zu vereinfachen, wurden einige einfache Mechanismen geschaffen, die Informationen für die <span\nstyle='font-weight:bold'>Erstellung des Pakets</span> (build) und <span\nstyle='font-weight:bold'>Aktionen beim Einspielen des Pakets</span> (install) über eine Konfiguration beschreiben können.</p>\n\n<p>Unterhalb eines Lösungspakets (hier am Beispiel von <span\nstyle='font-style:italic'>Business Solutions Invoice</span>) können in einem Ordner <span\nstyle='font-style:italic'>.eloinst</span> Konfigurationen für das Installationspaket abgelegt werden. Diese müssen den Namenskonventionen <span\nstyle='font-style:italic'>build</span> und <span style='font-style:italic'>install</span> folgen.</p>\n\n<p><p><img src=\"guides/p0A73BAFE_D273_48DC_8AAB_55939E71BB61/img1.png\" alt=\"Administration\nt:» _temp\nBusiness Solutions\ncommon\nelonst\nbuild\nInstall\nC:&#39; keywordng forms\nt) All Rhino\nt&quot; Configuraticn\nC&#39; Documentation\" width=\"395\" height=\"218\"></p></p>\n\n<h2 id='p0A73BAFE_D273_48DC_8AAB_55939E71BB61-section-installationsprozess'>Installationsprozess</h2>\n\n<p>Die gesamte Installation wird durch die Klasse <code>sol.common.jc.SolutionInstaller</code> abgewickelt. Diese importiert zuerst den im Exportsatz enthaltenen Archivbereich. Da es sich hierbei um einen Standard-Archivexport/-import handelt, werden Masken, Stichwortlisten etc. ebenfalls übernommen. Anschließend werden im Exportsatz enthaltene Workflows importiert.</p>\n\n<p>Abschließend werden Operationen ausgeführt, welche in der Konfiguration für den Installationsprozess hinterlegt wurden. Dies bezieht sich bspw. auf das Referenzieren von Elementen im Archiv oder das Hinzufügen von Farben.</p>\n\n<h2 id='p0A73BAFE_D273_48DC_8AAB_55939E71BB61-section-konfiguration'>Konfiguration</h2>\n\n<p>Für die Konfiguration der Installationspakete stehen zusätzliche Apps bereit, die Oberflächen für die build- und install-JSON-Dateien anbieten.</p>\n\n<p><span class=\"tag_important\">Werden diese nicht angezeigt, fehlt eventuell die <span\nstyle='font-style:italic'>ClientInfo</span>-Konfiguration im App-Manager des ELOwf, welche die GUID der Konfigurationsdatei im Archiv mit der zugehörigen App verknüpft.</span></p>\n\n<h3 id='p0A73BAFE_D273_48DC_8AAB_55939E71BB61-section-build'>Build</h3>\n\n<p>Die <span\nstyle='font-style:italic'>Build</span>-Konfiguration enthält Informationen, welche Informationen aus dem bestehenden Archiv exportiert werden sollen. Dies bezieht sich bspw. auf das Verzeichnis für einen Archivexport oder eine Liste der gewünschten Workflows.</p>\n\n<p>Eine genaue Beschreibung der einzelnen Funktionen kann der Konfigurations-App entnommen werden. Ein Beispiel für die Datei <span\nstyle='font-weight:bold;font-style:italic'>build.json</span> zeigt sich wie folgt:</p>\n\n<pre><code>{\n  \"setupName\": \"sol.invoice\",\n  \"installConfigRepoPath\": \"ARCPATH:/Administration/Business solutions/invoice/.eloinst/install\",    \n  \"exportRepoPath\": \"ARCPATH:/Administration/Business Solutions/invoice\",\n  \"workflowTemplates1\": [\"ELOinvoice\"]\n}\n</code></pre>\n\n<h3 id='p0A73BAFE_D273_48DC_8AAB_55939E71BB61-section-install'>Install</h3>\n\n<p>Die <span\nstyle='font-style:italic'>Install</span>-Konfiguration enthält Operationen, die während der Installation ausgeführt werden sollen. Der häufigste Anwendungsfall ist hierbei das Referenzieren der Skripte aus dem Ordner <span\nstyle='font-style:italic'>Administration\\Business Solutions\\</span> in die entsprechenden Ordner der ELO-Komponenten (bspw. ELOas).</p>\n\n<p>Eine genaue Beschreibung der einzelnen Funktionen kann der Konfigurations-App entnommen werden. Ein Beispiel für die Datei <span\nstyle='font-weight:bold;font-style:italic'>install.json</span> zeigt sich wie folgt:</p>\n\n<pre><code>{\n  \"setupName\": \"sol.common\",\n  \"users\": [  { \"name\": \"user1\", \"type\": \"User\" }  ],\n  \"colors\": [  { \"name\": \"color1\", \"rgb\": \"255\" }  ],\n  \"refChildren\":  [{ \n                      \"source\": \"{{bsFolderPath}}/common/All\",\n                      \"destinations\": [\"{{administrationFolderPath}}/ELOwf Base/Webapp\",\n                                        \"{{administrationFolderPath}}/ELOas Base/JavaScript\",\n                                        \"{{ixScriptingBaseFolderPath}}/_ALL/business_solutions\",\n                                        \"{{jcScriptingBaseFolderPath}}/business_solutions\",\n                                        \"{{bsFolderPath}}/common/ELOapps/Modules/sol.common.01\"]\n                    }, { \n                      \"source\": \"{{bsFolderPath}}/common/ELOas Base\",\n                      \"destinations\": [\"{{administrationFolderPath}}/ELOas Base\"]\n                    }, {\n                      \"source\": \"{{bsFolderPath}}/common/IndexServer Scripting Base\",\n                      \"destinations\": [\"{{ixScriptingBaseFolderPath}}/_ALL/business_solutions\"],\n                      \"ignoreSubfolders\": true\n                    }],\n  \"asConfigDialog\": {  \"configDestination\": \"{{bsFolderPath}}/common/Configuration/as.config\"  },\n  \"reloads\": {  \"ix\": true,  \"apps\": true  },\n  \"instAppModules\": [\"sol.common.01\"]\n}\n</code></pre>\n\n<h2 id='p0A73BAFE_D273_48DC_8AAB_55939E71BB61-section-erstellen-eines-installationspakets'>Erstellen eines Installationspakets</h2>\n\n<p>Ein Installationspaket kann abschließend über die Funktion <span\nstyle='font-weight:bold;font-style:italic'>Build setup package</span> erstellt werden. Der Client bietet einen <span\nstyle='font-weight:bold;font-style:italic'>Speichern unter</span>-Dialog mit der erzeugten <span\nstyle='font-style:italic'>.eloinst</span>-Datei an.</p>\n\n<p><p><img src=\"guides/p0A73BAFE_D273_48DC_8AAB_55939E71BB61/img3.png\" alt=\"ELO\n- BS Invoice (Nils Mosbach)\nDOKUMENT\nAUFGABEN\nWERKZEUGE\nDEVELOPMENT\nRECHNU\nGoto I d\nTools\nGenerate Validate\nreport\nreport\nVersions report\nauild Setup auild debug\nPackage Setup Package\nSetup\" width=\"751\" height=\"160\"></p></p>\n\n<h2 id='p0A73BAFE_D273_48DC_8AAB_55939E71BB61-section-einspielen-eines-installationspakets'>Einspielen eines Installationspakets</h2>\n\n<p><span\nstyle='font-style:italic'>.eloinst</span>-Pakete können am einfachsten per Drag&amp;Drop in den Java Client eingespielt werden. Hierzu muss zuvor eine Anmeldung als Administrator erfolgt sein.</p>\n\n<h2 id='p0A73BAFE_D273_48DC_8AAB_55939E71BB61-section-bereitstellen-von-installationspaketen-%C3%BCber-eine-webseite'>Bereitstellen von Installationspaketen über eine Webseite</h2>\n\n<p>Alternativ können Pakete auch über <span\nstyle='font-style:italic'>elodms://</span>-Links auf einer Webseite angeboten werden. Dabei muss der <span\nstyle='font-weight:bold'>absolute </span>Pfad des Installationspakets base64-codiert (<code>BASE64ENCODEDURL</code>) übergeben werden:</p>\n\n<pre><code>elodms://im/BASE64ENCODEDURL\n</code></pre>\n","title":"Installationspakete"});
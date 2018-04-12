# Java Client-Scripting

Im Java Client-Scripting sollte weitgehend auf clientseitiges Scripting verzichtet werden. Operationen wie bspw. das Anlegen von Ordnern sollten über IX-Funktionen implementiert werden, um diese Funktionen auch im Web Client zur Verfügung zu stellen.

Skripte im Java Client sollten zudem in `Main`-Klassen zusammengeführt werden, um einen zentralen Einstieg der verwendeten Klassen zu erhalten.

## Zusammenführen aller Skripte in einer Main-Klasse

Benötigte Skripte sollten in einer Klasse<span
style='font-weight:bold'> `Main`</span> zusammengeführt werden. Das erleichtert ein Debugging und sorgt für ein ordentliches Einbinden aller `include`-Aufrufe.

Hier als Beispiel die Klasse `sol.common.jc.Main` :

    importPackage(Packages.de.elo.ix.client);
    
    //@include lib_Class.js
    //@include lib_sol.common.Json.js
    //@include lib_sol.common.Compatibility.js
    //@include lib_sol.common.IxUtils.js
    //@include lib_sol.common.Config.js
    //@include lib_sol.common.jc.Functions.js
    //@include lib_sol.common.jc.Ribbon.js
    
    /**
     * @class sol.common.jc.Main
     * @singleton
     *
     * Contructs the JavaClient script.
     * Contains all necessary includes.
     *
     * # JavaClient resource files
     *
     * The resource files contain the text translation for the supported languages.
     *
     * - text_sol.common.client (default file with english texts)
     * - text_sol.common.client_DE
     *
     * # Scriptbutton Overview
     *
     * - Common->VersionsReport  Generate Report : 900
     * - Common->VersionsReport  Validate Report : 901
     *
     * @author Business Solutions, ELO Digital Office GmbH
     * @version 1.0
     *
     * @requires sol.common.Json
     * @requires sol.common.jc.Functions
     * @requires sol.common.jc.Ribbon
     */

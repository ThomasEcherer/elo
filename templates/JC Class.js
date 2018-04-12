
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
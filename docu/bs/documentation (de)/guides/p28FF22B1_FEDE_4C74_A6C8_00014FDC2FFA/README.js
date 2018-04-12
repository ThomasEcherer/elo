Ext.data.JsonP.p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA({"guide":"<h1 id='p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA-section-beispiel%3A-einfache-aktion'>Beispiel: Einfache Aktion</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA-section-definition-der-aktion'>Definition der Aktion</a>\n </li>\n<li>2. <a href='#!/guide/p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA-section-index-server-implementierung'>Index Server Implementierung</a>\n </li>\n<li>3. <a href='#!/guide/p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA-section-elo-workflow'>ELO Workflow</a>\n </li>\n<li>4. <a href='#!/guide/p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA-section-formular'>Formular</a>\n </li>\n<li>5. <a href='#!/guide/p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA-section-lokalisierung'>Lokalisierung</a>\n </li>\n</ul></div>\n\n<p><span class=\"tag_important\">Nachfolgend wird die zugrundeliegende Implementierung der Aktion &quot;Vertrag freigeben&quot; erläutert. </span></p>\n\n<p>Diese setzt sich aus folgenden Komponenten zusammen:</p>\n\n<ul>\n<li>Definition der Aktion</li>\n<li>Implementierung der Aktion im Index Server</li>\n<li>ELO Workflow</li>\n<li>ELO Formular</li>\n</ul>\n\n\n<p>Dabei wählt der Anwender einen bestehenden Vertrag in ELO aus und klickt in der Multifunktionsleiste auf &quot;Freigabe einleiten&quot;.</p>\n\n<p><p><img src=\"guides/p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA/img1.png\" alt=\"ELO contract\nVERTRÄGE\nFreigabe\nDOKUMENT\nANSICHT\nVertragsmanagement Archiv\nSuche\nDokument\nerze ugen\nDashboard\nAufgaben\n26\nNils\nMosbach\nFeed\nSTART\nVertrag\nAnlegen\nAUFGABEN\nNach Funktion suchen\nZahlungsplan\nVerhandlung\neinleiten\n9\nVertrag\nabgeschlossen\nKündigung\neinleiten\nDeckblatt\nerstellen\nDokumente\nZahlungsplan\nEtikett\nerstellen\nVerhandlung\nabgebrochen\nC62-Bürom iete Standort West\nVertrag\nC62-Büromiete Standort West\nLeitet die Freigabe des Vertragsentwurfs\nVertr\nDienstleistung\nKaufvertrag\nMietvertr ag\nHagen Immobilien GmbH\nt:» C62-Büromiete Standort VVest\nVertragsdaten\nAllgemein\nVertragslaueeit\nVertragsinhalt\" width=\"1100\" height=\"351\"></p></p>\n\n<p>Es öffnet sich anschließend ein Formular, welches es ermöglicht den nachfolgenden Prüfer auszuwählen und optional ein Kommentar zu hinterlassen.</p>\n\n<p><p><img src=\"guides/p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA/img3.png\" alt=\"Initiate approval\nStartthe approval process.\nFreigabedaten\nVertragsl\nNicht weiterleiten, nur Zwischenspeichern\nSpeichern Drucken\nNächster Bearbeitungsschritt\nOK Cancel\" width=\"1100\" height=\"603\"></p></p>\n\n<h2 id='p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA-section-definition-der-aktion'>Definition der Aktion</h2>\n\n<pre><code>{\n  \"type\": \"SIMPLE_ACTION\",\n  \"ribbon\": {\n    \"ribbonTab\": {\n      \"name\": \"TAB_SOL_CONTRACT\",\n      \"text\": \"sol.contract.client.ribbon.tabContract\",\n      \"position\": 95\n    },\n    \"buttongroup\": {\n      \"name\": \"GRP_SOL_EDITCONTRACTS\",\n      \"mode\": \"big\",\n      \"text\": \"sol.contract.client.ribbon.bandEdit\",\n      \"position\": 20\n    },\n    \"button\": {\n      \"name\": \"BTN_SOL_CONTRACTINITATEAPPROVAL\",\n      \"text\": \"sol.contract.client.ribbon.btnInitiateApproval\",\n      \"splitText\": \"sol.contract.client.ribbon.btnInitiateApprovalSplit\",\n      \"tooltipText\": \"sol.contract.client.ribbon.btnInitiateApproval.tooltip\",\n      \"tooltipTitle\": \"\",\n      \"access\": {\n        \"document\": false,\n        \"folder\": true\n      },\n      \"web\": {\n        \"smallIcon\": \"sol-contract-initateapproval16\",\n        \"smallIconHighRes\": \"sol-contract-initateapproval16-200\",\n        \"bigIcon\": \"sol-contract-initateapproval32\",\n        \"bigIconHighRes\": \"sol-contract-initateapproval32-200\"\n      },\n      \"jc\": {\n        \"buttonId\": \"729\"\n      },\n      \"position\": 10\n    }\n  },\n  \"action\": {\n    \"fct\": \"RF_sol_contract_action_ApproveContract\",\n    \"cfgTemplate\": \"{\\\"objId\\\": \\\"{{objId}}\\\" }\"\n  }\n}\n</code></pre>\n\n<h2 id='p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA-section-index-server-implementierung'>Index Server Implementierung</h2>\n\n<p>Die Implementierung der Aktion lädt dabei zuerst die Konfigurationsdatei in ELO und sucht in den Elternelementen nach einem Vertrag, falls das aktuelle ausgewählte Element kein Vertrag ist. Das wird benötigt, da Verträge Unterstrukturen enthalten können.</p>\n\n<p>Abschließend wird das Formular des ersten Benutzerknotens, welcher dem aktuellen Benutzer zugeordnet ist, ermittelt und als Event an den Client zurückgesendet.</p>\n\n<pre><code>importPackage(Packages.de.elo.ix.client);\nimportPackage(Packages.de.elo.ix.jscript);\n\n//@include lib_Class.js\n//@include lib_sol.common.Config.js\n//@include lib_sol.common.JsonUtils.js\n//@include lib_sol.common.SordUtils.js\n//@include lib_sol.common.IxUtils.js\n//@include lib_sol.common.WfUtils.js\n//@include lib_sol.common.RepoUtils.js\n//@include lib_sol.common.SordTypeUtils.js\n//@include lib_sol.common.Template.js\n//@include lib_sol.common.TranslateTerms.js\n//@include lib_sol.common.ix.RfUtils.js\n//@include lib_sol.common.ix.ActionBase.js\n//@include lib_sol.common.ix.FunctionBase.js\n//@include lib_sol.contract.ix.ContractUtils.js\n\n/**\n * Approve a contract\n * \n * @eloix\n * @requires <a href=\"#!/api/sol.common.Config\" rel=\"sol.common.Config\" class=\"docClass\">sol.common.Config</a>\n * @requires <a href=\"#!/api/sol.common.JsonUtils\" rel=\"sol.common.JsonUtils\" class=\"docClass\">sol.common.JsonUtils</a>\n * @requires <a href=\"#!/api/sol.common.SordUtils\" rel=\"sol.common.SordUtils\" class=\"docClass\">sol.common.SordUtils</a>\n * @requires <a href=\"#!/api/sol.common.IxUtils\" rel=\"sol.common.IxUtils\" class=\"docClass\">sol.common.IxUtils</a>\n * @requires <a href=\"#!/api/sol.common.CounterUtils\" rel=\"sol.common.CounterUtils\" class=\"docClass\">sol.common.CounterUtils</a>\n * @requires <a href=\"#!/api/sol.common.AclUtils\" rel=\"sol.common.AclUtils\" class=\"docClass\">sol.common.AclUtils</a>\n * @requires <a href=\"#!/api/sol.common.RepoUtils\" rel=\"sol.common.RepoUtils\" class=\"docClass\">sol.common.RepoUtils</a>\n * @requires <a href=\"#!/api/sol.common.Template\" rel=\"sol.common.Template\" class=\"docClass\">sol.common.Template</a>\n * @requires <a href=\"#!/api/sol.common.TranslateTerms\" rel=\"sol.common.TranslateTerms\" class=\"docClass\">sol.common.TranslateTerms</a>\n * @requires <a href=\"#!/api/sol.common.WfUtils\" rel=\"sol.common.WfUtils\" class=\"docClass\">sol.common.WfUtils</a>\n * @requires <a href=\"#!/api/sol.common.ix.RfUtils\" rel=\"sol.common.ix.RfUtils\" class=\"docClass\">sol.common.ix.RfUtils</a>\n * @requires <a href=\"#!/api/sol.common.ix.ActionBase\" rel=\"sol.common.ix.ActionBase\" class=\"docClass\">sol.common.ix.ActionBase</a>\n * @requires <a href=\"#!/api/sol.common.ix.FunctionBase\" rel=\"sol.common.ix.FunctionBase\" class=\"docClass\">sol.common.ix.FunctionBase</a>\n * @requires <a href=\"#!/api/sol.common.ix.functions.CopyFolderContents\" rel=\"sol.common.ix.functions.CopyFolderContents\" class=\"docClass\">sol.common.ix.functions.CopyFolderContents</a>\n * @requires <a href=\"#!/api/sol.common.ix.functions.CopySordData\" rel=\"sol.common.ix.functions.CopySordData\" class=\"docClass\">sol.common.ix.functions.CopySordData</a>\n * @requires sol.common.ContractUtils\n */\n<a href=\"#!/api/sol-static-method-define\" rel=\"sol-static-method-define\" class=\"docClass\">sol.define</a>(\"sol.contract.ix.actions.ApproveContract\", {\n  extend: \"<a href=\"#!/api/sol.common.ix.ActionBase\" rel=\"sol.common.ix.ActionBase\" class=\"docClass\">sol.common.ix.ActionBase</a>\",\n\n  requiredConfig: [\"ci\", \"user\", \"objId\"],\n\n  /** \n   * @cfg {de.elo.ix.client.ClientInfo} ci (required)\n   */\n\n  /** \n   * @cfg {de.elo.ix.client.UserInfo} user (required)\n   */\n\n  /**\n   * @cfg {String} templateId (required)\n   * Object ID of the template\n   */\n\n  initialize: function (config) {\n    var me = this;\n    me.$super(\"<a href=\"#!/api/sol.common.ix.ActionBase\" rel=\"sol.common.ix.ActionBase\" class=\"docClass\">sol.common.ix.ActionBase</a>\", \"initialize\", [config]);\n    me.config = sol.contract.ix.ContractUtils.loadConfig();\n  },\n\n  getName: function () {\n    return \"InitateApproval\";\n  },\n\n  process: function () {\n    var me = this,\n        contractSord, contractConfig, contractObjId,\n        wfPrefix, wfNumber, wfName,\n        flowId;\n\n    contractConfig = sol.contract.ix.ContractUtils.loadConfig();\n    contractSord = <a href=\"#!/api/sol.common.RepoUtils-method-findObjectTypeInHierarchy\" rel=\"sol.common.RepoUtils-method-findObjectTypeInHierarchy\" class=\"docClass\">sol.common.RepoUtils.findObjectTypeInHierarchy</a>(me.objId, contractConfig.objectTypes);\n    if (!contractSord) {\n      me.addErrorEvent(\"sol.contract.client.contract.msg.noContractFoundInHierarchy\", \"\", \"\", me.ci.language);\n      return;\n    }\n\n    contractObjId = contractSord.id;\n\n    wfPrefix = me.getLocalizedString(me.ci, contractConfig.workflows.approveContract.workflowPrefixKey);\n    wfNumber = me.actionId;\n    wfName = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(\"<a href=\"#!/api/sol.common.Template\" rel=\"sol.common.Template\" class=\"docClass\">sol.common.Template</a>\", { source: contractConfig.workflows.approveContract.workflowNameTemplate }).apply({ wfPrefix: wfPrefix, wfDate: new Date(), wfNumber: wfNumber });\n\n    flowId = me.startWorkflow(contractObjId, contractConfig.workflows.approveContract.workflowTemplateName, wfName);\n\n    me.addWfDialogEvent(flowId, { objId: contractObjId });\n  }\n});\n\n/**\n * @member sol.contract.ix.actions.ApproveContract\n * @method RF_sol_contract_action_ApproveContract\n * @static\n * @inheritdoc <a href=\"#!/api/sol.common.ix.FunctionBase-static-method-RF_FunctionName\" rel=\"sol.common.ix.FunctionBase-static-method-RF_FunctionName\" class=\"docClass\">sol.common.ix.FunctionBase.RF_FunctionName</a>\n */\nfunction RF_sol_contract_action_ApproveContract(ec, configAny) {\n  var rfUtils = <a href=\"#!/api/sol.common.ix.RfUtils\" rel=\"sol.common.ix.RfUtils\" class=\"docClass\">sol.common.ix.RfUtils</a>,\n      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny, \"objId\"),\n      approveContract;\n\n  config.ci = ec.ci;\n  config.user = ec.user;\n\n  approveContract = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(\"sol.contract.ix.actions.ApproveContract\", config);\n  return approveContract.execute();\n}\n</code></pre>\n\n<h2 id='p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA-section-elo-workflow'>ELO Workflow</h2>\n\n<p>Der erste Benutzerknoten enthält dabei ein Formular welches die Eingabe des Freigebers ermöglicht. Die Weiterleiten-Optionen <span\nstyle='font-weight:bold'>OK</span> und <span style='font-weight:bold'>cancel</span> werden dem Anwender später im Dialog angeboten.</p>\n\n<p><p><img src=\"guides/p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA/img5.png\" alt=\"iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\nsol.contract.contract.approval\nEigentümer\nSet approver\nEigentümer\nCancel\nSTATUS: Approval\nCHANGECOLOR: Approval initiated\nFEED: Approval initiated\nCHANGEUSER: Approval\nApproval\nEigentümer\nApprove\nSTATUS: Approved\nFEED: Approval comment\nContract approved\nEigentümer\nSTATUS: Drafi\nFEED : Approval rejected\nContract rejected\nEigentümer\nFinish\" width=\"572\" height=\"773\"></p></p>\n\n<h2 id='p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA-section-formular'>Formular</h2>\n\n<p>Das Formular kann dabei beliebig erweitert oder angepasst werden. In den ELO Business Solutions treten hier Tab-Gruppen zum Einsatz um die Formularlogik weiter zu modularisieren.</p>\n\n<p><p><img src=\"guides/p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA/img7.png\" alt=\"Tab-Gruppe bearbeiten\nTab-ID\nTabs\nUberschrift\nBaustein hinzufügen\nStartelement\nX Abbrechen\n310 contract approval dat _t•l\" width=\"804\" height=\"335\"></p></p>\n\n<p><p><img src=\"guides/p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA/img9.png\" alt=\"Neue Zeile\nNeue Spalte\nTabelle\nFreigabedaten\nP rüfer\nKommentar\nZeile löschen\nSpalte löschen\n— Eingabe\nDatum\nT Text\nEditor\nMarkierung\nSchalter\nInhalt einfügen\nAuswahl\nCombo\" width=\"658\" height=\"322\"></p></p>\n\n<h2 id='p28FF22B1_FEDE_4C74_A6C8_00014FDC2FFA-section-lokalisierung'>Lokalisierung</h2>\n\n<p>Alle verwendeten Lokalisierungsschlüssel werden dabei in den properties-Dateien hinterlegt. So bspw. auch der Schlüssel <code>sol.contract.client.ribbon.btnInitiateApproval</code>.</p>\n","title":"Beispiel: Einfache Aktion"});
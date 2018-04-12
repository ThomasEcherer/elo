Ext.data.JsonP.p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2({"guide":"<h1 id='p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2-section-beispiel%3A-erweiterte-aktion'>Beispiel: Erweiterte Aktion</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2-section-definition-der-aktion'>Definition der Aktion</a>\n </li>\n<li>2. <a href='#!/guide/p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2-section-index-server-implementierung-der-aktion'>Index Server Implementierung der Aktion</a>\n </li>\n<li>3. <a href='#!/guide/p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2-section-index-server-implementierung-des-dienstes-zur-ermittlung-der-vertragstypen'>Index Server Implementierung des Dienstes zur Ermittlung der Vertragstypen</a>\n </li>\n<li>4. <a href='#!/guide/p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2-section-elo-workflow'>ELO Workflow</a>\n </li>\n<li>5. <a href='#!/guide/p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2-section-formular'>Formular</a>\n </li>\n<li>6. <a href='#!/guide/p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2-section-lokalisierung'>Lokalisierung</a>\n </li>\n</ul></div>\n\n<p><span class=\"tag_important\">Nachfolgend wird die zugrundeliegende Implementierung der erweiterten Aktion &quot;Vertrag anlegen&quot; erläutert. </span></p>\n\n<p>Diese setzt sich aus folgenden Komponenten zusammen:</p>\n\n<ul>\n<li>Definition der Aktion</li>\n<li>Implementierung eines Services zur Ermittlung verfügbarer Aktentypen</li>\n<li>Implementierung der Aktion im Index Server</li>\n<li>ELO Workflow</li>\n<li>ELO Formular</li>\n</ul>\n\n\n<p>Dabei wählt der Anwender einen bestehenden Vertrag in ELO aus und klickt in der Multifunktionsleiste auf &quot;Freigabe einleiten&quot;.</p>\n\n<p><span class=\"tag_warning\">Die Aktion kann dabei Kontextlos ausgelöst werden. Somit können Verträge überall in ELO angelegt werden, die korrekte Auswahl eines Elternelements ist nicht notwendig.</span></p>\n\n<p><p><img src=\"guides/p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2/img1.png\" alt=\"ELO contract\nVERTRÄGE\nSTART\nDOKUMENT\nANSICHT\nVertragsmanagement Archiv\nSuche\nDokument\nerzeugen\nDashboard\nAufgaben\nNils\nMosbach\nFeed\nAUFGABEN\nNach Funktion suchen\nZahlungsplan\nWhandlung\neinleiten\nVertrag\nFreigabe\nein leiten\nDeckblatt\nerstellen\nDokumente\n9\nVertrag\nabgeschlossen\narbeiten\nKündigung\nein le ten\nVerhandlung\nabgebrochen\nBerichte\nEtikett\nerstellen\nLegt einen neuen Vertrag an\nC62-Bürom iete Standort West »\" width=\"1100\" height=\"207\"></p></p>\n\n<p><p><img src=\"guides/p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2/img3.png\" alt=\"ELO contract\nFreigabe\nVertragsmanagement\nVertrag auswählen\nArchiv\nSuche\nDashboard\nAufgaben\nVerhandlung\neinleiten\nBitte Wahlen Sie den anzulegenden Vertrags typ aus\nDienstleistung\nKaufvertrag\nMietvertrag\nMitarbeitervertrag\nRahmenvertrag\nStandard-Vertrag\nWartungsvertrag\nVertragsmanagement\nVerträge\nD Üienstleistung\nKaufvertrag\nMietvertrag\nHagen Immobilien GmbH\nCS2-8üromiete Standort\nRahmenvertrag\nStandard-Vertrag\nD: Wartungsvertrag\nNeues Üeckblatt\nAbbrechen\" width=\"1100\" height=\"559\"></p></p>\n\n<p>Es öffnet sich anschließend ein Formular, welches es ermöglicht den nachfolgenden Prüfer auszuwählen und optional ein Kommentar zu hinterlassen.</p>\n\n<p><p><img src=\"guides/p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2/img5.png\" alt=\"Vertragsl\nW-tr&quot; Standard-Vertr&quot;\nNeuer Vertrag\nFügen Sie einen neuen Vertrag hinzun\nVertragsinhalt\nNächster Bearbeitungsschritt\nAnlegen Cancel\nVertragsdaten\nAllgemein\nMa nda nt\nBuchungskreis\nVertragslaueeit\nStandard-Vertr ag\nZahlungsplan\nAblageort\nMandant\nN achname\nVertragspartner\nFirma\nVertragsdaten\nNicht weiterleiten, nur Zwischenspeichern\nSpeichern Drucken\" width=\"1100\" height=\"599\"></p></p>\n\n<h2 id='p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2-section-definition-der-aktion'>Definition der Aktion</h2>\n\n<pre><code>{\n  \"type\": \"ADVANCED_ACTION\",\n  \"ribbon\": {\n    \"ribbonTab\": {\n      \"name\": \"TAB_SOL_CONTRACT\",\n      \"text\": \"sol.contract.client.ribbon.tabContract\",\n      \"position\": 95\n    },\n    \"buttongroup\": {\n      \"name\": \"GRP_SOL_CONTRACT_CREATE\",\n      \"mode\": \"big\",\n      \"text\": \"sol.contract.client.ribbon.bandCreate\",\n      \"position\": 10\n    },\n    \"button\": {\n      \"name\": \"BTN_SOL_CONTRACT_CREATECONTRACT\",\n      \"text\": \"sol.contract.client.ribbon.btnCreateContract\",\n      \"splitText\": \"sol.contract.client.ribbon.btnCreateContractSplit\",\n      \"tooltipText\": \"sol.contract.client.ribbon.btnCreateContract.tooltip\",\n      \"tooltipTitle\": \"\",\n      \"access\": {\n        \"document\": true,\n        \"folder\": true\n      },\n      \"web\": {\n        \"iconName\": \"sol-contract-createcontract\",\n        \"smallIcon\": \"sol-contract-createcontract16\",\n        \"smallIconHighRes\": \"sol-contract-createcontract16-200\",\n        \"bigIcon\": \"sol-contract-createcontract32\",\n        \"bigIconHighRes\": \"sol-contract-createcontract32-200\"\n      },\n      \"jc\": {\n        \"buttonId\": \"728\"\n      },\n      \"position\": 10,\n      \"asTile\": true\n    }\n  },\n  \"action\": {\n    \"selectType\": {\n      \"fct\": \"RF_sol_contract_service_GetContractTypes\"\n    },\n    \"fct\": \"RF_sol_contract_action_CreateContract\",\n    \"cfgTemplate\": \"{\\\"contractType\\\": \\\"{{type.name}}\\\", \\\"templateId\\\": \\\"{{type.objId}}\\\" }\",\n    \"locale\": {\n      \"errorDlgTitle\": \"sol.pubsec.client.file.create.dialog.error.title\",\n      \"typesDlgTitle\": \"sol.contract.client.contract.create.dialog.title\",\n      \"typesDlgHeader\": \"sol.contract.client.contract.create.dialog.header\",\n      \"typesDlgText\": \"sol.contract.client.contract.create.dialog.text\",\n      \"typesDlgNoTypes\": \"sol.contract.client.contract.create.msg.notype\"\n    }\n  }\n}\n</code></pre>\n\n<h2 id='p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2-section-index-server-implementierung-der-aktion'>Index Server Implementierung der Aktion</h2>\n\n<p>Die Implementierung der Aktion lädt dabei zuerst die Konfigurationsdatei in ELO. Als Vorbedingung muss durch den Client eine Template-ID ausgewählt werden. Dies ist ein Element, welches in</p>\n\n<p>Abschließend wird das Formular des ersten Benutzerknotens, welcher dem aktuellen Benutzer zugeordnet ist, ermittelt und als Event an den Client zurückgesendet. Zusätzlich wird der Client angewiesen ein Goto auf das neu erzeugte Element anzulegen.</p>\n\n<pre><code>importPackage(Packages.de.elo.ix.client);\nimportPackage(Packages.de.elo.ix.jscript);\n\n//@include lib_Class.js\n//@include lib_sol.common.Config.js\n//@include lib_sol.common.JsonUtils.js\n//@include lib_sol.common.SordUtils.js\n//@include lib_sol.common.IxUtils.js\n//@include lib_sol.common.WfUtils.js\n//@include lib_sol.common.CounterUtils.js\n//@include lib_sol.common.AclUtils.js\n//@include lib_sol.common.RepoUtils.js\n//@include lib_sol.common.Template.js\n//@include lib_sol.common.TranslateTerms.js\n//@include lib_sol.common.ix.RfUtils.js\n//@include lib_sol.common.ix.ActionBase.js\n//@include lib_sol.common.ix.FunctionBase.js\n//@include lib_sol.contract.ix.ContractUtils.js\n\n\n/**\n * Creates a new new contract.\n * \n * @eloix\n * @requires <a href=\"#!/api/sol.common.Config\" rel=\"sol.common.Config\" class=\"docClass\">sol.common.Config</a>\n * @requires <a href=\"#!/api/sol.common.JsonUtils\" rel=\"sol.common.JsonUtils\" class=\"docClass\">sol.common.JsonUtils</a>\n * @requires <a href=\"#!/api/sol.common.SordUtils\" rel=\"sol.common.SordUtils\" class=\"docClass\">sol.common.SordUtils</a>\n * @requires <a href=\"#!/api/sol.common.IxUtils\" rel=\"sol.common.IxUtils\" class=\"docClass\">sol.common.IxUtils</a>\n * @requires <a href=\"#!/api/sol.common.CounterUtils\" rel=\"sol.common.CounterUtils\" class=\"docClass\">sol.common.CounterUtils</a>\n * @requires <a href=\"#!/api/sol.common.AclUtils\" rel=\"sol.common.AclUtils\" class=\"docClass\">sol.common.AclUtils</a>\n * @requires <a href=\"#!/api/sol.common.RepoUtils\" rel=\"sol.common.RepoUtils\" class=\"docClass\">sol.common.RepoUtils</a>\n * @requires <a href=\"#!/api/sol.common.Template\" rel=\"sol.common.Template\" class=\"docClass\">sol.common.Template</a>\n * @requires <a href=\"#!/api/sol.common.TranslateTerms\" rel=\"sol.common.TranslateTerms\" class=\"docClass\">sol.common.TranslateTerms</a>\n * @requires <a href=\"#!/api/sol.common.WfUtils\" rel=\"sol.common.WfUtils\" class=\"docClass\">sol.common.WfUtils</a>\n * @requires <a href=\"#!/api/sol.common.ix.RfUtils\" rel=\"sol.common.ix.RfUtils\" class=\"docClass\">sol.common.ix.RfUtils</a>\n * @requires <a href=\"#!/api/sol.common.ix.ActionBase\" rel=\"sol.common.ix.ActionBase\" class=\"docClass\">sol.common.ix.ActionBase</a>\n * @requires <a href=\"#!/api/sol.common.ix.FunctionBase\" rel=\"sol.common.ix.FunctionBase\" class=\"docClass\">sol.common.ix.FunctionBase</a>\n * @requires <a href=\"#!/api/sol.common.ix.functions.CopyFolderContents\" rel=\"sol.common.ix.functions.CopyFolderContents\" class=\"docClass\">sol.common.ix.functions.CopyFolderContents</a>\n * @requires <a href=\"#!/api/sol.common.ix.functions.CopySordData\" rel=\"sol.common.ix.functions.CopySordData\" class=\"docClass\">sol.common.ix.functions.CopySordData</a>\n * @requires sol.common.ContractUtils\n */\n<a href=\"#!/api/sol-static-method-define\" rel=\"sol-static-method-define\" class=\"docClass\">sol.define</a>(\"sol.contract.ix.actions.CreateContract\", {\n  extend: \"<a href=\"#!/api/sol.common.ix.ActionBase\" rel=\"sol.common.ix.ActionBase\" class=\"docClass\">sol.common.ix.ActionBase</a>\",\n\n  requiredConfig: [\"ci\", \"user\", \"contractType\"],\n\n  /** \n   * @cfg {de.elo.ix.client.ClientInfo} ci (required)\n   */\n\n  /** \n   * @cfg {de.elo.ix.client.UserInfo} user (required)\n   */\n\n  /**\n   * @cfg {String} templateId (required)\n   * Object ID of the template\n   */\n\n  initialize: function (config) {\n    var me = this;\n    me.$super(\"<a href=\"#!/api/sol.common.ix.ActionBase\" rel=\"sol.common.ix.ActionBase\" class=\"docClass\">sol.common.ix.ActionBase</a>\", \"initialize\", [config]);\n    me.config = sol.contract.ix.ContractUtils.loadConfig();\n  },\n\n  getName: function () {\n    return \"CreateContract\";\n  },\n\n  process: function () {\n    var me = this,\n        name, objId, flowId, sord,\n        objectType;\n\n    if (!me.templateId) {\n      me.addErrorEvent(\"sol.contract.ix.actions.CreateContract.error.target\", null, null, me.ci);\n      return;\n    }\n\n    name = me.buildElementName();\n\n    objId = <a href=\"#!/api/sol.common.IxUtils-method-execute\" rel=\"sol.common.IxUtils-method-execute\" class=\"docClass\">sol.common.IxUtils.execute</a>(\"RF_sol_function_CopyFolderContents\", {\n      objId: \"0\",\n      source: me.templateId,\n      copySourceAcl: false,\n      inheritDestinationAcl: false,\n      name: me.contractType + \" - \" + me.getTimeStampString(),\n      asAdmin: true\n    });\n\n    sord = <a href=\"#!/api/sol.common.RepoUtils-method-getSord\" rel=\"sol.common.RepoUtils-method-getSord\" class=\"docClass\">sol.common.RepoUtils.getSord</a>(objId);\n\n    objectType = me.config.objectTypes[0];\n\n    <a href=\"#!/api/sol.common.SordUtils-method-setObjKeyValue\" rel=\"sol.common.SordUtils-method-setObjKeyValue\" class=\"docClass\">sol.common.SordUtils.setObjKeyValue</a>(sord, me.config.fields.objectType, objectType);\n    <a href=\"#!/api/sol.common.SordUtils-method-setObjKeyValue\" rel=\"sol.common.SordUtils-method-setObjKeyValue\" class=\"docClass\">sol.common.SordUtils.setObjKeyValue</a>(sord, me.config.fields.contractType, me.contractType);\n    ixConnect.ix().checkinSord(sord, SordC.mbAllIndex, LockC.NO);    \n\n    flowId = me.startMaskStandardWorkflow(objId, { name: name, field: me.config.fields.defaultWorkflow });\n\n    if (flowId) {\n      me.addWfDialogEvent(flowId, { objId: objId, title: name });\n    }\n\n    me.addGotoIdEvent(objId);\n  },\n\n  /**\n   * @private\n   */\n  buildElementName: function () {\n    var me = this,\n        prefix;\n\n    prefix = me.getLocalizedString(me.ci, me.config.workflows.createContract.workflowPrefixKey);\n    return <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(\"<a href=\"#!/api/sol.common.Template\" rel=\"sol.common.Template\" class=\"docClass\">sol.common.Template</a>\", { source: me.config.workflows.createContract.workflowNameTemplate }).apply({ wfPrefix: prefix, contractType: me.contractType });\n  },\n\n  /**\n   * @private\n   */\n  getTimeStampString: function () {\n    return String(Packages.org.apache.commons.lang.time.DateFormatUtils.format(new java.util.Date(), \"yyyyMMddHHmmss\"));\n  },\n});\n\n/**\n * @member sol.contract.ix.actions.CreateContract\n * @method RF_sol_contract_action_CreateContract\n * @static\n * @inheritdoc <a href=\"#!/api/sol.common.ix.FunctionBase-static-method-RF_FunctionName\" rel=\"sol.common.ix.FunctionBase-static-method-RF_FunctionName\" class=\"docClass\">sol.common.ix.FunctionBase.RF_FunctionName</a>\n */\nfunction RF_sol_contract_action_CreateContract(ec, configAny) {\n  var rfUtils = <a href=\"#!/api/sol.common.ix.RfUtils\" rel=\"sol.common.ix.RfUtils\" class=\"docClass\">sol.common.ix.RfUtils</a>,\n      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny, \"contractType\", \"templateId\"),\n      createContract;\n\n  config.ci = ec.ci;\n  config.user = ec.user;\n\n  createContract = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(\"sol.contract.ix.actions.CreateContract\", config);\n  return createContract.execute();\n}\n</code></pre>\n\n<h2 id='p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2-section-index-server-implementierung-des-dienstes-zur-ermittlung-der-vertragstypen'>Index Server Implementierung des Dienstes zur Ermittlung der Vertragstypen</h2>\n\n<p>Ein Vertragstyp wird dabei durch eine Vorlage für den Vertrag im Konfigurationsbereich definiert. Diese Vorlage wird beim Anlegen kopiert, wodurch Metadaten vorbelegt und Strukturen der Vertragsakte übernommen werden können.</p>\n\n<p><p><img src=\"guides/p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2/img7.png\" alt=\"contract\nAdminis tr ation\nBusiness Solutions\n_global\nCommon\nCommon fx\ncommon_monitoring\nConnector dx\nConnector xml\ncontract\neloinst\nkeywording forms\nAction definitions\nAll Rhino\nConfiguration\nCOntract types\ntletstung\nKaufvertrag\nMietvertr ag\nWarbeitervertrag\nStandard-Vertr ag\nWartungsvertrag\" width=\"279\" height=\"533\"></p></p>\n\n<p>Vertragsakten werden zu diesem Zeitpunkt in der Chaosablage abgelegt und später im Workflow an die korrekte Position verschoben.</p>\n\n<pre><code>importPackage(Packages.de.elo.ix.client);\n\n//@include lib_Class.js\n//@include lib_sol.common.Config.js\n//@include lib_sol.common.JsonUtils.js\n//@include lib_sol.common.SordUtils.js\n//@include lib_sol.common.RepoUtils.js\n//@include lib_sol.common.TranslateTerms.js\n//@include lib_sol.common.ix.RfUtils.js\n//@include lib_sol.common.ix.ServiceBase.js\n//@include lib_sol.contract.ix.ContractUtils.js\n\n/**\n * Retrieves the available contract types.\n *\n * @author JHR, ELO Digital Office GmbH\n *\n * @eloix\n * @requires <a href=\"#!/api/sol.common.Config\" rel=\"sol.common.Config\" class=\"docClass\">sol.common.Config</a>\n * @requires <a href=\"#!/api/sol.common.JsonUtils\" rel=\"sol.common.JsonUtils\" class=\"docClass\">sol.common.JsonUtils</a>\n * @requires <a href=\"#!/api/sol.common.SordUtils\" rel=\"sol.common.SordUtils\" class=\"docClass\">sol.common.SordUtils</a>\n * @requires <a href=\"#!/api/sol.common.RepoUtils\" rel=\"sol.common.RepoUtils\" class=\"docClass\">sol.common.RepoUtils</a>\n * @requires <a href=\"#!/api/sol.common.TranslateTerms\" rel=\"sol.common.TranslateTerms\" class=\"docClass\">sol.common.TranslateTerms</a>\n * @requires <a href=\"#!/api/sol.common.ix.RfUtils\" rel=\"sol.common.ix.RfUtils\" class=\"docClass\">sol.common.ix.RfUtils</a>\n * @requires <a href=\"#!/api/sol.common.ix.ServiceBase\" rel=\"sol.common.ix.ServiceBase\" class=\"docClass\">sol.common.ix.ServiceBase</a>\n * @requires sol.contract.ix.ContractUtils\n */\n<a href=\"#!/api/sol-static-method-define\" rel=\"sol-static-method-define\" class=\"docClass\">sol.define</a>(\"sol.contract.ix.services.GetContractTypes\", {\n  extend: \"<a href=\"#!/api/sol.common.ix.ServiceBase\" rel=\"sol.common.ix.ServiceBase\" class=\"docClass\">sol.common.ix.ServiceBase</a>\",\n\n  initialize: function (config) {\n    var me = this;\n    me.$super(\"<a href=\"#!/api/sol.common.ix.ServiceBase\" rel=\"sol.common.ix.ServiceBase\" class=\"docClass\">sol.common.ix.ServiceBase</a>\", \"initialize\", [config]);\n    me.config = sol.contract.ix.ContractUtils.loadConfig();\n  },\n\n  /**\n   * Retrieves the data as spezified in the constructor configuration.\n   * @returns {String[]} Array with contract types\n   */\n  process: function () {\n    var me = this,\n        searchConfig = {},\n        contractTemplates;\n\n    searchConfig.includeFolders = true;\n    searchConfig.includeDocuments = false;\n    searchConfig.includeReferences = true;\n    searchConfig.sordZ = SordC.mbAllIndex;\n\n    contractTemplates = <a href=\"#!/api/sol.common.RepoUtils-method-findChildren\" rel=\"sol.common.RepoUtils-method-findChildren\" class=\"docClass\">sol.common.RepoUtils.findChildren</a>(me.config.templateFolderId, searchConfig);\n    return me.convertTemplateSords(contractTemplates);\n  },\n\n  /**\n   * @private\n   * Converts from Sords to Objects\n   * @param {de.elo.ix.client.Sord[]} reportTemplateSords\n   * @returns {Object[]}\n   */\n  convertTemplateSords: function (reportTemplateSords) {\n    var converted = [];\n    if (reportTemplateSords) {\n      reportTemplateSords.forEach(function (sord) {\n        converted.push({\n          objId: sord.id,\n          name: sord.name,\n          desc: sord.desc\n        });\n      });\n    }\n    return converted;\n  }\n});\n\n/**\n * @member sol.contract.ix.services.GetContractTypes\n * @method RF_sol_common_service_GetContractTypes\n * @static\n * @inheritdoc <a href=\"#!/api/sol.common.ix.ServiceBase-static-method-RF_ServiceBaseName\" rel=\"sol.common.ix.ServiceBase-static-method-RF_ServiceBaseName\" class=\"docClass\">sol.common.ix.ServiceBase.RF_ServiceBaseName</a>\n */\nfunction RF_sol_contract_service_GetContractTypes(iXSEContext, args) {\n  var rfUtils = <a href=\"#!/api/sol.common.ix.RfUtils\" rel=\"sol.common.ix.RfUtils\" class=\"docClass\">sol.common.ix.RfUtils</a>,\n      config = rfUtils.parseAndCheckParams(iXSEContext, arguments.callee.name, args),\n      service;\n\n  service = <a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>(\"sol.contract.ix.services.GetContractTypes\", config);\n  return rfUtils.stringify(service.process());\n}\n</code></pre>\n\n<h2 id='p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2-section-elo-workflow'>ELO Workflow</h2>\n\n<p>Der erste Benutzerknoten enthält dabei ein Formular welches die Eingabe aller Vertragsdaten ermöglicht. Die Weiterleiten-Optionen <span\nstyle='font-weight:bold'>OK</span> und <span style='font-weight:bold'>cancel</span> werden dem Anwender später im Dialog angeboten. Bricht der Anwender die Erstellung ab, wird da zuvor angelegte Vertragsobjekt wieder gelöscht.</p>\n\n<p><p><img src=\"guides/p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2/img9.png\" alt=\"sol.contract.contract.create\nEigentümer\nData entry\nEigentümer\ncreate\nMOVE : contract\nGENERATOR : contract no.\nGENERATOR : short description\nFEED : contract created\nCancel\nDELETE : temporary record\" width=\"498\" height=\"484\"></p></p>\n\n<h2 id='p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2-section-formular'>Formular</h2>\n\n<p>Das Formular kann dabei beliebig erweitert oder angepasst werden. In den ELO Business Solutions treten hier Tab-Gruppen zum Einsatz um die Formularlogik weiter zu modularisieren.</p>\n\n<p><p><img src=\"guides/p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2/img11.png\" alt=\"Tab-Gruppe bearbeiten\nTab-ID\nTabs\nUberschrift\ncontract form\nBaustein hinzufügen\nStartelement\nX Abbrechen\n110 contract_general all\n111 contract company all\n120 contract_partner all\n130 contract data all\n140 contract_proJect all\n150 contract duration all\n160 contract subjectmatte\n180 contract_paymentplan\" width=\"804\" height=\"574\"></p></p>\n\n<p>Nachfolge Abbildung zeigt ein Beispiel des Formulartemplates <code>110_contract_general_all</code>.</p>\n\n<p><p><img src=\"guides/p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2/img13.png\" alt=\"Neue Zeile\nNeue Spalte\nZeile löschen\nSpalte löschen\n— Eingabe\nDatum\nT Text\nEditor\nMarkierung\nSchalter\nInhalteinfügen\nAuswahl\nCombo\nLink\nLöschen\nverbinden\nTrennen\nTabelle\nsol .contract.form .general\nsol. contract.form. contractName\nsol.contract.form.type\nsol. contract.form.relation\nsol. contract.form. filingLocation\nsol. contract.form.status\" width=\"923\" height=\"314\"></p></p>\n\n<h2 id='p36A4F8B3_CEF3_4036_B000_4690E0ECF8C2-section-lokalisierung'>Lokalisierung</h2>\n\n<p>Alle verwendeten Lokalisierungsschlüssel werden dabei in den properties-Dateien hinterlegt. So bspw. auch der Schlüssel <code>sol.contract.client.ribbon.btnCreateContract</code>.</p>\n","title":"Beispiel: Erweiterte Aktion"});
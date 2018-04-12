# Beispiel: Erweiterte Aktion

<span class="tag_important">Nachfolgend wird die zugrundeliegende Implementierung der erweiterten Aktion &quot;Vertrag anlegen&quot; erläutert. </span>

Diese setzt sich aus folgenden Komponenten zusammen:

*   Definition der Aktion
*   Implementierung eines Services zur Ermittlung verfügbarer Aktentypen
*   Implementierung der Aktion im Index Server
*   ELO Workflow
*   ELO Formular

Dabei wählt der Anwender einen bestehenden Vertrag in ELO aus und klickt in der Multifunktionsleiste auf &quot;Freigabe einleiten&quot;. 

<span class="tag_warning">Die Aktion kann dabei Kontextlos ausgelöst werden. Somit können Verträge überall in ELO angelegt werden, die korrekte Auswahl eines Elternelements ist nicht notwendig.</span>

{@img img1.png ELO contract 
VERTRÄGE 
START 
DOKUMENT 
ANSICHT 
Vertragsmanagement Archiv 
Suche 
Dokument 
erzeugen 
Dashboard 
Aufgaben 
Nils 
Mosbach 
Feed 
AUFGABEN 
Nach Funktion suchen 
Zahlungsplan 
Whandlung 
einleiten 
Vertrag 
Freigabe 
ein leiten 
Deckblatt 
erstellen 
Dokumente 
9 
Vertrag 
abgeschlossen 
arbeiten 
Kündigung 
ein le ten 
Verhandlung 
abgebrochen 
Berichte 
Etikett 
erstellen 
Legt einen neuen Vertrag an 
C62-Bürom iete Standort West »}



{@img img3.png ELO contract 
Freigabe 
Vertragsmanagement 
Vertrag auswählen 
Archiv 
Suche 
Dashboard 
Aufgaben 
Verhandlung 
einleiten 
Bitte Wahlen Sie den anzulegenden Vertrags typ aus 
Dienstleistung 
Kaufvertrag 
Mietvertrag 
Mitarbeitervertrag 
Rahmenvertrag 
Standard-Vertrag 
Wartungsvertrag 
Vertragsmanagement 
Verträge 
D Üienstleistung 
Kaufvertrag 
Mietvertrag 
Hagen Immobilien GmbH 
CS2-8üromiete Standort 
Rahmenvertrag 
Standard-Vertrag 
D: Wartungsvertrag 
Neues Üeckblatt 
Abbrechen}

Es öffnet sich anschließend ein Formular, welches es ermöglicht den nachfolgenden Prüfer auszuwählen und optional ein Kommentar zu hinterlassen.

{@img img5.png Vertragsl 
W-tr" Standard-Vertr" 
Neuer Vertrag 
Fügen Sie einen neuen Vertrag hinzun 
Vertragsinhalt 
Nächster Bearbeitungsschritt 
Anlegen Cancel 
Vertragsdaten 
Allgemein 
Ma nda nt 
Buchungskreis 
Vertragslaueeit 
Standard-Vertr ag 
Zahlungsplan 
Ablageort 
Mandant 
N achname 
Vertragspartner 
Firma 
Vertragsdaten 
Nicht weiterleiten, nur Zwischenspeichern 
Speichern Drucken}

## Definition der Aktion

    {
      "type": "ADVANCED_ACTION",
      "ribbon": {
        "ribbonTab": {
          "name": "TAB_SOL_CONTRACT",
          "text": "sol.contract.client.ribbon.tabContract",
          "position": 95
        },
        "buttongroup": {
          "name": "GRP_SOL_CONTRACT_CREATE",
          "mode": "big",
          "text": "sol.contract.client.ribbon.bandCreate",
          "position": 10
        },
        "button": {
          "name": "BTN_SOL_CONTRACT_CREATECONTRACT",
          "text": "sol.contract.client.ribbon.btnCreateContract",
          "splitText": "sol.contract.client.ribbon.btnCreateContractSplit",
          "tooltipText": "sol.contract.client.ribbon.btnCreateContract.tooltip",
          "tooltipTitle": "",
          "access": {
            "document": true,
            "folder": true
          },
          "web": {
            "iconName": "sol-contract-createcontract",
            "smallIcon": "sol-contract-createcontract16",
            "smallIconHighRes": "sol-contract-createcontract16-200",
            "bigIcon": "sol-contract-createcontract32",
            "bigIconHighRes": "sol-contract-createcontract32-200"
          },
          "jc": {
            "buttonId": "728"
          },
          "position": 10,
          "asTile": true
        }
      },
      "action": {
        "selectType": {
          "fct": "RF_sol_contract_service_GetContractTypes"
        },
        "fct": "RF_sol_contract_action_CreateContract",
        "cfgTemplate": "{\"contractType\": \"{{type.name}}\", \"templateId\": \"{{type.objId}}\" }",
        "locale": {
          "errorDlgTitle": "sol.pubsec.client.file.create.dialog.error.title",
          "typesDlgTitle": "sol.contract.client.contract.create.dialog.title",
          "typesDlgHeader": "sol.contract.client.contract.create.dialog.header",
          "typesDlgText": "sol.contract.client.contract.create.dialog.text",
          "typesDlgNoTypes": "sol.contract.client.contract.create.msg.notype"
        }
      }
    }

## Index Server Implementierung der Aktion

Die Implementierung der Aktion lädt dabei zuerst die Konfigurationsdatei in ELO. Als Vorbedingung muss durch den Client eine Template-ID ausgewählt werden. Dies ist ein Element, welches in 

Abschließend wird das Formular des ersten Benutzerknotens, welcher dem aktuellen Benutzer zugeordnet ist, ermittelt und als Event an den Client zurückgesendet. Zusätzlich wird der Client angewiesen ein Goto auf das neu erzeugte Element anzulegen.

    importPackage(Packages.de.elo.ix.client);
    importPackage(Packages.de.elo.ix.jscript);
    
    //@include lib_Class.js
    //@include lib_sol.common.Config.js
    //@include lib_sol.common.JsonUtils.js
    //@include lib_sol.common.SordUtils.js
    //@include lib_sol.common.IxUtils.js
    //@include lib_sol.common.WfUtils.js
    //@include lib_sol.common.CounterUtils.js
    //@include lib_sol.common.AclUtils.js
    //@include lib_sol.common.RepoUtils.js
    //@include lib_sol.common.Template.js
    //@include lib_sol.common.TranslateTerms.js
    //@include lib_sol.common.ix.RfUtils.js
    //@include lib_sol.common.ix.ActionBase.js
    //@include lib_sol.common.ix.FunctionBase.js
    //@include lib_sol.contract.ix.ContractUtils.js
    
    
    /**
     * Creates a new new contract.
     * 
     * @eloix
     * @requires sol.common.Config
     * @requires sol.common.JsonUtils
     * @requires sol.common.SordUtils
     * @requires sol.common.IxUtils
     * @requires sol.common.CounterUtils
     * @requires sol.common.AclUtils
     * @requires sol.common.RepoUtils
     * @requires sol.common.Template
     * @requires sol.common.TranslateTerms
     * @requires sol.common.WfUtils
     * @requires sol.common.ix.RfUtils
     * @requires sol.common.ix.ActionBase
     * @requires sol.common.ix.FunctionBase
     * @requires sol.common.ix.functions.CopyFolderContents
     * @requires sol.common.ix.functions.CopySordData
     * @requires sol.common.ContractUtils
     */
    sol.define("sol.contract.ix.actions.CreateContract", {
      extend: "sol.common.ix.ActionBase",
      
      requiredConfig: ["ci", "user", "contractType"],
      
      /** 
       * @cfg {de.elo.ix.client.ClientInfo} ci (required)
       */
      
      /** 
       * @cfg {de.elo.ix.client.UserInfo} user (required)
       */
      
      /**
       * @cfg {String} templateId (required)
       * Object ID of the template
       */
      
      initialize: function (config) {
        var me = this;
        me.$super("sol.common.ix.ActionBase", "initialize", [config]);
        me.config = sol.contract.ix.ContractUtils.loadConfig();
      },
      
      getName: function () {
        return "CreateContract";
      },
      
      process: function () {
        var me = this,
            name, objId, flowId, sord,
            objectType;
        
        if (!me.templateId) {
          me.addErrorEvent("sol.contract.ix.actions.CreateContract.error.target", null, null, me.ci);
          return;
        }
        
        name = me.buildElementName();
    
        objId = sol.common.IxUtils.execute("RF_sol_function_CopyFolderContents", {
          objId: "0",
          source: me.templateId,
          copySourceAcl: false,
          inheritDestinationAcl: false,
          name: me.contractType + " - " + me.getTimeStampString(),
          asAdmin: true
        });
        
        sord = sol.common.RepoUtils.getSord(objId);
        
        objectType = me.config.objectTypes[0];
        
        sol.common.SordUtils.setObjKeyValue(sord, me.config.fields.objectType, objectType);
        sol.common.SordUtils.setObjKeyValue(sord, me.config.fields.contractType, me.contractType);
        ixConnect.ix().checkinSord(sord, SordC.mbAllIndex, LockC.NO);    
        
        flowId = me.startMaskStandardWorkflow(objId, { name: name, field: me.config.fields.defaultWorkflow });
        
        if (flowId) {
          me.addWfDialogEvent(flowId, { objId: objId, title: name });
        }
        
        me.addGotoIdEvent(objId);
      },
    
      /**
       * @private
       */
      buildElementName: function () {
        var me = this,
            prefix;
        
        prefix = me.getLocalizedString(me.ci, me.config.workflows.createContract.workflowPrefixKey);
        return sol.create("sol.common.Template", { source: me.config.workflows.createContract.workflowNameTemplate }).apply({ wfPrefix: prefix, contractType: me.contractType });
      },
      
      /**
       * @private
       */
      getTimeStampString: function () {
        return String(Packages.org.apache.commons.lang.time.DateFormatUtils.format(new java.util.Date(), "yyyyMMddHHmmss"));
      },
    });
    
    /**
     * @member sol.contract.ix.actions.CreateContract
     * @method RF_sol_contract_action_CreateContract
     * @static
     * @inheritdoc sol.common.ix.FunctionBase#RF_FunctionName
     */
    function RF_sol_contract_action_CreateContract(ec, configAny) {
      var rfUtils = sol.common.ix.RfUtils,
          config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny, "contractType", "templateId"),
          createContract;
      
      config.ci = ec.ci;
      config.user = ec.user;
      
      createContract = sol.create("sol.contract.ix.actions.CreateContract", config);
      return createContract.execute();
    }

## Index Server Implementierung des Dienstes zur Ermittlung der Vertragstypen

Ein Vertragstyp wird dabei durch eine Vorlage für den Vertrag im Konfigurationsbereich definiert. Diese Vorlage wird beim Anlegen kopiert, wodurch Metadaten vorbelegt und Strukturen der Vertragsakte übernommen werden können.

{@img img7.png contract 
Adminis tr ation 
Business Solutions 
_global 
Common 
Common fx 
common_monitoring 
Connector dx 
Connector xml 
contract 
eloinst 
keywording forms 
Action definitions 
All Rhino 
Configuration 
COntract types 
tletstung 
Kaufvertrag 
Mietvertr ag 
Warbeitervertrag 
Standard-Vertr ag 
Wartungsvertrag}

Vertragsakten werden zu diesem Zeitpunkt in der Chaosablage abgelegt und später im Workflow an die korrekte Position verschoben.

    importPackage(Packages.de.elo.ix.client);
    
    //@include lib_Class.js
    //@include lib_sol.common.Config.js
    //@include lib_sol.common.JsonUtils.js
    //@include lib_sol.common.SordUtils.js
    //@include lib_sol.common.RepoUtils.js
    //@include lib_sol.common.TranslateTerms.js
    //@include lib_sol.common.ix.RfUtils.js
    //@include lib_sol.common.ix.ServiceBase.js
    //@include lib_sol.contract.ix.ContractUtils.js
    
    /**
     * Retrieves the available contract types.
     *
     * @author JHR, ELO Digital Office GmbH
     *
     * @eloix
     * @requires sol.common.Config
     * @requires sol.common.JsonUtils
     * @requires sol.common.SordUtils
     * @requires sol.common.RepoUtils
     * @requires sol.common.TranslateTerms
     * @requires sol.common.ix.RfUtils
     * @requires sol.common.ix.ServiceBase
     * @requires sol.contract.ix.ContractUtils
     */
    sol.define("sol.contract.ix.services.GetContractTypes", {
      extend: "sol.common.ix.ServiceBase",
      
      initialize: function (config) {
        var me = this;
        me.$super("sol.common.ix.ServiceBase", "initialize", [config]);
        me.config = sol.contract.ix.ContractUtils.loadConfig();
      },
    
      /**
       * Retrieves the data as spezified in the constructor configuration.
       * @returns {String[]} Array with contract types
       */
      process: function () {
        var me = this,
            searchConfig = {},
            contractTemplates;
        
        searchConfig.includeFolders = true;
        searchConfig.includeDocuments = false;
        searchConfig.includeReferences = true;
        searchConfig.sordZ = SordC.mbAllIndex;
        
        contractTemplates = sol.common.RepoUtils.findChildren(me.config.templateFolderId, searchConfig);
        return me.convertTemplateSords(contractTemplates);
      },
      
      /**
       * @private
       * Converts from Sords to Objects
       * @param {de.elo.ix.client.Sord[]} reportTemplateSords
       * @returns {Object[]}
       */
      convertTemplateSords: function (reportTemplateSords) {
        var converted = [];
        if (reportTemplateSords) {
          reportTemplateSords.forEach(function (sord) {
            converted.push({
              objId: sord.id,
              name: sord.name,
              desc: sord.desc
            });
          });
        }
        return converted;
      }
    });
    
    /**
     * @member sol.contract.ix.services.GetContractTypes
     * @method RF_sol_common_service_GetContractTypes
     * @static
     * @inheritdoc sol.common.ix.ServiceBase#RF_ServiceBaseName
     */
    function RF_sol_contract_service_GetContractTypes(iXSEContext, args) {
      var rfUtils = sol.common.ix.RfUtils,
          config = rfUtils.parseAndCheckParams(iXSEContext, arguments.callee.name, args),
          service;
    
      service = sol.create("sol.contract.ix.services.GetContractTypes", config);
      return rfUtils.stringify(service.process());
    }


## ELO Workflow

Der erste Benutzerknoten enthält dabei ein Formular welches die Eingabe aller Vertragsdaten ermöglicht. Die Weiterleiten-Optionen <span
style='font-weight:bold'>OK</span> und <span style='font-weight:bold'>cancel</span> werden dem Anwender später im Dialog angeboten. Bricht der Anwender die Erstellung ab, wird da zuvor angelegte Vertragsobjekt wieder gelöscht.

{@img img9.png sol.contract.contract.create 
Eigentümer 
Data entry 
Eigentümer 
create 
MOVE : contract 
GENERATOR : contract no. 
GENERATOR : short description 
FEED : contract created 
Cancel 
DELETE : temporary record}

## Formular

Das Formular kann dabei beliebig erweitert oder angepasst werden. In den ELO Business Solutions treten hier Tab-Gruppen zum Einsatz um die Formularlogik weiter zu modularisieren.

{@img img11.png Tab-Gruppe bearbeiten 
Tab-ID 
Tabs 
Uberschrift 
contract form 
Baustein hinzufügen 
Startelement 
X Abbrechen 
110 contract_general all 
111 contract company all 
120 contract_partner all 
130 contract data all 
140 contract_proJect all 
150 contract duration all 
160 contract subjectmatte 
180 contract_paymentplan}

Nachfolge Abbildung zeigt ein Beispiel des Formulartemplates `110_contract_general_all`.

{@img img13.png Neue Zeile 
Neue Spalte 
Zeile löschen 
Spalte löschen 
— Eingabe 
Datum 
T Text 
Editor 
Markierung 
Schalter 
Inhalteinfügen 
Auswahl 
Combo 
Link 
Löschen 
verbinden 
Trennen 
Tabelle 
sol .contract.form .general 
sol. contract.form. contractName 
sol.contract.form.type 
sol. contract.form.relation 
sol. contract.form. filingLocation 
sol. contract.form.status}

## Lokalisierung

Alle verwendeten Lokalisierungsschlüssel werden dabei in den properties-Dateien hinterlegt. So bspw. auch der Schlüssel `sol.contract.client.ribbon.btnCreateContract`.

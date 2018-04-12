# Beispiel: Einfache Aktion

<span class="tag_important">Nachfolgend wird die zugrundeliegende Implementierung der Aktion &quot;Vertrag freigeben&quot; erläutert. </span>

Diese setzt sich aus folgenden Komponenten zusammen:

*   Definition der Aktion
*   Implementierung der Aktion im Index Server
*   ELO Workflow
*   ELO Formular

Dabei wählt der Anwender einen bestehenden Vertrag in ELO aus und klickt in der Multifunktionsleiste auf &quot;Freigabe einleiten&quot;. 

{@img img1.png ELO contract 
VERTRÄGE 
Freigabe 
DOKUMENT 
ANSICHT 
Vertragsmanagement Archiv 
Suche 
Dokument 
erze ugen 
Dashboard 
Aufgaben 
26 
Nils 
Mosbach 
Feed 
START 
Vertrag 
Anlegen 
AUFGABEN 
Nach Funktion suchen 
Zahlungsplan 
Verhandlung 
einleiten 
9 
Vertrag 
abgeschlossen 
Kündigung 
einleiten 
Deckblatt 
erstellen 
Dokumente 
Zahlungsplan 
Etikett 
erstellen 
Verhandlung 
abgebrochen 
C62-Bürom iete Standort West 
Vertrag 
C62-Büromiete Standort West 
Leitet die Freigabe des Vertragsentwurfs 
Vertr 
Dienstleistung 
Kaufvertrag 
Mietvertr ag 
Hagen Immobilien GmbH 
t:» C62-Büromiete Standort VVest 
Vertragsdaten 
Allgemein 
Vertragslaueeit 
Vertragsinhalt}

Es öffnet sich anschließend ein Formular, welches es ermöglicht den nachfolgenden Prüfer auszuwählen und optional ein Kommentar zu hinterlassen.

{@img img3.png Initiate approval 
Startthe approval process. 
Freigabedaten 
Vertragsl 
Nicht weiterleiten, nur Zwischenspeichern 
Speichern Drucken 
Nächster Bearbeitungsschritt 
OK Cancel}

## Definition der Aktion

    {
      "type": "SIMPLE_ACTION",
      "ribbon": {
        "ribbonTab": {
          "name": "TAB_SOL_CONTRACT",
          "text": "sol.contract.client.ribbon.tabContract",
          "position": 95
        },
        "buttongroup": {
          "name": "GRP_SOL_EDITCONTRACTS",
          "mode": "big",
          "text": "sol.contract.client.ribbon.bandEdit",
          "position": 20
        },
        "button": {
          "name": "BTN_SOL_CONTRACTINITATEAPPROVAL",
          "text": "sol.contract.client.ribbon.btnInitiateApproval",
          "splitText": "sol.contract.client.ribbon.btnInitiateApprovalSplit",
          "tooltipText": "sol.contract.client.ribbon.btnInitiateApproval.tooltip",
          "tooltipTitle": "",
          "access": {
            "document": false,
            "folder": true
          },
          "web": {
            "smallIcon": "sol-contract-initateapproval16",
            "smallIconHighRes": "sol-contract-initateapproval16-200",
            "bigIcon": "sol-contract-initateapproval32",
            "bigIconHighRes": "sol-contract-initateapproval32-200"
          },
          "jc": {
            "buttonId": "729"
          },
          "position": 10
        }
      },
      "action": {
        "fct": "RF_sol_contract_action_ApproveContract",
        "cfgTemplate": "{\"objId\": \"{{objId}}\" }"
      }
    }

## Index Server Implementierung

Die Implementierung der Aktion lädt dabei zuerst die Konfigurationsdatei in ELO und sucht in den Elternelementen nach einem Vertrag, falls das aktuelle ausgewählte Element kein Vertrag ist. Das wird benötigt, da Verträge Unterstrukturen enthalten können.

Abschließend wird das Formular des ersten Benutzerknotens, welcher dem aktuellen Benutzer zugeordnet ist, ermittelt und als Event an den Client zurückgesendet.

    importPackage(Packages.de.elo.ix.client);
    importPackage(Packages.de.elo.ix.jscript);
    
    //@include lib_Class.js
    //@include lib_sol.common.Config.js
    //@include lib_sol.common.JsonUtils.js
    //@include lib_sol.common.SordUtils.js
    //@include lib_sol.common.IxUtils.js
    //@include lib_sol.common.WfUtils.js
    //@include lib_sol.common.RepoUtils.js
    //@include lib_sol.common.SordTypeUtils.js
    //@include lib_sol.common.Template.js
    //@include lib_sol.common.TranslateTerms.js
    //@include lib_sol.common.ix.RfUtils.js
    //@include lib_sol.common.ix.ActionBase.js
    //@include lib_sol.common.ix.FunctionBase.js
    //@include lib_sol.contract.ix.ContractUtils.js
    
    /**
     * Approve a contract
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
    sol.define("sol.contract.ix.actions.ApproveContract", {
      extend: "sol.common.ix.ActionBase",
      
      requiredConfig: ["ci", "user", "objId"],
      
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
        return "InitateApproval";
      },
      
      process: function () {
        var me = this,
            contractSord, contractConfig, contractObjId,
            wfPrefix, wfNumber, wfName,
            flowId;
            
        contractConfig = sol.contract.ix.ContractUtils.loadConfig();
        contractSord = sol.common.RepoUtils.findObjectTypeInHierarchy(me.objId, contractConfig.objectTypes);
        if (!contractSord) {
          me.addErrorEvent("sol.contract.client.contract.msg.noContractFoundInHierarchy", "", "", me.ci.language);
          return;
        }
        
        contractObjId = contractSord.id;
        
        wfPrefix = me.getLocalizedString(me.ci, contractConfig.workflows.approveContract.workflowPrefixKey);
        wfNumber = me.actionId;
        wfName = sol.create("sol.common.Template", { source: contractConfig.workflows.approveContract.workflowNameTemplate }).apply({ wfPrefix: wfPrefix, wfDate: new Date(), wfNumber: wfNumber });
    
        flowId = me.startWorkflow(contractObjId, contractConfig.workflows.approveContract.workflowTemplateName, wfName);
        
        me.addWfDialogEvent(flowId, { objId: contractObjId });
      }
    });
    
    /**
     * @member sol.contract.ix.actions.ApproveContract
     * @method RF_sol_contract_action_ApproveContract
     * @static
     * @inheritdoc sol.common.ix.FunctionBase#RF_FunctionName
     */
    function RF_sol_contract_action_ApproveContract(ec, configAny) {
      var rfUtils = sol.common.ix.RfUtils,
          config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny, "objId"),
          approveContract;
      
      config.ci = ec.ci;
      config.user = ec.user;
      
      approveContract = sol.create("sol.contract.ix.actions.ApproveContract", config);
      return approveContract.execute();
    }

## ELO Workflow

Der erste Benutzerknoten enthält dabei ein Formular welches die Eingabe des Freigebers ermöglicht. Die Weiterleiten-Optionen <span
style='font-weight:bold'>OK</span> und <span style='font-weight:bold'>cancel</span> werden dem Anwender später im Dialog angeboten.

{@img img5.png iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii 
sol.contract.contract.approval 
Eigentümer 
Set approver 
Eigentümer 
Cancel 
STATUS: Approval 
CHANGECOLOR: Approval initiated 
FEED: Approval initiated 
CHANGEUSER: Approval 
Approval 
Eigentümer 
Approve 
STATUS: Approved 
FEED: Approval comment 
Contract approved 
Eigentümer 
STATUS: Drafi 
FEED : Approval rejected 
Contract rejected 
Eigentümer 
Finish}

## Formular

Das Formular kann dabei beliebig erweitert oder angepasst werden. In den ELO Business Solutions treten hier Tab-Gruppen zum Einsatz um die Formularlogik weiter zu modularisieren.

{@img img7.png Tab-Gruppe bearbeiten 
Tab-ID 
Tabs 
Uberschrift 
Baustein hinzufügen 
Startelement 
X Abbrechen 
310 contract approval dat _t•l}

{@img img9.png Neue Zeile 
Neue Spalte 
Tabelle 
Freigabedaten 
P rüfer 
Kommentar 
Zeile löschen 
Spalte löschen 
— Eingabe 
Datum 
T Text 
Editor 
Markierung 
Schalter 
Inhalt einfügen 
Auswahl 
Combo}

## Lokalisierung

Alle verwendeten Lokalisierungsschlüssel werden dabei in den properties-Dateien hinterlegt. So bspw. auch der Schlüssel `sol.contract.client.ribbon.btnInitiateApproval`.

# Aktionstypen und Client-Implementierung

Aktionen beschreiben den technischen Ablauf auf der Serverseite. Für die Ausführung einer Aktion können aber zusätzlich weitere Informationen notwendig sein, die von den Clients an den Server übermittelt werden.

## Einfache Aktionen (SIMPLE_ACTION)

Diese beschreiben Aktionen für die der Client keine Vorbedingungen zum Ausführen der Aktion erledigen muss. Im einfachsten Fall wird vom Anwender ein Element im Archiv ausgewählt und die Aktion gestartet.

Gibt die Aktion Events zurück werden diese anschließend vom Client ausgeführt.

> <span
style='font-style:italic'>Ein Beispiel: Die Funktion Vertrag abgeschlossen markiert einen Vertrag als abschlossen und unterschrieben. Hierzu muss der Vertrag in ELO ausgewählt werden, anschließend wird auf Serverseite im Workflow der Status des Vertrags, die Farbe des Elements sowie ein Feed-Beitrag gesetzt.</span>

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
ort west 
Verh andlung 
einleiten 
Deckblatt 
erstellen 
Dokumente 
9 
Vertrag 
abgeschlossen 
Kündigung 
einleiten 
Etikett 
erstellen 
Verhandlung 
abgebr ochen 
0er Vertrag wurde abgeschlossen 
Vertragsmanagement}

<span
style='font-weight:bold'>Nachfolgend zeigt sich der Auszug aus der `Action definition`:</span>

Die Implementierung findet hier als Index Server Aktion, repräsentiert durch die `registered function` `RF_sol_contract_action_ContractConcluded`, statt. 

Um der Aktion die benötigten Informationen mitzugeben wird ein <a
href="#!/guide/pBFB0C475_0FC1_47BA_9ABC_8E664ECC269B">Template</a> `cfgTemplate` verwendet. Dieses muss ein valides JSON-Objekt aufbauen, welches in der Aktion verwendet werden kann. Im Template kann auf die Objekt-ID des aktuell selektierten Elements durch `{{objId}}` zugegriffen werden (Siehe auch <a
href="#!/guide/p6DAA94C6_8B8E_40E9_9D9E_E946F91F4ACF">Aktionslogik</a>).

      "action": {
        "fct": "RF_sol_contract_action_ContractConcluded",
        "cfgTemplate": "{\"objId\": \"{{objId}}\" }"
      }

## Erweiterte Aktionen (ADVANCED_ACTION)

Weiterführend können Clients angewiesen werden <span
style='font-weight:bold'>vor dem Auslösen einer Aktion</span> weitere Schritte durchzuführen.

### Auswahl eines Typs

Die Funktion `Vertrag anlegen` bietet beispielsweise die Möglichkeit vorab aus einer Reihe von Vertragstypen zu wählen. Der ausgewählte Typ wird anschließend an die Aktion übergeben.

<span class="tag_important">Die Typauswahl gibt dem Anwender die Möglichkeit aus einer flachen Liste einen Eintrag auszuwählen.</span>

{@img img3.png ELO contract 
VERTRÄGE 
START 
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
AUFGABEN 
Nach Funktion suchen 
Zahlungsplan 
Verhandlung 
einleiten 
Vertrag 
Freigabe 
9 
Vertrag 
abgeschlossen 
arbeiten 
Kündigung 
einleiten 
Deckblatt 
erstellen 
Dokumente 
Etikett 
erstellen 
Verhandlung 
abgebrochen 
Legt einen neuen Vertrag an 
Vertr age 
Denstleistung 
C62-Bürom iete Standort West 
Vertrag}

{@img img5.png ELO 
contract 
Vertrag auswählen 
Bitte Wahlen Sie den anzulegenden Vertrags typ aus 
Dienstleistung 
Kaufvertrag 
Mietvertrag 
Mitarbeitervertrag 
Rahmenvertrag 
Standard-Vertrag 
Wartungsvertrag 
Abbrechen 
Vertragsmanagement 
D: Üienstleistung 
Kaufvertrag 
Mietvertrag 
Hagen Inwobilien GmbH 
CS2-8üromiete Standort 
Rahmenvertrag 
D: Standard-Vertrag 
D: Wartungsvertrag 
Neues Üeckblatt}

Grundlage für die Typenauswahl ist ein Index Server Service, welcher eine Liste (`Array`) von Vertragstypen zurückgibt. Name und Beschreibung werden dabei im Client in einem Auswahldialog angezeigt.

{@img img7.png Object 
o 
desc: " 
name: "Dienstleistung" 
Object 
proto 
Object 
o 
desc: " 
name: "Kaufvertrag" 
3223 
Object 
prota 
*Object' *Object' *Object' *Object' *Object)}

Um die Werte an die Aktion zu übergeben kann im `cfgTemplate` auf den ausgewählten Eintrag inkl. aller Daten zugegriffen werden. Bspw.: `{{type.name}}` gibt den Namen des ausgewählten Typs zurück. Zusätzlich werden für den Typ-Auswahldialog noch Lokalisierungsinformationen benötigt.

    {
      "type": "ADVANCED_ACTION",
      "ribbon": {<br>
       ...
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

### Auswahl eines Elementes aus ELO

Die Funktion `Dokument erzeugen` bietet beispielsweise die Möglichkeit vorab aus einer Reihe von Dokumentvorlagen zu wählen, die in ELO abgelegt sind. Das ausgewählte Element wird anschließend an die Aktion übergeben.

<span class="tag_important">Die Tree-Auswahl gibt die Anwender die Möglichkeit aus einem Teilbereich von ELO einen Eintrag auszuwählen.</span>

{@img img9.png ELO contract 
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
Bearbeiten 
Kündigung 
einleiten 
Deckblatt 
erstellen 
Etikett 
erstellen 
Verhandlung 
abgebr ochen 
Erzeugt ein neues Dokument 
C62-Bürom iete Standort West 
Vertragsmanagement}

{@img img11.png ELO contract 
Vertragsmanagement 
abgeschlossen 
Template 
Bitte ein Template für das Dokumentauswählen 
- namenot set- 
@Test Dokument 
Aufgaben 26}


Um die Werte an die Aktion zu übergeben kann im `cfgTemplate` auf den ausgewählten Eintrag inkl. aller Daten zugegriffen werden. Bspw.: `{{tree.objId}}` gibt die Objekt-ID des ausgewählten Elements zurück. Zusätzlich werden für den Tree-Auswahldialog noch Lokalisierungsinformationen benötigt.

    {
      "type": "ADVANCED_ACTION",
      "ribbon": {
        …
      },
      "action": {
        "selectTree": {
           "rootFromCfgFile": "ARCPATH:/Administration/Business Solutions/contract/Configuration/contract.Config",
           "rootFromCfgProperty": "\"{{config.document.templateFolderId}}\""
        },
        "fct": "sol.contract.as.actions.PrepareDocument",
        "type": "AS",
        "solution": "contract",
        "cfgTemplate": "{\"parentId\": \"{{objId}}\", \"templateId\": \"{{tree.objId}}\" }",
        "locale": {
          "errorDlgTitle": "sol.pubsec.client.filecoversheet.dialog.noTemplates",
          "treeDlgTitle": "sol.contract.client.document.selectTemplate.title",
          "treeDlgHeader": "sol.contract.client.document.selectTemplate.text"
        }
      }
    }

Interner Ablauf

<span class="tag_warning">Nachfolgende Dokumentation soll ein tieferes Verständnis über den internen Ablauf auf Client-Seite geben.</span>

Durch diese Standardisierung ist es möglich, Aktionen im ELO Web Client sowie im ELO Java Client ohne großen Implementierungsaufwand anzubieten. Von der Klasse `sol.common.web.ActionDefinitionUtils`, welche bspw. die Registrierung der Buttons im Web Client vornimmt wird die Definition der Aktion an Hilfsfunktionen übergeben, welche u.a. Vorbedingungen wie die Typauswahl übernimmt.

SIMPLE_ACTION: sol.common.web.ActionHelper#executeSimpleAction
ADVANCED_ACTION: sol.common.web.ActionHelper#executeAdvancedAction

Die Klassen `sol.common.jc.ActionHandler` sowie `sol.common.web.ActionHandler` führen anschließend die ELO Index Server oder ELO AS Aktion aus und sorgen für den Umgang mit den zurückgegebenen Verfahrensweisen (Events).

### Sonderfälle

In besonderen Fällen kann es notwendig sein eine Aktion nicht über die Definition `Action definition` auszulösen. In diesem Fall können Aktionen auch direkt über das Scripting aufgerufen werden. Das erlaubt es auf besondere Anforderungen einzugehen. Nachfolgende Beispiele zeigen den direkten Aufruf von Aktionen über den ActionHandler. Zu beachten ist, dass dieser dennoch die zurückgegebenen Events verarbeitet.

<span
style='font-weight:bold'>Java Client </span>

    //@include lib_Class.js
    
    sol.define("sol.pubsec.jc.FilingPlan", {
      singleton: true,
      
      startChangeRequest: function (parentId) {
        // specific Java Client scripting  
        sol.common.jc.ActionHandler.execute("RF_sol_pubsec_action_FilingPlanChangeRequest", {"objId": parentId});
      }
      
    });

<span
style='font-weight:bold'>Web Client </span>

    (function () {
      sol.define("sol.pubsec.web.FilingPlan", {
        singleton: true,
    
        startChangeRequest : function (parentId) {            
          // specific Web Client scripting            
          sol.common.web.ActionHandler.execute("RF_sol_pubsec_action_FilingPlanChangeRequest", {"objId": parentId});
        }
      });
    }());

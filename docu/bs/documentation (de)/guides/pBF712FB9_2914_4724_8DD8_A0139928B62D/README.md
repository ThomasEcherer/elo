# Roles: Benutzer dynamisch ermitteln

In unterschiedlichen Freigabeszenarien müssen Benutzer oder Gruppen anhand von Regeln basierend auf zugrundeliegenden Informationen ermittelt werden.

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Im Rechnungseingangsumfeld beschreibt das Feld `INVOICE_NET_AMOUNT` den Nettobetrag. Der Freigabeprozess kann bspw. vorsehen, dass je nach Konfiguration die Gruppe </span><span
style='font-weight:bold;font-style:italic'>Management</span><span
style='font-style:italic'> Rechnungen über einem Nettobetrag von 10.000 € freigeben muss.</span>

Mithilfe der Klasse `sol.common.Roles` können solche Regeln basierend auf Metadaten in einer Konfiguration hinterlegt und ausgewertet werden. Die genaue Verwendung kann der Klassendokumentation entnommen werden.

Eine Konfiguration kann hierfür mehrere Rollen enthalten und jeder Rolle eine Reihe von Benutzern/ Gruppen zuweisen die angewandt werden, falls die Bedingungen zutreffen.

## Definition von Gruppen und Regeln
### Konfiguration über eine Oberfläche

Für die Konfiguration der Rollen steht eine ELO App zu Verfügung die das Hinzufügen von Benutzern und Bedingungen erleichtert.

In nachfolgender Oberfläche wird für die Rolle `APPROVAL` die Gruppe `sol.management` eingesetzt, falls die Bedingung `INVOICE_NET_AMOUNT` &gt; 3000 eintrifft.

{@img img1.png ELO invote 
DOKUMENT 
D elonst 
ANSICHT 
AUFGABEN 
Nach Funktion suchen 
sol.inv0ice.WorkflowUserRoles.C0nfig 
Benutzerrollen-Konfiguration 
Benuterrolle APPROVAL 
Rollenname 
Benutzer 
sol. management 
+ Benueer hinzuugen 
Archiv 
Aufgaben 
KEmmbrett 
Beart)edung Suche 
Nils Mosbach 
START 
Feed 
X 
unter 
VVfUserROlesconfig QIliCkEdit Dokument 
X 
D .keywordig forms 
Configuration 
soliwote. 
D Dashboard-Data 
D Documentation 
D ELOapps 
D ELOas aase 
D ELOwf Base 
D Export Templates 
D IndexServer Scrong Base 
D l"VOice Templates 
D Java Scrbtng Base 
AppROVAL 
Bedingungen 
Bedingung 
Konverter s 
+ Betingungen}

### Interner Konfigurationsaufbau

    var myRoleConfig = {
      ROLE: [
        { user : "user1", conditions : [ { grp : "LENGTH", rel : "GT", val : 3000, converter : "custom.converters.NumberConverter.inchesInCm" } ] },
        { user : "user2" }
      ]
    }

## Ermitteln eines Anwenders

    var sord = ixc.ix().checkoutSord(...);
    var users = sol.common.Roles.getUsers('ROLE', sord, myRoleConfig);

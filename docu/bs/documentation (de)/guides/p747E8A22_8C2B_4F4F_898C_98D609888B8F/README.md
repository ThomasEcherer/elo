# Anwendungsfunktionalität

ELO-Clients bieten im Standard einen großen Funktionsumfang, der viele Grundbelange des Enterprise Content Managements abdeckt. Aufgrund des Komplexitätsgrads der Lösungen ist es notwendig, Clients um Anwendungslogik zu erweitern und weitere Funktionen bereitzustellen.

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Für die Verwaltung von elektronischen Akten im öffentlichen Sektor wurde eine eigene Registerkarte </span><span
style='font-weight:bold;font-style:italic'>Akte</span><span style='font-style:
italic'> eingeführt, die weitere Aktionen wie bspw. </span><span
style='font-weight:bold;font-style:italic'>Akte anlegen</span><span
style='font-style:italic'>,</span><span style='font-weight:bold;font-style:
italic'> Akte schließen</span><span style='font-style:italic'>,</span><span
style='font-weight:bold;font-style:italic'> Akte öffnen</span><span
style='font-style:italic'> etc. bereitstellt.</span>

{@img img1.png srvpdevbsOIvm•.8020/vveÉ x 
E LO pubsec 
DOCUMENT 
VIEW TASKS 
Vorgang Laufmappe 
anlegen anlegen 
Vorgangsbearbetung 
« I - Zentrale Verwaltung 
p search this foner 
10 - Zentrale Verwaltung im allgemeinen 
ELO Service 
Nils Mosbach • 
Gl Feed 
Manual 
Aktenplan 
START 
E-AKTE 
schließen öffnen 
Bearbeiten 
Aktenplan 
löschen 
2 
Aktenplan Anderung 
beantr agen 
Aktenband 
anlegen anlegen 
An legen 
Repository 
10 - Zentrale... 
Ak tenplan 
C) I - Zentrale Verwaltung 
t:» 2 - Konzeptentwicklung, Publikationen, Veranstal 
t:» 3- öffentlichketsarbet, Zusammenarbeit und Ko}

## ELO-Multi-Client-Strategie

ELO verfolgt mit der Multi-Client-Strategie das Ziel, Benutzern unterschiedliche Clients zur Verfügung zu stellen.  Business Solutions setzen sich zum Ziel, Anwendungsfunktionalität gleichermaßen im Java Client und im Web Client bereitzustellen.

Um dies in vertretbarem Aufwand zu gewährleisten, werden Funktionen als <a
href="#!/guide/p0B6BCC8E_42D0_4EAE_BC44_F13016A4F81D"><span
style='font-weight:bold'>Aktionen</span></a> weitgehend auf der Server-Seite durch ELOas oder Indexserver-Skripte implementiert. Aktionen teilen dem Client anschließend mit, was dieser nach erfolgreicher Ausführung erledigen soll. Eine Aktion wird meist durch einen Button in der Multifunktionsleiste ausgelöst. 

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Im Falle der E-Akte findet sich im Client ein Button </span><span
style='font-weight:bold;font-style:italic'>Akte anlegen</span><span
style='font-style:italic'>, der die gleichnamige Aktion, repräsentiert durch die Klasse `sol.pubsec.ix.actions.CreateRecord` , auslöst. Diese Aktion, welche im Indexserver läuft, teilt dem Client anschließend mit, die erzeugte Akte anzuzeigen.</span>

## Balance von Scripting und Modularisierung

Wird Anwendungslogik bereitgestellt, muss abgewogen werden, welche Logik in der Aktion implementiert wird und welche Logik modularisiert werden kann. Grundsätzlich gilt, dass die Aktion lediglich Basisoperationen wie bspw. das Anlegen eines Ordners erledigen sollte. <span
style='font-weight:bold'>Für das Ausführen weiterer Logik (z.B. Erzeugen eines Feed-Beitrags) wird von der Aktion ein Workflow gestartet</span>, der mithilfe von <a
href="#!/guide/pADD870BA_9AA2_4900_8D6B_FA0FB26D9BEC"><span
style='font-weight:bold'>Funktionsbausteinen</span></a> auch komplexere Anwendungsfälle abbilden kann. 

Benutzereingaben sollten, soweit möglich, durch einen Benutzerknoten mit zugehörigem ELOwf-Formular realisiert werden. Aktionen können hierfür den Clients mitteilen, das Formular in einem Dialog anzuzeigen.

Die richtige Balance von individuellem Scripting und Modularisierung durch Funktionsbausteine erlaubt es Partnern und Consultants, die Anwendungslogik von Lösungen durch einfache Modifikation des Workflows an ihre Bedürfnisse anzupassen. Zudem soll durch die Modularisierung von häufig benutzten Funktionen Entwicklungsarbeit reduziert werden.

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Die Aktion </span><span style='font-weight:bold;
font-style:italic'>Akte anlegen</span><span style='font-style:italic'> startet den Workflow `sol.pubsec.record.CreateRecord`    In diesem finden sich Funktionsbausteine, die bspw. einen Feed-Kommentar schreiben oder die Farbe der Aktenbeschriftung auf </span><span
style='font-weight:bold;font-style:italic'>Offen</span><span style='font-style:
italic'> (Grün) setzen. Der Workflow enthält dabei einen Benutzerknoten, welcher ein Formular zur Erfassung der benötigten Informationen der Akte bereitstellt.</span>
> 






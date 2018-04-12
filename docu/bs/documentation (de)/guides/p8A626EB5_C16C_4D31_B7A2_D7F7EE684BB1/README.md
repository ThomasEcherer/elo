# Technische Zusammenfassung

Eine Vielzahl von Hilfs- sowie Handler-Klassen sorgt für den reibungslosen Ablauf des Aktionenkonzeptes. Nachfolgend wird der technische Ablauf kurz zusammengefasst um einen allgemeinen Überblick zu geben.

## Client Start

Eine Aktion wird die eine `Action definition` beschrieben. Diese Definition enthält Informationen für die Multifunktionsleiste sowie Ausführung der Aktion. Die Klassen sol.common.jc.ActionDefinitionUtils (Java Client) und sol.common.web.ActionDefinitionUtils (Web Client) bauen mithilfe des <a
href="#!/guide/p4A156A44_F024_4918_BE64_496EA6C348F2">Service</a> `sol.common.ix.services.RibbonDefinitionCollector` das Ribbon auf.

## Client Ausführung einer Aktion

Von den `ActionDefinitionUtils` werden die Informationen für die Ausführung einer Aktion an den `ActionHelper` übergeben. Dieser führt Vorbedingungen aus und ruft anschließend den Handler für die Aktion auf. Hierzu stehen momentan zwei Impementierungen zur Verfügung:

<span
style='font-weight:bold'>SIMPLE_ACTION</span>: sol.common.web.ActionHelper#executeSimpleAction
<span
style='font-weight:bold'>ADVANCED_ACTION</span>: sol.common.web.ActionHelper#executeAdvancedAction

Die Klassen `sol.common.jc.ActionHandler` sowie `sol.common.web.ActionHandler` führen anschließend die ELO Index Server oder ELO AS Aktion aus und sorgen für den Umgang mit den zurückgegebenen Verfahrensweisen (Events).

## Server Implementierung

Die Aktionslogik wird als Indexserver-Skript oder ELOas-Regel implementiert. Die Klassen `sol.common.ix.ActionBase` sowie `sol.common.as.ActionBase` stellen Hilfsfunktionen sowie eine Basis Implementierung bereit. Die zugrundeliegende `registered function` oder ELOas-Regel wird vom Client aufgerufen. 

Nicht verpflichtend kann eine Aktion auf dem Server einen Workflow starten um den technischen Ablauf zu modellieren. Zudem können von der Aktion auf Serverseite Events zurückgegeben werden die nach Ausführung vom Client verarbeitet werden müssen.

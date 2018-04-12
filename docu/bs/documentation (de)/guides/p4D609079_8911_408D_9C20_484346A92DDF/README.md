# Technische Konzepte

Um die Anpassbarkeit von Lösungen in den Projekten zu gewährleisten, wurde eine Reihe technologischer Konzepte entwickelt, die es ermöglichen, eine Lösung aus Einzelaspekten modular aufzubauen und diese wiederzuverwenden, um somit eine Updatefähigkeit der Lösung im Kern zu gewährleisten.

<span
style='font-weight:bold'>Diese Konzepte finden sich gebündelt in einem Paket namens </span><span
style='font-weight:bold;font-style:italic'>Business Solutions Common</span><span
style='font-weight:bold'> und können ebenfalls für eigene Projekte verwendet werden.</span>

<span
style='font-weight:bold'>Die folgenden Abschnitte fassen eine Reihe von implementierten Konzepten zusammen und geben einen einfachen Überblick. Weitere Informationen können stets der Klassendokumentation entnommen werden.</span>
 
Im Kern wurde ein <a
href="#!/guide/p78A42722_9D6B_45AE_884B_B847AE864468"><span
style='font-weight:bold'>Klassenframework</span></a> geschaffen, welches objektrelationalen Prinzipien folgt und somit bestehende Komponenten sowohl flexibel erweiterbar als auch effizienter in der Entwicklung gestaltet. So können bspw. <a
href="#!/guide/p375A5383_1983_41BE_8BC4_B145CFACA792"><span
style='font-weight:bold'>dynamische Stichwortlisten</span></a> durch eine Konfiguration von lediglich fünf Config-Properties schnell und sicher definiert werden. Eine Reihe von <a
href="#!/guide/pD1142BD3_E84D_4967_B5EC_A948C48729F7"><span
style='font-weight:bold'>Utility-Klassen</span></a> bildet dabei die Grundbelange von Lösungen ab und hilft beim Umgang mit Indexserver-Objekten und -Zugriffen. 

## Aktionen, Funktionsbausteine und Services

Darauf aufbauend wurde die Implementierung von Erweiterungen im Client (bspw. `Vertrag anlegen`) durch serverseitige <a
href="#!/guide/p0B6BCC8E_42D0_4EAE_BC44_F13016A4F81D"><span
style='font-weight:bold'>Aktionen</span></a>  standardisiert, was es ermöglicht, Funktionalität in allen ELO-Clients bereitzustellen. Technische Abläufe werden dabei durch <a
href="#!/guide/pADD870BA_9AA2_4900_8D6B_FA0FB26D9BEC"><span
style='font-weight:bold'>Funktionsbausteine</span></a> mithilfe von ELO-Workflows abgebildet. Dies ermöglicht maximale Flexibilität und folgt der Prämisse, einfache Logik anzupassen ohne eine Zeile Code zu schreiben.

{@img img1.png}

<a
href="#!/guide/p4A156A44_F024_4918_BE64_496EA6C348F2"><span
style='font-weight:bold'>Services</span></a> dienen dabei der Datensammlung oder stellen verschiedene Operationen bereit, die von der aufrufenden Instanz weiterverarbeitet werden müssen. So bietet bspw. die Klasse<span
style='font-weight:bold'> `sol.common.ix.service.ChildrenDataCollector`</span> die Möglichkeit, große Mengen an Daten zu sammeln und diese aufzubereiten. Dabei kann bspw. eine ELO App übermitteln, welche Informationen (bspw. `objKey`-Parameter) benötigt werden. Das spart Traffic und sorgt für performante Apps auch auf mobilen Geräten.



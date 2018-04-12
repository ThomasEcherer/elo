Ext.data.JsonP.p747E8A22_8C2B_4F4F_898C_98D609888B8F({"guide":"<h1 id='p747E8A22_8C2B_4F4F_898C_98D609888B8F-section-anwendungsfunktionalit%C3%A4t'>Anwendungsfunktionalität</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/p747E8A22_8C2B_4F4F_898C_98D609888B8F-section-elo-multi-client-strategie'>ELO-Multi-Client-Strategie</a>\n </li>\n<li>2. <a href='#!/guide/p747E8A22_8C2B_4F4F_898C_98D609888B8F-section-balance-von-scripting-und-modularisierung'>Balance von Scripting und Modularisierung</a>\n </li>\n</ul></div>\n\n<p>ELO-Clients bieten im Standard einen großen Funktionsumfang, der viele Grundbelange des Enterprise Content Managements abdeckt. Aufgrund des Komplexitätsgrads der Lösungen ist es notwendig, Clients um Anwendungslogik zu erweitern und weitere Funktionen bereitzustellen.</p>\n\n<blockquote><p><span\nstyle='font-weight:bold;font-style:italic'>Beispiel:</span><span\nstyle='font-style:italic'> Für die Verwaltung von elektronischen Akten im öffentlichen Sektor wurde eine eigene Registerkarte </span><span\nstyle='font-weight:bold;font-style:italic'>Akte</span><span style='font-style:\nitalic'> eingeführt, die weitere Aktionen wie bspw. </span><span\nstyle='font-weight:bold;font-style:italic'>Akte anlegen</span><span\nstyle='font-style:italic'>,</span><span style='font-weight:bold;font-style:\nitalic'> Akte schließen</span><span style='font-style:italic'>,</span><span\nstyle='font-weight:bold;font-style:italic'> Akte öffnen</span><span\nstyle='font-style:italic'> etc. bereitstellt.</span></p></blockquote>\n\n<p><p><img src=\"guides/p747E8A22_8C2B_4F4F_898C_98D609888B8F/img1.png\" alt=\"srvpdevbsOIvm•.8020/vveÉ x\nE LO pubsec\nDOCUMENT\nVIEW TASKS\nVorgang Laufmappe\nanlegen anlegen\nVorgangsbearbetung\n« I - Zentrale Verwaltung\np search this foner\n10 - Zentrale Verwaltung im allgemeinen\nELO Service\nNils Mosbach •\nGl Feed\nManual\nAktenplan\nSTART\nE-AKTE\nschließen öffnen\nBearbeiten\nAktenplan\nlöschen\n2\nAktenplan Anderung\nbeantr agen\nAktenband\nanlegen anlegen\nAn legen\nRepository\n10 - Zentrale...\nAk tenplan\nC) I - Zentrale Verwaltung\nt:» 2 - Konzeptentwicklung, Publikationen, Veranstal\nt:» 3- öffentlichketsarbet, Zusammenarbeit und Ko\" width=\"888\" height=\"345\"></p></p>\n\n<h2 id='p747E8A22_8C2B_4F4F_898C_98D609888B8F-section-elo-multi-client-strategie'>ELO-Multi-Client-Strategie</h2>\n\n<p>ELO verfolgt mit der Multi-Client-Strategie das Ziel, Benutzern unterschiedliche Clients zur Verfügung zu stellen.  Business Solutions setzen sich zum Ziel, Anwendungsfunktionalität gleichermaßen im Java Client und im Web Client bereitzustellen.</p>\n\n<p>Um dies in vertretbarem Aufwand zu gewährleisten, werden Funktionen als <a\nhref=\"#!/guide/p0B6BCC8E_42D0_4EAE_BC44_F13016A4F81D\"><span\nstyle='font-weight:bold'>Aktionen</span></a> weitgehend auf der Server-Seite durch ELOas oder Indexserver-Skripte implementiert. Aktionen teilen dem Client anschließend mit, was dieser nach erfolgreicher Ausführung erledigen soll. Eine Aktion wird meist durch einen Button in der Multifunktionsleiste ausgelöst.</p>\n\n<blockquote><p><span\nstyle='font-weight:bold;font-style:italic'>Beispiel:</span><span\nstyle='font-style:italic'> Im Falle der E-Akte findet sich im Client ein Button </span><span\nstyle='font-weight:bold;font-style:italic'>Akte anlegen</span><span\nstyle='font-style:italic'>, der die gleichnamige Aktion, repräsentiert durch die Klasse <code>sol.pubsec.ix.actions.CreateRecord</code> , auslöst. Diese Aktion, welche im Indexserver läuft, teilt dem Client anschließend mit, die erzeugte Akte anzuzeigen.</span></p></blockquote>\n\n<h2 id='p747E8A22_8C2B_4F4F_898C_98D609888B8F-section-balance-von-scripting-und-modularisierung'>Balance von Scripting und Modularisierung</h2>\n\n<p>Wird Anwendungslogik bereitgestellt, muss abgewogen werden, welche Logik in der Aktion implementiert wird und welche Logik modularisiert werden kann. Grundsätzlich gilt, dass die Aktion lediglich Basisoperationen wie bspw. das Anlegen eines Ordners erledigen sollte. <span\nstyle='font-weight:bold'>Für das Ausführen weiterer Logik (z.B. Erzeugen eines Feed-Beitrags) wird von der Aktion ein Workflow gestartet</span>, der mithilfe von <a\nhref=\"#!/guide/pADD870BA_9AA2_4900_8D6B_FA0FB26D9BEC\"><span\nstyle='font-weight:bold'>Funktionsbausteinen</span></a> auch komplexere Anwendungsfälle abbilden kann.</p>\n\n<p>Benutzereingaben sollten, soweit möglich, durch einen Benutzerknoten mit zugehörigem ELOwf-Formular realisiert werden. Aktionen können hierfür den Clients mitteilen, das Formular in einem Dialog anzuzeigen.</p>\n\n<p>Die richtige Balance von individuellem Scripting und Modularisierung durch Funktionsbausteine erlaubt es Partnern und Consultants, die Anwendungslogik von Lösungen durch einfache Modifikation des Workflows an ihre Bedürfnisse anzupassen. Zudem soll durch die Modularisierung von häufig benutzten Funktionen Entwicklungsarbeit reduziert werden.</p>\n\n<blockquote><p><span\nstyle='font-weight:bold;font-style:italic'>Beispiel:</span><span\nstyle='font-style:italic'> Die Aktion </span><span style='font-weight:bold;\nfont-style:italic'>Akte anlegen</span><span style='font-style:italic'> startet den Workflow <code>sol.pubsec.record.CreateRecord</code>    In diesem finden sich Funktionsbausteine, die bspw. einen Feed-Kommentar schreiben oder die Farbe der Aktenbeschriftung auf </span><span\nstyle='font-weight:bold;font-style:italic'>Offen</span><span style='font-style:\nitalic'> (Grün) setzen. Der Workflow enthält dabei einen Benutzerknoten, welcher ein Formular zur Erfassung der benötigten Informationen der Akte bereitstellt.</span></p></blockquote>\n","title":"Anwendungsfunktionalität"});
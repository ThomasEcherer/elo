# Web-Performance

Grundlegend gelten hier ebenfalls die Hinweise zur <a
href="#!/guide/pEFE7A0EF_91BC_4B57_9E2A_F8E29745A194">JS-Performance</a>. In Ergänzung ergeben sich im Web-Umfeld einige Besonderheiten aufgrund der Rendering-Engine des Browsers.

## Web-Applikationen sind single-threaded

<span class="tag_warning">Code, der während des Layout-Prozesses oder des Renderings ausgeführt wird, muss optimiert werden. Rechenintensive Aufgaben sollten dabei vermieden werden oder müssen in einen Background-Worker ausgelagert werden.</span>

Im klassischen Fall (falls keine Web-Worker zum Einsatz kommen) läuft die gesamte Web-Applikation in einem Thread. Das schließt Rendering, Layout sowie die gesamte JS-Ausführung mit ein. 

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Benötigt die Ausführung einer JS-Funktion mehrere Sekunden, friert in dieser Zeit die gesamte Oberfläche ein. Schlimmer noch: Werden ELO-Apps in bestehende Web-Applikationen eingebunden, trifft das auch auf die einbindende Applikation zu. So würde das Rechnungseingangscockpit bei teuren statistischen Auswertungen ebenfalls den Web Client blockieren.</span>

## Verwenden der Indexserver-API

<span class="tag_warning">Werden IX-Funktionen verwendet, <span
style='font-weight:bold'>müssen diese asynchron aufgerufen werden</span>, da andernfalls ebenfalls der UI-Thread blockiert wird, bis die Antwort vom Indexserver zurückgeliefert wurde.</span>

    api.IX.ix().checkoutSord("123", api.CONST.SORD.mbAll, api.CONST.LOCK.NO, 
        function(sord) {
          // success
        }, function() {
          // failure
        });

## CSS-Performance

CSS-Selektoren werden von rechts nach links aufgelöst. In diesem Fall ist zu beachten, dass folgender Selektor alle `span`-Elemente der aktuellen Webseite zurückliefert und nachfiltert:

    .invoices div.invoice span {
       font-size: 12px;
    }

In diesem Falle sollte besser ein einschränkender Selektor gewählt werden, der die Ergebnisliste stärker einschränkt:

    div.invoice span.title {
       font-size: 12px;
    }

## DOM-Zugriffe reduzieren​​​

<span class="tag_warning">Zugriffe auf das DOM des Browsers sind extrem teuer. Werden mehrere Elemente in einem Durchlauf der Webseite hinzugefügt, müssen diese <span
style='font-weight:bold'>vor</span> dem Hinzufügen zum DOM zusammengebaut werden. Nur so kann verhindert werden, dass der Browser bei jeder DOM-Operation den Rendering-Prozess anstößt.</span>

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Der Aufbau einer Tabelle in Kombination mit einer Schleife geschieht hier über eine String Builder-Implementierung in JS.&nbsp;Nach Abschluss der Operationen kann die Tabelle in das DOM geschrieben werden. </span>

    var tableBuilder= ['<table unselectable="on">'];
    for (var i=0; i<10000; i++) { 
       tableBuilder.push('<tr>
       tableBuilder.push('  <td>1</td>
       tableBuilder.push('  <td>2</td>
       tableBuilder.push('</tr>'); 
    } 
    tableBuilder.push('</table>');
     
    var table = tableBuilder.join("");
    document.getElementById('myTableContainer').innerHTML = table;
    

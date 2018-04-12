# JS-Performance

## Schleifen optimier​en

JS berechnet beim Durchlaufen von Schleifen zu jedem Iterationsschritt die Länge des Arrays. Bei größeren Arrays sollte daher die maximal Anzahl in einer Variablen gespeichert werden.

Teure Berechnungen und DOM-Operationen sollten zudem außerhalb von Schleifen erfolgen:

    var names = ['George', 'Ringo', 'Paul', 'John', ………]; 
    
    for(var i=0, var length = names.length; i < length; i++){ 
       doSomethingWith(names[i]); 
    }

## Vermeiden von eval ()

<span class="tag_warning">Der Einsatz der JavaScript-Funktion `eval()` sollte vermieden werden, da dieser Aufruf zur Laufzeit kompiliert werden muss. Dies ist teuer und beinhaltet zusätzliche Sicherheitsrisiken.</span>

## Iteration über Cache-Elemente
​
Iterieren über Objektattribute ist um ca. Faktor 6 langsamer als das Iterieren über ein einfaches Array. Werden Maps zum Zwischenspeichern von Objekten verwendet, sollte daher zwangsläufig parallel ein Array aufgebaut werden, falls später auf alle Elemente zugegriffen werden soll:

<span
style='font-weight:bold'>Schlecht `for/in`: </span>
    
    for (var guid in sordMap) {
        if (!sordMap.hasOwnProperty(guid)) continue;
     
        // do something with sordMap[guid];
    }

<span
style='font-weight:bold'>Besser `for/i`:</span>

    var length;
    for(var i=0, length=sordList.length; i < j; i++){ 
       var sord = sordList[i]; 
    }
    
## Iteration über Objekt-Attribute

Wird regelmäßig über alle Attribute eines dynamisch erzeugten Objekts iteriert empfiehlt es sich anstelle von `for (attName in obj)` beim Anlegen des Objekts eine Liste mit hinzugefügten Attributen zu pflegen. Iteriert wird anschließend über die Liste von Attributen:

    var obj = {
      _attrs = ['name', 'ort'],
      name: 'Max',
      ort: 'Stuttgart'
    };
    
    var length;
    for(var i=0, length=obj._attrs.length; i < j; i++){ 
       var attr = obj._attrs[i];
       var val = obj[attr]; 
    }

## Konvertieren von Nummern

Werden JS-Strings in Nummern konvertiert, konnte kein großer Performance-Unterschied zwischen `parseInt()`, `parseFloat()` oder `Number()` identifiziert werden. Hier kann die Funktion eingesetzt werden, die das gewünschte Ergebnis liefert.

# Logging

Das Logging von Lösungen wird mithilfe einer Hilfsklasse `sol.Logger` standardisiert. Diese stellt u. a. folgende Funktionen zur Verfügung:

*   Standardisierte Ausgabe für alle Typen
*   Vordefinierter Scope, der in die Log-Ausgabe aufgenommen wird
*   String Formatting-Möglichkeiten, um Log-Ausgaben mit Werten zu versehen
*   Weiterführende Informationen in das Log aufnehmen durch die Übergabe eines JS-Objekts
*   Ausführungszeiten von Funktionen loggen

<span class="tag_important">Eine genaue Beschreibung der Logging-Möglichkeiten gibt die Klasse `sol.Logger`. Alternativ kann selbstverständlich auch der im Scripting verfügbare Standard-Logger `log` verwendet werden.</span>

## Beispielhafte Verwendung

Zuerst muss eine Instanz der Logger-Klasse erzeugt werden:

    var logger = sol.create("sol.Logger", { scope: 'custom.ix.MyClass' });

<span class="tag_important"><span
style='font-weight:bold'>Für Implementierungen innerhalb einer eigenen Klasse, welche über das Klassenframework erstellt wurde</span>, erfolgt die Instanziierung des Loggers in der `initialize`-Funktion von `sol.Base`  Falls kein Logger zur Verfügung steht, ist zu prüfen, ob bei eigenen `initialize`-Funktionen auch die `initialize`-Funktion der Superklasse `sol.Base` aufgerufen wurde.</span>

Folgende Beispiele zeigen eine Verwendung des Loggers. Weitere Erklärungen können der Klassendokumentation von `sol.Logger` entnommen werden.

    logger.info('Searching for elements...');
    // [custom.ix.MyClass] Searching for elements... :
    
    logger.info('Searching for elements...', { parentId: 123 });
    // [custom.ix.MyClass] Searching for elements... : {"parentId":123}
    
    logger.info(['Searching for elements of parentId: {0}', 123]);
    // [custom.ix.MyClass] Searching for elements of parentId: 123 :
    
    logger.info(['Searching for elements of parentId: {0}', 123], {userName: 'Administrator'});
    // [custom.ix.MyClass] Searching for elements of parentId: 123 : {"userName":"Administrator"}

## Loggen von Funktionen

<span class="tag_important">Gerade bei vielen Funktionsaufrufen ist es notwendig, teure Aufrufe zu identifizieren, um die Performanz zu verbessern. Aus diesem Grund sollten Funktionenaufrufe mit `me.logger.enter` und `me.logger.exit` protokolliert werden. Im Debug-Modus wird anschließend die Ausführungszeit nach übergebenem Funktionsnamen ermittelt.</span>

    myFunction: function() {
      var me = this;
      me.logger.enter("my.Function", { param: "abc" });  // Object optional
      // function code belongs here.
      me.logger.exit("my.Function", { result: "xyz"});  // Object optional
    }
    
    // [custom.ix.MyClass] ENTER my.Function : {"param":"abc"}
    // [custom.ix.MyClass] EXIT my.Function : 313ms : {"result":"xyz"}


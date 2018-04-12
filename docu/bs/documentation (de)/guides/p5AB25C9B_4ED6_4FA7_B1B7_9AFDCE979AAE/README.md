# JS-Coding-Guidelines

## Namensgebung

​Variablen und Funktionen sollten durch&nbsp;aussagekräftige, zweckbeschreibende, aussprechbare, suchbare englische Namen beschrieben werden. Hierzu gilt: lange beschreibende Namen sind besser als kurze geheimnisvolle.

Es ist die&nbsp;​&quot;lowerCamelCase&quot;-Schreibweise zu&nbsp;verwenden, mit Ausnahme von Konstanten: diese werden GROSS geschrieben.

    var MAXUSERID = 900000;
     
    function buildName( firstName, lastName ) {
      var me = this;
      return firstName + ' ' + lastName;
    }

## Kommentare

​​Kommentare werden in Englisch geschrieben und erklären&nbsp;das Warum/Wofür, nicht das Was/Wie des Codes. Auskommentierter Code dient lediglich Test-Szenarien und sollte nicht hinterlassen werden.

JS ist eine untypisierte Sprache;&nbsp;Kommentare sollten daher den Standards von JSDuck entsprechen. Falls möglich sollte eine Parameter-Deklaration inkl. des Typs in den Kommentar aufgenommen werden.

Kommentare sollten durch /* */ anstelle von // definiert werden. Ersteres sorgt für keine&nbsp;Probleme, falls Zeilenumbrüche entfernt werden.

    /**
     * Represents a book.
     * @constructor
     * @param {string} title - The title of the book.
     * @param {string} author - The author of the book.
     */
    function Book(title, author) {
      var me = this, 
                data;
    /* using web worker since initial calculation might be expensive. */
      data = worker.readBook(title, author);
    }

## Kurznotationen verwenden​​​

​JS bietet eine Reihe von Kurznotationen, die zu verwenden sind.

<span
style='font-weight:bold'>Definition von Arrays</span>

    // falsch
    var lunch = new Array();
    lunch[0]='Dosa';
    lunch[1]='Roti';
    lunch[2]='Rice';
    lunch[3]='what the heck is this?';
    
    // richtig
    var lunch = ['Dosa',
       'Roti',
       'Rice',
       'what the heck is this?'];

<span
style='font-weight:bold'>Vereinfachte Schreibweise von if/else-Anweisungen</span>

    // falsch
    if(v){
       var x = v;
    } else {
       var x =10;
    }
    
    // richtig
    var x = v || 10;

<span
style='font-weight:bold'>Vereinfachte Schreibweise von komplexeren if/else-Anweisungen</span>

    // falsch
    var direction;
    if(x > 100){
       direction = 1;
    } else {
       direction = -1;
    }
    
    // richtig
    var direction = (x > 100) ? 1 : -1;

## Objekte und Variablen​

*   Property-Schreibweise verwenden, d.h. `file.name` statt `file.getName()`
*   wenig Verkettungen benutzen
*   keine ungarische Notation, keine Member-Präfixe
*   Variablen nicht wiederverwenden, vor allem nicht mit anderem Typ
*   `i`, `j`, `k` als Schleifenzähler sind o.k.

## Funktionen

*   Funktionen sollen ein Verb haben (`postPayment`, `deletePage`, `save`)
*   ein Wort pro Konzept, z.B. nicht zwischen `fetch`, `retrieve`, `get` wechseln
*   Funktionen sollen wenige Zeilen beinhalten
*   eine Funktion soll nur eine Aufgabe erfüllen
*   eine Abstraktionsebene pro Funktion
*   mehrere zusammengehörende Funktionen sollen von oben nach unten gelesen werden können, d.h. die Abstraktionstiefe wird nach unten tiefer
*   wenige Funktionsargumente verwenden
*   Anweisung und Abfrage sollten getrennt sein, d.h. keine Aufgabe in einer if-Abfrage erledigen
*   auch bei einzeiligen Anweisungsblöcken geschweifte Klammern verwenden

## Fehlerbehandlung

*   Ausnahmen statt Fehlercodes verwenden
*   es sollte kein &quot;null&quot; zurückgeben werden
*   &quot;null&quot; nur in Ausnahmen übergeben, als erlaubt dokumentieren

## Sonstiges​

*   Objektorientierung sollte verwendet werden um Namespaces zu schaffen; bei Libraries ein MUSS
*   `Array.join` als String Builder-Alternative verwenden​

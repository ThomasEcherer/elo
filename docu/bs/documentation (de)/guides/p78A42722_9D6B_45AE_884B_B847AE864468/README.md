# Klassenframework

<span class="tag_important"><span
style='font-weight:bold'>Eine detaillierte Beschreibung des Klassenframeworks gibt `sol.ClassManager`</span></span>

Um JavaScript-Klassen verstärkt zu modularisieren, wurde ein eigenes JS-Klassenframework entwickelt, das sich der objektrelationalen Entwicklung annähert und Grundkonzepte wie Vererbung, Mixins und Singletons implementiert. Mit Hilfe dieser Techniken ist es möglich, Basisfunktionalitäten in einer Base Class zu beschreiben und in unterschiedlichen Implementierungen zu nutzen.

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Die Klasse `sol.common.ix.DynKwlDatabaseIterator` stellt eine Basis-Implementierung für dynamische Stichwortlisten {{DYNLST}} bereit, die von unterschiedlichen Listen implementiert wird. So bspw. im Falle von </span><span
style='font-weight:bold;font-style:italic'>ELO Business Solutions Invoice</span><span
style='font-style:italic'> durch `sol.invoice.ix.dynkwl.Company`</span>

Der Vorteil hierdurch ist, dass Änderungen an der Implementierung durch Ableiten einer eigenen Klasse vorgenommen werden können. 

<span class="tag_caution">Consultants oder Entwickler, die mit ELO Business Solutions arbeiten, werden angewiesen, keine Änderungen an den Kern-Funktionalitäten vorzunehmen, um eine Upgrade-Fähigkeit zu gewährleisten. Alle Erweiterungen müssen durch eigene Abwandlungen der Klasse realisiert werden!</span>

Die Klasse `sol.ClassManager` verwaltet dabei alle Klassendefinitionen und ermöglicht es, Instanzen der Klassen zu erzeugen. 

## Klassenmodell

Im Folgenden wird ein einfaches Beispiel konstruiert, welches die Vorteile eines Klassenframeworks auf JavaScript-Basis verdeutlicht. Erweiterte Beispiele können der Dokumentation von `sol.ClassManager` entnommen werden.

{@img img1.png}

## Business Solutions Common-API

Dieses Common-Paket stellt eine API durch verschiedene Klassen bereit. Es beinhaltet Funktionen und Config-Properties, die verwendet werden können. 

<span class="tag_caution">In der JavaScript-Dokumentation werden interne Funktionen als `@private` oder `@protected` deklariert. Diese <span
style='font-weight:bold'>dürfen keinesfalls in Skripten verwendet werden</span>, da durch kontinuierliches Refactoring sich der interne Aufbau der Klasse durchaus ändern kann. Werden interne Klassenfunktionen überschrieben oder verwendet, kann die Funktionalität der Lösung zukünftig nicht gewährleistet werden. Consultants oder Entwickler, die mit ELO Business Solutions arbeiten, werden daher angewiesen, lediglich die in der Klassendokumentation als `@public` definierten Methoden und Properties zu verwenden.</span>

## Dokumentation von Klassen

Klassen und Funktionen müssen mithilfe der Spezifikation der Dokumentationsplattform <a
href="https://github.com/senchalabs/jsduck"><span style='font-weight:bold;
font-style:italic'>JSDuck</span></a> dokumentiert werden. Dies sorgt für die Implementierung objektrelationaler Konzepte in JS. 

<span class="tag_important">Weitere Informationen zur Dokumentation von JS-Dateien gibt die Anleitung zur <a
href="#!/guide/">JS-Dokumentation</a>.</span>

## Definition einer Klasse

Klassen werden mithilfe der Funktion `sol.define` definiert. Das folgende Beispiel veranschaulicht dies:

    sol.define("custom.solution.BaseModule", {
      requiredConfig: ['name'],
      initialize: function (config) {
        var me = this;
        me.$super("sol.Base", "initialize", arguments);
      },
      doSth: function () {  }
    });
    
    sol.define("custom.solution.Module2", {
      extend: "custom.solution.BaseModule",
      doSthDifferent: function () {  }
    });


## Erzeugen einer Klasse

Eine Instanz der Klasse kann anschließend durch `sol.create` erstellt werden. Der Vorteil besteht hier darin, dass selbst bei Instanziierung einer Klasse Funktionen der Superklasse überschrieben werden können.

    var myModule = sol.create("custom.solution.Module2", {
      name: "My first module",
      doSth: function() { 
        // implement custom doSth function
      }
    });

Mit Hilfe von Config-Properties können Werte definiert werden, die bei der Instanziierung einer Klasse mitgegeben werden müssen. In objektrelationalen Modellen würde dies einer Liste von Parametern entsprechen, die dem Konstruktor der Klasse übergeben werden. Die Basisimplementierung `sol.Base` trägt zusätzlich dafür Sorge, dass alle in `requiredConfig` definierten Config-Properties übergeben wurden. Andernfalls wird eine Exception geworfen.

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Die Klasse `sol.common.ix.DynKwlDatabaseIterator` hat eine Reihe von verpflichtenden Configs, die benötigt werden, um Datenbankabfragen auszulösen. Dies sind bspw. `sqlQuery`, `tableHeaders` und `tableKeyNames`</span>

{@img img3.png Config options 
Required config options 
„'Query : String 
sql-query that can contain placeholders ? used by prepared statements. 
CODE, NAME, STREET, ZIECCDE, CITY, cc-TYZRY CODE from CODE ? CR NAME 
column header names. 
mapping between columns and elo group or map fields.}

## Fallstricke

Mit Hilfe der Funktion `sol.define` kann eine Klasse definiert werden. Das bedeutet, dass durch das Prototyping Funktionen <span
style='font-weight:bold'>und Properties</span> statisch in der Objektinstanz zur Verfügung stehen. Somit dürfen auf Klassenebene lediglich Konstanten oder statische Werte gesetzt werden.

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Wird der Klassendefinition ein Array hinzugefügt, steht in allen erzeugen Instanzen der Klasse die gleiche Instanz des Arrays zur Verfügung. </span><span
style='font-weight:bold;font-style:italic'>Ist dies nicht gewollt, muss das Array in der </span><span
style='font-style:italic'>`initialize`-</span><span style='font-weight:bold;
font-style:italic'>Funktion der Klasse erzeugt werden.</span>

Im Vergleich zu objektorientierten Programmiersprachen wie Java können gleichnamige lokale Properties diejenigen des Prototypings überschreiben. 

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> In der Klassendefinition wird eine Property `name` mit dem Wert </span><span
style='font-weight:bold;font-style:italic'>nicht gesetzt</span><span
style='font-style:italic'> definiert. Die Funktion `setName()` setzt dabei den Namen auf Instanzebene. In diesem Fall wird der statische Name nicht geändert, die lokale Variable hat Vorrang. Wird jedoch ein auf Klassenebene definiertes Array erweitert, greift dies für alle anderen Klassen, da keine neue Array-Instanz auf Ebene der instanziierten Klasse angelegt wird.</span>

<span class="tag_important">Die Dokumentation von `sol.ClassManager` liefert im Kapitel <span
style='font-style:italic'>Class Properties and Prototyping</span> einige Beispiele.</span>





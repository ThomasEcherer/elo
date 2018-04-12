# JS-Dokumentation

<span
style='font-weight:bold'>Als Grundlage für die Dokumentation der JS-Klassen wird der Standard des Dokumentationstools </span><a
href="https://github.com/senchalabs/jsduck/wiki"><span style='font-weight:bold;
font-style:italic'>JSDuck</span></a><span style='font-weight:bold'> angewendet.</span> Objektrelationale Ansätze des <a
href="#!/guide/p78A42722_9D6B_45AE_884B_B847AE864468">Klassenframeworks</a> lassen sich hiermit, verglichen mit anderen Standards, am effizientesten abbilden.

Erweiterte Dokumentationsmechanismen stehen durch die Markdown-Syntax (md) zur Verfügung. Diese beschreibt bspw. die Definition von Überschriften und Code-Blöcken. Einige Beispiele:

    # Überschrift 1
    ## Überschrift 2
    
        // Code, 4 Zeichen eingerückt
        var x = 0;

## Dokumentation von Klassen

Klassen sollten mit einer Beschreibung der allgemeinen Funktionsweise sowie mit einigen Beispielen, wie diese Klasse verwendet werden kann, dokumentiert werden. Wichtig sind an dieser Stelle auch die Angabe von Versionsnummer und Namen des Entwicklers:

    /**
     * Basic description of this class
     *
     * # Usage scenario 1
     *
     *     var tpl = sol.create('sol.common.Template', {
     *     });
     *
     * @author Name, Company
     * @version 1.0
     */

Es ist nicht notwendig, die Vererbung und den Klassennamen mit `@extend` und `@class` zu dokumentieren. Private Funktionen und Attribute müssen mit `@private` gekennzeichnet werden.

Erwarten Klassen bei der Instanziierung eine Reihe von Config-Parametern, müssen diese mit `@config` gekennzeichnet werden.

## Abhängigkeiten von anderen JS-Klassen

Hat ein Skript Abhängigkeiten von anderen JS-Klassen, sollten diese durch das Tag `@requires` in der Klassenbeschreibung hinterlegt werden.

## Funktionsfähigkeit in ELO-Modulen

Entwickler werden bei der Lösungsentwicklung mit unterschiedlichen Scripting-Umgebungen konfrontiert. ELOas, Java Client und Indexserver verwenden bspw. die Rhino-Engine für die JS-Ausführung, Web-Applikationen dagegen einen Browser wie bspw. Google Chrome. 

    @eloall   // All ELO components and applications
    @eloix    // ELO Indexserver
    @eloas    // ELO Automation Services
    @elojc    // ELO Java Client
    @eloweb   // ELO Web Client

## Gesamtes Beispiel

    /**
     * Basic description of this class
     *
     * # Usage scenario 1
     *
     *     var tpl = sol.create('sol.common.Template', {
     *         source = 'Hello {{name}}.'
     *     });
     *
     *     var result = tpl.apply({
     *       name: 'Marcus'
     *     });
     *
     * @author Name, Company
     * @version 1.0
     *
     * @eloix
     * @eloas
     * @elojc
     * @requires handlebars.js
     */
    sol.define("sol.common.Template", {
    
      /**
       * @cfg {String} source
       * Template source as a string.
       */
      source: 'not defined',
    
      /**
      * @private
      * Compiles the template string.
      */
      compile: function () {  },
    
      /**
       * Loads the template string from an ELO document
       * @param {String} ELO object ID
       */
      load: function (objId) {  },
    });

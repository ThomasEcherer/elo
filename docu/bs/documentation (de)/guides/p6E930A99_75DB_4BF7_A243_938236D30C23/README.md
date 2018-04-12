# Praxisbeispiele für ELO-Module

Das Modularisieren von Funktionalität über eigene JS-Klassen ermöglicht es, Funktionalität erweiterbar und dokumentierbar zu halten. Im Folgenden sollen einige Rohlinge für das Erstellen von neuen JS-Klassen sowie Utility-Klassen gezeigt werden.

## Neue JS-Klasse

    //@include lib_Class.js.js
    
    /**
     * Class documentation here
     *
     * @author {NAME}, ELO Digital Office GmbH
     * @version 1.0
     */
    sol.define("sol.common.ClassName", {
          
      /** 
       * @cfg {String} objId
       */
      objId: undefined,
      
      /**
       * @property {Number} myProperty
       */
      myProperty: 123,
      
      initialize: function (config) {
        var me = this;
        me.$super("initialize", [config]);
      } 
      
    });

## Utiltily-Klassen als Singleton

    //@include lib_Class.js.js
    
    /**
     * @singleton
     *
     * Class documentation here
     *
     * @author {NAME}, ELO Digital Office GmbH
     * @version 1.0
     */
    sol.define("sol.common.ClassName", {
      singleton: true,
     
    });
    
    

    

# Indexserver-Scripting

Im Folgenden sollen einige Best Practices zum Erstellen von Funktionalität mithilfe des ELO Indexservers gegeben werden.

## IX-Function (Funktionsbaustein)

Indexserver-Funktionalität sollte soweit möglich und sinnvoll als `sol.common.ix.FunctionBase` implementiert werden. Dies stellt grundlegend sicher, dass die implementierte Funktion als Baustein im Workflow sowie eigenständig über die IX-Schnittstelle aufgerufen werden kann.


    importPackage(Packages.de.elo.ix.client);
    
    //@include lib_Class.js
    //@include lib_sol.common.ix.FunctionBase.js
    // further includes
    
    var logger = sol.create("sol.Logger", { scope: "{{namespace}}.ix.functions.{{className}}" });
    
    /**
     * {{description}}
     *
     * @author {{author}}, {{company}}
     * @version 1.00.000
     *
     * @eloix
     * @requires sol.common.Config
     * @requires sol.common.ConfigMixin
     * @requires sol.common.ObjectUtils.js
     * @requires sol.common.StringUtils.js
     * @requires sol.common.JsonUtils.js
     * @requires sol.common.RepoUtils.js
     * @requires sol.common.WfUtils.js
     * @requires sol.common.ix.RfUtils.js
     * @requires sol.common.ix.FunctionBase
     */
    sol.define("{{namespace}}.ix.functions.{{className}}", {
      extend: "sol.common.ix.FunctionBase",
    
      // you might add required configuration here //
      //requiredConfig: [],
      
      // configuration section //
      /** 
       * @cfg {Type} exampleCfg
       */
      
      // property section //
      /**
       * @private
       * @property {Type} exampleProperty
       */
       
      initialize: function (config) {
        var me = this;
        me.$super("sol.common.ix.FunctionBase", "initialize", [config]);
        // do your initialization //
      },
    
      /**
       * {{description}}
       */
      process: function () {
        var me = this;
        // do your processing //
      }
    
      // add your internal methods //
    
    });
    
    /**
     * @member {{namespace}}.ix.functions.{{className}}
     * @static
     * @inheritdoc sol.common.ix.FunctionBase#onEnterNode
     */
    function onEnterNode(ci, userId, wfDiagram, nodeId) {
      logger.enter("onEnterNode_{{className}}", { "flowId": wfDiagram.id, "nodeId": nodeId });
      var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId), // you might add required properties here
          module;
    
      // These might be usefull in your class //
      //config.objId = wfDiagram.objId;
      //config.ci = ci;
      module = sol.create("{{namespace}}.ix.functions.{{className}}", config);
    
      module.process();
    
      logger.exit("onEnterNode_{{className}}");
    }
    
    /**
     * @member {{namespace}}.ix.functions.{{className}}
     * @static
     * @inheritdoc sol.common.ix.FunctionBase#onExitNode
     */
    function onExitNode(ci, userId, wfDiagram, nodeId) {
      logger.enter("onExitNode_{{className}}", { "flowId": wfDiagram.id, "nodeId": nodeId });
      var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId), // you might add required properties here
          module;
    
      // These might be usefull in your class //
      //config.objId = wfDiagram.objId;
      //config.ci = ci;
      module = sol.create("{{namespace}}.ix.functions.{{className}}", config);
    
      module.process();
    
      logger.exit("onExitNode_{{className}}");
    }
    
    /**
     * @member {{namespace}}.ix.functions.{{className}}
     * @method RF_{{namespaceWithUnderscores}}_function_{{className}}
     * @static
     * @inheritdoc sol.common.ix.FunctionBase#RF_FunctionName
     */
    function RF_{{namespaceWithUnderscores}}_function_{{className}}(ec, configAny) {
      logger.enter("RF_{{namespaceWithUnderscores}}_function_{{className}}", configAny);
      var rfUtils = sol.common.ix.RfUtils,
          config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), // you might add required properties here
          module;
      
      // These might be usefull in your class //
      //config.ci = ec.ci;
      //config.user = ec.user;
    
      module = sol.create("{{namespace}}.ix.functions.{{className}}", config);
      module.process();
    
      logger.exit("RF_{{namespaceWithUnderscores}}_function_{{className}}");
    }


## IX-Action (Aktion)


    importPackage(Packages.de.elo.ix.client);
    
    //@include lib_Class.js
    //@include lib_sol.common.ix.ActionBase.js
    // further includes
    
    var logger = sol.create("sol.Logger", { scope: "{{namespace}}.ix.actions.{{className}}" });
    
    /**
     * {{description}}
     * 
     * @author {{author}}, {{company}}
     * @version 1.00.000
     * 
     * @eloix
     * @requires sol.common.JsonUtils
     * @requires sol.common.SordUtils
     * @requires sol.common.IxUtils
     * @requires sol.common.CounterUtils
     * @requires sol.common.TranslateTerms
     * @requires sol.common.WfUtils
     * @requires sol.common.ix.RfUtils
     * @requires sol.common.ix.ActionBase
     */
    sol.define("{{namespace}}.ix.actions.{{className}}", {
      extend: "sol.common.ix.ActionBase",
      
      // you might add required configuration here //
      //requiredConfig: [],
      
      // configuration section //
      /** 
       * @cfg {Type} exampleCfg
       */
      
      // property section //
      /**
       * @private
       * @property {Type} exampleProperty
       */
      
      initialize: function (config) {
        var me = this;
        me.$super("sol.common.ix.ActionBase", "initialize", [config]);
        // do your initialization //
      },
      
      /**
       * Returns the name of this action.
       * @return {String}
       */
      getName: function () {
        return "{{className}}";
      },
      
      /**
       * {{description}}
       */
      process: function () {
        var me = this;
        // do your processing //
        me.addErrorEvent("This is just an example, this action has no implementaion yet");
      }
      
      // add your internal methods //
      
    });
    
    /**
     * @member {{namespace}}.ix.actions.{{className}}
     * @method RF_{{namespaceWithUnderscores}}_action_{{className}}
     * @static
     * @inheritdoc sol.common.ix.ActionBase#RF_FunctionName
     */
    function RF_{{namespaceWithUnderscores}}_action_{{className}}(ec, configAny) {
      var config, action, result;
      
      logger.enter("RF_{{namespaceWithUnderscores}}_action_{{className}}", configAny);
    
      config = sol.common.ix.RfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), // you might add required properties here
    
      // These might be usefull in your class //
      //config.ci = ec.ci;
      //config.user = ec.user;
      
      action = sol.create("{{namespace}}.ix.actions.{{className}}", config);
      result = action.execute();
      
      logger.exit("RF_{{namespaceWithUnderscores}}_action_{{className}}");
      
      return result;
    }


## IX-Service

Indexserver-Funktionalität, die Daten zurückliefert oder es erfordert, dass das Ergebnis weiterverarbeitet wird, sollte soweit möglich und sinnvoll als `sol.common.ix.ServiceBase` implementiert werden. 

    importPackage(Packages.de.elo.ix.client);
    
    //@include lib_Class.js
    //@include lib_sol.common.ix.ServiceBase.js
    
    var logger = sol.create("sol.Logger", { scope: "{{namespace}}.ix.services.{{className}}" });
    
    /**
     * {{description}}
     *
     * @author {{author}}, {{company}}
     * @version 1.00.000
     *
     * @eloix
     * @requires sol.common.JsonUtils
     * @requires sol.common.ix.RfUtils
     * @requires sol.common.ix.ServiceBase
     */
    sol.define("{{namespace}}.ix.services.{{className}}", {
      extend: "sol.common.ix.ServiceBase",
    
      // you might add required configuration here //
      //requiredConfig: [],
      
      // configuration section //
      /** 
       * @cfg {Type} exampleCfg
       */
      
      // property section //
      /**
       * @private
       * @property {Type} exampleProperty
       */
       
      initialize: function (config) {
        var me = this;
        me.$super("sol.common.ix.ServiceBase", "initialize", [config]);
        // do your initialization //
      },
    
      /**
       * {{description}}
       */
      process: function () {
        var me = this;
        // do your processing //
        return { hallo: "welt" };
        
      }
      
      // add your internal methods //
      
    });
    
    /**
     * @member {{namespace}}.ix.services.{{className}}
     * @method RF_{{namespaceWithUnderscores}}_service_{{className}}
     * @static
     * @inheritdoc sol.common.ix.ServiceBase#RF_ServiceBaseName
     */
    function RF_{{namespaceWithUnderscores}}_service_{{className}}(ec, configAny) {
      var rfUtils = sol.common.ix.RfUtils,
          config, service, result;
      
      logger.enter("RF_{{namespaceWithUnderscores}}_service_{{className}}", configAny);
    
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), // you might add required properties here
    
      // These might be usefull in your class //
      //config.ci = ec.ci;
      //config.user = ec.user;
    
      service= sol.create("{{namespace}}.ix.services.{{className}}", config);
      result = rfUtils.stringify(service.process());
    
      logger.exit("RF_{{namespaceWithUnderscores}}_service_{{className}}");
    
      return result;
    }


## Dynamische Stichwortlisten

Dynamische Stichwortlisten sollten mithilfe der Klasse `sol.common.ix.DynKwlDatabaseIterator` implementiert werden. Diese kapselt grundlegende Anforderungen an den Umgang mit Datenbanken und lässt sich einfach konfigurieren.

    importPackage(Packages.de.elo.ix.jscript);
    importPackage(Packages.de.elo.ix.scripting);
    
    //@include lib_Class.js.js
    //@include lib_sol.common.ix.DynKwlDatabaseIterator.js
    
    /**
     * Dynamic keyword list that queries the recipients database.
     *
     * The list of current fields is returned as a table.
     *
     * |Name|Key|Example data|
     * |:-----|:------|:------|
     * |Company Code|COMPANY_NO|122|
     * |Name|COMPANY_NAME|ELO Digital Office GmbH|
     * |Street|COMPANY_ADDRESS_STREET|TuebingerStr. 34|
     * |Zip code|COMPANY_ADDRESS_ZIPCODE|70178|
     * |City|COMPANY_ADDRESS_CITY|Stuttgart|
     * |Country|COMPANY_ADDRESS_COUNTRY|DE|
     *
     * Limits results to COMPANY_NO.
     *
     * @author {{author}}, {{company}}
     * @version 1.00.000
     */
    sol.define("sol.invoice.ix.dynkwl.Company", {
      extend: "sol.common.ix.DynKwlDatabaseIterator",
      /**
       * @cfg
       * @inheritdoc
       */
      tableTitle: "Firma",
      /**
       * @cfg
       * @inheritdoc
       */
      sqlQuery: "select CODE, NAME, STREET, ZIPCODE, CITY, COUNTRY_CODE from sol_invoice_company where CODE like ? OR NAME like ?",
      /**
       * @cfg
       * @inheritdoc
       */
      sqlParams: [
        {mode: "STARTS_WITH"},
        {mode: "CONTAINS"}
      ],
      /**
       * @cfg
       * @inheritdoc
       */
      tableKeyNames: ["COMPANY_CODE", "COMPANY_NAME", null, null, null, null],
      //tableKeyNames: ["COMPANY_CODE", "COMPANY_NAME", "COMPANY_ADDRESS_STREET", "COMPANY_ADDRESS_ZIPCODE", "COMPANY_ADDRESS_CITY", "COMPANY_ADDRESS_COUNTRY"],
      /**
       * @cfg
       * @inheritdoc
       */
      tableHeaders: ["Nummer", "Name", "Straße", "PLZ", "Ort", "Land"]
    });
    
    /**
     * @static
     * @member sol.invoice.ix.dynkwl.Company
     * Implements a DynamicKeywordDataProvider for this keyword list that can be used by checkoutKeywordsDynamic.
     * @returns {DynamicKeywordDataProvider}
     */
    function getDataIterator() {
      var log = sol.create("sol.Logger", {scope: "sol.invoice.ix.dynkwl.Company"}),
        iterator;
      try {
        log.info("DynamicKeywordList (");
        iterator = sol.create("sol.invoice.ix.dynkwl.Company", {});
        return new DynamicKeywordDataProvider(iterator);
      } finally {
        log.info(")getDataIterator");
      }
    }


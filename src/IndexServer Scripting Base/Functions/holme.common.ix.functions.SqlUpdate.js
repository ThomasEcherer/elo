
importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.FunctionBase.js
//@include lib_sol.common.RepoUtils.js
//@include lib_sol.common.ObjectUtils.js
//@include lib_sol.common.SordUtils.js
//@include lib_sol.common.Template.js


var logger = sol.create("sol.Logger", { scope: "holme.common.ix.functions.SqlUpdate" });

/**
 * Executes an update- or insert-SQL Command.
 * 
 * Uses the ELO-Database Connection by default.
 * If a dataBaseSource and/or SchemaName is set, it has to be configured
 * as JNDI Resource in the Tomat/conf/context.xml
 * 
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.Config
 * @requires sol.common.Template
 * @requires sol.common.RepoUtils  
 */
sol.define("holme.common.ix.functions.SqlUpdate", {
  extend: "sol.common.ix.FunctionBase",
  
  /**
   * @property {String|int} objId The ObjectId of the Elo-Object the Workflow is attached to. (Will be used for Tempalting)
   */
  objId: undefined,

  /**
   * @property {String} statement The Statement to execute. Either this or 'statementTemplate' has to be set. 
   */
  statement: undefined,

  /**
   * @property {String} statementTemplate ObjID|Guid|Arcpath to the Templatefile of the statment to execute. Either his or 'statement' has to be set
   */
  statementTemplate: undefined,

  /**
   * @property {String} dataSourceName (optional) The name of the datasource to use. If not set the ELO-Db-Connection will be used
   */
  dataSourceName: undefined,

  /**
   * @property {String} schemaName (optional) The Name of the Schema to connect to. Only usable with 'dataSourceName'.
   * @see dataSourceName
   */
  schemaName: undefined,

  /**
   * @property {boolean} debug Determines if Debug-Messages schould be written or not. Default is false
   */
  debug: false,

  initialize: function (config) {
    var me = this;
    me.$super("sol.common.ix.FunctionBase", "initialize", [config]);    

    if (!me.statement && !me.statementTemplate) {
      throw "Either 'statement' or 'statementTemplate' has to be set";
    }
  },

  /**
   * Prepares the Statemnt. 
   * Uses Templating to complete it. 
   * Executes the SQL-stement
   */
  process: function () {
    var me = this,
        dbcn, stmnt, ret;  

    //  Initialize Datebase Connection
    if (me.debug) {
      logger.info("... init Database Connection ...");
    }
    dbcn = me.initDatabaseConnection();

    //  Prepare the SQL-Statement
    if (me.debug) {
      logger.info("... Prepare the SQL-Statement ...");      
    }
    stmnt = me.prepareStatement();
       
    //  Execute SQL-Statement
    if (me.debug) {
      logger.info("Executing Statement:", stmnt);
    }
    ret = dbcn.update(stmnt);
    logger.info("Number of Rows affected: ", ret);

  },

  /**
   * @private
   * Initializes the Database Connection.
   * If 'dataSourceName' and/or 'schemaName' this will be used to establish a database connection.
   * Otherwise the ELO-DB-Connection will be used.
   * 
   * @return {de.elo.ix.jscript.DBConnection} The Datdabase-Connection
   */
  initDatabaseConnection: function () {
    var me = this;

    if (me.dataSourceName) {
      if (me.schemaName) {
        return new Packages.de.elo.ix.jscript.DBConnection(me.dataSourceName, me.schemaName);
      }
      return new Packages.de.elo.ix.jscript.DBConnection(me.dataSourceName);
    }
    return new Packages.de.elo.ix.jscript.DBConnection();
  },

  /**
   * Downloads the Statment from the Templatefile.
   * Completes it withtemplating.
   * 
   * @returns {String} The SQL-Command to execute
   */
  prepareStatement: function () {
    var me = this,
        sord, templateId, tpl;

    //  Download Statment if template is configured
    if (me.statementTemplate) {
      templateId = sol.common.RepoUtils.getSord(me.statementTemplate, { sordZ: SordC.mbMin, lockZ: LockC.NO }).id;
      me.statement = sol.common.RepoUtils.downloadToString(templateId, null);
    }

    //  Use Templating to comPreparedplete the statemnt
    if (me.objId) {
      sord = ixConnectAdmin.ix().checkoutSord(me.objId, SordC.mbLean, LockC.NO);
      tpl = sol.create("sol.common.Template", { source: me.statement });
      return tpl.applySord(sord);
    }
    
    return me.statement;
  }
});

/**
 * @member holme.common.ix.functions.SqlUpdate
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onEnterNode
 */
function onEnterNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onEnterNode_SqlUpdate", { flowId: wfDiagram.id, nodeId: nodeId });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId), 
      module;
  
  config.objId = wfDiagram.objId;
  module = sol.create("holme.common.ix.functions.SqlUpdate", config);
  module.process();

  logger.exit("onEnterNode_SqlUpdate");
}

/**
 * @member holme.common.ix.functions.SqlUpdate
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onExitNode
 */
function onExitNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onExitNode_SqlUpdate", { flowId: wfDiagram.id, nodeId: nodeId });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId),
      module;

  config.objId = wfDiagram.objId;
  module = sol.create("holme.common.ix.functions.SqlUpdate", config);
  module.process();

  logger.exit("onExitNode_SqlUpdate");
}

/**
 * @member holme.common.ix.functions.SqlUpdate
 * @method RF_holme_common_function_SqlUpdate
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.RF_FunctionName
 */
function RF_holme_common_function_SqlUpdate(ec, configAny) {
  logger.enter("RF_holme_common_function_SqlUpdate", configAny);
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), 
      module;

  module = sol.create("holme.common.ix.functions.SqlUpdate", config);
  module.process();

  logger.exit("RF_holme_common_function_SqlUpdate");
}
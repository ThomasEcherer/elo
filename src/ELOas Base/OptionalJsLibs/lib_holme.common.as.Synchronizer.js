
importPackage(Packages.de.elo.ix.jscript);
importPackage(Packages.de.elo.ix.scripting);

//@include lib_sol.common.RepoUtils.js
//@include lib_sol.common.XmlUtils.js
//@include lib_sol.common.CounterUtils.js
//@include lib_sol.common.ActionBase.js
//@include lib_sol.common.as.ActionBase.js
//@include lib_sol.common.as.FunctionBase.js
//@include lib_sol.common.JsonUtils.js
//@include lib_sol.common.SordUtils.js
//@include lib_sol.common.IxUtils.js
//@include lib_sol.common.CounterUtils.js
//@include lib_sol.common.TranslateTerms.js
//@include lib_sol.common.WfUtils.js


/**
 *
 * 
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 * 
 * @eloas
 */
sol.define("holme.common.as.Synchronizer", {
  
  /**
   * @property {Object} sqlConfig of the SQL Paramters
   * @property {int} sqlConfig.dbnr The number of the stored
   * @property {String} sqlConfig.stmnt The ID|GUID|Arcpath to the Statementfile      
   * @property {Object} sqlConfig.placeHolder Content of the Placehodler to be placed into the statement   
   */
  sqlConfig: undefined,

  /**
   * @cfg
   * @property {String[]} keyAttributes A List of SQL-Columns/Groupnames used as Search-Paramters to find the related elo-object
   */
  keyAttributes: undefined,

  /**
   * @cfg
   * @property {String} mask (optional) The name of the keywording mask to search for
   */
  mask: undefined,

  /**
   * @cfg
   * @property {String} wf (optional) Name of the Workflowtemplate to start if changes on the indexing information happend.
   */
  wf: undefined,

  /**
   * @cfg
   * @property {String[]} updateIndexFields (optional) If set, this defines the sqlColumns to write the indexfield with the same name
   */
  updateIndexFields: undefined,

  /**
   * @cfg
   * @property {boolean} createNewIfNotFound (optional) Default ist true. Determines if a new object is created if no one is found 
   */
  createNewIfNotFound: true,

  /**
   * @private
   * @property {ResultSet} rs The Result from the sql-query
   */
  rs: undefined,

  initialize: function (config) {
    var me = this;    
    config = config || {};
    me.$super("sol.Base", "initialize", [config]);
    if (!me.logger) {
      me.logger = sol.create("sol.Logger", { scope: "holme.common.as.Synchronizer" });
    }
  },

  process: function () {
    var me = this,
        stmnt, eloObjectId, row, rs,
        i, max;

    //  preapres the statement
    me.logger.info("... prepare SQL Statment ...");
    stmnt = me.prepareSqlStatement();

    //  Triggers the statment    
    me.logger.info("... Query date with Statement:", stmnt);
    rs = me.query(stmnt);

    //  Go through every line
    me.logger.info("...Go through every line of result...");
    max = rs.length;
    for (i = 0; i < max; i++) {    

      me.logger.info(["... Processing row {0}/{1}", i, max]);
      row = rs[i];

      //  Find elo Object
      me.logger.info("... Try to find ELO-Object ...");
      eloObjectId = me.findEloObject(row);
      me.logger.info("... Found ELO-Object: ", eloObjectId);

      //  May create a new object
      if (eloObjectId < 1 && me.createNewIfNotFound) {
        me.logger.info("ELO-Object not found. Gonna Create one");
        eloObjectId = me.createNewEloObject(row);
        me.logger.info("Created new Object:", eloObjectId);
      }

      if (eloObjectId < 1) {
        throw "Elo Object not found and/or could not be created";
      }

      //  Update Index-Informations
      me.logger.info("... Updating Index Informations ...");
      me.updateIndexing(eloObjectId, row);

      //  If Changes happend start workflow
      if (me.wf) {
        me.logger.info("... Start Workflow-Teample:", me.wf);
        sol.common.WfUtils.startWorkflow(me.wf, me.wf, eloObjectId);
      }
    }
  },
   
  /**
   * Searches an ELO-Object with the defined keyattribute an document-mask. ('mask', 'keyAttributes')
   * 
   * @returns {int} The ID of the object found. Or -1 if nothing was found.
   */
  findEloObject: function () {
    var me = this,  
        cfg, keys = [], i, max;

    max = me.keyAttributes.length;
    for (i = 0; i < max; i++) {
      keys.push({
        name: me.keyAttributes[i],
        value: me.rs.getString(me.keyAttributes[i])
      });
    }

    cfg = {
      mask: me.mask,
      keys: keys
    };

    return holme.common.RepoUtils.findFirst(cfg);
  },

  /**
   * Initializes the DB-Connection. Triggers the query, and returns the result of it
   * 
   * @param {String} stmnt The Statement to trigger
   * @returns {Object[]} The Result of the Query
   */
  query: function (stmnt) {
    var me = this,
        dbConnection;

    dbConnection = me.initDbSession();
    if (me.sqlConfig.placeHolder) {
      return dbConnection.query(stmnt, me.sqlConfig.placeHolder);
    }
    return dbConnection.query(stmnt);
  },

  /**
   * Updates the Keywording information of the elo-object
   * 
   * @param {String|int} objId The ObjectId of the ELO-Object to update
   * @param {Object} row An JavaScript-Object of the row 
   */
  updateIndexing: function (objId, row) {
    var me = this,
        sord, i, max;

    try {
      sord = ixConnect.ix().checkoutSord(objId, SordC.mbLean, LockC.YES);

      max = me.updateIndexFields.length;
      for (i = 0; i < max; i++) {
        sol.common.SordUtils.setObjKeyValue(sord, me.updateIndexFields[i], row[me.updateIndexFields[i]]);
      }

      ixConnect.ix().checkindSord(sord, SordC.mbLean, LockC.YES);

    } catch (e) {
      me.logger.error("Error on updat indexing: ", e);
      if (sord) {
        try {
          ixConnect.ix().checkindSord(sord, SordC.mbOnlyUnlock, LockC.YES);
        } catch (ignored) {
          /* ignored */
        }
      }
      throw e;
    }
  },

  /**
   * Internal function that opens a database connection for map and non map
   * capable clients. Via default the archive database is used but can be changed
   * to a custom database connection if jdbc and dbName has been set.  * 
   * 
   * @returns {de.elo.ix.jscript.DBConnection} database connection
   */
  initDbSession: function () {
    var me = this;
    if (me.jdbc && me.dbName) {
      return new Packages.de.elo.ix.jscript.DBConnection(me.jdbc, me.dbName);
    } else if (me.jdbc) {
      return new Packages.de.elo.ix.jscript.DBConnection(me.jdbc);
    } else {
      return new Packages.de.elo.ix.jscript.DBConnection();
    }
  },

  /**
   * Reads the startement-file as String (sqlConfig.stmmt)
   * 
   * @returns {String} The SQL-Query
   */
  prepareSqlStatement: function () {
    var me = this,
        objid;    

    if (sol.common.RepoUtils.isGuid(me.sqlConfig.stmnt) || sol.common.RepoUtils.isObjId((me.sqlConfig.stmnt))) {
      return sol.common.RepoUtils.downloadToString(me.sqlConfig.stmnt, null);
    } else {
      try {
        objid = sol.common.RepoUtils.getObjId(me.sqlConfig.stmnt);        
        return sol.common.RepoUtils.downloadToString(objid, null);
      } catch (e) {
        me.logger.error("Error on resolving Arcpath of sqstmnt", me.sqlConfig.stmnt);
        throw e;
      }      
    }
  },

  /**
   * Creates a new Folder in the chaos cabinet.
   *  
   * @param {Object} row The Indexingvalues for the new Object. Every Parameter is seen as ObjKeys
   * @returns {int} The freshly created 
   */
  createNewEloObject: function (row) {
    var me = this,
        sord, i, max;

    sord = ixConnect.ix().createSord("0", me.mask, EditInfoC.mbSord).sord;
    max = me.updateIndexFields.length;
    for (i = 0; i < max; i++) {
      sol.common.SordUtils.setObjKeyValue(sord, me.updateIndexFields[i], row[me.updateIndexFields[i]]);
    }

    return ixConnect.ix().checkindSord(sord, SordC.mbLean, LockC.YES);   
  }

});
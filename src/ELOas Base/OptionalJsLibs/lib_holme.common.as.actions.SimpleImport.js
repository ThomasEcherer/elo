
//@include lib_Class.js
//@include lib_sol.common.as.ActionBase.js
//@include lib_sol.common.RepoUtils.js
//@include lib_sol.common.FileUtils.js

var logger = sol.create("sol.Logger", { scope: "holme.common.as.actions.SimpleImport" });

/**
 * Code documentation
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @requires sol.common.RepoUtils
 * @requires lib_sol.common.FileUtils
 */
sol.define("holme.common.as.actions.SimpleImport", {
  extend: "sol.common.as.ActionBase",

  /**
   * @property {String} folderImport The Path to the folder to import
   */
  folderImport: undefined,

  /** 
   * @property {String} folderTodo (optional) If set the documents will be moved into this folder before import. This is used to make sure that the documents are not in access by any other programm
   */
  folderTodo: undefined,

  /**
   * @property {String} folderError (optional) If set and any error occurs, the document will be moved into this folder
   */
  folderError: undefined,

  /**
   * @property {String} folderDone (optional) If set the document will be moved into this folder after archiving
   */
  folderDone: undefined,

  /**
   * @property {boolean} deleteAfterImport Default is false. If set the document will be deleted after import. 
   */
  deleteAfterImport: false,

  /**
   * @property {String} extFiler (optional) If set only documents with the given extension will be imported
   */
  extFiler: undefined,

  /**
   * @property {String} workflowTemplate (optional) If set, the given workflow will be started
   */
  workflowTemplate: undefined,

  /**
   * @property {String} parentId Default is '0' (Chaos Cabinet). Defines where to archive the dcoument
   */
  parentId: 0,

  /**
   * @property {String} mask The keywording-mask the documents will get. Default is '0'
   */
  mask: 0,

  requiredConfig: ["folderImport"],
  
  initialize: function (config) {
    var me = this;
    me.$super("sol.common.ix.ActionBase", "initialize", [config]);
  },

  getName: function () {
    return "holme.common.as.actions.SimpleImport";
  },

  process: function () {
    var me = this,
        files, i, max, objId, wfid;
        
    // get the files to import
    files = me.getFilesToImport();

    // Go through all files to import
    max = files.length;
    for (i = 0; i < max; i++) {
      try {

        // import file
        objId = me.importFile(files[i]);

        // start workflow
        if (me.workflowTemplate) {
          wfid = ixConnect.ix().startWorkflow(me.workflowTemplate, me.workflowTemplate, objId);
          logger.info(["Workflow {0} started on Object {1}", wfid, objId]);          
        }

        // Delete / Move file
        if (me.deleteAfterImport) {
          sol.common.FileUtils(files[i].getAbsolutePath(), { quietly: true });
        } else if (me.folderDone) {
          sol.common.FileUtils.rename(files[i].getAbsolutePath(), me.folderDone + files[i].name); //TODO: Anstatt pfade File-Objekte bauen
        }
      } catch (e) {
        logger.error(e);
        if (me.folderError) {
          try {
            sol.common.FileUtils.rename(files[i].getAbsolutePath(), me.folderError + files[i].name); //TODO: Anstatt pfade File-Objekte bauen
          } catch (ex) {
            //ignore
          }
        }
      }
    }
  },

  /**
   * Collects the Files to import.
   * Uses 'extFilter' to filter the files
   * 
   * @returns {File[]} A List of files to import
   */
  getFilesToImport: function () {
    var me = this;
    
    if (me.extFiler) {
      return new File(me.folderImport).listFiles(
        new Packages.java.io.FileFilter(
          new SuffixFileFilter(me.extFiler)
        )
      );
    }
    return new File(me.folderImport).listFiles();        
  },

  /**
   * Imports a file into ELO
   * 
   * @param {File} file The File to import
   * @returns {String} the Object-ID of the saved file
   */
  importFile: function (file) {
    var me = this;
    return sol.common.RepoUtils.saveToRepo({
      name: file.name,
      parentId: me.parentId,
      maskId: me.mask,
      file: file
    });
  }
});

importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js

/**
 * Inserts Text into a Bookmark of a word-document
 * 
 * Requieres
 *  -   ooxml-schemas-1.3.jar
 * RF_sol_common_service_ExecuteAsAction
 * 
 *
 * @author TE, Holme Consulting & Solutions
 * @version 1.00
 *  
 * @eloas
 * @requires sol.common.as.ActionBase
 * @requires holme.common.as.FileUtils
 * @requires holme.common.as.Word
 */
sol.define("holme.common.as.actions.WordInsertTextIntoBookmark", {
  extend: "sol.common.as.ActionBase",

  requieredProperty: ["objectId, bookmarkName, bookmarkValue"],

  initialize: function (config) {
    var me = this;
    log.info("Start init");
    me.$super("sol.common.as.ActionBase", "initialize", [config]);        
    log.info("Finnished init");
  },

  getName: function () {
    return "WordInsertTextIntoBookmark";
  },

  process: function () {
    var me = this,
        inputStream, workbook, sord, hasToUnlock = false, newWordFile,
        wordUtils, holmeUtils;

    try {    
      holmeUtils = sol.create("holme.common.HolmeUtils", {});
      wordUtils = sol.create("holme.common.as.Word", {});
      sord = ixConnect.ix().checkoutSord(me.objectId, SordC.mbAll, LockC.YES);
      hasToUnlock = true;
      inputStream = ixConnect.download(sord.docVersion.url, 0, sord.docVersion.size);            
      workbook = wordUtils.loadDocument(inputStream);
      wordUtils.insertTextAtBookmark(workbook, me.bookmarkName, me.bookmarkValue);
      newWordFile = wordUtils.saveAsInputStream(workbook);
      holmeUtils.archiveNewVersion(sord, newWordFile);
    } catch (e) {
      log.error(e);
    } finally {
      if (sord) {
        if (hasToUnlock) {
          try {
            ixConnect.ix().checkinSord(sord, SordC.mbOnlyUnlock, LockC.YES);
          } catch (ex) {
            // ignore
          }
        }   
      }
      if (inputStream) {
        try {
          inputStream.close();
        } catch (ex) { 
          //ignore
        }
      }
      if (workbook) {
        try {
          workbook.close();
        } catch (ex) {
          //ignore
        }
      }
      if (newWordFile) {
        try {
          newWordFile.close();                    
        } catch (ex) {
          //ignore
        }
      }
    }
  }
});
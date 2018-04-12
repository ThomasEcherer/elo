
importPackage(Packages.de.elo.ix.client);
importPackage(Packages.org.apache.poi.hssf.usermodel);
importPackage(Packages.org.apache.poi.ss.usermodel);
importPackage(Packages.org.apache.poi.xssf.usermodel);

//@include lib_Class.js
//@include sol.common.RepoUtils


/**
 * Checksout a ELO-Excel-File, write an Value into the Footer and saves it as new Version
 * 
 * # Überschrift1
 * 
 * ## Überschrift2
 *  
 *   Config Example:
 *  {
 *      "solution": "holme.common",
 *      "action": "holme.common.as.actions.ExcelSetFooter",
 *      "config": {
 *          "objectId": "2014",
 *          "text": "foooooter"
 *      },
 *      "connParams": {
 *          "language": "de"
 *      }
 *  }
 *
 * @author TE, Holme Consulting & Solutions
 * @version 1.00
 *  
 * @eloas
 * @requires sol.common.as.ActionBase
 * @requires holme.common.as.FileUtils
 * @requires holme.common.as.Excel
 * @requires sol.common.RepoUtils
 */
sol.define("holme.common.as.actions.ExcelSetFooter", {
  extend: "sol.common.as.ActionBase",

  requieredProperty: ["objectId, text"],

  /**
   * @cfg {String|int} The ObjectId of the Excel-File to set to Footer
   */
  objectId: undefined,

  /**
   * @cfg {String} The text to write into the footer
   */
  text: undefined,

  initialize: function (config) {
    var me = this;
    log.info("Start init");
    me.$super("sol.common.as.ActionBase", "initialize", [config]);
    if (!me.objectId && !me.text) {
      throw "IllegalArgumentException: either 'objectId' or 'text' is not defined";
    }        
    log.info("Finnished init");
  },

  getName: function () {
    return "ExcelSetFooter";
  },

  process: function () {
    var me = this,
        inputStream, sord, hasToUnlock = false, newExcelFile,
        excel;

    try {          
      excel = sol.create("holme.common.as.Excel", {});
      sord = ixConnect.ix().checkoutSord(me.objectId, SordC.mbAll, LockC.YES);
      hasToUnlock = true;
      inputStream = ixConnect.download(sord.docVersion.url, 0, sord.docVersion.size);            
      excel.loadExcelFile(inputStream);
      excel.setFooter(1, me.text);
      newExcelFile = excel.saveAsOutputStream();
      sol.common.RepoUtils.saveToRepo(
        {                    
          objId: sord.id,
          outputStream: newExcelFile,
          extension: sord.docVersion.ext
        }
      );
      
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
      if (newExcelFile) {
        try {
          newExcelFile.close();                    
        } catch (ex) {
          //ignore
        }
      }
      if (excel) {
        try {
          excel.close();
        } catch (ex) { 
          //ignore
        }
      }

    }
  }
});
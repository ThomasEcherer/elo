
//@include lib_Class.js

/**
 * Common Utilities for ELO
 *
 * @author TE, HOLME Consulting & Solutions GmbH
 * @version 1.00.000
 *
 * @elojc
 * @eloas
 * @eloix
 */
sol.define("holme.common.RepoUtils", {
  singleton: true,

  /**
   * Downloads the ELO-Document as InputStream
   * 
   * @param {String} objId - The ObjId of the Document to download
   * @returns {InputStream}  The Document as InputStream
   */
  getInputStreamFromSord: function (objId) {
    var sord = ixConnect.ix().checkoutSord(objId, SordC.mbAll, LockC.NO);
    return ixConnect.download(sord.docVersion.url, 0, sord.docVersion.size);
  },

  /**
   * Converts a Output-Stream to a InputStream (ByeArrayInputStream)
   * 
   * @param {ByteArrayOutputStream} outputStream The Outputstream to convert
   * @returns {InputStream} The converted Outputstream as ByteArrayInputStream
   */
  outputStreamToInputStream: function (outputStream) {
    return new ByteArrayInputStream(outputStream.toByteArray());
  },

  /**
   * Copies the ACL from one object to another
   * 
   * @param {Object} config The Configuration what todo
   * @param {String} config.targetId The ObjectId of the object to paste the acl to
   * @param {String} config.soruceId The ObjectId of the object to copy the acl from
   * @param {boolean} config.asAdmin (optional) Default = false. If Set to true the Admin-Connnection will be used
   */
  copyAcl: function (config) {
    var target, source, removeLock = true, con;
    con = config.asAdmin ? ixConnectAdmin : ixConnect;
    try {
      target = con.ix().checkoutSord(config.targetId, SordC.mbLean, LockC.YES);
      source = con.ix().checkoutSord(config.sourceId, SordC.mbLean, LockC.NO);
      target.aclItems = source.aclItems;
      con.ix().checkinSord(target, SordC.mbLean, LockC.YES);
    } finally {
      if (removeLock) {
        try {
          if (target) {
            con.ix().checkinSord(target, SordC.mbOnlyUnlock, LockC.YES);
          }
        } catch (ex) {
          //ignore
        }
      }
    }    
  },

  /**
   * Initiate a simple keywording search for one key-attribute.
   * 
   * @param {Object} cfg The Search Configuration
   * @param {String} cfg.mask The name or ID of the mask to search for
   * @param {Object[]} cfg.keys The Search-Paramters
   * @param {String} cfg.keys.name The Name of the objkey to search for
   * @param {String} cfg.keys.value the Value to search for
   * 
   * @returns {int} The ObjectId of the found Object. Returs '-1' if nothing found
   * 
   */
  findFirst: function (cfg) {
    var fi, fr, line, i, max;

    if (!cfg) {
      throw "No Configuration given!";
    }

    if (!cfg.mask && !cfg.keys) {
      throw "Neither mask nor keys are given !";
    }

    fi = new FindInfo();
    fi.findByIndex = new FindByIndex();

    if (cfg.mask) {
      fi.findByIndex.maskNo = cfg.mask;
    }

    if (cfg.keys) {
      fi.findByIndex.objKeys = [];
      max = cfg.keys.length;
      for (i = 0; i < max; i++) {
        line = sol.common.SordUtils.getDocMaskLine(cfg.mask, cfg.keys[i].name);
        fi.findByINdex.objKeys.push(new ObjKey([cfg.keys[i].value], line.id, line.key, 0));
      }
    }
    fi.findOptions = new FindOptions();

    try {
      fr = ixConnect.ix().findFirstSords(fi, 2, SordC.mbMin);
      if (fr.sords.length > 0) {
        return fr.sords[0].id;
      }
      return -1;
    } finally {
      if (fr) {
        try {
          ixConnect.ix().findClose(fr.searchId);
        } catch (e) { 
          /* ignored */ 
        }
      }
    }
  },

  /**
   * Seaches for the latest change made in one index field.
   * 
   * @param {String} objId The ELO-Object to search its history
   * @param {String} objKeyName The name of the searched index field
   * @returns {String} The Date as ISO-Date-String of the latest change made in the indexfield. Returns undefined if nothing found
   */
  getLatestObjKeyChangeDate: function (objId, objKeyName) {
    var hist, sordHist, histKeys, key, i, max, j, maxj, dates = [],
        latestDate;

    //  get Sord-History
    hist = ixConnect.ix().checkoutSordHistory(objId);
    
    //  collect all changes with objkey
    SORDHIST: for (i = 0; i < max; i++) {
      max = hist.length;
      sordHist = hist[i];
      histKeys = sordHist.histKeys;
      maxj = histKeys.length;
      for (j = 0; j < maxj; j++) {
        key = histKeys[i];
        if (key.keyName == objKeyName) {
          dates.push(ixConnect.isoToDate(sordHist.timeStampUTC.replaceAll("\\.", "")));
          continue SORDHIST;
        }
      }
    } 

    //  find the latest date
    max = dates.length;
    for (i = 0; i < max; i++) {
      if (!latestDate || dates[i].after(latestDate)) {
        latestDate = dates[i];
      }
    }

    if (latestDate) {
      return ixConnect.dateToIso(latestDate);
    }
    return;    
  }

});
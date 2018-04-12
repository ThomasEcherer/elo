
importPackage(Packages.de.elo.ix.client);
importPackage(Packages.org.apache.poi.hsmf);

//@include lib_Class.js

/**
 * Utilities for Email (.msg).
 *
 * @author TE, Holme & Co, Consulting & Solutions
 * @version 1.01.002
 *
 * @requires POI Library 
 */
sol.define("holme.common.as.MsgUtils", {
  singleton: true,

  /**
   * Gets the date that the message was accepted by the server on.
   * 
   * @param {File|InputStream} file - The email to read from
   * @returns {String} Email-Date as ISO-Date
   */
  getEmailDate: function (file) {
    var mapiMessage, cal, isoDate;
    mapiMessage = new Packages.org.apache.poi.hsmf.MAPIMessage(file);
    cal = mapiMessage.getMessageDate();
    isoDate = cal.get(java.util.Calendar.YEAR)
            + ("0" + (cal.get(java.util.Calendar.MONTH) + 1)).slice(-2)
            + ("0" + cal.get(java.util.Calendar.DAY_OF_MONTH)).slice(-2)
            + ("0" + cal.get(java.util.Calendar.HOUR_OF_DAY)).slice(-2)
            + ("0" + cal.get(java.util.Calendar.MINUTE)).slice(-2)
            + ("0" + cal.get(java.util.Calendar.SECOND)).slice(-2);  
    return isoDate;
  }
});
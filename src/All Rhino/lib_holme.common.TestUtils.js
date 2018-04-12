
importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js

/**
 * Test Utilities for ELO
 *
 * @author TE, HOLME Consulting & Solutions GmbH
 * @version 1.00
 *
 * @elojc
 * @eloas
 * @eloix
 */
sol.define("holme.common.TestUtils", {
  singleton: true,

  /**
   * Creates a DummyFile
   *    
   * @returns {File} Returns a dummy-file
   */
  createDummyFile: function () {
    var file, writer, date;
    try {
      date = new Date();
      file = File.createTempFile("TEMP", "TEST", new File(sol.common.FileUtils.getTempDirPath()));
      writer = new BufferedWriter(new OutputStreamWriter(new FileOutputStream(file), "utf-8"));
      writer.write(date.getTime());
      writer.flush();
      writer.close();
      return file;
    } finally {
      try {
        if (writer) {
          writer.close();
        } 
      } catch (e) {
        //ignore            
      }
    }    
  }

});
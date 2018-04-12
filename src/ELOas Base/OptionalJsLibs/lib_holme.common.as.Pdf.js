
importPackage(Packages.de.elo.ix.client);
importPackage(Packages.org.apache.pdfbox.pdmodel);
importPackage(Packages.org.apache.pdfbox.util);
importPackage(Packages.org.apache.pdfbox.text);

//@include lib_Class.js

/**
 * Utilities for PdfFiles
 *
 * @author TE, Holme & Co, Consulting & Solutions
 * @version 1.00
 * 
 * @requires pdfbox 2.0.0 or abaove
 * 
 * @eloas
 * @elojc
 */
sol.define("holme.common.as.Pdf", {
  // singleton: true,

  /**
   * @property {PDDocument} document The PDF-Document that laods at the beginning
   */

  
  /**
   * Loads the PDF-Document as a PDDocument object.
   * If this mehtod is Called you have to call "closeDocument" at last as well
   * 
   * @param {InputStream} document The PDF-Document to read
   */
  loadDocument: function (document) {
    var me = this;
    me.document = Packages.org.apache.pdfbox.pdmodel.PDDocument.load(document);
  },

  /**
   * Creates a new Pdf-Document with the given Pages-range
   *      
   * @param {int} from Number of Page to split from (0-based)
   * @param {int} to Number of Page to split to (0-based)
   * @returns {OutputStream} The splitted PDF-File as Outputstream
   */
  splitDocument: function (from, to) {
    var me = this,
        doc, baos, i;        

    //  Split the Document
    doc = new Packages.org.apache.pdfbox.pdmodel.PDDocument();
    for (i = from; i <= to; i++) {
      doc.addPage(me.document.getPage(i));
    }
    baos = new ByteArrayOutputStream();
    doc.save(baos);
    doc.close();
    return baos;
  },

  /**
   * Reads the a whole page from a PDF-Document. 
   * Only reads the embedded text. (that does not include OCR)
   *      
   * @param {int} startPage The first Page to read from. (0-based)
   * @param {int} endPage The Last Page-Number to read from. (0-based)
   * @returns {String} The read text from the given Pages.
   */
  readPages: function (startPage, endPage) {
    var me = this,
        stripper;
    
    stripper = new Packages.org.apache.pdfbox.text.PDFTextStripper();
    stripper.setStartPage(startPage);
    stripper.setEndPage(endPage);
    return stripper.getText(me.document).trim();
  },

  /**
   * Closes the PDF-Document safly.
   */
  closeDocument: function () {
    var me = this;
    me.document.close();
  },

  /**
   * This will return the total page count of the PDF document
   * 
   * @returns {int} The total number of pages in the PDF document
   */
  getNumberOfPages: function () {
    var me = this;
    return me.document.getNumberOfPages();
  },

  /**
   * Returns the PDF specification version this document conforms to.
   * 
   * @returns {float} the PDF version (e.g. 1.4f)
   */
  getVersion: function () {
    var me = this;        
    return me.document.getVersion();
  }

});
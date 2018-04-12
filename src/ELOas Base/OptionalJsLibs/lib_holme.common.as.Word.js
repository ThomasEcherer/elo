
importPackage(Packages.org.docx4j);
importPackage(Packages.java.util.regex);
importPackage(Packages.java.io);
importPackage(Packages.org.apache.poi.xwpf.usermodel);

//@include lib_Class.js

/**
 * Provides easy Access to Word-Files.
 * 
 * After creating the Object with 
 * ```
 * sol.create("holme.common.as.Word", {}) ;
 * ```
 * 
 * You have to load the Document.
 * After that you can process your editing.
 * Maybe save your new Version afterwars
 * and call 'closeDocument' in the end.
 *
 * @author TE, HOLME Consulting & Solutions GmbH
 * @version 1.0
 */
sol.define("holme.common.as.Word", {
  
  /**
   * @property {XWPFDocument} document The Word-Document to edit
   */
  document: undefined,

  /**
   * Loads the Word-Document
   * 
   * @param {InputStream} inputStream The Word-Dokument to read
   */
  loadDocument: function (inputStream) {
    var me = this;
    me.document = new Packages.org.apache.poi.xwpf.usermodel.XWPFDocument(inputStream);    
  },

  /**
   * Read the Word-Document as Text (using Docx4J-Library, which is 
   * not included into the AS by default)
   * 
   * @static
   * @param {java.io.InputStream} inputStream - The Word-Document to read
   * @returns {String} The Word-Document as Text
   * @throws {Docx4JException} 
   */
  readDoc: function (inputStream) {
    var me = this,
        doc, main, jaxbElement, writer;
    try {            
      doc = Packages.org.docx4j.Docx4J.load(inputStream); //org.docx4j.Docx4J
        
      main = doc.getMainDocumentPart();
      jaxbElement = main.getJaxbElement();

      if (me.debug) {
        log.info("[readDoc] creating string writer");
      }
      writer = new Packages.java.io.StringWriter(); //java.io.StringWriter
      Packages.org.docx4j.TextUtils.extractText(jaxbElement, writer); //org.docx4j.TextUtils

      if (me.debug) {
        log.info("[readDoc] flush buffer");
      }
      return writer.getBuffer().toString();
    } catch (e) {
      log.error(e);
      throw e;
    } finally {
      if (inputStream) {
        try {
          inputStream.close();
        } catch (ex) { 
          //ignore 
        }
      }
    }
  },

  /**
   * Inserts Text into a bookmark
   * 
   * @param {String} bookmarkName The Bookmark-Name to write to
   * @param {String} bookmarkValue The Text to insert into the bookmark
   */
  insertTextAtBookmark: function (bookmarkName, bookmarkValue) {
    var me = this,
        tableList, tableIter, rowList, rowIter, cellList, cellIter,
        table, row, cell; 

    function procParaList(paraList, bmkName, bmValue) {
      var paraIter, para, bookmarkList, bookmarkIter, bookmark, run, nextNode; 
          
      paraIter = paraList.iterator(); 
      while (paraIter.hasNext()) { 
        para = paraIter.next(); 
        bookmarkList = para.getCTP().getBookmarkStartList(); 
        bookmarkIter = bookmarkList.iterator();                 
        while (bookmarkIter.hasNext()) { 
          bookmark = bookmarkIter.next(); 
          if (bookmark.getName().equals(bookmarkName)) { 
            run = para.createRun(); 
            run.setText(bookmarkValue); 
            nextNode = bookmark.getDomNode().getNextSibling(); 
            if (nextNode == null) {
              continue;
            }                        
            while (!(nextNode.getNodeName().contains("bookmarkEnd"))) { 
              para.getCTP().getDomNode().removeChild(nextNode); 
              nextNode = bookmark.getDomNode().getNextSibling(); 
            } 
            para.getCTP().getDomNode().insertBefore( 
              run.getCTR().getDomNode(), 
              nextNode);                         
          } 
        } 
      } 
    }
            
    procParaList(me.document.getParagraphs(), bookmarkName, bookmarkValue); 
    
    tableList = me.document.getTables(); 
    tableIter = tableList.iterator(); 
    while (tableIter.hasNext()) { 
      table = tableIter.next(); 
      rowList = table.getRows(); 
      rowIter = rowList.iterator(); 
      while (rowIter.hasNext()) { 
        row = rowIter.next(); 
        cellList = row.getTableCells(); 
        cellIter = cellList.iterator(); 
        while (cellIter.hasNext()) { 
          cell = cellIter.next(); 
          procParaList(cell.getParagraphs(), 
            bookmarkName, 
            bookmarkValue); 
        } 
      } 
    }         
  },

  /**
   * Saves the given Word-Document as InputStream
   *
   * @returns {InputStream} The saved Word-Document
   */
  saveAsInputStream: function () {
    var me = this;
    return new ByteArrayInputStream(me.saveAsOutputStream().toByteArray());
  },

  /**
   * Saves the given Word-Document as OutputStream
   * 
   * @returns {OutputStream} The saved Word-Document
   */
  saveAsOutputStream: function () {
    var me = this,
        out;
    out = new ByteArrayOutputStream();
    me.document.write(out);
    return out;
  },

  /**
   * Close the document. Should always be called when editing
   * the document, and saving it, is finished.
   */
  closeDocument: function () {
    var me = this;
    me.document.close();
  } 
    
});

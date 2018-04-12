
importPackage(Packages.de.elo.ix.client);
importPackage(Packages.org.apache.poi.hssf.usermodel);
importPackage(Packages.org.apache.poi.ss.usermodel);
importPackage(Packages.org.apache.poi.xssf.usermodel);

//@include lib_Class.js
//@include lib_sol.common.as.FunctionBase.js
//@include lib_sol.common.RepoUtils.js
//@include lib_sol.common.RepoUtils.js
//@include lib_sol.common.IxUtils.js
//@include lib_sol.common.as.Excel.js
//@include lib_sol.common.Template.js
//@include lib_sol.common.ExceptionUtils.js



var logger = sol.create("sol.Logger", { scope: "holme.common.as.Excel" });

/**
 * # Short Description
 * 
 * Utilities for ExcelFiles (xlsx only).
 * 
 * # Must known
 * 
 * "loadDocument" or "prepareNewDocument" has to be called at first.
 * and "closeDocument" has to be called at last.
 * 
 * # Example
 *  try {
 *      var excel = sol.create("holme.common.as.Excel", {});
 *      excel.loadDocument(inputStream);
 *      // do fancy excel stuff
 *  } finally {
 *      if (excel) {
 *          try {
 *              excel.closeDocument();
 *          } catch(e) {}
 *      }
 *  }
 * 
 * # Requirments
 * - AS 10.02
 *
 * @author TE, Holme Consulting & Solutions
 * @version 1.01.001
 * 
 * @eloas
 */
sol.define("holme.common.as.Excel", {

  /**
   * @property {XSSFWorkbook} workbook The loaded Excel-File
   */
  workbook: undefined,


  /**
   * Creates a new Excel-File (without saving it)
   */
  prepareNewDocument: function () {
    var me = this;
    me.workbook = new Packages.org.apache.poi.xssf.usermodel.XSSFWorkbook();
  },

  /**
   * Adds a new sheet to the excel file
   * 
   * @param {String} name Name of the Sheet
   */
  addSheet: function (name) {
    var me = this;
    me.workbook.createSheet(name);
  },

  /**
   * Loads an Excel-File.
   * The Inputstream for Excelfile will be closed after loading.
   * 
   * The method "close" have to be called when the work is done
   * 
   * @param {inputStream} inputStream The Excel-File to load. Will be closed afterwards
   */
  loadDocument: function (inputStream) {       
    var me = this;
    me.workbook = new Packages.org.apache.poi.xssf.usermodel.XSSFWorkbook(inputStream);                        
    inputStream.close();
  },

  /**
   * Writes an Footer.
   * The method 'loadDocument' has to be called before.
   *      
   * @param {int} sheetNr The Number of Sheet to set the footer
   * @param {String} text The Text that should be written into the footer
   * @param {Object} cfg (optional) Configuration for Footer-Settings (font, fontsize, fontstyle)
   */
  setFooter: function (sheetNr, text, cfg) {
    var me = this,
        footer;
    footer = me.workbook.getSheetAt(sheetNr).getFooter();

    if (!cfg) {
      cfg = {};
      cfg.font = "Arial";
      cfg.fontStyle = "regular";
      cfg.fontSize = 8;
    }

    footer.setLeft(Packages.org.apache.poi.hssf.usermodel.HSSFFooter.font(cfg.font, cfg.fontStyle) 
        + Packages.org.apache.poi.hssf.usermodel.HSSFFooter.fontSize(cfg.fontSize) 
        + " " + text);        
  },

  /**
   * Read the Content of a footer
   * 
   * @param {int} sheetNr The number of the Sheet to read from
   * @param {String} whichFooter Which footer to read. Possible Options are ("LEFT", "CENTER", RIGHT")
   * @returns {String} The Content of the footer
   */
  getFooter: function (sheetNr, whichFooter) {
    var me = this;

    if (whichFooter == "LEFT") {
      return me.workbook.getSheetAt(sheetNr).getFooter().getLeft();
    } 

    if (whichFooter == "CENTER") {
      return me.workbook.getSheetAt(sheetNr).getFooter().getCenter();
    } 

    if (whichFooter == "RIGHT") {
      return me.workbook.getSheetAt(sheetNr).getFooter().getRight();
    } 

    throw ("The Parameter 'whichFooter' (" + whichFooter + ") is wrong! Choose on of 'LEFT', 'CENTER', 'RIGHT'");
  },

  /**
   * Reads all Footers of a sheet.
   * Returns an JavaScript Objects with 3 Parameters:
   *  -   left
   *  -   center
   *  -   right
   * 
   * @param {int} sheetNr The number of the sheet to read the footer from
   * @return {Object} All Footers. Field 'left', 'center' and 'right'
   */
  getFooters: function (sheetNr) {
    var me = this,
        footer, ret = {};

    footer = me.workbook.getSheetAt(sheetNr);
    ret.left = footer.getLeft();
    ret.center = footer.getCenter();
    ret.right = footer.getRight();
    return ret;
  },

  /**
   * @private
   * Reads the Value of a Cell type-wise.
   * Means that its differs between
   *  -   String
   *  -   Numeric
   *  -   Boolean
   *  -   Formula
   *  -   Blank
   * @param {Cell} cell The Cell to read from
   * @returns {Object} Returns the value of the cell in its given type (String, Numeric, ...)     
   */
  getValueOfCell: function (cell) {
    if (!cell) {
      logger.warn("Cell is empty");
      return "";
    }
    var type = cell.getCellType();
    if (type == Packages.org.apache.poi.ss.usermodel.CellType.STRING) {
      return cell.getStringCellValue();
    }

    if (type == Packages.org.apache.poi.ss.usermodel.CellType.NUMERIC) {
      return cell.getNumericCellValue();
    }

    if (type == Packages.org.apache.poi.ss.usermodel.CellType.BOOLEAN) {
      return cell.getBooleanCellValue();
    }

    if (type == Packages.org.apache.poi.ss.usermodel.CellType.ERROR) {
      return cell.getErrorCellString();
    }

    if (type == Packages.org.apache.poi.ss.usermodel.CellType.FORMULA) {
      return cell.getCellFormula();
    }

    return cell.toString();
  },

  /**
   * @private
   * Returns the raw, underlying ooxml value for the cell
   * If the cell contains a string, then this value is an index into the shared string table, 
   * pointing to the actual string value. Otherwise, the value of the cell is expressed directly 
   * in this element. Cells containing formulas express the last calculated result of the 
   * formula in this element.
   * 
   * @param {Cell} cell The Cell to read from
   * @returns {String} Returns the raw cell value as contained in the underlying CTCell bean, null for blank cells.
   */
  getRawValueOfCell: function (cell) {
    return cell.getRawValue();
  },

  /**
   * Reads the value of a specific cell.
   * 
   * @param {int} sheetNr - The number of the Sheet to read from 
   * @param {int} row - The row to read from
   * @param {int} column - The column to read from
   * @returns {Object} The Value of the cell. (In its configured type. String, Numeric , ...)
   */
  getValueAt: function (sheetNr, row, column) {
    var me = this,
        cell;        
    cell = me.workbook.getSheetAt(sheetNr).getRow(row).getCell(column);        
    return me.getValueOfCell(cell);
  },

  /**
   * Returns the raw, underlying ooxml value for the cell
   * If the cell contains a string, then this value is an index into the shared string table, 
   * pointing to the actual string value. Otherwise, the value of the cell is expressed directly 
   * in this element. Cells containing formulas express the last calculated result of the 
   * formula in this element.
   * 
   * @param {int} sheetNr - The number of the Sheet to read from 
   * @param {int} row - The row to read from
   * @param {int} column - The column to read from
   * @returns {Object} The Value of the cell. (In its configured type. String, Numeric , ...)
   */
  getRawValueAt: function (sheetNr, row, column) {
    var me = this,
        cell;        
    cell = me.workbook.getSheetAt(sheetNr).getRow(row).getCell(column);        
    return me.getRawValueOfCell(cell);
  },

  /**
   * Saves the Excel-File as "new" InputStream
   * 
   * @returns {ByteArrayInputStream} ByteArrayInputStream of the saved Excel-File
   */
  saveAsInputStream: function () {
    var me = this,
        baos;
    baos = new ByteArrayOutputStream();
    me.workbook.write(baos);
    baos.close();
    return new ByteArrayInputStream(baos.toByteArray());
  },

  /**
   * Saves the Exel-File as ByteArrayOutputStream
   * 
   * @returns {ByteArrayOutputStream} The saved Excel-Files
   */
  saveAsOutputStream: function () {
    var me = this,
        baos;
    baos = new ByteArrayOutputStream();
    me.workbook.write(baos);
    baos.close();        
    return baos;
  },

  /**
   * Saves the Excel-File into the given outputStream
   *
   * @param {OutputStream} outputStream The outputstream to write the excel-File to
   */
  saveAs: function (outputStream) {
    var me = this;
    me.workbook.write(outputStream);
    outputStream.close();
  },

  /**
   * Saves the Excel-File into a File
   * 
   * @param {String|File} newFile The new Excel-File to write to
   */
  saveAsNewFile: function (newFile) {        
    var me = this,
        out;
    out = new FileOutputStream(newFile);
    me.workbook.write(out);
    out.close();        
  },

  /**
   * Writes an Cell
   * 
   * @param {int} sheetNr On which sheet to write
   * @param {int} rowNr On which row to write
   * @param {int} column On with column to write
   * @param {String} value The Value to write into the cell
   */
  setValueAt: function (sheetNr, rowNr, column, value) {
    var me = this;
    me.workbook.getSheetAt(sheetNr).getRow(rowNr).getCell(column).setCellValue(value);
  },
  
  /**
   * Adds a new Row into the excel File
   * 
   * @param {Object} cfg The Configuration to set    
   * @param {int} cfg.sheetNr The Sheet-nr to add the row. This is redundant to sheetName
   * @param {String} cfg.sheetName The Sheet-name to add the row. this is redundant to sheetnr
   * @param {String[]} cfg.values List of values to write into the row
   */
  addRow: function (cfg) {
    var me = this,
        row, cell, i, max, sheet;

    if (cfg.sheetNr) {
      sheet = me.workbook.getSheetAt(cfg.sheetNr);
    } else if (cfg.sheetName) {
      sheet = me.workbook.getSheet(cfg.sheetName);
    } else {
      throw "Either 'sheetNr' or 'sheetName' has to be set!";
    }

    if (!sheet) {
      logger.warn(["Sheet not found (nr={0}) (name={1})", cfg.sheetNr, cfg.sheetName]);
      throw "Sheet not found";
    }

    row = sheet.createRow(sheet.getLastRowNum() + 1);
    max = cfg.values.length;
    for (i = 0; i < max; i++) {
      cell = row.createCell(i);
      cell.setCellValue(cfg.values[i]);
    }    
  },

  /**
   * not tested yet
   * @param {Object} config Configuration
   * @param {int} sheetNr Sheet-NR to read from
   * @param {Object[]} filters List of Filters to 
   * @param {Object} filters.filter Configuration of one filter
   * @param {Int} filters.filter.cell CellNumber this filter should after at
   * @param {String} filters.filter.value The value the cell should have
   * @param {String} filters.filter.comparison The kind of comparison the filter with the cell value (Valid values ar 'EQUAL' 'GREATER' 'LESS')
   * @param {Int[]} columnSelects the column to read
   * @param {boolean} onlyOneResult Determines if only the first result should be returned
   * @returns {Object[]} The Content of the cells
   */
  selectColumnsWhere: function (config) {
    var me = this,
        sheet, rowIterator, row, cellValue, cell, singleResult, result = [], i, max, j, maxj, sheetNr, filters, columnSelects;        

    sheetNr = config.sheetNr; 
    filters = config.filters; 
    columnSelects = config.columnSelects;
              
    logger.info(["...get Sheet #{0}...", sheetNr]);
    sheet = me.workbook.getSheetAt(sheetNr);
    rowIterator = sheet.rowIterator();
        
    //  Go through the whole Excel Sheet
    rows: while (rowIterator.hasNext()) {
      row = rowIterator.next();

      //  Check if the where-clauses hits
      // logger.info(["...check filters on row# {0}", row.getRowNum()]);
      max = filters.length;
      for (i = 0; i < max; i++) {
        cell = row.getCell(filters[i].cell);
        if (!cell) {
          // logger.warn(["Cell {0} is null. Skip it.", filters[i].cell]);
          continue rows;
        }
        cellValue = me.getValueOfCell(cell) + "";
        filters[i].value += "";

        if (filters[i].comparison == "EQUAL") {
          // logger.info(["DEBUG: equal compariosn {0}={1}", cellValue, filters[i].value]);
          if (cellValue == filters[i].value) {
            continue;
          } 
        }

        if (filters[i].comparison == "GREATER") {
          // logger.info(["DEBUG: greater compariosn {0}={1}", cellValue, filters[i].value]);
          if (cellValue >= filters[i].value) {
            continue;
          }
        }

        if (filters[i].comparison == "LESS") {
          // logger.info(["DEBUG: less compariosn {0}={1}", cellValue, filters[i].value]);
          if (cellValue < filters[i].value) {
            continue;
          }
        }

        // logger.info(["Filter hast not matched (comparison={0}) (filterValue={1}) (cellValue={2})", filters[i].comparison, filters[i].value, cellValue]);
        continue rows;
      }

      logger.info("...adding cells to result...");
      //  Add the Cells to the result
      maxj = columnSelects.length;
      singleResult = [];
      for (j = 0; j < maxj; j++) {    
        singleResult.push(me.getValueOfCell(row.getCell(columnSelects[j])));
        // logger.info(["Adding singleresult {0} to result", singleResult]);
      }
      result.push(singleResult);
      
      if (me.onlyOneResult) {
        break;
      }
    }                   
    return result;
  },

  /**
   * Closes the Excel-File. 
   * This Method has to be called after work with excel is done.
   * Best practice >> Put this in finally
   */
  closeDocument: function () {
    var me = this;
    me.workbook.close();
  }

});

/** 
 * 
 * # Short Description 
 * Reads an Excel-Value and writes it into map|sord|wfmap...
 *  
 * # Sample Configuration
 *  {
 *    objId: "4711",
 *    readConfig: {
 *      source: "3792",
 *		  sheetNr: "0",
 *		  filters: [
 *  		  { cell: 0, value: "204431.0", comparison: "EQUAL" } 
 *	    ],
 *	    columnSelects: [10]
 *	  },
 *	  setConfig: {
 *      type: "MAP",
 *      key: "TEST",
 *  	  defaultValue: "DEFAULT"
 *    }
 *  }
 *
 * @author TE, Holme Consulting & Solutions
 * @version 1.00.000
 * 
 * @eloas
 */
sol.define("holme.common.as.functions.SetFromCell", {

  extend: "sol.common.as.FunctionBase",  

  requiredConfig: ["objId", "setConfig", "readConfig"],

  /**
   * @cfg setConfig {Object} Configuration for Setting the read value
   * @cfg setConfig.entries {Object[]} [requiered] Entries that contains the values to set. (Value will be set with the read value from excel)
   * @cfg setConfig.defaultValue {String} Value to write if nothing found in Excel
   */
  setConfig: undefined,

  /**
   * @cfg readConfig {Object} Configuration what to read in the Excel-File
   * @cfg readConfig.source {String} ID or GUID of the Excel-File to read
   * @cfg readConfig.sheetNr {Int} The Sheet to read
   * @cfg readConfig.filters {Object[]} List of Filters 
   * @cfg readConfig.columnSelects {Int[]} The Columns to select/read
   * @see holme.common.as.Excel.selectColumnsWhere
   */
  readConfig: undefined,

  /**
   * @cfg {String|Int} objId the ObjectId of the ELO-Object to write
   */
  objId: undefined,

  initialize: function (config) {
    var me = this,
        tpl, cfg, sord, s, p;
        
    me.logger = sol.create("sol.Logger", { scope: "holme.common.as.functions.SetFromCell" });
    me.logger.info("Initialize ....");

    if (!config || !config.objId) {
      me.logger.error("No 'objId' given");
      throw "No 'objId' given";      
    } else {
      me.logger.info("Reading object", config.objId);
    }

    
    sord = sol.common.RepoUtils.getSord(config.objId + "", { sordZ: SordC.mbLean, lockZ: LockC.NO });    
    s = JSON.stringify(config);    
    tpl = sol.create("sol.common.Template", { source: s });    
    p = tpl.applySord(sord);    
    cfg = JSON.parse(p);          
    me.$super("sol.common.as.FunctionBase", "initialize", [cfg]);  

    // me.$super("sol.common.as.FunctionBase", "initialize", [config]);    
    
    me.logger.info("1");
    if (me.setConfig.entries.length != me.readConfig.columnSelects.length) {
      throw "The Number of setConfig.entries and readConfig.columnSelects have to be the same";
    }
   
  },


  process: function () {    
    var me = this,
        readValues, inputStream, excel, sord, ba;
    
    try {
      //  Prepare Excel-File
      me.logger.info("prepare Excel File");      
      sord = sol.common.RepoUtils.getSord(me.readConfig.source, { sordZ: SordC.mbAll });
      ba = sol.common.RepoUtils.downloadToByteArray(me.readConfig.source, sord.docVersion.id);
      inputStream = new ByteArrayInputStream(ba);
      
      //  Read from Excel File
      me.logger.info("Reading from excel...");
      excel = sol.create("holme.common.as.Excel", {});
      excel.loadDocument(inputStream);
      me.readConfig.onlyOneResult = true;
      readValues = excel.selectColumnsWhere(me.readConfig);

      //  Write the read Excel-Value into elo-object
      me.logger.info(["...write values #{0}", readValues.length]);  
      if (readValues && readValues.length > 0) {
        me.logger.info(["Write value {0}", readValues[0].join("¶")]);
        me.writeValue(readValues[0]);    
      } else {
        me.logger.info("No Values found. Write default values");        
        me.writeValue(new Array(me.setConfig.entries.length));
      }

      return { passOn: true };      
    } catch (e) {
      me.logger.error(e);
      throw e;
    } finally {
      if (excel) {
        try {
          excel.closeDocument();
        } catch (ex) {
          /* ignored */
        }
      }
    }    
    
  },

  /**
   * Prepares the setconfig.
   * Sets the Param 'objId' with me.objId 
   * and the Param 'value' with the read excel-Value and calls sol.common.ix.function.Set to write the vlues
   * 
   * @param {String[]} data the value to write
   */
  writeValue: function (data) {
    var me = this,
        i, max, value;

    max = data.length;
    for (i = 0; i < max; i++) {
      value = data[i];

      if (!value && !me.setConfig.defaultValue) {
        me.logger.info("No Value and no defaultvalue, no writing");
        return;
      }

      if (!value && me.setConfig.defaultValue) {
        value = me.setConfig.defaultValue;
      } 
      me.setConfig.entries[i].value = value + "";     
    }
    
    me.logger.info("...writing values ....");
    
    sol.common.IxUtils.execute("RF_sol_function_Set", {
      objId: me.objId,      
      entries: me.setConfig.entries      
    });
  }

});

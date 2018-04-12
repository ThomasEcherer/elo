
importPackage(Packages.de.elo.ix.jscript);
importPackage(Packages.de.elo.ix.scripting);

//@include lib_Class.js.js
//@include lib_sol.common.ix.DynKwlDatabaseIterator.js

/**
 * Dynamic keyword list that queries the recipients database.
 *
 * The list of current fields is returned as a table.
 *
 * |Name|Key|Example data|
 * |:-----|:------|:------|
 * |Company Code|COMPANY_NO|122|
 * |Name|COMPANY_NAME|ELO Digital Office GmbH|
 * |Street|COMPANY_ADDRESS_STREET|TuebingerStr. 34|
 * |Zip code|COMPANY_ADDRESS_ZIPCODE|70178|
 * |City|COMPANY_ADDRESS_CITY|Stuttgart|
 * |Country|COMPANY_ADDRESS_COUNTRY|DE|
 *
 * Limits results to COMPANY_NO.
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 */
sol.define("sol.invoice.ix.dynkwl.Company", {
  extend: "sol.common.ix.DynKwlDatabaseIterator",
  /**
   * @cfg
   * @inheritdoc
   */
  tableTitle: "Firma",
  /**
   * @cfg
   * @inheritdoc
   */
  sqlQuery: "select CODE, NAME, STREET, ZIPCODE, CITY, COUNTRY_CODE from sol_invoice_company where CODE like ? OR NAME like ?",
  /**
   * @cfg
   * @inheritdoc
   */
  sqlParams: [
    {mode: "STARTS_WITH"},
    {mode: "CONTAINS"}
  ],
  /**
   * @cfg
   * @inheritdoc
   */
  tableKeyNames: ["COMPANY_CODE", "COMPANY_NAME", null, null, null, null],
  //tableKeyNames: ["COMPANY_CODE", "COMPANY_NAME", "COMPANY_ADDRESS_STREET", "COMPANY_ADDRESS_ZIPCODE", "COMPANY_ADDRESS_CITY", "COMPANY_ADDRESS_COUNTRY"],
  /**
   * @cfg
   * @inheritdoc
   */
  tableHeaders: ["Nummer", "Name", "Straße", "PLZ", "Ort", "Land"]
});

/**
 * Implements a DynamicKeywordDataProvider for this keyword list that can be used by checkoutKeywordsDynamic.
 * @static
 * @member sol.invoice.ix.dynkwl.Company
 * @returns {DynamicKeywordDataProvider}
 */
function getDataIterator() {
  var log = sol.create("sol.Logger", {scope: "sol.invoice.ix.dynkwl.Company"}),
      iterator;
  try {
    log.info("DynamicKeywordList (");
    iterator = sol.create("sol.invoice.ix.dynkwl.Company", {});
    return new DynamicKeywordDataProvider(iterator);
  } finally {
    log.info(")getDataIterator");
  }
}
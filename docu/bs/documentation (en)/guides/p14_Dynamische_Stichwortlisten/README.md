<h1>Dynamic keyword lists</h1>
<p>Dynamic keyword lists represent a standard method for using data from external systems for indexing or entering data in ELO. This function is available for all clients and can be specified in the keywording form configuration (for index fields) or in forms (for map fields).</p>
<p><span
style='font-weight:bold'>We refer at this point to the documentation on dynamic keyword lists. A helper class that makes it easier to create keyword lists was developed for Business Solutions.</span></p>
<h2>Fundamentals</h2>
<p>A dynamic keyword list gets all the required filter criteria from the client and uses these to return relevant hits with the help of a database query. This returns a table with data as well as additional information such as the ELO field identifier, column name, table name, etc. </p>
<p><span
style='font-weight:bold'>Example:</span></p>
<table><thead><tr><td><span
style='font-weight:bold'>Number</span></td><td><span
style='font-weight:bold'>Name</span></td><td><span
style='font-weight:bold'>Street</span></td><td><span
style='font-weight:bold'>Country</span></td></tr></thead><tbody><tr><td><span
style='font-weight:bold'>VENDOR_NO</span></td><td><span
style='font-weight:bold'>VENDOR_NAME</span></td><td><span
style='font-weight:bold'>VENDOR_ADDRESS_STREET</span></td><td><span
style='font-weight:bold'>VENDOR_ADDRESS_COUNTRY</span></td></tr><tr><td>1001</td><td>Name</td><td>Street address 12</td><td>DE</td></tr><tr><td>1002</td><td>Supplier name</td><td>Supplier address</td><td></td></tr></tbody></table>

<p>ELO Java Client, ELO Web Client and ELOwf implement this concept and offer a selection of data in table form. When the user selects a column, all data following the ELO field identifiers is imported.</p>
<p>{@img img1.png}</p>
<h2>Definition of a keyword list</h2>
<p>Dynamic keyword lists {{DYNLST}} can be defined with the help of the <code>sol.common.ix.DynKwlDatabaseIterator</code> class. These provide all basic functions and can only be defined via configuration values. <span
style='font-weight:bold'>The guidelines for</span><a
href="#!/guide/p19_Indexserver_Scripting"> <span
style='font-weight:bold'>Indexserver scripting</span></a><span
style='font-weight:bold'> contains a detailed example.</p>
Framework
<p>The structure of the table needs to be defined as a fundamental requirement. This is composed of the name <code>tableTitle</code> (also displayed in the client), the column name <code>tableHeaders</code>, and the ELO field identifiers <code>tableKeyNames</code>. Field identifiers are evaluated by the clients to identify and complete corresponding metadata/map data.</p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> The following example defines a dynamic keyword list for entering to a table row in ELOwf:</span></p>
</blockquote>
<pre><code>sol.define('sol.invoice.ix.dynkwl.TradeCharge', {
    extend: 'sol.common.ix.DynKwlDatabaseIterator',

    tableTitle: 'Charges',
    sqlQuery: &quot;select code, description from sol_invoice_trade_charge where language = ? AND (code like ? OR description like ?) order by description&quot;,
    sqlParams: [
        { valueType: 'LANGUAGE' },
        { mode: 'STARTS_WITH' },
        { mode: 'CONTAINS' }
    ],
    tableKeyNames: [&quot;IX_MAP_INVOICE_TRADE_CHARGE_CODE{i}&quot;, &quot;IX_MAP_INVOICE_TRADE_CHARGE_DESC{i}&quot;],
    tableHeaders: [&quot;Code&quot;, &quot;Name&quot;]
});
</code></pre>
<p>Data can be entered to index fields by default by specifying the field name. If you want this to work for map fields as well, you need to add the prefix <code>IX_MAP</code>:</p>
<pre><code>    // Fill index fields by group field names
    tableKeyNames: [&quot;VENDOR_NAME&quot;, &quot;VENDOR_NO&quot;],

    // Fill map fields
    tableKeyNames: [&quot;IX_MAP_INVOICE_PURCHASER_NO&quot;, &quot;IX_MAP_INVOICE_PURCHASER_NAME&quot;],

    // Fill a map table row
    // {i} ELOwf substitutes with the current table index
    tableKeyNames: [&quot;IX_MAP_INVOICE_TRADE_CHARGE_CODE{i}&quot;, &quot;IX_MAP_INVOICE_TRADE_CHARGE_DESC{i}&quot;],
</code></pre>
<h3>Database query</h3>
<p>The database query can be defined as a prepared SQL statement with the help of the <code>sqlQuery</code> property and should contain the placeholder &quot;<code>?</code>&quot;. together. These placeholders are exchanged with the help of the <code>sqlParams</code> at runtime. The <code>sqlParams</code> array must contain the exact same number of elements as there are placeholders.</p>
<p>The following options are available: </p>
<ul>
<li><code>mode</code> - Describes the comparison mode, e.g. <code>STARTS_WITH</code> or <code>CONTAINS</code>.</li>
<li><code>name</code> - Describes the name of the group/map field transferred from the client. If no name has been set, the current user entry (filter value) is applied.</li>
<li><code>message</code> - Defines an error message if the field does not yet contain any data. This message is displayed in the client.</li>
</ul>
<p>It is also possible to access system properties using a <code>valueType</code> parameter, e.g. <code>LANGUAGE</code> returns the current user language.</p>
<p>Other <span
style='font-weight:bold'>examples:</span></p>
<pre><code>    sqlQuery: &quot;select CODE, NAME, STREET, ZIPCODE, CITY, COUNTRY_CODE from sol_invoice_company where CODE like ? OR NAME like ?&quot;,
    sqlParams: [
      {mode: 'STARTS_WITH'},
      {mode: 'CONTAINS'}
    ],

    sqlQuery: &quot;select NO, NAME from sol_invoice_costobject where COMPANY_CODE = ? AND (NO like ? or NAME like ?) order by NAME&quot;,
    sqlParams: [
      { name: 'COMPANY_CODE', message: 'Select a company' },
      { mode: 'STARTS_WITH' },
      { mode: 'CONTAINS' }
    ],
</code></pre>
<h2>Examples</h2>
<h3>Dynamic keyword lists in the keywording form definition</h3>
<p>It is possible to set dynamic keyword lists in the keywording form definition for every field that you want the list to be shown for. To do so, add the script name to the list in the repository. When a user starts to type data into a field, the current field value is passed as a<span
style='font-weight:bold'> filter value</span> to the keyword list.</p>
<p>{@img img3.png}</p>
<h3>Filling out index fields in an ELOwf form</h3>
<p>Index fields are filled out using the <span
style='font-weight:bold;font-style:italic'>Keyword</span> keyword list. In this case, ELOwf determines the underlying keyword list via the keywording definition for the specified group name.</p>
<p>{@img img5.png}</p>
<h3>Filling out a table row in an ELOwf form</h3>
<p>If you want to write data to a table row in an ELOwf form, the script name of the keyword list must have been entered. A list of the filters to be transferred must also have been entered, e.g. <code>IX_GRP_COMPANY_CODE,IX_GRP_VENDOR_NO</code>. If you want to import values from the current table row, this needs to be specified with an <code>{i}</code>: <code>IX_MAP_INVOICE_TRADE_CHARGE_CODE{i}</code></p>
<p>{@img img7.png}</p>
<h2>Others uses for dynamic keyword lists</h2>
<p>Dynamic keyword lists can also be used for providing elements from ELO. The <code>sol.common.ix.DynKwlSearchIterator</code> class provides a basic implementation. If child elements of a folder should be returned, you can use the <code>sol.common.ix.DynKwlFindChildrenIterator</code> class.</p>

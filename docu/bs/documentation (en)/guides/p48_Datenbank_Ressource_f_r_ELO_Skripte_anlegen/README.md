<h1>Creating database resources for ELO scripts</h1>
<p>The following steps explain how to create a database resource in <span
style='font-weight:bold;font-style:italic'>Apache Tomcat</span>. This is required if you need to access external databases from ELO scripting.</p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> Dynamic keyword lists enable you to access tables in the ELO repository database without having to make major modifications. However, if you need to access the </span><span
style='font-weight:bold;font-style:italic'>DocXtractor Matching DB</span><span
style='font-style:italic'>, you need to create a database resource that can be saved to the scripting (<code>sol.common.ix.DynKwlDatabaseIterator</code>) later on.</p>
</blockquote>
<h2>Saving a database resource to a context.xml file</h2>
<p><span class="tag_important">A description of the Tomcat <span
style='font-style:italic'>context.xml</span> options can be found in the <a
href="https://tomcat.apache.org/tomcat-8.0-doc/config/context.html#Resource_Definitions"><span
style='font-style:italic'>Resource Definitions</span></a> in the Tomcat documentation.</span></p>
<p>We recommend that you save the access data to the <span
style='font-weight:bold;font-style:italic'>context.xml</span> file so that you do not need to enter them in the scripting:</p>
<pre><code>&lt;?xml version='1.0' encoding='utf-8'?&gt;
&lt;!-- The contents of this file will be loaded for each web application --&gt;
&lt;Context&gt;

    &lt;!-- Add folowing line to file --&gt;
&lt;Resource name=&quot;jdbc/invoice.dx&quot; auth=&quot;Container&quot; type=&quot;javax.sql.DataSource&quot; 
    driverClassName=&quot;com.microsoft.sqlserver.jdbc.SQLServerDriver&quot; 
    url=&quot;jdbc:sqlserver://localhost:1433;databaseName=invoice&quot; 
    username=&quot;elodb&quot; password=&quot;elo&quot; 
    maxActive=&quot;20&quot; maxIdle=&quot;10&quot; maxWait=&quot;-1&quot;/&gt;

&lt;/Context&gt;
</code></pre>
<h2>Using the resource</h2>
<p>After you restart Tomcat, you can use resources in dynamic keyword lists, for example. The <code>jdbc</code> configuration of the <code>sol.common.ix.DynKwlDatabaseIterator</code> class is used for this.</p>
<p><span
style='font-weight:bold'>Example:</span></p>
<pre><code>sol.define('sol.invoice.ix.dynkwl.Company', {
  extend: 'sol.common.ix.DynKwlDatabaseIterator',

  // use INVOICE resource
  jdbc: 'jdbc/INVOICE',

  tableTitle: 'Firma',
  sqlQuery: &quot;select CODE, NAME, STREET, ZIPCODE, CITY, COUNTRY_CODE from sol_invoice_company where CODE like ? OR NAME like ?&quot;,
  sqlParams: [
    {mode: 'STARTS_WITH'},
    {mode: 'CONTAINS'}
  ],
  tableKeyNames: [&quot;COMPANY_CODE&quot;, &quot;COMPANY_NAME&quot;, null, null, null, null],
  tableHeaders: [&quot;Number&quot;, &quot;Name&quot;, &quot;Street&quot;, &quot;Zipcode&quot;, &quot;City&quot;, &quot;Country&quot;]
});
</code></pre>

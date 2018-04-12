<h1>Object formatter: Transform objects</h1>
<p>ELO Indexserver objects are a good way to transport data to different environments. However, the data is not always optimally structured according to what it is required for. </p>
<p>For example, this is the case when large volumes of data need to be loaded in cockpits with AngularJS or when templates need to directly access metadata. </p>
<p>The <code>sol.common.ObjectFormatter</code> class contains a detailed description as well as several examples.</p>
<p>This class is responsible for transforming Indexserver objects into other formats. There are essentially two object structures available for <span
style='font-weight:bold'>statistic evaluations</span> and for use in <span
style='font-weight:bold'>templates</span>. The class can be used to transform Sord and task objects, for example.</p>
<table><thead><tr><td><span
style='font-weight:bold'>Indexserver object</span></td><td><span
style='font-weight:bold'>For templates</span></td><td><span
style='font-weight:bold'>For statistical evaluations</span></td></tr></thead><tbody><tr><td>    de.elo.ix.client.Sord</td><td>    sol.common.ObjectFormatter.TemplateSord</td><td>    sol.common.ObjectFormatter.StatisticSord</td></tr><tr><td>    de.elo.ix.client.UserTask</td><td>    sol.common.ObjectFormatter.TemplateTask</td><td>    sol.common.ObjectFormatter.StatisticTask</td></tr></tbody></table>

<h2>Example of a transformation</h2>
<p>The following is an example of an excerpt of an Indexserver Sord object. Note the nested array structure of the <code>objKeys</code>, for example:</p>
<pre><code>ixSord  = {
  &quot;id&quot;: &quot;7572&quot;,
  &quot;maskName&quot;: &quot;Incoming invoice&quot;,
  &quot;name&quot;: &quot;Invoice 0000&quot;,
  &quot;IDateIso&quot;: &quot;20150720142400&quot;,
  &quot;XDateIso&quot;: &quot;&quot;,
  &quot;objKeys&quot;: [{
    name: &quot;VENDOR_NAME&quot;, data: [&quot;Weiler KG&quot;],
  }],
}
</code></pre>
<p>An object specifically adapted for use in templates ('Template Sord') looks like this:</p>
<pre><code>templateSord  = {
  &quot;id&quot;: &quot;7572&quot;,
  &quot;maskName&quot;: &quot;Incoming invoice&quot;,
  &quot;name&quot;: &quot;Invoice 0000&quot;,
  &quot;IDateIso&quot;: &quot;20150720142400&quot;,
  &quot;XDateIso&quot;: &quot;&quot;,
  &quot;objKeys&quot;: {
    &quot;VENDOR_NAME&quot;: &quot;Weiler KG&quot;,
    &quot;INVOICE_DATE&quot;: &quot;20150601162415&quot;,
    &quot;INVOICE_CASH_DISCOUNT_AMOUNT&quot;: 554
  }
}
</code></pre>
<p>The transformation gives you easy access to <code>objKeys</code>, for example in templates (Word, e-mail, file references, etc.):</p>
<pre><code>{{templateSord.objKeys.VENDOR_NAME}}
</code></pre>
<p>Performance and data volume</p>
<p>If large volume of data are retrieved from the Indexserver, the Sord formatter enables you to reduce the size of objects. In this case, only the required attributes and metadata are transferred, which considerably reduces data traffic.</p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> Up to 10,000 invoices can be displayed in the Invoice cockpit. This can amount to more than 60 MB of data. if only the data that is required is transferred to the cockpit, this reduces the amount of data to less than 4 to 5 MB.</span></p>
</blockquote>

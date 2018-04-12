<h1>Namespaces</h1>
<p>You must assign namespaces {{NAMSPC}} to solution scripts. A namespace should at least consist of the source, the corresponding module, and a group.</p>
<pre><code>{Source}.{Module name}.{Group}
E.g.: sol.invoice.ix
</code></pre>
<p>At ELO, source identifiers have a maximum of three characters. Partners are therefore instructed to use identifiers with more than four characters.</p>
<p><span
style='font-weight:bold'>Examples of ELO namespaces:</span></p>
<pre><code>sol.common
sol.invoice
elo.apps
api.ix
</code></pre>
<p><span
style='font-weight:bold'>Examples of user-defined namespaces:</span></p>
<pre><code>custom.invoice
elopartnername.invoice
elobp.common
</code></pre>
<h2>Creating namespaces</h2>
<p>Namespaces {{NAMSPC}}} are automatically created when defining a class, if required. If you want namespaces to be automatically created, you can use the <code>sol.NamespaceManager</code> class.</p>
<pre><code>sol.ns('elopartnername.invoice');

// in this case an object structure in JS is created as follows
var elopartnername = elopartnername || {};
elopartnername.invoice= elopartnername.invoice|| {};
</code></pre>

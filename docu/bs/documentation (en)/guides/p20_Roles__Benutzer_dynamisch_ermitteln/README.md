<h1>Dynamically assigning roles to users</h1>
<p>In different approval scenarios, users or groups must be determined using rules that are based on underlying information.</p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> In invoice processing, the <code>INVOICE_NET_AMOUNT</code> field denotes the net amount. In the approval process, it could be possible that the </span><span
style='font-weight:bold;font-style:italic'>Management</span><span
style='font-style:italic'> group needs to approve all invoices that exceed the net amount of &euro;10,000.</span></p>
</blockquote>
<p>The <code>sol.common.Rules</code> class can be used to store and evaluate rules like this based on metadata in a configuration. You can refer to the class documentation for detailed information on how to use this.</p>
<p>A configuration can contain multiple roles and assign a number of users/groups to each role that apply if the conditions are met.</p>
<h2>Definition of groups and rules</h2>
<h3>Configuration via an interface</h3>
<p>There is an ELO app for configuring the roles that makes it easier to add users and conditions.</p>
<p>In the following interface, the <code>sol.management</code> group is used for the <code>APPROVAL</code> role if the condition <code>INVOICE_NET_AMOUNT</code> &gt; 3000 is met.</p>
<p>{@img img1.png}</p>
<h3>Internal configuration</h3>
<pre><code>var myRoleConfig = {
  ROLE: [
    { user : &quot;user1&quot;, conditions : [ { grp : &quot;LENGTH&quot;, rel : &quot;GT&quot;, val : 3000, converter : &quot;custom.converters.NumberConverter.inchesInCm&quot; } ] },
    { user : &quot;user2&quot; }
  ]
}
</code></pre>
<h2>Determining a user</h2>
<pre><code>var sord = ixc.ix().checkoutSord(...);
var users = sol.common.Roles.getUsers('ROLE', sord, myRoleConfig);
</code></pre>

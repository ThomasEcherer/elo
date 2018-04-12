<h1>Application features</h1>
<p>By default, ELO clients offer a wide range of functions that cover many basic areas of enterprise content management. Due to the highly complex nature of the solutions, it is necessary to build the application logic of the clients and provide additional functions.</p>
<blockquote>
<p><span
style='font-style:italic'>Example:</span><span
style='font-weight:bold;font-style:italic'> A separate </span>ERECORD</span><span style='font-style:
italic'> tab containing actions such as </span><span
style='font-weight:bold;font-style:italic'>Create file</span><span
style='font-style:italic'>,</span><span style='font-weight:bold;font-style:
italic'>&nbsp;Close file</span><span style='font-style:italic'>, and</span><span
style='font-weight:bold;font-style:italic'> Open file</span><span
style='font-style:italic'> was provided for managing electronic records in the area of public administration.</span></p>
</blockquote>
<p>{@img img1.png}</p>
<h2>ELO multi-client strategy</h2>
<p>The ELO multi-client strategy serves to provide users with different clients. ELO Business Solutions aim to provide users with the same functions in the Java Client and the Web Client.</p>
<p>To ensure this, functions are implemented mainly server-side as <a
href="#!/guide/p5_Aktionen"><span
style='font-weight:bold'>actions</span></a> using ELOas or Indexserver scripts. Actions then tell the client what to do once the actions have been completed successfully. An action is usually triggered via a button on the ribbon. </p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> In the case of e-records, there is a</span><span
style='font-weight:bold;font-style:italic'> Create file</span><span
style='font-style:italic'> button in the client, which triggers an action with the same name. This action is represented by the <code>sol.pubsec.ix.actions.CreateRecord</code> class. This action, which runs on the Indexserver, subsequently instructs the client to display the file created.</span></p>
</blockquote>
<h2>Balance between scripting and modularity</h2>
<p>If application logic provided, it is necessary to consider what logic is implemented in the action and which logic can be modularized. As a general rule, an action should only complete basic operations such as creating a folder. <span
style='font-weight:bold'>If additional logic needs to be applied (e.g. to generate a feed entry), the action starts a workflow</span>, which uses <a
href="#!/guide/p6_Funktionsbausteine"><span
style='font-weight:bold'>function modules</span></a> to map more complex usage scenarios. </p>
<p>As far as possible, a user node with a corresponding ELOwf form should be used for data that is entered manually. Actions can instruct the clients to show the form in a dialog box.</p>
<p>The right balance between custom scripting and modularity via function modules enables Business Partners and consultants to adapt the application logic of solutions to their own requirements by making simple modifications to the workflow. In addition, modularizing frequently used functions reduces the need for programming.</p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> The </span><span style='font-weight:bold;
font-style:italic'>Create record</span><span style='font-style:italic'> action starts the workflow <code>sol.pubsec.record.CreateRecord</code>    This contains function modules such as writing a feed comment or setting the color of the file status to </span><span
style='font-weight:bold;font-style:italic'>Open</span><span style='font-style:
italic'> (green). The workflow also has a user node that provides a form for entering the information that the file must contain.</span></p>
</blockquote>

<h1>Process logic and best practices</h1>
<p>The solution process logic describes a best practice approach to modelling processes in companies This enables users to benefit from the experience gathered in existing projects, giving them a good basis to work with.</p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> The steps in the incoming invoice process are usually </span><span
style='font-weight:bold;font-style:italic'>Automatic data extraction</span><span
style='font-style:italic'>,</span><span style='font-weight:bold;font-style:
italic'> Formal verification</span><span style='font-style:italic'>,</span><span
style='font-weight:bold;font-style:italic'>&nbsp;Approval by department</span><span
style='font-style:italic'> and</span><span style='font-weight:bold;font-style:
italic'> Allocation to an account</span><span style='font-style:italic'>, before the invoice is finally transferred to the ERP system. A number of technical concepts were implemented to support this process. </span></p>
</blockquote>
<p>As it is not possible to create a standardized process for all usage scenarios due to differing company requirements, mechanisms were created that enable companies to quickly make modular changes to the process using ELO tools.</p>
<h2>Modularization of workflow forms</h2>
<p>All data is entered with the help of ELOwf forms, either via dialog boxes in the client or when issuing approval in the invoice process, for example. These are split into small modules with different roles and can be combined for different usage scenarios.</p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> During the </span><span
style='font-weight:bold;font-style:italic'>Formal verification</span><span
style='font-style:italic'> in the incoming invoice process, all creditor data should be shown. However, only the creditor name and number are required for the approval step. There are multiple creditor modules that can be used in the individual usage scenarios.</span></p>
</blockquote>
<p>{@img img1.png}</p>
<p>Forms are made up of a number of modules. You can modify these modules or combine them into a single form using the ELOwf form designer.</p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> If the accounts department needs to add project data to an invoice, this can be added to the form with just a few clicks.</p>
</blockquote>
<p>{@img img3.png}</p>
<h2>Process documentation via the feed</h2>
<p><span
style='font-weight:bold;font-style:italic'>ELO Social Components</span> provide a new form of collaboration within processes. The document feed is a simple way to communicate according to the principles of Enterprise 2.0. This method for documenting processes ensures maximum transparency.</p>
<p>The objective is to visualize the process in chronological order and give you the option to intervene.</p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> An invoice is in circulation. The user </span><span
style='font-weight:bold;font-style:italic'>Lagneaux</span><span
style='font-style:italic'> approves the invoice but it is not being paid until later, which means that the deadline for getting a discount has expired.</span></p>
</blockquote>
<p>{@img img5.png}</p>
<h2>Function modules</h2>
<p>Function modules enable you to integrate technical sequences into a process in order to be able to respond to customer requirements faster. For example, you can add your own <span
style='font-weight:bold;font-style:italic'>Create feed entry</span> module to enable you to write feed posts within a process.</p>
<p>As you are able to configure functions, you can do without scripting when you need to make minor adjustments to the process logic.</p>
<p>There are a number of modules available by default, such as <span
style='font-weight:bold;font-style:italic'>Black out text</span>, <span
style='font-weight:bold;font-style:italic'>Change color of element</span> or <span
style='font-weight:bold;font-style:italic'>Import metadata</span>.</p>

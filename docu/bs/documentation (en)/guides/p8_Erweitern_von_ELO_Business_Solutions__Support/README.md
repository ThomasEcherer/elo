<h1>Extending ELO Business Solutions/support</h1>
<p><span class="tag_caution">Extensions and changes to functions may not be made in JavaScript classes of the <span
style='font-style:italic'>Business Solutions</span> packages. These are done using custom packages. You may not be able to update solutions if you make changes to core components. You are also no longer entitled to support in such cases.</span></p>
<p><span
style='font-style:italic'>Business Solutions</span> implement different concepts to adapt existing logic. If you have any questions, please contact the <span
style='font-style:italic'>Business Solutions</span> team.</p>
<h2>Using custom packages</h2>
<p>A solution consists of different packages, which in turn contain additional custom packages. These custom packages can be used to adapt the configuration of a solution or the available action types, for example. If the developer tools are installed, an installation file can be created from each custom package. This enables you to easily transport all changes for a customer from the development system to the customer.</p>
<p>{@img img1.png}
{@img img3.png}</p>
<p><span class="tag_important">Tip: You can also use custom packages to create standard configurations for different usage scenarios. For example, &quot;Contract management - Property management&quot;.</span></p>
<p>A custom package usually contains a complete image of the configuration. The following example is based on the Invoice custom package. Configuration files are empty and only carry modifications to the basic configuration. </p>
<p>{@img img5.png}</p>
<p>The configuration pages for the solution visualize this process and show where changes have been made to settings. The following example is based on the sol.invoice.config.</p>
<p>{@img img7.png}</p>
<h2>Extensions to JavaScript classes</h2>
<p>Further developments should also be placed in the custom package so that they can be ported using the same mechanism.</p>
<p>Scripts/changes should be referenced at the corresponding locations. This also enables you to create your own installation packages so that you can install changes that deviate from the <span
style='font-style:italic'>Business Solutions</span> default settings.</p>
<p>JavaScript classes must be provided in a separate namespace, e.g. <code>partner.invoice.ix</code><br />

See also <a
href="#!/guide/p9_Namespaces">namespaces</a>.</p>
<p><span class="tag_caution">The namespace<span
style='font-weight:bold'> <code>sol</code></span> can only be used by <span style='font-style:
italic'>Business Solutions</span>. Own classes in this namespace may conflict with changes in later versions.</span></p>
<h2>Changes to technical processes</h2>
<p>Technical processes are implemented in <span
style='font-style:italic'>Business Solutions</span> with the help of workflow function modules. If you want to add your own logic, you can adapt the workflow to the project requirements.</p>
<p>Function modules enter the configuration for this in the node comment and can be easily deleted. 
See also <a
href="#!/guide/p6_Funktionsbausteine">Function modules</a>.</p>
<p>If you don't want a feed post to be written after extraction of ZUGFeRD data, for example, you can easily remove the selected node. If you want a different message to be shown, save a language file to the <span
style='font-weight:bold;font-style:italic'>Administration\Localization\custom\</span> folder and adjust the corresponding node configuration.</p>
<p>{@img img9.png}</p>
<p>If you do not have sufficient function modules to meet the requirements, you can also write your own function modules. </p>
<p><span class="tag_important">We recommend that you copy the workflow and store the new name in the configuration of the custom package. There is a setting for this for all technical workflows.</span></p>
<h2>Extend form modules</h2>
<p><span class="tag_important">You can edit Business Solutions forms in the form designer starting from ELO 10.01. Modifications are automatically saved to the custom package and are mostly updateable.</span></p>
<p>You can extend forms easily. However, changes to the <span
style='font-style:italic'>Business Solutions</span> forms should be be carried out in a separate template. To do so, clone the existing template, place it is a separate module and reference it in the form.</p>
<p>{@img img11.png}</p>
<h2>Extend the logic of existing JS classes</h2>
<p>If a class does not meet the requirements of a project, create a child class and override the desired properties/functions. This is helpful if you need to modify SQL queries for the available keyword lists, for example.</p>
<h2>Bug fixes</h2>
<p>Found/fixed an error? These may be fixed of course. Please inform the support team of any changes/errors so that these can be forwarded to <span
style='font-style:italic'>Business Solutions</span> for changing or fixing in the core product. The <span
style='font-style:italic'>Business Solutions</span> team welcomes any suggestions for improvements. :)</p>
<h2>Changes to Business Solutions JavaScript classes</h2>
<p><span class="tag_caution">Please do not make any changes to internal classes of <span
style='font-style:italic'>Business Solutions</span> modules as this increases the amount of time it takes to realize projects. Technical modules such as <span
style='font-weight:bold;font-style:italic'>Common</span>,<span
style='font-weight:bold;font-style:italic'> Connector</span> etc. may not be changed as these have dependencies with other <span
style='font-style:italic'>Business Solutions</span>.</span></p>
<p><span class="tag_caution">However, should it be necessary to make changes to the base classes of a solution, there may be problems with regards to updates as well as in terms of support. In this case, you need to maintain a version history of the classes so that the original state can be restored when you install updates.</span></p>
<p><span class="tag_important">We also advise you mark modified classes with a color (e.g. red).</span></p>

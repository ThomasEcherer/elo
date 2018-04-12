<h1>Solution architecture</h1>
<h2>Modularity</h2>
<p>Solutions are offered as packages including the whole configuration and all scripts. This helps users to maintain an overview despite the large number of scripts and templates and also represents the namespace.</p>
<p>A package should contain all the scripts, configurations and templates that the solution requires. It is then possible to put all the required files into an installation package that can be easily transferred to different systems.</p>
<p>Cross-solution functions are put into separate packages so that can be reused. For example, you will find <a
href="#!/guide/p5_Aktionen">actions</a> or <a
href="#!/guide/p14_Dynamische_Stichwortlisten">dynamic keyword lists</a> in the <span
style='font-weight:bold;font-style:italic'>common</span> package. whereas the <a
href="#!/guide/">XML Importer</a> is located in the <span
style='font-weight:bold;font-style:italic'>connector_xml</span> package.</p>
<p>The modularity aspects are explained in the following using the Invoice solution as an example. The solution contains different modules, e.g. <span
style='font-weight:bold;font-style:italic'>common</span>, <span
style='font-weight:bold;font-style:italic'>connector_xml </span>or <span
style='font-weight:bold;font-style:italic'>invoice</span>. Each module can be installed using the instructions in the documentation for a solution.</p>
<p>{@img img1.png}</p>
<p>The structure of the modules corresponds largely to the structure of the <span
style='font-weight:bold;font-style:italic'>Administration</span> folder. There is a separate entry for each ELO component here. Module scripts are filed here, referencing the original location. This is carried out by the installation package during installation.</p>
<blockquote>
<p><span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> By default, Indexserver scripts are filed to </span><span
style='font-weight:bold;font-style:italic'>Administration\Index Server Scripting Base\All\</span><span
style='font-style:italic'>. As solutions contain a number of scripts, these are filed to </span><span
style='font-weight:bold;font-style:italic'>Administration\Business Solutions\invoice\Index Server Scripting Base\</span><span
style='font-style:italic'> and linked to </span><span style='font-weight:
bold;font-style:italic'>Administration\Index Server Scripting Base\All\business solutions\</span><span
style='font-style:italic'>. This enables the developer to see quickly which solutions contain which scripts.</span></p>
</blockquote>
<p>The structure of a package can be extended, but should follow a naming convention.</p>
<table><thead><tr><td><span
style='font-weight:bold'>Folder name</span></td><td><span
style='font-weight:bold'>Description</span></td><td><span
style='font-weight:bold'>Namespace</span></td></tr></thead><tbody><tr><td>.eloinst</td><td><span
style='font-weight:bold'>Configuration for creating installation packages</span></td><td></td></tr><tr><td>.keywording forms</td><td><span
style='font-weight:bold'>Keywording forms required for the solution</span><br />A folder/blank document bearing that name should be created for each keywording form so that it is transferred during import/export.</td><td></td></tr><tr><td>All</td><td><span
style='font-weight:bold'>Scripts for all ELO modules</span><br />These scripts are referenced in all scripting folders of the ELO components.</td><td>    sol.invoice</td></tr><tr><td>All Rhino</td><td><span
style='font-weight:bold'>Scripts for all ELO modules that are based on the Rhino engine</span><br />These scripts are referenced in all scripting folders of the modules affected, e.g. ELOas, Java Client, Indexserver.</td><td>    sol.invoice</td></tr><tr><td>Configuration</td><td><span
style='font-weight:bold'>Configuration files for a solution package</span></td><td>    sol.invoice</td></tr><tr><td>Resources</td><td><span
style='font-weight:bold'>Solution resources</span><br />The required files, such as images or templates, can be stored here.</td><td>    </td></tr><tr><td>ELOapps</td><td><span
style='font-weight:bold'>Scripts for the ELOapps</span></td><td>    sol.invoice.apps</td></tr><tr><td>ELOas Base</td><td><span
style='font-weight:bold'>Scripts for ELOas</span></td><td>    sol.invoice.as</td></tr><tr><td>ELOwf Base</td><td><span
style='font-weight:bold'>Templates and scripts for form-based workflows</span></td><td>    sol.invoice.wf</td></tr><tr><td>Indexserver Scripting Base</td><td><span
style='font-weight:bold'>Scripts for the Indexserver</span></td><td>    sol.invoice.ix</td></tr><tr><td>Java Client Scripting Base</td><td><span
style='font-weight:bold'>Scripts for the Java Client</span></td><td>    sol.invoice.jc</td></tr><tr><td>Webclient Scripting Base</td><td><span
style='font-weight:bold'>Scripts for the Web Client</span></td><td>    sol.invoice.web</td></tr></tbody></table>

<h2>Module metadata</h2>
<p>The <span
style='font-weight:bold;font-style:italic'>ELO Business Solutions</span> keywording form should be assigned to modules. This enables users to add a version number and a <span
style='font-style:italic'>build</span> number that increments when <a
href="#!/guide/p18_Installationspakete">installation packages</a> are created.</p>
<p>{@img img3.png}</p>
<h2>Naming files in the repository</h2>
<p>The naming conventions applied to scripts enable users to separate additional library functions (e.g. helper classes) from available implementations (e.g. dynamic keyword lists, actions or services).</p>
<p>Classes that may be included should bear the prefix <code>lib_</code>. As all classes are referenced below the <span
style='font-weight:bold;font-style:italic'>Administration\Index Server Scripting Base</span> folder later on, the namespace should be included in the script name.</p>
<table><thead><tr><td><span
style='font-weight:bold'>Application</span></td><td><span
style='font-weight:bold'>Pattern</span></td></tr></thead><tbody><tr><td>Final implementation<br />(e.g. actions)</td><td>namespace.classname</td></tr><tr><td>Library classes<br />(e.g. utility classes)</td><td>lib_namespace.classname</td></tr></tbody></table>

<p>Several examples from the <span
style='font-style:italic'>Business Solutions Invoice</span> solution (child entries from <span
style='font-weight:bold;font-style:italic'>Administration\Business Solutions\invoice\Index Server Scripting Base</span>):</p>
<p>{@img img5.png}</p>
<h2>Modularity of configurations/extensions</h2>
<p>ELO Business Solutions offer <span
style='font-weight:bold;font-style:italic'>custom packages</span> for each package. A custom package contains all necessary configuration options for a solution. This allows you to separate the code base from the configuration for the purpose of installing future updates.</p>
<p>{@img img7.png}
{@img img9.png}</p>
<p><span class="tag_important">Each package is equipped with a custom package where appropriate. If there are no links to the packages on the installation pages, you do not need to install them. They can be downloaded from the ELO SupportWeb.</span></p>

Ext.data.JsonP.p18_Installationspakete({"guide":"<h1 id='p18_Installationspakete-section-installation-packages'>Installation packages</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/p18_Installationspakete-section-installation-process'>Installation process</a>\n </li>\n<li>2. <a href='#!/guide/p18_Installationspakete-section-configuration'>Configuration</a>\n </li>\n<li>3. <a href='#!/guide/p18_Installationspakete-section-creating-an-installation-package'>Creating an installation package</a>\n </li>\n<li>4. <a href='#!/guide/p18_Installationspakete-section-importing-an-installation-package'>Importing an installation package</a>\n </li>\n<li>5. <a href='#!/guide/p18_Installationspakete-section-uploading-installation-packages-from-a-website'>Uploading installation packages from a website</a>\n </li>\n</ul></div>\n\n\n<p><span class=\"tag_important\">The following concepts require the <span\nstyle='font-weight:bold;font-style:italic'>development</span> module.</span></p>\n\n\n<p>Solutions are made up of scripts, configurations, colors, and keywording forms, etc. Installation packages containing all the required information are created to ensure that these can be imported in the system quickly. These packages have the file extension <span\nstyle='font-style:italic'>.eloinst</span></p>\n\n\n<p>To make it easier for developers to create installation packages, various simple tools were created which can describe information for <span\nstyle='font-weight:bold'>creating a package</span> (build) and <span\nstyle='font-weight:bold'>actions when importing the package</span> (install) via a configuration.</p>\n\n\n<p>Configurations for the installation package can be filed to an <span\nstyle='font-style:italic'>.eloinst</span> folder below the solution package (<span\nstyle='font-style:italic'>Business Solutions Invoice</span> is used as an example here), These must follow the <span\nstyle='font-style:italic'>build</span> and <span style='font-style:italic'>install</span> naming conventions.</p>\n\n\n<p><p><img src=\"guides/p18_Installationspakete/img1.png\" alt=\"\" width=\"395\" height=\"218\"></p></p>\n\n\n<h2 id='p18_Installationspakete-section-installation-process'>Installation process</h2>\n\n\n<p>The <code>sol.common.jc.SolutionInstaller</code> class processes the entire installation. It starts by importing the repository work area contained in the export set. As this involves a standard import/export process, keywording forms, keyword lists, etc. are also transferred. The workflows contained in the export set are subsequently imported.</p>\n\n\n<p>Following this, operations necessary for the installation process that are defined in the configuration are executed. This could be referencing elements in the repository or adding colors, for example.</p>\n\n\n<h2 id='p18_Installationspakete-section-configuration'>Configuration</h2>\n\n\n<p>There are additional apps for configuring the installation packages, which provide interfaces for the build and install JSON files. </p>\n\n\n<p><span class=\"tag_important\">If these do not show up, the <span\nstyle='font-style:italic'>ClientInfo</span> configuration in the ELOwf app manager, which links the GUID of the configuration file in the repository with the corresponding app, may be missing.</span></p>\n\n\n<h3 id='p18_Installationspakete-section-build'>Build</h3>\n\n\n<p>The <span\nstyle='font-style:italic'>build</span> configuration contains information as to which data is to be exported from the existing repository. This could refer to the folder for exporting a repository or a list of the workflows that are required.</p>\n\n\n<p>The configuration app contains a detailed description of the individual functions. The following is an example of the <span\nstyle='font-weight:bold;font-style:italic'>build.json</span> file:</p>\n\n\n<pre><code>{\n  &quot;setupName&quot;: &quot;sol.invoice&quot;,\n  &quot;installConfigRepoPath&quot;: &quot;ARCPATH:/Administration/Business solutions/invoice/.eloinst/install&quot;,    \n  &quot;exportRepoPath&quot;: &quot;ARCPATH:/Administration/Business Solutions/invoice&quot;,\n  &quot;workflowTemplates1&quot;: [&quot;ELOinvoice&quot;]\n}\n</code></pre>\n\n\n<h3 id='p18_Installationspakete-section-install'>Install</h3>\n\n\n<p>The <span\nstyle='font-style:italic'>install</span> configuration contains operations that are to be executed during installation. The most common one is referencing scripts from the <span\nstyle='font-style:italic'>Administration\\Business Solutions\\</span> folder to the corresponding ELO components folder (e.g. ELOas). </p>\n\n\n<p>The configuration app contains a detailed description of the individual functions. The following is an example of the <span\nstyle='font-weight:bold;font-style:italic'>install.json</span> file:</p>\n\n\n<pre><code>{\n  &quot;setupName&quot;: &quot;sol.common&quot;,\n  &quot;users&quot;: [  { &quot;name&quot;: &quot;user1&quot;, &quot;type&quot;: &quot;User&quot; }  ],\n  &quot;colors&quot;: [  { &quot;name&quot;: &quot;color1&quot;, &quot;rgb&quot;: &quot;255&quot; }  ],\n  &quot;refChildren&quot;:  [{ \n                      &quot;source&quot;: &quot;{{bsFolderPath}}/common/All&quot;,\n                      &quot;destinations&quot;: [&quot;{{administrationFolderPath}}/ELOwf Base/Webapp&quot;,\n                                        &quot;{{administrationFolderPath}}/ELOas Base/JavaScript&quot;,\n                                        &quot;{{ixScriptingBaseFolderPath}}/_ALL/business_solutions&quot;,\n                                        &quot;{{jcScriptingBaseFolderPath}}/business_solutions&quot;,\n                                        &quot;{{bsFolderPath}}/common/ELOapps/Modules/sol.common.01&quot;]\n                    }, { \n                      &quot;source&quot;: &quot;{{bsFolderPath}}/common/ELOas Base&quot;,\n                      &quot;destinations&quot;: [&quot;{{administrationFolderPath}}/ELOas Base&quot;]\n                    }, {\n                      &quot;source&quot;: &quot;{{bsFolderPath}}/common/IndexServer Scripting Base&quot;,\n                      &quot;destinations&quot;: [&quot;{{ixScriptingBaseFolderPath}}/_ALL/business_solutions&quot;],\n                      &quot;ignoreSubfolders&quot;: true\n                    }],\n  &quot;asConfigDialog&quot;: {  &quot;configDestination&quot;: &quot;{{bsFolderPath}}/common/Configuration/as.config&quot;  },\n  &quot;reloads&quot;: {  &quot;ix&quot;: true,  &quot;apps&quot;: true  },\n  &quot;instAppModules&quot;: [&quot;sol.common.01&quot;]\n}\n</code></pre>\n\n\n<h2 id='p18_Installationspakete-section-creating-an-installation-package'>Creating an installation package</h2>\n\n\n<p>An installation package can be created using the <span\nstyle='font-weight:bold;font-style:italic'>Build setup package</span> function. The client offers a <span\nstyle='font-weight:bold;font-style:italic'>Save as</span> dialog box with the created <span\nstyle='font-style:italic'>.eloinst</span> file.</p>\n\n\n<p><p><img src=\"guides/p18_Installationspakete/img3.png\" alt=\"\" width=\"557\" height=\"127\"></p></p>\n\n\n<h2 id='p18_Installationspakete-section-importing-an-installation-package'>Importing an installation package</h2>\n\n\n<p>The easiest way to import <span\nstyle='font-style:italic'>.eloinst</span> packages is to drag and drop them onto the Java Client. You must be logged on as administrator to do this.</p>\n\n\n<h2 id='p18_Installationspakete-section-uploading-installation-packages-from-a-website'>Uploading installation packages from a website</h2>\n\n\n<p>Alternatively, you can offer packages via <span\nstyle='font-style:italic'>elodms://</span> links on a website. The <span\nstyle='font-weight:bold'>absolute </span>path of the base64-coded (<code>BASE64ENCODEDURL</code>) installation package must be transferred:</p>\n\n\n<pre><code>elodms://im/BASE64ENCODEDURL\n</code></pre>\n\n","title":"Installation packages"});
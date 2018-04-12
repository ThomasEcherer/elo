<h1>Installation packages</h1>
<p><span class="tag_important">The following concepts require the <span
style='font-weight:bold;font-style:italic'>development</span> module.</span></p>
<p>Solutions are made up of scripts, configurations, colors, and keywording forms, etc. Installation packages containing all the required information are created to ensure that these can be imported in the system quickly. These packages have the file extension <span
style='font-style:italic'>.eloinst</span></p>
<p>To make it easier for developers to create installation packages, various simple tools were created which can describe information for <span
style='font-weight:bold'>creating a package</span> (build) and <span
style='font-weight:bold'>actions when importing the package</span> (install) via a configuration.</p>
<p>Configurations for the installation package can be filed to an <span
style='font-style:italic'>.eloinst</span> folder below the solution package (<span
style='font-style:italic'>Business Solutions Invoice</span> is used as an example here), These must follow the <span
style='font-style:italic'>build</span> and <span style='font-style:italic'>install</span> naming conventions.</p>
<p>{@img img1.png}</p>
<h2>Installation process</h2>
<p>The <code>sol.common.jc.SolutionInstaller</code> class processes the entire installation. It starts by importing the repository work area contained in the export set. As this involves a standard import/export process, keywording forms, keyword lists, etc. are also transferred. The workflows contained in the export set are subsequently imported.</p>
<p>Following this, operations necessary for the installation process that are defined in the configuration are executed. This could be referencing elements in the repository or adding colors, for example.</p>
<h2>Configuration</h2>
<p>There are additional apps for configuring the installation packages, which provide interfaces for the build and install JSON files. </p>
<p><span class="tag_important">If these do not show up, the <span
style='font-style:italic'>ClientInfo</span> configuration in the ELOwf app manager, which links the GUID of the configuration file in the repository with the corresponding app, may be missing.</span></p>
<h3>Build</h3>
<p>The <span
style='font-style:italic'>build</span> configuration contains information as to which data is to be exported from the existing repository. This could refer to the folder for exporting a repository or a list of the workflows that are required.</p>
<p>The configuration app contains a detailed description of the individual functions. The following is an example of the <span
style='font-weight:bold;font-style:italic'>build.json</span> file:</p>
<pre><code>{
  &quot;setupName&quot;: &quot;sol.invoice&quot;,
  &quot;installConfigRepoPath&quot;: &quot;ARCPATH:/Administration/Business solutions/invoice/.eloinst/install&quot;,    
  &quot;exportRepoPath&quot;: &quot;ARCPATH:/Administration/Business Solutions/invoice&quot;,
  &quot;workflowTemplates1&quot;: [&quot;ELOinvoice&quot;]
}
</code></pre>
<h3>Install</h3>
<p>The <span
style='font-style:italic'>install</span> configuration contains operations that are to be executed during installation. The most common one is referencing scripts from the <span
style='font-style:italic'>Administration\Business Solutions\</span> folder to the corresponding ELO components folder (e.g. ELOas). </p>
<p>The configuration app contains a detailed description of the individual functions. The following is an example of the <span
style='font-weight:bold;font-style:italic'>install.json</span> file:</p>
<pre><code>{
  &quot;setupName&quot;: &quot;sol.common&quot;,
  &quot;users&quot;: [  { &quot;name&quot;: &quot;user1&quot;, &quot;type&quot;: &quot;User&quot; }  ],
  &quot;colors&quot;: [  { &quot;name&quot;: &quot;color1&quot;, &quot;rgb&quot;: &quot;255&quot; }  ],
  &quot;refChildren&quot;:  [{ 
                      &quot;source&quot;: &quot;{{bsFolderPath}}/common/All&quot;,
                      &quot;destinations&quot;: [&quot;{{administrationFolderPath}}/ELOwf Base/Webapp&quot;,
                                        &quot;{{administrationFolderPath}}/ELOas Base/JavaScript&quot;,
                                        &quot;{{ixScriptingBaseFolderPath}}/_ALL/business_solutions&quot;,
                                        &quot;{{jcScriptingBaseFolderPath}}/business_solutions&quot;,
                                        &quot;{{bsFolderPath}}/common/ELOapps/Modules/sol.common.01&quot;]
                    }, { 
                      &quot;source&quot;: &quot;{{bsFolderPath}}/common/ELOas Base&quot;,
                      &quot;destinations&quot;: [&quot;{{administrationFolderPath}}/ELOas Base&quot;]
                    }, {
                      &quot;source&quot;: &quot;{{bsFolderPath}}/common/IndexServer Scripting Base&quot;,
                      &quot;destinations&quot;: [&quot;{{ixScriptingBaseFolderPath}}/_ALL/business_solutions&quot;],
                      &quot;ignoreSubfolders&quot;: true
                    }],
  &quot;asConfigDialog&quot;: {  &quot;configDestination&quot;: &quot;{{bsFolderPath}}/common/Configuration/as.config&quot;  },
  &quot;reloads&quot;: {  &quot;ix&quot;: true,  &quot;apps&quot;: true  },
  &quot;instAppModules&quot;: [&quot;sol.common.01&quot;]
}
</code></pre>
<h2>Creating an installation package</h2>
<p>An installation package can be created using the <span
style='font-weight:bold;font-style:italic'>Build setup package</span> function. The client offers a <span
style='font-weight:bold;font-style:italic'>Save as</span> dialog box with the created <span
style='font-style:italic'>.eloinst</span> file.</p>
<p>{@img img3.png}</p>
<h2>Importing an installation package</h2>
<p>The easiest way to import <span
style='font-style:italic'>.eloinst</span> packages is to drag and drop them onto the Java Client. You must be logged on as administrator to do this.</p>
<h2>Uploading installation packages from a website</h2>
<p>Alternatively, you can offer packages via <span
style='font-style:italic'>elodms://</span> links on a website. The <span
style='font-weight:bold'>absolute </span>path of the base64-coded (<code>BASE64ENCODEDURL</code>) installation package must be transferred:</p>
<pre><code>elodms://im/BASE64ENCODEDURL
</code></pre>

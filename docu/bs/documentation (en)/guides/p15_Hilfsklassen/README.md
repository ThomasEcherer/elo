<h1>Helper classes</h1>
<p>The <span
style='font-weight:bold;font-style:italic'>Business Solutions Common</span> modules provides a series of helper classes that can be used for various purposes.</p>
<p>A selection of classes are mentioned in the following section. The scripting documentation contains exact descriptions of all helper classes.</p>
<h2>Overall compatibility of scripts</h2>
<p>To ensure that API calls to ELO are compatible, the variable <code>ixConnect</code> is set as the Indexserver connection in the scripts from ELO version 9.03. </p>
<h2>Utility classes</h2>
<p>Utility classes are singletons and can be used with instantiation.</p>
<table><thead><tr><td><span
style='font-weight:bold'>Name of the class</span></td><td><span
style='font-weight:bold'>Description</span></td></tr></thead><tbody><tr><td>    sol.common.AclUtils</td><td><span
style='font-weight:bold'>Utility functions for administering permissions in ELO</span></td></tr><tr><td>    sol.common.as.BarcodeUtils</td><td><span
style='font-weight:bold'>Utility functions for using QR codes and barcodes</span></td></tr><tr><td>    sol.common.as.Utils</td><td><span
style='font-weight:bold'>Utility functions for simplifying ELOas rules</span></td></tr><tr><td>    sol.common.as.PdfUtils</td><td><span
style='font-weight:bold'>Utility functions for handling PDF documents</span></td></tr><tr><td>    sol.common.AsUtils</td><td><span
style='font-weight:bold'>Utility functions for handling ELOas calls</span></td></tr><tr><td>    sol.common.AsyncUtils</td><td><span
style='font-weight:bold'>Utility functions for synchronizing asynchronous calls</span></td></tr><tr><td>    sol.common.CounterUtils</td><td><span
style='font-weight:bold'>Utility functions for using counters</span></td></tr><tr><td>    sol.common.DateUtils</td><td><span
style='font-weight:bold'>Utility functions for handling date formats</span></td></tr><tr><td>    sol.common.ExceptionUtils</td><td><span
style='font-weight:bold'>Utility functions for handling Indexserver exceptions</span></td></tr><tr><td>    sol.common.ExecUtils</td><td><span
style='font-weight:bold'>Utility functions for managing local system resources</span></td></tr><tr><td>    sol.common.FileUtils</td><td><span
style='font-weight:bold'>Utility functions for managing local and temporary files</span></td></tr><tr><td>    sol.common.HttpUtils</td><td><span
style='font-weight:bold'>Utility functions to query the contents of external http sources</span></td></tr><tr><td>    sol.common.ix.DynKwlUtils</td><td><span
style='font-weight:bold'>Utility functions for dynamic keyword lists</span><br />Uses dynamic keyword lists to make it easier to complete data.</td></tr><tr><td>    sol.common.ix.RfUtils</td><td><span
style='font-weight:bold'>Utility functions for implementing registered functions</span><br />Simplifies parsing and validation of the transferred parameter values.</td></tr><tr><td>    sol.common.IxUtils</td><td><span
style='font-weight:bold'>Utility functions for calling the Indexserver</span><br />Simplifies calling of registered functions, etc.</td></tr><tr><td>    sol.common.JsonUtils</td><td><span
style='font-weight:bold'>Utility functions for dealing with JSON data</span><br />Simplifies serialization of JSON data.</td></tr><tr><td>    sol.common.ObjectUtils</td><td><span
style='font-weight:bold'>Utility functions for handling JS objects</span></td></tr><tr><td>    sol.common.RepoUtils</td><td><span
style='font-weight:bold'>Utility functions for access to ELO elements</span><br />Simplifies access to ELO elements in the ELO repository.</td></tr><tr><td>    sol.common.SordTypeUtils</td><td><span
style='font-weight:bold'>Utility functions for handling Sord object types</span><br /></td></tr><tr><td>    sol.common.SordUtils</td><td><span
style='font-weight:bold'>Utility functions for handling Sord object types</span><br />Simplifies access to Sord information.</td></tr><tr><td>    sol.common.StringUtils</td><td><span
style='font-weight:bold'>Utility functions for handling character strings</span></td></tr><tr><td>    sol.common.TranslateTerms</td><td><span
style='font-weight:bold'>Utility functions for localizing solutions</span></td></tr><tr><td>    sol.common.UserUtils</td><td><span
style='font-weight:bold'>Utility functions for handling user profiles</span></td></tr><tr><td>    sol.common.WfUtils</td><td><span
style='font-weight:bold'>Utility functions for handling workflows</span><br />Simplifies access to workflow nodes and allows these to be edited.</td></tr><tr><td>    sol.common.XmlUtils</td><td><span
style='font-weight:bold'>Utility functions for creating XML data structures from JS objects</span></td></tr><tr><td>    sol.common.ZipUtils</td><td><span
style='font-weight:bold'>Utility functions for using and creating ZIP files</span></td></tr></tbody></table>

<h2>Function classes</h2>
<p>Function classes require an instantiation with the desired context.</p>
<table><thead><tr><td><span
style='font-weight:bold'>Name of the class</span></td><td><span
style='font-weight:bold'>Description</span></td></tr></thead><tbody><tr><td>    sol.common.as.Mail</td><td><span
style='font-weight:bold'>Utility class for sending e-mails</span></td></tr><tr><td>    sol.common.as.OfficeDocument</td><td><span
style='font-weight:bold'>Class for using Office documents in ELOas</span><br />Contains implementations for Excel, Word, PowerPoint, Visio and Mapi.</td></tr><tr><td>    sol.common.Config</td><td><span
style='font-weight:bold'>Class for reading and writing JSON configuration files</span></td></tr><tr><td>    sol.common.Locale</td><td><span
style='font-weight:bold'>Class for reading user locals</span><br />Returns information for loading user-specific information, such as language or decimal separators.</td></tr><tr><td>    sol.common.SordMap</td><td><span
style='font-weight:bold'>Class for reading and writing map files</span><br />Helps read and write map files for a Sord object.</td></tr><tr><td>    sol.common.UserProfile</td><td><span
style='font-weight:bold'>Class for reading user information</span><br />Helps read user properties from the user profile.</td></tr></tbody></table>

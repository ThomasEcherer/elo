<h1>Glossary and abbreviations</h1>
<h2>Glossary</h2>
<table><thead><tr><td><span
style='font-weight:bold'>Term</span></td><td><span
style='font-weight:bold'>Description</span></td></tr></thead><tbody><tr><td><span
style='font-weight:bold'>Action</span></td><td>Actions are sequences of simple events that the user can trigger in the client via a function (button). Actions are implemented as an Indexserver script or an ELOas rule.<br /><br /> <span
style='font-weight:bold;font-style:italic'>Example</span>: The <span style='font-weight:bold;
font-style:italic'>Create file</span> action creates a folder, starts a workflow with the same name and triggers client events such as <span
style='font-weight:bold;font-style:italic'>Show form</span>.</td></tr><tr><td><span
style='font-weight:bold'>Dynamic keyword</span></td><td>Dynamic keyword lists allow the use of data from external databases for keywording or data entry in ELO. These can be applied to index fields (for keywording forms) as well as to map fields (for forms). When a user starts to type data into a field, the current field value is passed as a filter value to the keyword list. Database queries can be used to process data that is entered and visualize the results in table form.</td></tr><tr><td><span
style='font-weight:bold'>Framework</span></td><td>Program framework for creating an application. The templates used in the framework also affect the structure of the application. The framework defines the control flow and the interfaces of concrete classes that need to be programmed. Another purpose of frameworks is to provide a reusable design pattern.<br /><br />The <span
style='font-style:italic'>Business Solutions</span> class framework enables derived classes to inherit the functions of the base class. It also provides object relational methods in JavaScript.</td></tr><tr><td><span
style='font-weight:bold'>Function module</span></td><td>A separate program component which is called via a module-specific interface. A function module can embed and call other modules.</td></tr><tr><td><span
style='font-weight:bold'>Utility class</span></td><td>Utility classes provide functions that are not part of the core function of the application they are used in. <br /><br />Utility classes are special helper classes that have only static methods.</td></tr><tr><td><span
style='font-weight:bold'>Namespace</span></td><td>Space in which each name uniquely identifies an object. The name can be used in multiple namespaces to refer to a different object. The objects are arranged in a tree structure and called via corresponding path names.<br /><br />Namespaces are used to categorize <span
style='font-style:italic'>ELO Business Solutions</span>, ensure they are logically separated and make it possible to differentiation between classes of the <span
style='font-style:italic'>Business Solutions</span> team and third-party modifications.<br /><br />&gt; <span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> The namespace sol.invoice.ix contains all classes that </span><span
style='font-weight:bold;font-style:italic'>ELO Business Solution Invoice</span><span
style='font-style:italic'> users to communicate with the Indexserver.</span></td></tr><tr><td><span
style='font-weight:bold'>Object formatter</span></td><td>The Indexserver Sord objects generally contain a large amount of information that is not actually required. The object formatter can be used to define object properties, which makes it easier to transfer objects. This is recommended for large database queries to reduce the volume of data transferred from the Indexserver to the client. <br /><br />This function is used by services that collect data for dashboard apps developed in <span
style='font-style:italic'>AngularJS</span>.</td></tr><tr><td><span
style='font-weight:bold'>Service</span></td><td>A separate program component that bundles related functions on a range of topics and makes these available via a specifically defined interface.<br /><br />Unlike function modules, services makes information available to the client and are not used as workflow nodes.</td></tr><tr><td><span
style='font-weight:bold'>Sord</span></td><td>A repository object in ELO. This can either be a document or a folder.</td></tr><tr><td><span
style='font-weight:bold'>Workflows</span></td><td>Sequence of actions that correspond to a work process and is either triggered by the system or manually by the user via connected function modules and nodes.<br>
<br />&gt; <span
style='font-weight:bold;font-style:italic'>Example:</span><span
style='font-style:italic'> The<span style='font-weight:bold;
font-style:italic'> Create record </span><span style='font-style:italic'>action starts the workflow 'sol.pubsec.record.CreateRecord'. This workflow contains function modules such as writing a feed comment or setting the color of the file status. The workflow also has a user node that provides a form for entering the information that the record must contain.</span></td></tr></tbody></table>

<h2>Abbreviations</h2>
<table><thead><tr><td><span
style='font-weight:bold'>Abbreviation</span></td><td><span
style='font-weight:bold'>Term</span></td></tr></thead><tbody><tr><td>AS</td><td>ELO Automation Services (ELOas)</td></tr><tr><td>BS Invoice</td><td>Business Solution Invoice</td></tr><tr><td>DX</td><td>DocXtractor</td></tr><tr><td>IX</td><td>ELO Indexserver (ELOix)</td></tr><tr><td>JS</td><td> JavaScript</td></tr></tbody></table>

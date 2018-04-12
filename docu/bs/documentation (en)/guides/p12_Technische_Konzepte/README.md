<h1>Technical concepts</h1>
<p>To ensure that solutions can be adapted to individual projects, a number of technological concepts have been developed which allow users to break down the individual components in a solution into modules, enabling the core solution components to be updated as required.</p>
<p><span
style='font-weight:bold'>These concepts are bundled into a package called </span><span
style='font-weight:bold;font-style:italic'>Business Solutions Common</span><span
style='font-weight:bold'> and can be used for own projects.</span></p>
<p><span
style='font-weight:bold'>The following sections provide a summary and overview of the implemented concepts. You can refer to the class documentation for detailed information.</span></p>
<p>In essence, a <a
href="#!/guide/p13_Klassenframework"><span
style='font-weight:bold'>class framework</span></a> based on object relational principles was created which enables the developer to extend the functions of existing components. For example, you can define <a
href="#!/guide/p14_Dynamische_Stichwortlisten"><span
style='font-weight:bold'>dynamic keyword lists</span></a> quickly and easily just by modifying five config properties. A series of <a
href="#!/guide/p15_Hilfsklassen"><span
style='font-weight:bold'> utility classes</span></a> cover the basic requirements of solutions and helps when dealing with Indexserver objects and access to the Indexserver. </p>
<h2>Actions, function modules and services</h2>
<p>Based on this, the implementation of client extensions (e.g. <code>Create contract</code>) was standardized with server-side <a
href="#!/guide/p5_Aktionen"><span
style='font-weight:bold'>actions</span></a>, which means that functions are available in all the ELO clients. Technical processes are mapped using <a
href="#!/guide/p6_Funktionsbausteine"><span
style='font-weight:bold'>function modules</span></a> with the help of ELO workflows. This provides maximum flexibility and follows on from the premise of adapting the logic without having to write code.</p>
<p>{@img img1.png}</p>
<p><a
href="#!/guide/p16_Services"><span
style='font-weight:bold'>Services</span></a> are used for collecting data or providing various operations that need to be processed by the calling instance. For example, the <span
style='font-weight:bold'> <code>sol.common.ix.service.ChildrenDataCollector</code></span> class can be used to collect and prepare large volumes of data. An ELO app can transfer which information (e.g.<code>objKey</code> parameters) are required, for example. This reduces traffic and ensures that apps for mobile devices are high performance.</p>

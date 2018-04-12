Ext.data.JsonP.module_03_components({"guide":"<h1 id='module_03_components-section-elo.module.component'>elo.module.component</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/module_03_components-section-usedefaultmodules'>useDefaultModules</a>\n </li>\n<li>2. <a href='#!/guide/module_03_components-section-components'>Components</a>\n </li>\n</ul></div>\n\n<p>This module provides support for ELO Apps using AngularJS.\nThis module is directly connected to the <strong>useDefaultModules</strong> flag in the manifest of\nan ELO App. So if this flag is set in the ELO App Manager, the module will be\nadded to the list of modules for this ELO App.\nThis module has dependencies to AngularJS and further third party scripts.</p>\n\n<p><strong>Please note</strong>: We encourage the use of AngularJS in ELO Apps and provide\nfront-end components only for AngularJS.</p>\n\n<h2 id='module_03_components-section-usedefaultmodules'>useDefaultModules</h2>\n\n<p>This flag marks the use of AngularJS in the ELO App. The flag causes slight\nchanges in the apps loading behavior. Also additional AngularJS specific code\ngets created in the apps default JavaScript file.</p>\n\n<p>Since AngularJS provides the app with its controller concept the <em>onLoad</em> function\ncode should be relocated inside the AngularJS controller of the ELO app.\nTherefore onLoad will be executed before AngularJS will bootstrap its components\nand start working. So the <em>onLoad</em> function of an ELO App having the\n<strong>useDefaultModules</strong> flag set can be used to apply changes before the normal\nAngularJS bootstrap.</p>\n\n<p>The <em>onLoad</em> function gets called with an empty object as parameter. If the property\n<em>disableNgBootstrap</em> is set to true in the onLoad function. The bootstrap method\nwill not be called automatically after the execution of the <em>onLoad</em> function.\nThis is needed if asynchronious calls have to be made in the <em>onLoad</em> function.</p>\n\n<h2 id='module_03_components-section-components'>Components</h2>\n\n<p>The module further defines directives, services, and filters to provide basic\ncomponents providing simple default behaviour.</p>\n\n<p>For further details see: api.module.Components.</p>\n","title":"elo.module.components"});
Ext.data.JsonP.core_02_app_configuration({"guide":"<h1 id='core_02_app_configuration-section-app-specific-configuration'>App specific configuration</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/core_02_app_configuration-section-introduction'>Introduction</a>\n </li>\n<li>2. <a href='#!/guide/core_02_app_configuration-section-archive-configuration-folder'>Archive configuration folder</a>\n </li>\n<li>3. <a href='#!/guide/core_02_app_configuration-section-adding-a-configuration-file-into-the-apps-manifest'>Adding a configuration file into the Apps manifest</a>\n </li>\n<li>4. <a href='#!/guide/core_02_app_configuration-section-access-data-inside-the-app'>Access data inside the app</a>\n </li>\n</ul></div>\n\n<p>This guide explains how to store JSON data for a specific ELO App into the\narchive and access it in the running app.</p>\n\n<h2 id='core_02_app_configuration-section-introduction'>Introduction</h2>\n\n<p>If an ELO App needs static data as configuration (e.g. a mask name, a folder guid,\na workflow template id etc.) it is a bad idea to write this data into the\nJavaScript code of the app. Instead it should be stored in the archive, so it\ncan be modified without changing the ELO App itself.</p>\n\n<h2 id='core_02_app_configuration-section-archive-configuration-folder'>Archive configuration folder</h2>\n\n<p>The ELO Apps will create several folders inside the Administration folder. One\nis called Configuration. To store app specific configuration data a JSON text\nfile can be created with any name short description. The content\nof the document must be a JSON object. In order for an app to load any number\nof those configuration files a <em>configFiles</em> object has to be added in the apps\nmanifest. The ELOwf will cache all those JSON documents and transmit the data\nto the ELO App when it is loading. Be aware because of that cache the server does\n not need to access the archive every time the ELO App should be loaded.\nBut changing the archive JSON file needs an refresh in the ELO App Manager.</p>\n\n<p><p><img src=\"guides/core_02_app_configuration/archive_config_folder.PNG\" alt=\"Alt Configuration folder in the archive\" width=\"808\" height=\"284\"></p></p>\n\n<h2 id='core_02_app_configuration-section-adding-a-configuration-file-into-the-apps-manifest'>Adding a configuration file into the Apps manifest</h2>\n\n<p>To add a configuration file to an App it must be added to the manifest. Therefore\nin the ELO App Manager in the Details View a number of files can be added by\ngiving them IDs.</p>\n\n<p><p><img src=\"guides/core_02_app_configuration/appmanager_add_config.PNG\" alt=\"Alt Adding configurations to the App\" width=\"805\" height=\"252\"></p></p>\n\n<h2 id='core_02_app_configuration-section-access-data-inside-the-app'>Access data inside the app</h2>\n\n<p>Inside the ELO Apps JavaScript code the data can be accessed with the configured\nID from the manifest using api.helpers.Configuration singleton.</p>\n\n<pre><code>var test = api.helpers.Configuration.has(\"config\");\n// test is true\ntest = api.helpers.Configuration.get(\"config\");\n// test is { docId: 537, parentId: 536 }\n</code></pre>\n\n<p><strong>Please note</strong>: If the JSON data inside the document is altered the\nchanges will not take effect until the caches are reloaded (this can be done via\nthe refresh button inside the ELO App Manager).</p>\n","title":"App-Specific Configuration"});
Ext.data.JsonP.core_01_first_app({"guide":"<h1 id='core_01_first_app-section-creating-the-first-elo-app'>Creating the first ELO App</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/core_01_first_app-section-elo-app-manager'>ELO App Manager</a>\n </li>\n<li>2. <a href='#!/guide/core_01_first_app-section-create-a-new-elo-app'>Create a new ELO App</a>\n </li>\n<li>3. <a href='#!/guide/core_01_first_app-section-what-did-just-happen%3F'>What did just happen?</a>\n </li>\n<li>4. <a href='#!/guide/core_01_first_app-section-start-developing'>Start developing</a>\n </li>\n</ul></div>\n\n<p>This tutorial will explain step by step how to build your first ELO App.</p>\n\n<h2 id='core_01_first_app-section-elo-app-manager'>ELO App Manager</h2>\n\n<p>The first step to create an App is to start the ELO App Manager. This can be done e.g. via\nthe status page of the ELOwf.</p>\n\n<p><p><img src=\"guides/core_01_first_app/elowf_status_page.PNG\" alt=\"Alt ELOwf Status page\" width=\"740\" height=\"145\"></p></p>\n\n<p>To use the ELO App Manager an ELO login is required. The user need Administrator rights.\nAfter the login the ELO App Manager will start (for further details about the ELO\n App Manager please read the following guid: <a href=\"#!/guide/basic_04_appmanager\">ELO App Manager</a>).</p>\n\n<h2 id='core_01_first_app-section-create-a-new-elo-app'>Create a new ELO App</h2>\n\n<p>In the ELO App Manager hit the button to create a new ELO App in the toolbar.\nIn the details view a form will be shown to fill out the manifest file of the new App.</p>\n\n<p>Fill out the form according to the following values:</p>\n\n<ul>\n<li><em>App name</em> = Hello World</li>\n<li><em>Namespace</em> = my.custom</li>\n<li><em>App ID</em> = First</li>\n<li><em>Default language</em> = en</li>\n<li><em>ELO session required</em> = 'check'</li>\n<li><em>Use default modules</em> = 'uncheck'</li>\n</ul>\n\n\n<p>After checking the ELO session checkbox the ELO App Manager will automatically add\nthe elo.module.session Module. It will give the ELO App access to the Indexserver and\nprovide a login screen if the ELO App has no ticket information if it get started.</p>\n\n<p><p><img src=\"guides/core_01_first_app/first_app_details.PNG\" alt=\"Alt Details tab in the ELO App Manager\" width=\"815\" height=\"428\"></p></p>\n\n<p>After pressing the Save button the ELO App will get created in the local data directory\nand appear in the left list of available apps in the ELO App Manager.\nSelecting the ELO App again will show its manifest in the details.</p>\n\n<p>Pressing the link of the App ID column in the available apps list will start the ELO App.\nSince we have a valid Administrator login, the ELO App will start immediately.</p>\n\n<p><p><img src=\"guides/core_01_first_app/first_app_browser.PNG\" alt=\"Alt Details tab in the ELO App Manager\" width=\"1660\" height=\"159\"></p></p>\n\n<h2 id='core_01_first_app-section-what-did-just-happen%3F'>What did just happen?</h2>\n\n<p>When saving the form for the new ELO App it will get evaluated and after that the ELOwf\nwill automatically generate a stub ELO App structure in the local data directory.</p>\n\n<p>Besides the folder structure, the ELO App already contains:</p>\n\n<ul>\n<li>The manifest file manifest.json</li>\n<li>A HTML body snippet in First.html</li>\n<li>A locale file in locales/First.properties</li>\n<li>A JavaScript file with onLoad handler in app/First.js</li>\n<li>Stylesheet with default styles in resources/css/First.css</li>\n</ul>\n\n\n<p>After generating this structure, the ELO App will get build so it is runnable.</p>\n\n<p>The structure look like:</p>\n\n<p><p><img src=\"guides/core_01_first_app/first_app_structure.PNG\" alt=\"Alt Generated App structure\" width=\"243\" height=\"255\"></p></p>\n\n<h2 id='core_01_first_app-section-start-developing'>Start developing</h2>\n\n<p>Having a running ELO App helps a lot when it comes to getting started with development.\nBasically you can write any application with the files at hand.</p>\n\n<h3 id='core_01_first_app-section-properties'>properties</h3>\n\n<p>All texts that should be displayed in the ELO App are written inside the .properties file.\nSince the <em>defaultLanguage</em> in the manifest is 'en' the file should contain only English text.\nIf you need multi-language support you can translate the .properties file to other\nlanguages and create new files holding the ISO 639 language postfix. E.g. the French\ntranslation would be written in First_fr.properties.</p>\n\n<h3 id='core_01_first_app-section-html'>HTML</h3>\n\n<p>In the HTML file (First.html) all static content is written. If you need access to the\nlocalized text in the properties files you can use ${KEY}. Loading the ELO App\nwill dynamically replace those by the text in the requested language (or the\n<em>defaultLanguage</em> if the requested language is not available) file with the given key.\nOn startup the files input will be loaded into the memory, the key will be replaced\nwith the localized text from the requested language and then the content will be\nloaded into the body tag of the apps HTML page.</p>\n\n<h3 id='core_01_first_app-section-javascript'>JavaScript</h3>\n\n<p>The JavaScript file (app/First.js) already contains some script code.</p>\n\n<pre><code>(function(){\n    'use strict';\n\n    api.namespace('my.custom.First');\n\n    my.custom.First.onLoad = function(){\n\n        // Put your Javascript on start code here...\n        api.webapps.WebApp.showToast(api.helpers.Text.getText('APP.NAME'),\n                'just wants to say Hello World!', api.webapps.WebApp.TOAST_TYPE.INFO, 3);\n    };\n\n}());\n</code></pre>\n\n<p>The code is wrapped inside a function call with the <strong>'use strict';</strong> declaration\nin order to enable Strict Mode. It is recommended to always use Strict Mode when\nwriting JavaScript code that is running in a browser. For more information about\n the Strict Mode see <a href=\"http://www.w3schools.com/js/js_strict.asp\">here</a>.</p>\n\n<p>The script creates a JavaScript the object <strong>my.custom.First</strong> as namespace using\n<strong>api.namespace</strong>. All needed global variables should be defined under this namespace\n to prevent name collisions.</p>\n\n<p>Next an <strong>onLoad</strong> function is implemented by displaying a toast by calling\n<strong>api.webapps.WebApp.showToast</strong>. This function gets called after every script was\nloaded and executed. So if no AngularJS is used, here is a good place load data\n from the Indexserver etc.</p>\n\n<p>After all scripts are loaded and if configured, a session to the indexserver is\nestablished, the <strong>onLoad</strong> function gets called. It is called with an empty object\nas parameter. This object can be altered to control the further loading process,\nby adding different parameter:</p>\n\n<ul>\n<li><strong>[keepLoadingScreen]</strong>: Set to true will not disable the loading screen. The\ndeveloper has to do this on its own by calling api.webapps.WebApp.hideLoadingScreen.</li>\n<li><strong>[disableNgBootstrap]</strong>: In case of an app having <strong>useDefaultModules</strong> set to\ntrue in its manifest. This parameter will prevent the call to start the\nAngularJS bootstrap execution.</li>\n</ul>\n\n\n<p>Both parameters are needed if asynchronious calls are made inside the <strong>onLoad</strong>\nfunction.</p>\n\n<p><strong>Please note:</strong> The keep your ELO App compatible with future release do not\nuse any internal methods or object. Only methods and objects provided by this\nAPI documentation can be used. As a rule of thumb only methods and object under\nthe api. namespace will be supported, especially the elo. namespace is for\ninternal use only and can differ in each version (in addition to the JSON API).</p>\n\n<h3 id='core_01_first_app-section-css'>CSS</h3>\n\n<p>The CSS file (resources/css/First.css) already contains some classes. First a\ndefault font type is set to ensure all apps are using the same font. Furthermore\nthe styles for the toast messages are also stored here.\nIf you want to customize the toast messages alter the classes here or just add\nyour CSS code below.</p>\n","title":"Creating the first ELO App"});
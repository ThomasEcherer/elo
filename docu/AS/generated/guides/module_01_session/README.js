Ext.data.JsonP.module_01_session({"guide":"<h1 id='module_01_session-section-elo.module.session'>elo.module.session</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/module_01_session-section-useelosession'>useEloSession</a>\n </li>\n<li>2. <a href='#!/guide/module_01_session-section-restrict-access-to-elo-apps'>Restrict access to ELO Apps</a>\n </li>\n<li>3. <a href='#!/guide/module_01_session-section-starting-the-app'>Starting the App</a>\n </li>\n<li>4. <a href='#!/guide/module_01_session-section-javascript-libraries'>JavaScript libraries</a>\n </li>\n</ul></div>\n\n<p>This guide explains the use of the <strong>elo.module.session</strong> module.\nThis module is directly connected to the <strong>useEloSession</strong> flag in the manifest of\nan ELO App. So if this flag is set in the ELO App Manager, the module will be\nadded to the list of modules for this ELO App.</p>\n\n<p><strong>Please note</strong>: This module will not work correctly without the <strong>useEloSession</strong>\nflag in the manifest of the ELO App.</p>\n\n<h2 id='module_01_session-section-useelosession'>useEloSession</h2>\n\n<p>Besides adding the module to the list the <strong>useEloSession</strong> flag tells the system\nthat this ELO App needs an ELO session in order to work correctly. In other words:\nThe ELO App wants to access the archive or use ELO functionality in any way.</p>\n\n<p>If the flag is set the ELO App can only be accessed if there is a valid ELO\nsession ticket available. If the ELO App is running inside client\n(embedded by a <a href=\"#!/guide/basic_03_clientinfo\">Client Info</a>.) such a ticket is\n provided as Url parameter. The parameter gets evaluated, the access to the\nELO App is checked and if everything is alright the ELO App gets loaded. Loading\nthe ELO App will transmit the ticket to the browser using a HTML cookie.</p>\n\n<p>If no ticket is available or the ticket is invalid. The system (i.e. the ELOwf)\nwill redirect the call of an ELO App to a Login page. Here the user can login\nmanually in order to create a new ticket.</p>\n\n<p><p><img src=\"guides/module_01_session/login_app.PNG\" alt=\"ELO Login app\" width=\"886\" height=\"358\"></p></p>\n\n<p>After a successful login the user gets redirected to the original ELO App.</p>\n\n<h2 id='module_01_session-section-restrict-access-to-elo-apps'>Restrict access to ELO Apps</h2>\n\n<p>If there is a valid ELO login for an ELO App it can be checked if the user is\nallowed to use the app. Therefore each archived/installed ELO App containing the\nhas an <em>access</em> folder in its archive structure. Every time an ELO App containing\n<strong>useEloSession</strong> flag gets loaded the access is checked:</p>\n\n<ul>\n<li>If the ELO App has status development only users holding Administrator right\nwill have access. This holds also for the ELO App Manager app.</li>\n<li>If the ELO App is installed all users having read access on the <em>access</em>\nfolder gain access to the ELO App.</li>\n</ul>\n\n\n<h2 id='module_01_session-section-starting-the-app'>Starting the App</h2>\n\n<p>When the ELO App gets loaded with a valid ticket the html page will dynamically\nget created. If the elo.module.session module is loaded it directly starts to\nconnect to the indexserver. Since this is a asynchronious request the other\nscripts continue to load.\nOnly if the DOMContentLoaded event <strong>and</strong> the connection to the indexserver is\nestablished the <em>onLoad</em> function of the app will get executed. Here the IXConnection\nobject can be accessed via <em>api.IX</em>. After the <em>onLoad</em> function the loading\nscreen will be hidden.</p>\n\n<h2 id='module_01_session-section-javascript-libraries'>JavaScript libraries</h2>\n\n<p>The elo.module.session module provides static helper functions to simplify the\ncommunication to the indexserver (see package api.ix):</p>\n\n<ul>\n<li><strong>[api.ix.DateUtils]</strong>: Basic date transformation from/to ELO iso date format.</li>\n<li><strong>[api.ix.ListUtils]</strong>: Helpers to retrieve user, mask, task and sord lists.</li>\n<li><strong>[api.ix.SordUtils]</strong>: Helpers regarding sord objects.</li>\n<li><strong>[api.ix.TaskUtils]</strong>: Helpers regarding user task and workflow objects.</li>\n<li><strong>[api.ix.UserUtils]</strong>: Helpers regarding users.</li>\n<li><strong>[api.ix.EloUtils]</strong>: Additional helpers.</li>\n</ul>\n\n","title":"elo.module.session"});
# Creating the first ELO App

This tutorial will explain step by step how to build your first ELO App.

## ELO App Manager

The first step to create an App is to start the ELO App Manager. This can be done e.g. via 
the status page of the ELOwf.

{@img elowf_status_page.PNG Alt ELOwf Status page}

To use the ELO App Manager an ELO login is required. The user need Administrator rights.
After the login the ELO App Manager will start (for further details about the ELO
 App Manager please read the following guid: [ELO App Manager](#!/guide/basic_04_appmanager)).

## Create a new ELO App

In the ELO App Manager hit the button to create a new ELO App in the toolbar.
In the details view a form will be shown to fill out the manifest file of the new App.

Fill out the form according to the following values:

- *App name* = Hello World
- *Namespace* = my.custom
- *App ID* = First
- *Default language* = en
- *ELO session required* = 'check'
- *Use default modules* = 'uncheck'

After checking the ELO session checkbox the ELO App Manager will automatically add 
the elo.module.session Module. It will give the ELO App access to the Indexserver and
provide a login screen if the ELO App has no ticket information if it get started.

{@img first_app_details.PNG Alt Details tab in the ELO App Manager}

After pressing the Save button the ELO App will get created in the local data directory
and appear in the left list of available apps in the ELO App Manager.
Selecting the ELO App again will show its manifest in the details.

Pressing the link of the App ID column in the available apps list will start the ELO App.
Since we have a valid Administrator login, the ELO App will start immediately.

{@img first_app_browser.PNG Alt Details tab in the ELO App Manager}

## What did just happen?

When saving the form for the new ELO App it will get evaluated and after that the ELOwf
will automatically generate a stub ELO App structure in the local data directory.

Besides the folder structure, the ELO App already contains:

- The manifest file manifest.json
- A HTML body snippet in First.html
- A locale file in locales/First.properties
- A JavaScript file with onLoad handler in app/First.js
- Stylesheet with default styles in resources/css/First.css

After generating this structure, the ELO App will get build so it is runnable.

The structure look like:

{@img first_app_structure.PNG Alt Generated App structure}

## Start developing

Having a running ELO App helps a lot when it comes to getting started with development.
Basically you can write any application with the files at hand.

### properties

All texts that should be displayed in the ELO App are written inside the .properties file.
Since the *defaultLanguage* in the manifest is 'en' the file should contain only English text.
If you need multi-language support you can translate the .properties file to other
languages and create new files holding the ISO 639 language postfix. E.g. the French
translation would be written in First_fr.properties.

### HTML

In the HTML file (First.html) all static content is written. If you need access to the
localized text in the properties files you can use ${KEY}. Loading the ELO App
will dynamically replace those by the text in the requested language (or the 
*defaultLanguage* if the requested language is not available) file with the given key.
On startup the files input will be loaded into the memory, the key will be replaced
with the localized text from the requested language and then the content will be
loaded into the body tag of the apps HTML page.

### JavaScript

The JavaScript file (app/First.js) already contains some script code.

    (function(){
    	'use strict';
    
    	api.namespace('my.custom.First');
    
    	my.custom.First.onLoad = function(){
    
    		// Put your Javascript on start code here...
    		api.webapps.WebApp.showToast(api.helpers.Text.getText('APP.NAME'),
                    'just wants to say Hello World!', api.webapps.WebApp.TOAST_TYPE.INFO, 3);
    	};

    }());

The code is wrapped inside a function call with the **'use strict';** declaration
in order to enable Strict Mode. It is recommended to always use Strict Mode when
writing JavaScript code that is running in a browser. For more information about
 the Strict Mode see [here](http://www.w3schools.com/js/js_strict.asp).

The script creates a JavaScript the object **my.custom.First** as namespace using 
**api.namespace**. All needed global variables should be defined under this namespace
 to prevent name collisions.

Next an **onLoad** function is implemented by displaying a toast by calling 
**api.webapps.WebApp.showToast**. This function gets called after every script was
loaded and executed. So if no AngularJS is used, here is a good place load data
 from the Indexserver etc.

After all scripts are loaded and if configured, a session to the indexserver is 
established, the **onLoad** function gets called. It is called with an empty object
as parameter. This object can be altered to control the further loading process,
by adding different parameter:

- **[keepLoadingScreen]**: Set to true will not disable the loading screen. The
developer has to do this on its own by calling api.webapps.WebApp.hideLoadingScreen.
- **[disableNgBootstrap]**: In case of an app having **useDefaultModules** set to
true in its manifest. This parameter will prevent the call to start the
AngularJS bootstrap execution.

Both parameters are needed if asynchronious calls are made inside the **onLoad**
function.

**Please note:** The keep your ELO App compatible with future release do not 
use any internal methods or object. Only methods and objects provided by this 
API documentation can be used. As a rule of thumb only methods and object under 
the api. namespace will be supported, especially the elo. namespace is for 
internal use only and can differ in each version (in addition to the JSON API).

### CSS

The CSS file (resources/css/First.css) already contains some classes. First a
default font type is set to ensure all apps are using the same font. Furthermore
the styles for the toast messages are also stored here.
If you want to customize the toast messages alter the classes here or just add
your CSS code below.

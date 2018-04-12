# ELO App

## Introduction

This guide explains the basic terms and technical backgrounds of an ELO App.  

An ELO App is a single page web application, that provides easy access to the ELO
functionality by scripting APIs and the Indexserver JSON API. An App can be 
generated via the ELO App Manager by filling out the manifest containing basic
metadata information. Submitting the manifest will create a folder containing an
 already running app. To customize the app a developer can add JavaScript, CSS
files or expand its functionality by loading ELO, third party or his own
modules (see below).

## App Manifest

The manifest of an app is a JSON data object holding the metadata informations
of the app. The metadata information is:

- **[id]**: A technical string to identify the app. 
- **[namespace]**: A dot-separated namespace string (like Java packages). Together
with the id it builds the unique apps full name. The namespace must be a valid JavaScript namespace (no digit after a dot).
- **[version]**: The last version string used to checkin the app into the archive (see app life cycle).
- **[build]**: (read-only) An internal build number.
- **[defaultLanguage]**: A ISO 639-1 two letter language, that is used as default language.
The generated locale properties is assumed to be in that language.
- **[status]**: (read-only) An internal constant holding the status of the app in the life cycle
(it will get updated automatically, so it is possible that the value in the manifest is already out of date).
- **[supportedLocales]**: (read-only) A list of ISO 639-1 two letter languages that is automatically computed by
reading the files from the locales folder.
- **[useEloSession]**: Flag to decide if a ticket should be evaluated starting the app,
 and to redirect to a login page if no ticket is available. If set to true the
 elo-session module should be used.
- **[useDefaultModules]**: Flag to decide if the app uses the default frameworks (AngularJs and Bootstrap).
In this case additional the ng-app attribute is set in the HTML tag of the apps web page. 
<!--- TODO What modules are used here -->
- **[jsLibs]**: A string array containing the relative paths (inside the app folder 
of the ELO App) of the JavaScript files that will get loaded in that order.
- **[cssLibs]**: A string array containing the relative paths (inside the resources/css folder 
of the ELO App) of the CSS files that will get loaded in that order.
- **[modules]**: A string array containing the id names of the modules that will get loaded in that order.
Be aware in order for a module to get loaded it must exist and be deployed in the modules folder.
- **[configFiles]**: An object array to load additional json configuration files from the archive into the app.
The object contains:
    - *[id]*: A string id to identify the configuration data in the app (see [App specific configuration](#!/guide/core_02_app_configuration)).
    - *[name]*: A string name to identify the configuration file in the archive under Administration/ELOapps/Configuration.
- **[concatenate]**: **Since 9.03.002** Boolean flag to concatenate the array of **jsLibs** into one file during the build phase.
This file is then used every time the app gets loaded except if it is loaded with the debug flag. 
- **[minimize]**: **Since 9.03.002** Boolean flag to minimize the concatenated JavaScript code of this app during the build phase.
Minimizing code can lead to errors especially when it comes to AngularJS. For an 
instruction how to build code that can be minimized in AngularJS please 
read [here](https://docs.angularjs.org/tutorial/step_05#a-note-on-minification).

Here the example of the manifest file of the elo.session.Test app:
{@img app_manifest.PNG ELO App manifest file}

## App Life Cycle

ELO apps are stored in two places:

- The archive under Administration/ELOapps/Apps
- The deployed_apps folder in the directory configured as dataDir in the ELOwf config.xml file

ELO apps can have the following status:

- **[In development]** An app always gets generated in the local dataDir folder. 
It has the status 'in development'. If the app needs an ELO session (useEloSession
flag is true) it can only be accessed via users holding the Administrator user right.
The next steps for an app in development are: 
  - *[Archiving]* This stores the app into the archive, it remains in the local data folder, the status is set to 'Installed'.
  - *[Removing]* Deletes the app from the dataDir, all data is lost.
- **[Installed]** Installed apps are productive ready versions. The app is located
in the data directory and the archive (having the same build version on both locations).
The next steps for an installed app are: 
  - *[Edit]* Increases the internal build number and sets the status to 'in development'.
  - *[Deinstallation]* Deletes the app from the dataDir, changes its status to 'archived'.
  - *[Removing]* Deletes the app from the dataDir and the archive, all data is lost.
- **[Archived]** Archived apps are only located in the archive. They cannot be accessed.
The next steps for an archived app are:
  - *[Installation]* Copies the app into the dataDir, changes its status to 'installed'.
  - *[Removing]* Deletes the app from the archive, all data is lost.

## Structure

An ELO App is a folder with the apps full name (i.e. the namespace plus the id).

{@img app_structure.PNG ELO App local file structure}

In the local dataDir an app has the internal following structure:

- **[manifest.json]**: The manifest file in json format. This file holds the metadata
 information like described above.
- **[&lt;app id&gt;.html]**: The HTML snippet file (in the screenshot Test.html). It
 contains html code, that gets inside the body tag of the apps web page.
 Here the user can access the properties file by using curly brackets and a key
 (e.g. {APP.NAME} to include the text with key APP.NAME from the locales properties file).
**Please note**: Do not delete the predefined HTML file, also ELO cannot archive empty files.
So if the file is not needed just write a comment in it: ``<!-- not used -->``.
- **[locales]**: In this folder the apps locale file and all translations will be stored.
Generating an app the properties file gets written &lt;app id&gt;.properties. According
 to the defaultLanguage in the manifest the content of this file has to be in
 that language. Additional .properties files can be added in other languages by
 adding _&lt;language&gt; to the file (e.g. &lt;app id&gt;_fr.properties for the french version).  
**Please note**: All locale files should be stored in UTF-8 encoding to ensure correct rendering of
special characters.
- **[resources]**: This folder contains all static resources needed in the app
 by creation it consosts of two subfolders:
  - **[css]**: Holding all CSS files. Here a predefined &lt;app id&gt;.css file gets created.
This file will always be loaded on startup. All other style files that should be loaded
 during startup must be registered in the manifest file.  
**Please note**: Do not delete the predefined css file, also ELO cannot archive empty files.
So if the file is not needed just write a comment in it: ``/* not used */``.
  - **[images]**: Holding all image files. Images can be linked from the css files via relative paths.
- **[app]**: This folder holds all app-specific script files. Here a predefined 
&lt;app id&gt;.js file is used as entry point for script execution. This script
 will get loaded last on page startup. All other script files that should be loaded
 during startup must be registered in the manifest file.  
**Please note**: Do not delete the predefined js file, also ELO cannot archive empty files.
So if the file is not needed just write a comment in it: ``/* not used */``.
- **[build]**: The build folder (not in screenshot) is a dynamic generated folder
 that holds all additional build data. Here the JavaScript locale files are generated
 from the properties files. **Since 9.03.002** it may hold minified versions of the
 JavaScript code. The js file using the full name of the ELO app (namespace <dot> id)
is the concatenated JavaScript code from jsLibs. The file containing *.min.js* is the
minimified version of the concatenated file (both only exists if the **minimize** flag is set in the apps manifest).
Files ending with an language (e.g. *.de.js*) hold the completely build JavaScript code
for that ELO App including all module JavaScript code. These files are created for all 
supported language if the **concatenate**  flag is set in the apps manifest.

When archiving an ELO App all the above folders (except the build folder, that will be
 created every time the ELO App gets installed) will be written to the archive.
Additional an folder **access** is created. The ELO access right on this folder are
 used to decide if a user is allowed to use the ELO app.  
**Please note**: To check if an user is allowed to access an ELO Apps he must 
have a valid ELO session. So only ELO Apps with the manifest flag **useEloSession**
get checked.

{@img app_archive_structure.PNG ELO App archive structure}

## Loading an App

When the ELO App gets loaded the html page will dynamically get created including:

- Dynamic JavaScript data
    - url parameters
    - feature/dpi detection
    - server settings
    - app specific configuration JavaScript objects
- The Html snippet file containing the correct language replacements

- The apps locale JavaScript file
- The core JavaScript files 
    - communication
    - helpers 
    - etc
- The modules JavaScript files with all dependencies
- The apps configured script files
- The apps default JavaScript file

- The modules CSS files with all dependencies
- The apps configured CSS files
- The apps default CSS file

Having the html page delivered will start the script loading process.
Scripts get loaded in parallel but executed in the correct sequence.

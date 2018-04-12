# Module

## Introduction

This guide explains the basic terms and technical backgrounds of a module. 

A module is a set of files, that can can be reused inside any ELO App. 
Typically a module consists of JavaScript and/or CSS files. The module registers
all files that must be loaded inside the HTML of an ELO App can be registered
inside the module manifest file.

## Module Manifest

The manifest of a module is a JSON data object holding the metadata informations
of the module. The metadata information is:

- **[id]**: A technical string to identify the module (by convention it is a dot separated name). 
- **[defaultLanguage]**: [Optional] A ISO 639-1 two letter language, that is used as default language.
The generated locale properties is assumed to be in that language. If the module
 itself does not need text localization, the default language should be empty.
- **[status]**: (read-only) An internal constant holding the status of the module in the life cycle
(it will get updated automatically, so it is possible that the value in the manifest is already out of date).
- **[jsLibs]**: A string array containing the relative paths (inside the folder 
of the ELO Module) of the JavaScript files that will get loaded in that order.
- **[jsDebugLibs]**: **Since 9.03.002** [Optional] A string array containing the relative paths (inside the folder 
of the ELO Module) of the JavaScript files that will get loaded in that order. 
If this entry exists it will be used instead of **jsLibs** if the debug flag is set when the app is loading.
- **[cssLibs]**: A string array containing the relative paths (inside folder 
of the ELO Module) of the CSS files that will get loaded in that order.
- **[modules]**: A string array containing the id names of the module dependencies that will get loaded in that order.
Be aware in order for a module to get loaded it must exist and be deployed in the modules folder.
- **[minimize]**: **Since 9.03.002** Flag to minimize the JavaScript code of this module during the build phase.
Minimizing code can lead to errors especially when it comes to AngularJS. For an 
instruction how to build code that can be minimized in AngularJS please 
read [here](https://docs.angularjs.org/tutorial/step_05#a-note-on-minification).
- **[noArchiving]**: **Since 9.03.002** Flag to disable the button to archive the module in ELO App Manager.
This flag must be set manually in the manifest.json file. It is used for imported 
modules that should not be overwritten by accident.

Here the example of the manifest file of the elo.module.components.01 module:

{@img module_manifest.PNG ELO Module manifest file}

## Module Life Cycle

Like ELO apps the modules have the same lifecycle. They are stored in two places:

- The archive under Administration/ELOapps/Modules
- The modules folder in the directory configured as dataDir in the ELOwf config.xml file

ELO modules can have the following status:

- **[In development]** A module always gets generated in the local dataDir folder. 
It has the status 'in development'.
The next steps for a module in development are: 
  - *[Archiving]* This stores the module into the archive, it remains in the local data folder, the status is set to 'Installed'.
  - *[Removing]* Deletes the module from the dataDir, all data is lost.
- **[Installed]** Installed modules are productive ready versions. The module is located
in the data directory and the archive.
The next steps for an installed module are: 
  - *[Edit]* Sets the status to 'in development'.
  - *[Deinstallation]* Deletes the module from the dataDir, changes its status to 'archived'.
  - *[Removing]* Deletes the module from the dataDir and the archive, all data is lost.
- **[Archived]** Archived modules are only located in the archive. They cannot be accessed.
The next steps for an archived module are:
  - *[Installation]* Copies the module into the dataDir, changes its status to 'installed'.
  - *[Removing]* Deletes the module from the archive, all data is lost.

## Structure

A ELO Module is a folder with its id as name.

{@img module_structure.PNG ELO Module local file structure}

The structure inside is as follows:

  - **[manifest.json]**: The manifest file in json format. This file holds the metadata
 information like described above.
  - **[locales]**: Given a defaultLanguage this folder gets craeted. In it the modules
 locale file and all translations will be stored. Generating the module the 
properties file gets written &lt;module id&gt;.properties. According
 to the defaultLanguage in the manifest the content of this file has to be in
 that language. Additional .properties files can be added in other languages by
 adding _&lt;language&gt; to the file (e.g. &lt;module id&gt;_fr.properties for the french version).
  - **[build]**: The build folder (not in screenshot) is a dynamic generated folder
 that holds all additional build data. Here the JavaScript locale files are generated
 from the properties files. **Since 9.03.002** it may hold minified versions of the
 JavaScript code. The js file using the module name is the concatenated JavaScript
 code from jsLibs. The file containing *.min.js* is the minimified version of the
 concatenated file (both only exists if the **minimize** flag is set in the modules manifest).

JavaScript libraries often bring there own structure so referencing them in the 
manifest is done from the modules main folder.

When archiving an ELO Module all the above folders (except the build folder, that will be
 created every time the ELO Module gets installed) will be written to the archive.


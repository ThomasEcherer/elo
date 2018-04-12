# ELO App Manager

The ELO App Manager enables the Administrator to create, edit, archive and publish
ELO Apps and Modules, publish Client Infos to display ELO Apps or web pages inside
the client.

## General Appearance

The ELO App Manager is separated into two parts, on the left (1) the lists of ELO Apps,
Modules or client infos are displayed. On the right (2) a view provides detailed 
information to a set of selected items from the list views.

{@img appmanager.PNG Alt ELO App Manager}

In the system toolbar (3) all lists can be refreshed from the server via the refresh button, 
and new ELO Apps, Modules or client infos can be created.

{@img appmanager_toolbar.PNG Alt ELO App Manager Toolbar}

In the lists on the left an object can be selected to open its detail views and
alter its life cycle.

## ELO Apps

For an introduction to the basic concepts of an ELO App, please have a look into
the guide [ELO App](#!/guide/basic_01_elo_app).

New apps can be created with the button in the toolbar. A form will be displayed
in the details view of the ELO App Manager.

More information about creating an ELO App can be found in the guid 
[Creating the first ELO App](#!/guide/core_01_first_app).

### Actions 

The actions represent the changes in the app life cycle (see ELO App guide).

{@img apps_cleanBuild_16.png Alt Build} (Re)Creates the dynamic build folder of the app.

{@img apps_archivieren_16.png Alt Archiving} The app is archived.

{@img apps_installieren_16.png Alt Installation} The app gets installed.

{@img apps_deinstallieren_16.png Alt Deinstallation} The app gets uninstalled.

{@img apps_loeschen_16.png Alt Delete} Delete the app.

### Details View

The details view of the app is a form to create the apps manifest file.

{@img app_details.PNG Alt ELO App Manager App Details}

Some fields (like name, namespace and id) are only editable when the app is created.
This is since the app structure strongly relies on these values, so changing them
afterwards will result in a new app.

Scripts, Stylesheets and Modules can be added via the three lists (click on the plus sign).
An entry can be removed via the X icon on the right of the script.
Via drag&drop the order can be changed.

**Please note**: The loading order is very important when it comes to dependencies,
 so if script files are loaded that depend on each other, bringing them into the
 correct order is essential.

## Module

For an introduction to the basic concepts of an Module, please have a look into
the guide [Module](#!/guide/basic_02_module).

New Modules can be created with the button in the toolbar. A form will be displayed
in the details view of the ELO App Manager.

### Actions 

The actions represent the changes in the Modules life cycle (see Module guide).

{@img apps_cleanBuild_16.png Alt Build} (Re)Creates the dynamic build folder of the Module.

{@img apps_archivieren_16.png Alt Archiving} The Module is archived.

{@img apps_installieren_16.png Alt Installation} The Module gets installed.

{@img apps_deinstallieren_16.png Alt Deinstallation} The Module gets uninstalled.

{@img apps_loeschen_16.png Alt Delete} Delete the Module.

### Details View

The details view of the Module is a form to create the Modules manifest file.

{@img module_details.PNG Alt ELO App Manager Module Details}

Module ID field is only editable when the Module is created.
This is since the Modules structure strongly relies on its id, so changing them
afterwards will result in a new Module.

The default language of Modules is optional. It depends if your Module scripts
need to have localized strings. If it is set, a locales folder will be created 
in the Modules structure. 

Scripts, Stylesheets and dependent Modules can be added via the three lists (click on the plus sign).
An entry can be removed via the X icon on the right of the script.
Via drag&drop the order can be changed.

**Please note**: The loading order is very important when it comes to dependencies,
 so if script files are loaded that depend on each other, bringing them into the
 correct order is essential.

## Client Info

For an introduction to the basic concepts of an ELO Client Info, please have a look into
the guide [Client Info](#!/guide/basic_03_clientinfo).

New Client Infos can be created with the button in the toolbar. A form will be displayed
in the details view of the ELO App Manager.

### Actions 

After saving a new created Client Info it will directly be written into the archive.
Setting ELO read access to the archive folder will enable it to be accessed for other users.

The actions represent the changes in the Client Infos life cycle.

{@img apps_loeschen_16.png Alt Delete} Deletes the Client Info from the archive.

### Details View

The details view of the Client Info is a form to configure the clients behaviour.

{@img clientinfo_details.PNG Alt ELO App Manager Module Details}

Client Info ID field is only editable when the Client Info is created.

The first block represents the content of the web view that should be integrated into the clients.
Here either a ELO App or a url and the name can be specified. The second block
 specifies how the web view will be integrated into the clients.
If empty it will be embeeded as new region, given a mask or id selector it will
 be visible in the document view for all entries matching the id or mask.

## Refresh Button

The refresh button will read all ELO Apps, Modules and ClientInfo from the archive
 and locale data directory and compare the manifest files in order to check if their
build number differ. Accordingly all caches will be reloaded including the App
configuration entries.

The refresh button will not rebuild Apps or Modules, so changes in locale files will not have any affect.
This is done via the build button in the grid menu of Apps or Modules.

### Refresh Configuration

The App specific configuration files are stored in the archive but to prevent 
reading them every time an ELO App is loaded they will be chached. 
For more information see [App specific configuration](#!/guide/core_02_app_configuration).

With this button all archived JSON configuration files will be reloaded into cache.

### Refresh Archiveicons

Archived icons can be used in ELO Apps or for tiles in the clients. The are 
stored in the archive as .ico files. In order to use them in a web page they must
be converted into .png images.
For more information see [elo.module.icons](#!/guide/module_02_icons).

With this button the images are taken from the archive and built.

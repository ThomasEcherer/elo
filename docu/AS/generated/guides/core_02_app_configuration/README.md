# App specific configuration

This guide explains how to store JSON data for a specific ELO App into the 
archive and access it in the running app.

## Introduction

If an ELO App needs static data as configuration (e.g. a mask name, a folder guid,
a workflow template id etc.) it is a bad idea to write this data into the 
JavaScript code of the app. Instead it should be stored in the archive, so it 
can be modified without changing the ELO App itself.

## Archive configuration folder

The ELO Apps will create several folders inside the Administration folder. One 
is called Configuration. To store app specific configuration data a JSON text 
file can be created with any name short description. The content
of the document must be a JSON object. In order for an app to load any number 
of those configuration files a *configFiles* object has to be added in the apps 
manifest. The ELOwf will cache all those JSON documents and transmit the data
to the ELO App when it is loading. Be aware because of that cache the server does
 not need to access the archive every time the ELO App should be loaded.
But changing the archive JSON file needs an refresh in the ELO App Manager.

{@img archive_config_folder.PNG Alt Configuration folder in the archive}

## Adding a configuration file into the Apps manifest

To add a configuration file to an App it must be added to the manifest. Therefore
in the ELO App Manager in the Details View a number of files can be added by 
giving them IDs.

{@img appmanager_add_config.PNG Alt Adding configurations to the App}

## Access data inside the app

Inside the ELO Apps JavaScript code the data can be accessed with the configured
ID from the manifest using api.helpers.Configuration singleton.

    var test = api.helpers.Configuration.has("config");
    // test is true
    test = api.helpers.Configuration.get("config");
    // test is { docId: 537, parentId: 536 }

**Please note**: If the JSON data inside the document is altered the
changes will not take effect until the caches are reloaded (this can be done via
the refresh button inside the ELO App Manager).
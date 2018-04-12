# Localization

This guide explains the possibilities to localize ELO Apps and modules.

## Properties files

ELO Apps provide a *locales* folder that contains a properties file. Properties 
files are used in the Java Programming language. Basically a Properties file is 
a text file containing a list of key-value pairs. Each pair is stored in one line,
the key is separated from the value by *=*. For each language a separate file is
created using the ISO 639 two letter language (e.g. myApp.properties -> myApp_fr.properties).
The default file is expected to contain the text in the language given by the 
*defaultLanguage* attribute of the ELO App. 

**Please note**: All properties files are stored with UTF-8 encoding.

**Please note**: Only the two letter *language* for the properties files are supported
not additional *country* or *variant* specific files.

## In ELO Apps

In all ELO Apps a properties file for the *defaultLanguage* of the app get created.
The files name is the id of the ELO App. This file already holds the display name
of the ELO App. Changes on the properties file needs a rebuild of the app in the
ELO App Manager in order to build the JavaScript locale files.

An ELO App chooses its language on load by the following order:
- If there is a url parameter **lang** given the two letter language is used from its value.
- Else the language of the request locale header is used.

The language will be evaluated if it is supported, i.e. if there is a properties
file for that language. If not the *defaultLanguage* is used.

Typically the language setting comes from:
- The chosen language in the apps login screen
- The client language if the app is embedded inside a client

### HTML

In the static html snippet file localized text can be added using **${key}**, 
where key is a key in the properties file. When the app gets loaded the html 
snippet will be parsed and all occurences will be replaced by the requested 
languages text.

### JavaScript

For JavaScript the properties files get rewritten to according JavaScript files 
holding an JavaScript object containing the localized text. Only the script with
the requested language gets loaded in the app, so accessing other languages on 
runtime is not possible.

To get a localized text from a given key the api.helpers.Text method can be used.
Here also dynamic values can be placed in predifined gaps in the localized text.
(E.g. if *APP.WELCOME=Welcome {0}* is one pair in the properties file:

    var text = api.helpers.Text.getText('APP.WELCOME', 'Ben');
    // text is Welcome Ben

### AngularJS templates 

In order to use the localized text in AngularJS templates, the AngularJS Filter 
**eloLocales** can be used from the elo.module.components module.

    <h1>{{ "APP.WELCOME" | eloLocales:userName }}</h1>

Where userName is a scope variable holding the string 'Ben' from the example above.
If no dynamic key is used *:userName* can be omitted.

## In ELO Modules

ELO modules by default do not have a locales folder with an properties file created.
If the *defaultLanguage* of a module is set in the manifest a locales folder is 
expected and the module the build process will try to create JavaScript locale files.
The properties file will have the name of the modules id in camel case notation 
(dots are replaced).

**Please note**: If the *defaultLanague* of a module is set, the locales folder 
is expected to be existing and containing at least the default properties file.

## Conflicts

**Please note**: In order to identify the correct text inside **all** loaded 
properties JavaScript files, the keys has to be unique in **all** files.
It is suggested to use **APP.** prefix for all keys of the ELO Apps properties file.
And for each module a separate prefix.

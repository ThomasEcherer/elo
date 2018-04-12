# Client Info


## Introduction

This guide explains the basic terms and technical concepts of a client info object.  

A client info object is a metadata file that holds information when and where to
show a web view inside an ELO client. Usually it is used to display ELO Apps, but
it is not restricted to do so. Basically any Url can be displayed inside the ELO client.

## Client Info File

The client info file is a JSON data object holding the settings how to display 
embed the web view or configure the client. The metadata information is:

- **[id]**: A technical string to identify the client info object (the archive entry gets the id as short description). 
- **[web]**: [Optional] A object holding the information about the web site to embed in the client. The object holds:
    - *[id]*: [Optional] The id of the ELO App embed in the client (if set a namespace is also required).
    - *[namespace]*: [Optional] The namespace of the ELO App embed in the client (if set a id is also required).
    - *[url]*: [Optional] Any url to load (if set id and namespace are not required).
    - *[name]*: The display name for the app/url in the client (tab or region). In case of an ELO App the app name is used, in case of an url a name must be given.
    - *[eloSession]*: A boolean flag if the client should set the typical parameters (ticket, locale etc.) when loading the web site.
- **[view]**: A object holding the information about where to place the web site in the client. The object holds:
    - *[type]*: A string constant. Possible values are:
        - [REGION]: To embed the webview as region.
        - [DOCVIEW]: To configure/add the web site to the clients document view.
    <!--- - *[position]* TODO -->
    - *[show]*: [Optional] A string constant to configure the document view (only for type DOCVIEW). The possible values are:
        - [CONTENT]: To display the folder/document.
        - [CONTENT_FEED]: To display the folder/document and document feed.
        - [CONTENT_FORM]: To display the folder/document and form.
        - [CONTENT_FORM_FEED]: To display the folder/document, form and document feed.
    - *[focus]*: [Optional] A string constant to focus one view in the document view (only for type DOCVIEW). The possible values are:
        - [CONTENT]: To focus the folder/document tab.
        - [FEED]: To focus the feed tab.
        - [FORM]: To focus the form tab.
        - [APP]: To focus the app tab.
        - [INDEX]: To focus the index tab.
        - [FULLTEXT]: To focus the fulltext tab (only in JavaClient).
- **[selector]**: A object holding the information about when to configure/add the web site to the clients document view.
    - *[mask]*: A string guid of a mask, the configuration triggers if any entry with this mask is selected.
    - *[ids]*: A string array of entry guids, the configuration triggers if any entry with one of these ids is selected. 
    - *[arcPath]*: A string to identify a sord object, all strings are valid that can be used 
        as objId parameter in the checkoutSord method of the Indexserver documentation (e.g. ID, GUID, Archive path, MD5 hash etc.).
        Using arcPath value a checkoutSord is called and add the guid of the returned sord will be added to the ids array.

Here the example of the client info file to embed wikipedia in a web view as region:

{@img clientinfo_wikipedia.PNG ELO client info file}

## Client Info Life Cycle

Client Info files do not have a lifecycle. They get written into the archive in
Administration/ELOapps/ClientInfos. Every user who has read access to the file 
will get configuration/web site in his client.

## Creating a Client Info

There are two reasons to create a client info object:

1. To embed a web view inside a client. In order to display an ELO App or any other web site.
2. To configure the clients document view for a selected mask or specific entry.

As reference see

{@img clientinfo_app_manager.PNG ELO client info file}

### Create a Client Info to embed a web view

- Click on "Add Client Info" to open an empty form.
- Choose a **Client Info ID** for the client info object.
- Select either the app to embed in the **App ID** dropdown or the Url of the web
 site in the **URL** text field.
- If a web view is added by an url, the **Display name** is also required. It is
 displayed in the client. (Apps get their display name from the APP.NAME key in their language files).
- If an App is embedded and it needs an ELO session to run, make sure the **ELO logon required** box is checked.
- If the web view should appear as tile (view.type = REGION) the form can be saved.
- If the web view should be displayed in the document view (view.type = DOCVIEW) at least one selector must be given.
    - Choose a form in **Form selector** dropdown, if the web view should be visible every time an entry with this form is selected.
    - Give a comma separated list of guids in the **ID selector** to display the web view, if an entry with one of the ids is selected.
    - Give an archive path string as defined in the Indexserver Api documentation for the *checkoutDoc* method.
- Optional the fields **Preferred view** and **Field in focus** can be used to
 configure the document view of the clinet if the web view is visible.

### Create a Client Info to configure the document view

- Click on "Add Client Info" to open an empty form.
- Choose a **Client Info ID** for the client info object.
- Leave the **Embedding a WebView** box empty.
- To define for what selected entries the configuration should be applied at least one selector must be given.
    - Choose a form in **Form selector** dropdown, if the configuration should be applied every time an entry with this form is selected.
    - Give a comma separated list of guids in the **ID selector** to apply the configuration, if an entry with one of the ids is selected.
    - Give an archive path string as defined in the Indexserver Api documentation for the *checkoutDoc* method.
- Set a **Preferred view** from the dropdown to ensure the selected viewers are visible if a selector above matches. 
- Set the **Field in focus** from the dropdown to ensure the selected tab gains focus if a selector matches.

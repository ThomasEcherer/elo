# elo.module.session

This guide explains the use of the **elo.module.session** module.
This module is directly connected to the **useEloSession** flag in the manifest of 
an ELO App. So if this flag is set in the ELO App Manager, the module will be
added to the list of modules for this ELO App.

**Please note**: This module will not work correctly without the **useEloSession**
flag in the manifest of the ELO App.

## useEloSession

Besides adding the module to the list the **useEloSession** flag tells the system
that this ELO App needs an ELO session in order to work correctly. In other words:
The ELO App wants to access the archive or use ELO functionality in any way.

If the flag is set the ELO App can only be accessed if there is a valid ELO 
session ticket available. If the ELO App is running inside client 
(embedded by a [Client Info](#!/guide/basic_03_clientinfo).) such a ticket is
 provided as Url parameter. The parameter gets evaluated, the access to the 
ELO App is checked and if everything is alright the ELO App gets loaded. Loading 
the ELO App will transmit the ticket to the browser using a HTML cookie.

If no ticket is available or the ticket is invalid. The system (i.e. the ELOwf)
will redirect the call of an ELO App to a Login page. Here the user can login 
manually in order to create a new ticket.

{@img login_app.PNG ELO Login app}

After a successful login the user gets redirected to the original ELO App.

## Restrict access to ELO Apps

If there is a valid ELO login for an ELO App it can be checked if the user is 
allowed to use the app. Therefore each archived/installed ELO App containing the 
has an *access* folder in its archive structure. Every time an ELO App containing 
**useEloSession** flag gets loaded the access is checked:

- If the ELO App has status development only users holding Administrator right
will have access. This holds also for the ELO App Manager app.
- If the ELO App is installed all users having read access on the *access* 
folder gain access to the ELO App.

## Starting the App

When the ELO App gets loaded with a valid ticket the html page will dynamically 
get created. If the elo.module.session module is loaded it directly starts to 
connect to the indexserver. Since this is a asynchronious request the other 
scripts continue to load. 
Only if the DOMContentLoaded event **and** the connection to the indexserver is 
established the *onLoad* function of the app will get executed. Here the IXConnection
object can be accessed via *api.IX*. After the *onLoad* function the loading 
screen will be hidden.

## JavaScript libraries

The elo.module.session module provides static helper functions to simplify the
communication to the indexserver (see package api.ix):

- **[api.ix.DateUtils]**: Basic date transformation from/to ELO iso date format.
- **[api.ix.ListUtils]**: Helpers to retrieve user, mask, task and sord lists.
- **[api.ix.SordUtils]**: Helpers regarding sord objects.
- **[api.ix.TaskUtils]**: Helpers regarding user task and workflow objects.
- **[api.ix.UserUtils]**: Helpers regarding users.
- **[api.ix.EloUtils]**: Additional helpers.

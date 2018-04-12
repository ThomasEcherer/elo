# elo.module.component

This module provides support for ELO Apps using AngularJS.
This module is directly connected to the **useDefaultModules** flag in the manifest of 
an ELO App. So if this flag is set in the ELO App Manager, the module will be
added to the list of modules for this ELO App.
This module has dependencies to AngularJS and further third party scripts.

**Please note**: We encourage the use of AngularJS in ELO Apps and provide 
front-end components only for AngularJS.

## useDefaultModules

This flag marks the use of AngularJS in the ELO App. The flag causes slight 
changes in the apps loading behavior. Also additional AngularJS specific code 
gets created in the apps default JavaScript file. 

Since AngularJS provides the app with its controller concept the *onLoad* function
code should be relocated inside the AngularJS controller of the ELO app.
Therefore onLoad will be executed before AngularJS will bootstrap its components
and start working. So the *onLoad* function of an ELO App having the 
**useDefaultModules** flag set can be used to apply changes before the normal 
AngularJS bootstrap.

The *onLoad* function gets called with an empty object as parameter. If the property
*disableNgBootstrap* is set to true in the onLoad function. The bootstrap method
will not be called automatically after the execution of the *onLoad* function.
This is needed if asynchronious calls have to be made in the *onLoad* function.

## Components

The module further defines directives, services, and filters to provide basic
components providing simple default behaviour.

For further details see: api.module.Components.



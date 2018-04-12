# JSHint-Konfiguration

<span
style='color:black'>Als einheitlicher Standard für validen JS-Code wird das Analysetool </span><span
style='font-weight:bold;font-style:italic;color:black'>JSHint</span><span
style='color:black'> verwendet. Weitere Informationen gibt die offizielle </span><a
href="http://jshint.com/docs/">Website</a><span style='color:black'>.</span>

## JSHint-Konfiguration in Eclipse setzen

Die Entwicklungsumgebung Eclipse bietet über ein Plugin die Möglichkeit, JS-Dateien mit JSHint zu prüfen. Hier kann im Dialog <span
style='font-weight:bold;font-style:italic'>Preferences</span> eine Konfiguration hinterlegt werden:

{@img img1.png}

## Konfiguration JSHint

    {
        "maxerr"        : 50,       // {int} Maximum error before stopping
     
        // Enforcing
        "curly"         : true,     // true: Require {} for every new block or scope
        "forin"         : true,     // true: Require filtering for..in loops with obj.hasOwnProperty()
        "immed"         : false,    // true: Require immediate invocations to be wrapped in parens e.g. `(function () { } ());`
        "indent"        : 2,        // {int} Number of spaces to use for indentation
        "newcap"        : false,    // true: Require capitalization of all constructor functions e.g. `new F()`
        "noempty"       : true,     // true: Prohibit use of empty blocks
        "nonbsp"        : true,     // true: Prohibit "non-breaking whitespace" characters.
        "nonew"         : false,    // true: Prohibit use of constructors for side-effects (without assignment)
        "quotmark"      : false,    // Quotation mark consistency:
                                    //   false    : do nothing (default)
                                    //   true     : ensure whatever is used is consistent
                                    //   "single" : require single quotes
                                    //   "double" : require double quotes
        "undef"         : true,     // true: Require all non-global variables to be declared (prevents global leaks)
        "unused"        : false,    // true: Require all defined variables be used
        "strict"        : false,    // true: Requires all functions run in ES5 Strict Mode
        "maxparams"     : false,    // {int} Max number of formal params allowed per function
        "maxdepth"      : false,    // {int} Max depth of nested blocks (within functions)
        "maxstatements" : false,    // {int} Max number statements per function
        "maxcomplexity" : false,    // {int} Max cyclomatic complexity per function
        "maxlen"        : false,    // {int} Max number of characters per line
     
        // Relaxing
        "asi"           : false,     // true: Tolerate Automatic Semicolon Insertion (no semicolons)
        "boss"          : false,     // true: Tolerate assignments where comparisons would be expected
        "debug"         : true,      // true: Allow debugger statements e.g. browser breakpoints.
        "eqnull"        : false,     // true: Tolerate use of `== null`
        "es5"           : false,     // true: Allow ES5 syntax (ex: getters and setters)
        "esnext"        : false,     // true: Allow ES.next (ES6) syntax (ex: `const`)
        "funcscope"     : false,     // true: Tolerate defining variables inside control statements
        "globalstrict"  : false,     // true: Allow global "use strict" (also enables 'strict')
        "lastsemic"     : false,     // true: Tolerate omitting a semicolon for the last statement of a 1-line block
        "laxbreak"      : false,     // true: Tolerate possibly unsafe line breakings
        "laxcomma"      : false,     // true: Tolerate comma-first style coding
        "loopfunc"      : false,     // true: Tolerate functions being defined in loops
        "multistr"      : false,     // true: Tolerate multi-line strings
        "noyield"       : false,     // true: Tolerate generator functions with no yield statement in them.
        "notypeof"      : false,     // true: Tolerate invalid typeof operator values
        "proto"         : false,     // true: Tolerate using the `__proto__` property
        "scripturl"     : false,     // true: Tolerate script-targeted URLs
        "shadow"        : false,     // true: Allows re-define variables later in code e.g. `var x=1; x=2;`
        "sub"           : false,     // true: Tolerate using `[]` notation when it can still be expressed in dot notation
        "supernew"      : false,     // true: Tolerate `new function () { ... };` and `new Object;`
        "validthis"     : false,     // true: Tolerate using this in a non-constructor function
     
        // Environments
        "devel"         : true,     // Development/debugging (alert, confirm, etc)
        "rhino"         : true,     // Rhino
     
        // Custom Globals
        "globals"       : {},       // additional predefined global variables
     
        "-W079"         : false,    // Redefinition of '{a}'
        "-W100"         : false,    // 'This character may get silently deleted by one or more browsers'
     
        "predef": ["sol",
                   "DocMaskLineC",
                   "EditInfoC",
                   "EditInfoZ",
                   "ix",
                   "IXExceptionC",
                   "LockC",
                   "log",
                   "SordC",
                   "SordZ"]
    }

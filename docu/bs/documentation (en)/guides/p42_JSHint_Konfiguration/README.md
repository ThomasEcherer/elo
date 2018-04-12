<h1>JSHint configuration</h1>
<p><span
style='color:black'>The JSHint</span><span
style='font-weight:bold;font-style:italic;color:black'>analyze tool is used as the unified standard for valid JS code. You can obtain further information on this from the official </span><a
href="http://jshint.com/docs/">website</a><span style='color:black'>.</span></p>
<h2>Setting JSHint configuration in Eclipse</h2>
<p>The Eclipse development environment offers a plug-in that enables you to check JS files with JSHint. You can save the configuration in the <span
style='font-weight:bold;font-style:italic'>Preferences</span> dialog box.</p>
<p>{@img img1.png}</p>
<h2>JSHint configuration</h2>
<pre><code>{
    &quot;maxerr&quot;        : 50,       // {int} Maximum error before stopping

    // Enforcing
    &quot;curly&quot;         : true,     // true: Require {} for every new block or scope
    &quot;forin&quot;         : true,     // true: Require filtering for..in loops with obj.hasOwnProperty()
    &quot;immed&quot;         : false,    // true: Require immediate invocations to be wrapped in parens e.g. `(function () { } ());`
    &quot;indent&quot;        : 2,        // {int} Number of spaces to use for indentation
    &quot;newcap&quot;        : false,    // true: Require capitalization of all constructor functions e.g. `new F()`
    &quot;noempty&quot;       : true,     // true: Prohibit use of empty blocks
    &quot;nonbsp&quot;        : true,     // true: Prohibit &quot;non-breaking whitespace&quot; characters.
    &quot;nonew&quot;         : false,    // true: Prohibit use of constructors for side-effects (without assignment)
    &quot;quotmark&quot;      : false,    // Quotation mark consistency:
                                //   false    : do nothing (default)
                                //   true     : ensure whatever is used is consistent
                                //   &quot;single&quot; : require single quotes
                                //   &quot;double&quot; : require double quotes
    &quot;undef&quot;         : true,     // true: Require all non-global variables to be declared (prevents global leaks)
    &quot;unused&quot;        : false,    // true: Require all defined variables be used
    &quot;strict&quot;        : false,    // true: Requires all functions run in ES5 Strict Mode
    &quot;maxparams&quot;     : false,    // {int} Max number of formal params allowed per function
    &quot;maxdepth&quot;      : false,    // {int} Max depth of nested blocks (within functions)
    &quot;maxstatements&quot; : false,    // {int} Max number statements per function
    &quot;maxcomplexity&quot; : false,    // {int} Max cyclomatic complexity per function
    &quot;maxlen&quot;        : false,    // {int} Max number of characters per line

    // Relaxing
    &quot;asi&quot;           : false,     // true: Tolerate Automatic Semicolon Insertion (no semicolons)
    &quot;boss&quot;          : false,     // true: Tolerate assignments where comparisons would be expected
    &quot;debug&quot;         : true,      // true: Allow debugger statements e.g. browser breakpoints.
    &quot;eqnull&quot;        : false,     // true: Tolerate use of `== null`
    &quot;es5&quot;           : false,     // true: Allow ES5 syntax (ex: getters and setters)
    &quot;esnext&quot;        : false,     // true: Allow ES.next (ES6) syntax (ex: `const`)
    &quot;funcscope&quot;     : false,     // true: Tolerate defining variables inside control statements
    &quot;globalstrict&quot;  : false,     // true: Allow global &quot;use strict&quot; (also enables 'strict')
    &quot;lastsemic&quot;     : false,     // true: Tolerate omitting a semicolon for the last statement of a 1-line block
    &quot;laxbreak&quot;      : false,     // true: Tolerate possibly unsafe line breakings
    &quot;laxcomma&quot;      : false,     // true: Tolerate comma-first style coding
    &quot;loopfunc&quot;      : false,     // true: Tolerate functions being defined in loops
    &quot;multistr&quot;      : false,     // true: Tolerate multi-line strings
    &quot;noyield&quot;       : false,     // true: Tolerate generator functions with no yield statement in them.
    &quot;notypeof&quot;      : false,     // true: Tolerate invalid typeof operator values
    &quot;proto&quot;         : false,     // true: Tolerate using the `__proto__` property
    &quot;scripturl&quot;     : false,     // true: Tolerate script-targeted URLs
    &quot;shadow&quot;        : false,     // true: Allows re-define variables later in code e.g. `var x=1; x=2;`
    &quot;sub&quot;           : false,     // true: Tolerate using `[]` notation when it can still be expressed in dot notation
    &quot;supernew&quot;      : false,     // true: Tolerate `new function () { ... };` and `new Object;`
    &quot;validthis&quot;     : false,     // true: Tolerate using this in a non-constructor function

    // Environments
    &quot;devel&quot;         : true,     // Development/debugging (alert, confirm, etc)
    &quot;rhino&quot;         : true,     // Rhino

    // Custom Globals
    &quot;globals&quot;       : {},       // additional predefined global variables

    &quot;-W079&quot;         : false,    // Redefinition of '{a}'
    &quot;-W100&quot;         : false,    // 'This character may get silently deleted by one or more browsers'

    &quot;predef&quot;: [&quot;sol&quot;,
               &quot;DocMaskLineC&quot;,
               &quot;EditInfoC&quot;,
               &quot;EditInfoZ&quot;,
               &quot;ix&quot;,
               &quot;IXExceptionC&quot;,
               &quot;LockC&quot;,
               &quot;log&quot;,
               &quot;SordC&quot;,
               &quot;SordZ&quot;]
}
</code></pre>

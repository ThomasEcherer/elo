<h1>Localization</h1>
<p>Localization is an important tool when it comes to offering ELO Business Solutions in different countries or enabling multinational companies to provide foreign branches with the same solution.</p>
<p><span class="tag_warning">The translation tables in ELO provide a classical method for localizing individual words. This method is not used in ELO Business Solutions. Instead, new options have been created based on properties files that can be used by translation agencies.</span></p>
<h2>Localization using language files on the Indexserver</h2>
<p>From ELO version 9.3, properties files can also be stored in the Administration folder in ELO. These should be filed to the <code>Localization</code> folder. </p>
<p>{@img img1.png}</p>
<p>Standard components such as ELO Business Solutions are stored in the <code>system</code> folder. This folder must not be used for customizing the solutions or for own projects. Business Partners can store own localization information to the <code>custom</code> folder.</p>
<p>The advantage of this is the priority with which localization files are loaded. It is therefore possible to override translations in the <code>system</code> folder in the <code>custom</code> folder. For example, the function for creating a file in German, <span
style='font-weight:bold'>Akte anlegen</span>, can easily be changed to <span
style='font-weight:bold'>Dossier anlegen</span> to correspond to Swiss requirements.</p>
<p>Properties files are merely key value assignments. The keys can be used later on as <span
style='font-weight:bold'>locale keys</span>.</p>
<p>{@img img3.png}</p>
<p>Here are several examples of how these can be used.</p>
<h3>Workflows</h3>
<p>Workflow nodes can also be localized via locale keys. To do so, save the keys to the <code>Translation variable</code> field.</p>
<p>{@img img5.png}</p>
<p><span class="tag_important">The workflow name can also localized via the start node.</span></p>
<h3>Keywording forms</h3>
<p>The Administration Console also has a variety of localization options in the form designer, e.g. for the name of a keywording form.</p>
<p><span class="tag_caution">Please note: Keywording forms appear translated in the client but you can only access them via the Indexserver API if you specify the name. For this reason, you always need to the specify the <span
style='font-weight:bold'>original name</span> and a <span
style='font-weight:bold'>locale key.</span></span></p>
<p>{@img img7.png}</p>
<p>{@img img9.png}</p>
<h3>Forms</h3>
<p>The Indexserver localization mechanisms mean that it is possible to offer forms in different languages. All you need to do here is to store the <span
style='font-weight:bold'>locale keys</span> to the form.</p>
<p>This enables you to translate the title bars of tab groups, </p>
<p>{@img img11.png}</p>
<p>...or texts in the form.</p>
<p>{@img img13.png}</p>
<h2>Localization of client scripting</h2>
<p>There are various concepts available for localizing client scripts.</p>
<h3>Java Client scripting</h3>
<p>Localization in the Java Client is carried out using standard mechanisms. The language file (properties file) must be saved to the Scripting Base folder of the Java Client.</p>
<p>The Java Client scripts can then access the locale keys of a file.</p>
<p><span class="tag_important">The Indexserver localization mechanism is not used for this. However, the files below the localization folder can be referenced in the Java Client Scripting Base. This means they are available in both environments.</span></p>
<h3>Web Client scripting</h3>
<p>In Web Client scripting, the script must specify which localizations are required using the <code>api.require</code> function. The Web Client calls the Indexserver localization mechanism during startup and loads the required information. The Web Client API documentation contains further information on Web Client scripting.</p>
<pre><code>api.require({
    locales: ['sol.contract.client']
}, function (localesObject) {
    console.log('requirements are fulfilled');
});
</code></pre>
<p>This mechanism ensures that only the keys are loaded that are required by the scripts.</p>
<h2>Localized keyword lists</h2>
<p>ELO Business Solutions has its own mechanism for localizing keyword lists. A key is assigned to each keyword. When the keyword is returned, it appears in the client as translated.</p>
<p>The following figure shows an example of this using the document type in ELO Business Solution Invoice. The key <code>D1</code> stands for <code>Reminder 1</code>.</p>
<p>{@img img15.png}</p>
<p>A combination of both values is written to the object metadata. In this example, this is <code>D1 - Reminder 1</code>. The key can then be extracted in the scripting so it is possible to trigger language-independent operations.</p>
<p>The basis of this is a <span
style='font-weight:bold'>dynamic keyword list</span> that loads the key value pairs from the configuration and makes them available in the form or in the client, for example.</p>
<p>A configuration interface makes it easier to add and rename keywords.</p>
<p>{@img img17.png}</p>

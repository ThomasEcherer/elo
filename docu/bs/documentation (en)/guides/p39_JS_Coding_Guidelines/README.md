<h1>JS coding guidelines</h1>
<h2>Naming</h2>
<p>You should choose meaningful, pronounceable and searchable English names for variables and functions. Long, descriptive names are better than short, cryptic ones.</p>
<p>The lowerCamelCase naming convention is to be used except for constants, which are written in CAPITALS:</p>
<pre><code>var MAXUSERID = 900000;

function buildName( firstName, lastName ) {
  var me = this;
  return firstName + ' ' + lastName;
}
</code></pre>
<h2>Comments</h2>
<p>Comments are written in English and should explain what the code is for. Commented out code is only used for test scenarios and should not be left in.</p>
<p>JY is an untypified language; comments should therefore conform to JSDuck standards. If possible, the comment should include a parameter declaration including the type.</p>
<p>Cmments should be defined using /<em> </em>/ instead of //. This is to avoid problems when using line breaks.</p>
<pre><code>/**
 * Represents a book.
 * @constructor
 * @param {string} title - The title of the book.
 * @param {string} author - The author of the book.
 */
function Book(title, author) {
  var me = this, 
            data;
/* using web worker since initial calculation might be expensive. */
  data = worker.readBook(title, author);
}
</code></pre>
<h2>Use short notations</h2>
<p>JS offers a number of short notations.</p>
<p><span
style='font-weight:bold'>Array definitions</span></p>
<pre><code>// false
var lunch = new Array();
lunch[0]='Dosa';
lunch[1]='Roti';
lunch[2]='Rice';
lunch[3]='what the heck is this?';

// richtig
var lunch = ['Dosa',
   'Roti',
   'Rice',
   'what the heck is this?'];
</code></pre>
<p><span
style='font-weight:bold'>Simplified way to write if/else instructions</span></p>
<pre><code>// false
if(v){
   var x = v;
} else {
   var x =10;
}

// true
var x = v || 10;
</code></pre>
<p><span
style='font-weight:bold'>Simplified way to write more complex if/else instructions</span></p>
<pre><code>// false
var direction;
if(x &gt; 100){
   direction = 1;
} else {
   direction = -1;
}

// trues
var direction = (x &gt; 100) ? 1 : -1;
</code></pre>
<h2>Objects and variables</h2>
<ul>
<li>Use property spelling convention, i.e. <code>file.name</code> instead of <code>file.getName()</code></li>
<li>Use few concatenations</li>
<li>No Hungarian notations, no member prefixes</li>
<li>Do not reuse variables, especially not with a different type</li>
<li><code>i</code>, <code>j</code>, <code>k</code> as loop counters are allowed</li>
</ul>
<h2>Functions</h2>
<ul>
<li>Functions should contain a verb (<code>postPayment</code>, <code>deletePage</code>, <code>save</code>)</li>
<li>one word per concept, e.g. do not switch between <code>fetch</code>, <code>retrieve</code>, and <code>get</code></li>
<li>Functions should contain few lines</li>
<li>One function should only complete one task</li>
<li>There should only be one abstraction level per function</li>
<li>Multiple related functions should be readable from top to bottom, i.e. the abstraction depth increases further down</li>
<li>Use few function arguments</li>
<li>Instruction and query should be separate, i.e. do not complete tasks in an 'if' query</li>
<li>Also use curly brackets for single-line instruction blocks</li>
</ul>
<h2>Error handling</h2>
<ul>
<li>Use exceptions instead of error codes</li>
<li>&quot;Null&quot; should not be returned</li>
<li>Only transfer &quot;null&quot; in exceptions, document as allowed</li>
</ul>
<h2>Other</h2>
<ul>
<li>Object orientation should be used to create namespaces; MANDATORY for libraries</li>
<li>Use <code>Array.join</code> as string builder alternative</li>
</ul>

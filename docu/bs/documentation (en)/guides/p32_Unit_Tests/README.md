<h1>Unit tests</h1>
<p>When developing solutions, it is important to carry out tests to check if functions still work after version updates.</p>
<p>The JavaScript test framework <a
href="http://jasmine.github.io/">Jasmine</a> is a good method for testing Indexserver functions such as actions, services and function modules.</p>
<h2>Interface for conducting unit tests</h2>
<p>The <code>development</code> package is an app for managing and running unit tests. This lists all tests that are available in the system and enables the user to start them.</p>
<p>{@img img1.png}</p>
<p>The results are then displayed in the app.</p>
<p>{@img img3.png}</p>
<h2>Filing unit tests to ELO</h2>
<p>Unit tests are JavaScript files and must be filed to the Administration folder. Tests are run in the browser and have access to the Indexserver JavaScript API.</p>
<p>{@img img5.png}</p>
<p>Jasmine can be used for defining test suites and testing operations. The official project documentation contains further information on this.</p>
<h2>Example - testing the ChangeColor function module</h2>
<p>{@img img7.png}</p>
<p>A <code>test.Utils</code> helper class was developed for Business Solutions that handles creation of demo objects as well as passing on workflows for test scenarios. </p>
<pre><code>describe(&quot;[function] sol.common.ix.functions.ChangeColor&quot;, function() {
    var objId,
      sordA, sordB;

    it(&quot;should throw if executed without 'objId'&quot;, function() {
      expect(function() {
        test.Utils.execute('RF_sol_function_ChangeColor', { 
        });
      }).toThrow();
    });

    describe(&quot;change color&quot;, function() {
      var objId,
        sordA, sordB;

      beforeAll(function() {
        expect(function() {
          objId = test.Utils.createSord();
        }).not.toThrow();

        expect(function() {
          sordA = test.Utils.getSord(objId);
        }).not.toThrow();

      });

      it(&quot;should change color&quot;, function() {&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        expect(function() {
          test.Utils.execute('RF_sol_function_ChangeColor', { 
            objId: objId,
            color: &quot;red&quot;
          });
        }).not.toThrow();

        expect(function() {
          sordB = test.Utils.getSord(objId);
        }).not.toThrow();

        expect(sordA.kind).not.toEqual(sordB.kind);
      });

      afterAll(function() {
        expect(function() {
          test.Utils.deleteSord(objId);
        }).not.toThrow();
      });
    });
});
</code></pre>

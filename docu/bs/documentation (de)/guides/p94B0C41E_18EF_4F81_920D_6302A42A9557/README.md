# AS-Scripting

Die Prämisse bei der Entwicklung von ELOas-Regeln sollte sein, möglichst wenig Code in den eigentlichen Regeln zu verwenden. Jegliche Funktionalität sollte in eigene Module ausgelagert werden.

## Template für JavaScript

    // Java includes -> important: leave first line empty
    
    /**
     * Code documentation
     *
     * @author Max Mustermann, ELO Digital Office GmbH
     * @version X
     *
     * @requires my.namespace.MySuperclass
     * @requires my.namespace.MyMixin
     */
    sol.define("my.namespace.MyClass", {
      singleton: true,
      extend: 'my.namespace.MySuperclass',
      mixins: ['my.namespace.MyMixin'],
    
      // properties section
    
      // optional
      initialize: function (config) {
        
      },
    
      // implementation section
      process: function() {}
    });


## Template für ELOas-Regeln

    <ruleset>
      <base>
        <name>my.namespace.RuleName</name>
        <search>
          <name>"DIRECT"</name>
          <value>""</value>
          <mask>0</mask>
          <max>200</max>
        </search>
        <interval>1H</interval>
      </base>
    <rule>
      <name>Regel1</name>
      <condition></condition>
      <script>
        EM_WRITE_CHANGED = false;
    
        var logger = sol.create("sol.Logger", { scope: "my.namespace.RuleName" });
        logger.enter("RuleName");
    
        // your code, e.g. calling superclass
        my.namespace.MyClass.process();
    
        logger.exit("RuleName");
      </script>
    </rule>
    <rule>
      <name>Global Error Rule</name>
      <condition>OnError</condition>
      <script></script>
    </rule>
    </ruleset>

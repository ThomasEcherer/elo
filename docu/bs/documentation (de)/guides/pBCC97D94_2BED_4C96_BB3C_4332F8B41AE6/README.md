# Datenbank-Ressource für ELO-Skripte anlegen

Folgende Schritte erläutern, wie eine Datenbank-Quelle als Ressource in <span
style='font-weight:bold;font-style:italic'>Apache Tomcat</span> angelegt werden kann. Dies wird benötigt, falls aus dem ELO-Scripting heraus auf externe Datenbanken zugegriffen werden soll.

> <span
style='font-weight:bold;font-style:italic'>Beispiel:</span><span
style='font-style:italic'> Dynamische Stichwortlisten erlauben es, ohne große Anpassungen auf Tabellen zuzugreifen, die sich in der ELO-Archivdatenbank befinden. Soll jedoch auf die </span><span
style='font-weight:bold;font-style:italic'>DocXtractor Matching DB</span><span
style='font-style:italic'> zugegriffen werden, muss hierzu eine Datenbank-Ressource angelegt werden, die später im Scripting (`sol.common.ix.DynKwlDatabaseIterator`) hinterlegt werden kann.</span>

## Datenbank-Ressource in context.xml-Datei hinterlegen

<span class="tag_important">Eine Beschreibung der Tomcat-<span
style='font-style:italic'>context.xml</span>-Optionen findet sich in den <a
href="https://tomcat.apache.org/tomcat-8.0-doc/config/context.html#Resource_Definitions"><span
style='font-style:italic'>Resource Definitions</span></a> der Tomcat-Dokumentation.</span>

Es empfiehlt sich, die Datenbank-Zugangsdaten in der Datei <span
style='font-weight:bold;font-style:italic'>context.xml</span> zu hinterlegen, um diese nicht im Scripting eingeben zu müssen:

    <?xml version='1.0' encoding='utf-8'?>
    <!-- The contents of this file will be loaded for each web application -->
    <Context>
    
        <!-- Add folowing line to file -->
    <Resource name="jdbc/invoice.dx" auth="Container" type="javax.sql.DataSource" 
        driverClassName="com.microsoft.sqlserver.jdbc.SQLServerDriver" 
        url="jdbc:sqlserver://localhost:1433;databaseName=invoice" 
        username="elodb" password="elo" 
        maxActive="20" maxIdle="10" maxWait="-1"/>
    
    </Context>

## Verwenden der Ressource

Ressourcen können nach einem Neustart von Tomcat bspw. in dynamischen Stichwortlisten verwendet werden. Hierzu dient die Konfiguration `jdbc` der Klasse `sol.common.ix.DynKwlDatabaseIterator`

<span
style='font-weight:bold'>Beispiel:</span>

    sol.define('sol.invoice.ix.dynkwl.Company', {
      extend: 'sol.common.ix.DynKwlDatabaseIterator',
    
      // use INVOICE resource
      jdbc: 'jdbc/INVOICE',
    
      tableTitle: 'Firma',
      sqlQuery: "select CODE, NAME, STREET, ZIPCODE, CITY, COUNTRY_CODE from sol_invoice_company where CODE like ? OR NAME like ?",
      sqlParams: [
        {mode: 'STARTS_WITH'},
        {mode: 'CONTAINS'}
      ],
      tableKeyNames: ["COMPANY_CODE", "COMPANY_NAME", null, null, null, null],
      tableHeaders: ["Nummer", "Name", "Straße", "PLZ", "Ort", "Land"]
    });
    



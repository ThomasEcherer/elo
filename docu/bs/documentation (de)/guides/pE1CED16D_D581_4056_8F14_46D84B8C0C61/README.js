Ext.data.JsonP.pE1CED16D_D581_4056_8F14_46D84B8C0C61({"guide":"<h1 id='pE1CED16D_D581_4056_8F14_46D84B8C0C61-section-unit-tests'>Unit Tests</h1>\n<div class='toc'>\n<p><strong>Contents</strong></p>\n<ul>\n<li>1. <a href='#!/guide/pE1CED16D_D581_4056_8F14_46D84B8C0C61-section-oberfl%C3%A4che-zum-ausf%C3%BChren-von-unit-tests'>Oberfläche zum Ausführen von Unit Tests</a>\n </li>\n<li>2. <a href='#!/guide/pE1CED16D_D581_4056_8F14_46D84B8C0C61-section-ablage-von-unit-tests-in-elo'>Ablage von Unit Tests in ELO</a>\n </li>\n<li>3. <a href='#!/guide/pE1CED16D_D581_4056_8F14_46D84B8C0C61-section-ein-beispiel---test-des-funktionsbausteins-changecolor'>Ein Beispiel - Test des Funktionsbausteins ChangeColor</a>\n </li>\n</ul></div>\n\n<p>Tests sind bei der Entwicklung von Lösungen außerordentlich wichtig, um schnell zu prüfen inwieweit Funktionalitäten nach Versionsupdates noch funktionieren.</p>\n\n<p>Index Server Funktionen wie Aktionen, Services und Funktionsbausteine können dabei bequem über das Java Script Test-Framework <a\nhref=\"http://jasmine.github.io/\">Jasmine</a> getestet werden.</p>\n\n<h2 id='pE1CED16D_D581_4056_8F14_46D84B8C0C61-section-oberfl%C3%A4che-zum-ausf%C3%BChren-von-unit-tests'>Oberfläche zum Ausführen von Unit Tests</h2>\n\n<p>Im Paket <code>development</code> ist eine App zum Verwalten und Ausführen von Unit Tests enthalten. Diese listet alle im System verfügbaren Tests auf und erlaubt es diese zu starten.</p>\n\n<p><p><img src=\"guides/pE1CED16D_D581_4056_8F14_46D84B8C0C61/img1.png\" alt=\"ELO common\nunitTests\nDOKUMENT\nArchiv Aufgaben\nKlemmbrett Bearbeitung Suche Business Solutions\nNils\nMosbach\nSTART\nKONTAKTE\nTESTAFFEN\nAUFGABEN\nNach Funktion suchen\nQ\nfunctionl\nSpeichern Unter\nANSICHT\nELO Business Solutions Unit Tests\nRun tests\nSelect all\nDeselectall\nIfunction) sol .common .ixfunctions.ChangeColor\nIfunction) sol .common .ixfunctlons.CheckMandatoryFields\nIfunction) sol .common .ixfunctions.CopyFolderContents\nIfunction) sol .common .ixfunctlons.CopySordData\nIfunction) sol .common .ixfunctions.CreateFromTemplate\nIfunction) sol .common .ixfunctionsDelete\nIfunction) sol .common .ixfunctions.FeedComment\" width=\"1064\" height=\"511\"></p></p>\n\n<p>Die Ergebnisse werden anschließend in der App angezeigt.</p>\n\n<p><p><img src=\"guides/pE1CED16D_D581_4056_8F14_46D84B8C0C61/img3.png\" alt=\"ELO common\nunitTests\nDOKUMENT\nArchiv Aufgaben\nKlemmbrett Bearbeitung Suche Business Solutions\nNils\nMosbach\nSTART\nKONTAKTE\nTESTAFFEN\nAUFGABEN\nNach Funktion suchen\nSpeichern Unter\nStart another test run\nfinished in 1.532s\nANSICHT\nELO Business Solutions Unit Tests\n@Jasmine 2.4.1\n4 specs, failures\nCfunction) sol . common . i x . functions .ChangeCoIor\nshould throw if executed Without &#39;objld&#39;\nchange color\nshould change color\nchange color, remember and restore\nshould change and store color\nshould restore color\" width=\"1064\" height=\"511\"></p></p>\n\n<h2 id='pE1CED16D_D581_4056_8F14_46D84B8C0C61-section-ablage-von-unit-tests-in-elo'>Ablage von Unit Tests in ELO</h2>\n\n<p>UnitTests sind JavaScript Dateien und müssen im Administrations-Ordner ablegt werden. Tests werden dabei im Browser ausgeführt und haben Zugriff auf die Index Server Java Script API.</p>\n\n<p><p><img src=\"guides/pE1CED16D_D581_4056_8F14_46D84B8C0C61/img5.png\" alt=\"Business Solutions\n_global\nt» Action definitions\nUnd Tests\nlactionl sol contactayacticns CreateCcntactRepcrt\nlacticnl sol contactayactions CreateLabeI\nlactionl sol contactix actions CreateCompany\nlactionl sol contactix actions CreateContact\nlactionl sol contactix actions CreateContactList\nlfunctionl sol common ix functions ChangeCoIor\" width=\"416\" height=\"226\"></p></p>\n\n<p>Jasmine erlaubt an dieser Stelle die Definition von Test-Suiten und Prüfoperationen weitere Hinweise können der offiziellen Dokumentation des Projektes entnommen werden.</p>\n\n<h2 id='pE1CED16D_D581_4056_8F14_46D84B8C0C61-section-ein-beispiel---test-des-funktionsbausteins-changecolor'>Ein Beispiel - Test des Funktionsbausteins ChangeColor</h2>\n\n<p><p><img src=\"guides/pE1CED16D_D581_4056_8F14_46D84B8C0C61/img7.png\" alt=\"ELO common\n6.\n8.\nunitTests\nDOKUMENT\nArchiv Aufgaben\nKlemmbrett Bearbeitung Suche Business Solutions\nNils\nMosbach\nSTART\nKONTAKTE\nTESTAFFEN\nRun tests\nAUFGABEN\nNach Funktion suchen\nSpeichern Unter\nQuickEdit Dokument Feed\nVergleich Auschecken\nANSICHT\n(functionl sol.common.ix.functions.ChangeCoIor\nQuick Edit\nELO Business Solutions Unit Tests\nSelect all\nDeselect all\nQ\nfunction\nIfunction) sol .common .ixfunctions.ChangeColor\nIfunction) sol .common .ixfunctlons.CheckMandatoryFields\nIfunction) sol .common .ixfunctions.CopyFolderContents\nIfunction) sol .common .ixfunctlons.CopySordData\nIfunction) sol .common .ixfunctions.CreateFromTemplate\nIfunction) sol .common .ixfunctionsDelete\nAk tuelle Bearbeitung\n2. describe(&quot; Cfunction) sol. commn.ix. functions.ChangeColor&quot; ,\nFunction()\n3\n4\n5\n9\n13\n11\n12\n13\n14\n15\n16\n17\n18.\n19.\n21\n22\nvor objld,\nsordA, sordB;\nthron if executed without &#39;objld&#39;&quot;, functionO -l\ntest. Utils. execute( &#39; ion_ChangeColor &#39; ,\nD. toThrow() ;\ndescribe(&quot;change color&quot; ,\nvar objld,\nsordA, sordB;\nfunction()\nobjld test.Utils.createSord();\nD. not. toThrmv() ;\" width=\"1064\" height=\"512\"></p></p>\n\n<p>Für Business Solutions wurde eine Hilfsklasse <code>test.Utils</code> erstellt die das Erzeugen von Demo-Objekten sowie weiterleiten von Workflows für Testfälle übernimmt.</p>\n\n<pre><code>describe(\"[function] <a href=\"#!/api/sol.common.ix.functions.ChangeColor\" rel=\"sol.common.ix.functions.ChangeColor\" class=\"docClass\">sol.common.ix.functions.ChangeColor</a>\", function() {\n    var objId,\n      sordA, sordB;\n\n    it(\"should throw if executed without 'objId'\", function() {\n      expect(function() {\n        test.Utils.execute('RF_sol_function_ChangeColor', { \n        });\n      }).toThrow();\n    });\n\n    describe(\"change color\", function() {\n      var objId,\n        sordA, sordB;\n\n      beforeAll(function() {\n        expect(function() {\n          objId = test.Utils.createSord();\n        }).not.toThrow();\n\n        expect(function() {\n          sordA = test.Utils.getSord(objId);\n        }).not.toThrow();\n\n      });\n\n      it(\"should change color\", function() {        \n        expect(function() {\n          test.Utils.execute('RF_sol_function_ChangeColor', { \n            objId: objId,\n            color: \"red\"\n          });\n        }).not.toThrow();\n\n        expect(function() {\n          sordB = test.Utils.getSord(objId);\n        }).not.toThrow();\n\n        expect(sordA.kind).not.toEqual(sordB.kind);\n      });\n\n      afterAll(function() {\n        expect(function() {\n          test.Utils.deleteSord(objId);\n        }).not.toThrow();\n      });\n    });\n});\n</code></pre>\n","title":"Unit Tests"});
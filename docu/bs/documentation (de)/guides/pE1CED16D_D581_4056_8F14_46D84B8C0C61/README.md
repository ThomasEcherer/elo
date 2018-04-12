# Unit Tests

Tests sind bei der Entwicklung von Lösungen außerordentlich wichtig, um schnell zu prüfen inwieweit Funktionalitäten nach Versionsupdates noch funktionieren.

Index Server Funktionen wie Aktionen, Services und Funktionsbausteine können dabei bequem über das Java Script Test-Framework <a
href="http://jasmine.github.io/">Jasmine</a> getestet werden.

## Oberfläche zum Ausführen von Unit Tests

Im Paket `development` ist eine App zum Verwalten und Ausführen von Unit Tests enthalten. Diese listet alle im System verfügbaren Tests auf und erlaubt es diese zu starten.

{@img img1.png ELO common 
unitTests 
DOKUMENT 
Archiv Aufgaben 
Klemmbrett Bearbeitung Suche Business Solutions 
Nils 
Mosbach 
START 
KONTAKTE 
TESTAFFEN 
AUFGABEN 
Nach Funktion suchen 
Q 
functionl 
Speichern Unter 
ANSICHT 
ELO Business Solutions Unit Tests 
Run tests 
Select all 
Deselectall 
Ifunction) sol .common .ixfunctions.ChangeColor 
Ifunction) sol .common .ixfunctlons.CheckMandatoryFields 
Ifunction) sol .common .ixfunctions.CopyFolderContents 
Ifunction) sol .common .ixfunctlons.CopySordData 
Ifunction) sol .common .ixfunctions.CreateFromTemplate 
Ifunction) sol .common .ixfunctionsDelete 
Ifunction) sol .common .ixfunctions.FeedComment}

Die Ergebnisse werden anschließend in der App angezeigt.

{@img img3.png ELO common 
unitTests 
DOKUMENT 
Archiv Aufgaben 
Klemmbrett Bearbeitung Suche Business Solutions 
Nils 
Mosbach 
START 
KONTAKTE 
TESTAFFEN 
AUFGABEN 
Nach Funktion suchen 
Speichern Unter 
Start another test run 
finished in 1.532s 
ANSICHT 
ELO Business Solutions Unit Tests 
@Jasmine 2.4.1 
4 specs, failures 
Cfunction) sol . common . i x . functions .ChangeCoIor 
should throw if executed Without 'objld' 
change color 
should change color 
change color, remember and restore 
should change and store color 
should restore color}

## Ablage von Unit Tests in ELO

UnitTests sind JavaScript Dateien und müssen im Administrations-Ordner ablegt werden. Tests werden dabei im Browser ausgeführt und haben Zugriff auf die Index Server Java Script API.

{@img img5.png Business Solutions 
_global 
t» Action definitions 
Und Tests 
lactionl sol contactayacticns CreateCcntactRepcrt 
lacticnl sol contactayactions CreateLabeI 
lactionl sol contactix actions CreateCompany 
lactionl sol contactix actions CreateContact 
lactionl sol contactix actions CreateContactList 
lfunctionl sol common ix functions ChangeCoIor}

Jasmine erlaubt an dieser Stelle die Definition von Test-Suiten und Prüfoperationen weitere Hinweise können der offiziellen Dokumentation des Projektes entnommen werden.

## Ein Beispiel - Test des Funktionsbausteins ChangeColor

{@img img7.png ELO common 
6. 
8. 
unitTests 
DOKUMENT 
Archiv Aufgaben 
Klemmbrett Bearbeitung Suche Business Solutions 
Nils 
Mosbach 
START 
KONTAKTE 
TESTAFFEN 
Run tests 
AUFGABEN 
Nach Funktion suchen 
Speichern Unter 
QuickEdit Dokument Feed 
Vergleich Auschecken 
ANSICHT 
(functionl sol.common.ix.functions.ChangeCoIor 
Quick Edit 
ELO Business Solutions Unit Tests 
Select all 
Deselect all 
Q 
function 
Ifunction) sol .common .ixfunctions.ChangeColor 
Ifunction) sol .common .ixfunctlons.CheckMandatoryFields 
Ifunction) sol .common .ixfunctions.CopyFolderContents 
Ifunction) sol .common .ixfunctlons.CopySordData 
Ifunction) sol .common .ixfunctions.CreateFromTemplate 
Ifunction) sol .common .ixfunctionsDelete 
Ak tuelle Bearbeitung 
2. describe(" Cfunction) sol. commn.ix. functions.ChangeColor" , 
Function() 
3 
4 
5 
9 
13 
11 
12 
13 
14 
15 
16 
17 
18. 
19. 
21 
22 
vor objld, 
sordA, sordB; 
thron if executed without 'objld'", functionO -l 
test. Utils. execute( ' ion_ChangeColor ' , 
D. toThrow() ; 
describe("change color" , 
var objld, 
sordA, sordB; 
function() 
objld test.Utils.createSord(); 
D. not. toThrmv() ;}

Für Business Solutions wurde eine Hilfsklasse `test.Utils` erstellt die das Erzeugen von Demo-Objekten sowie weiterleiten von Workflows für Testfälle übernimmt. 
 
    describe("[function] sol.common.ix.functions.ChangeColor", function() {
        var objId,
          sordA, sordB;
      
        it("should throw if executed without 'objId'", function() {
          expect(function() {
            test.Utils.execute('RF_sol_function_ChangeColor', { 
            });
          }).toThrow();
        });
    
        describe("change color", function() {
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
    
          it("should change color", function() {        
            expect(function() {
              test.Utils.execute('RF_sol_function_ChangeColor', { 
                objId: objId,
                color: "red"
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
    
    



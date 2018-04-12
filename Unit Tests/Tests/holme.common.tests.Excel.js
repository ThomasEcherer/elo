
/* eslint-disable */
describe("holme.common.tests.Excel", function() {
    var ret, retData, retErr;

    //  -----------------------------------------------------------------------  
    //              >>  Test splitting Document / create Sub-Document  <<
    //  -----------------------------------------------------------------------
    describe("splitDocument-Function [2]", function() {
        beforeAll(function() {
            ret = test.Utils.execute("RF_sol_common_service_ExecuteAsAction", 
                {
                    solution: "holme.common",
                    action: "holme.common.as.actions.test.Pdf.splitDocument",
                    config: {
                        objId: "2011",
                        fromPage: "1",
                        toPage: "2"
                    },
                    connParams: {
                        language: "de"
                    }
                }
            );

            if (!ret.responseOk) {
                console.error(ret);                
                api.Webclient.alert("Unerwarteter Fehler", "Aktion konnte nicht ausgeführt werden. " + ret);                
            }

            expect(ret.responseOk).toBe(true);
        });

        it("Splits the Document, and reads the Amount of Pages of the splitted Docuemnt", 
            function() {                
                expect(ret.content).toMatch("2");
            }
        );  
    });

});
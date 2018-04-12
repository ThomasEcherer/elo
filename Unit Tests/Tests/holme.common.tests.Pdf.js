
/* eslint-disable */
describe("holme.common.unittests.Pdf", function() {
    var ret, retData, retErr;


    //  -----------------------------------------------------------------------  
    //              >>  Test Creating Error <<
    //  -----------------------------------------------------------------------
    describe("Error-Creation", function() {
        it("should produce an error", 
            function() {
                ret = test.Utils.execute("RF_sol_common_service_ExecuteAsAction", 
                    {
                        solution: "holme.common",
                        action: "holme.common.as.actions.test.PdfUtils",
                        config: {
                            test: "ERROR"
                        },
                        connParams: {
                            language: "de"
                        }
                    }
                ).responseOk;
                expect(ret).toBe(false);
            }
        );        
    });

    //  -----------------------------------------------------------------------  
    //              >>  Test Reading PDF-Document, Page 2  <<
    //  -----------------------------------------------------------------------
    describe("Read Pdf - Page 2", function() {

        beforeAll(function() {
            ret = test.Utils.execute("RF_sol_common_service_ExecuteAsAction", 
                {
                    solution: "holme.common",
                    action: "holme.common.as.actions.test.Pdf.readPage",
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
            expect(ret.responseOk).toBe(true);
        });

        it("should Load a PdfDocument and Read the Page #2", 
            function() {                
                expect(ret.content).toMatch("Dies ist Seite2");
            }
        );        
    });    

    //  -----------------------------------------------------------------------  
    //              >>  Test reading amount of Pages  <<
    //  -----------------------------------------------------------------------
    describe("Read Amount of Pages", function() {
        beforeAll(function() {
            ret = test.Utils.execute("RF_sol_common_service_ExecuteAsAction", 
                {
                    solution: "holme.common",
                    action: "holme.common.as.actions.test.Pdf.getNumberOfPages",
                    config: {
                        objId: "2011"
                    },
                    connParams: {
                        language: "de"
                    }
                }
            );

            if (ret && ret.events && ret.events.length > 0 && ret.events[0].ID && ret.events[0].ID === "ERROR") {
                console.error(ret);
                if (ret.events[0].obj && ret.events[0].obj.msg) {
                    var error = ret.events[0].obj.msg;
                    api.Webclient.alert("Unerwarteter Fehler", "Aktion konnte nicht ausgeführt werden. " + error);
                }
            }

            expect(ret.responseOk).toBe(true);
        });

        it("read the pages of Testdocument. Should be '3'", 
            function() {                
                expect(ret.content).toMatch("3");
            }
        );  
    });

    //  -----------------------------------------------------------------------  
    //              >>  Test splitting Document / create Sub-Document  <<
    //  -----------------------------------------------------------------------
    describe("splitDocument-Function [1]", function() {
        beforeAll(function() {
            ret = test.Utils.execute("RF_sol_common_service_ExecuteAsAction", 
                {
                    solution: "holme.common",
                    action: "holme.common.as.actions.test.Pdf.splitDocument",
                    config: {
                        objId: "2011",
                        fromPage: "1",
                        toPage: "1"
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
                expect(ret.content).toMatch("1");
            }
        );  
    });

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
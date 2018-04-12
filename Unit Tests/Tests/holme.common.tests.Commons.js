
/* eslint-disable */
describe("holme.common.tests.Common", function() {
    var ret, dummyFile1, dummyFile2, retData, retErr;

    //  -----------------------------------------------------------------------  
    //              >>  Test inserting a new Version of a ELO-Document  <<
    //  -----------------------------------------------------------------------
    describe("Insert new Version", function() {

        beforeAll(function() { // creating dummy files
            expect(function () {
                dummyFile1 = holme.common.TestUtils.createDummyFile();
                dummyFile2 = holme.common.TestUtils.createDummyFile();
            }).not.toThrow();
        });

        it("Splits the Document, and reads the Amount of Pages of the splitted Docuemnt", 

            // Archive new Doc


            //  insert new Version
            function() {                
                expect(ret.content).toMatch("2");
            }
        );  

        afterAll(function() {
            expect(function() {
                if (dummyFile1) {
                    dummyFile1.delete();
                }

                if (dummyFile2) {
                    dummyFile2.delete();
                }
            }).not.toThrow();
        });
    });

});
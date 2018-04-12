
/* eslint-disable */
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
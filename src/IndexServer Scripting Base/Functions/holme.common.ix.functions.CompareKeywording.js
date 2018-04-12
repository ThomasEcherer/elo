importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.FunctionBase.js
//@include lib_sol.common.WfUtils.js

var logger = sol.create("sol.Logger", { scope: "holme.common.ix.functions.CompareKeywording" });

/**
 * Compares the keywording of 2 Objects and writes the result (TRUE/FALSE) into the workflow-status
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.Config
 * @requires sol.common.WfUtils
 * @requires sol.common.ix.FunctionBase
 */
sol.define("holme.common.ix.functions.CompareKeywording", {
  extend: "sol.common.ix.FunctionBase",
  
  requiredConfig: ["source", "target"],
  
  /** 
   * @cfg {String} source ObjId from the source-Object to compare from
   */

  /** 
   * @cfg {String} target ObjId from the target-Object to compare to
   */

  /** 
   * @cfg {String[]} compareObjKeys (optional) List of ObjKey-Names to compare. If not set, all objKeys from source will be compared
   */

  /**
   * @cfg {de.elo.ix.client.wfDiagram} wfDiagram (optional)
   * Required by onExitNode. The workflow which should be checked. If Set it writes into its status
   */

  initialize: function (config) {
    var me = this;
    me.$super("sol.common.ix.FunctionBase", "initialize", [config]);
  },

  /**
   * Compares the keywording of 2 Objects and writes the result (TRUE/FALSE) into the workflow-status
   * @returns {boolean} Returns TRUE if the Keywording is the same, returns FALSE otherwise
   */
  process: function () {
    var me = this,
        statusValue, sordSource, sordTarget, sordz;

    sordz = new SordZ(SordC.mbObjKeys);

    sordSource = ixConnectAdmin.checkoutSord(me.source, sordz, LockC.NO);
    sordTarget = ixConnectAdmin.checkoutSord(me.target, sordz, LockC.NO);

    statusValue = me.compareSords(sordSource, sordTarget);

    if (me.wfDiagram) {
      sol.common.WfUtils.setWorkflowStatus(me.wfDiagram, statusValue);
    }       
    return statusValue;    
  },

  /**
   * Compares if the keywording informations of 2 objects are the same.
   * 
   * @param {Sord} sordSource The ELO-Object to compare from
   * @param {Sord} sordTarget The ELO-Object to compare to
   * @returns {boolean} Returns TRUE if the keywording is the same, returns FALSE otherwise
   */
  compareSords: function (sordSource, sordTarget) {
    var me = this, 
        i, j, k,
        maxs, maxt, maxk, isObjKeyAllowed = false;

    maxs = sordSource.objKeys.length;
    maxt = sordTarget.objKeys.length;
    if (me.compareObjKeys) {
      maxk = me.compareObjKeys.length;
    }

    for (i = 0; i < maxs; i++) {
      if (me.compareObjKeys) {
        isObjKeyAllowed = false;
        for (k = 0; k < maxk; k++) {
          if (sordSource.objKeys[i].name == me.compareObjKeys[k]) {
            isObjKeyAllowed = true;
            break;
          }
        }
        if (!isObjKeyAllowed) {
          continue;
        }
      }
      
      for (j = 0; j < maxt; j++) {
        if (sordSource.objKeys[i].data.length != sordTarget.objKeys[j].data.length) {
          logger.info(["Length of ObjKey '{0}' is different between ({1}) and ({2})", sordSource.objKeys[i].name, sordSource, sordTarget]);
          return false;
        }

        if (sordSource.objKeys[i].data.length > 0) {
          if (sordSource.objKeys[i].data[0] == sordTarget.objKeys[j].data[0]) {
            logger.info(["Content of ObjKey '{0} is differnet between Object ({1} and ({2})", sordSource.objKeys[i].name, sordSource, sordTarget]);
            return false;
          }
        }
        
      }
    }

    return true;
  }

});

/**
 * @member holme.common.ix.functions.CompareKeywording
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onExitNode
 */
function onExitNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onExitNode_CompareKeywording", { 
    flowId: wfDiagram.id, 
    nodeId: nodeId 
  });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId),
      module;

  config.source = wfDiagram.objId;
  config.wfDiagram = wfDiagram;

  module = sol.create("holme.common.ix.functions.CompareKeywording", config);
  module.process();

  logger.exit("onExitNode_CompareKeywording");
}

/**
 * @member holme.common.ix.functions.CompareKeywording
 * @method RF_holme_common_function_CompareKeywording
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.RF_FunctionName
 */
function RF_holme_common_function_CompareKeywording(ec, configAny) {
  logger.enter("RF_holme_common_function_CompareKeywording", configAny);
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), 
      module,
      ret;

  module = sol.create("holme.common.ix.functions.CompareKeywording", config);
  ret = module.process();

  logger.exit("RF_holme_common_function_CompareKeywording");
  return ret;
}
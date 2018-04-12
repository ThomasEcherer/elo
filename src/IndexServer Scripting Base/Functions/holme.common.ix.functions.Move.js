
importPackage(Packages.de.elo.ix.client);

//@include lib_Class.js
//@include lib_sol.common.ix.FunctionBase.js
//@include lib_sol.common.RepoUtils.js
//@include lib_sol.common.IxUtils.js
//@include lib_sol.common.Template.js
//@include lib_sol.common.ObjectFormatter.js

var logger = sol.create("sol.Logger", { scope: "holme.common.ix.functions.Move" });

/**
 * Same as sol.common.ix.functions.Move, 
 * but accepts an startpoint, option to set the icons correctly,
 * and a
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @eloix
 * @requires sol.common.Config
 * @requires sol.common.RepoUtils
 * @requires sol.common.ix.FunctionBase
 * @requires sol.common.Template
 * @requires sol.common.ObjectFormatter.TemplateSord
 */
sol.define("holme.common.ix.functions.Move", {
  extend: "sol.common.ix.FunctionBase",
  
  requiredConfig: ["objId", "path"],    
  
  /** 
   * @cfg {String} path The Path to add after starting point.
   * The first character will be used as Separator
   */
  path: undefined,

  /** 
   * @cfg {String} objId the Object to move
   */
  objId: undefined,

  /**
   * @property {String} startPoint ObjId of the Starting point. Templating will be used
   */
  startPoint: undefined,

  initialize: function (config) {
    var me = this;
    me.$super("sol.common.ix.FunctionBase", "initialize", [config]);
    logger.info(["Start Function with (ObjId={0}) (targetId={1}) (path={2})", me.objId, me.targetId, me.path]);
  },

  /**
   * Moves an Entry. 
   */
  process: function () {
    var me = this,
        destFolderId;

    //  Use Handlebars to resole placeholder
    me.resolvePlaceholder();

    //  Gets or Creates thte Desination folder
    destFolderId = me.preparePath();    

    //  Move the Object to its destination
    logger.info(["Check if objid (destFoldeR={0})", destFolderId]);
    if (sol.common.RepoUtils.isObjId(destFolderId)) {
      sol.common.RepoUtils.moveSords([me.objId], destFolderId);
    } else {
      logger.error("DestFolderId couldn't be resolved");
    }
    
  },

  /**
   * Gets or Creates the Destination Path.
   * When Creating the path the SordType counts up. If a Startpoint
   * is given it starts with the type of the startpoint-folder +1.
   * 
   * @returns {int} The ObjectID of the Destination
   */
  preparePath: function () {
    var me = this,
        sordType = 0, parent, aclItemInherit, aclItems,
        mask, sordNames, sords = [], ids, parentId, separator;
    
    //  get the path-Separator
    separator = me.path.substring(0, 1);    

    //  Prepare inherit ACL
    aclItemInherit = new AclItem();
    aclItemInherit.type = AclItemC.TYPE_INHERIT;
    aclItems = [aclItemInherit];

    mask = "";

    if (me.startPoint) {
      parent = ixConnectAdmin.ix().checkoutSord(me.startPoint, SordC.mbLean, LockC.NO);
      sordType = parent.type;
    } 

    parentId = parent ? parent.id : 1;

    sordNames = me.path.substring(1, me.path.length).split(separator);
    sordNames.forEach(function (name) {
      sordType++;
      var sord = ixConnectAdmin.ix().createSord("", mask, SordC.mbAll);
      sord.name = name;
      sord.type = sordType;
      sord.aclItems = aclItems;
      sords.push(sord);
    });

    ids = ixConnectAdmin.ix().checkinSordPath(parentId, sords, SordC.mbAll);
    return ids[ids.length - 1];
  },
  
  /**
   * Uses Handlebars to resolve 'path' and 'startPoint'
   */
  resolvePlaceholder: function () {
    var me = this,
        sord, data, tpl;

    sord = ixConnectAdmin.ix().checkoutSord(me.objId, SordC.mbLean, LockC.NO);
    data = sol.common.ObjectFormatter.format({
      sord: {
        formatter: "sol.common.ObjectFormatter.TemplateSord",              
        data: sord
      }
    });

    tpl = sol.create("sol.common.Template", { source: me.path });
    me.path = tpl.apply(data); 

    if (me.startPoint) {
      tpl = sol.create("sol.common.Template", { source: me.startPoint });
      me.startPoint = tpl.apply(data);
    }
  }

});

/**
 * @member holme.common.ix.functions.Move
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.onExitNode
 */
function onExitNode(ci, userId, wfDiagram, nodeId) {
  logger.enter("onExitNode_Move", { flowId: wfDiagram.id, nodeId: nodeId });
  var config = sol.common.WfUtils.parseAndCheckParams(wfDiagram, nodeId), // you might add required properties here
      module;

  config.objId = wfDiagram.objId;
  module = sol.create("holme.common.ix.functions.Move", config);

  module.process();

  logger.exit("onExitNode_Move");
}

/**
 * @member holme.common.ix.functions.Move
 * @method RF_holme_common_function_Move
 * @static
 * @inheritdoc sol.common.ix.FunctionBase.RF_FunctionName
 */
function RF_holme_common_function_Move(ec, configAny) {
  logger.enter("RF_holme_common_function_Move", configAny);
  var rfUtils = sol.common.ix.RfUtils,
      config = rfUtils.parseAndCheckParams(ec, arguments.callee.name, configAny), // you might add required properties here
      module;

  module = sol.create("holme.common.ix.functions.Move", config);
  module.process();

  logger.exit("RF_holme_common_function_Move");
}
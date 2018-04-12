/**
 * @include Dump.js
 */
 
function DumpWorkflow() {
}
 
DumpWorkflow.prototype = new Dump(0);
 
DumpWorkflow.prototype.constructor = function(indent) {
  this.indent = indent;
}

DumpWorkflow.prototype.dumpWFType = function(wftype) {
  switch (wftype.bset) {
    case CONST.WORKFLOW_TYPE.ACTIVE.bset: 
      this.debug("type=ACTIVE");
      break;
    case CONST.WORKFLOW_TYPE.FINISHED.bset:
      this.debug("type=FINISHED");
	  break;
    case CONST.WORKFLOW_TYPE.TEMPLATE.bset:
      this.debug("type=TEMPLATE");
	  break;
	default:
	  this.debug("type=unknown");
  }
}

DumpWorkflow.prototype.dump = function(workflow) {
  this.enterBlock("Workflow");
  
  this.debug("name=" + workflow.name);
  this.debug("id=" + workflow.id);
  this.dumpWFType(workflow.type);
  this.debug("objid=" + workflow.objId);
  this.debug("objType=" + workflow.objType);
  this.debug("nextNodeId=" + workflow.nextNodeId);
  this.debug("completionDate=" + workflow.completionDateIso);

  this.dumpWFNodes(workflow.nodes);
  this.dumpWFNodeMatrix(workflow.matrix);

  this.exitBlock("Workflow");
}


DumpWorkflow.prototype.dumpWFNodeMatrix = function(matrix) {
  this.enterBlock("Matrix");
  if (matrix != null && matrix.assocs != null) {
	this.debug("count=" + matrix.assocs.length);
	for (var i = 0; i < matrix.assocs.length; i++) {
		this.dumpWFNodeAssoc(matrix.assocs[i]);
	}
  }
  this.exitBlock("Matrix");
}

DumpWorkflow.prototype.dumpWFNodeAssoc = function(assoc) {
  this.enterBlock("NodeAssoc");
  this.debug("nodeFrom=" + assoc.nodeFrom);
  this.debug("nodeTo=" + assoc.nodeTo);
  switch (assoc.type) {
    case CONST.WORKFLOW_NODE_ASSOC_TYPE.IF_TRUE: 
      this.debug("type=IF_TRUE");
      break;
    case CONST.WORKFLOW_NODE_ASSOC_TYPE.IF_FALSE: 
      this.debug("type=IF_FALSE");
      break;
    case CONST.WORKFLOW_NODE_ASSOC_TYPE.ALWAYS: 
      this.debug("type=ALWAYS");
      break;
  }
  this.debug("done=", assoc.done);
  this.exitBlock("NodeAssoc");
}

DumpWorkflow.prototype.dumpWFNodes = function(nodes) {
  this.enterBlock("Nodes");
  if (nodes != null) {
	this.debug("count=" + nodes.length);
	for (var i = 0; i < nodes.length; i++) {
	  this.dumpWFNode(nodes[i]);
	}
  }
  this.exitBlock("Nodes");
}

DumpWorkflow.prototype.dumpWFNode = function(node) {
  this.enterBlock("Node");
  this.debug("id=" + node.id);
  this.debug("name=" + node.name);
  this.debug("type=" + node.type);
  this.debug("isNext=" + node.isNext);
  this.debug("flags=" + node.flags);
  this.debug("alertBegin=" + node.alertBegin);
  this.debug("alertTo=" + node.alertTo);
  this.debug("alertWait=" + node.alertWait);
  this.debug("locked=" + node.locked);
  this.debug("lockedOwner=" + node.lockedOwner);
  this.debug("nbOfDonesToExit=" + node.nbOfDonesToExit);
  this.debug("onEnter=" + node.onEnter);
  this.debug("onExit=" + node.onExit);
  this.debug("posX=" + node.posX);
  this.debug("posY=" + node.posY);
  this.debug("result=" + (node.result ? "true" : "false"));
  this.debug("userId=" + node.userId);
  this.debug("comment=" + node.comment);
  this.debug("condition=" + node.condition);
  this.debug("yesNoCondition=" + node.yesNoCondition);
  this.debug("enterDate=" + node.enterDateIso);
  this.debug("exitDate=" + node.exitDateIso);
  this.debug("inUseDate=" + node.inUseDateIso);
  this.exitBlock("Node");
}


function init() {
  if (log.isDebugEnabled()) log.debug("init DumpWorkFlow.js");
}

init();
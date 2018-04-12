// This is an example for using workflow scripts.
// Copy this file to the script directory of AM, e.g. D:\ELOenterprise\data\am-eloam\configuration\eloscripts\


// There are some objects implicitly availiable.
// ix    - IndexServer interface
// CONST - IndexServer constants
// globalScope - Object that can contain global variables shared by all scripts
// scriptScope - Object that can contain global variables shared by all instances of this script

/**
 * @include DumpWorkFlow.js
 * @include DumpSord.js
 */
 
var importNames = JavaImporter();
importNames.importPackage(Packages.javax.mail);
importNames.importPackage(Packages.javax.mail.internet);
importNames.importPackage(Packages.java.util);
importNames.importPackage(Packages.de.elo.ix.client);

function sendMail(subject, content) {
  with (importNames) {
	var props = new Properties();
    props.setProperty("mail.transport.protocol", "smtp");
    props.setProperty("mail.host", "192.168.1.94");
    props.setProperty("mail.user", "ImigW");
    props.setProperty("mail.password", "");

	var mailSession = Session.getDefaultInstance(props, null);
	var transport = mailSession.getTransport();

	var message = new MimeMessage(mailSession);
	message.setSubject(subject);
	message.setContent(content, "text/plain");
	message.addRecipient(Message.RecipientType.TO,
			new InternetAddress("w.imig@elo.info"));

	transport.connect();
	transport.sendMessage(message,
		message.getRecipients(Message.RecipientType.TO));
	transport.close();
  }
}

/**
 * IndexServer calls this function if a workflow node is activated
 * @param ci ClientInfo object with language, country and ticket
 * @param userId The calling users ID (Integer)
 * @param workflow WFDiagram object
 * @param nodeId The activated node ID (Integer)
 */
function onEnterNode(ci, userId, workflow, nodeId) {
  log.debug("onEnterNode(");
  log.debug(")onEnterNode");
}

/**
 * IndexServer calls this function if a workflow node is deactivated
 * @param ci ClientInfo object with language, country and ticket
 * @param userId The calling users ID (Integer)
 * @param workflow WFDiagram object
 * @param nodeId The activated node ID (Integer)
 */
function onExitNode(ci, userId, workflow, nodeId) {
  log.debug("onExitNode(");
  log.debug("ci.ticket=" + ci.ticket);

  //var dumpWorkflow = new DumpWorkflow(2);
  //dumpWorkflow.dump(workflow);
  
  var editInfo = ix.checkoutSord(ci, workflow.objId, CONST.EDIT_INFO.mbSord, CONST.LOCK.YES);
  //var dumpSord = new DumpSord(2);
  //dumpSord.dump(editInfo.sord);
  
  editInfo.sord.desc = "This text was written inside the WorkFlowScriptExample";
  log.debug("update sord.desc=" + editInfo.sord.desc);
  
  ix.checkinSord(ci, editInfo.sord, CONST.SORD.mbAll, CONST.LOCK.NO);

  // list sords in first level
  with (importNames) {
    log.info("list sords:");
    var fi = new FindInfo();
    fi.findChildren = new FindChildren();
    fi.findChildren.parentId = "1";
    var fr = ix.findFirstSords(ci, fi, 100, CONST.SORD.mbMin);
    for (var i = 0; i < fr.sords.length; i++) {
      log.info("fr.sords[" + i + "].id=" + fr.sords[i].id + ", name=" + fr.sords[i].name);
    }
    ix.findClose(ci, fr.searchId);
  }

  
  sendMail("Workflow " + workflow.name + " finished",
           editInfo.sord.desc);
           
           

  // Call updateDisplayMembers after setting user names and ISO dates:
  // e.g.:
  //workflow.nodes[2].userName = "Ulla Freitag";
  //workflow.nodes[2].userDelayDateIso = "20091211100908";
  //workflow.dbHelper.updateDisplayMembers(true);


  
  log.debug(")onExitNode");
}

// some function, see below.
function init() {
  if (log.isDebugEnabled()) log.debug("init WorkFlowScriptExample.js");
}

//
// Statements in the toplevel scope will be executed each time when 
// onEnterNode or onExitNode is called.
// 
init();


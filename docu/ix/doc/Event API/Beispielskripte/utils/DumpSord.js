/**
 * @include Dump.js
 */

importPackage(Packages.de.elo.ix.client);

function DumpSord() {
}

DumpSord.prototype = new Dump(0);

DumpSord.prototype.constructor = function(indent) {
  this.indent = indent;
}

DumpSord.prototype.dump = function(name, sord) {
  if (sord) {
	  this.enterBlock(name);
	  this.debug("id=" + sord.id);
	  this.debug("guid=" + sord.guid);
	  this.debug("name=" + sord.name);
	  this.debug("changedMembers=" + new SordZ(sord.changedMembers) );
	  this.exitBlock(name);
  }
  else {
	  this.debug(name + "=null")
  }
}

function init() {
	  if (log.isDebugEnabled()) log.debug("init DumpSord.js");
	}

	init();

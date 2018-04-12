/**
 * @include Dump.js
 */

function DumpSord() {
}

DumpSord.prototype = new Dump(0);

DumpSord.prototype.constructor = function(indent) {
  this.indent = indent;
}

DumpSord.prototype.dump = function(sord) {
  this.enterBlock("Sord");
  this.debug("id=" + sord.id);
  this.debug("name=" + sord.name);
  this.debug("desc=" + sord.desc);
  this.exitBlock("Sord");
}


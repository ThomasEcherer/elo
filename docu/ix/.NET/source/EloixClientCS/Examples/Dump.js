
function Dump(indent) {
  this.indent = indent;
}

Dump.prototype.makeIndent = function() {
  var s = "                                                                   ";
  var i = Math.min(this.indent, s.length);
  return s.substr(0, i);
}

Dump.prototype.enterBlock = function(blockName) {
  this.debug(blockName);
  this.indent += 2;
}

Dump.prototype.exitBlock = function(blockName) {
  this.indent -= 2;
  this.debug(blockName);
}

Dump.prototype.debug = function(msg) {
  if (log.isDebugEnabled()) {
    log.debug(this.makeIndent() + msg);
  }
}

function init() {
  if (log.isDebugEnabled()) log.debug("init dump.js");
}

init();
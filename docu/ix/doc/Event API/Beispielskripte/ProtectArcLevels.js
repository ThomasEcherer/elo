/**
 * This example script protects the first archive levels from 
 * beeing modified by non-administrators.   
 */

/**
 * @include utils/DumpSord.js
 */

//Import the IndexServer API classes.
importPackage(Packages.de.elo.ix.client);

// Number of protected archive levels
var PROTECTED_LEVELS = 2;

/**
 * Ensure that the given Sord object contains informations about its archive path.
 * @param ec Execution context
 * @param sord Sord object
 * @return false, if the supplied Sord object is undefined.
 */
function ensureSordRefPaths(ec, sord) {
	if (log.isDebugEnabled()) log.debug("ensureSordRefPaths(sord=" + sord);
	var succ = false;

	// If sord object is an existing sord...
	if (sord && sord.id > 0) {
		
		// ... check wether member refPaths is valid
		succ = Bitset.isTrue(sord.changedMembers, SordC.mbRefPaths);
		
		// If refPaths is not valid...
		if (!succ) {
			
			// ... read refPaths via IndexServer API call
			if (log.isDebugEnabled()) log.debug("read path ...");
			var editZ = new EditInfoZ(0, new SordZ(SordC.mbRefPaths));
			var ed = ix.checkoutSord(ec.ci, sord.id, editZ, LockC.NO);
			sord.refPaths = ed.sord.refPaths;
			if (log.isDebugEnabled()) log.debug("read path OK");
			succ = true;
		}
	}
	
	if (log.isDebugEnabled()) log.debug(")ensureSordRefPaths=" + succ);
	return succ;
}

/**
 * Returns the archive path level of the given Sord object.
 * Sord.refPaths must be valid.
 * @param ec Execution context
 * @param sord Sord object
 * @return -1: chaos folder, 0: sord is the archive entry, >= 1: archive level 
 */
function getArcLevel(ec, sord) {
	if (log.isDebugEnabled()) log.debug("getArcLevel(" + sord);
	var level = -1; // chaos folder
	if (sord && sord.id > 0) {
		if (sord.id == 1) {
			level = 0; // archive entry
		}
		else {
			if (ensureSordRefPaths(ec, sord)) {
				if (log.isDebugEnabled()) log.debug("path=" + sord.refPaths[0]);
				level = sord.refPaths[0].path.length + 1;
			}
		}
	}
	if (log.isDebugEnabled()) log.debug(")getArcLevel=" + level);
	return level;
}

/**
 * Throws an access denied exception if the given level is a protected level
 * and the current user does not have administrator privilleges.
 * @param ec Execution context
 * @param level archive level
 */
function throwAccessDeniedIfArcLevelIsProtected(ec, level) {
	if (log.isDebugEnabled()) log.debug("throwAccessDeniedIfArcLevelIsProtected(" + level);
	if (level == -1) {
		// chaos folder
	}
	else if (level <= PROTECTED_LEVELS) {
		var isAdmin = Bitset.isTrue(ec.user.flags, AccessC.FLAG_ADMIN);
		if (log.isDebugEnabled()) log.debug("isAdmin=" + isAdmin);
		if (!isAdmin) {
			log.info("throw ACCESS_DENIED");
			ec.throwException(IXExceptionC.ACCESS_DENIED, "Only administrators can create objects on level=" + level);
		}
	}
	if (log.isDebugEnabled()) log.debug(")throwAccessDeniedIfArcLevelIsProtected");
}

/**
 * Event handler.
 */
function onBeforeCheckinSord(ec, sord, sordDB, parentSord, sordZ, lockZ) {
	if (log.isDebugEnabled()) log.debug("onBeforeCheckinSord(");
	
	if (log.isDebugEnabled()) {
		var dumpSord = new DumpSord(2);
		dumpSord.dump("sord", sord);
		dumpSord.dump("sordDB", sordDB);
		dumpSord.dump("parentSord", parentSord);
		log.debug("sordZ=" + lockZ);
		log.debug("lockZ=" + lockZ);

		log.debug("ec.user=" + ec.user);
		log.debug("ec.ci=" + ec.ci);
	}

	var level = -1;
	if (sord.id < 0) {
		level = getArcLevel(ec, parentSord) + 1;
	}
	else {
		level = getArcLevel(ec, sord);
	}
	
	throwAccessDeniedIfArcLevelIsProtected(ec, level);
	
	if (log.isDebugEnabled()) log.debug(")onBeforeCheckinSord");
}

/**
 * Event handler.
 */
function onBeforeDeleteSord(ec, parentSord, sord, lockZ, delOpts ) {
	if (log.isDebugEnabled()) log.debug("onBeforeDeleteSord(");

	if (log.isDebugEnabled()) {
		var dumpSord = new DumpSord(2);
		dumpSord.dump("sord", sord);
		dumpSord.dump("parentSord", parentSord);
		log.debug("delOpts=" + delOpts);
		log.debug("lockZ=" + lockZ);
	
		log.debug("ec.user=" + ec.user);
		log.debug("ec.ci=" + ec.ci);
	}
	
	var level = getArcLevel(ec, parentSord) + 1;
	throwAccessDeniedIfArcLevelIsProtected(ec, level);
	
	if (log.isDebugEnabled()) log.debug(")onBeforeDeleteSord");
}

/**
 * Event handler.
 */
function onBeforeRefSord(ec, parentSordOld, parentSordNew, sord, manSortIndex ) {
	if (log.isDebugEnabled()) log.debug("onBeforeRefSord(");

	if (log.isDebugEnabled()) {
		var dumpSord = new DumpSord(2);
		dumpSord.dump("parentSordOld", parentSordOld);
		dumpSord.dump("parentSordNew", parentSordNew);
		dumpSord.dump("sord", sord);
		log.debug("manSortIndex=" + manSortIndex);
	
		log.debug("ec.user=" + ec.user);
		log.debug("ec.ci=" + ec.ci);
	}
	
	var level = getArcLevel(ec, parentSordOld) + 1;
	throwAccessDeniedIfArcLevelIsProtected(ec, level);

	level = getArcLevel(ec, parentSordNew) + 1;
	throwAccessDeniedIfArcLevelIsProtected(ec, level);
	
	if (log.isDebugEnabled()) log.debug(")onBeforeRefSord");
}

/**
 * This function is called when the script is loaded and prints some text
 * into the IndexServer log file.
 */
function init() {
	if (log.isDebugEnabled()) log.debug("init ProtectArcLevels.js");
}

init();

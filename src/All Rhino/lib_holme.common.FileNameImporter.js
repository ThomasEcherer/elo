
importPackage(Packages.java.io);
importPackage(Packages.org.apache.commons.io.filefilter);
importPackage(Packages.java.util.regex);

//@include lib_Class.js
//@include lib_sol.common.RepoUtils.js
//@include lib_sol.common.Template.js

var logger = sol.create("sol.Logger", { scope: "holme.common.FileNameImporter" });

/**
 * TODO: Muss eigentlich in AS
 * 
 * Imports file into ELO.
 * The Filename of those files contains archiving Informations like keywording informations
 * 
 * Example 1:
 * 
 *    Description: To Import Files from a folder with the filename Syntax: "#<ANLAGEJAHR>-<AUFTRAGSNUMMER># <random text>"
 *    where the regex is #0000-00000# and the '#' should be ignored, and the first 0000 is objkey 1
 *    and the other 00000 is objkey 2 you can use something like this:
 * 
 *  {
 *	    "regexPattern": "[#]\\d\\d\\d\\d[-]\\d\\d\\d\\d\\d[#]",
 *	    "regexSplitCharacter": "-",
 *	    "regexRelations": [ "EINS", "ZWEI" ],
 *	    "regexDeleteCharacters": [ "#" ],
 *	    "source": "/usr/local/elo/temp/import",
 *	    "repoPath": "ARCPATH:/import",
 *	    "mask": "Testmaske"	
 *  }
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.00
 *
 */
sol.define("holme.common.FileNameImporter", {

  /**
   * @cfg
   * @property {String} regexPattern (optional) Pattern to look for in filename (need either 'regexOjKey' or 'relations')
   */
  regexPattern: undefined,

  /**
   * @cfg
   * @property {String} regexObjKey (optional) Name of the Objkey the regex-pattern is set to, if found. pattern has to be set for this option
   */
  regexObjkey: undefined,

  /**
   * @cfg
   * @property {String} regexSplitCharacter (optional) Only useable with regexObjKEy
   */
  regexSplitCharacter: undefined,

  /**
   * @cfg
   * @property {String[]} regexRelation (optional) Only usable with regex and regexSplitCharacter. List of ObjKeynames. Has to be the same order which split regex results in.
   */
  regexRelations: undefined,

  /**
   * @cfg
   * @property {String[]} regexDeleteCharacters (optional) characters to delete/replace after regex was found
   */
  regexDeleteCharacters: undefined,

  /**
   * @cfg
   * @property {String} source Path to the folder that documents has to be imported
   */
  source: undefined,

  /**
   * @cfg
   * @property {String} repoPath ObjId, Guid or Arcpath to the archiving repoPath
   */
  repoPath: undefined,

  /**
   * @cfg
   * @property {String} mask Name of the Keywording mask the documents should get
   */
  mask: undefined,

  /**
   * @cfg
   * @property {String} workflow Name of the workflow-Template that have to start after archiving the document
   */
  workflow: undefined,

  /**
   * @cfg
   * @property {String} ext (optional) Name of the extensions that should be collected
   */
  ext: undefined,

  /**
   * @cfg
   * @property {String[]} relations (optional) Only useable with 'splitCharacter'. Has an array of objkeys. That positioning is the same with splitted filename by 'splitCharacter'.
   */
  relations: undefined,

  /**
   * @cfg
   * @property {String} spiltCharacter (optional) Only useable with 'relations'. Determines the Split-Character to split the filename into peaces for keywording
   */
  splitCharacter: undefined,

  /**
   * @cfg
   * @property {String} destination Path where to move the files that are successfully archieved
   */
  destination: undefined,

  /**
   * @property {object} objKeysObj Map that contains key-value pairs. (eg. { "indexzeilenname1": "cleanRegex"})
   */
  objKeysObj: undefined,

  /**
   * @prop {String} errorRepoPath Destination in ELO when an error occurs and the file still should get saved in ELO. If not set, no saving on error
   */
  errorRepoPath: undefined,

  /**
   * Initializes the object
   * @param {Object} config The Configuration
   */
  initialize: function (config) {
    var me = this;
    logger.enter("holme.common.FileNameImporter.initialize", config);
    config = config || {};    
    me.$super("sol.Base", "initialize", [config]);

    me.checkIfConfigIsValid();   
    
    logger.exit("holme.common.FileNameImporter.initialize");
  },

  checkIfConfigIsValid: function () {
    var me = this;    
    //@todo Überprüfen ob Zwangsfelder-komibnationen gesetzt sind
  },
  
  process: function () {
    var me = this,
        files, i, key, max, file, objId, objKeys, regex, 
        tpl, templatingData = {}, cleanRegex, cleanFileName;
        
    logger.info("...collectfiles ...");
    files = me.collectFiles();

    max = files.length;
    for (i = 0; i < max; i++) {
      file = files[i];
      
      try {
        logger.info("...processing file", { file: String(file.name) });      
        if (me.regexPattern) {
          regex = me.searchRegex(file.name);        
          templatingData["regex"] = regex;        
          logger.info("Regex", { regex: String(regex) });                
        }
  
        logger.info("... prepare Document ...");
        if (me.regexDeleteCharacters) {
          cleanRegex = me.fixRegex(regex);
          templatingData["cleanRegex"] = cleanRegex;
          objKeys = me.prepareDocument(file.name, cleanRegex);
        } else {
          objKeys = me.prepareDocument(file.name, regex);      
        }
  
        cleanFileName = sol.common.FileUtils.getName(file).replace(regex, "").trim();
        templatingData["cleanFileName"] = cleanFileName;
  
        if (me.objKeysObj) {
          logger.info("... filling objKeys ...");
          for (key in me.objKeysObj) {
            tpl = sol.create("sol.common.Template", {
              source: me.objKeysObj[key]
            });
            objKeys[key] = tpl.apply(templatingData);
          }
        }
        
        logger.info("... archive file ...");
        objId = me.archiveFile(file, objKeys, cleanFileName);
        logger.info("archived File:" + { objId: objId });
  
        if (me.workflow) {
          logger.info("... start workflow ...");
          ixConnectAdmin.ix().startWorkFlow(me.workflow, me.workflow, objId);
        }
  
        if (me.destination) {
          if (file.renameTo(new File(me.destination + File.separator + file.name))) {
            logger.info(["File {0} successfully moved into {1}", file.name, me.destination]);
          } else {
            logger.error(["Could not move File {0} into folder {1}", file.name, me.destination]);
          }
        }
      } catch (e) {
        logger.error(e);
        if (me.errorRepoPath) {
          try {
            sol.common.RepoUtils.saveToRepo({
              name: file.name,
              repoPath: me.errorRepoPath,
              maskId: me.mask,
              file: file
            });
          } catch (ex) {
            logger.error("Error on archiving errorpath", ex);
          }
        }
      }

    }
  },

  /**
   * Removes the deletechars-character from the regex-data
   * 
   * @private
   * @param {String} regex The regexdata to fix.
   * @returns {String} the finxed regexdata
   */
  fixRegex: function (regex) {
    var me = this,
        r = regex;

    me.regexDeleteCharacters.forEach(function (delChar) {
      r = r.replaceAll(delChar, "");
    }); 
    return r;
  },

  /**
   * Searches for the regex value in the filename
   * 
   * @param {String} fileName The Name of the File to read the regex from
   * @returns {String} If regex found it will return the value of it. Will return undefined otherwise
   */
  searchRegex: function (fileName) {
    var me = this,
        matcher,
        pattern,
        ret;   
    logger.info("serachRegex", { pattern: me.regexPattern });
    pattern = Packages.java.util.regex.Pattern.compile(me.regexPattern);
    matcher = pattern.matcher(fileName);
    if (matcher.find()) {
      ret = matcher.group();      
      return ret;
    }
        
  },  

  /**
   * Prepares keywording by filtering Information out of the filename.
   * @private
   * @param {String} fileName The Filename to read the propteries from
   * @param {String} regex (optional) The Regex
   * @return {ObjKey[]} The read objKeys
   */
  prepareDocument: function (fileName, regex) {
    var me = this,
        objKeys = {},
        splitted,
        i;

    if (regex) {
      if (me.regexObjkey) {
        objKeys.push(new ObjKey([regex], 0, me.regexObjkey, 0));
      } else {
        splitted = regex.split(me.regexSplitCharacter);
        for (i in me.regexRelations) {
          if (splitted.length > i) {
            objKeys[me.regexRelations[i]] = splitted[i];
          }
        }
      }
      return objKeys;
    }

    if (me.relations && me.splitCharacter) {
      splitted = fileName.split(me.splitCharacter);
      for (i in me.relations) {
        if (splitted.length > i) {
          objKeys[me.relations[i]] = splitted[i];
        }
      }
    }
    
    return objKeys;
  },

  /**
   * Collects the Files in the Folder to import.
   * Only the first level (direct children to the folder) will be imported
   * 
   * @private
   * @returns {File[]} Files in the Folder to import
   */
  collectFiles: function () {
    var me = this;
    if (me.ext) {
      return new File(me.source).listFiles(
        new Packages.java.io.FileFilter(
          new SuffixFileFilter(me.ext)
        )
      );
    }
    return new File(me.source).listFiles();
  }, 

  /**
   * Archives the Files
   * 
   * @private   
   * @param {File} file The File to be imported
   * @param {Object} objKeys The Keywording information as Map
   * @param {String} shortName The Shortname for the ELO-Object
   * 
   * @returns {String} The ObjectId of the archived Document;
   */
  archiveFile: function (file, objKeys, shortName) {
    var me = this, 
        parentId, ext;   

    if (!me.ext) {
      ext = sol.common.FileUtils.getExtension(file);
    } else {
      ext = me.ext;
    }

    if (sol.common.RepoUtils.isObjId(me.repoPath) 
      || sol.common.RepoUtils.isGuid(me.repoPath)) {
      parentId = me.repoPath;
    } else {
      parentId = sol.common.RepoUtils.getObjId(me.repoPath);
    }

    return sol.common.RepoUtils.saveToRepo({
      name: shortName,
      parentId: parentId,
      maskId: me.mask,
      objKeysObj: objKeys,
      extenion: ext,
      file: file
    });
  }

});
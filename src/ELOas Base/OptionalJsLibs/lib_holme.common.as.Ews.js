
importPackage(Packages.microsoft.exchange.webservices.data);
importPackage(Packages.microsoft.exchange.webservices.data.credential);
importPackage(Packages.microsoft.exchange.webservices.data.core.enumeration.misc);
importPackage(Packages.microsoft.exchange.webservices.data.core.enumeration.property);

//@include lib_sol.common.RepoUtils.js
//@include lib_sol.common.XmlUtils.js
//@include lib_sol.common.CounterUtils.js
//@include lib_sol.common.ObjectUtils.js
//@include lib_sol.common.ActionBase.js
//@include lib_sol.common.as.ActionBase.js
//@include lib_sol.common.as.FunctionBase.js
//@include lib_sol.common.JsonUtils.js
//@include lib_sol.common.SordUtils.js
//@include lib_sol.common.IxUtils.js
//@include lib_sol.common.CounterUtils.js
//@include lib_sol.common.TranslateTerms.js
//@include lib_sol.common.WfUtils.js

var logger = sol.create("sol.Logger", { scope: "holme.common.as.Ews" });

sol.define("holme.common.as.actions.ReadFolderSent", {
  extend: "sol.common.as.ActionBase",

  /**
   * Filter Options for searching Emails
   * @property {Object} filter Filter Options for searching Emails
   * @property {String} filter.isoDateFrom ISO-Date
   * @property {String} filter.isoDateTo ISO-Date   
   * @property {String} filter.recipient Recipient of the sent mail
   */
  filter: undefined,

  /**
   * @cfg
   * @property {boolean} convertToSimpleObject Determines if the returned Object should be simplified objects (with Attributes 'subject', 'dateSent', 'dateReceived'
   */
  convertToSimpleObject: false,

  initialize: function (config) {
    var me = this;
    me.$super("sol.common.as.ActionBase", "initialize", [config]);
    me.config = config;
  },

  getName: function () {
    return "holme.common.as.actions.ReadFolderSent";
  },

  /**
   * Sends an email
   * @return {Object[]}
   */
  process: function () {
    var me = this,
        mail, ret, folder;
    
    try {
      mail = sol.create("holme.common.as.Ews", me.config);
      folder = Packages.microsoft.exchange.webservices.data.core.enumeration.property.WellKnownFolderName.SentItems;    
      ret = mail.readFolder(folder, me.filter);

      if (me.debug) {
        logger.info(["found #{0} items", ret.length]);
      }
      return me.convertToSimpleObject ? me.convertMailsToSimpleObject(ret) : ret;
    } catch (e) {
      logger.error(e);
      return e;
    }
  }

});

sol.define("holme.common.as.functions.SendMail", {
    
  extend: "sol.common.as.FunctionBase",

  initialize: function (config) {
    var me = this;
    me.$super("sol.common.as.FunctionBase", "initialize", [config]);
    me.config = config;
  },

  /**
   * Sends an email
   * @return {Object}
   */
  process: function () {
    var me = this,
        mail;
    mail = sol.create("holme.common.as.Ews", me.config);
    mail.send();

    return { passOn: true };
  }
});


/**
 * Code documentation
 * 
 * The Configurationfile located in:
 *  /Administration/Business Solutions/holme.common/Configuration/EwsMail
 *  
 * needs Parameter:
 *    url | URL to Exchange Web-Service. (e.g.: https://SERVER/EWS/Exchange.asmx)
 *
 *    
 * Requieres the Java-Libraries
 *  - ews-java-api-2.0.jar (or higher)
 *  - joda-time-2.8.jar (or higher)
 * 
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.001
 * 
 * @eloas
 */
sol.define("holme.common.as.Ews", {
  singleton: true,

  /**
   * @cfg {String} url
   * SMTP host
   */

  /**
   * @cfg {String} from
   * Sender
   */

  /**
   * @cfg {String} to
   * Recipients
   */

  /**
   * @cfg {String} subject
   * Subject
   */

  /**
   * @cfg {Object} body
   * Body configuration
   *
   * @cfg {Object} body.type
   * Body type "html" or "text". Default is "text"
   *
   * @cfg {Object} body.tplObjId
   * Object ID of the body template
   */

  /**
   * @cfg {Object} data
   * This Object will be provided for the template processing.
   */

  /**
   * @cfg {String} objId
   * The data of this sord object will be provided for the template processing.
   */

  /**
   * @cfg {String} flowId
   * The data of this workflow will be provided for the template processing.
   */

  /**
   * @cfg {String} nodeId
   * The data of this workflow node will be provided for the template processing.
   */

  /**
   * @cfg {String} user
   * user Name
   */

  /**
   * @cfg {String} password
   * User password
   */

  /**
   * @cfg {String} domain
   * (Optional) If set, this parameter is used for domain
   */

  /**
   * @cfg {Boolean} debug
   * True if the SMTP debug information should be written into the log
   */

  /**
   * @cfg {Array} atts
   * Attachments
   *
   * # Example:
   *     "atts": [{"objId": "4309"},
   *              {"objId": "4309", "convertToPdf": true}]
   */

  /**
   * @cfg {String} exchangeVersion
   * The Version of the used Exchange-Version.
   * 
   * Possible Values are:
   *  "version2010_sp2"
   *  "version2010_sp1"
   *  "version2010"
   *  "version2007_sp1"
   */

  /**
   * @property {boolean} saveSentMail Determines if the sent mail should be saved in 'Sent'-Folder. Default is false.
   */
  saveSentMail: false,

  service: null,

  versionen: {
    version2010_sp2: Packages.microsoft.exchange.webservices.data.core.enumeration.misc.ExchangeVersion.Exchange2010_SP2,
    version2010_sp1: Packages.microsoft.exchange.webservices.data.core.enumeration.misc.ExchangeVersion.Exchange2010_SP1,
    version2010: Packages.microsoft.exchange.webservices.data.core.enumeration.misc.ExchangeVersion.Exchange2010,
    version2007_sp1: Packages.microsoft.exchange.webservices.data.core.enumeration.misc.ExchangeVersion.Exchange2007_SP1
  },

  initialize: function (config) {
    var me = this;
    logger.info("Init-Class von EWS Hauptklasse (config=" + config + ")");
    config = config || {};
    me.$super("sol.Base", "initialize", [config]);
  },

  /**
   * Laods the mail configuration
   * @param {String} repoPath Path in ELO to the mail-configuration to load
   * @return {Object} Mail configuration
   */
  loadMailConfig: function (repoPath) {
    var objId;
    objId = sol.common.RepoUtils.getObjId(repoPath);
    if (!objId) {
      logger.error("Config not found:", repoPath);
      return;
    }
    return sol.create("sol.common.Config", { compose: objId }).config;
  },

  /**
   * Starts a Session.
   * Uses the Paramiter 'auth' 'user' and 'password'
   */
  initSession: function () {
    var me = this,
        credentials, mailConfig;  
        
    logger.info("hole mail-config");
    mailConfig = me.loadMailConfig("ARCPATH:/Administration/Business Solutions/holme.common/Configuration/mail.config");
    
    if (me.version == "version2010_sp2") {
      me.exchangeVersion = Packages.microsoft.exchange.webservices.data.core.enumeration.misc.ExchangeVersion.Exchange2010_SP2;
    } else {
      logger.warn("Exchange Version nicht erkannt:", me.version);
    }

    if (!me.exchangeVersion) {
      me.exchangeVersion = Packages.microsoft.exchange.webservices.data.core.enumeration.misc.ExchangeVersion.Exchange2010_SP2;
    }

    if (!me.url) {      
      me.url = mailConfig.url;
    }

    if (!me.user) {
      me.user = mailConfig.user;      
    }

    if (!me.password) {
      me.password = mailConfig.password;
    }

    if (!me.domain) {
      me.domain = mailConfig.domain;
    }
    
    me.service = new Packages.microsoft.exchange.webservices.data.core.ExchangeService(me.exchangeVersion);        
    if (me.domain && me.domain != "") {
      credentials = new Packages.microsoft.exchange.webservices.data.credential.WebCredentials(me.user, me.password, me.domain);
    } else {
      credentials = new Packages.microsoft.exchange.webservices.data.credential.WebCredentials(me.user, me.password);
    }
    me.service.setCredentials(credentials);
    me.service.setUrl(new Packages.java.net.URI(me.url));        
  },

  /**
   * @private
   * Retrieves the data that is provided for templating
   */
  getData: function () {
    var me = this,
        wfDiagram;

    me.data = me.data || {};

    if (me.objId) {
      me.sord = ixConnect.ix().checkoutSord(me.objId, EditInfoC.mbSord, LockC.NO).sord;
      me.data.sord = sol.common.SordUtils.getTemplateSord(me.sord).sord;
    }

    if (me.flowId && me.nodeId && !me.noWorkflowInfo) {
      wfDiagram = ixConnect.ix().checkoutWorkFlow(String(me.flowId), WFTypeC.ACTIVE, WFDiagramC.mbAll, LockC.NO);
      me.data.node = sol.common.WfUtils.getTemplateWfDiagramNode(wfDiagram, String(me.nodeId)).node;
    }
  },

  /**
   * @private
   * Retrieves the recipient of the mail
   * @param {Object|String} to Recipient definition
   * @return {String} recipient
   */
  getRecipient: function (to) {
    var me = this,
        recipient, wfDiagram, wfNode, successorNodes;

    logger.info("getRecipient with to:", to);

    if (sol.common.ObjectUtils.isObject(to)) {
      logger.warn("to is object");
      if (!to.type) {
        logger.error("to.type is empty");
        throw "to.type is empty";
      }

      // me.logger.debug("recipientConfig=" + JSON.stringify(to));

      switch (String(to.type).toUpperCase()) {

        case "GRP":
          me.checkKey(to);
          recipient = sol.common.SordUtils.getValue(me.sord, to);
          break;

        case "MAP":
          me.checkKey(to);
          recipient = sol.common.SordUtils.getValue(me.sord, to);
          break;

        case "SORDOWNER":
          recipient = me.sord.ownerName;
          break;

        case "WFMAP":
          me.checkKey(to);
          me.checkWorkflowProps();
          recipient = sol.common.WfUtils.getWfMapValue(me.flowId, to.key);
          break;

        case "CURRENT":
          wfDiagram = me.getWorkflow();
          wfNode = sol.common.WfUtils.getNode(wfDiagram, me.nodeId);
          recipient = wfNode.userName;
          break;

        case "NEXT":
          wfDiagram = me.getWorkflow();
          successorNodes = sol.common.WfUtils.getSuccessorNodes(wfDiagram, me.nodeId, WFNodeC.TYPE_PERSONNODE);
          if (!successorNodes || (successorNodes.length == 0)) {
            throw "No appropriate successor node found";
          }
          if (successorNodes.length > 1) {
            throw "Successor node is ambiguous";
          }
          recipient = successorNodes[0].userName;
          break;

        case "WFOWNER":
          wfDiagram = me.getWorkflow();
          recipient = wfDiagram.ownerName;
          break;

        default:
          throw "to.type=" + to.type + " is unsupported";
      }
    } else {
      recipient = to + "";
    }

    if (!recipient) {
      throw "Recipient user is empty";
    }

    logger.info("Recipient:", recipient);
    logger.info("indexof:", recipient.indexOf("@"));
    if (recipient.indexOf("@") < 0) {      
      recipient = sol.common.UserUtils.getMailAddress(recipient);
    }

    if (!recipient) {
      throw "Recipient is empty";
    }

    return recipient;
  },

  /**
   * @private
   * @param {Object} to Recipient configuration
   * Checks the key value
   */
  checkKey: function (to) {
    if (!to.key) {
      throw "to.key is empty";
    }
  },

  /**
   * @private
   * Returns the workflow diagram
   * @return {de.elo.ix.client.WFDiagram}
   */
  getWorkflow: function () {
    var me = this;
    if (!me.flowId) {
      throw "flowId is empty";
    }
    if (!me.nodeId) {
      throw "nodeId is empty";
    }
    return ixConnect.ix().checkoutWorkFlow(me.flowId, WFTypeC.ACTIVE, WFDiagramC.mbAll, LockC.NO);
  },

  /**
   * @public
   * Sends an Email    
   */
  send: function () {
    var me = this,
        msg;

    logger.info("... Init Session ...");
    me.initSession();

    logger.info("... get Data ...");
    me.getData();
    me.recipient = me.getRecipient(me.to);

    if (!me.recipient) {
      throw "Recipient is empty.";
    }

    try {      
      logger.info("... Prepare Email ...");
      msg = new Packages.microsoft.exchange.webservices.data.core.service.item.EmailMessage(me.service);
      msg.subject = me.subject || "";
      me.recipient.split(";").forEach(function (toPart) {
        msg.getToRecipients().add(toPart);
      });
      msg.body = me.addBody();

      if (me.atts) {
        logger.info("... Adding Attachments ...");
        me.atts.forEach(function (attConfig) {
          var sord, attInputStream, dataSource, fileName;
          sord = ixConnect.ix().checkoutSord(attConfig.objId, EditInfoC.mbSordDoc, LockC.NO).sord;
          attConfig.extension = sord.docVersion.ext;
          attInputStream = me.getAttAsStream(attConfig);
          dataSource = Packages.org.apache.commons.io.IOUtils.toByteArray(attInputStream);
          attInputStream.close();
          fileName = sord.name + "." + attConfig.extension;
          msg.getAttachments().addFileAttachment(fileName, dataSource);
        });
      }      

      if (me.saveSentMail) {
        logger.info("... Send and save ...");
        msg.sendAndSaveCopy();
      } else {
        logger.info("... send without save ...");
        msg.send();
      }
    } catch (ex) {
      logger.error("Error on Sending Mail:", ex);
    }
  },

  /**
   * @private
   * @returns {String} The Bodytext, given by 'body', 'body.conent' and 'body.tplObjId'
   * 
   */
  addBody: function () {
    var me = this,
        bodyContent, template;
    me.body = me.body || {};
    
    bodyContent = me.body.content || "";
    if (me.body.tplObjId) {
      template = sol.create("sol.common.Template", {});
      template.load(me.body.tplObjId);
      bodyContent = template.apply(me.data);
      return new Packages.microsoft.exchange.webservices.data.property.complex.MessageBody(bodyContent);
    } else {
      return Packages.microsoft.exchange.webservices.data.property.complex.MessageBody.getMessageBodyFromText(bodyContent);
    }   
    
  },

  /**
   * @private
   * @param {object} attConfig Attachment configuration
   * @return {java.io.InputStream} Attachment input stream
   */
  getAttAsStream: function (attConfig) {
    var officeConverter, inputStream;
    if (attConfig.objId) {
      if (attConfig.convertToPdf) {
        officeConverter = sol.create("sol.common.as.functions.OfficeConverter", {
          openFromRepo: {
            objId: attConfig.objId
          },
          saveToStream: {
            format: "pdf"
          }
        });
        if (officeConverter.isSupported(attConfig.extension)) {
          inputStream = officeConverter.execute();
          attConfig.extension = "pdf";
          return inputStream;
        }
      }
    }
    return sol.common.RepoUtils.downloadToStream(attConfig.objId);
  },

  /**
   * Reads the Mails of a folder
   * 
   * @param {microsoft.exchange.webservices.data.core.enumeration.property.WellKnownFolderName} wkFolderName The folder to read
   * @param {Object} filter The Filter for Emails
   * @param {String} filter.year The year to filter the emails for
   * @param {String} filter.month The month to filter the emails for
   * @param {Stirng} filter.recipient The recipient to filter the emails for
   * 
   * @returns {microsoft.exchange.webservices.data.core.service.item.Item[]} the emails of the folder
   */
  readFolder: function (wkFolderName, filter) {
    var me = this,
        view, findResults, item, returnList = [], searchFilters;

    // init session if neccessary    
    me.initSession(); 
        
    // Prepare filter
    if (filter) {
      searchFilters = new Packages.microsoft.exchange.webservices.data.search.filter.SearchFilter.SearchFilterCollection();
      if (filter.isoDateFrom) {
        searchFilters.add(
          new Packages.microsoft.exchange.webservices.data.search.filter.SearchFilter.IsGreaterThanOrEqualTo(
            Packages.microsoft.exchange.webservices.data.core.service.schema.EmailMessageSchema.DateTimeSent, ixConnect.isoToDate(me.filter.isoDateFrom) 
          ));
      }
      
      if (filter.isoDateTo) {
        searchFilters.add(
          new Packages.microsoft.exchange.webservices.data.search.filter.SearchFilter.IsLessThanOrEqualTo(
            Packages.microsoft.exchange.webservices.data.core.service.schema.EmailMessageSchema.DateTimeSent, ixConnect.isoToDate(me.filter.isoDateTo) 
          ));
      }

      if (filter.recipient) {
        searchFilters.add(
          new Packages.microsoft.exchange.webservices.data.search.filter.SearchFilter.ContainsSubstring(
            Packages.microsoft.exchange.webservices.data.core.service.schema.EmailMessageSchema.ToRecipients, ixConnect.isoToDate(filter.recipient) 
          ));
      }
    }

    // Search for Items
    view = new Packages.microsoft.exchange.webservices.data.search.ItemView(50);    
    do {
      findResults = searchFilters ? 
        me.service.findItems(wkFolderName, searchFilters, view) 
        : me.service.findItems(wkFolderName, view);
            
      for (item in findResults.items) {                
        returnList.push(findResults.items[item]);        
      }
      view.Offset += 50;

    } while (findResults.MoreAvailable);
    
    return returnList;
  },

  /**
   * Converts the given Emails into a simplified object   
   * 
   * @param {Item[]|EmailMessage[]} mails to convert
   * @returns {Object[]} An Array of the simplified emails
   */
  convertMailsToSimpleObject: function (mails) {
    var me = this,
        simpleObjects = [], i, max;

    //TODO: Maybe use a simliar system like elo do with constancs 'SordC' To determines which fields to set

    max = mails.length;
    for (i = 0; i < max; i++) {
      simpleObjects.push(me.convertMailToSimpleObject(mails[i]));
    }
    return simpleObjects;
  },

  /**
   * Converts a single Email into a simplified object
   * 
   * @param {Item|EmailMessage} mail Email to simplify
   * @returns {Object} The simplified Email-Message
   */
  convertMailToSimpleObject: function (mail) {
    var simpleObject;

    simpleObject = {
      subject: mail.getSubject(),
      dateSent: mail.getDateTimeSent(),
      dateReceived: mail.getDateTimeReceived()
    };

    return simpleObject;
  }



});
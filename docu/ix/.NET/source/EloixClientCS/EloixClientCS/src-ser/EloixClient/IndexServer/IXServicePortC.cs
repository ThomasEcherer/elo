//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	/// <summary>
	/// <p>Constants for options and classes used by IndexServer.
	/// </summary>
	/// <remarks>
	/// </p>
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class IXServicePortC : BSerializable
	{
	
		#region Constructors
		
		public IXServicePortC() {
		}		
		
		public IXServicePortC(EloixClient.IndexServer.AccessC @ACCESS, EloixClient.IndexServer.AclItemC @ACL_ITEM, EloixClient.IndexServer.ActivityC @ACTIVITY, EloixClient.IndexServer.ActivityProjectC @ACTIVITY_PROJECT, EloixClient.IndexServer.AlertC @ALERT, EloixClient.IndexServer.ArchivingModeC @ARCHIVING_MODE, EloixClient.IndexServer.CheckinUsersC @CHECKIN_USERS, EloixClient.IndexServer.CheckoutUsersC @CHECKOUT_USERS, EloixClient.IndexServer.ColorDataC @COLOR, EloixClient.IndexServer.ConfigFileC @CONFIG_FILE, EloixClient.IndexServer.CopySordC @COPY_SORD, EloixClient.IndexServer.CounterInfoC @COUNTER_INFO, EloixClient.IndexServer.DocMaskC @DOC_MASK, EloixClient.IndexServer.DocMaskLineC @DOC_MASK_LINE, EloixClient.IndexServer.DocVersionC @DOC_VERSION, EloixClient.IndexServer.EditInfoC @EDIT_INFO, EloixClient.IndexServer.ExportOptionsC @EXPORT_OPTIONS, EloixClient.IndexServer.ImportOptionsC @IMPORT_OPTIONS, EloixClient.IndexServer.IXExceptionC @IXEXCEPTION, EloixClient.IndexServer.KeywordC @KEYWORD, EloixClient.IndexServer.LinkSordC @LINK_SORD, EloixClient.IndexServer.LockC @LOCK, EloixClient.IndexServer.NavigationInfoC @NAV_INFO, EloixClient.IndexServer.NoteC @NOTE, EloixClient.IndexServer.ObjKeyC @OBJ_KEY, EloixClient.IndexServer.ProcessInfoC @PROCESS_INFO, EloixClient.IndexServer.ReminderC @REMINDER, EloixClient.IndexServer.ReplSetNameC @REPL_SET_NAME, EloixClient.IndexServer.ReportC @REPORT, EloixClient.IndexServer.ReportInfoC @REPORT_INFO, EloixClient.IndexServer.ReportModeC @REPORT_MODE, EloixClient.IndexServer.ReportOptionsC @REPORT_OPTIONS, EloixClient.IndexServer.SearchModeC @SEARCH_MODE, EloixClient.IndexServer.ServerStateC @SERVER_STATE, EloixClient.IndexServer.SessionOptionsC @SESSION_OPTIONS, EloixClient.IndexServer.SordC @SORD, EloixClient.IndexServer.SordHistC @SORD_HIST, EloixClient.IndexServer.SordHistKeyC @SORD_HIST_KEY, EloixClient.IndexServer.SordTypeC @SORD_TYPE, EloixClient.IndexServer.SortOrderC @SORT_ORDER, EloixClient.IndexServer.StoreInfoC @STORE_INFO, EloixClient.IndexServer.WFTakeNodeC @TAKE_NODE, EloixClient.IndexServer.ThesaurusC @THESAURUS, EloixClient.IndexServer.UserInfoC @USER_INFO, EloixClient.IndexServer.UserProfileC @USER_PROFILE, EloixClient.IndexServer.UserTaskPriorityC @USER_TASK_PRIORITY, EloixClient.IndexServer.UserTaskSortOrderC @USER_TASK_SORT_ORDER, EloixClient.IndexServer.VtDocC @VT_DOC, EloixClient.IndexServer.WFDiagramC @WORKFLOW, EloixClient.IndexServer.WFNodeC @WORKFLOW_NODE, EloixClient.IndexServer.WFNodeMatrixC @WORKFLOW_NODE_ASSOC_TYPE, EloixClient.IndexServer.WFTypeC @WORKFLOW_TYPE, EloixClient.IndexServer.InvalidateCacheC @INVALIDATE_CACHE, EloixClient.IndexServer.WFVersionC @WORKFLOW_VERSION, EloixClient.IndexServer.NoteTemplateC @NOTE_TEMPLATE, EloixClient.IndexServer.NoteFreehandC @NOTE_FREEHAND, EloixClient.IndexServer.ArchiveStatisticsOptionsC @ARCHIVE_STATISTICS_OPTIONS, EloixClient.IndexServer.MapDomainC @MAP_CONFIG, EloixClient.IndexServer.MapDomainC @MAP_DOMAIN, EloixClient.IndexServer.EloIxOptC @ELO_IX_OPT, EloixClient.IndexServer.AnyC @ANY, EloixClient.IndexServer.SearchTermsC @SEARCH_TERMS, EloixClient.IndexServer.AdminModeC @ADMIN_MODE, EloixClient.IndexServer.FulltextConfigC @FULLTEXT_CONFIG, EloixClient.IndexServer.ServerInfoDMC @SERVER_INFO_DM, EloixClient.IndexServer.FindDirectC @FIND_DIRECT, EloixClient.IndexServer.feed.ActionC @ACTION, EloixClient.IndexServer.feed.FeedC @FEED, EloixClient.IndexServer.TranslateTermC @TRANSLATE_TERM, EloixClient.IndexServer.EventBusC @EVENT_BUS, EloixClient.IndexServer.PreviewImageInfoC @PREVIEW_IMAGE_INFO, EloixClient.IndexServer.ResolveRightsResultC @RESOLVE_RIGHTS, EloixClient.IndexServer.feed.FindActionsInfoC @FIND_ACTIONS_INFO, EloixClient.IndexServer.SubscriptionC @SUBSCRIPTION, EloixClient.IndexServer.MapDataC @MAP_DATA, EloixClient.IndexServer.MapHistC @MAP_HIST, EloixClient.IndexServer.WorkflowExportOptionsC @WORKFLOW_EXPORT_OPTIONS, EloixClient.IndexServer.WFNodeHistoryC @WORKFLOW_NODE_HISTORY, EloixClient.IndexServer.DocMaskLineTemplateC @DOC_MASK_LINE_TEMPLATE, EloixClient.IndexServer.PublicDownloadC @PUBLIC_DOWNLOAD, EloixClient.IndexServer.FileDataC @FILE_DATA, EloixClient.IndexServer.OcrInfoC @OCR_INFO) {
			this.ACCESSValue = @ACCESS;
			this.ACL_ITEMValue = @ACL_ITEM;
			this.ACTIVITYValue = @ACTIVITY;
			this.ACTIVITY_PROJECTValue = @ACTIVITY_PROJECT;
			this.ALERTValue = @ALERT;
			this.ARCHIVING_MODEValue = @ARCHIVING_MODE;
			this.CHECKIN_USERSValue = @CHECKIN_USERS;
			this.CHECKOUT_USERSValue = @CHECKOUT_USERS;
			this.COLORValue = @COLOR;
			this.CONFIG_FILEValue = @CONFIG_FILE;
			this.COPY_SORDValue = @COPY_SORD;
			this.COUNTER_INFOValue = @COUNTER_INFO;
			this.DOC_MASKValue = @DOC_MASK;
			this.DOC_MASK_LINEValue = @DOC_MASK_LINE;
			this.DOC_VERSIONValue = @DOC_VERSION;
			this.EDIT_INFOValue = @EDIT_INFO;
			this.EXPORT_OPTIONSValue = @EXPORT_OPTIONS;
			this.IMPORT_OPTIONSValue = @IMPORT_OPTIONS;
			this.IXEXCEPTIONValue = @IXEXCEPTION;
			this.KEYWORDValue = @KEYWORD;
			this.LINK_SORDValue = @LINK_SORD;
			this.LOCKValue = @LOCK;
			this.NAV_INFOValue = @NAV_INFO;
			this.NOTEValue = @NOTE;
			this.OBJ_KEYValue = @OBJ_KEY;
			this.PROCESS_INFOValue = @PROCESS_INFO;
			this.REMINDERValue = @REMINDER;
			this.REPL_SET_NAMEValue = @REPL_SET_NAME;
			this.REPORTValue = @REPORT;
			this.REPORT_INFOValue = @REPORT_INFO;
			this.REPORT_MODEValue = @REPORT_MODE;
			this.REPORT_OPTIONSValue = @REPORT_OPTIONS;
			this.SEARCH_MODEValue = @SEARCH_MODE;
			this.SERVER_STATEValue = @SERVER_STATE;
			this.SESSION_OPTIONSValue = @SESSION_OPTIONS;
			this.SORDValue = @SORD;
			this.SORD_HISTValue = @SORD_HIST;
			this.SORD_HIST_KEYValue = @SORD_HIST_KEY;
			this.SORD_TYPEValue = @SORD_TYPE;
			this.SORT_ORDERValue = @SORT_ORDER;
			this.STORE_INFOValue = @STORE_INFO;
			this.TAKE_NODEValue = @TAKE_NODE;
			this.THESAURUSValue = @THESAURUS;
			this.USER_INFOValue = @USER_INFO;
			this.USER_PROFILEValue = @USER_PROFILE;
			this.USER_TASK_PRIORITYValue = @USER_TASK_PRIORITY;
			this.USER_TASK_SORT_ORDERValue = @USER_TASK_SORT_ORDER;
			this.VT_DOCValue = @VT_DOC;
			this.WORKFLOWValue = @WORKFLOW;
			this.WORKFLOW_NODEValue = @WORKFLOW_NODE;
			this.WORKFLOW_NODE_ASSOC_TYPEValue = @WORKFLOW_NODE_ASSOC_TYPE;
			this.WORKFLOW_TYPEValue = @WORKFLOW_TYPE;
			this.INVALIDATE_CACHEValue = @INVALIDATE_CACHE;
			this.WORKFLOW_VERSIONValue = @WORKFLOW_VERSION;
			this.NOTE_TEMPLATEValue = @NOTE_TEMPLATE;
			this.NOTE_FREEHANDValue = @NOTE_FREEHAND;
			this.ARCHIVE_STATISTICS_OPTIONSValue = @ARCHIVE_STATISTICS_OPTIONS;
			this.MAP_CONFIGValue = @MAP_CONFIG;
			this.MAP_DOMAINValue = @MAP_DOMAIN;
			this.ELO_IX_OPTValue = @ELO_IX_OPT;
			this.ANYValue = @ANY;
			this.SEARCH_TERMSValue = @SEARCH_TERMS;
			this.ADMIN_MODEValue = @ADMIN_MODE;
			this.FULLTEXT_CONFIGValue = @FULLTEXT_CONFIG;
			this.SERVER_INFO_DMValue = @SERVER_INFO_DM;
			this.FIND_DIRECTValue = @FIND_DIRECT;
			this.ACTIONValue = @ACTION;
			this.FEEDValue = @FEED;
			this.TRANSLATE_TERMValue = @TRANSLATE_TERM;
			this.EVENT_BUSValue = @EVENT_BUS;
			this.PREVIEW_IMAGE_INFOValue = @PREVIEW_IMAGE_INFO;
			this.RESOLVE_RIGHTSValue = @RESOLVE_RIGHTS;
			this.FIND_ACTIONS_INFOValue = @FIND_ACTIONS_INFO;
			this.SUBSCRIPTIONValue = @SUBSCRIPTION;
			this.MAP_DATAValue = @MAP_DATA;
			this.MAP_HISTValue = @MAP_HIST;
			this.WORKFLOW_EXPORT_OPTIONSValue = @WORKFLOW_EXPORT_OPTIONS;
			this.WORKFLOW_NODE_HISTORYValue = @WORKFLOW_NODE_HISTORY;
			this.DOC_MASK_LINE_TEMPLATEValue = @DOC_MASK_LINE_TEMPLATE;
			this.PUBLIC_DOWNLOADValue = @PUBLIC_DOWNLOAD;
			this.FILE_DATAValue = @FILE_DATA;
			this.OCR_INFOValue = @OCR_INFO;
		}		
		
		public IXServicePortC(IXServicePortC rhs)
		{
			this.ACCESSValue = rhs.ACCESSValue;
			this.ACL_ITEMValue = rhs.ACL_ITEMValue;
			this.ACTIVITYValue = rhs.ACTIVITYValue;
			this.ACTIVITY_PROJECTValue = rhs.ACTIVITY_PROJECTValue;
			this.ALERTValue = rhs.ALERTValue;
			this.ARCHIVING_MODEValue = rhs.ARCHIVING_MODEValue;
			this.CHECKIN_USERSValue = rhs.CHECKIN_USERSValue;
			this.CHECKOUT_USERSValue = rhs.CHECKOUT_USERSValue;
			this.COLORValue = rhs.COLORValue;
			this.CONFIG_FILEValue = rhs.CONFIG_FILEValue;
			this.COPY_SORDValue = rhs.COPY_SORDValue;
			this.COUNTER_INFOValue = rhs.COUNTER_INFOValue;
			this.DOC_MASKValue = rhs.DOC_MASKValue;
			this.DOC_MASK_LINEValue = rhs.DOC_MASK_LINEValue;
			this.DOC_VERSIONValue = rhs.DOC_VERSIONValue;
			this.EDIT_INFOValue = rhs.EDIT_INFOValue;
			this.EXPORT_OPTIONSValue = rhs.EXPORT_OPTIONSValue;
			this.IMPORT_OPTIONSValue = rhs.IMPORT_OPTIONSValue;
			this.IXEXCEPTIONValue = rhs.IXEXCEPTIONValue;
			this.KEYWORDValue = rhs.KEYWORDValue;
			this.LINK_SORDValue = rhs.LINK_SORDValue;
			this.LOCKValue = rhs.LOCKValue;
			this.NAV_INFOValue = rhs.NAV_INFOValue;
			this.NOTEValue = rhs.NOTEValue;
			this.OBJ_KEYValue = rhs.OBJ_KEYValue;
			this.PROCESS_INFOValue = rhs.PROCESS_INFOValue;
			this.REMINDERValue = rhs.REMINDERValue;
			this.REPL_SET_NAMEValue = rhs.REPL_SET_NAMEValue;
			this.REPORTValue = rhs.REPORTValue;
			this.REPORT_INFOValue = rhs.REPORT_INFOValue;
			this.REPORT_MODEValue = rhs.REPORT_MODEValue;
			this.REPORT_OPTIONSValue = rhs.REPORT_OPTIONSValue;
			this.SEARCH_MODEValue = rhs.SEARCH_MODEValue;
			this.SERVER_STATEValue = rhs.SERVER_STATEValue;
			this.SESSION_OPTIONSValue = rhs.SESSION_OPTIONSValue;
			this.SORDValue = rhs.SORDValue;
			this.SORD_HISTValue = rhs.SORD_HISTValue;
			this.SORD_HIST_KEYValue = rhs.SORD_HIST_KEYValue;
			this.SORD_TYPEValue = rhs.SORD_TYPEValue;
			this.SORT_ORDERValue = rhs.SORT_ORDERValue;
			this.STORE_INFOValue = rhs.STORE_INFOValue;
			this.TAKE_NODEValue = rhs.TAKE_NODEValue;
			this.THESAURUSValue = rhs.THESAURUSValue;
			this.USER_INFOValue = rhs.USER_INFOValue;
			this.USER_PROFILEValue = rhs.USER_PROFILEValue;
			this.USER_TASK_PRIORITYValue = rhs.USER_TASK_PRIORITYValue;
			this.USER_TASK_SORT_ORDERValue = rhs.USER_TASK_SORT_ORDERValue;
			this.VT_DOCValue = rhs.VT_DOCValue;
			this.WORKFLOWValue = rhs.WORKFLOWValue;
			this.WORKFLOW_NODEValue = rhs.WORKFLOW_NODEValue;
			this.WORKFLOW_NODE_ASSOC_TYPEValue = rhs.WORKFLOW_NODE_ASSOC_TYPEValue;
			this.WORKFLOW_TYPEValue = rhs.WORKFLOW_TYPEValue;
			this.INVALIDATE_CACHEValue = rhs.INVALIDATE_CACHEValue;
			this.WORKFLOW_VERSIONValue = rhs.WORKFLOW_VERSIONValue;
			this.NOTE_TEMPLATEValue = rhs.NOTE_TEMPLATEValue;
			this.NOTE_FREEHANDValue = rhs.NOTE_FREEHANDValue;
			this.ARCHIVE_STATISTICS_OPTIONSValue = rhs.ARCHIVE_STATISTICS_OPTIONSValue;
			this.MAP_CONFIGValue = rhs.MAP_CONFIGValue;
			this.MAP_DOMAINValue = rhs.MAP_DOMAINValue;
			this.ELO_IX_OPTValue = rhs.ELO_IX_OPTValue;
			this.ANYValue = rhs.ANYValue;
			this.SEARCH_TERMSValue = rhs.SEARCH_TERMSValue;
			this.ADMIN_MODEValue = rhs.ADMIN_MODEValue;
			this.FULLTEXT_CONFIGValue = rhs.FULLTEXT_CONFIGValue;
			this.SERVER_INFO_DMValue = rhs.SERVER_INFO_DMValue;
			this.FIND_DIRECTValue = rhs.FIND_DIRECTValue;
			this.ACTIONValue = rhs.ACTIONValue;
			this.FEEDValue = rhs.FEEDValue;
			this.TRANSLATE_TERMValue = rhs.TRANSLATE_TERMValue;
			this.EVENT_BUSValue = rhs.EVENT_BUSValue;
			this.PREVIEW_IMAGE_INFOValue = rhs.PREVIEW_IMAGE_INFOValue;
			this.RESOLVE_RIGHTSValue = rhs.RESOLVE_RIGHTSValue;
			this.FIND_ACTIONS_INFOValue = rhs.FIND_ACTIONS_INFOValue;
			this.SUBSCRIPTIONValue = rhs.SUBSCRIPTIONValue;
			this.MAP_DATAValue = rhs.MAP_DATAValue;
			this.MAP_HISTValue = rhs.MAP_HISTValue;
			this.WORKFLOW_EXPORT_OPTIONSValue = rhs.WORKFLOW_EXPORT_OPTIONSValue;
			this.WORKFLOW_NODE_HISTORYValue = rhs.WORKFLOW_NODE_HISTORYValue;
			this.DOC_MASK_LINE_TEMPLATEValue = rhs.DOC_MASK_LINE_TEMPLATEValue;
			this.PUBLIC_DOWNLOADValue = rhs.PUBLIC_DOWNLOADValue;
			this.FILE_DATAValue = rhs.FILE_DATAValue;
			this.OCR_INFOValue = rhs.OCR_INFOValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Constants for access rights.
		/// </summary>
		public EloixClient.IndexServer.AccessC ACCESS
		{
			get
			{
				return ACCESSValue;
			}
			set
			{
				this.ACCESSValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for access control lists.
		/// </summary>
		public EloixClient.IndexServer.AclItemC ACL_ITEM
		{
			get
			{
				return ACL_ITEMValue;
			}
			set
			{
				this.ACL_ITEMValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for Activities
		/// </summary>
		public EloixClient.IndexServer.ActivityC ACTIVITY
		{
			get
			{
				return ACTIVITYValue;
			}
			set
			{
				this.ACTIVITYValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for Activity project options.
		/// </summary>
		public EloixClient.IndexServer.ActivityProjectC ACTIVITY_PROJECT
		{
			get
			{
				return ACTIVITY_PROJECTValue;
			}
			set
			{
				this.ACTIVITY_PROJECTValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for Alerts (messages).
		/// </summary>
		public EloixClient.IndexServer.AlertC ALERT
		{
			get
			{
				return ALERTValue;
			}
			set
			{
				this.ALERTValue = value;
			}
		}
		
		
		/// <summary>
		/// Archiving modes like version controlled, read-only,...
		/// </summary>
		public EloixClient.IndexServer.ArchivingModeC ARCHIVING_MODE
		{
			get
			{
				return ARCHIVING_MODEValue;
			}
			set
			{
				this.ARCHIVING_MODEValue = value;
			}
		}
		
		
		/// <summary>
		/// Options for the <code>checkinUsers</code> function.
		/// </summary>
		public EloixClient.IndexServer.CheckinUsersC CHECKIN_USERS
		{
			get
			{
				return CHECKIN_USERSValue;
			}
			set
			{
				this.CHECKIN_USERSValue = value;
			}
		}
		
		
		/// <summary>
		/// Options for the <code>checkoutUsers</code> function.
		/// </summary>
		public EloixClient.IndexServer.CheckoutUsersC CHECKOUT_USERS
		{
			get
			{
				return CHECKOUT_USERSValue;
			}
			set
			{
				this.CHECKOUT_USERSValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for colours
		/// </summary>
		public EloixClient.IndexServer.ColorDataC COLOR
		{
			get
			{
				return COLORValue;
			}
			set
			{
				this.COLORValue = value;
			}
		}
		
		
		/// <summary>
		/// Constanst for ConfigFile.
		/// </summary>
		public EloixClient.IndexServer.ConfigFileC CONFIG_FILE
		{
			get
			{
				return CONFIG_FILEValue;
			}
			set
			{
				this.CONFIG_FILEValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants (options) for the <code>copySord</code> function.
		/// </summary>
		public EloixClient.IndexServer.CopySordC COPY_SORD
		{
			get
			{
				return COPY_SORDValue;
			}
			set
			{
				this.COPY_SORDValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for CounterInfo.
		/// </summary>
		public EloixClient.IndexServer.CounterInfoC COUNTER_INFO
		{
			get
			{
				return COUNTER_INFOValue;
			}
			set
			{
				this.COUNTER_INFOValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for storage masks.
		/// </summary>
		public EloixClient.IndexServer.DocMaskC DOC_MASK
		{
			get
			{
				return DOC_MASKValue;
			}
			set
			{
				this.DOC_MASKValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for storage mask index lines.
		/// </summary>
		public EloixClient.IndexServer.DocMaskLineC DOC_MASK_LINE
		{
			get
			{
				return DOC_MASK_LINEValue;
			}
			set
			{
				this.DOC_MASK_LINEValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for document or attachment version history.
		/// </summary>
		public EloixClient.IndexServer.DocVersionC DOC_VERSION
		{
			get
			{
				return DOC_VERSIONValue;
			}
			set
			{
				this.DOC_VERSIONValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for editing indexing information and documents.
		/// </summary>
		public EloixClient.IndexServer.EditInfoC EDIT_INFO
		{
			get
			{
				return EDIT_INFOValue;
			}
			set
			{
				this.EDIT_INFOValue = value;
			}
		}
		
		
		/// <summary>
		/// Export options constants.
		/// </summary>
		public EloixClient.IndexServer.ExportOptionsC EXPORT_OPTIONS
		{
			get
			{
				return EXPORT_OPTIONSValue;
			}
			set
			{
				this.EXPORT_OPTIONSValue = value;
			}
		}
		
		
		/// <summary>
		/// Import options constants.
		/// </summary>
		public EloixClient.IndexServer.ImportOptionsC IMPORT_OPTIONS
		{
			get
			{
				return IMPORT_OPTIONSValue;
			}
			set
			{
				this.IMPORT_OPTIONSValue = value;
			}
		}
		
		
		/// <summary>
		/// Error numbers used in IndexServer exceptions.
		/// </summary>
		public EloixClient.IndexServer.IXExceptionC IXEXCEPTION
		{
			get
			{
				return IXEXCEPTIONValue;
			}
			set
			{
				this.IXEXCEPTIONValue = value;
			}
		}
		
		
		/// <summary>
		/// Keyword constants.
		/// </summary>
		public EloixClient.IndexServer.KeywordC KEYWORD
		{
			get
			{
				return KEYWORDValue;
			}
			set
			{
				this.KEYWORDValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for linkSords
		/// </summary>
		public EloixClient.IndexServer.LinkSordC LINK_SORD
		{
			get
			{
				return LINK_SORDValue;
			}
			set
			{
				this.LINK_SORDValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants to lock and unlock data against concurrent modification.
		/// </summary>
		public EloixClient.IndexServer.LockC LOCK
		{
			get
			{
				return LOCKValue;
			}
			set
			{
				this.LOCKValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for navigation information.
		/// </summary>
		public EloixClient.IndexServer.NavigationInfoC NAV_INFO
		{
			get
			{
				return NAV_INFOValue;
			}
			set
			{
				this.NAV_INFOValue = value;
			}
		}
		
		
		/// <summary>
		/// Note.
		/// </summary>
		public EloixClient.IndexServer.NoteC NOTE
		{
			get
			{
				return NOTEValue;
			}
			set
			{
				this.NOTEValue = value;
			}
		}
		
		
		/// <summary>
		/// Index lines of indexing information.
		/// </summary>
		public EloixClient.IndexServer.ObjKeyC OBJ_KEY
		{
			get
			{
				return OBJ_KEYValue;
			}
			set
			{
				this.OBJ_KEYValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for process information
		/// </summary>
		public EloixClient.IndexServer.ProcessInfoC PROCESS_INFO
		{
			get
			{
				return PROCESS_INFOValue;
			}
			set
			{
				this.PROCESS_INFOValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for reminders.
		/// </summary>
		public EloixClient.IndexServer.ReminderC REMINDER
		{
			get
			{
				return REMINDERValue;
			}
			set
			{
				this.REMINDERValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for replication set names.
		/// </summary>
		public EloixClient.IndexServer.ReplSetNameC REPL_SET_NAME
		{
			get
			{
				return REPL_SET_NAMEValue;
			}
			set
			{
				this.REPL_SET_NAMEValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for report.
		/// </summary>
		public EloixClient.IndexServer.ReportC REPORT
		{
			get
			{
				return REPORTValue;
			}
			set
			{
				this.REPORTValue = value;
			}
		}
		
		
		/// <summary>
		/// ReportInfo constants including report action codes.
		/// </summary>
		public EloixClient.IndexServer.ReportInfoC REPORT_INFO
		{
			get
			{
				return REPORT_INFOValue;
			}
			set
			{
				this.REPORT_INFOValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for report modes (no, limited, verbose, full).
		/// </summary>
		public EloixClient.IndexServer.ReportModeC REPORT_MODE
		{
			get
			{
				return REPORT_MODEValue;
			}
			set
			{
				this.REPORT_MODEValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for report options containing report erp codes
		/// </summary>
		public EloixClient.IndexServer.ReportOptionsC REPORT_OPTIONS
		{
			get
			{
				return REPORT_OPTIONSValue;
			}
			set
			{
				this.REPORT_OPTIONSValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for find options.
		/// </summary>
		public EloixClient.IndexServer.SearchModeC SEARCH_MODE
		{
			get
			{
				return SEARCH_MODEValue;
			}
			set
			{
				this.SEARCH_MODEValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for server state providing the status of server modules.
		/// </summary>
		public EloixClient.IndexServer.ServerStateC SERVER_STATE
		{
			get
			{
				return SERVER_STATEValue;
			}
			set
			{
				this.SERVER_STATEValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for session options.
		/// </summary>
		public EloixClient.IndexServer.SessionOptionsC SESSION_OPTIONS
		{
			get
			{
				return SESSION_OPTIONSValue;
			}
			set
			{
				this.SESSION_OPTIONSValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for the indexing information (Sord object).
		/// </summary>
		public EloixClient.IndexServer.SordC SORD
		{
			get
			{
				return SORDValue;
			}
			set
			{
				this.SORDValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for sord history.
		/// </summary>
		public EloixClient.IndexServer.SordHistC SORD_HIST
		{
			get
			{
				return SORD_HISTValue;
			}
			set
			{
				this.SORD_HISTValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for sord history entries.
		/// </summary>
		public EloixClient.IndexServer.SordHistKeyC SORD_HIST_KEY
		{
			get
			{
				return SORD_HIST_KEYValue;
			}
			set
			{
				this.SORD_HIST_KEYValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for sord type.
		/// </summary>
		public EloixClient.IndexServer.SordTypeC SORD_TYPE
		{
			get
			{
				return SORD_TYPEValue;
			}
			set
			{
				this.SORD_TYPEValue = value;
			}
		}
		
		
		/// <summary>
		/// Sort orders like manually, alphabetically, ...
		/// </summary>
		public EloixClient.IndexServer.SortOrderC SORT_ORDER
		{
			get
			{
				return SORT_ORDERValue;
			}
			set
			{
				this.SORT_ORDERValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for store info.
		/// </summary>
		public EloixClient.IndexServer.StoreInfoC STORE_INFO
		{
			get
			{
				return STORE_INFOValue;
			}
			set
			{
				this.STORE_INFOValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for take node.
		/// </summary>
		public EloixClient.IndexServer.WFTakeNodeC TAKE_NODE
		{
			get
			{
				return TAKE_NODEValue;
			}
			set
			{
				this.TAKE_NODEValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for thesaurus.
		/// </summary>
		public EloixClient.IndexServer.ThesaurusC THESAURUS
		{
			get
			{
				return THESAURUSValue;
			}
			set
			{
				this.THESAURUSValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for user information.
		/// </summary>
		public EloixClient.IndexServer.UserInfoC USER_INFO
		{
			get
			{
				return USER_INFOValue;
			}
			set
			{
				this.USER_INFOValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for user profile.
		/// </summary>
		public EloixClient.IndexServer.UserProfileC USER_PROFILE
		{
			get
			{
				return USER_PROFILEValue;
			}
			set
			{
				this.USER_PROFILEValue = value;
			}
		}
		
		
		/// <summary>
		/// Priority constants.
		/// </summary>
		public EloixClient.IndexServer.UserTaskPriorityC USER_TASK_PRIORITY
		{
			get
			{
				return USER_TASK_PRIORITYValue;
			}
			set
			{
				this.USER_TASK_PRIORITYValue = value;
			}
		}
		
		
		/// <summary>
		/// Sort order used when collecting tasks.
		/// </summary>
		public EloixClient.IndexServer.UserTaskSortOrderC USER_TASK_SORT_ORDER
		{
			get
			{
				return USER_TASK_SORT_ORDERValue;
			}
			set
			{
				this.USER_TASK_SORT_ORDERValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for the control of the fulltext service.
		/// </summary>
		public EloixClient.IndexServer.VtDocC VT_DOC
		{
			get
			{
				return VT_DOCValue;
			}
			set
			{
				this.VT_DOCValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for Workflows
		/// </summary>
		public EloixClient.IndexServer.WFDiagramC WORKFLOW
		{
			get
			{
				return WORKFLOWValue;
			}
			set
			{
				this.WORKFLOWValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for workflow nodes
		/// </summary>
		public EloixClient.IndexServer.WFNodeC WORKFLOW_NODE
		{
			get
			{
				return WORKFLOW_NODEValue;
			}
			set
			{
				this.WORKFLOW_NODEValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for workflow node association types used by WFNodeMatrix
		/// </summary>
		public EloixClient.IndexServer.WFNodeMatrixC WORKFLOW_NODE_ASSOC_TYPE
		{
			get
			{
				return WORKFLOW_NODE_ASSOC_TYPEValue;
			}
			set
			{
				this.WORKFLOW_NODE_ASSOC_TYPEValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for workflows
		/// </summary>
		public EloixClient.IndexServer.WFTypeC WORKFLOW_TYPE
		{
			get
			{
				return WORKFLOW_TYPEValue;
			}
			set
			{
				this.WORKFLOW_TYPEValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for function invalidateCache.
		/// </summary>
		public EloixClient.IndexServer.InvalidateCacheC INVALIDATE_CACHE
		{
			get
			{
				return INVALIDATE_CACHEValue;
			}
			set
			{
				this.INVALIDATE_CACHEValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for WFVersion.
		/// </summary>
		public EloixClient.IndexServer.WFVersionC WORKFLOW_VERSION
		{
			get
			{
				return WORKFLOW_VERSIONValue;
			}
			set
			{
				this.WORKFLOW_VERSIONValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for NoteTemplate
		/// </summary>
		public EloixClient.IndexServer.NoteTemplateC NOTE_TEMPLATE
		{
			get
			{
				return NOTE_TEMPLATEValue;
			}
			set
			{
				this.NOTE_TEMPLATEValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for NoteFreehand
		/// </summary>
		public EloixClient.IndexServer.NoteFreehandC NOTE_FREEHAND
		{
			get
			{
				return NOTE_FREEHANDValue;
			}
			set
			{
				this.NOTE_FREEHANDValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for getArchiveStatistics
		/// </summary>
		public EloixClient.IndexServer.ArchiveStatisticsOptionsC ARCHIVE_STATISTICS_OPTIONS
		{
			get
			{
				return ARCHIVE_STATISTICS_OPTIONSValue;
			}
			set
			{
				this.ARCHIVE_STATISTICS_OPTIONSValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for MapDomain, checkoutMap etc.
		/// </summary>
		public EloixClient.IndexServer.MapDomainC MAP_CONFIG
		{
			get
			{
				return MAP_CONFIGValue;
			}
			set
			{
				this.MAP_CONFIGValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for MapDomain, checkoutMap etc.
		/// </summary>
		public EloixClient.IndexServer.MapDomainC MAP_DOMAIN
		{
			get
			{
				return MAP_DOMAINValue;
			}
			set
			{
				this.MAP_DOMAINValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for IndexServer options.
		/// </summary>
		public EloixClient.IndexServer.EloIxOptC ELO_IX_OPT
		{
			get
			{
				return ELO_IX_OPTValue;
			}
			set
			{
				this.ELO_IX_OPTValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for class Any.
		/// </summary>
		public EloixClient.IndexServer.AnyC ANY
		{
			get
			{
				return ANYValue;
			}
			set
			{
				this.ANYValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for {@link IXServicePortIF#getSearchTerms(ClientInfo, FindInfo, int)}.
		/// </summary>
		public EloixClient.IndexServer.SearchTermsC SEARCH_TERMS
		{
			get
			{
				return SEARCH_TERMSValue;
			}
			set
			{
				this.SEARCH_TERMSValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for the administration mode.
		/// </summary>
		public EloixClient.IndexServer.AdminModeC ADMIN_MODE
		{
			get
			{
				return ADMIN_MODEValue;
			}
			set
			{
				this.ADMIN_MODEValue = value;
			}
		}
		
		
		/// <summary>
		/// Constanst for the fulltext configuration.
		/// </summary>
		public EloixClient.IndexServer.FulltextConfigC FULLTEXT_CONFIG
		{
			get
			{
				return FULLTEXT_CONFIGValue;
			}
			set
			{
				this.FULLTEXT_CONFIGValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for the class ServerInfoDM.
		/// </summary>
		public EloixClient.IndexServer.ServerInfoDMC SERVER_INFO_DM
		{
			get
			{
				return SERVER_INFO_DMValue;
			}
			set
			{
				this.SERVER_INFO_DMValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for the class FindDirect.
		/// </summary>
		public EloixClient.IndexServer.FindDirectC FIND_DIRECT
		{
			get
			{
				return FIND_DIRECTValue;
			}
			set
			{
				this.FIND_DIRECTValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for feed actions.
		/// </summary>
		public EloixClient.IndexServer.feed.ActionC ACTION
		{
			get
			{
				return ACTIONValue;
			}
			set
			{
				this.ACTIONValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for document feed.
		/// </summary>
		public EloixClient.IndexServer.feed.FeedC FEED
		{
			get
			{
				return FEEDValue;
			}
			set
			{
				this.FEEDValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for translate term.
		/// </summary>
		public EloixClient.IndexServer.TranslateTermC TRANSLATE_TERM
		{
			get
			{
				return TRANSLATE_TERMValue;
			}
			set
			{
				this.TRANSLATE_TERMValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for event busses.
		/// </summary>
		public EloixClient.IndexServer.EventBusC EVENT_BUS
		{
			get
			{
				return EVENT_BUSValue;
			}
			set
			{
				this.EVENT_BUSValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for preview image info.
		/// </summary>
		public EloixClient.IndexServer.PreviewImageInfoC PREVIEW_IMAGE_INFO
		{
			get
			{
				return PREVIEW_IMAGE_INFOValue;
			}
			set
			{
				this.PREVIEW_IMAGE_INFOValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for resolving rights.
		/// </summary>
		public EloixClient.IndexServer.ResolveRightsResultC RESOLVE_RIGHTS
		{
			get
			{
				return RESOLVE_RIGHTSValue;
			}
			set
			{
				this.RESOLVE_RIGHTSValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for {@link de.elo.ix.client.feed.FeedService#findFirstActions(ClientInfo, de.elo.ix.client.feed.FindActionsInfo, int, de.elo.ix.client.feed.ActionZ)}.
		/// </summary>
		public EloixClient.IndexServer.feed.FindActionsInfoC FIND_ACTIONS_INFO
		{
			get
			{
				return FIND_ACTIONS_INFOValue;
			}
			set
			{
				this.FIND_ACTIONS_INFOValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for Subscription
		/// </summary>
		public EloixClient.IndexServer.SubscriptionC SUBSCRIPTION
		{
			get
			{
				return SUBSCRIPTIONValue;
			}
			set
			{
				this.SUBSCRIPTIONValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for MapData
		/// </summary>
		public EloixClient.IndexServer.MapDataC MAP_DATA
		{
			get
			{
				return MAP_DATAValue;
			}
			set
			{
				this.MAP_DATAValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for class MapHist.
		/// </summary>
		public EloixClient.IndexServer.MapHistC MAP_HIST
		{
			get
			{
				return MAP_HISTValue;
			}
			set
			{
				this.MAP_HISTValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for function {@link IXServicePortIF#exportWorkflow(ClientInfo, WorkflowExportOptions)}.
		/// </summary>
		public EloixClient.IndexServer.WorkflowExportOptionsC WORKFLOW_EXPORT_OPTIONS
		{
			get
			{
				return WORKFLOW_EXPORT_OPTIONSValue;
			}
			set
			{
				this.WORKFLOW_EXPORT_OPTIONSValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for workflow history.
		/// </summary>
		public EloixClient.IndexServer.WFNodeHistoryC WORKFLOW_NODE_HISTORY
		{
			get
			{
				return WORKFLOW_NODE_HISTORYValue;
			}
			set
			{
				this.WORKFLOW_NODE_HISTORYValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for storage mask index line templates.
		/// </summary>
		public EloixClient.IndexServer.DocMaskLineTemplateC DOC_MASK_LINE_TEMPLATE
		{
			get
			{
				return DOC_MASK_LINE_TEMPLATEValue;
			}
			set
			{
				this.DOC_MASK_LINE_TEMPLATEValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for public download.
		/// </summary>
		public EloixClient.IndexServer.PublicDownloadC PUBLIC_DOWNLOAD
		{
			get
			{
				return PUBLIC_DOWNLOADValue;
			}
			set
			{
				this.PUBLIC_DOWNLOADValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for FileDataC.
		/// </summary>
		public EloixClient.IndexServer.FileDataC FILE_DATA
		{
			get
			{
				return FILE_DATAValue;
			}
			set
			{
				this.FILE_DATAValue = value;
			}
		}
		
		
		/// <summary>
		/// Constants for OcrInfoC.
		/// </summary>
		public EloixClient.IndexServer.OcrInfoC OCR_INFO
		{
			get
			{
				return OCR_INFOValue;
			}
			set
			{
				this.OCR_INFOValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Version information used in serialization with IxDataStream
		/// </summary>
		public const String STREAM_VERSION = "10.17.080.003";

		protected EloixClient.IndexServer.AccessC ACCESSValue;

		protected EloixClient.IndexServer.AclItemC ACL_ITEMValue;

		protected EloixClient.IndexServer.ActivityC ACTIVITYValue;

		protected EloixClient.IndexServer.ActivityProjectC ACTIVITY_PROJECTValue;

		protected EloixClient.IndexServer.AlertC ALERTValue;

		protected EloixClient.IndexServer.ArchivingModeC ARCHIVING_MODEValue;

		protected EloixClient.IndexServer.CheckinUsersC CHECKIN_USERSValue;

		protected EloixClient.IndexServer.CheckoutUsersC CHECKOUT_USERSValue;

		protected EloixClient.IndexServer.ColorDataC COLORValue;

		protected EloixClient.IndexServer.ConfigFileC CONFIG_FILEValue;

		protected EloixClient.IndexServer.CopySordC COPY_SORDValue;

		protected EloixClient.IndexServer.CounterInfoC COUNTER_INFOValue;

		protected EloixClient.IndexServer.DocMaskC DOC_MASKValue;

		protected EloixClient.IndexServer.DocMaskLineC DOC_MASK_LINEValue;

		protected EloixClient.IndexServer.DocVersionC DOC_VERSIONValue;

		protected EloixClient.IndexServer.EditInfoC EDIT_INFOValue;

		protected EloixClient.IndexServer.ExportOptionsC EXPORT_OPTIONSValue;

		protected EloixClient.IndexServer.ImportOptionsC IMPORT_OPTIONSValue;

		protected EloixClient.IndexServer.IXExceptionC IXEXCEPTIONValue;

		protected EloixClient.IndexServer.KeywordC KEYWORDValue;

		protected EloixClient.IndexServer.LinkSordC LINK_SORDValue;

		protected EloixClient.IndexServer.LockC LOCKValue;

		protected EloixClient.IndexServer.NavigationInfoC NAV_INFOValue;

		protected EloixClient.IndexServer.NoteC NOTEValue;

		protected EloixClient.IndexServer.ObjKeyC OBJ_KEYValue;

		protected EloixClient.IndexServer.ProcessInfoC PROCESS_INFOValue;

		protected EloixClient.IndexServer.ReminderC REMINDERValue;

		protected EloixClient.IndexServer.ReplSetNameC REPL_SET_NAMEValue;

		protected EloixClient.IndexServer.ReportC REPORTValue;

		protected EloixClient.IndexServer.ReportInfoC REPORT_INFOValue;

		protected EloixClient.IndexServer.ReportModeC REPORT_MODEValue;

		protected EloixClient.IndexServer.ReportOptionsC REPORT_OPTIONSValue;

		protected EloixClient.IndexServer.SearchModeC SEARCH_MODEValue;

		protected EloixClient.IndexServer.ServerStateC SERVER_STATEValue;

		protected EloixClient.IndexServer.SessionOptionsC SESSION_OPTIONSValue;

		protected EloixClient.IndexServer.SordC SORDValue;

		protected EloixClient.IndexServer.SordHistC SORD_HISTValue;

		protected EloixClient.IndexServer.SordHistKeyC SORD_HIST_KEYValue;

		protected EloixClient.IndexServer.SordTypeC SORD_TYPEValue;

		protected EloixClient.IndexServer.SortOrderC SORT_ORDERValue;

		protected EloixClient.IndexServer.StoreInfoC STORE_INFOValue;

		protected EloixClient.IndexServer.WFTakeNodeC TAKE_NODEValue;

		protected EloixClient.IndexServer.ThesaurusC THESAURUSValue;

		protected EloixClient.IndexServer.UserInfoC USER_INFOValue;

		protected EloixClient.IndexServer.UserProfileC USER_PROFILEValue;

		protected EloixClient.IndexServer.UserTaskPriorityC USER_TASK_PRIORITYValue;

		protected EloixClient.IndexServer.UserTaskSortOrderC USER_TASK_SORT_ORDERValue;

		protected EloixClient.IndexServer.VtDocC VT_DOCValue;

		protected EloixClient.IndexServer.WFDiagramC WORKFLOWValue;

		protected EloixClient.IndexServer.WFNodeC WORKFLOW_NODEValue;

		protected EloixClient.IndexServer.WFNodeMatrixC WORKFLOW_NODE_ASSOC_TYPEValue;

		protected EloixClient.IndexServer.WFTypeC WORKFLOW_TYPEValue;

		protected EloixClient.IndexServer.InvalidateCacheC INVALIDATE_CACHEValue;

		protected EloixClient.IndexServer.WFVersionC WORKFLOW_VERSIONValue;

		protected EloixClient.IndexServer.NoteTemplateC NOTE_TEMPLATEValue;

		protected EloixClient.IndexServer.NoteFreehandC NOTE_FREEHANDValue;

		protected EloixClient.IndexServer.ArchiveStatisticsOptionsC ARCHIVE_STATISTICS_OPTIONSValue;

		protected EloixClient.IndexServer.MapDomainC MAP_CONFIGValue;

		protected EloixClient.IndexServer.MapDomainC MAP_DOMAINValue;

		protected EloixClient.IndexServer.EloIxOptC ELO_IX_OPTValue;

		protected EloixClient.IndexServer.AnyC ANYValue;

		protected EloixClient.IndexServer.SearchTermsC SEARCH_TERMSValue;

		protected EloixClient.IndexServer.AdminModeC ADMIN_MODEValue;

		protected EloixClient.IndexServer.FulltextConfigC FULLTEXT_CONFIGValue;

		protected EloixClient.IndexServer.ServerInfoDMC SERVER_INFO_DMValue;

		protected EloixClient.IndexServer.FindDirectC FIND_DIRECTValue;

		protected EloixClient.IndexServer.feed.ActionC ACTIONValue;

		protected EloixClient.IndexServer.feed.FeedC FEEDValue;

		protected EloixClient.IndexServer.TranslateTermC TRANSLATE_TERMValue;

		protected EloixClient.IndexServer.EventBusC EVENT_BUSValue;

		protected EloixClient.IndexServer.PreviewImageInfoC PREVIEW_IMAGE_INFOValue;

		protected EloixClient.IndexServer.ResolveRightsResultC RESOLVE_RIGHTSValue;

		protected EloixClient.IndexServer.feed.FindActionsInfoC FIND_ACTIONS_INFOValue;

		protected EloixClient.IndexServer.SubscriptionC SUBSCRIPTIONValue;

		protected EloixClient.IndexServer.MapDataC MAP_DATAValue;

		protected EloixClient.IndexServer.MapHistC MAP_HISTValue;

		protected EloixClient.IndexServer.WorkflowExportOptionsC WORKFLOW_EXPORT_OPTIONSValue;

		protected EloixClient.IndexServer.WFNodeHistoryC WORKFLOW_NODE_HISTORYValue;

		protected EloixClient.IndexServer.DocMaskLineTemplateC DOC_MASK_LINE_TEMPLATEValue;

		protected EloixClient.IndexServer.PublicDownloadC PUBLIC_DOWNLOADValue;

		protected EloixClient.IndexServer.FileDataC FILE_DATAValue;

		protected EloixClient.IndexServer.OcrInfoC OCR_INFOValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1264954948L;		
	} // end class
}  // end namespace

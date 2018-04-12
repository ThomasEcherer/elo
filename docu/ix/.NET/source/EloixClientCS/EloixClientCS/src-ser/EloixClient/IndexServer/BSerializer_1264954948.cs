//
// Serializer for de.elo.ix.client.IXServicePortC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1264954948 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1264954948();
		
		public BSerializer_1264954948()
			: base(1264954948) {}
		
		public BSerializer_1264954948(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			IXServicePortC obj = (IXServicePortC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ACCESS, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ACL_ITEM, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ACTIVITY, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ACTIVITY_PROJECT, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ALERT, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ARCHIVING_MODE, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.CHECKIN_USERS, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.CHECKOUT_USERS, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.COLOR, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.CONFIG_FILE, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.COPY_SORD, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.COUNTER_INFO, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.DOC_MASK, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.DOC_MASK_LINE, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.DOC_VERSION, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.EDIT_INFO, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.EXPORT_OPTIONS, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.IMPORT_OPTIONS, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.IXEXCEPTION, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.KEYWORD, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.LINK_SORD, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.LOCK, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.NAV_INFO, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.NOTE, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.OBJ_KEY, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.PROCESS_INFO, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.REMINDER, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.REPL_SET_NAME, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.REPORT, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.REPORT_INFO, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.REPORT_MODE, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.REPORT_OPTIONS, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.SEARCH_MODE, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.SERVER_STATE, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.SESSION_OPTIONS, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.SORD, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.SORD_HIST, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.SORD_HIST_KEY, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.SORD_TYPE, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.SORT_ORDER, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.STORE_INFO, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.TAKE_NODE, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.THESAURUS, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.USER_INFO, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.USER_PROFILE, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.USER_TASK_PRIORITY, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.USER_TASK_SORT_ORDER, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.VT_DOC, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.WORKFLOW, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.WORKFLOW_NODE, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.WORKFLOW_NODE_ASSOC_TYPE, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.WORKFLOW_TYPE, false, null);
			if (version >= 600000093000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.INVALIDATE_CACHE, false, null);
				if (version >= 700000000000008L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.WORKFLOW_VERSION, false, null);
					if (version >= 700000000000024L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bout.writeObj(obj.NOTE_TEMPLATE, false, null);
						if (version >= 700000000000025L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bout.writeObj(obj.NOTE_FREEHAND, false, null);
							if (version >= 700000020000009L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bout.writeObj(obj.ARCHIVE_STATISTICS_OPTIONS, false, null);
								if (version >= 700000040000001L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bout.writeObj(obj.MAP_CONFIG, false, null);
									if (version >= 700000040000003L) {
										// checkpoint byps.gen.cs.PrintContext:494
										bout.writeObj(obj.ELO_IX_OPT, false, null);
										if (version >= 700000040000019L) {
											// checkpoint byps.gen.cs.PrintContext:494
											bout.writeObj(obj.ANY, false, null);
											if (version >= 700000040000021L) {
												// checkpoint byps.gen.cs.PrintContext:494
												bout.writeObj(obj.SEARCH_TERMS, false, null);
												if (version >= 700000040000022L) {
													// checkpoint byps.gen.cs.PrintContext:494
													bout.writeObj(obj.ADMIN_MODE, false, null);
													if (version >= 700000040000023L) {
														// checkpoint byps.gen.cs.PrintContext:494
														bout.writeObj(obj.FULLTEXT_CONFIG, false, null);
														if (version >= 700000040000026L) {
															// checkpoint byps.gen.cs.PrintContext:494
															bout.writeObj(obj.SERVER_INFO_DM, false, null);
															if (version >= 800000000000001L) {
																// checkpoint byps.gen.cs.PrintContext:494
																bout.writeObj(obj.FIND_DIRECT, false, null);
																if (version >= 800000010000000L) {
																	// checkpoint byps.gen.cs.PrintContext:494
																	bout.writeObj(obj.EVENT_BUS, false, null);
																	if (version >= 800000012000004L) {
																		// checkpoint byps.gen.cs.PrintContext:494
																		bout.writeObj(obj.MAP_DOMAIN, false, null);
																		if (version >= 900000000000003L) {
																			// checkpoint byps.gen.cs.PrintContext:494
																			bout.writeObj(obj.ACTION, false, null);
																			// checkpoint byps.gen.cs.PrintContext:494
																			bout.writeObj(obj.FEED, false, null);
																			if (version >= 900000000000007L) {
																				// checkpoint byps.gen.cs.PrintContext:494
																				bout.writeObj(obj.TRANSLATE_TERM, false, null);
																				if (version >= 900000000000015L) {
																					// checkpoint byps.gen.cs.PrintContext:494
																					bout.writeObj(obj.PREVIEW_IMAGE_INFO, false, null);
																					if (version >= 900000000000020L) {
																						// checkpoint byps.gen.cs.PrintContext:494
																						bout.writeObj(obj.RESOLVE_RIGHTS, false, null);
																						if (version >= 900000000000037L) {
																							// checkpoint byps.gen.cs.PrintContext:494
																							bout.writeObj(obj.FIND_ACTIONS_INFO, false, null);
																							if (version >= 900000014000003L) {
																								// checkpoint byps.gen.cs.PrintContext:494
																								bout.writeObj(obj.SUBSCRIPTION, false, null);
																								if (version >= 900000014000009L) {
																									// checkpoint byps.gen.cs.PrintContext:494
																									bout.writeObj(obj.MAP_DATA, false, null);
																									if (version >= 900000018000002L) {
																										// checkpoint byps.gen.cs.PrintContext:494
																										bout.writeObj(obj.MAP_HIST, false, null);
																										// checkpoint byps.gen.cs.PrintContext:494
																										bout.writeObj(obj.WORKFLOW_EXPORT_OPTIONS, false, null);
																										if (version >= 900000030000018L) {
																											// checkpoint byps.gen.cs.PrintContext:494
																											bout.writeObj(obj.WORKFLOW_NODE_HISTORY, false, null);
																											if (version >= 900000030000030L) {
																												// checkpoint byps.gen.cs.PrintContext:494
																												bout.writeObj(obj.PUBLIC_DOWNLOAD, false, null);
																												if (version >= 900990009000002L) {
																													// checkpoint byps.gen.cs.PrintContext:494
																													bout.writeObj(obj.DOC_MASK_LINE_TEMPLATE, false, null);
																													if (version >= 1000000020000006L) {
																														// checkpoint byps.gen.cs.PrintContext:494
																														bout.writeObj(obj.FILE_DATA, false, null);
																														if (version >= 1000170059000002L) {
																															// checkpoint byps.gen.cs.PrintContext:494
																															bout.writeObj(obj.OCR_INFO, false, null);
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			IXServicePortC obj = (IXServicePortC)(obj1 != null ? obj1 : bin.onObjectCreated(new IXServicePortC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ACCESS = (EloixClient.IndexServer.AccessC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ACL_ITEM = (EloixClient.IndexServer.AclItemC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ACTIVITY = (EloixClient.IndexServer.ActivityC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ACTIVITY_PROJECT = (EloixClient.IndexServer.ActivityProjectC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ALERT = (EloixClient.IndexServer.AlertC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ARCHIVING_MODE = (EloixClient.IndexServer.ArchivingModeC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.CHECKIN_USERS = (EloixClient.IndexServer.CheckinUsersC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.CHECKOUT_USERS = (EloixClient.IndexServer.CheckoutUsersC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.COLOR = (EloixClient.IndexServer.ColorDataC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.CONFIG_FILE = (EloixClient.IndexServer.ConfigFileC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.COPY_SORD = (EloixClient.IndexServer.CopySordC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.COUNTER_INFO = (EloixClient.IndexServer.CounterInfoC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.DOC_MASK = (EloixClient.IndexServer.DocMaskC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.DOC_MASK_LINE = (EloixClient.IndexServer.DocMaskLineC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.DOC_VERSION = (EloixClient.IndexServer.DocVersionC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.EDIT_INFO = (EloixClient.IndexServer.EditInfoC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.EXPORT_OPTIONS = (EloixClient.IndexServer.ExportOptionsC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.IMPORT_OPTIONS = (EloixClient.IndexServer.ImportOptionsC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.IXEXCEPTION = (EloixClient.IndexServer.IXExceptionC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.KEYWORD = (EloixClient.IndexServer.KeywordC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.LINK_SORD = (EloixClient.IndexServer.LinkSordC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.LOCK = (EloixClient.IndexServer.LockC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.NAV_INFO = (EloixClient.IndexServer.NavigationInfoC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.NOTE = (EloixClient.IndexServer.NoteC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.OBJ_KEY = (EloixClient.IndexServer.ObjKeyC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.PROCESS_INFO = (EloixClient.IndexServer.ProcessInfoC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.REMINDER = (EloixClient.IndexServer.ReminderC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.REPL_SET_NAME = (EloixClient.IndexServer.ReplSetNameC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.REPORT = (EloixClient.IndexServer.ReportC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.REPORT_INFO = (EloixClient.IndexServer.ReportInfoC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.REPORT_MODE = (EloixClient.IndexServer.ReportModeC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.REPORT_OPTIONS = (EloixClient.IndexServer.ReportOptionsC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.SEARCH_MODE = (EloixClient.IndexServer.SearchModeC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.SERVER_STATE = (EloixClient.IndexServer.ServerStateC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.SESSION_OPTIONS = (EloixClient.IndexServer.SessionOptionsC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.SORD = (EloixClient.IndexServer.SordC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.SORD_HIST = (EloixClient.IndexServer.SordHistC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.SORD_HIST_KEY = (EloixClient.IndexServer.SordHistKeyC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.SORD_TYPE = (EloixClient.IndexServer.SordTypeC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.SORT_ORDER = (EloixClient.IndexServer.SortOrderC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.STORE_INFO = (EloixClient.IndexServer.StoreInfoC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.TAKE_NODE = (EloixClient.IndexServer.WFTakeNodeC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.THESAURUS = (EloixClient.IndexServer.ThesaurusC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.USER_INFO = (EloixClient.IndexServer.UserInfoC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.USER_PROFILE = (EloixClient.IndexServer.UserProfileC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.USER_TASK_PRIORITY = (EloixClient.IndexServer.UserTaskPriorityC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.USER_TASK_SORT_ORDER = (EloixClient.IndexServer.UserTaskSortOrderC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.VT_DOC = (EloixClient.IndexServer.VtDocC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.WORKFLOW = (EloixClient.IndexServer.WFDiagramC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.WORKFLOW_NODE = (EloixClient.IndexServer.WFNodeC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.WORKFLOW_NODE_ASSOC_TYPE = (EloixClient.IndexServer.WFNodeMatrixC)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.WORKFLOW_TYPE = (EloixClient.IndexServer.WFTypeC)bin.readObj(false, null);
			if (version >= 600000093000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.INVALIDATE_CACHE = (EloixClient.IndexServer.InvalidateCacheC)bin.readObj(false, null);
				if (version >= 700000000000008L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.WORKFLOW_VERSION = (EloixClient.IndexServer.WFVersionC)bin.readObj(false, null);
					if (version >= 700000000000024L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.NOTE_TEMPLATE = (EloixClient.IndexServer.NoteTemplateC)bin.readObj(false, null);
						if (version >= 700000000000025L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.NOTE_FREEHAND = (EloixClient.IndexServer.NoteFreehandC)bin.readObj(false, null);
							if (version >= 700000020000009L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.ARCHIVE_STATISTICS_OPTIONS = (EloixClient.IndexServer.ArchiveStatisticsOptionsC)bin.readObj(false, null);
								if (version >= 700000040000001L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.MAP_CONFIG = (EloixClient.IndexServer.MapDomainC)bin.readObj(false, null);
									if (version >= 700000040000003L) {
										// checkpoint byps.gen.cs.PrintContext:449
										obj.ELO_IX_OPT = (EloixClient.IndexServer.EloIxOptC)bin.readObj(false, null);
										if (version >= 700000040000019L) {
											// checkpoint byps.gen.cs.PrintContext:449
											obj.ANY = (EloixClient.IndexServer.AnyC)bin.readObj(false, null);
											if (version >= 700000040000021L) {
												// checkpoint byps.gen.cs.PrintContext:449
												obj.SEARCH_TERMS = (EloixClient.IndexServer.SearchTermsC)bin.readObj(false, null);
												if (version >= 700000040000022L) {
													// checkpoint byps.gen.cs.PrintContext:449
													obj.ADMIN_MODE = (EloixClient.IndexServer.AdminModeC)bin.readObj(false, null);
													if (version >= 700000040000023L) {
														// checkpoint byps.gen.cs.PrintContext:449
														obj.FULLTEXT_CONFIG = (EloixClient.IndexServer.FulltextConfigC)bin.readObj(false, null);
														if (version >= 700000040000026L) {
															// checkpoint byps.gen.cs.PrintContext:449
															obj.SERVER_INFO_DM = (EloixClient.IndexServer.ServerInfoDMC)bin.readObj(false, null);
															if (version >= 800000000000001L) {
																// checkpoint byps.gen.cs.PrintContext:449
																obj.FIND_DIRECT = (EloixClient.IndexServer.FindDirectC)bin.readObj(false, null);
																if (version >= 800000010000000L) {
																	// checkpoint byps.gen.cs.PrintContext:449
																	obj.EVENT_BUS = (EloixClient.IndexServer.EventBusC)bin.readObj(false, null);
																	if (version >= 800000012000004L) {
																		// checkpoint byps.gen.cs.PrintContext:449
																		obj.MAP_DOMAIN = (EloixClient.IndexServer.MapDomainC)bin.readObj(false, null);
																		if (version >= 900000000000003L) {
																			// checkpoint byps.gen.cs.PrintContext:449
																			obj.ACTION = (EloixClient.IndexServer.feed.ActionC)bin.readObj(false, null);
																			// checkpoint byps.gen.cs.PrintContext:449
																			obj.FEED = (EloixClient.IndexServer.feed.FeedC)bin.readObj(false, null);
																			if (version >= 900000000000007L) {
																				// checkpoint byps.gen.cs.PrintContext:449
																				obj.TRANSLATE_TERM = (EloixClient.IndexServer.TranslateTermC)bin.readObj(false, null);
																				if (version >= 900000000000015L) {
																					// checkpoint byps.gen.cs.PrintContext:449
																					obj.PREVIEW_IMAGE_INFO = (EloixClient.IndexServer.PreviewImageInfoC)bin.readObj(false, null);
																					if (version >= 900000000000020L) {
																						// checkpoint byps.gen.cs.PrintContext:449
																						obj.RESOLVE_RIGHTS = (EloixClient.IndexServer.ResolveRightsResultC)bin.readObj(false, null);
																						if (version >= 900000000000037L) {
																							// checkpoint byps.gen.cs.PrintContext:449
																							obj.FIND_ACTIONS_INFO = (EloixClient.IndexServer.feed.FindActionsInfoC)bin.readObj(false, null);
																							if (version >= 900000014000003L) {
																								// checkpoint byps.gen.cs.PrintContext:449
																								obj.SUBSCRIPTION = (EloixClient.IndexServer.SubscriptionC)bin.readObj(false, null);
																								if (version >= 900000014000009L) {
																									// checkpoint byps.gen.cs.PrintContext:449
																									obj.MAP_DATA = (EloixClient.IndexServer.MapDataC)bin.readObj(false, null);
																									if (version >= 900000018000002L) {
																										// checkpoint byps.gen.cs.PrintContext:449
																										obj.MAP_HIST = (EloixClient.IndexServer.MapHistC)bin.readObj(false, null);
																										// checkpoint byps.gen.cs.PrintContext:449
																										obj.WORKFLOW_EXPORT_OPTIONS = (EloixClient.IndexServer.WorkflowExportOptionsC)bin.readObj(false, null);
																										if (version >= 900000030000018L) {
																											// checkpoint byps.gen.cs.PrintContext:449
																											obj.WORKFLOW_NODE_HISTORY = (EloixClient.IndexServer.WFNodeHistoryC)bin.readObj(false, null);
																											if (version >= 900000030000030L) {
																												// checkpoint byps.gen.cs.PrintContext:449
																												obj.PUBLIC_DOWNLOAD = (EloixClient.IndexServer.PublicDownloadC)bin.readObj(false, null);
																												if (version >= 900990009000002L) {
																													// checkpoint byps.gen.cs.PrintContext:449
																													obj.DOC_MASK_LINE_TEMPLATE = (EloixClient.IndexServer.DocMaskLineTemplateC)bin.readObj(false, null);
																													if (version >= 1000000020000006L) {
																														// checkpoint byps.gen.cs.PrintContext:449
																														obj.FILE_DATA = (EloixClient.IndexServer.FileDataC)bin.readObj(false, null);
																														if (version >= 1000170059000002L) {
																															// checkpoint byps.gen.cs.PrintContext:449
																															obj.OCR_INFO = (EloixClient.IndexServer.OcrInfoC)bin.readObj(false, null);
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace

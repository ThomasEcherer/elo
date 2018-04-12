//
// Serializer for de.elo.ix.client.FindResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1301335819 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1301335819();
		
		public BSerializer_1301335819()
			: base(1301335819) {}
		
		public BSerializer_1301335819(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindResult obj = (FindResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.breakTimeout);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.breakTotalCount);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.count);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.moreResults);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.searchId);
			if (version >= 700000040000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.estimatedCount);
				if (version >= 800000020000006L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.dynamicFolder);
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.configFiles, false, EloixClient.IndexServer.BSerializer_1737266313.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ids, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.reportInfos, false, EloixClient.IndexServer.BSerializer_1243223397.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sords, false, EloixClient.IndexServer.BSerializer_919539303.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.tasks, false, EloixClient.IndexServer.BSerializer_829657911.instance);
			if (version >= 600000094000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.workflows, false, EloixClient.IndexServer.BSerializer_838894319.instance);
				if (version >= 700000000000000L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.translateTerms, false, EloixClient.IndexServer.BSerializer_1088095067.instance);
					if (version >= 700000040000002L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bout.writeObj(obj.fulltextResultItems, false, EloixClient.IndexServer.BSerializer_804274709.instance);
						if (version >= 700000040000008L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bout.writeObj(obj.fulltextCtrlResultItems, false, EloixClient.IndexServer.BSerializer_1980589728.instance);
							if (version >= 800000036000000L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bout.writeObj(obj.jobStates, false, EloixClient.IndexServer.BSerializer_1788243283.instance);
								if (version >= 900000000000003L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bout.writeObj(obj.actions, false, EloixClient.IndexServer.BSerializer_433625553.instance);
									if (version >= 900000000000004L) {
										// checkpoint byps.gen.cs.PrintContext:494
										bout.writeObj(obj.feeds, false, EloixClient.IndexServer.BSerializer_425536672.instance);
										if (version >= 900000014000003L) {
											// checkpoint byps.gen.cs.PrintContext:494
											bout.writeObj(obj.subscriptions, false, EloixClient.IndexServer.BSerializer_1862275569.instance);
											if (version >= 900000016000003L) {
												// checkpoint byps.gen.cs.PrintContext:494
												bout.writeObj(obj.notes, false, EloixClient.IndexServer.BSerializer_2111020589.instance);
												if (version >= 900000022000006L) {
													// checkpoint byps.gen.cs.PrintContext:494
													bout.writeObj(obj.notifications, false, EloixClient.IndexServer.BSerializer_1147263971.instance);
													if (version >= 900000022000015L) {
														// checkpoint byps.gen.cs.PrintContext:494
														bout.writeObj(obj.hashTagRelations, false, EloixClient.IndexServer.BSerializer_1403472717.instance);
														if (version >= 900000022000020L) {
															// checkpoint byps.gen.cs.PrintContext:494
															bout.writeObj(obj.hashTags, false, EloixClient.IndexServer.BSerializer_1239602222.instance);
															if (version >= 900000050000001L) {
																// checkpoint byps.gen.cs.PrintContext:494
																bout.writeObj(obj.userInfos, false, EloixClient.IndexServer.BSerializer_1870226832.instance);
																// checkpoint byps.gen.cs.PrintContext:494
																bout.writeObj(obj.userNames, false, EloixClient.IndexServer.BSerializer_1874463571.instance);
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
			FindResult obj = (FindResult)(obj1 != null ? obj1 : bin.onObjectCreated(new FindResult()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.breakTimeout = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.breakTotalCount = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.count = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.moreResults = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.searchId = bbuf.getString();
			if (version >= 700000040000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.estimatedCount = bbuf.getInt();
				if (version >= 800000020000006L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.dynamicFolder = bbuf.getString();
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.configFiles = (EloixClient.IndexServer.ConfigFile[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1737266313.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ids = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.reportInfos = (EloixClient.IndexServer.ReportInfo[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1243223397.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sords = (EloixClient.IndexServer.Sord[])bin.readObj(false, EloixClient.IndexServer.BSerializer_919539303.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tasks = (EloixClient.IndexServer.UserTask[])bin.readObj(false, EloixClient.IndexServer.BSerializer_829657911.instance);
			if (version >= 600000094000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.workflows = (EloixClient.IndexServer.WFDiagram[])bin.readObj(false, EloixClient.IndexServer.BSerializer_838894319.instance);
				if (version >= 700000000000000L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.translateTerms = (EloixClient.IndexServer.TranslateTerm[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1088095067.instance);
					if (version >= 700000040000002L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.fulltextResultItems = (EloixClient.IndexServer.FindByFulltextResultItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_804274709.instance);
						if (version >= 700000040000008L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.fulltextCtrlResultItems = (EloixClient.IndexServer.FindByFulltextCtrlResultItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1980589728.instance);
							if (version >= 800000036000000L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.jobStates = (EloixClient.IndexServer.JobState[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1788243283.instance);
								if (version >= 900000000000003L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.actions = (EloixClient.IndexServer.feed.Action[])bin.readObj(false, EloixClient.IndexServer.BSerializer_433625553.instance);
									if (version >= 900000000000004L) {
										// checkpoint byps.gen.cs.PrintContext:449
										obj.feeds = (IDictionary<String,EloixClient.IndexServer.feed.Feed>)bin.readObj(false, null);
										if (version >= 900000014000003L) {
											// checkpoint byps.gen.cs.PrintContext:449
											obj.subscriptions = (IDictionary<String,EloixClient.IndexServer.Subscription>)bin.readObj(false, null);
											if (version >= 900000016000003L) {
												// checkpoint byps.gen.cs.PrintContext:449
												obj.notes = (IList<EloixClient.IndexServer.Note>)bin.readObj(false, null);
												if (version >= 900000022000006L) {
													// checkpoint byps.gen.cs.PrintContext:449
													obj.notifications = (IDictionary<String,EloixClient.IndexServer.Notification>)bin.readObj(false, null);
													if (version >= 900000022000015L) {
														// checkpoint byps.gen.cs.PrintContext:449
														obj.hashTagRelations = (IList<EloixClient.IndexServer.feed.HashTagRelation>)bin.readObj(false, null);
														if (version >= 900000022000020L) {
															// checkpoint byps.gen.cs.PrintContext:449
															obj.hashTags = (IDictionary<String,EloixClient.IndexServer.feed.HashTag>)bin.readObj(false, null);
															if (version >= 900000050000001L) {
																// checkpoint byps.gen.cs.PrintContext:449
																obj.userInfos = (IDictionary<int,EloixClient.IndexServer.UserInfo>)bin.readObj(false, null);
																// checkpoint byps.gen.cs.PrintContext:449
																obj.userNames = (IDictionary<int,EloixClient.IndexServer.UserName>)bin.readObj(false, null);
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

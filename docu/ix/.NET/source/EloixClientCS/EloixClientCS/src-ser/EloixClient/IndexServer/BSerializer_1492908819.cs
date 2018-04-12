//
// Serializer for de.elo.ix.client.WFCollectNode
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1492908819 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1492908819();
		
		public BSerializer_1492908819()
			: base(1492908819) {}
		
		public BSerializer_1492908819(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			WFCollectNode obj = (WFCollectNode)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.activateDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.active);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flowId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.flowName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.inUseDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nodeId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.nodeName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objType);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.prio);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.terminateDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.userId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userName);
			if (version >= 600000098000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.completionDateIso);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.overTimeLimit);
				if (version >= 700000000000000L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.userDelayDateIso);
					if (version >= 700000000000019L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.flowStatus);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.timeLimitIso);
						if (version >= 700000000000047L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.workflowOwnerId);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.workflowOwnerName);
							if (version >= 700000020000006L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putInt(obj.designDepartmentId);
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putString(obj.designDepartmentName);
								if (version >= 700000026000003L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.nodeComment);
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.objName);
									if (version >= 800000010000002L) {
										// checkpoint byps.gen.cs.PrintContext:494
										bbuf.putInt(obj.timeLimit);
										// checkpoint byps.gen.cs.PrintContext:494
										bbuf.putInt(obj.timeLimitUserId);
										// checkpoint byps.gen.cs.PrintContext:494
										bbuf.putString(obj.timeLimitUserName);
										if (version >= 800000022000000L) {
											// checkpoint byps.gen.cs.PrintContext:494
											bbuf.putString(obj.activateDateWorkflowIso);
											if (version >= 800000024000000L) {
												// checkpoint byps.gen.cs.PrintContext:494
												bbuf.putString(obj.formSpec);
												if (version >= 900000016000016L) {
													// checkpoint byps.gen.cs.PrintContext:494
													bbuf.putBoolean(obj.overTimeLimitAny);
													if (version >= 900000018000006L) {
														// checkpoint byps.gen.cs.PrintContext:494
														bbuf.putBoolean(obj.hidden);
														if (version >= 900000022000012L) {
															// checkpoint byps.gen.cs.PrintContext:494
															bbuf.putString(obj.flowNameTranslationKey);
															// checkpoint byps.gen.cs.PrintContext:494
															bbuf.putString(obj.nodeCommentTranslationKey);
															// checkpoint byps.gen.cs.PrintContext:494
															bbuf.putString(obj.nodeNameTranslationKey);
															if (version >= 900000022000018L) {
																// checkpoint byps.gen.cs.PrintContext:494
																bbuf.putString(obj.properties);
																if (version >= 900000022000019L) {
																	// checkpoint byps.gen.cs.PrintContext:494
																	bbuf.putString(obj.label);
																	if (version >= 900000030000021L) {
																		// checkpoint byps.gen.cs.PrintContext:494
																		bbuf.putString(obj.labelTranslationKey);
																		if (version >= 900000030000022L) {
																			// checkpoint byps.gen.cs.PrintContext:494
																			bbuf.putInt(obj.parentFlowId);
																			if (version >= 1000000000000004L) {
																				// checkpoint byps.gen.cs.PrintContext:494
																				bbuf.putInt(obj.callNodeId);
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
			if (version >= 700000000000019L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.timeLimitEscalations, false, EloixClient.IndexServer.BSerializer_1495941578.instance);
				if (version >= 800000022000000L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.timeLimitsWorkflow, false, EloixClient.IndexServer.BSerializer_1495941578.instance);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFCollectNode obj = (WFCollectNode)(obj1 != null ? obj1 : bin.onObjectCreated(new WFCollectNode()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.activateDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.active = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inUseDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objType = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.prio = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.terminateDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userName = bbuf.getString();
			if (version >= 600000098000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.completionDateIso = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.overTimeLimit = bbuf.getBoolean();
				if (version >= 700000000000000L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.userDelayDateIso = bbuf.getString();
					if (version >= 700000000000019L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.flowStatus = bbuf.getString();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.timeLimitIso = bbuf.getString();
						if (version >= 700000000000047L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.workflowOwnerId = bbuf.getInt();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.workflowOwnerName = bbuf.getString();
							if (version >= 700000020000006L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.designDepartmentId = bbuf.getInt();
								// checkpoint byps.gen.cs.PrintContext:449
								obj.designDepartmentName = bbuf.getString();
								if (version >= 700000026000003L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.nodeComment = bbuf.getString();
									// checkpoint byps.gen.cs.PrintContext:449
									obj.objName = bbuf.getString();
									if (version >= 800000010000002L) {
										// checkpoint byps.gen.cs.PrintContext:449
										obj.timeLimit = bbuf.getInt();
										// checkpoint byps.gen.cs.PrintContext:449
										obj.timeLimitUserId = bbuf.getInt();
										// checkpoint byps.gen.cs.PrintContext:449
										obj.timeLimitUserName = bbuf.getString();
										if (version >= 800000022000000L) {
											// checkpoint byps.gen.cs.PrintContext:449
											obj.activateDateWorkflowIso = bbuf.getString();
											if (version >= 800000024000000L) {
												// checkpoint byps.gen.cs.PrintContext:449
												obj.formSpec = bbuf.getString();
												if (version >= 900000016000016L) {
													// checkpoint byps.gen.cs.PrintContext:449
													obj.overTimeLimitAny = bbuf.getBoolean();
													if (version >= 900000018000006L) {
														// checkpoint byps.gen.cs.PrintContext:449
														obj.hidden = bbuf.getBoolean();
														if (version >= 900000022000012L) {
															// checkpoint byps.gen.cs.PrintContext:449
															obj.flowNameTranslationKey = bbuf.getString();
															// checkpoint byps.gen.cs.PrintContext:449
															obj.nodeCommentTranslationKey = bbuf.getString();
															// checkpoint byps.gen.cs.PrintContext:449
															obj.nodeNameTranslationKey = bbuf.getString();
															if (version >= 900000022000018L) {
																// checkpoint byps.gen.cs.PrintContext:449
																obj.properties = bbuf.getString();
																if (version >= 900000022000019L) {
																	// checkpoint byps.gen.cs.PrintContext:449
																	obj.label = bbuf.getString();
																	if (version >= 900000030000021L) {
																		// checkpoint byps.gen.cs.PrintContext:449
																		obj.labelTranslationKey = bbuf.getString();
																		if (version >= 900000030000022L) {
																			// checkpoint byps.gen.cs.PrintContext:449
																			obj.parentFlowId = bbuf.getInt();
																			if (version >= 1000000000000004L) {
																				// checkpoint byps.gen.cs.PrintContext:449
																				obj.callNodeId = bbuf.getInt();
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
			if (version >= 700000000000019L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.timeLimitEscalations = (EloixClient.IndexServer.WFTimeLimit[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1495941578.instance);
				if (version >= 800000022000000L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.timeLimitsWorkflow = (EloixClient.IndexServer.WFTimeLimit[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1495941578.instance);
				}
			}
			
			return obj;
		}
		
	}
} // namespace

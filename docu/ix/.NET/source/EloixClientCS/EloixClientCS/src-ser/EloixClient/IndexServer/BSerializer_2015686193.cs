//
// Serializer for de.elo.ix.client.WFNode
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2015686193 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2015686193();
		
		public BSerializer_2015686193()
			: base(2015686193) {}
		
		public BSerializer_2015686193(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			WFNode obj = (WFNode)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.allowActivate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.comment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.delayDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.delayDays);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.department2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.designDepartment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.enterDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.exitDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flags);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.inUseDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.isNext);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.moveCyclePosX);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nbOfDonesToExit);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.onEnter);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.onExit);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.posX);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.posY);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.tag);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.timeLimit);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.timeLimitIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.type);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.userId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userTerminate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.yesNoCondition);
			if (version >= 600000098000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.overTimeLimit);
				if (version >= 700000000000000L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.userDelayDateIso);
					if (version >= 700000000000015L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.processOnServerId);
						if (version >= 700000040000012L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.formSpec);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.iconId);
							if (version >= 900000018000005L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putString(obj.commentTranslationKey);
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putString(obj.nameTranslationKey);
								if (version >= 900000022000018L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.properties);
									if (version >= 900000022000019L) {
										// checkpoint byps.gen.cs.PrintContext:494
										bbuf.putString(obj.label);
										if (version >= 900000030000006L) {
											// checkpoint byps.gen.cs.PrintContext:494
											bbuf.putInt(obj.departmentGroup);
											if (version >= 900000030000021L) {
												// checkpoint byps.gen.cs.PrintContext:494
												bbuf.putString(obj.labelTranslationKey);
												if (version >= 900000030000022L) {
													// checkpoint byps.gen.cs.PrintContext:494
													bbuf.putInt(obj.retVal);
													// checkpoint byps.gen.cs.PrintContext:494
													bbuf.putInt(obj.subFlowId);
													if (version >= 900990009000003L) {
														// checkpoint byps.gen.cs.PrintContext:494
														bbuf.putString(obj.returnValue);
														if (version >= 900990009000004L) {
															// checkpoint byps.gen.cs.PrintContext:494
															bbuf.putInt(obj.subTemplateId);
															if (version >= 900990009000005L) {
																// checkpoint byps.gen.cs.PrintContext:494
																bbuf.putInt(obj.prio);
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
			if (version >= 700000000000016L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.timeLimitEscalations, false, EloixClient.IndexServer.BSerializer_1495941578.instance);
				if (version >= 700000000000021L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.objKeyNames, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.scriptNames, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFNode obj = (WFNode)(obj1 != null ? obj1 : bin.onObjectCreated(new WFNode()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.allowActivate = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.comment = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.delayDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.delayDays = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.department2 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.designDepartment = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.enterDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.exitDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flags = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inUseDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.isNext = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.moveCyclePosX = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nbOfDonesToExit = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.onEnter = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.onExit = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.posX = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.posY = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tag = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeLimit = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeLimitIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userTerminate = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.yesNoCondition = bbuf.getString();
			if (version >= 600000098000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.overTimeLimit = bbuf.getBoolean();
				if (version >= 700000000000000L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.userDelayDateIso = bbuf.getString();
					if (version >= 700000000000015L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.processOnServerId = bbuf.getString();
						if (version >= 700000040000012L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.formSpec = bbuf.getString();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.iconId = bbuf.getString();
							if (version >= 900000018000005L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.commentTranslationKey = bbuf.getString();
								// checkpoint byps.gen.cs.PrintContext:449
								obj.nameTranslationKey = bbuf.getString();
								if (version >= 900000022000018L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.properties = bbuf.getString();
									if (version >= 900000022000019L) {
										// checkpoint byps.gen.cs.PrintContext:449
										obj.label = bbuf.getString();
										if (version >= 900000030000006L) {
											// checkpoint byps.gen.cs.PrintContext:449
											obj.departmentGroup = bbuf.getInt();
											if (version >= 900000030000021L) {
												// checkpoint byps.gen.cs.PrintContext:449
												obj.labelTranslationKey = bbuf.getString();
												if (version >= 900000030000022L) {
													// checkpoint byps.gen.cs.PrintContext:449
													obj.retVal = bbuf.getInt();
													// checkpoint byps.gen.cs.PrintContext:449
													obj.subFlowId = bbuf.getInt();
													if (version >= 900990009000003L) {
														// checkpoint byps.gen.cs.PrintContext:449
														obj.returnValue = bbuf.getString();
														if (version >= 900990009000004L) {
															// checkpoint byps.gen.cs.PrintContext:449
															obj.subTemplateId = bbuf.getInt();
															if (version >= 900990009000005L) {
																// checkpoint byps.gen.cs.PrintContext:449
																obj.prio = bbuf.getInt();
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
			if (version >= 700000000000016L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.timeLimitEscalations = (EloixClient.IndexServer.WFTimeLimit[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1495941578.instance);
				if (version >= 700000000000021L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.objKeyNames = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
					// checkpoint byps.gen.cs.PrintContext:449
					obj.scriptNames = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
				}
			}
			
			return obj;
		}
		
	}
} // namespace

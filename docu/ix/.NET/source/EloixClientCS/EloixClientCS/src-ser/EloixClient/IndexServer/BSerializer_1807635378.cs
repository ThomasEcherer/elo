//
// Serializer for de.elo.ix.client.WorkFlowActiveDoc
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1807635378 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1807635378();
		
		public BSerializer_1807635378()
			: base(1807635378) {}
		
		public BSerializer_1807635378(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			WorkFlowActiveDoc obj = (WorkFlowActiveDoc)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.activate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.alertFromBegin);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.alertTo);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.alertWait);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.comment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.completionDate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.condition);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.delayDate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.delayDays);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.deleted);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.department);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.department2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.designDepartment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.eloObjId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flowId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.flowName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.inUseDate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.isNext);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.labelTranslationKey);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lockId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.locked);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.moveCyclePosX);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nodeFlags);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nodeId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nodeType);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.onActivate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.onTerminate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.posX);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.posY);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.prio);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succType);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_0);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_1);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_10);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_11);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_12);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_13);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_14);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_15);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_16);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_17);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_18);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_19);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_3);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_4);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_5);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_6);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_7);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_8);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_9);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.tag);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.templateId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.terminate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userTerminate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.yNCondition);
			if (version >= 700000000000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.userDelayDate);
				if (version >= 700000000000008L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.versionId);
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.versionName);
					if (version >= 700000000000014L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.alertTo2);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.alertTo3);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.alertWait2);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.alertWait3);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.nextServerId);
						if (version >= 700000000000018L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.versionCreateDate);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.versionTag);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.versionUserId);
							if (version >= 700000040000012L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putString(obj.formSpec);
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putString(obj.iconId);
								if (version >= 900000018000005L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.commentTranslationKey);
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.flowNameTranslationKey);
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.nameTranslationKey);
									if (version >= 900000022000019L) {
										// checkpoint byps.gen.cs.PrintContext:494
										bbuf.putString(obj.label);
										// checkpoint byps.gen.cs.PrintContext:494
										bbuf.putString(obj.properties);
										if (version >= 900000030000006L) {
											// checkpoint byps.gen.cs.PrintContext:494
											bbuf.putInt(obj.departmentGroup);
											if (version >= 900000030000022L) {
												// checkpoint byps.gen.cs.PrintContext:494
												bbuf.putInt(obj.retVal);
												// checkpoint byps.gen.cs.PrintContext:494
												bbuf.putInt(obj.subWorkflow);
												if (version >= 900990009000003L) {
													// checkpoint byps.gen.cs.PrintContext:494
													bbuf.putString(obj.returnValue);
													if (version >= 900990009000004L) {
														// checkpoint byps.gen.cs.PrintContext:494
														bbuf.putInt(obj.subWorkflowTemplate);
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
			WorkFlowActiveDoc obj = (WorkFlowActiveDoc)(obj1 != null ? obj1 : bin.onObjectCreated(new WorkFlowActiveDoc()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.activate = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.alertFromBegin = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.alertTo = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.alertWait = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.comment = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.completionDate = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.condition = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.delayDate = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.delayDays = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.deleted = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.department = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.department2 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.designDepartment = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.eloObjId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inUseDate = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.isNext = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.labelTranslationKey = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.locked = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.moveCyclePosX = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeFlags = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeType = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.onActivate = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.onTerminate = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.posX = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.posY = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.prio = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succType = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_0 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_1 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_10 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_11 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_12 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_13 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_14 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_15 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_16 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_17 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_18 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_19 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_2 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_3 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_4 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_5 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_6 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_7 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_8 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_9 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tag = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.templateId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.terminate = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userTerminate = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.yNCondition = bbuf.getString();
			if (version >= 700000000000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.userDelayDate = bbuf.getInt();
				if (version >= 700000000000008L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.versionId = bbuf.getInt();
					// checkpoint byps.gen.cs.PrintContext:449
					obj.versionName = bbuf.getString();
					if (version >= 700000000000014L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.alertTo2 = bbuf.getInt();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.alertTo3 = bbuf.getInt();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.alertWait2 = bbuf.getInt();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.alertWait3 = bbuf.getInt();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.nextServerId = bbuf.getString();
						if (version >= 700000000000018L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.versionCreateDate = bbuf.getInt();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.versionTag = bbuf.getString();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.versionUserId = bbuf.getInt();
							if (version >= 700000040000012L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.formSpec = bbuf.getString();
								// checkpoint byps.gen.cs.PrintContext:449
								obj.iconId = bbuf.getString();
								if (version >= 900000018000005L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.commentTranslationKey = bbuf.getString();
									// checkpoint byps.gen.cs.PrintContext:449
									obj.flowNameTranslationKey = bbuf.getString();
									// checkpoint byps.gen.cs.PrintContext:449
									obj.nameTranslationKey = bbuf.getString();
									if (version >= 900000022000019L) {
										// checkpoint byps.gen.cs.PrintContext:449
										obj.label = bbuf.getString();
										// checkpoint byps.gen.cs.PrintContext:449
										obj.properties = bbuf.getString();
										if (version >= 900000030000006L) {
											// checkpoint byps.gen.cs.PrintContext:449
											obj.departmentGroup = bbuf.getInt();
											if (version >= 900000030000022L) {
												// checkpoint byps.gen.cs.PrintContext:449
												obj.retVal = bbuf.getInt();
												// checkpoint byps.gen.cs.PrintContext:449
												obj.subWorkflow = bbuf.getInt();
												if (version >= 900990009000003L) {
													// checkpoint byps.gen.cs.PrintContext:449
													obj.returnValue = bbuf.getString();
													if (version >= 900990009000004L) {
														// checkpoint byps.gen.cs.PrintContext:449
														obj.subWorkflowTemplate = bbuf.getInt();
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

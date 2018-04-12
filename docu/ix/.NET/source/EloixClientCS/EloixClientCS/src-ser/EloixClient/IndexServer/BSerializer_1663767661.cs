//
// Serializer for de.elo.ix.client.WFDiagram
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1663767661 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1663767661();
		
		public BSerializer_1663767661()
			: base(1663767661) {}
		
		public BSerializer_1663767661(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			WFDiagram obj = (WFDiagram)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.acl);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.completionDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.deleted);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lockId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lockName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objType);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.ownerId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ownerName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.prio);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.startDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.templateId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.templateName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.timeLimit);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.timeLimitIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.timeLimitUserId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.timeLimitUserName);
			if (version >= 600000096000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.overTimeLimit);
				if (version >= 600000098000000L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.flags);
					if (version >= 700000000000007L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.access);
						if (version >= 700000000000010L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.guid);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.tStamp);
							if (version >= 700000000000015L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putString(obj.processOnServerId);
								if (version >= 700000026000003L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.objName);
									if (version >= 900000018000005L) {
										// checkpoint byps.gen.cs.PrintContext:494
										bbuf.putString(obj.nameTranslationKey);
										if (version >= 900000018000006L) {
											// checkpoint byps.gen.cs.PrintContext:494
											bbuf.putBoolean(obj.hidden);
											if (version >= 900000030000022L) {
												// checkpoint byps.gen.cs.PrintContext:494
												bbuf.putInt(obj.parentFlowId);
												if (version >= 900990009000001L) {
													// checkpoint byps.gen.cs.PrintContext:494
													bbuf.putString(obj.TStampSync);
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
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.aclItems, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.matrix, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.nodes, false, EloixClient.IndexServer.BSerializer_1457843286.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.type, false, null);
			if (version >= 700000000000008L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.version, false, null);
				if (version >= 700000000000016L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.timeLimitEscalations, false, EloixClient.IndexServer.BSerializer_1495941578.instance);
					if (version >= 900000030000022L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bout.writeObj(obj.subWorkflows, false, EloixClient.IndexServer.BSerializer_1085717935.instance);
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFDiagram obj = (WFDiagram)(obj1 != null ? obj1 : bin.onObjectCreated(new WFDiagram()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.acl = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.completionDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.deleted = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objType = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ownerId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ownerName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.prio = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.startDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.templateId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.templateName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeLimit = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeLimitIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeLimitUserId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeLimitUserName = bbuf.getString();
			if (version >= 600000096000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.overTimeLimit = bbuf.getBoolean();
				if (version >= 600000098000000L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.flags = bbuf.getInt();
					if (version >= 700000000000007L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.access = bbuf.getInt();
						if (version >= 700000000000010L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.guid = bbuf.getString();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.tStamp = bbuf.getString();
							if (version >= 700000000000015L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.processOnServerId = bbuf.getString();
								if (version >= 700000026000003L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.objName = bbuf.getString();
									if (version >= 900000018000005L) {
										// checkpoint byps.gen.cs.PrintContext:449
										obj.nameTranslationKey = bbuf.getString();
										if (version >= 900000018000006L) {
											// checkpoint byps.gen.cs.PrintContext:449
											obj.hidden = bbuf.getBoolean();
											if (version >= 900000030000022L) {
												// checkpoint byps.gen.cs.PrintContext:449
												obj.parentFlowId = bbuf.getInt();
												if (version >= 900990009000001L) {
													// checkpoint byps.gen.cs.PrintContext:449
													obj.TStampSync = bbuf.getString();
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
			// checkpoint byps.gen.cs.PrintContext:449
			obj.aclItems = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.matrix = (EloixClient.IndexServer.WFNodeMatrix)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodes = (EloixClient.IndexServer.WFNode[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1457843286.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = (EloixClient.IndexServer.WFTypeZ)bin.readObj(false, null);
			if (version >= 700000000000008L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.version = (EloixClient.IndexServer.WFVersion)bin.readObj(false, null);
				if (version >= 700000000000016L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.timeLimitEscalations = (EloixClient.IndexServer.WFTimeLimit[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1495941578.instance);
					if (version >= 900000030000022L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.subWorkflows = (IDictionary<int,EloixClient.IndexServer.WFDiagram>)bin.readObj(false, null);
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace

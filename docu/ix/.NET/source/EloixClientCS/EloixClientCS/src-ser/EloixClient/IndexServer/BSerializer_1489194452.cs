//
// Serializer for de.elo.ix.client.FindTasksInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1489194452 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1489194452();
		
		public BSerializer_1489194452()
			: base(1489194452) {}
		
		public BSerializer_1489194452(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindTasksInfo obj = (FindTasksInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.endDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.highestPriority);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclActivities);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclDeputy);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclGroup);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclReminders);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclWorkflows);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lowestPriority);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.startDateIso);
			if (version >= 600000098000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.overTimeLimit);
				if (version >= 800000010000006L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.inclOverTimeForSuperior);
					if (version >= 800000012000005L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.inclDeleted);
						if (version >= 800000020000003L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putBoolean(obj.allUsers);
							if (version >= 800000028000002L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putString(obj.taskName);
								if (version >= 900000000000025L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putBoolean(obj.updateInUseDate);
									if (version >= 900000018000006L) {
										// checkpoint byps.gen.cs.PrintContext:494
										bbuf.putBoolean(obj.inclHidden);
										if (version >= 900990009000009L) {
											// checkpoint byps.gen.cs.PrintContext:494
											bbuf.putInt(obj.timeLimitBias);
										}
									}
								}
							}
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sortOrder, false, null);
			if (version >= 800000012000003L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.userIds, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
				if (version >= 800000020000004L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.sordZ, false, null);
					if (version >= 900000000000003L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bout.writeObj(obj.inclActivityTypes, false, EloixClient.IndexServer.BSerializer_2123584667.instance);
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindTasksInfo obj = (FindTasksInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FindTasksInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.endDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.highestPriority = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclActivities = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclDeputy = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclGroup = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclReminders = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclWorkflows = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lowestPriority = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.startDateIso = bbuf.getString();
			if (version >= 600000098000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.overTimeLimit = bbuf.getBoolean();
				if (version >= 800000010000006L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.inclOverTimeForSuperior = bbuf.getBoolean();
					if (version >= 800000012000005L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.inclDeleted = bbuf.getBoolean();
						if (version >= 800000020000003L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.allUsers = bbuf.getBoolean();
							if (version >= 800000028000002L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.taskName = bbuf.getString();
								if (version >= 900000000000025L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.updateInUseDate = bbuf.getBoolean();
									if (version >= 900000018000006L) {
										// checkpoint byps.gen.cs.PrintContext:449
										obj.inclHidden = bbuf.getBoolean();
										if (version >= 900990009000009L) {
											// checkpoint byps.gen.cs.PrintContext:449
											obj.timeLimitBias = bbuf.getInt();
										}
									}
								}
							}
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sortOrder = (EloixClient.IndexServer.UserTaskSortOrderZ)bin.readObj(false, null);
			if (version >= 800000012000003L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.userIds = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
				if (version >= 800000020000004L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.sordZ = (EloixClient.IndexServer.SordZ)bin.readObj(false, null);
					if (version >= 900000000000003L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.inclActivityTypes = (IList<String>)bin.readObj(false, null);
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace

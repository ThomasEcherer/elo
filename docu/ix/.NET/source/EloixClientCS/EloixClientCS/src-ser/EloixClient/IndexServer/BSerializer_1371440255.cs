//
// Serializer for de.elo.ix.client.FindOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1371440255 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1371440255();
		
		public BSerializer_1371440255()
			: base(1371440255) {}
		
		public BSerializer_1371440255(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindOptions obj = (FindOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.escapeChar);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.evalCount);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclDeleted);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.orderBy);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.rangeDelimiter);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.reserved);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.searchId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.sortOrder);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.timeoutSeconds);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.totalCount);
			if (version >= 700000000000022L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.onlyDeleted);
				if (version >= 700000006000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.TStamp);
					if (version >= 700000022000002L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.wildcards);
						if (version >= 800000026000000L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putBoolean(obj.excludeSummary);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.searchLifetimeSeconds);
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.objIds, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.replSet, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.searchMode, false, null);
			if (version >= 700000022000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.lockZ, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindOptions obj = (FindOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new FindOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.escapeChar = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.evalCount = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclDeleted = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.orderBy = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.rangeDelimiter = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.reserved = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.searchId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sortOrder = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeoutSeconds = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.totalCount = bbuf.getInt();
			if (version >= 700000000000022L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.onlyDeleted = bbuf.getBoolean();
				if (version >= 700000006000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.TStamp = bbuf.getString();
					if (version >= 700000022000002L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.wildcards = bbuf.getString();
						if (version >= 800000026000000L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.excludeSummary = bbuf.getBoolean();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.searchLifetimeSeconds = bbuf.getInt();
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objIds = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.replSet = (EloixClient.IndexServer.ReplSet)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.searchMode = (EloixClient.IndexServer.SearchModeZ)bin.readObj(false, null);
			if (version >= 700000022000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lockZ = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace

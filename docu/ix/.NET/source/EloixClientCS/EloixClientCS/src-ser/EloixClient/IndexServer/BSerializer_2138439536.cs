//
// Serializer for de.elo.ix.client.CopyInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2138439536 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2138439536();
		
		public BSerializer_2138439536()
			: base(2138439536) {}
		
		public BSerializer_2138439536(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			CopyInfo obj = (CopyInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.depth);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.manSortIdx);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			if (version >= 700000020000010L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.adjustAclDifference);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.adjustAclIgnoreDocuments);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.adjustAclIgnoreFolders);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.adjustAclInBackground);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.adjustAclOverwrite);
				if (version >= 800000020000005L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.checkRecursion);
					if (version >= 800000030000001L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.oldParentId);
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CopyInfo obj = (CopyInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new CopyInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.depth = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.manSortIdx = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			if (version >= 700000020000010L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.adjustAclDifference = bbuf.getBoolean();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.adjustAclIgnoreDocuments = bbuf.getBoolean();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.adjustAclIgnoreFolders = bbuf.getBoolean();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.adjustAclInBackground = bbuf.getBoolean();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.adjustAclOverwrite = bbuf.getBoolean();
				if (version >= 800000020000005L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.checkRecursion = bbuf.getBoolean();
					if (version >= 800000030000001L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.oldParentId = bbuf.getString();
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace

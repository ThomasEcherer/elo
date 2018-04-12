//
// Serializer for de.elo.ix.client.ObjDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1521332903 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1521332903();
		
		public BSerializer_1521332903()
			: base(1521332903) {}
		
		public BSerializer_1521332903(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ObjDataC obj = (ObjDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnAcl);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnInternalDesc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnSDesc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnSName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnSReg);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTStamp);
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnTStampAcl);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnTStampAclSync);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnTStampSync);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ObjDataC obj = (ObjDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new ObjDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnAcl = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnInternalDesc = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnSDesc = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnSName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnSReg = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTStamp = bbuf.getInt();
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnTStampAcl = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnTStampAclSync = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnTStampSync = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace

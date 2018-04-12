//
// Serializer for de.elo.ix.client.CombineAclResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1034263904 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1034263904();
		
		public BSerializer_1034263904()
			: base(1034263904) {}
		
		public BSerializer_1034263904(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			CombineAclResult obj = (CombineAclResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.compareCode);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.compareIgnoreAccessCode);
			if (version >= 700000020000005L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.differenceAclStr);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.intersectionAclStr);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.inverseDifferenceAclStr);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.sumAclStr);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.difference, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.intersection, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.inverseDifference, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sum, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CombineAclResult obj = (CombineAclResult)(obj1 != null ? obj1 : bin.onObjectCreated(new CombineAclResult()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.compareCode = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.compareIgnoreAccessCode = bbuf.getInt();
			if (version >= 700000020000005L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.differenceAclStr = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.intersectionAclStr = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.inverseDifferenceAclStr = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.sumAclStr = bbuf.getString();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.difference = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.intersection = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inverseDifference = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sum = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			
			return obj;
		}
		
	}
} // namespace

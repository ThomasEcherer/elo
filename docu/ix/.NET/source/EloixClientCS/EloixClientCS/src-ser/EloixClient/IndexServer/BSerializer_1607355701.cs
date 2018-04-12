//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_refSord
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1607355701 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1607355701();
		
		public BSerializer_1607355701()
			: base(1607355701) {}
		
		public BSerializer_1607355701(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_refSord obj = (BRequest_IXServicePortIF_refSord)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.manSortIdxValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.newParentIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.oldParentIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_refSord obj = (BRequest_IXServicePortIF_refSord)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_refSord()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.manSortIdxValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.newParentIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.oldParentIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

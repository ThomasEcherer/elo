//
// Serializer for de.elo.ix.client.VtDoc
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1935852595 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1935852595();
		
		public BSerializer_1935852595()
			: base(1935852595) {}
		
		public BSerializer_1935852595(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			VtDoc obj = (VtDoc)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.code);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.docId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objId);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			VtDoc obj = (VtDoc)(obj1 != null ? obj1 : bin.onObjectCreated(new VtDoc()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.code = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace

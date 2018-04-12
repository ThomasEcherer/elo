//
// Serializer for de.elo.ix.client.DeleteActivityOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_78913228 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_78913228();
		
		public BSerializer_78913228()
			: base(78913228) {}
		
		public BSerializer_78913228(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			DeleteActivityOptions obj = (DeleteActivityOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.deleteFinally);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			DeleteActivityOptions obj = (DeleteActivityOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new DeleteActivityOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.deleteFinally = bbuf.getBoolean();
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.CheckinDocOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1433031299 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1433031299();
		
		public BSerializer_1433031299()
			: base(1433031299) {}
		
		public BSerializer_1433031299(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			CheckinDocOptions obj = (CheckinDocOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.keepIds);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CheckinDocOptions obj = (CheckinDocOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new CheckinDocOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.keepIds = bbuf.getBoolean();
			
			return obj;
		}
		
	}
} // namespace

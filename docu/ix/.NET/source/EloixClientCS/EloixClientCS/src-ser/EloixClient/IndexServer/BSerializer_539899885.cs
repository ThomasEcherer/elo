//
// Serializer for de.elo.ix.client.NotifyServerInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_539899885 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_539899885();
		
		public BSerializer_539899885()
			: base(539899885) {}
		
		public BSerializer_539899885(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			NotifyServerInfo obj = (NotifyServerInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.ocrCount);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.scanCount);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			NotifyServerInfo obj = (NotifyServerInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new NotifyServerInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ocrCount = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.scanCount = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace

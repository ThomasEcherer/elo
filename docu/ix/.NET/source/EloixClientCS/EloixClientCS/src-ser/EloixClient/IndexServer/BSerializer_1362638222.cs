//
// Serializer for de.elo.ix.client.QueryJobProtocolInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1362638222 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1362638222();
		
		public BSerializer_1362638222()
			: base(1362638222) {}
		
		public BSerializer_1362638222(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			QueryJobProtocolInfo obj = (QueryJobProtocolInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.jobGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.level);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.startDateISO);
			if (version >= 900000000000030L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.startEventId);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			QueryJobProtocolInfo obj = (QueryJobProtocolInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new QueryJobProtocolInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.jobGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.level = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.startDateISO = bbuf.getString();
			if (version >= 900000000000030L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.startEventId = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace

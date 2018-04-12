//
// Serializer for de.elo.ix.client.ClientInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1258190913 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1258190913();
		
		public BSerializer_1258190913()
			: base(1258190913) {}
		
		public BSerializer_1258190913(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ClientInfo obj = (ClientInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.callId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.country);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.language);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ticket);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.timeZone);
			if (version >= 800000010000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.options);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ClientInfo obj = (ClientInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new ClientInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.callId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.country = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.language = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ticket = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeZone = bbuf.getString();
			if (version >= 800000010000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.options = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace

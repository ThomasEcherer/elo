//
// Serializer for de.elo.ix.client.QueryJobProtocolResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_222450704 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_222450704();
		
		public BSerializer_222450704()
			: base(222450704) {}
		
		public BSerializer_222450704(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			QueryJobProtocolResult obj = (QueryJobProtocolResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.downloadUrl);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.events, false, EloixClient.IndexServer.BSerializer_1465721064.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			QueryJobProtocolResult obj = (QueryJobProtocolResult)(obj1 != null ? obj1 : bin.onObjectCreated(new QueryJobProtocolResult()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.downloadUrl = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.events = (EloixClient.IndexServer.QueryJobProtocolEvent[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1465721064.instance);
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.Subscription
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_323351719 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_323351719();
		
		public BSerializer_323351719()
			: base(323351719) {}
		
		public BSerializer_323351719(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			Subscription obj = (Subscription)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.createDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.watchGuid);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Subscription obj = (Subscription)(obj1 != null ? obj1 : bin.onObjectCreated(new Subscription()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.createDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.watchGuid = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

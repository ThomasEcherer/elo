//
// Serializer for de.elo.ix.client.feed.ActionHistory
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_598833764 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_598833764();
		
		public BSerializer_598833764()
			: base(598833764) {}
		
		public BSerializer_598833764(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ActionHistory obj = (ActionHistory)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.actionGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.createDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.text);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ActionHistory obj = (ActionHistory)(obj1 != null ? obj1 : bin.onObjectCreated(new ActionHistory()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.actionGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.createDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.text = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.feed.HashTag
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_1143177929 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1143177929();
		
		public BSerializer_1143177929()
			: base(1143177929) {}
		
		public BSerializer_1143177929(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			HashTag obj = (HashTag)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.counter);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.createDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.hstgGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.hstgName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lastUsedIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.status);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.tStamp);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			HashTag obj = (HashTag)(obj1 != null ? obj1 : bin.onObjectCreated(new HashTag()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.counter = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.createDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hstgGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hstgName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lastUsedIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.status = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tStamp = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

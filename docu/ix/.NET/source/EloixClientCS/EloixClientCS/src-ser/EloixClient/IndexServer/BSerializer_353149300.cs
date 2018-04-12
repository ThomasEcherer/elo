//
// Serializer for de.elo.ix.client.EloDmOpt
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_353149300 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_353149300();
		
		public BSerializer_353149300()
			: base(353149300) {}
		
		public BSerializer_353149300(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			EloDmOpt obj = (EloDmOpt)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.remark);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.value);
			if (version >= 1000000000000008L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.instanceName);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EloDmOpt obj = (EloDmOpt)(obj1 != null ? obj1 : bin.onObjectCreated(new EloDmOpt()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.remark = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.value = bbuf.getString();
			if (version >= 1000000000000008L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.instanceName = bbuf.getString();
			}
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.ProcessFulltext
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1125907212 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1125907212();
		
		public BSerializer_1125907212()
			: base(1125907212) {}
		
		public BSerializer_1125907212(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ProcessFulltext obj = (ProcessFulltext)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.addToFulltext);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ProcessFulltext obj = (ProcessFulltext)(obj1 != null ? obj1 : bin.onObjectCreated(new ProcessFulltext()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.addToFulltext = bbuf.getBoolean();
			
			return obj;
		}
		
	}
} // namespace

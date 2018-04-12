//
// Serializer for de.elo.ix.client.SessionOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1197100286 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1197100286();
		
		public BSerializer_1197100286()
			: base(1197100286) {}
		
		public BSerializer_1197100286(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			SessionOptions obj = (SessionOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.options, false, EloixClient.IndexServer.BSerializer_1826370901.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SessionOptions obj = (SessionOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new SessionOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.options = (EloixClient.IndexServer.KeyValue[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.MapValue
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_408347242 : EloixClient.IndexServer.BSerializer_516301248 {
		
		public readonly static new BSerializer instance = new BSerializer_408347242();
		
		public BSerializer_408347242()
			: base(408347242) {}
		
		public BSerializer_408347242(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			MapValue obj = (MapValue)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.blobValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MapValue obj = (MapValue)(obj1 != null ? obj1 : bin.onObjectCreated(new MapValue()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.blobValue = (EloixClient.IndexServer.FileData)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

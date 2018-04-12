//
// Serializer for de.elo.ix.client.MapHistItem
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_342049067 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_342049067();
		
		public BSerializer_342049067()
			: base(342049067) {}
		
		public BSerializer_342049067(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			MapHistItem obj = (MapHistItem)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.histGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.key);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.value);
			if (version >= 1000000020000011L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.blobValue, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MapHistItem obj = (MapHistItem)(obj1 != null ? obj1 : bin.onObjectCreated(new MapHistItem()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.histGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.key = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.value = bbuf.getString();
			if (version >= 1000000020000011L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.blobValue = (EloixClient.IndexServer.FileData)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace

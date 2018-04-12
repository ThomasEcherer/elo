//
// Serializer for de.elo.ix.client.FileData
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_888671717 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_888671717();
		
		public BSerializer_888671717()
			: base(888671717) {}
		
		public BSerializer_888671717(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FileData obj = (FileData)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.contentType);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.data, false, EloixClient.IndexServer.BSerializer_1374008726.instance);
			if (version >= 1000000020000005L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.stream, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FileData obj = (FileData)(obj1 != null ? obj1 : bin.onObjectCreated(new FileData()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.contentType = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.data = (byte[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1374008726.instance);
			if (version >= 1000000020000005L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.stream = (System.IO.Stream)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace

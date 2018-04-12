//
// Serializer for de.elo.ix.client.system.ArchivValue
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class BSerializer_1695870218 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1695870218();
		
		public BSerializer_1695870218()
			: base(1695870218) {}
		
		public BSerializer_1695870218(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ArchivValue obj = (ArchivValue)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.count);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.year);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ArchivValue obj = (ArchivValue)(obj1 != null ? obj1 : bin.onObjectCreated(new ArchivValue()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.count = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.year = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace

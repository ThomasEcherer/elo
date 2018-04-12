//
// Serializer for de.elo.ix.client.ArchiveStatistics
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2056457945 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2056457945();
		
		public BSerializer_2056457945()
			: base(2056457945) {}
		
		public BSerializer_2056457945(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ArchiveStatistics obj = (ArchiveStatistics)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.maxDocId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.maxObjId);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ArchiveStatistics obj = (ArchiveStatistics)(obj1 != null ? obj1 : bin.onObjectCreated(new ArchiveStatistics()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maxDocId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maxObjId = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace

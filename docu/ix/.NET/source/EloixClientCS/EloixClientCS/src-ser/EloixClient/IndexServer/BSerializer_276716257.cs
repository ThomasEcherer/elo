//
// Serializer for de.elo.ix.client.ArchiveStatisticsOptionsC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_276716257 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_276716257();
		
		public BSerializer_276716257()
			: base(276716257) {}
		
		public BSerializer_276716257(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ArchiveStatisticsOptionsC obj = (ArchiveStatisticsOptionsC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ArchiveStatisticsOptionsC obj = (ArchiveStatisticsOptionsC)(obj1 != null ? obj1 : bin.onObjectCreated(new ArchiveStatisticsOptionsC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.ArchivingModeC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1464718703 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1464718703();
		
		public BSerializer_1464718703()
			: base(1464718703) {}
		
		public BSerializer_1464718703(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ArchivingModeC obj = (ArchivingModeC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.dummy);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ArchivingModeC obj = (ArchivingModeC)(obj1 != null ? obj1 : bin.onObjectCreated(new ArchivingModeC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dummy = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace

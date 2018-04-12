//
// Serializer for de.elo.ix.client.EditInfoEswOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_522299581 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_522299581();
		
		public BSerializer_522299581()
			: base(522299581) {}
		
		public BSerializer_522299581(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			EditInfoEswOptions obj = (EditInfoEswOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 700000040000024L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.reserved);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EditInfoEswOptions obj = (EditInfoEswOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new EditInfoEswOptions()));
			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 700000040000024L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.reserved = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace

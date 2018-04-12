//
// Serializer for de.elo.ix.client.ImportOptionsC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1908370444 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1908370444();
		
		public BSerializer_1908370444()
			: base(1908370444) {}
		
		public BSerializer_1908370444(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ImportOptionsC obj = (ImportOptionsC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ImportOptionsC obj = (ImportOptionsC)(obj1 != null ? obj1 : bin.onObjectCreated(new ImportOptionsC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

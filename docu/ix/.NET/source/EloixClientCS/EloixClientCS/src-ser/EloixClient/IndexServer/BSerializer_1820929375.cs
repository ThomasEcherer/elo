//
// Serializer for de.elo.ix.client.AdminModeC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1820929375 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1820929375();
		
		public BSerializer_1820929375()
			: base(1820929375) {}
		
		public BSerializer_1820929375(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			AdminModeC obj = (AdminModeC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			AdminModeC obj = (AdminModeC)(obj1 != null ? obj1 : bin.onObjectCreated(new AdminModeC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

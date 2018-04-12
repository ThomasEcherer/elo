//
// Serializer for de.elo.ix.client.NavigationInfoC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1520348158 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1520348158();
		
		public BSerializer_1520348158()
			: base(1520348158) {}
		
		public BSerializer_1520348158(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			NavigationInfoC obj = (NavigationInfoC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			NavigationInfoC obj = (NavigationInfoC)(obj1 != null ? obj1 : bin.onObjectCreated(new NavigationInfoC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

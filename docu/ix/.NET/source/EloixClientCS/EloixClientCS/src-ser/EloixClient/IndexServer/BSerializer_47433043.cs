//
// Serializer for de.elo.ix.client.MapDomainC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_47433043 : EloixClient.IndexServer.BSerializer_915355095 {
		
		public readonly static new BSerializer instance = new BSerializer_47433043();
		
		public BSerializer_47433043()
			: base(47433043) {}
		
		public BSerializer_47433043(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			MapDomainC obj = (MapDomainC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MapDomainC obj = (MapDomainC)(obj1 != null ? obj1 : bin.onObjectCreated(new MapDomainC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

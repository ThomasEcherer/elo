//
// Serializer for de.elo.ix.client.EditInfoC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2100880359 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2100880359();
		
		public BSerializer_2100880359()
			: base(2100880359) {}
		
		public BSerializer_2100880359(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			EditInfoC obj = (EditInfoC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EditInfoC obj = (EditInfoC)(obj1 != null ? obj1 : bin.onObjectCreated(new EditInfoC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

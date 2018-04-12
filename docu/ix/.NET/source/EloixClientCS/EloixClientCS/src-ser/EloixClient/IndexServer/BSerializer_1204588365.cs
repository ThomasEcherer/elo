//
// Serializer for de.elo.ix.client.IXExceptionC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1204588365 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1204588365();
		
		public BSerializer_1204588365()
			: base(1204588365) {}
		
		public BSerializer_1204588365(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			IXExceptionC obj = (IXExceptionC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			IXExceptionC obj = (IXExceptionC)(obj1 != null ? obj1 : bin.onObjectCreated(new IXExceptionC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

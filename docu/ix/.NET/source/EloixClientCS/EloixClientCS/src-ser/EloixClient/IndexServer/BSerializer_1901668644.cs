//
// Serializer for de.elo.ix.client.BResult_893011331
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1901668644 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1901668644();
		
		public BSerializer_1901668644()
			: base(1901668644) {}
		
		public BSerializer_1901668644(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_893011331 obj = (BResult_893011331)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_893011331.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_893011331 obj = (BResult_893011331)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_893011331()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (IDictionary<int,EloixClient.IndexServer.OrgUnitInfo>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

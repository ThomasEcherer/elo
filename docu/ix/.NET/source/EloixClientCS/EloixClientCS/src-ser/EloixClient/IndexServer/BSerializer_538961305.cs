//
// Serializer for de.elo.ix.client.BResult_1788243283
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_538961305 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_538961305();
		
		public BSerializer_538961305()
			: base(538961305) {}
		
		public BSerializer_538961305(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1788243283 obj = (BResult_1788243283)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_1788243283.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1788243283 obj = (BResult_1788243283)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1788243283()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.JobState[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1788243283.instance);
			
			return obj;
		}
		
	}
} // namespace

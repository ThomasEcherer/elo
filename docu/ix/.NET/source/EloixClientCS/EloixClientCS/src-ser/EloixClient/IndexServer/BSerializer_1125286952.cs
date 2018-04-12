//
// Serializer for de.elo.ix.client.BResult_810727301
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1125286952 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1125286952();
		
		public BSerializer_1125286952()
			: base(1125286952) {}
		
		public BSerializer_1125286952(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_810727301 obj = (BResult_810727301)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_810727301 obj = (BResult_810727301)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_810727301()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.NotifyServerResult)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.BResult_231031238
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1008002146 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1008002146();
		
		public BSerializer_1008002146()
			: base(1008002146) {}
		
		public BSerializer_1008002146(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_231031238 obj = (BResult_231031238)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_231031238.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_231031238 obj = (BResult_231031238)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_231031238()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.StoreInfo[])bin.readObj(false, EloixClient.IndexServer.BSerializer_231031238.instance);
			
			return obj;
		}
		
	}
} // namespace

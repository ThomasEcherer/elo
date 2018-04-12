//
// Serializer for de.elo.ix.client.BResult_1768472140
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1408305917 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1408305917();
		
		public BSerializer_1408305917()
			: base(1408305917) {}
		
		public BSerializer_1408305917(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1768472140 obj = (BResult_1768472140)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_1768472140.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1768472140 obj = (BResult_1768472140)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1768472140()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.WFVersion[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1768472140.instance);
			
			return obj;
		}
		
	}
} // namespace

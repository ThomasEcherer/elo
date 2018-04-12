//
// Serializer for de.elo.ix.client.BResult_105830886
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1366049664 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1366049664();
		
		public BSerializer_1366049664()
			: base(1366049664) {}
		
		public BSerializer_1366049664(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_105830886 obj = (BResult_105830886)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_105830886.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_105830886 obj = (BResult_105830886)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_105830886()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.SubsInfo[])bin.readObj(false, EloixClient.IndexServer.BSerializer_105830886.instance);
			
			return obj;
		}
		
	}
} // namespace

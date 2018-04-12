//
// Serializer for de.elo.ix.client.BResult_776454091
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_799026444 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_799026444();
		
		public BSerializer_799026444()
			: base(799026444) {}
		
		public BSerializer_799026444(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_776454091 obj = (BResult_776454091)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_776454091.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_776454091 obj = (BResult_776454091)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_776454091()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.Note[])bin.readObj(false, EloixClient.IndexServer.BSerializer_776454091.instance);
			
			return obj;
		}
		
	}
} // namespace

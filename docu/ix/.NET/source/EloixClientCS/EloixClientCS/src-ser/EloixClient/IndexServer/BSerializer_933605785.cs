﻿//
// Serializer for de.elo.ix.client.BResult_755261279
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_933605785 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_933605785();
		
		public BSerializer_933605785()
			: base(933605785) {}
		
		public BSerializer_933605785(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_755261279 obj = (BResult_755261279)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_755261279.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_755261279 obj = (BResult_755261279)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_755261279()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.IdName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_755261279.instance);
			
			return obj;
		}
		
	}
} // namespace

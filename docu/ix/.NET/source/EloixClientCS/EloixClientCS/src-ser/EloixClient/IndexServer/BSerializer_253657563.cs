﻿//
// Serializer for de.elo.ix.client.BResult_1088095067
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_253657563 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_253657563();
		
		public BSerializer_253657563()
			: base(253657563) {}
		
		public BSerializer_253657563(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1088095067 obj = (BResult_1088095067)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_1088095067.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1088095067 obj = (BResult_1088095067)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1088095067()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.TranslateTerm[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1088095067.instance);
			
			return obj;
		}
		
	}
} // namespace

﻿//
// Serializer for de.elo.ix.client.BResult_1107316733
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_874621629 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_874621629();
		
		public BSerializer_874621629()
			: base(874621629) {}
		
		public BSerializer_874621629(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1107316733 obj = (BResult_1107316733)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_1107316733.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1107316733 obj = (BResult_1107316733)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1107316733()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.DocMaskLineTemplate[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1107316733.instance);
			
			return obj;
		}
		
	}
} // namespace

﻿//
// Serializer for de.elo.ix.client.BResult_661820173
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_765305647 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_765305647();
		
		public BSerializer_765305647()
			: base(765305647) {}
		
		public BSerializer_765305647(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_661820173 obj = (BResult_661820173)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_661820173 obj = (BResult_661820173)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_661820173()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.PreviewImageResult)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

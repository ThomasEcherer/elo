﻿//
// Serializer for de.elo.ix.client.BResult_1264954948
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1553005093 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1553005093();
		
		public BSerializer_1553005093()
			: base(1553005093) {}
		
		public BSerializer_1553005093(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1264954948 obj = (BResult_1264954948)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1264954948 obj = (BResult_1264954948)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1264954948()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.IXServicePortC)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

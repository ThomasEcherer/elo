﻿//
// Serializer for de.elo.ix.client.BResult_1
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_139578694 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_139578694();
		
		public BSerializer_139578694()
			: base(139578694) {}
		
		public BSerializer_139578694(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1 obj = (BResult_1)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.resultValue);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1 obj = (BResult_1)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = bbuf.getBoolean();
			
			return obj;
		}
		
	}
} // namespace

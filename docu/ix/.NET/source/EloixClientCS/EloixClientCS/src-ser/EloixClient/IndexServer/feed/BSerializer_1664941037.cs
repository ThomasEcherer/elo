﻿//
// Serializer for de.elo.ix.client.feed.HashTagZ
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_1664941037 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1664941037();
		
		public BSerializer_1664941037()
			: base(1664941037) {}
		
		public BSerializer_1664941037(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			HashTagZ obj = (HashTagZ)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.bset);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			HashTagZ obj = (HashTagZ)(obj1 != null ? obj1 : bin.onObjectCreated(new HashTagZ()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.bset = bbuf.getLong();
			
			return obj;
		}
		
	}
} // namespace
﻿//
// Serializer for de.elo.ix.client.NotificationZ
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1624160439 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1624160439();
		
		public BSerializer_1624160439()
			: base(1624160439) {}
		
		public BSerializer_1624160439(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			NotificationZ obj = (NotificationZ)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.bset);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			NotificationZ obj = (NotificationZ)(obj1 != null ? obj1 : bin.onObjectCreated(new NotificationZ()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.bset = bbuf.getLong();
			
			return obj;
		}
		
	}
} // namespace

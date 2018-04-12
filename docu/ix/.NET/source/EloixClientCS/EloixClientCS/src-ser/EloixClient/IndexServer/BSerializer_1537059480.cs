﻿//
// Serializer for de.elo.ix.client.KeyInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1537059480 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1537059480();
		
		public BSerializer_1537059480()
			: base(1537059480) {}
		
		public BSerializer_1537059480(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			KeyInfo obj = (KeyInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			KeyInfo obj = (KeyInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new KeyInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

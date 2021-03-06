﻿//
// Serializer for de.elo.ix.client.IndexServerForArchive
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_145656220 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_145656220();
		
		public BSerializer_145656220()
			: base(145656220) {}
		
		public BSerializer_145656220(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			IndexServerForArchive obj = (IndexServerForArchive)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.arcName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.url);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			IndexServerForArchive obj = (IndexServerForArchive)(obj1 != null ? obj1 : bin.onObjectCreated(new IndexServerForArchive()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.arcName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.url = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

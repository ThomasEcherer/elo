﻿//
// Serializer for de.elo.ix.client.OcrInfoQueryLanguages
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_648095775 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_648095775();
		
		public BSerializer_648095775()
			: base(648095775) {}
		
		public BSerializer_648095775(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			OcrInfoQueryLanguages obj = (OcrInfoQueryLanguages)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.ctrl);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			OcrInfoQueryLanguages obj = (OcrInfoQueryLanguages)(obj1 != null ? obj1 : bin.onObjectCreated(new OcrInfoQueryLanguages()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ctrl = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace

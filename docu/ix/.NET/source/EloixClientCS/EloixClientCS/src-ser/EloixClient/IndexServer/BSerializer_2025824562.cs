﻿//
// Serializer for de.elo.ix.client.FulltextConfigC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2025824562 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2025824562();
		
		public BSerializer_2025824562()
			: base(2025824562) {}
		
		public BSerializer_2025824562(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FulltextConfigC obj = (FulltextConfigC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FulltextConfigC obj = (FulltextConfigC)(obj1 != null ? obj1 : bin.onObjectCreated(new FulltextConfigC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

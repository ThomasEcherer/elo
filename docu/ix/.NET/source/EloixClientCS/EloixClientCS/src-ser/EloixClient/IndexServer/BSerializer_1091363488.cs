//
// Serializer for de.elo.ix.client.ActivityC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1091363488 : EloixClient.IndexServer.BSerializer_72578008 {
		
		public readonly static new BSerializer instance = new BSerializer_1091363488();
		
		public BSerializer_1091363488()
			: base(1091363488) {}
		
		public BSerializer_1091363488(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ActivityC obj = (ActivityC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ActivityC obj = (ActivityC)(obj1 != null ? obj1 : bin.onObjectCreated(new ActivityC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.LoginScriptOptionsC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1002222217 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1002222217();
		
		public BSerializer_1002222217()
			: base(1002222217) {}
		
		public BSerializer_1002222217(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			LoginScriptOptionsC obj = (LoginScriptOptionsC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			LoginScriptOptionsC obj = (LoginScriptOptionsC)(obj1 != null ? obj1 : bin.onObjectCreated(new LoginScriptOptionsC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

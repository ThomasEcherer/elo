//
// Serializer for de.elo.ix.client.LoginScriptOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1536364115 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1536364115();
		
		public BSerializer_1536364115()
			: base(1536364115) {}
		
		public BSerializer_1536364115(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			LoginScriptOptions obj = (LoginScriptOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.clientName);
			if (version >= 1000170059000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.techUser);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			LoginScriptOptions obj = (LoginScriptOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new LoginScriptOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.clientName = bbuf.getString();
			if (version >= 1000170059000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.techUser = bbuf.getString();
			}
			
			return obj;
		}
		
	}
} // namespace

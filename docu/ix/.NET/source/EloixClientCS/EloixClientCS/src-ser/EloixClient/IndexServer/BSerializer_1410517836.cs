//
// Serializer for de.elo.ix.client.GetWebDAVPathOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1410517836 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1410517836();
		
		public BSerializer_1410517836()
			: base(1410517836) {}
		
		public BSerializer_1410517836(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			GetWebDAVPathOptions obj = (GetWebDAVPathOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.tickketInPath);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			GetWebDAVPathOptions obj = (GetWebDAVPathOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new GetWebDAVPathOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tickketInPath = bbuf.getBoolean();
			
			return obj;
		}
		
	}
} // namespace

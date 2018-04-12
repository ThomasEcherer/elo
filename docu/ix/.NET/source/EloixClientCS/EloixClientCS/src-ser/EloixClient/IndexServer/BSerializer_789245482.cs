//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteSordTypes
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_789245482 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_789245482();
		
		public BSerializer_789245482()
			: base(789245482) {}
		
		public BSerializer_789245482(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_deleteSordTypes obj = (BRequest_IXServicePortIF_deleteSordTypes)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordTypeIdsValue, false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.unlockZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_deleteSordTypes obj = (BRequest_IXServicePortIF_deleteSordTypes)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_deleteSordTypes()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordTypeIdsValue = (int[])bin.readObj(false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.unlockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

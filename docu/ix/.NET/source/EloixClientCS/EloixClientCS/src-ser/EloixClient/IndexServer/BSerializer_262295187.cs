//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_resolveRights
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_262295187 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_262295187();
		
		public BSerializer_262295187()
			: base(262295187) {}
		
		public BSerializer_262295187(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_resolveRights obj = (BRequest_IXServicePortIF_resolveRights)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.infoValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.uiValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_resolveRights obj = (BRequest_IXServicePortIF_resolveRights)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_resolveRights()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.infoValue = (EloixClient.IndexServer.ResolveRightsInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.uiValue = (EloixClient.IndexServer.UserInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

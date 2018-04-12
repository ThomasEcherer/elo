//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinCryptInfos
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1795186254 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1795186254();
		
		public BSerializer_1795186254()
			: base(1795186254) {}
		
		public BSerializer_1795186254(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkinCryptInfos obj = (BRequest_IXServicePortIF_checkinCryptInfos)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.cryptInfosValue, false, EloixClient.IndexServer.BSerializer_809229049.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.unlockZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkinCryptInfos obj = (BRequest_IXServicePortIF_checkinCryptInfos)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkinCryptInfos()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.cryptInfosValue = (EloixClient.IndexServer.CryptInfo[])bin.readObj(false, EloixClient.IndexServer.BSerializer_809229049.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.unlockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

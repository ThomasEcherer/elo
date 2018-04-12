//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinUsers
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_621774353 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_621774353();
		
		public BSerializer_621774353()
			: base(621774353) {}
		
		public BSerializer_621774353(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkinUsers obj = (BRequest_IXServicePortIF_checkinUsers)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.checkinUsersZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.unlockZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.userInfosValue, false, EloixClient.IndexServer.BSerializer_1132956238.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkinUsers obj = (BRequest_IXServicePortIF_checkinUsers)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkinUsers()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.checkinUsersZValue = (EloixClient.IndexServer.CheckinUsersZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.unlockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userInfosValue = (EloixClient.IndexServer.UserInfo[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1132956238.instance);
			
			return obj;
		}
		
	}
} // namespace

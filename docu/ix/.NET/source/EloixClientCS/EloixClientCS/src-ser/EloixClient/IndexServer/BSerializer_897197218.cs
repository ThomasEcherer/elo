//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinReplNames
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_897197218 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_897197218();
		
		public BSerializer_897197218()
			: base(897197218) {}
		
		public BSerializer_897197218(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkinReplNames obj = (BRequest_IXServicePortIF_checkinReplNames)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.replNamesValue, false, EloixClient.IndexServer.BSerializer_884364631.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.unlockZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkinReplNames obj = (BRequest_IXServicePortIF_checkinReplNames)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkinReplNames()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.replNamesValue = (EloixClient.IndexServer.ReplSetName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_884364631.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.unlockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

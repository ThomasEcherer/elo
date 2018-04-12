//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinColors
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1576322695 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1576322695();
		
		public BSerializer_1576322695()
			: base(1576322695) {}
		
		public BSerializer_1576322695(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkinColors obj = (BRequest_IXServicePortIF_checkinColors)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.colorsValue, false, EloixClient.IndexServer.BSerializer_1870182600.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.unlockZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkinColors obj = (BRequest_IXServicePortIF_checkinColors)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkinColors()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.colorsValue = (EloixClient.IndexServer.ColorData[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1870182600.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.unlockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

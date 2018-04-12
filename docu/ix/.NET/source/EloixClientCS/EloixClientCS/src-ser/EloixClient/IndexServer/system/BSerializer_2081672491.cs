//
// Serializer for de.elo.ix.client.system.BRequest_SystemInformation_userReport
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class BSerializer_2081672491 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2081672491();
		
		public BSerializer_2081672491()
			: base(2081672491) {}
		
		public BSerializer_2081672491(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_SystemInformation_userReport obj = (BRequest_SystemInformation_userReport)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.siValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_SystemInformation_userReport obj = (BRequest_SystemInformation_userReport)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_SystemInformation_userReport()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.siValue = (EloixClient.Indexserver.system.SystemInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

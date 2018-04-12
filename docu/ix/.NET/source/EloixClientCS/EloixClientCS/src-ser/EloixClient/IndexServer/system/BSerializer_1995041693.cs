//
// Serializer for de.elo.ix.client.system.BRequest_SystemInformation_archivReport
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class BSerializer_1995041693 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1995041693();
		
		public BSerializer_1995041693()
			: base(1995041693) {}
		
		public BSerializer_1995041693(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_SystemInformation_archivReport obj = (BRequest_SystemInformation_archivReport)obj1;			
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
			BRequest_SystemInformation_archivReport obj = (BRequest_SystemInformation_archivReport)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_SystemInformation_archivReport()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.siValue = (EloixClient.Indexserver.system.SystemInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

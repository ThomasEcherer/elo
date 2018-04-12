//
// Serializer for de.elo.ix.client.health.HealthCheckInfos
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	public class BSerializer_333475674 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_333475674();
		
		public BSerializer_333475674()
			: base(333475674) {}
		
		public BSerializer_333475674(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			HealthCheckInfos obj = (HealthCheckInfos)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.archiveGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.customerLicenseKeyHash);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.infos, false, EloixClient.IndexServer.BSerializer_1270538819.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			HealthCheckInfos obj = (HealthCheckInfos)(obj1 != null ? obj1 : bin.onObjectCreated(new HealthCheckInfos()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.archiveGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.customerLicenseKeyHash = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.infos = (IList<EloixClient.IndexServer.health.HealthCheckInfo>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkLicense
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_523346511 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_523346511();
		
		public BSerializer_523346511()
			: base(523346511) {}
		
		public BSerializer_523346511(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkLicense obj = (BRequest_IXServicePortIF_checkLicense)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.licenseInfoValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkLicense obj = (BRequest_IXServicePortIF_checkLicense)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkLicense()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.licenseInfoValue = (EloixClient.IndexServer.LicenseInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

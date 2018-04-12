//
// Serializer for de.elo.ix.client.LicenseInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2024296158 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2024296158();
		
		public BSerializer_2024296158()
			: base(2024296158) {}
		
		public BSerializer_2024296158(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			LicenseInfo obj = (LicenseInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.customerName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.licenseKey);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.moduleName);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			LicenseInfo obj = (LicenseInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new LicenseInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.customerName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.licenseKey = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.moduleName = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.system.LicenseCounter
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class BSerializer_189487184 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_189487184();
		
		public BSerializer_189487184()
			: base(189487184) {}
		
		public BSerializer_189487184(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			LicenseCounter obj = (LicenseCounter)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.countType);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.disabled);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.sumAccess);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.accessMap, false, EloixClient.IndexServer.BSerializer_1434022628.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.userInfo, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			LicenseCounter obj = (LicenseCounter)(obj1 != null ? obj1 : bin.onObjectCreated(new LicenseCounter()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.countType = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.disabled = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sumAccess = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.accessMap = (Dictionary<int,int>)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userInfo = (EloixClient.IndexServer.UserInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

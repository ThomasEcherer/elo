//
// Serializer for de.elo.ix.client.system.LicenseReport
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class BSerializer_1320348587 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1320348587();
		
		public BSerializer_1320348587()
			: base(1320348587) {}
		
		public BSerializer_1320348587(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			LicenseReport obj = (LicenseReport)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.deletedUser);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.freeUser);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.fullUser);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.ixUser);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nbOfIgLicenses);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nbOfServerLicenses);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.serno);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.counterList, false, EloixClient.IndexServer.BSerializer_2005491011.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			LicenseReport obj = (LicenseReport)(obj1 != null ? obj1 : bin.onObjectCreated(new LicenseReport()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.deletedUser = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.freeUser = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fullUser = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ixUser = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nbOfIgLicenses = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nbOfServerLicenses = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.serno = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.counterList = (IList<EloixClient.Indexserver.system.LicenseCounter>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

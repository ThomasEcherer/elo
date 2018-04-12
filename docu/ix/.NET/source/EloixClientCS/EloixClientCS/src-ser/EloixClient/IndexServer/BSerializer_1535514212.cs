//
// Serializer for de.elo.ix.client.FindByAcl
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1535514212 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1535514212();
		
		public BSerializer_1535514212()
			: base(1535514212) {}
		
		public BSerializer_1535514212(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindByAcl obj = (FindByAcl)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.distinctAcl);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.acls, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindByAcl obj = (FindByAcl)(obj1 != null ? obj1 : bin.onObjectCreated(new FindByAcl()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.distinctAcl = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.acls = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace

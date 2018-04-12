//
// Serializer for de.elo.ix.client.ProcessAcl
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_402225782 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_402225782();
		
		public BSerializer_402225782()
			: base(402225782) {}
		
		public BSerializer_402225782(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ProcessAcl obj = (ProcessAcl)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 700000020000008L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.addAcl);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.andAcl);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.setAcl);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.subAcl);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.addAclItems, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.andAclItems, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.setAclItems, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.subAclItems, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ProcessAcl obj = (ProcessAcl)(obj1 != null ? obj1 : bin.onObjectCreated(new ProcessAcl()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 700000020000008L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.addAcl = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.andAcl = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.setAcl = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.subAcl = bbuf.getString();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.addAclItems = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.andAclItems = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.setAclItems = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.subAclItems = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			
			return obj;
		}
		
	}
} // namespace

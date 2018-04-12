//
// Serializer for de.elo.ix.client.EditInfoZ
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_878901868 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_878901868();
		
		public BSerializer_878901868()
			: base(878901868) {}
		
		public BSerializer_878901868(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			EditInfoZ obj = (EditInfoZ)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.bset);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordZ, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EditInfoZ obj = (EditInfoZ)(obj1 != null ? obj1 : bin.onObjectCreated(new EditInfoZ()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.bset = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordZ = (EloixClient.IndexServer.SordZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

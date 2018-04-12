//
// Serializer for de.elo.ix.client.system.SystemReport
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class BSerializer_276702696 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_276702696();
		
		public BSerializer_276702696()
			: base(276702696) {}
		
		public BSerializer_276702696(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			SystemReport obj = (SystemReport)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.doccount);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.docsize);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.ftsize);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.previewsize);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SystemReport obj = (SystemReport)(obj1 != null ? obj1 : bin.onObjectCreated(new SystemReport()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.doccount = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docsize = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ftsize = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.previewsize = bbuf.getLong();
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.EloFtOpt
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_181406923 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_181406923();
		
		public BSerializer_181406923()
			: base(181406923) {}
		
		public BSerializer_181406923(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			EloFtOpt obj = (EloFtOpt)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.remark);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.value);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EloFtOpt obj = (EloFtOpt)(obj1 != null ? obj1 : bin.onObjectCreated(new EloFtOpt()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.remark = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.value = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

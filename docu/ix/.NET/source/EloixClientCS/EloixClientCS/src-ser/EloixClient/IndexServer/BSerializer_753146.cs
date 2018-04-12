//
// Serializer for de.elo.ix.client.ObjChange
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_753146 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_753146();
		
		public BSerializer_753146()
			: base(753146) {}
		
		public BSerializer_753146(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ObjChange obj = (ObjChange)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.code);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.param);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.param2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.tStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.user);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ObjChange obj = (ObjChange)(obj1 != null ? obj1 : bin.onObjectCreated(new ObjChange()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.code = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.param = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.param2 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.user = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.ObjKey
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_237417996 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_237417996();
		
		public BSerializer_237417996()
			: base(237417996) {}
		
		public BSerializer_237417996(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ObjKey obj = (ObjKey)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.data, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ObjKey obj = (ObjKey)(obj1 != null ? obj1 : bin.onObjectCreated(new ObjKey()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.data = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace

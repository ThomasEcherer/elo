//
// Serializer for de.elo.ix.client.Keyword
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1426243550 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1426243550();
		
		public BSerializer_1426243550()
			: base(1426243550) {}
		
		public BSerializer_1426243550(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			Keyword obj = (Keyword)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.add);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.enabled);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.raw);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.text);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.children, false, EloixClient.IndexServer.BSerializer_206201524.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Keyword obj = (Keyword)(obj1 != null ? obj1 : bin.onObjectCreated(new Keyword()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.add = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.enabled = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.raw = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.text = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.children = (EloixClient.IndexServer.Keyword[])bin.readObj(false, EloixClient.IndexServer.BSerializer_206201524.instance);
			
			return obj;
		}
		
	}
} // namespace

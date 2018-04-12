//
// Serializer for de.elo.ix.client.ActivityOption
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_595132669 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_595132669();
		
		public BSerializer_595132669()
			: base(595132669) {}
		
		public BSerializer_595132669(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ActivityOption obj = (ActivityOption)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.mandatory);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.onlyKeyword);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.readOnly);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.sorted);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.stamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.keywords, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ActivityOption obj = (ActivityOption)(obj1 != null ? obj1 : bin.onObjectCreated(new ActivityOption()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.mandatory = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.onlyKeyword = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.readOnly = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sorted = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.stamp = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.keywords = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace

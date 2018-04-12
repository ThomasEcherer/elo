//
// Serializer for de.elo.ix.client.ValuesOfObjKey
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1153931872 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1153931872();
		
		public BSerializer_1153931872()
			: base(1153931872) {}
		
		public BSerializer_1153931872(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ValuesOfObjKey obj = (ValuesOfObjKey)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.totalCount);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.usageCounts, false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.values, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ValuesOfObjKey obj = (ValuesOfObjKey)(obj1 != null ? obj1 : bin.onObjectCreated(new ValuesOfObjKey()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.totalCount = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.usageCounts = (int[])bin.readObj(false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.values = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace

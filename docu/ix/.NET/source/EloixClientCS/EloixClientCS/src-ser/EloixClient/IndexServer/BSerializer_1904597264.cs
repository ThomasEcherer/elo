//
// Serializer for de.elo.ix.client.CopyResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1904597264 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1904597264();
		
		public BSerializer_1904597264()
			: base(1904597264) {}
		
		public BSerializer_1904597264(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			CopyResult obj = (CopyResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.mapGuidsSource2Copy, false, EloixClient.IndexServer.BSerializer_1710660846.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.mapIdsSource2Copy, false, EloixClient.IndexServer.BSerializer_1347703734.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CopyResult obj = (CopyResult)(obj1 != null ? obj1 : bin.onObjectCreated(new CopyResult()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.mapGuidsSource2Copy = (IDictionary<String,String>)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.mapIdsSource2Copy = (IDictionary<int,int>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

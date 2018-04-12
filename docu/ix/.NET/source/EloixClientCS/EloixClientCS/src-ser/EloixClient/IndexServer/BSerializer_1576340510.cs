//
// Serializer for de.elo.ix.client.PurgeSettings
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1576340510 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1576340510();
		
		public BSerializer_1576340510()
			: base(1576340510) {}
		
		public BSerializer_1576340510(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			PurgeSettings obj = (PurgeSettings)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.dayLimit);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.fileCheckMode);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.pathId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.startHour);
			if (version >= 900000000000027L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.excludePathIds, false, EloixClient.IndexServer.BSerializer_181681714.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			PurgeSettings obj = (PurgeSettings)(obj1 != null ? obj1 : bin.onObjectCreated(new PurgeSettings()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dayLimit = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fileCheckMode = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.pathId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.startHour = bbuf.getInt();
			if (version >= 900000000000027L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.excludePathIds = (IList<int>)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace

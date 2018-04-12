//
// Serializer for de.elo.ix.client.search.OptimizerConfig
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace de.elo.ix.client.search
{
	
	public class BSerializer_645566676 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_645566676();
		
		public BSerializer_645566676()
			: base(645566676) {}
		
		public BSerializer_645566676(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			OptimizerConfig obj = (OptimizerConfig)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.intervalHours);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ixid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lastException);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putDate(obj.nextRunAt);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt((int)obj.status);
			if (version >= 1000000000000007L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.lockName);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			OptimizerConfig obj = (OptimizerConfig)(obj1 != null ? obj1 : bin.onObjectCreated(new OptimizerConfig()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.intervalHours = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ixid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lastException = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nextRunAt = bbuf.getDate();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.status = (de.elo.ix.client.search.SearchIndexerStatus)bbuf.getInt();
			if (version >= 1000000000000007L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lockName = bbuf.getString();
			}
			
			return obj;
		}
		
	}
} // namespace

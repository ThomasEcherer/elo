//
// Serializer for de.elo.ix.client.PurgeStatus
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2053888643 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2053888643();
		
		public BSerializer_2053888643()
			: base(2053888643) {}
		
		public BSerializer_2053888643(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			PurgeStatus obj = (PurgeStatus)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.errorMessage);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.isRunning);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lastPurgeTime);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.numberOfDocsPurged);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			PurgeStatus obj = (PurgeStatus)(obj1 != null ? obj1 : bin.onObjectCreated(new PurgeStatus()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.errorMessage = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.isRunning = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lastPurgeTime = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.numberOfDocsPurged = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace

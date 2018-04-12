//
// Serializer for de.elo.ix.client.system.SystemInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class BSerializer_2061316528 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2061316528();
		
		public BSerializer_2061316528()
			: base(2061316528) {}
		
		public BSerializer_2061316528(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			SystemInfo obj = (SystemInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.endDate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.startDate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.storePathID);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.userReportMode);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SystemInfo obj = (SystemInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new SystemInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.endDate = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.startDate = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.storePathID = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userReportMode = bbuf.getLong();
			
			return obj;
		}
		
	}
} // namespace

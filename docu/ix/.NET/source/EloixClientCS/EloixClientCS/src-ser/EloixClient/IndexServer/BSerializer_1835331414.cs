//
// Serializer for de.elo.ix.client.SordPaths
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1835331414 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1835331414();
		
		public BSerializer_1835331414()
			: base(1835331414) {}
		
		public BSerializer_1835331414(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			SordPaths obj = (SordPaths)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordPaths, false, EloixClient.IndexServer.BSerializer_1773247378.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SordPaths obj = (SordPaths)(obj1 != null ? obj1 : bin.onObjectCreated(new SordPaths()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordPaths = (IList<EloixClient.IndexServer.SordPath>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

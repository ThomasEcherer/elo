//
// Serializer for de.elo.ix.client.BResult_907729609
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1537036490 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1537036490();
		
		public BSerializer_1537036490()
			: base(1537036490) {}
		
		public BSerializer_1537036490(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_907729609 obj = (BResult_907729609)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_907729609.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_907729609 obj = (BResult_907729609)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_907729609()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (IList<EloixClient.IndexServer.ResolveRightsResult>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.WFNodeMatrix
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_425879495 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_425879495();
		
		public BSerializer_425879495()
			: base(425879495) {}
		
		public BSerializer_425879495(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			WFNodeMatrix obj = (WFNodeMatrix)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.assocs, false, EloixClient.IndexServer.BSerializer_715244239.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFNodeMatrix obj = (WFNodeMatrix)(obj1 != null ? obj1 : bin.onObjectCreated(new WFNodeMatrix()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.assocs = (EloixClient.IndexServer.WFNodeAssoc[])bin.readObj(false, EloixClient.IndexServer.BSerializer_715244239.instance);
			
			return obj;
		}
		
	}
} // namespace

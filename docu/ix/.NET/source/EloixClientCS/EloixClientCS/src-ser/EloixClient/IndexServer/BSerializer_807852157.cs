//
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterRefSord
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_807852157 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_807852157();
		
		public BSerializer_807852157()
			: base(807852157) {}
		
		public BSerializer_807852157(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServerEvents_onAfterRefSord obj = (BRequest_IXServerEvents_onAfterRefSord)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.manSortIndexValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ecValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.parentSordNewValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.parentSordOldValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServerEvents_onAfterRefSord obj = (BRequest_IXServerEvents_onAfterRefSord)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServerEvents_onAfterRefSord()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.manSortIndexValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ecValue = (EloixClient.IndexServer.IXServerEventsContext)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.parentSordNewValue = (EloixClient.IndexServer.Sord)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.parentSordOldValue = (EloixClient.IndexServer.Sord)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordValue = (EloixClient.IndexServer.Sord)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

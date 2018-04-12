//
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onInheritKeywording
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_53854844 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_53854844();
		
		public BSerializer_53854844()
			: base(53854844) {}
		
		public BSerializer_53854844(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServerEvents_onInheritKeywording obj = (BRequest_IXServerEvents_onInheritKeywording)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ecValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.okeyNamesValue, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.parentSordValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.reservedValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServerEvents_onInheritKeywording obj = (BRequest_IXServerEvents_onInheritKeywording)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServerEvents_onInheritKeywording()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ecValue = (EloixClient.IndexServer.IXServerEventsContext)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.okeyNamesValue = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.parentSordValue = (EloixClient.IndexServer.Sord)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.reservedValue = (Object)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordValue = (EloixClient.IndexServer.Sord)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

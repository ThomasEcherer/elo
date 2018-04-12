//
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_executeRegisteredFunctionString
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1679329575 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1679329575();
		
		public BSerializer_1679329575()
			: base(1679329575) {}
		
		public BSerializer_1679329575(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServerEvents_executeRegisteredFunctionString obj = (BRequest_IXServerEvents_executeRegisteredFunctionString)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.argsValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.functionNameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ecValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServerEvents_executeRegisteredFunctionString obj = (BRequest_IXServerEvents_executeRegisteredFunctionString)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServerEvents_executeRegisteredFunctionString()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.argsValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.functionNameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ecValue = (EloixClient.IndexServer.IXServerEventsContext)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

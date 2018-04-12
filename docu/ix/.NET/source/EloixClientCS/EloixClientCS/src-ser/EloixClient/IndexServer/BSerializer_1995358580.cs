//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_startAdHocWorkFlow
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1995358580 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1995358580();
		
		public BSerializer_1995358580()
			: base(1995358580) {}
		
		public BSerializer_1995358580(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_startAdHocWorkFlow obj = (BRequest_IXServicePortIF_startAdHocWorkFlow)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.cancelMessageValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.cancelUserIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.finishedMessageValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.finishedScriptValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.finishedUserIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.forValidationValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.nameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.nodeNameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.serialFlowValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.arrUserIdsValue, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_startAdHocWorkFlow obj = (BRequest_IXServicePortIF_startAdHocWorkFlow)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_startAdHocWorkFlow()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.cancelMessageValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.cancelUserIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.finishedMessageValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.finishedScriptValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.finishedUserIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.forValidationValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeNameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.serialFlowValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.arrUserIdsValue = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

﻿//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_startAdHocWorkFlow3
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1726573785 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1726573785();
		
		public BSerializer_1726573785()
			: base(1726573785) {}
		
		public BSerializer_1726573785(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_startAdHocWorkFlow3 obj = (BRequest_IXServicePortIF_startAdHocWorkFlow3)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.nameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.startWfInfoValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_startAdHocWorkFlow3 obj = (BRequest_IXServicePortIF_startAdHocWorkFlow3)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_startAdHocWorkFlow3()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.startWfInfoValue = (EloixClient.IndexServer.StartAdHocWorkflowInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

﻿//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_testAdapter
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1934035815 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1934035815();
		
		public BSerializer_1934035815()
			: base(1934035815) {}
		
		public BSerializer_1934035815(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_testAdapter obj = (BRequest_IXServicePortIF_testAdapter)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.fnValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.paramsValue, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_testAdapter obj = (BRequest_IXServicePortIF_testAdapter)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_testAdapter()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fnValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.paramsValue = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace

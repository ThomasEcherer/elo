﻿//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getCompiledScripts
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1449667401 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1449667401();
		
		public BSerializer_1449667401()
			: base(1449667401) {}
		
		public BSerializer_1449667401(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_getCompiledScripts obj = (BRequest_IXServicePortIF_getCompiledScripts)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_getCompiledScripts obj = (BRequest_IXServicePortIF_getCompiledScripts)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_getCompiledScripts()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

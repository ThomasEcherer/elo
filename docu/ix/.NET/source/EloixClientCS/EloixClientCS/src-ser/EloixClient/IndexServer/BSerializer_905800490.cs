//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_executeScript
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_905800490 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_905800490();
		
		public BSerializer_905800490()
			: base(905800490) {}
		
		public BSerializer_905800490(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_executeScript obj = (BRequest_IXServicePortIF_executeScript)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.paramsValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_executeScript obj = (BRequest_IXServicePortIF_executeScript)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_executeScript()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.paramsValue = (EloixClient.IndexServer.ExecuteScriptParams)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

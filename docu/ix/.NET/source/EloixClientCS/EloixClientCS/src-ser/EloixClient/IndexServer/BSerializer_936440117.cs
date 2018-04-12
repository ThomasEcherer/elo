//
// Serializer for de.elo.ix.client.ExecuteScriptParams
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_936440117 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_936440117();
		
		public BSerializer_936440117()
			: base(936440117) {}
		
		public BSerializer_936440117(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ExecuteScriptParams obj = (ExecuteScriptParams)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.functionName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.scriptEngine);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.scriptObjId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.scriptString);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.functionParams, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.scriptCode, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ExecuteScriptParams obj = (ExecuteScriptParams)(obj1 != null ? obj1 : bin.onObjectCreated(new ExecuteScriptParams()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.functionName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.scriptEngine = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.scriptObjId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.scriptString = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.functionParams = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.scriptCode = (EloixClient.IndexServer.FileData)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

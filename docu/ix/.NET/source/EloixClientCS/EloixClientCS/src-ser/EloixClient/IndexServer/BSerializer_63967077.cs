//
// Serializer for de.elo.ix.client.ExecuteScriptResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_63967077 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_63967077();
		
		public BSerializer_63967077()
			: base(63967077) {}
		
		public BSerializer_63967077(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ExecuteScriptResult obj = (ExecuteScriptResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.errorColumn);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.errorLine);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.errorMessage);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.returnedString);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ExecuteScriptResult obj = (ExecuteScriptResult)(obj1 != null ? obj1 : bin.onObjectCreated(new ExecuteScriptResult()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.errorColumn = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.errorLine = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.errorMessage = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.returnedString = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

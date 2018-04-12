//
// Serializer for de.elo.ix.client.WorkflowExportOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_402835780 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_402835780();
		
		public BSerializer_402835780()
			: base(402835780) {}
		
		public BSerializer_402835780(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			WorkflowExportOptions obj = (WorkflowExportOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.characterSet);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.flowId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.flowVersId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.wordWrap);
			if (version >= 900000016000017L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.format);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WorkflowExportOptions obj = (WorkflowExportOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new WorkflowExportOptions()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.characterSet = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowVersId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.wordWrap = bbuf.getString();
			if (version >= 900000016000017L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.format = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace

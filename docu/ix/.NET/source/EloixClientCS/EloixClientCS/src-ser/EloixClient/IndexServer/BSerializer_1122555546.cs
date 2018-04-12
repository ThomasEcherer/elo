//
// Serializer for de.elo.ix.client.ProcessScript
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1122555546 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1122555546();
		
		public BSerializer_1122555546()
			: base(1122555546) {}
		
		public BSerializer_1122555546(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ProcessScript obj = (ProcessScript)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.processPostfix);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.tag);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ProcessScript obj = (ProcessScript)(obj1 != null ? obj1 : bin.onObjectCreated(new ProcessScript()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.processPostfix = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tag = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

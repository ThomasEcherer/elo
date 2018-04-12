//
// Serializer for de.elo.ix.client.FindByRegisteredFunction
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_700871698 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_700871698();
		
		public BSerializer_700871698()
			: base(700871698) {}
		
		public BSerializer_700871698(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindByRegisteredFunction obj = (FindByRegisteredFunction)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.functionName);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.args, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindByRegisteredFunction obj = (FindByRegisteredFunction)(obj1 != null ? obj1 : bin.onObjectCreated(new FindByRegisteredFunction()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.functionName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.args = (EloixClient.IndexServer.Any)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

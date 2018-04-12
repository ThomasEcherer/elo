//
// Serializer for de.elo.ix.client.myelo.MyELOState
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.myelo
{
	
	public class BSerializer_1426941339 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1426941339();
		
		public BSerializer_1426941339()
			: base(1426941339) {}
		
		public BSerializer_1426941339(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			MyELOState obj = (MyELOState)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.newFeed);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.newTask);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.newWorkflow);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userGuid);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MyELOState obj = (MyELOState)(obj1 != null ? obj1 : bin.onObjectCreated(new MyELOState()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.newFeed = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.newTask = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.newWorkflow = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userGuid = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

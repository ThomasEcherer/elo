//
// Serializer for de.elo.ix.client.UserTask
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1484696239 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1484696239();
		
		public BSerializer_1484696239()
			: base(1484696239) {}
		
		public BSerializer_1484696239(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			UserTask obj = (UserTask)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.activity, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.reminder, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.wfNode, false, null);
			if (version >= 800000020000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.sord, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			UserTask obj = (UserTask)(obj1 != null ? obj1 : bin.onObjectCreated(new UserTask()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.activity = (EloixClient.IndexServer.Activity)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.reminder = (EloixClient.IndexServer.Reminder)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.wfNode = (EloixClient.IndexServer.WFCollectNode)bin.readObj(false, null);
			if (version >= 800000020000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.sord = (EloixClient.IndexServer.Sord)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace

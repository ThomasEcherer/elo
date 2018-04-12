//
// Serializer for de.elo.ix.client.WFNodeHistory
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_784568809 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_784568809();
		
		public BSerializer_784568809()
			: base(784568809) {}
		
		public BSerializer_784568809(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			WFNodeHistory obj = (WFNodeHistory)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.enterDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.exitDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.flowGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.histGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nodeId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_0);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_1);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_10);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_11);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_12);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_13);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_14);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_15);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_16);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_17);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_18);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_19);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_3);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_4);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_5);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_6);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_7);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_8);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ_9);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.userId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userName);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFNodeHistory obj = (WFNodeHistory)(obj1 != null ? obj1 : bin.onObjectCreated(new WFNodeHistory()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.enterDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.exitDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.histGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_0 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_1 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_10 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_11 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_12 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_13 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_14 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_15 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_16 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_17 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_18 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_19 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_2 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_3 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_4 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_5 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_6 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_7 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_8 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ_9 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userName = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

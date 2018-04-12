//
// Serializer for de.elo.ix.client.ReportInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1280848136 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1280848136();
		
		public BSerializer_1280848136()
			: base(1280848136) {}
		
		public BSerializer_1280848136(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ReportInfo obj = (ReportInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.actTime);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.actTimeISO);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.action);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.actionNo);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.comment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.extra1);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.extra2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.sessionNo);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.text);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.userId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userName);
			if (version >= 900000016000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.extra3);
			}
			if (version >= 900000016000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.extraInfo, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReportInfo obj = (ReportInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new ReportInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.actTime = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.actTimeISO = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.action = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.actionNo = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.comment = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.extra1 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.extra2 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sessionNo = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.text = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userName = bbuf.getString();
			if (version >= 900000016000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.extra3 = bbuf.getString();
			}
			if (version >= 900000016000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.extraInfo = (Object)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace

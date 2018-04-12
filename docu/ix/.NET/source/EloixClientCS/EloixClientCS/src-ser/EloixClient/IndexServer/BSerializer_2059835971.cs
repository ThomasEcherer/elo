//
// Serializer for de.elo.ix.client.UserNodeInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2059835971 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2059835971();
		
		public BSerializer_2059835971()
			: base(2059835971) {}
		
		public BSerializer_2059835971(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			UserNodeInfo obj = (UserNodeInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.nodeName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userId);
			if (version >= 900000016000009L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.timeLimit);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.timeLimitIso);
				if (version >= 900000016000013L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.flags);
				}
			}
			if (version >= 900000016000009L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.timeLimitEscalations, false, EloixClient.IndexServer.BSerializer_1495941578.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			UserNodeInfo obj = (UserNodeInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new UserNodeInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getString();
			if (version >= 900000016000009L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.timeLimit = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.timeLimitIso = bbuf.getString();
				if (version >= 900000016000013L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.flags = bbuf.getInt();
				}
			}
			if (version >= 900000016000009L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.timeLimitEscalations = (EloixClient.IndexServer.WFTimeLimit[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1495941578.instance);
			}
			
			return obj;
		}
		
	}
} // namespace

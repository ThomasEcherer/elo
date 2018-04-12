//
// Serializer for de.elo.ix.client.SessionInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_866689803 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_866689803();
		
		public BSerializer_866689803()
			: base(866689803) {}
		
		public BSerializer_866689803(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			SessionInfo obj = (SessionInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.clientComputer);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.userId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.validSeconds);
			if (version >= 800000032000006L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.appName);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.appType);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.appVersion);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.bestBefore);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.runAs);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.ticket);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.userName);
				if (version >= 900000022000005L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.loginName);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SessionInfo obj = (SessionInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new SessionInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.clientComputer = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.validSeconds = bbuf.getInt();
			if (version >= 800000032000006L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.appName = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.appType = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.appVersion = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.bestBefore = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.runAs = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.ticket = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.userName = bbuf.getString();
				if (version >= 900000022000005L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.loginName = bbuf.getString();
				}
			}
			
			return obj;
		}
		
	}
} // namespace

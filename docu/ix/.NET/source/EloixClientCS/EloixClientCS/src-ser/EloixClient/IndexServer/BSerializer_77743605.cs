//
// Serializer for de.elo.ix.client.ApplyForNotificationsInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_77743605 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_77743605();
		
		public BSerializer_77743605()
			: base(77743605) {}
		
		public BSerializer_77743605(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ApplyForNotificationsInfo obj = (ApplyForNotificationsInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.adminMode);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.userTask);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ApplyForNotificationsInfo obj = (ApplyForNotificationsInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new ApplyForNotificationsInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.adminMode = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userTask = bbuf.getBoolean();
			
			return obj;
		}
		
	}
} // namespace

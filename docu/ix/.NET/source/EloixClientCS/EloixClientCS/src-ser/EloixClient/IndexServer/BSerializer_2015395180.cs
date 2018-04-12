//
// Serializer for de.elo.ix.client.UserProfileData
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2015395180 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2015395180();
		
		public BSerializer_2015395180()
			: base(2015395180) {}
		
		public BSerializer_2015395180(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			UserProfileData obj = (UserProfileData)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.key);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.user);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.value);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			UserProfileData obj = (UserProfileData)(obj1 != null ? obj1 : bin.onObjectCreated(new UserProfileData()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.key = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.user = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.value = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

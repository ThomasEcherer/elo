//
// Serializer for de.elo.ix.client.SubsInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1910142939 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1910142939();
		
		public BSerializer_1910142939()
			: base(1910142939) {}
		
		public BSerializer_1910142939(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			SubsInfo obj = (SubsInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.active);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inheritRights);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.subsId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.subsName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.userId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userName);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SubsInfo obj = (SubsInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new SubsInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.active = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inheritRights = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.subsId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.subsName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userName = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

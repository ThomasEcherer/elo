//
// Serializer for de.elo.ix.client.FindByVersion
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_925953882 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_925953882();
		
		public BSerializer_925953882()
			: base(925953882) {}
		
		public BSerializer_925953882(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindByVersion obj = (FindByVersion)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.versionComment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.versionMD5);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.versionNumber);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.workVersionOnly);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindByVersion obj = (FindByVersion)(obj1 != null ? obj1 : bin.onObjectCreated(new FindByVersion()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.versionComment = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.versionMD5 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.versionNumber = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workVersionOnly = bbuf.getBoolean();
			
			return obj;
		}
		
	}
} // namespace

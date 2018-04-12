//
// Serializer for de.elo.ix.client.FindConfigFileInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1887106523 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1887106523();
		
		public BSerializer_1887106523()
			: base(1887106523) {}
		
		public BSerializer_1887106523(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindConfigFileInfo obj = (FindConfigFileInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclDeputy);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.postboxUserId);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.names, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindConfigFileInfo obj = (FindConfigFileInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FindConfigFileInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclDeputy = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.postboxUserId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.names = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace

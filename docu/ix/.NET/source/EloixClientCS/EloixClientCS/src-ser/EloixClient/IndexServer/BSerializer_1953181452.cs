//
// Serializer for de.elo.ix.client.NavigationInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1953181452 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1953181452();
		
		public BSerializer_1953181452()
			: base(1953181452) {}
		
		public BSerializer_1953181452(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			NavigationInfo obj = (NavigationInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.ignoreDocuments);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.maxCount);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.maxDepth);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.maxSiblings);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.startIDs, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			if (version >= 900000014000007L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.findInfo, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			NavigationInfo obj = (NavigationInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new NavigationInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ignoreDocuments = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maxCount = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maxDepth = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maxSiblings = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.startIDs = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			if (version >= 900000014000007L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.findInfo = (EloixClient.IndexServer.FindInfo)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace

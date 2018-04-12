//
// Serializer for de.elo.ix.client.ServerInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1701204890 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1701204890();
		
		public BSerializer_1701204890()
			: base(1701204890) {}
		
		public BSerializer_1701204890(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ServerInfo obj = (ServerInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.version);
			if (version >= 700000000000015L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.replProcessOnServerId);
				if (version >= 800000000000002L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.databaseEngine);
					if (version >= 800000012000004L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.instanceName);
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.indexServers, false, EloixClient.IndexServer.BSerializer_1712744473.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.license, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ServerInfo obj = (ServerInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new ServerInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.version = bbuf.getString();
			if (version >= 700000000000015L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.replProcessOnServerId = bbuf.getString();
				if (version >= 800000000000002L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.databaseEngine = bbuf.getString();
					if (version >= 800000012000004L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.instanceName = bbuf.getString();
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.indexServers = (EloixClient.IndexServer.IndexServerForArchive[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1712744473.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.license = (EloixClient.IndexServer.License)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.ServerInfoDM
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1425760760 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1425760760();
		
		public BSerializer_1425760760()
			: base(1425760760) {}
		
		public BSerializer_1425760760(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ServerInfoDM obj = (ServerInfoDM)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.blackeningEnabled);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.proxyMode);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.restoreStoreId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.storeMode);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.backupStoreIds, false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.basisStoreIds, false, EloixClient.IndexServer.BSerializer_100361105.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ServerInfoDM obj = (ServerInfoDM)(obj1 != null ? obj1 : bin.onObjectCreated(new ServerInfoDM()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.blackeningEnabled = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.proxyMode = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.restoreStoreId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.storeMode = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.backupStoreIds = (int[])bin.readObj(false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.basisStoreIds = (int[])bin.readObj(false, EloixClient.IndexServer.BSerializer_100361105.instance);
			
			return obj;
		}
		
	}
} // namespace

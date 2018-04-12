//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getEditInfoFromESW
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_835848697 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_835848697();
		
		public BSerializer_835848697()
			: base(835848697) {}
		
		public BSerializer_835848697(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_getEditInfoFromESW obj = (BRequest_IXServicePortIF_getEditInfoFromESW)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.eswOptionsValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.fileDatasValue, false, EloixClient.IndexServer.BSerializer_1078168929.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_getEditInfoFromESW obj = (BRequest_IXServicePortIF_getEditInfoFromESW)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_getEditInfoFromESW()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.eswOptionsValue = (EloixClient.IndexServer.EditInfoEswOptions)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fileDatasValue = (EloixClient.IndexServer.FileData[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1078168929.instance);
			
			return obj;
		}
		
	}
} // namespace

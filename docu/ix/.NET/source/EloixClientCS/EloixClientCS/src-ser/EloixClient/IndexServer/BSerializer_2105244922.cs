//
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onFileUploadBuildResponse
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2105244922 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2105244922();
		
		public BSerializer_2105244922()
			: base(2105244922) {}
		
		public BSerializer_2105244922(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServerEvents_onFileUploadBuildResponse obj = (BRequest_IXServerEvents_onFileUploadBuildResponse)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.fileNameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.dvValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ecValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.requestInfoValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.responseInfoValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServerEvents_onFileUploadBuildResponse obj = (BRequest_IXServerEvents_onFileUploadBuildResponse)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServerEvents_onFileUploadBuildResponse()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fileNameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dvValue = (EloixClient.IndexServer.DocVersion)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ecValue = (EloixClient.IndexServer.IXServerEventsContext)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.requestInfoValue = (EloixClient.IndexServer.HttpRequestInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.responseInfoValue = (EloixClient.IndexServer.HttpResponseInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

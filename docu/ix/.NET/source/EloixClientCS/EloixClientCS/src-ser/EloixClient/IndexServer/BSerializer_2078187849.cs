//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinDocsBegin
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2078187849 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2078187849();
		
		public BSerializer_2078187849()
			: base(2078187849) {}
		
		public BSerializer_2078187849(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkinDocsBegin obj = (BRequest_IXServicePortIF_checkinDocsBegin)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.documentsValue, false, EloixClient.IndexServer.BSerializer_1047127860.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkinDocsBegin obj = (BRequest_IXServicePortIF_checkinDocsBegin)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkinDocsBegin()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.documentsValue = (EloixClient.IndexServer.Document[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1047127860.instance);
			
			return obj;
		}
		
	}
} // namespace

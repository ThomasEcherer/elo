﻿//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinDocsEnd
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1794336151 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1794336151();
		
		public BSerializer_1794336151()
			: base(1794336151) {}
		
		public BSerializer_1794336151(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkinDocsEnd obj = (BRequest_IXServicePortIF_checkinDocsEnd)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.documentsValue, false, EloixClient.IndexServer.BSerializer_1047127860.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordZsValue, false, EloixClient.IndexServer.BSerializer_1559053609.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordsValue, false, EloixClient.IndexServer.BSerializer_919539303.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.unlockZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkinDocsEnd obj = (BRequest_IXServicePortIF_checkinDocsEnd)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkinDocsEnd()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.documentsValue = (EloixClient.IndexServer.Document[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1047127860.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordZsValue = (EloixClient.IndexServer.SordZ[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1559053609.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordsValue = (EloixClient.IndexServer.Sord[])bin.readObj(false, EloixClient.IndexServer.BSerializer_919539303.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.unlockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

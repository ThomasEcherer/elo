//
// Serializer for de.elo.ix.client.HttpRequestInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1892343155 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1892343155();
		
		public BSerializer_1892343155()
			: base(1892343155) {}
		
		public BSerializer_1892343155(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			HttpRequestInfo obj = (HttpRequestInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.requestURI);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.requestURL);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.cookies, false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.headers, false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.requestParams, false, EloixClient.IndexServer.BSerializer_1826370901.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			HttpRequestInfo obj = (HttpRequestInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new HttpRequestInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.requestURI = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.requestURL = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.cookies = (EloixClient.IndexServer.KeyValue[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.headers = (EloixClient.IndexServer.KeyValue[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.requestParams = (EloixClient.IndexServer.KeyValue[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			
			return obj;
		}
		
	}
} // namespace

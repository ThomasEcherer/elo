//
// Serializer for de.elo.ix.client.Document
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_341056676 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_341056676();
		
		public BSerializer_341056676()
			: base(341056676) {}
		
		public BSerializer_341056676(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			Document obj = (Document)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.atts, false, EloixClient.IndexServer.BSerializer_807293031.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.docs, false, EloixClient.IndexServer.BSerializer_807293031.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Document obj = (Document)(obj1 != null ? obj1 : bin.onObjectCreated(new Document()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.atts = (EloixClient.IndexServer.DocVersion[])bin.readObj(false, EloixClient.IndexServer.BSerializer_807293031.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docs = (EloixClient.IndexServer.DocVersion[])bin.readObj(false, EloixClient.IndexServer.BSerializer_807293031.instance);
			
			return obj;
		}
		
	}
} // namespace

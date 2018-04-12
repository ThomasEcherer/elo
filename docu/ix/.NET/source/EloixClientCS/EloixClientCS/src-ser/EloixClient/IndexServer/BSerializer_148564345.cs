//
// Serializer for de.elo.ix.client.GetWebDAVPathResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_148564345 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_148564345();
		
		public BSerializer_148564345()
			: base(148564345) {}
		
		public BSerializer_148564345(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			GetWebDAVPathResult obj = (GetWebDAVPathResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.path);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			GetWebDAVPathResult obj = (GetWebDAVPathResult)(obj1 != null ? obj1 : bin.onObjectCreated(new GetWebDAVPathResult()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.path = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

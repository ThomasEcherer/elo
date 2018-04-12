//
// Serializer for de.elo.ix.client.BResult_1132956238
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1840998419 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1840998419();
		
		public BSerializer_1840998419()
			: base(1840998419) {}
		
		public BSerializer_1840998419(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1132956238 obj = (BResult_1132956238)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_1132956238.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1132956238 obj = (BResult_1132956238)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1132956238()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.UserInfo[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1132956238.instance);
			
			return obj;
		}
		
	}
} // namespace

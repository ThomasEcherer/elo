//
// Serializer for de.elo.ix.client.BResult_77743605
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1249722428 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1249722428();
		
		public BSerializer_1249722428()
			: base(1249722428) {}
		
		public BSerializer_1249722428(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_77743605 obj = (BResult_77743605)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_77743605 obj = (BResult_77743605)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_77743605()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.ApplyForNotificationsInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.BResult_52201250
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1769614830 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1769614830();
		
		public BSerializer_1769614830()
			: base(1769614830) {}
		
		public BSerializer_1769614830(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_52201250 obj = (BResult_52201250)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_52201250 obj = (BResult_52201250)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_52201250()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.BackupPurgeStatus)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

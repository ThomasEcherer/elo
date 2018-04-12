//
// Serializer for de.elo.ix.client.SordHistKey
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_251810638 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_251810638();
		
		public BSerializer_251810638()
			: base(251810638) {}
		
		public BSerializer_251810638(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			SordHistKey obj = (SordHistKey)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.histGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.keyData);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.keyName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.keyNo);
			if (version >= 800000032000007L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.keyId);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.keyIndex);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SordHistKey obj = (SordHistKey)(obj1 != null ? obj1 : bin.onObjectCreated(new SordHistKey()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.histGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.keyData = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.keyName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.keyNo = bbuf.getInt();
			if (version >= 800000032000007L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.keyId = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.keyIndex = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace

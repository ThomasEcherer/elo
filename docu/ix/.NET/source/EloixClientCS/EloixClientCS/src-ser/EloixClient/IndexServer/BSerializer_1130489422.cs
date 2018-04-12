//
// Serializer for de.elo.ix.client.ProcessCountElements
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1130489422 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1130489422();
		
		public BSerializer_1130489422()
			: base(1130489422) {}
		
		public BSerializer_1130489422(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ProcessCountElements obj = (ProcessCountElements)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.countResult, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ProcessCountElements obj = (ProcessCountElements)(obj1 != null ? obj1 : bin.onObjectCreated(new ProcessCountElements()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.countResult = (EloixClient.IndexServer.CountResult)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

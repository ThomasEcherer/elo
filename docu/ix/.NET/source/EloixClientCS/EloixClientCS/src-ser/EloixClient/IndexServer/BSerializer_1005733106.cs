//
// Serializer for de.elo.ix.client.EventListener
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1005733106 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1005733106();
		
		public BSerializer_1005733106()
			: base(1005733106) {}
		
		public BSerializer_1005733106(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			EventListener obj = (EventListener)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.filters, false, EloixClient.IndexServer.BSerializer_722503869.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EventListener obj = (EventListener)(obj1 != null ? obj1 : bin.onObjectCreated(new EventListener()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.filters = (EloixClient.IndexServer.EventFilter[])bin.readObj(false, EloixClient.IndexServer.BSerializer_722503869.instance);
			
			return obj;
		}
		
	}
} // namespace

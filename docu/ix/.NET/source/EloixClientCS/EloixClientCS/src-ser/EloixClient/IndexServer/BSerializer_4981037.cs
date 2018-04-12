//
// Serializer for de.elo.ix.client.LinkSordC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_4981037 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_4981037();
		
		public BSerializer_4981037()
			: base(4981037) {}
		
		public BSerializer_4981037(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			LinkSordC obj = (LinkSordC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.NOTHING, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			LinkSordC obj = (LinkSordC)(obj1 != null ? obj1 : bin.onObjectCreated(new LinkSordC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.NOTHING = (EloixClient.IndexServer.LinkSordZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

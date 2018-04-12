//
// Serializer for de.elo.ix.client.SordLink
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_200815802 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_200815802();
		
		public BSerializer_200815802()
			: base(200815802) {}
		
		public BSerializer_200815802(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			SordLink obj = (SordLink)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.linkId);
			if (version >= 900000016000008L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.permanent);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SordLink obj = (SordLink)(obj1 != null ? obj1 : bin.onObjectCreated(new SordLink()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.linkId = bbuf.getString();
			if (version >= 900000016000008L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.permanent = bbuf.getBoolean();
			}
			
			return obj;
		}
		
	}
} // namespace

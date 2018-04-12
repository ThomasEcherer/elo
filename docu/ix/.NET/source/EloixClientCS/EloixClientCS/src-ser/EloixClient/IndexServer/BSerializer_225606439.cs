//
// Serializer for de.elo.ix.client.AutoFilingOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_225606439 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_225606439();
		
		public BSerializer_225606439()
			: base(225606439) {}
		
		public BSerializer_225606439(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			AutoFilingOptions obj = (AutoFilingOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 900000018000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.autoFilingDefinition);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			AutoFilingOptions obj = (AutoFilingOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new AutoFilingOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 900000018000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.autoFilingDefinition = bbuf.getString();
			}
			
			return obj;
		}
		
	}
} // namespace

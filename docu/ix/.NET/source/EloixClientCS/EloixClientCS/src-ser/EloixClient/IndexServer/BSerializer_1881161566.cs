//
// Serializer for de.elo.ix.client.AutoFilingResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1881161566 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1881161566();
		
		public BSerializer_1881161566()
			: base(1881161566) {}
		
		public BSerializer_1881161566(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			AutoFilingResult obj = (AutoFilingResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.parentIds, false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.pathsAsString, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			AutoFilingResult obj = (AutoFilingResult)(obj1 != null ? obj1 : bin.onObjectCreated(new AutoFilingResult()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.parentIds = (int[])bin.readObj(false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.pathsAsString = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace

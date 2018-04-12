//
// Serializer for de.elo.ix.client.FindBySordHist
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2098788325 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2098788325();
		
		public BSerializer_2098788325()
			: base(2098788325) {}
		
		public BSerializer_2098788325(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindBySordHist obj = (FindBySordHist)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.histKeys, false, EloixClient.IndexServer.BSerializer_645430982.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindBySordHist obj = (FindBySordHist)(obj1 != null ? obj1 : bin.onObjectCreated(new FindBySordHist()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.histKeys = (EloixClient.IndexServer.SordHistKey[])bin.readObj(false, EloixClient.IndexServer.BSerializer_645430982.instance);
			
			return obj;
		}
		
	}
} // namespace

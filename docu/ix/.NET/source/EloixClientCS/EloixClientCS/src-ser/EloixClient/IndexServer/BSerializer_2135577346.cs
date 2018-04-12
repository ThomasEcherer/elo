//
// Serializer for de.elo.ix.client.EloFtStop
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2135577346 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2135577346();
		
		public BSerializer_2135577346()
			: base(2135577346) {}
		
		public BSerializer_2135577346(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			EloFtStop obj = (EloFtStop)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.stopword);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EloFtStop obj = (EloFtStop)(obj1 != null ? obj1 : bin.onObjectCreated(new EloFtStop()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.stopword = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.ReplSetCombination
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2078338937 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2078338937();
		
		public BSerializer_2078338937()
			: base(2078338937) {}
		
		public BSerializer_2078338937(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ReplSetCombination obj = (ReplSetCombination)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.combi, false, EloixClient.IndexServer.BSerializer_1374008726.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReplSetCombination obj = (ReplSetCombination)(obj1 != null ? obj1 : bin.onObjectCreated(new ReplSetCombination()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.combi = (byte[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1374008726.instance);
			
			return obj;
		}
		
	}
} // namespace

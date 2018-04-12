//
// Serializer for de.elo.ix.client.ProcessReplSet
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_712209598 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_712209598();
		
		public BSerializer_712209598()
			: base(712209598) {}
		
		public BSerializer_712209598(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ProcessReplSet obj = (ProcessReplSet)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.addReplSets, false, EloixClient.IndexServer.BSerializer_755261279.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.andReplSets, false, EloixClient.IndexServer.BSerializer_755261279.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.setReplSets, false, EloixClient.IndexServer.BSerializer_755261279.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.subReplSets, false, EloixClient.IndexServer.BSerializer_755261279.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ProcessReplSet obj = (ProcessReplSet)(obj1 != null ? obj1 : bin.onObjectCreated(new ProcessReplSet()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.addReplSets = (EloixClient.IndexServer.IdName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_755261279.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.andReplSets = (EloixClient.IndexServer.IdName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_755261279.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.setReplSets = (EloixClient.IndexServer.IdName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_755261279.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.subReplSets = (EloixClient.IndexServer.IdName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_755261279.instance);
			
			return obj;
		}
		
	}
} // namespace

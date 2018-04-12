//
// Serializer for de.elo.ix.client.FindByType
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_151307616 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_151307616();
		
		public BSerializer_151307616()
			: base(151307616) {}
		
		public BSerializer_151307616(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindByType obj = (FindByType)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.typeDocuments);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.typeStructures);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.typeExtensions, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.typeIDs, false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.typeNames, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindByType obj = (FindByType)(obj1 != null ? obj1 : bin.onObjectCreated(new FindByType()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.typeDocuments = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.typeStructures = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.typeExtensions = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.typeIDs = (int[])bin.readObj(false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.typeNames = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace

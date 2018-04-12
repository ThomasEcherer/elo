//
// Serializer for de.elo.ix.client.ArcPath
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_945258954 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_945258954();
		
		public BSerializer_945258954()
			: base(945258954) {}
		
		public BSerializer_945258954(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ArcPath obj = (ArcPath)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 700000000000028L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.pathAsString);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.path, false, EloixClient.IndexServer.BSerializer_755261279.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ArcPath obj = (ArcPath)(obj1 != null ? obj1 : bin.onObjectCreated(new ArcPath()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 700000000000028L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.pathAsString = bbuf.getString();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.path = (EloixClient.IndexServer.IdName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_755261279.instance);
			
			return obj;
		}
		
	}
} // namespace

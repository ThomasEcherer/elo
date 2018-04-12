//
// Serializer for de.elo.ix.client.CheckInDocMaskLineTemplateOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1586163042 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1586163042();
		
		public BSerializer_1586163042()
			: base(1586163042) {}
		
		public BSerializer_1586163042(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			CheckInDocMaskLineTemplateOptions obj = (CheckInDocMaskLineTemplateOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.keepModifiedLineMembers);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.onlyModifiedTemplateMembers);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.dmltZ, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CheckInDocMaskLineTemplateOptions obj = (CheckInDocMaskLineTemplateOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new CheckInDocMaskLineTemplateOptions()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.keepModifiedLineMembers = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.onlyModifiedTemplateMembers = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dmltZ = (EloixClient.IndexServer.DocMaskLineTemplateZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

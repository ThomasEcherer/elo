//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinDocMaskLineTemplate
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_702278853 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_702278853();
		
		public BSerializer_702278853()
			: base(702278853) {}
		
		public BSerializer_702278853(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkinDocMaskLineTemplate obj = (BRequest_IXServicePortIF_checkinDocMaskLineTemplate)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.dmltValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.dmltZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.lockZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.optionsValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkinDocMaskLineTemplate obj = (BRequest_IXServicePortIF_checkinDocMaskLineTemplate)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkinDocMaskLineTemplate()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dmltValue = (EloixClient.IndexServer.DocMaskLineTemplate)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dmltZValue = (EloixClient.IndexServer.DocMaskLineTemplateZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.optionsValue = (EloixClient.IndexServer.CheckInDocMaskLineTemplateOptions)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

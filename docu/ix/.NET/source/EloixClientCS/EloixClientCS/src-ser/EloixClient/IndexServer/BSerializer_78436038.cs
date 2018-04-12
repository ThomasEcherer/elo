//
// Serializer for de.elo.ix.client.FindByPreviewCtrl
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_78436038 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_78436038();
		
		public BSerializer_78436038()
			: base(78436038) {}
		
		public BSerializer_78436038(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FindByPreviewCtrl obj = (FindByPreviewCtrl)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.previewAvailable);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.previewError);
			if (version >= 700000040000010L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.fileExtensions, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindByPreviewCtrl obj = (FindByPreviewCtrl)(obj1 != null ? obj1 : bin.onObjectCreated(new FindByPreviewCtrl()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.previewAvailable = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.previewError = bbuf.getBoolean();
			if (version >= 700000040000010L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.fileExtensions = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			}
			
			return obj;
		}
		
	}
} // namespace

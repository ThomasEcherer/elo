//
// Serializer for de.elo.ix.client.PreviewImageInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1006046685 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1006046685();
		
		public BSerializer_1006046685()
			: base(1006046685) {}
		
		public BSerializer_1006046685(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			PreviewImageInfo obj = (PreviewImageInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.documentId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.endPage);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objectId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.previewSize);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.processDocument);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.renderAnnotations);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.renderAnnotationsData);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.renderAnnotationsOnly);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.startPage);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			PreviewImageInfo obj = (PreviewImageInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new PreviewImageInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.documentId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.endPage = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objectId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.previewSize = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.processDocument = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.renderAnnotations = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.renderAnnotationsData = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.renderAnnotationsOnly = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.startPage = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace

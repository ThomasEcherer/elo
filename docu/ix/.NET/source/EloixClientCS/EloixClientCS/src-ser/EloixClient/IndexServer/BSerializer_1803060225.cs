//
// Serializer for de.elo.ix.client.OcrInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1803060225 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1803060225();
		
		public BSerializer_1803060225()
			: base(1803060225) {}
		
		public BSerializer_1803060225(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			OcrInfo obj = (OcrInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.busId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.eventId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.messagesLanguage);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.queryLanguages, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.recognizeFile, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			OcrInfo obj = (OcrInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new OcrInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.busId = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.eventId = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.messagesLanguage = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.queryLanguages = (EloixClient.IndexServer.OcrInfoQueryLanguages)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.recognizeFile = (EloixClient.IndexServer.OcrInfoRecognizeFile)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

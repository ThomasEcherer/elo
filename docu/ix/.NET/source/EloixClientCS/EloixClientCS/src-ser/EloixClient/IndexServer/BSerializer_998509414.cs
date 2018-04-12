//
// Serializer for de.elo.ix.client.OcrResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_998509414 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_998509414();
		
		public BSerializer_998509414()
			: base(998509414) {}
		
		public BSerializer_998509414(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			OcrResult obj = (OcrResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.eventId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.exception);
			if (version >= 900000040000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.exceptionID);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.queryLanguages, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.recognizeFile, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			OcrResult obj = (OcrResult)(obj1 != null ? obj1 : bin.onObjectCreated(new OcrResult()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.eventId = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.exception = bbuf.getString();
			if (version >= 900000040000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.exceptionID = bbuf.getInt();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.queryLanguages = (EloixClient.IndexServer.OcrResultQueryLanguages)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.recognizeFile = (EloixClient.IndexServer.OcrResultRecognizeFile)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

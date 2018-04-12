//
// Serializer for de.elo.ix.client.OcrInfoRecognizeFile
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_701419851 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_701419851();
		
		public BSerializer_701419851()
			: base(701419851) {}
		
		public BSerializer_701419851(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			OcrInfoRecognizeFile obj = (OcrInfoRecognizeFile)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.accuracy);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.minCharConfidence);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.outputFormat);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.pageNo);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.rectUnit);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.replaceChar);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.singleColumnMode);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.timeoutSeconds);
			if (version >= 900000030000028L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.pageTimeout);
				if (version >= 1000170069000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.spaces);
					if (version >= 1000170080000003L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.encoding);
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.imageData, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.recognizeLangs, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.recognizeRects, false, EloixClient.IndexServer.BSerializer_610838867.instance);
			if (version >= 900000030000027L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.pageNumbers, false, EloixClient.IndexServer.BSerializer_100361105.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			OcrInfoRecognizeFile obj = (OcrInfoRecognizeFile)(obj1 != null ? obj1 : bin.onObjectCreated(new OcrInfoRecognizeFile()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.accuracy = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.minCharConfidence = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.outputFormat = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.pageNo = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.rectUnit = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.replaceChar = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.singleColumnMode = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeoutSeconds = bbuf.getInt();
			if (version >= 900000030000028L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.pageTimeout = bbuf.getInt();
				if (version >= 1000170069000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.spaces = bbuf.getInt();
					if (version >= 1000170080000003L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.encoding = bbuf.getInt();
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.imageData = (EloixClient.IndexServer.FileData)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.recognizeLangs = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.recognizeRects = (EloixClient.IndexServer.OcrRect[])bin.readObj(false, EloixClient.IndexServer.BSerializer_610838867.instance);
			if (version >= 900000030000027L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.pageNumbers = (int[])bin.readObj(false, EloixClient.IndexServer.BSerializer_100361105.instance);
			}
			
			return obj;
		}
		
	}
} // namespace

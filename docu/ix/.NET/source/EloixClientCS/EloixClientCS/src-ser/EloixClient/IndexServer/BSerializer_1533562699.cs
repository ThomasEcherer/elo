//
// Serializer for de.elo.ix.client.OcrResultRecognizeFile
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1533562699 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1533562699();
		
		public BSerializer_1533562699()
			: base(1533562699) {}
		
		public BSerializer_1533562699(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			OcrResultRecognizeFile obj = (OcrResultRecognizeFile)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.height);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putDouble(obj.skewAngle);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.text);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.width);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.textData, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			OcrResultRecognizeFile obj = (OcrResultRecognizeFile)(obj1 != null ? obj1 : bin.onObjectCreated(new OcrResultRecognizeFile()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.height = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.skewAngle = bbuf.getDouble();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.text = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.width = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.textData = (EloixClient.IndexServer.FileData)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

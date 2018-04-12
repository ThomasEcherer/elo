//
// Serializer for de.elo.ix.client.NoteText
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_669464920 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_669464920();
		
		public BSerializer_669464920()
			: base(669464920) {}
		
		public BSerializer_669464920(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			NoteText obj = (NoteText)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.text);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.fontInfo, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			NoteText obj = (NoteText)(obj1 != null ? obj1 : bin.onObjectCreated(new NoteText()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.text = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fontInfo = (EloixClient.IndexServer.FontInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

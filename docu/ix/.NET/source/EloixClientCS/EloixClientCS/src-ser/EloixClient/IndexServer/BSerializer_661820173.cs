//
// Serializer for de.elo.ix.client.PreviewImageResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_661820173 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_661820173();
		
		public BSerializer_661820173()
			: base(661820173) {}
		
		public BSerializer_661820173(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			PreviewImageResult obj = (PreviewImageResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.dimensionHeight);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.dimensionWidth);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.dpi);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.pages);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.progress);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.progressMax);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.statusMessage);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.urls, false, EloixClient.IndexServer.BSerializer_2123584667.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			PreviewImageResult obj = (PreviewImageResult)(obj1 != null ? obj1 : bin.onObjectCreated(new PreviewImageResult()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dimensionHeight = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dimensionWidth = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dpi = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.pages = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.progress = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.progressMax = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.statusMessage = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.urls = (IList<String>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

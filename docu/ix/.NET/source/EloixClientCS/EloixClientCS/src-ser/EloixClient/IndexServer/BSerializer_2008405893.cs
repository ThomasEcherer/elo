//
// Serializer for de.elo.ix.client.KeywordsDynamicInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2008405893 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2008405893();
		
		public BSerializer_2008405893()
			: base(2008405893) {}
		
		public BSerializer_2008405893(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			KeywordsDynamicInfo obj = (KeywordsDynamicInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 900000014000011L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.mapLineFocus);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.mapScriptName);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.maskLineFocus, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sord, false, null);
			if (version >= 900000014000011L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.mapData, false, EloixClient.IndexServer.BSerializer_1710660846.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			KeywordsDynamicInfo obj = (KeywordsDynamicInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new KeywordsDynamicInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 900000014000011L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.mapLineFocus = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.mapScriptName = bbuf.getString();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maskLineFocus = (EloixClient.IndexServer.DocMaskLine)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sord = (EloixClient.IndexServer.Sord)bin.readObj(false, null);
			if (version >= 900000014000011L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.mapData = (IDictionary<String,String>)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace

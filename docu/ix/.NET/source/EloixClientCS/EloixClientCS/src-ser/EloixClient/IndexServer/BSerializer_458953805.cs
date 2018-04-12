//
// Serializer for de.elo.ix.client.MaskName
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_458953805 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_458953805();
		
		public BSerializer_458953805()
			: base(458953805) {}
		
		public BSerializer_458953805(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			MaskName obj = (MaskName)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.documentMask);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.searchMask);
			if (version >= 700000000000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.folderMask);
				if (version >= 700000000000004L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.guid);
					if (version >= 700000000000042L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.access);
						if (version >= 800000036000001L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putBoolean(obj.barcodeMask);
							if (version >= 900000022000007L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putString(obj.nameTranslationKey);
							}
						}
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MaskName obj = (MaskName)(obj1 != null ? obj1 : bin.onObjectCreated(new MaskName()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.documentMask = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.searchMask = bbuf.getBoolean();
			if (version >= 700000000000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.folderMask = bbuf.getBoolean();
				if (version >= 700000000000004L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.guid = bbuf.getString();
					if (version >= 700000000000042L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.access = bbuf.getInt();
						if (version >= 800000036000001L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.barcodeMask = bbuf.getBoolean();
							if (version >= 900000022000007L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.nameTranslationKey = bbuf.getString();
							}
						}
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace

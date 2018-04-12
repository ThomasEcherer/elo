//
// Serializer for de.elo.ix.client.DocMaskC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_387842089 : EloixClient.IndexServer.BSerializer_1968969939 {
		
		public readonly static new BSerializer instance = new BSerializer_387842089();
		
		public BSerializer_387842089()
			: base(387842089) {}
		
		public BSerializer_387842089(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			DocMaskC obj = (DocMaskC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 700000000000003L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.GUID_BASIC);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.GUID_CONTACT);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.GUID_EMAIL);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.GUID_STRUCTURE_ELEMENT);
				if (version >= 700000000000006L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.lnAcl);
					if (version >= 700000000000024L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.GUID_FOLDER);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.GUID_SEARCH);
						if (version >= 800000020000001L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.GUID_ELOSCRIPTS);
							if (version >= 900000000000011L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putString(obj.GUID_USER_FOLDER);
								if (version >= 1000170059000003L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.GUID_MS_SHAREPOINT_DOCUMENT);
								}
							}
						}
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			DocMaskC obj = (DocMaskC)(obj1 != null ? obj1 : bin.onObjectCreated(new DocMaskC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 700000000000003L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.GUID_BASIC = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.GUID_CONTACT = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.GUID_EMAIL = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.GUID_STRUCTURE_ELEMENT = bbuf.getString();
				if (version >= 700000000000006L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.lnAcl = bbuf.getInt();
					if (version >= 700000000000024L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.GUID_FOLDER = bbuf.getString();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.GUID_SEARCH = bbuf.getString();
						if (version >= 800000020000001L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.GUID_ELOSCRIPTS = bbuf.getString();
							if (version >= 900000000000011L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.GUID_USER_FOLDER = bbuf.getString();
								if (version >= 1000170059000003L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.GUID_MS_SHAREPOINT_DOCUMENT = bbuf.getString();
								}
							}
						}
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace

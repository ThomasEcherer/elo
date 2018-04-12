//
// Serializer for de.elo.ix.client.DocMaskDetails
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_639048562 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_639048562();
		
		public BSerializer_639048562()
			: base(639048562) {}
		
		public BSerializer_639048562(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			DocMaskDetails obj = (DocMaskDetails)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.archivingMode);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.documentMask);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.encryptionSet);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.fulltext);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.searchMask);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.sortOrder);
			if (version >= 600000098000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.createIndexPath);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.createIndexReferencesPaths);
				if (version >= 700000000000000L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.folderMask);
					if (version >= 800000032000007L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.releaseDocument);
						if (version >= 900000018000004L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putBoolean(obj.documentContainer);
							if (version >= 900000030000013L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putBoolean(obj.translateSordName);
							}
						}
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			DocMaskDetails obj = (DocMaskDetails)(obj1 != null ? obj1 : bin.onObjectCreated(new DocMaskDetails()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.archivingMode = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.documentMask = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.encryptionSet = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fulltext = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.searchMask = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sortOrder = bbuf.getInt();
			if (version >= 600000098000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.createIndexPath = bbuf.getBoolean();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.createIndexReferencesPaths = bbuf.getBoolean();
				if (version >= 700000000000000L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.folderMask = bbuf.getBoolean();
					if (version >= 800000032000007L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.releaseDocument = bbuf.getBoolean();
						if (version >= 900000018000004L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.documentContainer = bbuf.getBoolean();
							if (version >= 900000030000013L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.translateSordName = bbuf.getBoolean();
							}
						}
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace

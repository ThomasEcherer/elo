//
// Serializer for de.elo.ix.client.SordDetails
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1713693326 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1713693326();
		
		public BSerializer_1713693326()
			: base(1713693326) {}
		
		public BSerializer_1713693326(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			SordDetails obj = (SordDetails)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.arcReplEnabled);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.archivingMode);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.encryptionSet);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.fulltext);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.fulltextDone);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.replRoot);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.sortOrder);
			if (version >= 700000000000046L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.linked);
				if (version >= 800000026000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.incomplete);
					if (version >= 800000032000007L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.limitedReleaseDocument);
						if (version >= 900000016000008L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putBoolean(obj.linkedPermanent);
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
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SordDetails obj = (SordDetails)(obj1 != null ? obj1 : bin.onObjectCreated(new SordDetails()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.arcReplEnabled = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.archivingMode = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.encryptionSet = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fulltext = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fulltextDone = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.replRoot = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sortOrder = bbuf.getInt();
			if (version >= 700000000000046L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.linked = bbuf.getBoolean();
				if (version >= 800000026000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.incomplete = bbuf.getBoolean();
					if (version >= 800000032000007L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.limitedReleaseDocument = bbuf.getBoolean();
						if (version >= 900000016000008L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.linkedPermanent = bbuf.getBoolean();
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
			}
			
			return obj;
		}
		
	}
} // namespace

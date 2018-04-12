//
// Serializer for de.elo.ix.client.DeleteOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_329713511 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_329713511();
		
		public BSerializer_329713511()
			: base(329713511) {}
		
		public BSerializer_329713511(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			DeleteOptions obj = (DeleteOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.deleteFinally);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.maxIDate);
			if (version >= 600000098000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.deleteExpiredOnly);
				if (version >= 700000000000041L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.maxTStamp);
					if (version >= 700000000000044L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.deleteDocumentVersionsOnly);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.deleteResidueFree);
						if (version >= 800000010000003L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putBoolean(obj.folderMustBeEmpty);
							if (version >= 800000030000002L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putBoolean(obj.deleteCertainDocumentVersionsOnly);
								if (version >= 800000032000009L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putBoolean(obj.deleteExpiredFolders);
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
			DeleteOptions obj = (DeleteOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new DeleteOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.deleteFinally = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maxIDate = bbuf.getString();
			if (version >= 600000098000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.deleteExpiredOnly = bbuf.getBoolean();
				if (version >= 700000000000041L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.maxTStamp = bbuf.getString();
					if (version >= 700000000000044L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.deleteDocumentVersionsOnly = bbuf.getBoolean();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.deleteResidueFree = bbuf.getBoolean();
						if (version >= 800000010000003L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.folderMustBeEmpty = bbuf.getBoolean();
							if (version >= 800000030000002L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.deleteCertainDocumentVersionsOnly = bbuf.getBoolean();
								if (version >= 800000032000009L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.deleteExpiredFolders = bbuf.getBoolean();
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

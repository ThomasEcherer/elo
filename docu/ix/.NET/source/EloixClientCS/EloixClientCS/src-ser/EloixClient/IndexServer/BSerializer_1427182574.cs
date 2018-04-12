//
// Serializer for de.elo.ix.client.CopyOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1427182574 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1427182574();
		
		public BSerializer_1427182574()
			: base(1427182574) {}
		
		public BSerializer_1427182574(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			CopyOptions obj = (CopyOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.copyOnlyBaseElement);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.copyStructuresAndDocuments);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.keepCurrentNotes);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.keepOriginalOwner);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.newParentId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.targetName);
			if (version >= 800000000000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.keepReferences);
				if (version >= 800000032000003L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.copyOnlyWorkversion);
					if (version >= 800000032000005L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.acceptChanges);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.keepOriginalPermissions);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.takeTargetPermissions);
						if (version >= 800000032000008L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putBoolean(obj.copyOnlyWorkAttachment);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putBoolean(obj.inclAttachments);
							if (version >= 900000000000006L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putBoolean(obj.adjustAclDifference);
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putBoolean(obj.moveOnly);
							}
						}
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CopyOptions obj = (CopyOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new CopyOptions()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.copyOnlyBaseElement = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.copyStructuresAndDocuments = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.keepCurrentNotes = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.keepOriginalOwner = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.newParentId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.targetName = bbuf.getString();
			if (version >= 800000000000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.keepReferences = bbuf.getBoolean();
				if (version >= 800000032000003L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.copyOnlyWorkversion = bbuf.getBoolean();
					if (version >= 800000032000005L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.acceptChanges = bbuf.getBoolean();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.keepOriginalPermissions = bbuf.getBoolean();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.takeTargetPermissions = bbuf.getBoolean();
						if (version >= 800000032000008L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.copyOnlyWorkAttachment = bbuf.getBoolean();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.inclAttachments = bbuf.getBoolean();
							if (version >= 900000000000006L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.adjustAclDifference = bbuf.getBoolean();
								// checkpoint byps.gen.cs.PrintContext:449
								obj.moveOnly = bbuf.getBoolean();
							}
						}
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace

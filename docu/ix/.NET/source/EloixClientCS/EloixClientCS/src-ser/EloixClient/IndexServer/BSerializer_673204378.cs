//
// Serializer for de.elo.ix.client.DocInfoDM
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_673204378 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_673204378();
		
		public BSerializer_673204378()
			: base(673204378) {}
		
		public BSerializer_673204378(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			DocInfoDM obj = (DocInfoDM)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.createDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ext);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.fclip);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lastAccessIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lastUpdateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.md5);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.owner);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.pathId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.pathId2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.size);
			if (version >= 600000097000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.encrSet);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.extOrig);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.sizeOrig);
				if (version >= 700000026000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.previewExt);
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.previewSize);
					if (version >= 700000040000006L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.fulltextContentSize);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.fulltextContentTStamp);
						if (version >= 900000000000023L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putLong(obj.previewSizeL);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putLong(obj.sizeL);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putLong(obj.sizeOrigL);
							if (version >= 900000030000023L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putString(obj.relFilePath);
							}
						}
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			DocInfoDM obj = (DocInfoDM)(obj1 != null ? obj1 : bin.onObjectCreated(new DocInfoDM()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.createDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ext = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fclip = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lastAccessIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lastUpdateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.md5 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.owner = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.pathId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.pathId2 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.size = bbuf.getInt();
			if (version >= 600000097000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.encrSet = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.extOrig = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.sizeOrig = bbuf.getInt();
				if (version >= 700000026000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.previewExt = bbuf.getString();
					// checkpoint byps.gen.cs.PrintContext:449
					obj.previewSize = bbuf.getInt();
					if (version >= 700000040000006L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.fulltextContentSize = bbuf.getInt();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.fulltextContentTStamp = bbuf.getString();
						if (version >= 900000000000023L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.previewSizeL = bbuf.getLong();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.sizeL = bbuf.getLong();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.sizeOrigL = bbuf.getLong();
							if (version >= 900000030000023L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.relFilePath = bbuf.getString();
							}
						}
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace

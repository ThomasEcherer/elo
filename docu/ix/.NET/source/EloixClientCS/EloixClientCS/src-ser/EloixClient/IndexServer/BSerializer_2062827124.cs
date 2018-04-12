//
// Serializer for de.elo.ix.client.PublicDownload
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2062827124 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2062827124();
		
		public BSerializer_2062827124()
			: base(2062827124) {}
		
		public BSerializer_2062827124(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			PublicDownload obj = (PublicDownload)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.docId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.expiration);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.remaining);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.timeStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.userId);
			if (version >= 900000000000028L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.objId);
				if (version >= 900000014000002L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.url);
					if (version >= 900000030000030L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.attachmentCode);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.fileName);
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			PublicDownload obj = (PublicDownload)(obj1 != null ? obj1 : bin.onObjectCreated(new PublicDownload()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.expiration = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.remaining = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getInt();
			if (version >= 900000000000028L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.objId = bbuf.getInt();
				if (version >= 900000014000002L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.url = bbuf.getString();
					if (version >= 900000030000030L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.attachmentCode = bbuf.getString();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.fileName = bbuf.getString();
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace

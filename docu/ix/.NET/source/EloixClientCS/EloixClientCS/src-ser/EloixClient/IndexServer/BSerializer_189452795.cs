//
// Serializer for de.elo.ix.client.DocHistory
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_189452795 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_189452795();
		
		public BSerializer_189452795()
			: base(189452795) {}
		
		public BSerializer_189452795(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			DocHistory obj = (DocHistory)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.comment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.createDate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.docId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.docMD5);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flags);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.sigId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.status);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.tStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.user);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.version);
			if (version >= 900000000000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.deleteDate);
				if (version >= 900000016000002L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.nbOfValidSignatures);
					if (version >= 900990009000001L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.TStampSync);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.type);
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			DocHistory obj = (DocHistory)(obj1 != null ? obj1 : bin.onObjectCreated(new DocHistory()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.comment = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.createDate = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docMD5 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flags = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sigId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.status = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.user = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.version = bbuf.getString();
			if (version >= 900000000000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.deleteDate = bbuf.getInt();
				if (version >= 900000016000002L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.nbOfValidSignatures = bbuf.getInt();
					if (version >= 900990009000001L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.TStampSync = bbuf.getString();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.type = bbuf.getInt();
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace

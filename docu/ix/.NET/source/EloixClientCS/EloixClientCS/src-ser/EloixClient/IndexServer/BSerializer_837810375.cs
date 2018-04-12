//
// Serializer for de.elo.ix.client.Relation
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_837810375 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_837810375();
		
		public BSerializer_837810375()
			: base(837810375) {}
		
		public BSerializer_837810375(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			Relation obj = (Relation)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.ordinal);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.parentId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.status);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.tStamp);
			if (version >= 700000000000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.guid);
				if (version >= 900000000000002L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.deleteDateIso);
					if (version >= 900990009000001L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.TStampSync);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.mainRelation);
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Relation obj = (Relation)(obj1 != null ? obj1 : bin.onObjectCreated(new Relation()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ordinal = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.parentId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.status = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tStamp = bbuf.getString();
			if (version >= 700000000000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.guid = bbuf.getString();
				if (version >= 900000000000002L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.deleteDateIso = bbuf.getString();
					if (version >= 900990009000001L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.TStampSync = bbuf.getString();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.mainRelation = bbuf.getBoolean();
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace

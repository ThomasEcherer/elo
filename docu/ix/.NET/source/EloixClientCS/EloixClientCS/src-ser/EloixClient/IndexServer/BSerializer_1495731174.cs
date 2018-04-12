//
// Serializer for de.elo.ix.client.KeywordList
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1495731174 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1495731174();
		
		public BSerializer_1495731174()
			: base(1495731174) {}
		
		public BSerializer_1495731174(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			KeywordList obj = (KeywordList)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.deleted);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.tStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.userId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userName);
			if (version >= 800000010000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lockId);
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.TStampSync);
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.children, false, EloixClient.IndexServer.BSerializer_206201524.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			KeywordList obj = (KeywordList)(obj1 != null ? obj1 : bin.onObjectCreated(new KeywordList()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.deleted = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userName = bbuf.getString();
			if (version >= 800000010000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lockId = bbuf.getInt();
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.TStampSync = bbuf.getString();
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.children = (EloixClient.IndexServer.Keyword[])bin.readObj(false, EloixClient.IndexServer.BSerializer_206201524.instance);
			
			return obj;
		}
		
	}
} // namespace

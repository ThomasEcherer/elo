//
// Serializer for de.elo.ix.client.Thesaurus
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1664944753 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1664944753();
		
		public BSerializer_1664944753()
			: base(1664944753) {}
		
		public BSerializer_1664944753(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			Thesaurus obj = (Thesaurus)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.compare);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.data);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.groupId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.listId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.prio);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Thesaurus obj = (Thesaurus)(obj1 != null ? obj1 : bin.onObjectCreated(new Thesaurus()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.compare = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.data = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.groupId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.listId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.prio = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace

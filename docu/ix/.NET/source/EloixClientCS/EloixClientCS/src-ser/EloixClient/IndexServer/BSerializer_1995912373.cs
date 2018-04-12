//
// Serializer for de.elo.ix.client.NoteTemplate
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1995912373 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1995912373();
		
		public BSerializer_1995912373()
			: base(1995912373) {}
		
		public BSerializer_1995912373(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			NoteTemplate obj = (NoteTemplate)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userId);
			if (version >= 700000000000040L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.acl);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.noteImage, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.noteText, false, null);
			if (version >= 700000000000040L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.aclItems, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			NoteTemplate obj = (NoteTemplate)(obj1 != null ? obj1 : bin.onObjectCreated(new NoteTemplate()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getString();
			if (version >= 700000000000040L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.acl = bbuf.getString();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.noteImage = (EloixClient.IndexServer.NoteImage)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.noteText = (EloixClient.IndexServer.NoteText)bin.readObj(false, null);
			if (version >= 700000000000040L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.aclItems = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			}
			
			return obj;
		}
		
	}
} // namespace

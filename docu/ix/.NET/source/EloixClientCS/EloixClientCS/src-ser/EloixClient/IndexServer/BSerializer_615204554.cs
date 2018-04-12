//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinNotes
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_615204554 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_615204554();
		
		public BSerializer_615204554()
			: base(615204554) {}
		
		public BSerializer_615204554(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkinNotes obj = (BRequest_IXServicePortIF_checkinNotes)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.noteZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.notesValue, false, EloixClient.IndexServer.BSerializer_776454091.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.unlockZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkinNotes obj = (BRequest_IXServicePortIF_checkinNotes)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkinNotes()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.noteZValue = (EloixClient.IndexServer.NoteZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.notesValue = (EloixClient.IndexServer.Note[])bin.readObj(false, EloixClient.IndexServer.BSerializer_776454091.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.unlockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

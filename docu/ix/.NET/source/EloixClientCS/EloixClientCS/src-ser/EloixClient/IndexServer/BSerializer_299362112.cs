//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findFirstNotes
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_299362112 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_299362112();
		
		public BSerializer_299362112()
			: base(299362112) {}
		
		public BSerializer_299362112(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_findFirstNotes obj = (BRequest_IXServicePortIF_findFirstNotes)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.maxValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.findInfoValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.noteZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_findFirstNotes obj = (BRequest_IXServicePortIF_findFirstNotes)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_findFirstNotes()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maxValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.findInfoValue = (EloixClient.IndexServer.FindInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.noteZValue = (EloixClient.IndexServer.NoteZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

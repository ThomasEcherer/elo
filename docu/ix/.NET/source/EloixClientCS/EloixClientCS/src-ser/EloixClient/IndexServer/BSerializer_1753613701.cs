//
// Serializer for de.elo.ix.client.NoteImage
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1753613701 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1753613701();
		
		public BSerializer_1753613701()
			: base(1753613701) {}
		
		public BSerializer_1753613701(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			NoteImage obj = (NoteImage)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.fileName);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.fileData, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			NoteImage obj = (NoteImage)(obj1 != null ? obj1 : bin.onObjectCreated(new NoteImage()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fileName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fileData = (EloixClient.IndexServer.FileData)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

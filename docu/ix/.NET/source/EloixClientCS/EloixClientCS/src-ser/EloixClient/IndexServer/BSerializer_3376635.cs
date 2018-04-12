//
// Serializer for de.elo.ix.client.ProcessMoveDocumentsToStoragePath
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_3376635 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_3376635();
		
		public BSerializer_3376635()
			: base(3376635) {}
		
		public BSerializer_3376635(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ProcessMoveDocumentsToStoragePath obj = (ProcessMoveDocumentsToStoragePath)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.pathId);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ProcessMoveDocumentsToStoragePath obj = (ProcessMoveDocumentsToStoragePath)(obj1 != null ? obj1 : bin.onObjectCreated(new ProcessMoveDocumentsToStoragePath()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.pathId = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.system.ArchivReport
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class BSerializer_1383534582 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1383534582();
		
		public BSerializer_1383534582()
			: base(1383534582) {}
		
		public BSerializer_1383534582(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ArchivReport obj = (ArchivReport)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.archivGUID);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.elodmdocs, false, EloixClient.IndexServer.BSerializer_164573046.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.objecte, false, EloixClient.IndexServer.BSerializer_164573046.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ArchivReport obj = (ArchivReport)(obj1 != null ? obj1 : bin.onObjectCreated(new ArchivReport()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.archivGUID = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.elodmdocs = (IList<EloixClient.Indexserver.system.ArchivValue>)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objecte = (IList<EloixClient.Indexserver.system.ArchivValue>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

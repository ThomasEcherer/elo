//
// Serializer for de.elo.ix.client.BackupProfile
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1230334315 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1230334315();
		
		public BSerializer_1230334315()
			: base(1230334315) {}
		
		public BSerializer_1230334315(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			BackupProfile obj = (BackupProfile)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nbOfDocsPerLoop);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.pathId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.retention);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.slot);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.sqlDocSelect);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.writeKeywording);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BackupProfile obj = (BackupProfile)(obj1 != null ? obj1 : bin.onObjectCreated(new BackupProfile()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nbOfDocsPerLoop = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.pathId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.retention = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.slot = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sqlDocSelect = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.writeKeywording = bbuf.getBoolean();
			
			return obj;
		}
		
	}
} // namespace

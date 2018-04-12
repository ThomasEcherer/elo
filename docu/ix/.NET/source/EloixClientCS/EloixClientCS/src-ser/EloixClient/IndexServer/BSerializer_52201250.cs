//
// Serializer for de.elo.ix.client.BackupPurgeStatus
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_52201250 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_52201250();
		
		public BSerializer_52201250()
			: base(52201250) {}
		
		public BSerializer_52201250(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			BackupPurgeStatus obj = (BackupPurgeStatus)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.backupStatus, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.purgeStatus, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BackupPurgeStatus obj = (BackupPurgeStatus)(obj1 != null ? obj1 : bin.onObjectCreated(new BackupPurgeStatus()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.backupStatus = (EloixClient.IndexServer.BackupStatus)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.purgeStatus = (EloixClient.IndexServer.PurgeStatus)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

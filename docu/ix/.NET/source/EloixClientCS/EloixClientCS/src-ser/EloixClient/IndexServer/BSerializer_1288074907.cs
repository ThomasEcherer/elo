//
// Serializer for de.elo.ix.client.BackupStatus
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1288074907 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1288074907();
		
		public BSerializer_1288074907()
			: base(1288074907) {}
		
		public BSerializer_1288074907(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			BackupStatus obj = (BackupStatus)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.errorMessage);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.isRunning);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.numberOfDocsCopied);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.secondsUntilNextCheck);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BackupStatus obj = (BackupStatus)(obj1 != null ? obj1 : bin.onObjectCreated(new BackupStatus()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.errorMessage = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.isRunning = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.numberOfDocsCopied = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.secondsUntilNextCheck = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace

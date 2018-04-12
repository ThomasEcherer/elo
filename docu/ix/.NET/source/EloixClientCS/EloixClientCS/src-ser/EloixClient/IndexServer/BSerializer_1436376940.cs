//
// Serializer for de.elo.ix.client.JobState
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1436376940 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1436376940();
		
		public BSerializer_1436376940()
			: base(1436376940) {}
		
		public BSerializer_1436376940(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			JobState obj = (JobState)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.countErrors);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.countEstimatedMax);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.countProcessed);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.expires);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.jobEnd);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.jobGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.jobName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.jobRunning);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.jobStart);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lastGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lastID);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.strMsg);
			if (version >= 800000036000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.doCancelJob);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.procInfo, false, null);
			if (version >= 700000000000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.countResult, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			JobState obj = (JobState)(obj1 != null ? obj1 : bin.onObjectCreated(new JobState()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.countErrors = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.countEstimatedMax = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.countProcessed = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.expires = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.jobEnd = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.jobGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.jobName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.jobRunning = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.jobStart = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lastGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lastID = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.strMsg = bbuf.getString();
			if (version >= 800000036000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.doCancelJob = bbuf.getBoolean();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.procInfo = (EloixClient.IndexServer.ProcessInfo)bin.readObj(false, null);
			if (version >= 700000000000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.countResult = (EloixClient.IndexServer.CountResult)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace

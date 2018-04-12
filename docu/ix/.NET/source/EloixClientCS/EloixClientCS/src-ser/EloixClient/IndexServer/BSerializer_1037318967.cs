//
// Serializer for de.elo.ix.client.ProcessInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1037318967 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1037318967();
		
		public BSerializer_1037318967()
			: base(1037318967) {}
		
		public BSerializer_1037318967(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ProcessInfo obj = (ProcessInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.delStatus);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.desc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.errorMode);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.ignoreDocuments);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.ignoreStructures);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.procMsgMax);
			if (version >= 700000000000038L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.forceOperation);
				if (version >= 800000000000004L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.inclReferences);
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.lockZ, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.procAcl, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.procMsgs, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.procReplSet, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.procScript, false, null);
			if (version >= 600000099000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.procFulltext, false, null);
				if (version >= 700000000000000L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.procCountElem, false, null);
					if (version >= 700000000000045L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bout.writeObj(obj.procMoveDocumentsToStoragePath, false, null);
						if (version >= 700000020000001L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bout.writeObj(obj.procCopyElements, false, null);
							if (version >= 900000000000031L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bout.writeObj(obj.procReleaseLock, false, null);
								if (version >= 1000170040000001L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bout.writeObj(obj.procInheritKeywording, false, null);
								}
							}
						}
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ProcessInfo obj = (ProcessInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new ProcessInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.delStatus = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.desc = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.errorMode = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ignoreDocuments = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ignoreStructures = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.procMsgMax = bbuf.getInt();
			if (version >= 700000000000038L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.forceOperation = bbuf.getBoolean();
				if (version >= 800000000000004L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.inclReferences = bbuf.getBoolean();
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockZ = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.procAcl = (EloixClient.IndexServer.ProcessAcl)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.procMsgs = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.procReplSet = (EloixClient.IndexServer.ProcessReplSet)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.procScript = (EloixClient.IndexServer.ProcessScript)bin.readObj(false, null);
			if (version >= 600000099000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.procFulltext = (EloixClient.IndexServer.ProcessFulltext)bin.readObj(false, null);
				if (version >= 700000000000000L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.procCountElem = (EloixClient.IndexServer.ProcessCountElements)bin.readObj(false, null);
					if (version >= 700000000000045L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.procMoveDocumentsToStoragePath = (EloixClient.IndexServer.ProcessMoveDocumentsToStoragePath)bin.readObj(false, null);
						if (version >= 700000020000001L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.procCopyElements = (EloixClient.IndexServer.ProcessCopyElements)bin.readObj(false, null);
							if (version >= 900000000000031L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.procReleaseLock = (EloixClient.IndexServer.ProcessReleaseLock)bin.readObj(false, null);
								if (version >= 1000170040000001L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.procInheritKeywording = (EloixClient.IndexServer.ProcessInheritKeywording)bin.readObj(false, null);
								}
							}
						}
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace

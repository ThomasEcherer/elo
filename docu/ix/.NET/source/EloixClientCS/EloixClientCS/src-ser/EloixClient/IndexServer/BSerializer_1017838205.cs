//
// Serializer for de.elo.ix.client.FindInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1017838205 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1017838205();
		
		public BSerializer_1017838205()
			: base(1017838205) {}
		
		public BSerializer_1017838205(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindInfo obj = (FindInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.findByFulltext, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.findByIndex, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.findByNotes, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.findBySordHist, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.findByType, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.findByVersion, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.findChildren, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.findOptions, false, null);
			if (version >= 600000092000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.findDirect, false, null);
				if (version >= 700000000000011L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.findByAcl, false, null);
					if (version >= 700000026000001L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bout.writeObj(obj.findByPreviewCtrl, false, null);
						if (version >= 700000040000006L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bout.writeObj(obj.findByFulltextCtrl, false, null);
							if (version >= 700000040000020L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bout.writeObj(obj.findByRegisteredFunction, false, null);
								if (version >= 900000000000028L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bout.writeObj(obj.findLinks, false, null);
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
			FindInfo obj = (FindInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FindInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.findByFulltext = (EloixClient.IndexServer.FindByFulltext)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.findByIndex = (EloixClient.IndexServer.FindByIndex)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.findByNotes = (EloixClient.IndexServer.FindByNotes)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.findBySordHist = (EloixClient.IndexServer.FindBySordHist)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.findByType = (EloixClient.IndexServer.FindByType)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.findByVersion = (EloixClient.IndexServer.FindByVersion)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.findChildren = (EloixClient.IndexServer.FindChildren)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.findOptions = (EloixClient.IndexServer.FindOptions)bin.readObj(false, null);
			if (version >= 600000092000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.findDirect = (EloixClient.IndexServer.FindDirect)bin.readObj(false, null);
				if (version >= 700000000000011L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.findByAcl = (EloixClient.IndexServer.FindByAcl)bin.readObj(false, null);
					if (version >= 700000026000001L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.findByPreviewCtrl = (EloixClient.IndexServer.FindByPreviewCtrl)bin.readObj(false, null);
						if (version >= 700000040000006L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.findByFulltextCtrl = (EloixClient.IndexServer.FindByFulltextCtrl)bin.readObj(false, null);
							if (version >= 700000040000020L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.findByRegisteredFunction = (EloixClient.IndexServer.FindByRegisteredFunction)bin.readObj(false, null);
								if (version >= 900000000000028L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.findLinks = (EloixClient.IndexServer.FindLinks)bin.readObj(false, null);
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

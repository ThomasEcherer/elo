//
// Serializer for de.elo.ix.client.ExportExtOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_291967 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_291967();
		
		public BSerializer_291967()
			: base(291967) {}
		
		public BSerializer_291967(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ExportExtOptions obj = (ExportExtOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.dateEndIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.dateStartIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.dateType);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.exportAttachments);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.exportDocs);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.exportDocsVersions);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.exportEncrytedDocs);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.exportKeywords);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.exportReminders);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.replaceRefWithOriginal);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.searchId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.srcType);
			if (version >= 900000016000014L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.exportStructure);
				if (version >= 1000000020000009L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.ignoreEmptyFolders);
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.masksList, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.srcList, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ExportExtOptions obj = (ExportExtOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new ExportExtOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dateEndIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dateStartIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dateType = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.exportAttachments = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.exportDocs = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.exportDocsVersions = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.exportEncrytedDocs = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.exportKeywords = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.exportReminders = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.replaceRefWithOriginal = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.searchId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.srcType = bbuf.getInt();
			if (version >= 900000016000014L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.exportStructure = bbuf.getBoolean();
				if (version >= 1000000020000009L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.ignoreEmptyFolders = bbuf.getBoolean();
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.masksList = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.srcList = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace

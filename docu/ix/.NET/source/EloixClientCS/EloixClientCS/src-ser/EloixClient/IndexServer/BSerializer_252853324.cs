//
// Serializer for de.elo.ix.client.PublicDownloadOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_252853324 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_252853324();
		
		public BSerializer_252853324()
			: base(252853324) {}
		
		public BSerializer_252853324(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			PublicDownloadOptions obj = (PublicDownloadOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 900000012000003L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.expiration);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.remaining);
				if (version >= 900000012000004L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.docId);
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.objId);
					if (version >= 900000014000008L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.contentDispositionAttachment);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.fileNameFromSordName);
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.downloadIds, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			PublicDownloadOptions obj = (PublicDownloadOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new PublicDownloadOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 900000012000003L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.expiration = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.remaining = bbuf.getInt();
				if (version >= 900000012000004L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.docId = bbuf.getString();
					// checkpoint byps.gen.cs.PrintContext:449
					obj.objId = bbuf.getString();
					if (version >= 900000014000008L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.contentDispositionAttachment = bbuf.getBoolean();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.fileNameFromSordName = bbuf.getBoolean();
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.downloadIds = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace

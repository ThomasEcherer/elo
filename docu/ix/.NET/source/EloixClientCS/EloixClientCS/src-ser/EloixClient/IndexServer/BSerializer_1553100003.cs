//
// Serializer for de.elo.ix.client.SordC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1553100003 : EloixClient.IndexServer.BSerializer_1521332903 {
		
		public readonly static new BSerializer instance = new BSerializer_1553100003();
		
		public BSerializer_1553100003()
			: base(1553100003) {}
		
		public BSerializer_1553100003(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			SordC obj = (SordC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.GUID_ADMINISTRATION_BASE);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.GUID_REPLICATION_BASE);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.GUID_SCRIPTING_BASE);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnDesc);
			if (version >= 700000000000029L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.GUID_IX_SCRIPTING_BASE);
				if (version >= 700000022000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.GUID_COLD_BACKGROUND_IMAGES);
					if (version >= 700000022000003L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.GUID_WIN_SCRIPTING_BASE);
						if (version >= 700000040000012L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.GUID_WFNODE_ICON_BEGINNODE);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.GUID_WFNODE_ICON_COLLECTNODE);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.GUID_WFNODE_ICON_CYCLE_BEGIN);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.GUID_WFNODE_ICON_CYCLE_END);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.GUID_WFNODE_ICON_IFNODE);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.GUID_WFNODE_ICON_PERSONNODE);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.GUID_WFNODE_ICON_SET_SERVER_ID);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.GUID_WFNODE_ICON_SPLITNODE);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.GUID_WFNODE_ICON_TERMINATE);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.GUID_WORKFLOW_ICONS_BASE);
							if (version >= 900000000000011L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putString(obj.GUID_USERS_FOLDER);
								if (version >= 900000000000032L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.ELOINDEX_USER_FOLDER_DATA);
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.ELOINDEX_USER_FOLDER_DATA_PROFILE);
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.ELOINDEX_USER_FOLDER_INBOX);
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.ELOINDEX_USER_FOLDER_PRIVATE);
									if (version >= 900000016000019L) {
										// checkpoint byps.gen.cs.PrintContext:494
										bbuf.putString(obj.GUID_TEXTREADER_FOLDER);
										// checkpoint byps.gen.cs.PrintContext:494
										bbuf.putString(obj.GUID_TRNOTCONV_FOLDER);
										if (version >= 900990009000008L) {
											// checkpoint byps.gen.cs.PrintContext:494
											bbuf.putString(obj.GUID_APPS_FOLDER);
										}
									}
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
			SordC obj = (SordC)(obj1 != null ? obj1 : bin.onObjectCreated(new SordC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.GUID_ADMINISTRATION_BASE = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.GUID_REPLICATION_BASE = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.GUID_SCRIPTING_BASE = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnDesc = bbuf.getInt();
			if (version >= 700000000000029L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.GUID_IX_SCRIPTING_BASE = bbuf.getString();
				if (version >= 700000022000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.GUID_COLD_BACKGROUND_IMAGES = bbuf.getString();
					if (version >= 700000022000003L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.GUID_WIN_SCRIPTING_BASE = bbuf.getString();
						if (version >= 700000040000012L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.GUID_WFNODE_ICON_BEGINNODE = bbuf.getString();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.GUID_WFNODE_ICON_COLLECTNODE = bbuf.getString();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.GUID_WFNODE_ICON_CYCLE_BEGIN = bbuf.getString();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.GUID_WFNODE_ICON_CYCLE_END = bbuf.getString();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.GUID_WFNODE_ICON_IFNODE = bbuf.getString();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.GUID_WFNODE_ICON_PERSONNODE = bbuf.getString();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.GUID_WFNODE_ICON_SET_SERVER_ID = bbuf.getString();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.GUID_WFNODE_ICON_SPLITNODE = bbuf.getString();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.GUID_WFNODE_ICON_TERMINATE = bbuf.getString();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.GUID_WORKFLOW_ICONS_BASE = bbuf.getString();
							if (version >= 900000000000011L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.GUID_USERS_FOLDER = bbuf.getString();
								if (version >= 900000000000032L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.ELOINDEX_USER_FOLDER_DATA = bbuf.getString();
									// checkpoint byps.gen.cs.PrintContext:449
									obj.ELOINDEX_USER_FOLDER_DATA_PROFILE = bbuf.getString();
									// checkpoint byps.gen.cs.PrintContext:449
									obj.ELOINDEX_USER_FOLDER_INBOX = bbuf.getString();
									// checkpoint byps.gen.cs.PrintContext:449
									obj.ELOINDEX_USER_FOLDER_PRIVATE = bbuf.getString();
									if (version >= 900000016000019L) {
										// checkpoint byps.gen.cs.PrintContext:449
										obj.GUID_TEXTREADER_FOLDER = bbuf.getString();
										// checkpoint byps.gen.cs.PrintContext:449
										obj.GUID_TRNOTCONV_FOLDER = bbuf.getString();
										if (version >= 900990009000008L) {
											// checkpoint byps.gen.cs.PrintContext:449
											obj.GUID_APPS_FOLDER = bbuf.getString();
										}
									}
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

//
// Serializer for de.elo.ix.client.FindDirectC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_627433249 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_627433249();
		
		public BSerializer_627433249()
			: base(627433249) {}
		
		public BSerializer_627433249(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FindDirectC obj = (FindDirectC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_DELDATE);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_DELDATE_MONTH);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_DELDATE_YEAR);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_DESC);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_EXT);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_GUID);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_ID);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_IDATE);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_IDATE_MONTH);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_IDATE_YEAR);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_MASK_ID);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_MASK_NAME);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_NAME);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_OBJ_KEY);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_OBJ_KEY_TOKENIZED);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_OWNER);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_OWNER_ID);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_TSTAMP);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_TYPE);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_XDATE);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_XDATE_MONTH);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.FIELD_XDATE_YEAR);
			if (version >= 1000000020000018L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.FIELD_DOC_SIZE);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.FIELD_OBJ_KEY_DATE);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.FIELD_OBJ_KEY_NUMERIC);
				if (version >= 1000000020000019L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.FIELD_VERSION_COMMENT);
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.FIELD_VERSION_NUMBER);
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.FIELD_VERSION_OWNER);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindDirectC obj = (FindDirectC)(obj1 != null ? obj1 : bin.onObjectCreated(new FindDirectC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_DELDATE = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_DELDATE_MONTH = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_DELDATE_YEAR = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_DESC = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_EXT = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_GUID = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_ID = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_IDATE = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_IDATE_MONTH = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_IDATE_YEAR = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_MASK_ID = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_MASK_NAME = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_NAME = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_OBJ_KEY = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_OBJ_KEY_TOKENIZED = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_OWNER = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_OWNER_ID = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_TSTAMP = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_TYPE = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_XDATE = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_XDATE_MONTH = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.FIELD_XDATE_YEAR = bbuf.getString();
			if (version >= 1000000020000018L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.FIELD_DOC_SIZE = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.FIELD_OBJ_KEY_DATE = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.FIELD_OBJ_KEY_NUMERIC = bbuf.getString();
				if (version >= 1000000020000019L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.FIELD_VERSION_COMMENT = bbuf.getString();
					// checkpoint byps.gen.cs.PrintContext:449
					obj.FIELD_VERSION_NUMBER = bbuf.getString();
					// checkpoint byps.gen.cs.PrintContext:449
					obj.FIELD_VERSION_OWNER = bbuf.getString();
				}
			}
			
			return obj;
		}
		
	}
} // namespace

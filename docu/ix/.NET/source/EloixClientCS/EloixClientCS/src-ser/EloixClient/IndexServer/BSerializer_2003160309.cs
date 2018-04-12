//
// Serializer for de.elo.ix.client.FindInfoAsInternalSQL
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2003160309 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2003160309();
		
		public BSerializer_2003160309()
			: base(2003160309) {}
		
		public BSerializer_2003160309(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FindInfoAsInternalSQL obj = (FindInfoAsInternalSQL)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.fromTables);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.groupByClause);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.orderByClause);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.whereClause);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindInfoAsInternalSQL obj = (FindInfoAsInternalSQL)(obj1 != null ? obj1 : bin.onObjectCreated(new FindInfoAsInternalSQL()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fromTables = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.groupByClause = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.orderByClause = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.whereClause = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

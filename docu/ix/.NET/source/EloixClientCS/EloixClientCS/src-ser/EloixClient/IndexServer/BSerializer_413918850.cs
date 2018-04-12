//
// Serializer for de.elo.ix.client.OrgUnitInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_413918850 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_413918850();
		
		public BSerializer_413918850()
			: base(413918850) {}
		
		public BSerializer_413918850(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			OrgUnitInfo obj = (OrgUnitInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.desc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.tStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ouProps, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			OrgUnitInfo obj = (OrgUnitInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new OrgUnitInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.desc = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ouProps = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace

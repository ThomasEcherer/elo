//
// Serializer for de.elo.ix.client.ReportInfoUserModified
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1649121955 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1649121955();
		
		public BSerializer_1649121955()
			: base(1649121955) {}
		
		public BSerializer_1649121955(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ReportInfoUserModified obj = (ReportInfoUserModified)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.newProps, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.oldProps, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReportInfoUserModified obj = (ReportInfoUserModified)(obj1 != null ? obj1 : bin.onObjectCreated(new ReportInfoUserModified()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.newProps = (EloixClient.IndexServer.ReportInfoUserProps)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.oldProps = (EloixClient.IndexServer.ReportInfoUserProps)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

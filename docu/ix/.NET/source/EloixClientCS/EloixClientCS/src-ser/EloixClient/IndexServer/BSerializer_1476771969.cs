//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_combineAcl
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1476771969 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1476771969();
		
		public BSerializer_1476771969()
			: base(1476771969) {}
		
		public BSerializer_1476771969(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_combineAcl obj = (BRequest_IXServicePortIF_combineAcl)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.lhsValue, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.optionsValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.rhsValue, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_combineAcl obj = (BRequest_IXServicePortIF_combineAcl)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_combineAcl()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lhsValue = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.optionsValue = (EloixClient.IndexServer.CombineAclOptions)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.rhsValue = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.ReportInfoUserProps
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2088129978 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2088129978();
		
		public BSerializer_2088129978()
			: base(2088129978) {}
		
		public BSerializer_2088129978(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ReportInfoUserProps obj = (ReportInfoUserProps)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.idsToNames, false, EloixClient.IndexServer.BSerializer_498630295.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.subsInfos, false, EloixClient.IndexServer.BSerializer_1546602844.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.userInfo, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.userInfoEff, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReportInfoUserProps obj = (ReportInfoUserProps)(obj1 != null ? obj1 : bin.onObjectCreated(new ReportInfoUserProps()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.idsToNames = (IDictionary<int,String>)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.subsInfos = (IList<EloixClient.IndexServer.SubsInfo>)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userInfo = (EloixClient.IndexServer.UserInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userInfoEff = (EloixClient.IndexServer.UserInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

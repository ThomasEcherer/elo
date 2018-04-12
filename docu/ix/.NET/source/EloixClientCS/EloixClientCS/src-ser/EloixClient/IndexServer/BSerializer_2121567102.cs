//
// Serializer for de.elo.ix.client.SordHist
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2121567102 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2121567102();
		
		public BSerializer_2121567102()
			: base(2121567102) {}
		
		public BSerializer_2121567102(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			SordHist obj = (SordHist)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.histGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.histSource);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.timeStampLocal);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.timeStampUTC);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.userNo);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.workStation);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.histKeys, false, EloixClient.IndexServer.BSerializer_645430982.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SordHist obj = (SordHist)(obj1 != null ? obj1 : bin.onObjectCreated(new SordHist()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.histGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.histSource = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeStampLocal = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeStampUTC = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userNo = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workStation = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.histKeys = (EloixClient.IndexServer.SordHistKey[])bin.readObj(false, EloixClient.IndexServer.BSerializer_645430982.instance);
			
			return obj;
		}
		
	}
} // namespace

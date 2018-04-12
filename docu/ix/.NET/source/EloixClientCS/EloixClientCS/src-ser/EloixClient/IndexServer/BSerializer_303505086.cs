//
// Serializer for de.elo.ix.client.MapHist
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_303505086 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_303505086();
		
		public BSerializer_303505086()
			: base(303505086) {}
		
		public BSerializer_303505086(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			MapHist obj = (MapHist)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.histGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.histSource);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.mapGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.mapId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.timeStampLocal);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.timeStampUTC);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.userId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.workStation);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.histItems, false, EloixClient.IndexServer.BSerializer_240257308.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MapHist obj = (MapHist)(obj1 != null ? obj1 : bin.onObjectCreated(new MapHist()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.histGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.histSource = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.mapGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.mapId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeStampLocal = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeStampUTC = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workStation = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.histItems = (EloixClient.IndexServer.MapHistItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_240257308.instance);
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.Any
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1191976387 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1191976387();
		
		public BSerializer_1191976387()
			: base(1191976387) {}
		
		public BSerializer_1191976387(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			Any obj = (Any)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.booleanValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putDouble(obj.doubleValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.intValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.longValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.stringValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.type);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.anyArray, false, EloixClient.IndexServer.BSerializer_1233910153.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.byteArray, false, EloixClient.IndexServer.BSerializer_1374008726.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.objectValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Any obj = (Any)(obj1 != null ? obj1 : bin.onObjectCreated(new Any()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.booleanValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.doubleValue = bbuf.getDouble();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.intValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.longValue = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.stringValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.anyArray = (EloixClient.IndexServer.Any[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1233910153.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.byteArray = (byte[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1374008726.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objectValue = (EloixClient.IndexServer.ValueClass)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

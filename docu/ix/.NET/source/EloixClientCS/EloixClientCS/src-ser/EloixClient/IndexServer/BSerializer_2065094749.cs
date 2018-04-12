//
// Serializer for de.elo.ix.client.SordType
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2065094749 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2065094749();
		
		public BSerializer_2065094749()
			: base(2065094749) {}
		
		public BSerializer_2065094749(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			SordType obj = (SordType)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.disabledIcon, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.extensions, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.icon, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.workflowIcon, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SordType obj = (SordType)(obj1 != null ? obj1 : bin.onObjectCreated(new SordType()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.disabledIcon = (EloixClient.IndexServer.FileData)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.extensions = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.icon = (EloixClient.IndexServer.FileData)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workflowIcon = (EloixClient.IndexServer.FileData)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

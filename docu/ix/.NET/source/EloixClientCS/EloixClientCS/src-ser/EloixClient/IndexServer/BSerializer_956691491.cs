//
// Serializer for de.elo.ix.client.IXServerEventsContext
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_956691491 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_956691491();
		
		public BSerializer_956691491()
			: base(956691491) {}
		
		public BSerializer_956691491(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			IXServerEventsContext obj = (IXServerEventsContext)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.url);
			if (version >= 900000016000005L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.clientComputer);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ci, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.user, false, null);
			if (version >= 900000016000005L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.sessionOptions, false, EloixClient.IndexServer.BSerializer_1710660846.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			IXServerEventsContext obj = (IXServerEventsContext)(obj1 != null ? obj1 : bin.onObjectCreated(new IXServerEventsContext()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.url = bbuf.getString();
			if (version >= 900000016000005L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.clientComputer = bbuf.getString();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ci = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.user = (EloixClient.IndexServer.UserInfo)bin.readObj(false, null);
			if (version >= 900000016000005L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.sessionOptions = (IDictionary<String,String>)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace

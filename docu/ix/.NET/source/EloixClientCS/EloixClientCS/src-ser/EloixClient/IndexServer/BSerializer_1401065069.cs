//
// Serializer for de.elo.ix.client.UserProfile
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1401065069 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1401065069();
		
		public BSerializer_1401065069()
			: base(1401065069) {}
		
		public BSerializer_1401065069(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			UserProfile obj = (UserProfile)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userId);
			if (version >= 700000040000014L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.excludeDefaultValues);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.excludeGroupValues);
				if (version >= 800000010000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.groupId);
					if (version >= 1000170040000004L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.includeAllGroupAndDefaultOptions);
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.options, false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			if (version >= 800000010000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.defaultOptions, false, EloixClient.IndexServer.BSerializer_1826370901.instance);
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.groupOptions, false, EloixClient.IndexServer.BSerializer_1826370901.instance);
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.userOptions, false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			UserProfile obj = (UserProfile)(obj1 != null ? obj1 : bin.onObjectCreated(new UserProfile()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getString();
			if (version >= 700000040000014L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.excludeDefaultValues = bbuf.getBoolean();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.excludeGroupValues = bbuf.getBoolean();
				if (version >= 800000010000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.groupId = bbuf.getInt();
					if (version >= 1000170040000004L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.includeAllGroupAndDefaultOptions = bbuf.getBoolean();
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.options = (EloixClient.IndexServer.KeyValue[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			if (version >= 800000010000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.defaultOptions = (EloixClient.IndexServer.KeyValue[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1826370901.instance);
				// checkpoint byps.gen.cs.PrintContext:449
				obj.groupOptions = (EloixClient.IndexServer.KeyValue[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1826370901.instance);
				// checkpoint byps.gen.cs.PrintContext:449
				obj.userOptions = (EloixClient.IndexServer.KeyValue[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			}
			
			return obj;
		}
		
	}
} // namespace

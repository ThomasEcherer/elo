﻿//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutConfigFiles
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_846870983 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_846870983();
		
		public BSerializer_846870983()
			: base(846870983) {}
		
		public BSerializer_846870983(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkoutConfigFiles obj = (BRequest_IXServicePortIF_checkoutConfigFiles)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.configFileZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.lockZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.namesValue, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkoutConfigFiles obj = (BRequest_IXServicePortIF_checkoutConfigFiles)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkoutConfigFiles()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.configFileZValue = (EloixClient.IndexServer.ConfigFileZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.namesValue = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace

//
// Serializer for de.elo.ix.client.ServerInfoDMC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_287365821 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_287365821();
		
		public BSerializer_287365821()
			: base(287365821) {}
		
		public BSerializer_287365821(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ServerInfoDMC obj = (ServerInfoDMC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ServerInfoDMC obj = (ServerInfoDMC)(obj1 != null ? obj1 : bin.onObjectCreated(new ServerInfoDMC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

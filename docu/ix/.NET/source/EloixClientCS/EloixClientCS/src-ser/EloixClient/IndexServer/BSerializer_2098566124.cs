//
// Serializer for de.elo.ix.client.ConfigFileC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2098566124 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2098566124();
		
		public BSerializer_2098566124()
			: base(2098566124) {}
		
		public BSerializer_2098566124(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ConfigFileC obj = (ConfigFileC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ConfigFileC obj = (ConfigFileC)(obj1 != null ? obj1 : bin.onObjectCreated(new ConfigFileC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

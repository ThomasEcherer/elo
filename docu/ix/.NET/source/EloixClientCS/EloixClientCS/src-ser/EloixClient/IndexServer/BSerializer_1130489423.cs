//
// Serializer for de.elo.ix.client.ProcessInheritKeywording
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1130489423 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1130489423();
		
		public BSerializer_1130489423()
			: base(1130489423) {}
		
		public BSerializer_1130489423(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ProcessInheritKeywording obj = (ProcessInheritKeywording)(obj1 != null ? obj1 : bin.onObjectCreated(new ProcessInheritKeywording()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

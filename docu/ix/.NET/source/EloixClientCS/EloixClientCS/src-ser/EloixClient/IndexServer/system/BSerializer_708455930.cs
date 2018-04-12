//
// Serializer for de.elo.ix.client.system.BStub_SystemInformation
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class BSerializer_708455930 : BSerializer_16 {
		
		public readonly static BSerializer instance = new BSerializer_708455930();
		
		public BSerializer_708455930()
			: base(708455930) {}
		
		protected override BRemote internalCreate(BTransport transport) {
			return new BStub_SystemInformation(transport);
		}
		
	}
} // namespace

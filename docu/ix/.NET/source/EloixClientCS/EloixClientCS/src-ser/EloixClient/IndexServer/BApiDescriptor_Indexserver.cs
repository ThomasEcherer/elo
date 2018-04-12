using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BApiDescriptor_Indexserver { 
	
		/**
		 * API serialisation version: 10.17.80.3
		 */
		public const long VERSION = 1000170080000003L;
		
		public readonly static BApiDescriptor instance = new BApiDescriptor(
			"Indexserver",
			"de.elo.ix.client",
			VERSION,
			false) // uniqueObjects
			.addRegistry(new BRegistry_Indexserver());
		
		
	}
}

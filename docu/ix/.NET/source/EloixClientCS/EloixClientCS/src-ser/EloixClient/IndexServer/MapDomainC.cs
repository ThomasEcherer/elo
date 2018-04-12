//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	/// <summary>
	/// This class defines constants for the predefined map tables.
	/// </summary>
	public class MapDomainC : EloixClient.IndexServer.MapDomainDataC, BSerializable
	{
	
		#region Constructors
		
		public MapDomainC() {
		}		
		
		public MapDomainC(MapDomainC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		public const String DOMAIN_SORD = "objekte";

		public const String DOMAIN_WORKFLOW_ACTIVE = "wfactive";

		public const String DOMAIN_WORKFLOW_FINISHED = "wffinished";

		public const String DOMAIN_IX_OPTIONS = "eloixopt";

		public const String DOMAIN_DM_OPTIONS = "elodmopt";

		public const String DOMAIN_FT_OPTIONS = "eloftopt";

		#endregion
		
		
		public static readonly new long serialVersionUID = 47433043L;		
	} // end class
}  // end namespace

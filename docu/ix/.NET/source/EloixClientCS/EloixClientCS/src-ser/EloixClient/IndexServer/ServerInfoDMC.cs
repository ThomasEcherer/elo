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
	/// Constants used by the members of the class ServerInfoDM.
	/// </summary>
	public class ServerInfoDMC : BSerializable
	{
	
		#region Constructors
		
		public ServerInfoDMC() {
		}		
		
		public ServerInfoDMC(ServerInfoDMC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// This bitmask selects the lower two bits of the ServerInfoDM.storeMode.
		/// </summary>
		/// <remarks>
		/// This bits are equal to one of the STOREMODE_BASEPATH_* constants.
		/// </remarks>
		public const int STOREMODE_BASEPATH_MASK = 3;

		/// <summary>
		/// Fill up base paths subsequently.
		/// </summary>
		public const int STOREMODE_BASEPATH_FILL_UP = 1;

		/// <summary>
		/// Fill base paths by round robin algorithm.
		/// </summary>
		public const int STOREMODE_BASEPATH_ROUNDROBIN = 0;

		#endregion
		
		
		public static readonly long serialVersionUID = 287365821L;		
	} // end class
}  // end namespace

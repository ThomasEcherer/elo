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
	/// Constants for the administration mode.
	/// </summary>
	public class AdminModeC : BSerializable
	{
	
		#region Constructors
		
		public AdminModeC() {
		}		
		
		public AdminModeC(AdminModeC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Administration mode is active
		/// </summary>
		public const int ON = 1;

		/// <summary>
		/// Administration mode is inactive
		/// </summary>
		public const int OFF = 0;

		/// <summary>
		/// Query administration mode
		/// </summary>
		public const int QUERY = -1;

		#endregion
		
		
		public static readonly long serialVersionUID = 1820929375L;		
	} // end class
}  // end namespace

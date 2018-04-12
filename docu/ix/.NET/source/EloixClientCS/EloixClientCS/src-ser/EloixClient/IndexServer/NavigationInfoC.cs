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
	/// Constants class for the NavigationInfo class.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class NavigationInfoC : BSerializable
	{
	
		#region Constructors
		
		public NavigationInfoC() {
		}		
		
		public NavigationInfoC(NavigationInfoC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// The minimum depth for tree walks.
		/// </summary>
		public const int MIN_NAV_DEPTH = 1;

		/// <summary>
		/// The overall limit for any visited element.
		/// </summary>
		public const int MIN_NAV_MAX_COUNT = 1;

		/// <summary>
		/// The minimum amount of collected siblings.
		/// </summary>
		public const int MIN_NAV_SIBLINGS = 1;

		/// <summary>
		/// This constant is used to override the navigation limit.
		/// </summary>
		public const int SKIP_NAV_LIMIT = 0;

		#endregion
		
		
		public static readonly long serialVersionUID = 1520348158L;		
	} // end class
}  // end namespace

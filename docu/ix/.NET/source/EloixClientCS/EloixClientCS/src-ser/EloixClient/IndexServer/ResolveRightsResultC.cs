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
	/// Constants for {@link ResolveRightsResult}.
	/// </summary>
	public class ResolveRightsResultC : BSerializable
	{
	
		#region Constructors
		
		public ResolveRightsResultC() {
		}		
		
		public ResolveRightsResultC(ResolveRightsResultC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Indicates that the user got the right directly.
		/// </summary>
		public const int DIRECT = 1;

		/// <summary>
		/// Indicates that the user got the right by inheritance of a group.
		/// </summary>
		public const int INHERITED = 2;

		/// <summary>
		/// Indicates that the user got the right by a substitution rule.
		/// </summary>
		public const int SUBSTITUTION = 4;

		#endregion
		
		
		public static readonly long serialVersionUID = 1322441656L;		
	} // end class
}  // end namespace

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
	/// An object of this class controls the function getArchiveStatistics.
	/// </summary>
	public class ArchiveStatisticsOptionsC : BSerializable
	{
	
		#region Constructors
		
		public ArchiveStatisticsOptionsC() {
		}		
		
		public ArchiveStatisticsOptionsC(ArchiveStatisticsOptionsC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Find the maximum document (version) ID
		/// </summary>
		public const long mbMaxDocId = 1L;

		/// <summary>
		/// Find the maximum object ID
		/// </summary>
		public const long mbMaxObjId = 2L;

		#endregion
		
		
		public static readonly long serialVersionUID = 276716257L;		
	} // end class
}  // end namespace

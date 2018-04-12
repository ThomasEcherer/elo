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
	/// <p>
	/// Constants for querying log messages of background jobs.
	/// </summary>
	/// <remarks>
	/// </p>
	/// </remarks>
	public class QueryJobProtocolC : BSerializable
	{
	
		#region Constructors
		
		public QueryJobProtocolC() {
		}		
		
		public QueryJobProtocolC(QueryJobProtocolC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Return only errors.
		/// </summary>
		public const int LOG_LEVEL_ERROR = 4096;

		/// <summary>
		/// Return only warnings.
		/// </summary>
		public const int LOG_LEVEL_WARN = 2048;

		/// <summary>
		/// Return only normal informations.
		/// </summary>
		public const int LOG_LEVEL_INFO = 1024;

		/// <summary>
		/// This value indicates that the object-ID is not set.
		/// </summary>
		public const int OBJID_NOT_SET = -1;

		#endregion
		
		
		public static readonly long serialVersionUID = 1764906979L;		
	} // end class
}  // end namespace

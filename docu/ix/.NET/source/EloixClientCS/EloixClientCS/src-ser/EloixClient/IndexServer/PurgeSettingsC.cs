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
	/// Constants for class PurgeSettings
	/// </summary>
	public class PurgeSettingsC : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public PurgeSettingsC() {
		}		
		
		public PurgeSettingsC(PurgeSettingsC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// for startHour: when the purge task is starting and then every 60 minutes
		/// </summary>
		public const int START_EVERY_HOUR = -1;

		/// <summary>
		/// for fileCheckMode: no file comparison (not recommended)
		/// </summary>
		public const int COMPARE_OFF = 1;

		/// <summary>
		/// for fileCheckMode: file comparison by file size
		/// </summary>
		public const int COMPARE_SIZE = 2;

		/// <summary>
		/// for fileCheckMode: file comparision by file content
		/// </summary>
		public const int COMPARE_CONTENT = 3;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1865968564L;		
	} // end class
}  // end namespace

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
	/// Constants for class ActivityProject.
	/// </summary>
	public class ActivityProjectC : EloixClient.IndexServer.ActivityProjectDataC, BSerializable
	{
	
		#region Constructors
		
		public ActivityProjectC() {
		}		
		
		public ActivityProjectC(ActivityProjectC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		public const long mbOptions = 8L;

		/// <summary>
		/// Reserved.
		/// </summary>
		/// <remarks>
		/// This name is used internally only. Do not use this name in your code.
		/// </remarks>
		public const String SYSTEM = "ELO_SYSTEM";

		/// <summary>
		/// Default project name.
		/// </summary>
		public const String DEFAULT = "ELO";

		/// <summary>
		/// Activity for observing documents and folders.
		/// </summary>
		public const String REQUEST = "ELO_REQ";

		/// <summary>
		/// Activity used to notify about a new document version or new sub-item.
		/// </summary>
		public const String NOTIFY = "ELO_NOTIFY";

		#endregion
		
		
		public static readonly new long serialVersionUID = 1697907147L;		
	} // end class
}  // end namespace

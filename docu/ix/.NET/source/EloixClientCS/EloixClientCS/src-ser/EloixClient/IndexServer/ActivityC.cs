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
	/// Constants for class Activity.
	/// </summary>
	public class ActivityC : EloixClient.IndexServer.ActivityDataC, BSerializable
	{
	
		#region Constructors
		
		public ActivityC() {
		}		
		
		public ActivityC(ActivityC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Typesafe element selector for members Activity.guid.
		/// </summary>
		/// <remarks>
		/// Contains ActivityC.mbGuid
		/// </remarks>
		public readonly static EloixClient.IndexServer.ActivityZ mbOnlyGuid = new ActivityZ(1L);

		/// <summary>
		/// Typesafe element selector for members Activity.guid and Activity.objGuid.
		/// </summary>
		/// <remarks>
		/// Contains ActivityC.mbGuid | ActivityC.mbObjGuid
		/// </remarks>
		public readonly static EloixClient.IndexServer.ActivityZ mbActivityAndObjectGuid = new ActivityZ(3L);

		/// <summary>
		/// Typesafe element selector for all members.
		/// </summary>
		/// <remarks>
		/// Contains ActivityC.mbAllMembers
		/// </remarks>
		public readonly static EloixClient.IndexServer.ActivityZ mbAll = new ActivityZ(2147483647L);

		#endregion
		
		
		public static readonly new long serialVersionUID = 1091363488L;		
	} // end class
}  // end namespace

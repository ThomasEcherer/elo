//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class UserTaskPriorityC : BSerializable
	{
	
		#region Constructors
		
		public UserTaskPriorityC() {
		}		
		
		public UserTaskPriorityC(UserTaskPriorityC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Minimum value = highest priority of reminder and activity
		/// </summary>
		public const int MIN = 0;

		/// <summary>
		/// Maximum value = lowest priority of reminder and activity
		/// </summary>
		public const int MAX = 2;

		/// <summary>
		/// Highest priority.
		/// </summary>
		public const int HIGHEST = 0;

		/// <summary>
		/// Lowest priority.
		/// </summary>
		public const int LOWEST = 2;

		#endregion
		
		
		public static readonly long serialVersionUID = 260320342L;		
	} // end class
}  // end namespace

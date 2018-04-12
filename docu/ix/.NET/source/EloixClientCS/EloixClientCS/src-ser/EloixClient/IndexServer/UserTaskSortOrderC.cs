//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class UserTaskSortOrderC : BSerializable
	{
	
		#region Constructors
		
		public UserTaskSortOrderC() {
		}		
		
		public UserTaskSortOrderC(UserTaskSortOrderC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		public const long bsetPRIORITY_DATE_NAME = 0L;

		public const long bsetDATE_PRIORITY_NAME = 1L;

		public const long bsetNAME_PRIORITY_DATE = 2L;

		public const long bsetFLAG_SORT_ORDER_INV = 4611686018427387904L;

		public const long bsetPRIORITY_DATE_NAME_INV = 4611686018427387904L;

		public const long bsetDATE_PRIORITY_NAME_INV = 4611686018427387905L;

		public const long bsetNAME_PRIORITY_DATE_INV = 4611686018427387906L;

		/// <summary>
		/// Order collected tasks by priority, date and NAME.
		/// </summary>
		public readonly static EloixClient.IndexServer.UserTaskSortOrderZ PRIORITY_DATE_NAME = new UserTaskSortOrderZ(0L);

		/// <summary>
		/// Order collected tasks by date, priority and NAME.
		/// </summary>
		public readonly static EloixClient.IndexServer.UserTaskSortOrderZ DATE_PRIORITY_NAME = new UserTaskSortOrderZ(1L);

		/// <summary>
		/// Order collected tasks by NAME, priority, date.
		/// </summary>
		public readonly static EloixClient.IndexServer.UserTaskSortOrderZ NAME_PRIORITY_DATE = new UserTaskSortOrderZ(2L);

		/// <summary>
		/// Inverse order collected tasks by priority, date and NAME.
		/// </summary>
		public readonly static EloixClient.IndexServer.UserTaskSortOrderZ PRIORITY_DATE_NAME_INV = new UserTaskSortOrderZ(4611686018427387904L);

		/// <summary>
		/// Inverse order collected tasks by date, priority and NAME.
		/// </summary>
		public readonly static EloixClient.IndexServer.UserTaskSortOrderZ DATE_PRIORITY_NAME_INV = new UserTaskSortOrderZ(4611686018427387904L);

		/// <summary>
		/// Inverse order collected tasks by NAME, priority, date.
		/// </summary>
		public readonly static EloixClient.IndexServer.UserTaskSortOrderZ NAME_PRIORITY_DATE_INV = new UserTaskSortOrderZ(4611686018427387904L);

		#endregion
		
		
		public static readonly long serialVersionUID = 854117900L;		
	} // end class
}  // end namespace

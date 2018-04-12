//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class ReminderC : EloixClient.IndexServer.ReminderDataC, BSerializable
	{
	
		#region Constructors
		
		public ReminderC() {
		}		
		
		public ReminderC(ReminderC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Sord guid.
		/// </summary>
		public const long mbObjGuid = 1048576L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAll = 2097151L;

		public const long mbCreateDateIso = 32L;

		public const long mbDeleted = 512L;

		public const long mbPromptDateIso = 16L;

		public const long mbDueDateIso = 64L;

		public const long mbLockName = 512L;

		public const long mbNotifyOnDelete = 256L;

		public const long mbNotifyOnView = 256L;

		public const long mbReceiverName = 4L;

		public const long mbSenderName = 8L;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1431555044L;		
	} // end class
}  // end namespace

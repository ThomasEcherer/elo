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
	/// <p>Bit constants for members of Notification</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class NotificationDataC : BSerializable
	{
	
		#region Constructors
		
		public NotificationDataC() {
		}		
		
		public NotificationDataC(int @lnUserGuid, int @lnWatchGuid, int @lnCreateDateIso) {
			this.lnUserGuidValue = @lnUserGuid;
			this.lnWatchGuidValue = @lnWatchGuid;
			this.lnCreateDateIsoValue = @lnCreateDateIso;
		}		
		
		public NotificationDataC(NotificationDataC rhs)
		{
			this.lnUserGuidValue = rhs.lnUserGuidValue;
			this.lnWatchGuidValue = rhs.lnWatchGuidValue;
			this.lnCreateDateIsoValue = rhs.lnCreateDateIsoValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: GUID of user who should receive this notification.
		/// </summary>
		/// <remarks>
		/// DB column: userguid
		/// </remarks>
		public int lnUserGuid
		{
			get
			{
				return lnUserGuidValue;
			}
			set
			{
				this.lnUserGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: GUID of changed Object.
		/// </summary>
		/// <remarks>
		/// DB column: watchguid
		/// </remarks>
		public int lnWatchGuid
		{
			get
			{
				return lnWatchGuidValue;
			}
			set
			{
				this.lnWatchGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Create date of the notification.
		/// </summary>
		/// <remarks>
		/// DB column: createdateiso
		/// </remarks>
		public int lnCreateDateIso
		{
			get
			{
				return lnCreateDateIsoValue;
			}
			set
			{
				this.lnCreateDateIsoValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: GUID of user who should receive this notification.
		/// </summary>
		/// <remarks>
		/// DB column: userguid
		/// </remarks>
		public const long mbUserGuid = 1L;

		protected int lnUserGuidValue;

		/// <summary>
		/// Member bit: GUID of changed Object.
		/// </summary>
		/// <remarks>
		/// DB column: watchguid
		/// </remarks>
		public const long mbWatchGuid = 2L;

		protected int lnWatchGuidValue;

		/// <summary>
		/// Member bit: Create date of the notification.
		/// </summary>
		/// <remarks>
		/// DB column: createdateiso
		/// </remarks>
		public const long mbCreateDateIso = 4L;

		protected int lnCreateDateIsoValue;

		/// <summary>
		/// Member bit: Indicates if the Notification is marked as important
		/// DB column: prio
		/// </summary>
		public const long mbPrio = 8L;

		/// <summary>
		/// Member bit: Indicates the type of the watched Element.
		/// </summary>
		/// <remarks>
		/// DB column: what
		/// </remarks>
		public const long mbWhat = 16L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 31L;

		#endregion
		
		
		public static readonly long serialVersionUID = 2010056196L;		
	} // end class
}  // end namespace

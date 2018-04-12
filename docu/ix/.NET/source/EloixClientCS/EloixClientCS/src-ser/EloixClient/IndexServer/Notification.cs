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
	/// Objects of this class represent a change notification.
	/// </summary>
	/// <remarks>
	/// This class is used internally.
	/// </remarks>
	public class Notification : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public Notification() {
		}		
		
		public Notification(String @userGuid, String @watchGuid, String @createDateIso, int @prio, int @what) {
			this.userGuidValue = @userGuid;
			this.watchGuidValue = @watchGuid;
			this.createDateIsoValue = @createDateIso;
			this.prioValue = @prio;
			this.whatValue = @what;
		}		
		
		public Notification(Notification rhs) : base(rhs)
		{
			this.userGuidValue = rhs.userGuidValue;
			this.watchGuidValue = rhs.watchGuidValue;
			this.createDateIsoValue = rhs.createDateIsoValue;
			this.prioValue = rhs.prioValue;
			this.whatValue = rhs.whatValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// GUID of user who should receive this notification.
		/// </summary>
		public String userGuid
		{
			get
			{
				return userGuidValue;
			}
			set
			{
				this.userGuidValue = value;
				setChangedMember(NotificationC.mbUserGuid);
			}
		}
		
		
		/// <summary>
		/// GUID of changed Object.
		/// </summary>
		public String watchGuid
		{
			get
			{
				return watchGuidValue;
			}
			set
			{
				this.watchGuidValue = value;
				setChangedMember(NotificationC.mbWatchGuid);
			}
		}
		
		
		/// <summary>
		/// Create date of the notification.
		/// </summary>
		public String createDateIso
		{
			get
			{
				return createDateIsoValue;
			}
			set
			{
				this.createDateIsoValue = value;
				setChangedMember(NotificationC.mbCreateDateIso);
			}
		}
		
		
		/// <summary>
		/// Indicates if the Notification is marked as important
		/// </summary>
		public int prio
		{
			get
			{
				return prioValue;
			}
			set
			{
				this.prioValue = value;
				setChangedMember(NotificationC.mbPrio);
			}
		}
		
		
		/// <summary>
		/// Indicates the type of the watched Element.
		/// 0 - Action.
		/// 1 - HashTag.
		/// </summary>
		public int what
		{
			get
			{
				return whatValue;
			}
			set
			{
				this.whatValue = value;
				setChangedMember(NotificationC.mbWhat);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String userGuidValue;

		protected String watchGuidValue;

		protected String createDateIsoValue;

		protected int prioValue;

		protected int whatValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 494610451L;		
	} // end class
}  // end namespace

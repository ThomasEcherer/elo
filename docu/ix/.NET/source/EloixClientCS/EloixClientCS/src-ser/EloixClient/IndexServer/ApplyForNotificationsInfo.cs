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
	/// This class defines which notification messages the server has to send.
	/// </summary>
	public class ApplyForNotificationsInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ApplyForNotificationsInfo() {
		}		
		
		public ApplyForNotificationsInfo(bool @adminMode, bool @userTask) {
			this.adminModeValue = @adminMode;
			this.userTaskValue = @userTask;
		}		
		
		public ApplyForNotificationsInfo(ApplyForNotificationsInfo rhs) : base(rhs)
		{
			this.adminModeValue = rhs.adminModeValue;
			this.userTaskValue = rhs.userTaskValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Receive {@link de.elo.ix.client.notify.ClientNotification#adminMode(ClientInfo, int)}
		/// </summary>
		public bool adminMode
		{
			get
			{
				return adminModeValue;
			}
			set
			{
				this.adminModeValue = value;
			}
		}
		
		
		/// <summary>
		/// Reserved
		/// </summary>
		public bool userTask
		{
			get
			{
				return userTaskValue;
			}
			set
			{
				this.userTaskValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool adminModeValue;

		protected bool userTaskValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 77743605L;		
	} // end class
}  // end namespace

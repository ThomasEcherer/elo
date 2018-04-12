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
	/// Find criterias for selecting alerts.
	/// </summary>
	/// <remarks>
	/// RESERVED
	/// </remarks>
	public class FindAlertInfo : BSerializable
	{
	
		#region Constructors
		
		public FindAlertInfo() {
		}		
		
		public FindAlertInfo(String @sourceId, String @destId, bool @inclAll, bool @inclAlam, bool @inclReminder, bool @inclInTray, bool @inclWorkFlow, bool @inclOthers, bool @inclSubs, String @objId, String @timeIso) {
			this.sourceIdValue = @sourceId;
			this.destIdValue = @destId;
			this.inclAllValue = @inclAll;
			this.inclAlamValue = @inclAlam;
			this.inclReminderValue = @inclReminder;
			this.inclInTrayValue = @inclInTray;
			this.inclWorkFlowValue = @inclWorkFlow;
			this.inclOthersValue = @inclOthers;
			this.inclSubsValue = @inclSubs;
			this.objIdValue = @objId;
			this.timeIsoValue = @timeIso;
		}		
		
		public FindAlertInfo(FindAlertInfo rhs)
		{
			this.sourceIdValue = rhs.sourceIdValue;
			this.destIdValue = rhs.destIdValue;
			this.inclAllValue = rhs.inclAllValue;
			this.inclAlamValue = rhs.inclAlamValue;
			this.inclReminderValue = rhs.inclReminderValue;
			this.inclInTrayValue = rhs.inclInTrayValue;
			this.inclWorkFlowValue = rhs.inclWorkFlowValue;
			this.inclOthersValue = rhs.inclOthersValue;
			this.inclSubsValue = rhs.inclSubsValue;
			this.objIdValue = rhs.objIdValue;
			this.timeIsoValue = rhs.timeIsoValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Find alerts created by this user, ID or name.
		/// </summary>
		public String sourceId
		{
			get
			{
				return sourceIdValue;
			}
			set
			{
				this.sourceIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Find alerts sendet to this user, ID or name.
		/// </summary>
		/// <remarks>
		/// Only main administrators can set this value to an arbitary user ID.
		/// Other users can only set one of her or his groups or one of her or
		/// his substituted users.
		/// </remarks>
		public String destId
		{
			get
			{
				return destIdValue;
			}
			set
			{
				this.destIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Find all notification types.
		/// </summary>
		/// <remarks>
		/// If this member is set, the other members related to
		/// notification types are ignored.
		/// </remarks>
		public bool inclAll
		{
			get
			{
				return inclAllValue;
			}
			set
			{
				this.inclAllValue = value;
			}
		}
		
		
		/// <summary>
		/// Find alarm notifications.
		/// </summary>
		/// <remarks>
		/// Ignored, if <code>inclAll</code> is true.
		/// </remarks>
		public bool inclAlam
		{
			get
			{
				return inclAlamValue;
			}
			set
			{
				this.inclAlamValue = value;
			}
		}
		
		
		/// <summary>
		/// Find reminder notifications.
		/// </summary>
		/// <remarks>
		/// Ignored, if <code>inclAll</code> is true.
		/// </remarks>
		public bool inclReminder
		{
			get
			{
				return inclReminderValue;
			}
			set
			{
				this.inclReminderValue = value;
			}
		}
		
		
		/// <summary>
		/// Find notifications related to the In Tray.
		/// </summary>
		/// <remarks>
		/// Ignored, if <code>inclAll</code> is true.
		/// </remarks>
		public bool inclInTray
		{
			get
			{
				return inclInTrayValue;
			}
			set
			{
				this.inclInTrayValue = value;
			}
		}
		
		
		/// <summary>
		/// Find workflow notifications.
		/// </summary>
		/// <remarks>
		/// Ignored, if <code>inclAll</code> is true.
		/// </remarks>
		public bool inclWorkFlow
		{
			get
			{
				return inclWorkFlowValue;
			}
			set
			{
				this.inclWorkFlowValue = value;
			}
		}
		
		
		/// <summary>
		/// Find all other notifications that are not explicitly
		/// listed here.
		/// </summary>
		/// <remarks>
		/// Ignored, if <code>inclAll</code> is true.
		/// </remarks>
		public bool inclOthers
		{
			get
			{
				return inclOthersValue;
			}
			set
			{
				this.inclOthersValue = value;
			}
		}
		
		
		/// <summary>
		/// Find notifications related to substitution rules.
		/// </summary>
		/// <remarks>
		/// Ignored, if <code>inclAll</code> is true.
		/// </remarks>
		public bool inclSubs
		{
			get
			{
				return inclSubsValue;
			}
			set
			{
				this.inclSubsValue = value;
			}
		}
		
		
		/// <summary>
		/// Find notifications related to this object.
		/// </summary>
		/// <remarks>
		/// For valid values see <code>checkoutSord</code>.
		/// </remarks>
		public String objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Find notifiations with this create date or
		/// in this date range.
		/// </summary>
		/// <remarks>
		/// A date range must be separated by "...".
		/// </remarks>
		public String timeIso
		{
			get
			{
				return timeIsoValue;
			}
			set
			{
				this.timeIsoValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String sourceIdValue;

		protected String destIdValue;

		protected bool inclAllValue;

		protected bool inclAlamValue;

		protected bool inclReminderValue;

		protected bool inclInTrayValue;

		protected bool inclWorkFlowValue;

		protected bool inclOthersValue;

		protected bool inclSubsValue;

		protected String objIdValue;

		protected String timeIsoValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 897433042L;		
	} // end class
}  // end namespace

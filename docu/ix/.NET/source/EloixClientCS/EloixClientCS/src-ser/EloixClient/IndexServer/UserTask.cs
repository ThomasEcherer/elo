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
	/// Describes the tasks assigned to a user.
	/// </summary>
	/// <remarks>
	/// ix.findFirstTasks returns the tasks for a user in the form of UserTask objects.
	/// Either activity, reminder or workflow is set depending upon whether the task
	/// is an activity, reminder or workflow task.
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class UserTask : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public UserTask() {
		}		
		
		public UserTask(EloixClient.IndexServer.Activity @activity, EloixClient.IndexServer.Reminder @reminder, EloixClient.IndexServer.WFCollectNode @wfNode, EloixClient.IndexServer.Sord @sord) {
			this.activityValue = @activity;
			this.reminderValue = @reminder;
			this.wfNodeValue = @wfNode;
			this.sordValue = @sord;
		}		
		
		public UserTask(UserTask rhs) : base(rhs)
		{
			this.activityValue = rhs.activityValue;
			this.reminderValue = rhs.reminderValue;
			this.wfNodeValue = rhs.wfNodeValue;
			this.sordValue = rhs.sordValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Task is an activity.
		/// </summary>
		public EloixClient.IndexServer.Activity activity
		{
			get
			{
				return activityValue;
			}
			set
			{
				this.activityValue = value;
			}
		}
		
		
		/// <summary>
		/// Task is a reminder item.
		/// </summary>
		public EloixClient.IndexServer.Reminder reminder
		{
			get
			{
				return reminderValue;
			}
			set
			{
				this.reminderValue = value;
			}
		}
		
		
		/// <summary>
		/// Task is a workflow task.
		/// </summary>
		public EloixClient.IndexServer.WFCollectNode wfNode
		{
			get
			{
				return wfNodeValue;
			}
			set
			{
				this.wfNodeValue = value;
			}
		}
		
		
		/// <summary>
		/// Associated Sord object.
		/// </summary>
		/// <remarks>
		/// This member is set, if {@link IXServicePortIF#findFirstTasks(ClientInfo, FindTasksInfo, int)} is called with
		/// {@link FindTasksInfo#sordZ} != null.
		/// This member contains the associatied Sord object to the task. Its valid members are defined by the element
		/// selector given in {@link FindTasksInfo#sordZ}.
		/// </remarks>
		public EloixClient.IndexServer.Sord sord
		{
			get
			{
				return sordValue;
			}
			set
			{
				this.sordValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.Activity activityValue;

		protected EloixClient.IndexServer.Reminder reminderValue;

		protected EloixClient.IndexServer.WFCollectNode wfNodeValue;

		protected EloixClient.IndexServer.Sord sordValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1484696239L;		
	} // end class
}  // end namespace

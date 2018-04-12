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
	/// This class contains the search criteria that are required for locating a
	/// task (reminders, workflow tasks or activity).
	/// </summary>
	public class FindTasksInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindTasksInfo() {
		}		
		
		public FindTasksInfo(String @endDateIso, int @highestPriority, bool @inclActivities, bool @inclDeputy, bool @inclGroup, bool @inclReminders, bool @inclWorkflows, int @lowestPriority, String @objId, EloixClient.IndexServer.UserTaskSortOrderZ @sortOrder, String @startDateIso, bool @overTimeLimit, bool @inclOverTimeForSuperior, String[] @userIds, bool @inclDeleted, bool @allUsers, EloixClient.IndexServer.SordZ @sordZ, String @taskName, bool @updateInUseDate, IList<String> @inclActivityTypes, bool @inclHidden, int @timeLimitBias) {
			this.endDateIsoValue = @endDateIso;
			this.highestPriorityValue = @highestPriority;
			this.inclActivitiesValue = @inclActivities;
			this.inclDeputyValue = @inclDeputy;
			this.inclGroupValue = @inclGroup;
			this.inclRemindersValue = @inclReminders;
			this.inclWorkflowsValue = @inclWorkflows;
			this.lowestPriorityValue = @lowestPriority;
			this.objIdValue = @objId;
			this.sortOrderValue = @sortOrder;
			this.startDateIsoValue = @startDateIso;
			this.overTimeLimitValue = @overTimeLimit;
			this.inclOverTimeForSuperiorValue = @inclOverTimeForSuperior;
			this.userIdsValue = @userIds;
			this.inclDeletedValue = @inclDeleted;
			this.allUsersValue = @allUsers;
			this.sordZValue = @sordZ;
			this.taskNameValue = @taskName;
			this.updateInUseDateValue = @updateInUseDate;
			this.inclActivityTypesValue = @inclActivityTypes;
			this.inclHiddenValue = @inclHidden;
			this.timeLimitBiasValue = @timeLimitBias;
		}		
		
		public FindTasksInfo(FindTasksInfo rhs) : base(rhs)
		{
			this.endDateIsoValue = rhs.endDateIsoValue;
			this.highestPriorityValue = rhs.highestPriorityValue;
			this.inclActivitiesValue = rhs.inclActivitiesValue;
			this.inclDeputyValue = rhs.inclDeputyValue;
			this.inclGroupValue = rhs.inclGroupValue;
			this.inclRemindersValue = rhs.inclRemindersValue;
			this.inclWorkflowsValue = rhs.inclWorkflowsValue;
			this.lowestPriorityValue = rhs.lowestPriorityValue;
			this.objIdValue = rhs.objIdValue;
			this.sortOrderValue = rhs.sortOrderValue;
			this.startDateIsoValue = rhs.startDateIsoValue;
			this.overTimeLimitValue = rhs.overTimeLimitValue;
			this.inclOverTimeForSuperiorValue = rhs.inclOverTimeForSuperiorValue;
			this.userIdsValue = rhs.userIdsValue;
			this.inclDeletedValue = rhs.inclDeletedValue;
			this.allUsersValue = rhs.allUsersValue;
			this.sordZValue = rhs.sordZValue;
			this.taskNameValue = rhs.taskNameValue;
			this.updateInUseDateValue = rhs.updateInUseDateValue;
			this.inclActivityTypesValue = rhs.inclActivityTypesValue;
			this.inclHiddenValue = rhs.inclHiddenValue;
			this.timeLimitBiasValue = rhs.timeLimitBiasValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Collect tasks up to this date.
		/// </summary>
		public String endDateIso
		{
			get
			{
				return endDateIsoValue;
			}
			set
			{
				this.endDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Collect tasks of this or lower priority.
		/// </summary>
		public int highestPriority
		{
			get
			{
				return highestPriorityValue;
			}
			set
			{
				this.highestPriorityValue = value;
			}
		}
		
		
		/// <summary>
		/// Collect activities.
		/// </summary>
		public bool inclActivities
		{
			get
			{
				return inclActivitiesValue;
			}
			set
			{
				this.inclActivitiesValue = value;
			}
		}
		
		
		/// <summary>
		/// Collect tasks received from users for which the current
		/// user is a substitute.
		/// </summary>
		public bool inclDeputy
		{
			get
			{
				return inclDeputyValue;
			}
			set
			{
				this.inclDeputyValue = value;
			}
		}
		
		
		/// <summary>
		/// Collect tasks of the users groups.
		/// </summary>
		public bool inclGroup
		{
			get
			{
				return inclGroupValue;
			}
			set
			{
				this.inclGroupValue = value;
			}
		}
		
		
		/// <summary>
		/// Collect reminders.
		/// </summary>
		public bool inclReminders
		{
			get
			{
				return inclRemindersValue;
			}
			set
			{
				this.inclRemindersValue = value;
			}
		}
		
		
		/// <summary>
		/// Collect workflows.
		/// </summary>
		public bool inclWorkflows
		{
			get
			{
				return inclWorkflowsValue;
			}
			set
			{
				this.inclWorkflowsValue = value;
			}
		}
		
		
		/// <summary>
		/// Collect tasks of this or higher priority.
		/// </summary>
		public int lowestPriority
		{
			get
			{
				return lowestPriorityValue;
			}
			set
			{
				this.lowestPriorityValue = value;
			}
		}
		
		
		/// <summary>
		/// Collect tasks for this Sord (ID or GUID).
		/// </summary>
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
		/// Controls the sort order or returned arrays.
		/// </summary>
		/// <remarks>
		/// If null, PRIORITY_DATE_NAME is used.
		/// </remarks>
		public EloixClient.IndexServer.UserTaskSortOrderZ sortOrder
		{
			get
			{
				return sortOrderValue;
			}
			set
			{
				this.sortOrderValue = value;
			}
		}
		
		
		/// <summary>
		/// Collect tasks beginning at this date.
		/// </summary>
		public String startDateIso
		{
			get
			{
				return startDateIsoValue;
			}
			set
			{
				this.startDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Collect nodes that exceeded the time limit.
		/// </summary>
		/// <remarks>
		/// Workflow only
		/// </remarks>
		public bool overTimeLimit
		{
			get
			{
				return overTimeLimitValue;
			}
			set
			{
				this.overTimeLimitValue = value;
			}
		}
		
		
		/// <summary>
		/// Collect tasks for a superior as defined in the escalation options.
		/// </summary>
		/// <remarks>
		/// When a workflow task exceeds its time limit, and the current user is
		/// assigned in the time limit options of this task,
		/// then the user receives this task from findFirstTasks/findNextTasks although
		/// she or he is not the owner of the task.
		/// If an entire workflow is over time, the user receives the start node of the workflow.
		/// This option applies to workflow tasks only.
		/// </remarks>
		public bool inclOverTimeForSuperior
		{
			get
			{
				return inclOverTimeForSuperiorValue;
			}
			set
			{
				this.inclOverTimeForSuperiorValue = value;
			}
		}
		
		
		/// <summary>
		/// IDs of the users which tasks can be collected by the administrator.
		/// </summary>
		/// <remarks>
		/// This member is ignored, if the current user does not have administrator privileges {@link AccessC#FLAG_ADMIN}.
		/// For administrators, this can be a list of user or groups which tasks should be selected. If the list is null or empty,
		/// The tasks of the administrator are collected. In order to collect all tasks from all users, set member {@link #allUsers}=true.
		/// </remarks>
		public String[] userIds
		{
			get
			{
				return userIdsValue;
			}
			set
			{
				this.userIdsValue = value;
			}
		}
		
		
		/// <summary>
		/// Select tasks for deleted folders and documents too.
		/// </summary>
		public bool inclDeleted
		{
			get
			{
				return inclDeletedValue;
			}
			set
			{
				this.inclDeletedValue = value;
			}
		}
		
		
		/// <summary>
		/// Collect tasks from all users.
		/// </summary>
		/// <remarks>
		/// This member is ignored, if the current user does not have administrator privileges {@link AccessC#FLAG_ADMIN}.
		/// If set to true, element {@link #userIds} is ignored and the tasks of all users are selected.
		/// </remarks>
		public bool allUsers
		{
			get
			{
				return allUsersValue;
			}
			set
			{
				this.allUsersValue = value;
			}
		}
		
		
		/// <summary>
		/// Return the associated Sord objects to the selected Tasks.
		/// </summary>
		/// <remarks>
		/// If this member is not null, the Sord objects to the selected Tasks are read from the database.
		/// The Sord objects can be found in {@link FindResult#sords} and in each {@link UserTask#sord}
		/// of the array {@link FindResult#tasks}.
		/// The Sord objects contain the elements defined in this element selector as valid members.
		/// </remarks>
		public EloixClient.IndexServer.SordZ sordZ
		{
			get
			{
				return sordZValue;
			}
			set
			{
				this.sordZValue = value;
			}
		}
		
		
		/// <summary>
		/// Select tasks with this name.
		/// </summary>
		/// <remarks>
		/// The task name of a Reminder is Reminder.name. The task name of an Activity is Activity.name.
		/// The task name of a workflow node is WFNode.name and WFCollectNode.nodeName.
		/// This element can contain wildcard characters.
		/// The underlying database column is by default not indexed. Thus, selecting only by taskName
		/// will result in a full table scan.
		/// </remarks>
		public String taskName
		{
			get
			{
				return taskNameValue;
			}
			set
			{
				this.taskNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Update WFNode.inUseDateIso for selected tasks.
		/// </summary>
		public bool updateInUseDate
		{
			get
			{
				return updateInUseDateValue;
			}
			set
			{
				this.updateInUseDateValue = value;
			}
		}
		
		
		/// <summary>
		/// Only select activities of the given types
		/// </summary>
		public IList<String> inclActivityTypes
		{
			get
			{
				return inclActivityTypesValue;
			}
			set
			{
				this.inclActivityTypesValue = value;
			}
		}
		
		
		/// <summary>
		/// Inlcude hidden tasks.
		/// </summary>
		/// <remarks>
		/// Currently this only affects workflows.
		/// </remarks>
		public bool inclHidden
		{
			get
			{
				return inclHiddenValue;
			}
			set
			{
				this.inclHiddenValue = value;
			}
		}
		
		
		/// <summary>
		/// Time limit bias.
		/// </summary>
		/// <remarks>
		/// This value added to each {@link WFNode#timeLimit} before evaluating whether the node is over time.
		/// It is measured in minutes. Indexserver uses a timeLimitBias of 1min when looking for over-timed nodes to be
		/// forwarded automatically through a {@link WFNodeMatrixC#IF_OVERTIME} edge.
		/// </remarks>
		public int timeLimitBias
		{
			get
			{
				return timeLimitBiasValue;
			}
			set
			{
				this.timeLimitBiasValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String endDateIsoValue;

		protected int highestPriorityValue;

		protected bool inclActivitiesValue;

		protected bool inclDeputyValue;

		protected bool inclGroupValue;

		protected bool inclRemindersValue;

		protected bool inclWorkflowsValue;

		protected int lowestPriorityValue;

		protected String objIdValue;

		protected EloixClient.IndexServer.UserTaskSortOrderZ sortOrderValue;

		protected String startDateIsoValue;

		protected bool overTimeLimitValue;

		protected bool inclOverTimeForSuperiorValue;

		protected String[] userIdsValue;

		protected bool inclDeletedValue;

		protected bool allUsersValue;

		protected EloixClient.IndexServer.SordZ sordZValue;

		protected String taskNameValue;

		protected bool updateInUseDateValue;

		protected IList<String> inclActivityTypesValue;

		protected bool inclHiddenValue;

		protected int timeLimitBiasValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1489194452L;		
	} // end class
}  // end namespace

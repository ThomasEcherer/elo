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
	/// This class contains the search criteria for selecting workflows.
	/// </summary>
	/// <remarks>
	/// <p>
	/// Copyright: Copyright (c) 2008, 2010
	/// </p>
	/// <p>
	/// Organisation: ELO Digital Office GmbH
	/// </p>
	/// </remarks>
	public class FindWorkflowInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindWorkflowInfo() {
		}		
		
		public FindWorkflowInfo(String[] @userIds, String @name, EloixClient.IndexServer.WFTypeZ @type, bool @overTimeLimit, String @objId, String @startDateIso, String @completionDateIso, String @templateId, bool @inclDeleted, String[] @ownerIds, String[] @activeUserIds, bool @inclHidden, EloixClient.IndexServer.SordZ @sordZ, bool @excludeUserGroups) {
			this.userIdsValue = @userIds;
			this.nameValue = @name;
			this.typeValue = @type;
			this.overTimeLimitValue = @overTimeLimit;
			this.objIdValue = @objId;
			this.startDateIsoValue = @startDateIso;
			this.completionDateIsoValue = @completionDateIso;
			this.templateIdValue = @templateId;
			this.inclDeletedValue = @inclDeleted;
			this.ownerIdsValue = @ownerIds;
			this.activeUserIdsValue = @activeUserIds;
			this.inclHiddenValue = @inclHidden;
			this.sordZValue = @sordZ;
			this.excludeUserGroupsValue = @excludeUserGroups;
		}		
		
		public FindWorkflowInfo(FindWorkflowInfo rhs) : base(rhs)
		{
			this.userIdsValue = rhs.userIdsValue;
			this.nameValue = rhs.nameValue;
			this.typeValue = rhs.typeValue;
			this.overTimeLimitValue = rhs.overTimeLimitValue;
			this.objIdValue = rhs.objIdValue;
			this.startDateIsoValue = rhs.startDateIsoValue;
			this.completionDateIsoValue = rhs.completionDateIsoValue;
			this.templateIdValue = rhs.templateIdValue;
			this.inclDeletedValue = rhs.inclDeletedValue;
			this.ownerIdsValue = rhs.ownerIdsValue;
			this.activeUserIdsValue = rhs.activeUserIdsValue;
			this.inclHiddenValue = rhs.inclHiddenValue;
			this.sordZValue = rhs.sordZValue;
			this.excludeUserGroupsValue = rhs.excludeUserGroupsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Collect workflows for this users.
		/// </summary>
		/// <remarks>
		/// For every given user or group in this list, those workflows are returned where
		/// the user or her or his groups or her or his substituted users has any
		/// node assigned.
		/// If this value is null or empty and the current user is a workflow administrator,
		/// the returned list of workflows is not constrained to any user ID.
		/// If this value is null or empty and the current user is not a workflow administrator,
		/// workflows for the current user inclusive her or his groups and inclusive her or his substituted users are returned.
		/// A Workflow administrator (privilege AccessC.FLAG_EDITWF) can specify
		/// any user or group ID here. Another user can only specify her or his user ID
		/// or her or his groups or her or his substituted users.
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
		/// Workflow name.
		/// </summary>
		/// <remarks>
		/// If not null and not empty, it the search is restricted to workflows named like this value.
		/// It may contain wildcards, e. g. *bill*.
		/// </remarks>
		public String name
		{
			get
			{
				return nameValue;
			}
			set
			{
				this.nameValue = value;
			}
		}
		
		
		/// <summary>
		/// Workflow type.
		/// </summary>
		/// <remarks>
		/// This parameter controls the search for nodes of either active or
		/// finished workflows. If this parameter is null, the search is performed on active workflows.
		/// </remarks>
		public EloixClient.IndexServer.WFTypeZ type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
			}
		}
		
		
		/// <summary>
		/// Collect only WFs that exceeded the time limit.
		/// </summary>
		/// <remarks>
		/// The entire WF or one of its nodes must be over time.
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
		/// Object ID.
		/// </summary>
		/// <remarks>
		/// Active and finished workflows only.
		/// If not null and not empty, only workflows assigned to this object are returned.
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
		/// Start date.
		/// </summary>
		/// <remarks>
		/// If not null and not empty, workflows started at this date or in this date range are returned.
		/// It can be a single date value or a time span of two ISO dates separated by "...". To
		/// return workflows with a start date up to a given time, set startDateIso="..."+time
		/// (the first time value can be omitted).
		/// </remarks>
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
		/// Completion date.
		/// </summary>
		/// <remarks>
		/// If not null and not empty, workflows completed at this date or in this date range are returned.
		/// Only valid if <code>wfType=FINISHED</code>.
		/// A time span can be specified by using "...".
		/// </remarks>
		public String completionDateIso
		{
			get
			{
				return completionDateIsoValue;
			}
			set
			{
				this.completionDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Workflow template ID or name.
		/// </summary>
		/// <remarks>
		/// If not null and not empty, the result is constrained to workflows based on this workflow template.
		/// </remarks>
		public String templateId
		{
			get
			{
				return templateIdValue;
			}
			set
			{
				this.templateIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Only template workflows: include deleted templates.
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
		/// List with ownerIds.
		/// </summary>
		/// <remarks>
		/// If not null and not empty only the workflows with these owners will be returned.
		/// </remarks>
		public String[] ownerIds
		{
			get
			{
				return ownerIdsValue;
			}
			set
			{
				this.ownerIdsValue = value;
			}
		}
		
		
		/// <summary>
		/// List with userIds.
		/// </summary>
		/// <remarks>
		/// If not null and not empty only the workflows with this active users will be returned.
		/// ActiveUsers are the users of the active workflow node.
		/// </remarks>
		public String[] activeUserIds
		{
			get
			{
				return activeUserIdsValue;
			}
			set
			{
				this.activeUserIdsValue = value;
			}
		}
		
		
		/// <summary>
		/// If true, include hidden/technical workflows with the result.
		/// </summary>
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
		/// Return the associated Sord objects to the selected workflows.
		/// </summary>
		/// <remarks>
		/// If this member is not null, the Sord objects to the selected workflows are read from the database.
		/// The Sord objects can be found in {@link FindResult#sords} in a random order.
		/// A Sord object is returned only once, even if there are more workflows assigned to the Sord.
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
		/// If true, only select workflows of the users.
		/// </summary>
		/// <remarks>
		/// The group workflows are excluded.
		/// </remarks>
		public bool excludeUserGroups
		{
			get
			{
				return excludeUserGroupsValue;
			}
			set
			{
				this.excludeUserGroupsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String[] userIdsValue;

		protected String nameValue;

		protected EloixClient.IndexServer.WFTypeZ typeValue;

		protected bool overTimeLimitValue;

		protected String objIdValue;

		protected String startDateIsoValue;

		protected String completionDateIsoValue;

		protected String templateIdValue;

		protected bool inclDeletedValue;

		protected String[] ownerIdsValue;

		protected String[] activeUserIdsValue;

		protected bool inclHiddenValue;

		protected EloixClient.IndexServer.SordZ sordZValue;

		protected bool excludeUserGroupsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1768797010L;		
	} // end class
}  // end namespace

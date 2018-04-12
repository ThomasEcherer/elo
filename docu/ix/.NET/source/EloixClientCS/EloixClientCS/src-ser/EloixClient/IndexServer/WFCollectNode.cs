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
	/// <p>Data used to display a workflow node int the task view.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>This class bundles the data which is required for displaying a workflow
	/// node. The class is used by <code>findFirstTasks</code> </p>
	/// </remarks>
	public class WFCollectNode : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WFCollectNode() {
		}		
		
		public WFCollectNode(String @activateDateIso, bool @active, int @flowId, String @flowName, String @inUseDateIso, int @nodeId, String @nodeName, String @objGuid, int @objId, int @objType, int @prio, String @terminateDateIso, int @userId, String @userName, bool @overTimeLimit, String @completionDateIso, String @userDelayDateIso, String @flowStatus, String @timeLimitIso, EloixClient.IndexServer.WFTimeLimit[] @timeLimitEscalations, int @workflowOwnerId, String @workflowOwnerName, int @designDepartmentId, String @designDepartmentName, String @nodeComment, String @objName, int @timeLimit, int @timeLimitUserId, String @timeLimitUserName, EloixClient.IndexServer.WFTimeLimit[] @timeLimitsWorkflow, String @activateDateWorkflowIso, String @formSpec, bool @overTimeLimitAny, bool @hidden, String @nodeNameTranslationKey, String @nodeCommentTranslationKey, String @flowNameTranslationKey, String @label, String @properties, int @parentFlowId, String @labelTranslationKey, int @callNodeId) {
			this.activateDateIsoValue = @activateDateIso;
			this.activeValue = @active;
			this.flowIdValue = @flowId;
			this.flowNameValue = @flowName;
			this.inUseDateIsoValue = @inUseDateIso;
			this.nodeIdValue = @nodeId;
			this.nodeNameValue = @nodeName;
			this.objGuidValue = @objGuid;
			this.objIdValue = @objId;
			this.objTypeValue = @objType;
			this.prioValue = @prio;
			this.terminateDateIsoValue = @terminateDateIso;
			this.userIdValue = @userId;
			this.userNameValue = @userName;
			this.overTimeLimitValue = @overTimeLimit;
			this.completionDateIsoValue = @completionDateIso;
			this.userDelayDateIsoValue = @userDelayDateIso;
			this.flowStatusValue = @flowStatus;
			this.timeLimitIsoValue = @timeLimitIso;
			this.timeLimitEscalationsValue = @timeLimitEscalations;
			this.workflowOwnerIdValue = @workflowOwnerId;
			this.workflowOwnerNameValue = @workflowOwnerName;
			this.designDepartmentIdValue = @designDepartmentId;
			this.designDepartmentNameValue = @designDepartmentName;
			this.nodeCommentValue = @nodeComment;
			this.objNameValue = @objName;
			this.timeLimitValue = @timeLimit;
			this.timeLimitUserIdValue = @timeLimitUserId;
			this.timeLimitUserNameValue = @timeLimitUserName;
			this.timeLimitsWorkflowValue = @timeLimitsWorkflow;
			this.activateDateWorkflowIsoValue = @activateDateWorkflowIso;
			this.formSpecValue = @formSpec;
			this.overTimeLimitAnyValue = @overTimeLimitAny;
			this.hiddenValue = @hidden;
			this.nodeNameTranslationKeyValue = @nodeNameTranslationKey;
			this.nodeCommentTranslationKeyValue = @nodeCommentTranslationKey;
			this.flowNameTranslationKeyValue = @flowNameTranslationKey;
			this.labelValue = @label;
			this.propertiesValue = @properties;
			this.parentFlowIdValue = @parentFlowId;
			this.labelTranslationKeyValue = @labelTranslationKey;
			this.callNodeIdValue = @callNodeId;
		}		
		
		public WFCollectNode(WFCollectNode rhs) : base(rhs)
		{
			this.activateDateIsoValue = rhs.activateDateIsoValue;
			this.activeValue = rhs.activeValue;
			this.flowIdValue = rhs.flowIdValue;
			this.flowNameValue = rhs.flowNameValue;
			this.inUseDateIsoValue = rhs.inUseDateIsoValue;
			this.nodeIdValue = rhs.nodeIdValue;
			this.nodeNameValue = rhs.nodeNameValue;
			this.objGuidValue = rhs.objGuidValue;
			this.objIdValue = rhs.objIdValue;
			this.objTypeValue = rhs.objTypeValue;
			this.prioValue = rhs.prioValue;
			this.terminateDateIsoValue = rhs.terminateDateIsoValue;
			this.userIdValue = rhs.userIdValue;
			this.userNameValue = rhs.userNameValue;
			this.overTimeLimitValue = rhs.overTimeLimitValue;
			this.completionDateIsoValue = rhs.completionDateIsoValue;
			this.userDelayDateIsoValue = rhs.userDelayDateIsoValue;
			this.flowStatusValue = rhs.flowStatusValue;
			this.timeLimitIsoValue = rhs.timeLimitIsoValue;
			this.timeLimitEscalationsValue = rhs.timeLimitEscalationsValue;
			this.workflowOwnerIdValue = rhs.workflowOwnerIdValue;
			this.workflowOwnerNameValue = rhs.workflowOwnerNameValue;
			this.designDepartmentIdValue = rhs.designDepartmentIdValue;
			this.designDepartmentNameValue = rhs.designDepartmentNameValue;
			this.nodeCommentValue = rhs.nodeCommentValue;
			this.objNameValue = rhs.objNameValue;
			this.timeLimitValue = rhs.timeLimitValue;
			this.timeLimitUserIdValue = rhs.timeLimitUserIdValue;
			this.timeLimitUserNameValue = rhs.timeLimitUserNameValue;
			this.timeLimitsWorkflowValue = rhs.timeLimitsWorkflowValue;
			this.activateDateWorkflowIsoValue = rhs.activateDateWorkflowIsoValue;
			this.formSpecValue = rhs.formSpecValue;
			this.overTimeLimitAnyValue = rhs.overTimeLimitAnyValue;
			this.hiddenValue = rhs.hiddenValue;
			this.nodeNameTranslationKeyValue = rhs.nodeNameTranslationKeyValue;
			this.nodeCommentTranslationKeyValue = rhs.nodeCommentTranslationKeyValue;
			this.flowNameTranslationKeyValue = rhs.flowNameTranslationKeyValue;
			this.labelValue = rhs.labelValue;
			this.propertiesValue = rhs.propertiesValue;
			this.parentFlowIdValue = rhs.parentFlowIdValue;
			this.labelTranslationKeyValue = rhs.labelTranslationKeyValue;
			this.callNodeIdValue = rhs.callNodeIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Date the node was activated
		/// </summary>
		public String activateDateIso
		{
			get
			{
				return activateDateIsoValue;
			}
			set
			{
				this.activateDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Is the node active or not?
		/// </summary>
		public bool active
		{
			get
			{
				return activeValue;
			}
			set
			{
				this.activeValue = value;
			}
		}
		
		
		/// <summary>
		/// Workflow id
		/// </summary>
		public int flowId
		{
			get
			{
				return flowIdValue;
			}
			set
			{
				this.flowIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Workflow name
		/// </summary>
		public String flowName
		{
			get
			{
				return flowNameValue;
			}
			set
			{
				this.flowNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Date the node was set to <i>In Use</i>
		/// </summary>
		public String inUseDateIso
		{
			get
			{
				return inUseDateIsoValue;
			}
			set
			{
				this.inUseDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Node identifier
		/// </summary>
		public int nodeId
		{
			get
			{
				return nodeIdValue;
			}
			set
			{
				this.nodeIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Description/processing instructions for the workflow node
		/// </summary>
		public String nodeName
		{
			get
			{
				return nodeNameValue;
			}
			set
			{
				this.nodeNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Object GUID of the object for which the workflow is started.
		/// </summary>
		/// <remarks>
		/// This member is not set, if workflow caching is enabled.
		/// </remarks>
		public String objGuid
		{
			get
			{
				return objGuidValue;
			}
			set
			{
				this.objGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Object id of the object for which the workflow is started.
		/// </summary>
		public int objId
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
		/// Object type of the object for which the workflow is started
		/// </summary>
		/// <remarks>
		/// .
		/// (1 for cabinet, 2 for folder, etc.)
		/// </remarks>
		public int objType
		{
			get
			{
				return objTypeValue;
			}
			set
			{
				this.objTypeValue = value;
			}
		}
		
		
		/// <summary>
		/// Node priority
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
			}
		}
		
		
		/// <summary>
		/// Date the node was completed/terminated
		/// </summary>
		public String terminateDateIso
		{
			get
			{
				return terminateDateIsoValue;
			}
			set
			{
				this.terminateDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// User number of the user for whom the workflow node is intended.
		/// </summary>
		public int userId
		{
			get
			{
				return userIdValue;
			}
			set
			{
				this.userIdValue = value;
			}
		}
		
		
		/// <summary>
		/// User name of the user for whom the workflow node is intended.
		/// </summary>
		public String userName
		{
			get
			{
				return userNameValue;
			}
			set
			{
				this.userNameValue = value;
			}
		}
		
		
		/// <summary>
		/// True, if the node exceeds the time limit.
		/// </summary>
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
		/// Date the workfow was completed
		/// </summary>
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
		/// The workflow node is deferred until this date.
		/// </summary>
		/// <remarks>
		/// Not valid for template workflows.
		/// Only valid for person nodes.
		/// ELO date format.
		/// </remarks>
		public String userDelayDateIso
		{
			get
			{
				return userDelayDateIsoValue;
			}
			set
			{
				this.userDelayDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Workflow status.
		/// </summary>
		/// <remarks>
		/// This member is only valid when this object is returned by the
		/// findFirstTasks or findNextTasks functions.
		/// </remarks>
		public String flowStatus
		{
			get
			{
				return flowStatusValue;
			}
			set
			{
				this.flowStatusValue = value;
			}
		}
		
		
		/// <summary>
		/// Node must be completed until this date.
		/// </summary>
		/// <remarks>
		/// This member is only valid when this object is returned by the
		/// findFirstTasks or findNextTasks functions.
		/// </remarks>
		public String timeLimitIso
		{
			get
			{
				return timeLimitIsoValue;
			}
			set
			{
				this.timeLimitIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Additional definitions for time limits.
		/// </summary>
		public EloixClient.IndexServer.WFTimeLimit[] timeLimitEscalations
		{
			get
			{
				return timeLimitEscalationsValue;
			}
			set
			{
				this.timeLimitEscalationsValue = value;
			}
		}
		
		
		/// <summary>
		/// Workflow owner ID.
		/// </summary>
		/// <remarks>
		/// This member is only valid when this object is returned by the
		/// findFirstTasks or findNextTasks functions.
		/// </remarks>
		public int workflowOwnerId
		{
			get
			{
				return workflowOwnerIdValue;
			}
			set
			{
				this.workflowOwnerIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Workflow owner name.
		/// </summary>
		/// <remarks>
		/// This member is only valid when this object is returned by the
		/// findFirstTasks or findNextTasks functions.
		/// </remarks>
		public String workflowOwnerName
		{
			get
			{
				return workflowOwnerNameValue;
			}
			set
			{
				this.workflowOwnerNameValue = value;
			}
		}
		
		
		/// <summary>
		/// ID of the user that was assigned to the node when the workflow started.
		/// </summary>
		public int designDepartmentId
		{
			get
			{
				return designDepartmentIdValue;
			}
			set
			{
				this.designDepartmentIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Name of the user that was assigned to the node when the workflow started.
		/// </summary>
		public String designDepartmentName
		{
			get
			{
				return designDepartmentNameValue;
			}
			set
			{
				this.designDepartmentNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Node description.
		/// </summary>
		public String nodeComment
		{
			get
			{
				return nodeCommentValue;
			}
			set
			{
				this.nodeCommentValue = value;
			}
		}
		
		
		/// <summary>
		/// Sord name.
		/// </summary>
		public String objName
		{
			get
			{
				return objNameValue;
			}
			set
			{
				this.objNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Time limit in minutes.
		/// </summary>
		public int timeLimit
		{
			get
			{
				return timeLimitValue;
			}
			set
			{
				this.timeLimitValue = value;
			}
		}
		
		
		/// <summary>
		/// The ID of the user that should be informed,
		/// if the time-limit is exceeded.
		/// </summary>
		/// <remarks>
		/// The IndexServer does not send any notification to the
		/// user. The client application is responsible for doing this.
		/// </remarks>
		public int timeLimitUserId
		{
			get
			{
				return timeLimitUserIdValue;
			}
			set
			{
				this.timeLimitUserIdValue = value;
			}
		}
		
		
		/// <summary>
		/// User name for timeLimitUserId;
		/// When writing a workflow with checkinWorkFlow, this value has preceedence
		/// before timeLimitUserId.
		/// </summary>
		/// <remarks>
		/// Set timeLimitUserName to an empty string, if
		/// timeLimitUserId should be used.
		/// </remarks>
		public String timeLimitUserName
		{
			get
			{
				return timeLimitUserNameValue;
			}
			set
			{
				this.timeLimitUserNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Time limits and time limit escalation of the entire workflow.
		/// </summary>
		/// <remarks>
		/// This array holds 3 time limit states of the entire workflow.
		/// The first item is filled from WFDiagram.overTimeLimit, WFDiagram.timeLimit,
		/// WFDiagram.timeLimitIso, WFDiagram.timeLimitUserId and WFDiagram.timeLimitUserName.
		/// The second and third items are set to the two items in WFDiagram.timeLimitEscaltions.
		/// </remarks>
		public EloixClient.IndexServer.WFTimeLimit[] timeLimitsWorkflow
		{
			get
			{
				return timeLimitsWorkflowValue;
			}
			set
			{
				this.timeLimitsWorkflowValue = value;
			}
		}
		
		
		/// <summary>
		/// Workflow start date.
		/// </summary>
		public String activateDateWorkflowIso
		{
			get
			{
				return activateDateWorkflowIsoValue;
			}
			set
			{
				this.activateDateWorkflowIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Same as {@link WFNode#formSpec}.
		/// </summary>
		public String formSpec
		{
			get
			{
				return formSpecValue;
			}
			set
			{
				this.formSpecValue = value;
			}
		}
		
		
		/// <summary>
		/// Indicates whether the workflow is an escalation.
		/// </summary>
		public bool overTimeLimitAny
		{
			get
			{
				return overTimeLimitAnyValue;
			}
			set
			{
				this.overTimeLimitAnyValue = value;
			}
		}
		
		
		/// <summary>
		/// Indicates whether this workflow is hidden.
		/// </summary>
		public bool hidden
		{
			get
			{
				return hiddenValue;
			}
			set
			{
				this.hiddenValue = value;
			}
		}
		
		
		/// <summary>
		/// Translation-keyword for nodeName.
		/// </summary>
		public String nodeNameTranslationKey
		{
			get
			{
				return nodeNameTranslationKeyValue;
			}
			set
			{
				this.nodeNameTranslationKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// Translation-keyword for nodeComment.
		/// </summary>
		public String nodeCommentTranslationKey
		{
			get
			{
				return nodeCommentTranslationKeyValue;
			}
			set
			{
				this.nodeCommentTranslationKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// Translation-keyword for workflow name.
		/// </summary>
		public String flowNameTranslationKey
		{
			get
			{
				return flowNameTranslationKeyValue;
			}
			set
			{
				this.flowNameTranslationKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// Display name by forwarding
		/// </summary>
		public String label
		{
			get
			{
				return labelValue;
			}
			set
			{
				this.labelValue = value;
			}
		}
		
		
		/// <summary>
		/// Node properties
		/// </summary>
		public String properties
		{
			get
			{
				return propertiesValue;
			}
			set
			{
				this.propertiesValue = value;
			}
		}
		
		
		/// <summary>
		/// ID of the parent workflow.
		/// </summary>
		public int parentFlowId
		{
			get
			{
				return parentFlowIdValue;
			}
			set
			{
				this.parentFlowIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Translation-keyword for {@link WFCollectNode#label}.
		/// </summary>
		public String labelTranslationKey
		{
			get
			{
				return labelTranslationKeyValue;
			}
			set
			{
				this.labelTranslationKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// The call node id of the main workflow, which call this sub workflow.
		/// </summary>
		public int callNodeId
		{
			get
			{
				return callNodeIdValue;
			}
			set
			{
				this.callNodeIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String activateDateIsoValue;

		protected bool activeValue;

		protected int flowIdValue;

		protected String flowNameValue;

		protected String inUseDateIsoValue;

		protected int nodeIdValue;

		protected String nodeNameValue;

		protected String objGuidValue;

		protected int objIdValue;

		protected int objTypeValue;

		protected int prioValue;

		protected String terminateDateIsoValue;

		protected int userIdValue;

		protected String userNameValue;

		protected bool overTimeLimitValue;

		protected String completionDateIsoValue;

		protected String userDelayDateIsoValue;

		protected String flowStatusValue;

		protected String timeLimitIsoValue;

		protected EloixClient.IndexServer.WFTimeLimit[] timeLimitEscalationsValue;

		protected int workflowOwnerIdValue;

		protected String workflowOwnerNameValue;

		protected int designDepartmentIdValue;

		protected String designDepartmentNameValue;

		protected String nodeCommentValue;

		protected String objNameValue;

		protected int timeLimitValue;

		protected int timeLimitUserIdValue;

		protected String timeLimitUserNameValue;

		protected EloixClient.IndexServer.WFTimeLimit[] timeLimitsWorkflowValue;

		protected String activateDateWorkflowIsoValue;

		protected String formSpecValue;

		protected bool overTimeLimitAnyValue;

		protected bool hiddenValue;

		protected String nodeNameTranslationKeyValue;

		protected String nodeCommentTranslationKeyValue;

		protected String flowNameTranslationKeyValue;

		protected String labelValue;

		protected String propertiesValue;

		protected int parentFlowIdValue;

		protected String labelTranslationKeyValue;

		protected int callNodeIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1492908819L;		
	} // end class
}  // end namespace

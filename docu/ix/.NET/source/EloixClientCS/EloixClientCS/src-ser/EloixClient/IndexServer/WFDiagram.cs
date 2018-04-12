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
	/// This class represents an active or finished workflow or a workflow template
	/// </summary>
	public class WFDiagram : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WFDiagram() {
		}		
		
		public WFDiagram(String @acl, EloixClient.IndexServer.AclItem[] @aclItems, String @completionDateIso, bool @deleted, int @id, int @lockId, String @lockName, EloixClient.IndexServer.WFNodeMatrix @matrix, String @name, EloixClient.IndexServer.WFNode[] @nodes, String @objId, int @objType, int @ownerId, String @ownerName, int @prio, String @startDateIso, int @templateId, String @templateName, int @timeLimit, String @timeLimitIso, int @timeLimitUserId, String @timeLimitUserName, EloixClient.IndexServer.WFTypeZ @type, bool @overTimeLimit, int @flags, int @access, EloixClient.IndexServer.WFVersion @version, String @guid, String @tStamp, String @processOnServerId, EloixClient.IndexServer.WFTimeLimit[] @timeLimitEscalations, String @objName, String @TStampSync, String @nameTranslationKey, bool @hidden, int @parentFlowId, int @callNodeId, IDictionary<int,EloixClient.IndexServer.WFDiagram> @subWorkflows) {
			this.aclValue = @acl;
			this.aclItemsValue = @aclItems;
			this.completionDateIsoValue = @completionDateIso;
			this.deletedValue = @deleted;
			this.idValue = @id;
			this.lockIdValue = @lockId;
			this.lockNameValue = @lockName;
			this.matrixValue = @matrix;
			this.nameValue = @name;
			this.nodesValue = @nodes;
			this.objIdValue = @objId;
			this.objTypeValue = @objType;
			this.ownerIdValue = @ownerId;
			this.ownerNameValue = @ownerName;
			this.prioValue = @prio;
			this.startDateIsoValue = @startDateIso;
			this.templateIdValue = @templateId;
			this.templateNameValue = @templateName;
			this.timeLimitValue = @timeLimit;
			this.timeLimitIsoValue = @timeLimitIso;
			this.timeLimitUserIdValue = @timeLimitUserId;
			this.timeLimitUserNameValue = @timeLimitUserName;
			this.typeValue = @type;
			this.overTimeLimitValue = @overTimeLimit;
			this.flagsValue = @flags;
			this.accessValue = @access;
			this.versionValue = @version;
			this.guidValue = @guid;
			this.tStampValue = @tStamp;
			this.processOnServerIdValue = @processOnServerId;
			this.timeLimitEscalationsValue = @timeLimitEscalations;
			this.objNameValue = @objName;
			this.TStampSyncValue = @TStampSync;
			this.nameTranslationKeyValue = @nameTranslationKey;
			this.hiddenValue = @hidden;
			this.parentFlowIdValue = @parentFlowId;
			this.callNodeIdValue = @callNodeId;
			this.subWorkflowsValue = @subWorkflows;
		}		
		
		public WFDiagram(WFDiagram rhs) : base(rhs)
		{
			this.aclValue = rhs.aclValue;
			this.aclItemsValue = rhs.aclItemsValue;
			this.completionDateIsoValue = rhs.completionDateIsoValue;
			this.deletedValue = rhs.deletedValue;
			this.idValue = rhs.idValue;
			this.lockIdValue = rhs.lockIdValue;
			this.lockNameValue = rhs.lockNameValue;
			this.matrixValue = rhs.matrixValue;
			this.nameValue = rhs.nameValue;
			this.nodesValue = rhs.nodesValue;
			this.objIdValue = rhs.objIdValue;
			this.objTypeValue = rhs.objTypeValue;
			this.ownerIdValue = rhs.ownerIdValue;
			this.ownerNameValue = rhs.ownerNameValue;
			this.prioValue = rhs.prioValue;
			this.startDateIsoValue = rhs.startDateIsoValue;
			this.templateIdValue = rhs.templateIdValue;
			this.templateNameValue = rhs.templateNameValue;
			this.timeLimitValue = rhs.timeLimitValue;
			this.timeLimitIsoValue = rhs.timeLimitIsoValue;
			this.timeLimitUserIdValue = rhs.timeLimitUserIdValue;
			this.timeLimitUserNameValue = rhs.timeLimitUserNameValue;
			this.typeValue = rhs.typeValue;
			this.overTimeLimitValue = rhs.overTimeLimitValue;
			this.flagsValue = rhs.flagsValue;
			this.accessValue = rhs.accessValue;
			this.versionValue = rhs.versionValue;
			this.guidValue = rhs.guidValue;
			this.tStampValue = rhs.tStampValue;
			this.processOnServerIdValue = rhs.processOnServerIdValue;
			this.timeLimitEscalationsValue = rhs.timeLimitEscalationsValue;
			this.objNameValue = rhs.objNameValue;
			this.TStampSyncValue = rhs.TStampSyncValue;
			this.nameTranslationKeyValue = rhs.nameTranslationKeyValue;
			this.hiddenValue = rhs.hiddenValue;
			this.parentFlowIdValue = rhs.parentFlowIdValue;
			this.callNodeIdValue = rhs.callNodeIdValue;
			this.subWorkflowsValue = rhs.subWorkflowsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Access control list in the internal format.
		/// </summary>
		/// <remarks>
		/// It defines who is able to edit
		/// the workflow. This member is only valid for workflow templates.
		/// </remarks>
		public String acl
		{
			get
			{
				return aclValue;
			}
			set
			{
				this.aclValue = value;
				setChangedMember(WFDiagramC.mbAcl);
			}
		}
		
		
		/// <summary>
		/// Access control list in a more convenient format than member acl.
		/// </summary>
		/// <remarks>
		/// It defines
		/// who is able to edit the workflow. This member is only valid for workflow
		/// templates.
		/// </remarks>
		public EloixClient.IndexServer.AclItem[] aclItems
		{
			get
			{
				return aclItemsValue;
			}
			set
			{
				this.aclItemsValue = value;
				setChangedMember(WFDiagramC.mbAclItems);
			}
		}
		
		
		/// <summary>
		/// Date of completion in ISO format.
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
				setChangedMember(WFDiagramC.mbCompletionDateIso);
			}
		}
		
		
		/// <summary>
		/// Flag that indicates whether the workflow template is deleted.
		/// </summary>
		/// <remarks>
		/// Only valid
		/// for template workflows.
		/// </remarks>
		public bool deleted
		{
			get
			{
				return deletedValue;
			}
			set
			{
				this.deletedValue = value;
				setChangedMember(WFDiagramC.mbDeleted);
			}
		}
		
		
		/// <summary>
		/// Workflow ID.
		/// </summary>
		public int id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
				setChangedMember(WFDiagramC.mbId);
			}
		}
		
		
		/// <summary>
		/// The ID of the user who has currently locked the workflow.
		/// </summary>
		public int lockId
		{
			get
			{
				return lockIdValue;
			}
			set
			{
				this.lockIdValue = value;
				setChangedMember(WFDiagramC.mbLockId);
			}
		}
		
		
		/// <summary>
		/// The name of the user who has currently locked the workflow.
		/// </summary>
		public String lockName
		{
			get
			{
				return lockNameValue;
			}
			set
			{
				this.lockNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Node matrix.
		/// </summary>
		public EloixClient.IndexServer.WFNodeMatrix matrix
		{
			get
			{
				return matrixValue;
			}
			set
			{
				this.matrixValue = value;
				setChangedMember(WFDiagramC.mbMatrix);
			}
		}
		
		
		/// <summary>
		/// Workflow name.
		/// </summary>
		public String name
		{
			get
			{
				return nameValue;
			}
			set
			{
				this.nameValue = value;
				setChangedMember(WFDiagramC.mbName);
			}
		}
		
		
		/// <summary>
		/// Array of nodes.
		/// </summary>
		public EloixClient.IndexServer.WFNode[] nodes
		{
			get
			{
				return nodesValue;
			}
			set
			{
				this.nodesValue = value;
				setChangedMember(WFDiagramC.mbNodes);
			}
		}
		
		
		/// <summary>
		/// ID or GUID of the associated folder or document object. checkoutWorkFlow
		/// will always return the numeric object ID in this field. checkinWorkFlow is
		/// able to receive a GUID too.
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
				setChangedMember(WFDiagramC.mbObjId);
			}
		}
		
		
		/// <summary>
		/// Sord type of the associated folder or document.
		/// </summary>
		public int objType
		{
			get
			{
				return objTypeValue;
			}
			set
			{
				this.objTypeValue = value;
				setChangedMember(WFDiagramC.mbObjType);
			}
		}
		
		
		/// <summary>
		/// ID of the user who has started the workflow.
		/// </summary>
		public int ownerId
		{
			get
			{
				return ownerIdValue;
			}
			set
			{
				this.ownerIdValue = value;
				setChangedMember(WFDiagramC.mbOwnerId);
			}
		}
		
		
		/// <summary>
		/// Name of the user who has started the workflow.
		/// </summary>
		public String ownerName
		{
			get
			{
				return ownerNameValue;
			}
			set
			{
				this.ownerNameValue = value;
				setChangedMember(WFDiagramC.mbOwnerName);
			}
		}
		
		
		/// <summary>
		/// Workflow priortiy: 0...high, 1...medium, 2...low.
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
				setChangedMember(WFDiagramC.mbPrio);
			}
		}
		
		
		/// <summary>
		/// Date of start in ISO format.
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
				setChangedMember(WFDiagramC.mbStartDateIso);
			}
		}
		
		
		/// <summary>
		/// The workflow was started based on this workflow template.
		/// </summary>
		/// <remarks>
		/// This member is
		/// only valid for active and finished workflows.
		/// </remarks>
		public int templateId
		{
			get
			{
				return templateIdValue;
			}
			set
			{
				this.templateIdValue = value;
				setChangedMember(WFDiagramC.mbTemplateId);
			}
		}
		
		
		/// <summary>
		/// The workflow was started based on the workflow template with this name.
		/// </summary>
		/// <remarks>
		/// This member is only valid for active and finished workflows.
		/// </remarks>
		public String templateName
		{
			get
			{
				return templateNameValue;
			}
			set
			{
				this.templateNameValue = value;
				setChangedMember(WFDiagramC.mbTemplateName);
			}
		}
		
		
		/// <summary>
		/// Time-limit for the entire workflow in minutes.
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
				setChangedMember(WFDiagramC.mbTimeLimitUserId);
			}
		}
		
		
		/// <summary>
		/// The entire workflow should be finished by this date.
		/// </summary>
		/// <remarks>
		/// Otherwise the
		/// time-limit is exceeded. This member is only valid for active and finished
		/// workflows. Read-only.
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
				setChangedMember(WFDiagramC.mbTimeLimitIso);
			}
		}
		
		
		/// <summary>
		/// The ID of the user that should be informed,if the time-limit for the
		/// workflow is exceeded.
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
				setChangedMember(WFDiagramC.mbTimeLimitUserId);
			}
		}
		
		
		/// <summary>
		/// The name of the user that should be informed, if the time-limit is
		/// exceeded.
		/// </summary>
		/// <remarks>
		/// When writing a workflow with checkinWorkFlow, this value has
		/// preceedence before timeLimitUserId. Set timeLimitUserName to an empty
		/// string, if timeLimitUserId should be used.
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
				setChangedMember(WFDiagramC.mbTimeLimitUserName);
			}
		}
		
		
		/// <summary>
		/// Typeof template: template, active or finished.
		/// </summary>
		public EloixClient.IndexServer.WFTypeZ type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
				setChangedMember(WFDiagramC.mbType);
			}
		}
		
		
		/// <summary>
		/// True, if the workflow exceeds the time limit.
		/// </summary>
		/// <remarks>
		/// Read-only.
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
		/// Flags of the begin node.
		/// </summary>
		/// <remarks>
		/// This value is a combination of the node flags
		/// suitable to begin nodes, e. g. WFNodeC.FLAG_WORKINGDAYS. To ensure
		/// compatibility with older client programs, the WFNode.flags of the start
		/// node are or-ed with the WFDiagram.flags.
		/// </remarks>
		public int flags
		{
			get
			{
				return flagsValue;
			}
			set
			{
				this.flagsValue = value;
				setChangedMember(WFDiagramC.mbFlags);
			}
		}
		
		
		/// <summary>
		/// Access rights to the object for the current user.
		/// </summary>
		/// <remarks>
		/// A combination of LUR_*
		/// constants. Read-only.
		/// </remarks>
		public int access
		{
			get
			{
				return accessValue;
			}
			set
			{
				this.accessValue = value;
				setChangedMember(WFDiagramC.mbAccess);
			}
		}
		
		
		/// <summary>
		/// Only templates: version information.
		/// </summary>
		public EloixClient.IndexServer.WFVersion version
		{
			get
			{
				return versionValue;
			}
			set
			{
				this.versionValue = value;
				setChangedMember(WFDiagramC.mbVersion);
			}
		}
		
		
		/// <summary>
		/// GUID
		/// </summary>
		public String guid
		{
			get
			{
				return guidValue;
			}
			set
			{
				this.guidValue = value;
				setChangedMember(WFDiagramC.mbGuid);
			}
		}
		
		
		/// <summary>
		/// TStamp
		/// </summary>
		public String tStamp
		{
			get
			{
				return tStampValue;
			}
			set
			{
				this.tStampValue = value;
				setChangedMember(WFDiagramC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// If not empty, the workflow can only be continued on this server (resp.
		/// </summary>
		/// <remarks>
		/// replication branch). The current server ID can be read by getServerInfo().
		/// This member is only valid for ACTIVE or FINISHED workflows.
		/// </remarks>
		public String processOnServerId
		{
			get
			{
				return processOnServerIdValue;
			}
			set
			{
				this.processOnServerIdValue = value;
				setChangedMember(WFDiagramC.mbProcessOnServerId);
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
				setChangedMember(WFDiagramC.mbTimeLimitEscalations);
			}
		}
		
		
		/// <summary>
		/// Sord name.
		/// </summary>
		/// <remarks>
		/// Readonly.
		/// </remarks>
		public String objName
		{
			get
			{
				return objNameValue;
			}
			set
			{
				this.objNameValue = value;
				setChangedMember(WFDiagramC.mbObjName);
			}
		}
		
		
		/// <summary>
		/// Timestamp of this object's last export by the replication.
		/// </summary>
		public String TStampSync
		{
			get
			{
				return TStampSyncValue;
			}
			set
			{
				this.TStampSyncValue = value;
				setChangedMember(WFDiagramC.mbTStampSync);
			}
		}
		
		
		/// <summary>
		/// Translation-keyword for {@link WFDiagram#name}.
		/// </summary>
		public String nameTranslationKey
		{
			get
			{
				return nameTranslationKeyValue;
			}
			set
			{
				this.nameTranslationKeyValue = value;
				setChangedMember(WFDiagramC.mbNameTranslationKey);
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
				setChangedMember(WFDiagramC.mbCallNodeId);
			}
		}
		
		
		/// <summary>
		/// Sub workflows.
		/// </summary>
		public IDictionary<int,EloixClient.IndexServer.WFDiagram> subWorkflows
		{
			get
			{
				return subWorkflowsValue;
			}
			set
			{
				this.subWorkflowsValue = value;
				setChangedMember(WFDiagramC.mbSubWorkflows);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String aclValue;

		protected EloixClient.IndexServer.AclItem[] aclItemsValue;

		protected String completionDateIsoValue;

		protected bool deletedValue;

		protected int idValue;

		protected int lockIdValue;

		protected String lockNameValue;

		protected EloixClient.IndexServer.WFNodeMatrix matrixValue;

		protected String nameValue;

		protected EloixClient.IndexServer.WFNode[] nodesValue;

		protected String objIdValue;

		protected int objTypeValue;

		protected int ownerIdValue;

		protected String ownerNameValue;

		protected int prioValue;

		protected String startDateIsoValue;

		protected int templateIdValue;

		protected String templateNameValue;

		protected int timeLimitValue;

		protected String timeLimitIsoValue;

		protected int timeLimitUserIdValue;

		protected String timeLimitUserNameValue;

		protected EloixClient.IndexServer.WFTypeZ typeValue;

		protected bool overTimeLimitValue;

		protected int flagsValue;

		protected int accessValue;

		protected EloixClient.IndexServer.WFVersion versionValue;

		protected String guidValue;

		protected String tStampValue;

		protected String processOnServerIdValue;

		protected EloixClient.IndexServer.WFTimeLimit[] timeLimitEscalationsValue;

		protected String objNameValue;

		protected String TStampSyncValue;

		protected String nameTranslationKeyValue;

		protected bool hiddenValue;

		protected int parentFlowIdValue;

		protected int callNodeIdValue;

		protected IDictionary<int,EloixClient.IndexServer.WFDiagram> subWorkflowsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1663767661L;		
	} // end class
}  // end namespace

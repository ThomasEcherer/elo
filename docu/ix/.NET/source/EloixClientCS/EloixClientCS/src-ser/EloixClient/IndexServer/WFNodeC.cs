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
	/// <p>Constants for <code>WorkFlowNode</code>.
	/// </summary>
	/// <remarks>
	/// </p>
	/// </remarks>
	public class WFNodeC : BSerializable
	{
	
		#region Constructors
		
		public WFNodeC() {
		}		
		
		public WFNodeC(int @lnName, int @lnComment, int @lnOnEnter, int @lnOnExit, int @lnYesNoCondition, int @lnCondition, int @lnProcessOnServerId, int @lnFormSpec, int @lnNameTranslationKey, int @lnCommentTranslationKey, int @lnLabel, int @lnLabelTranslationKey, int @lnProperties) {
			this.lnNameValue = @lnName;
			this.lnCommentValue = @lnComment;
			this.lnOnEnterValue = @lnOnEnter;
			this.lnOnExitValue = @lnOnExit;
			this.lnYesNoConditionValue = @lnYesNoCondition;
			this.lnConditionValue = @lnCondition;
			this.lnProcessOnServerIdValue = @lnProcessOnServerId;
			this.lnFormSpecValue = @lnFormSpec;
			this.lnNameTranslationKeyValue = @lnNameTranslationKey;
			this.lnCommentTranslationKeyValue = @lnCommentTranslationKey;
			this.lnLabelValue = @lnLabel;
			this.lnLabelTranslationKeyValue = @lnLabelTranslationKey;
			this.lnPropertiesValue = @lnProperties;
		}		
		
		public WFNodeC(WFNodeC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
			this.lnCommentValue = rhs.lnCommentValue;
			this.lnOnEnterValue = rhs.lnOnEnterValue;
			this.lnOnExitValue = rhs.lnOnExitValue;
			this.lnYesNoConditionValue = rhs.lnYesNoConditionValue;
			this.lnConditionValue = rhs.lnConditionValue;
			this.lnProcessOnServerIdValue = rhs.lnProcessOnServerIdValue;
			this.lnFormSpecValue = rhs.lnFormSpecValue;
			this.lnNameTranslationKeyValue = rhs.lnNameTranslationKeyValue;
			this.lnCommentTranslationKeyValue = rhs.lnCommentTranslationKeyValue;
			this.lnLabelValue = rhs.lnLabelValue;
			this.lnLabelTranslationKeyValue = rhs.lnLabelTranslationKeyValue;
			this.lnPropertiesValue = rhs.lnPropertiesValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Maximum length of node name.
		/// </summary>
		public int lnName
		{
			get
			{
				return lnNameValue;
			}
			set
			{
				this.lnNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of comment.
		/// </summary>
		public int lnComment
		{
			get
			{
				return lnCommentValue;
			}
			set
			{
				this.lnCommentValue = value;
			}
		}
		
		
		public int lnOnEnter
		{
			get
			{
				return lnOnEnterValue;
			}
			set
			{
				this.lnOnEnterValue = value;
			}
		}
		
		
		public int lnOnExit
		{
			get
			{
				return lnOnExitValue;
			}
			set
			{
				this.lnOnExitValue = value;
			}
		}
		
		
		public int lnYesNoCondition
		{
			get
			{
				return lnYesNoConditionValue;
			}
			set
			{
				this.lnYesNoConditionValue = value;
			}
		}
		
		
		public int lnCondition
		{
			get
			{
				return lnConditionValue;
			}
			set
			{
				this.lnConditionValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of processOnServerId.
		/// </summary>
		public int lnProcessOnServerId
		{
			get
			{
				return lnProcessOnServerIdValue;
			}
			set
			{
				this.lnProcessOnServerIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of form spec.
		/// </summary>
		public int lnFormSpec
		{
			get
			{
				return lnFormSpecValue;
			}
			set
			{
				this.lnFormSpecValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of the name's translation key.
		/// </summary>
		public int lnNameTranslationKey
		{
			get
			{
				return lnNameTranslationKeyValue;
			}
			set
			{
				this.lnNameTranslationKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of the comment's translation key.
		/// </summary>
		public int lnCommentTranslationKey
		{
			get
			{
				return lnCommentTranslationKeyValue;
			}
			set
			{
				this.lnCommentTranslationKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of the label.
		/// </summary>
		public int lnLabel
		{
			get
			{
				return lnLabelValue;
			}
			set
			{
				this.lnLabelValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of the labelTranslationKey.
		/// </summary>
		public int lnLabelTranslationKey
		{
			get
			{
				return lnLabelTranslationKeyValue;
			}
			set
			{
				this.lnLabelTranslationKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of the properties.
		/// </summary>
		public int lnProperties
		{
			get
			{
				return lnPropertiesValue;
			}
			set
			{
				this.lnPropertiesValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: Node ID
		/// </summary>
		public const long mbId = 1L;

		/// <summary>
		/// Member bit: Type
		/// </summary>
		public const long mbType = 2L;

		/// <summary>
		/// Member bit: Activated at this date.
		/// </summary>
		public const long mbEnterDate = 4L;

		/// <summary>
		/// Member bit: Leaved at this date.
		/// </summary>
		public const long mbExitDate = 8L;

		/// <summary>
		/// Member bit: In use at this date.
		/// </summary>
		public const long mbInUseDate = 16L;

		/// <summary>
		/// Member bit: Name
		/// </summary>
		public const long mbName = 32L;

		protected int lnNameValue;

		/// <summary>
		/// Member bit: User ID
		/// </summary>
		public const long mbUserId = 64L;

		/// <summary>
		/// Member bit: number of predecessor nodes that must be processed to forward this node.
		/// </summary>
		public const long mbNbOfDonesToExit = 128L;

		/// <summary>
		/// Member bit: (to be defined)
		/// </summary>
		public const long mbTimeLimit = 512L;

		/// <summary>
		/// Member bit: Node comment.
		/// </summary>
		public const long mbComment = 1024L;

		protected int lnCommentValue;

		/// <summary>
		/// Member bit: x position in designer view.
		/// </summary>
		public const long mbPosX = 4096L;

		/// <summary>
		/// Member bit: y position in designer view.
		/// </summary>
		public const long mbPosY = 8192L;

		/// <summary>
		/// Member bit: locked from user.
		/// </summary>
		public const long mbLockId = 16384L;

		/// <summary>
		/// Member bit: script to execute when node is activated.
		/// </summary>
		public const long mbOnEnter = 32768L;

		protected int lnOnEnterValue;

		/// <summary>
		/// Member bit: script to execute when node is leaved.
		/// </summary>
		public const long mbOnExit = 65536L;

		protected int lnOnExitValue;

		/// <summary>
		/// Member bit: control flags.
		/// </summary>
		public const long mbFlags = 131072L;

		/// <summary>
		/// Member bit: (to be defined)
		/// </summary>
		public const long mbIsNext = 262144L;

		/// <summary>
		/// Member bit: yes/no condition
		/// </summary>
		public const long mbYesNoCondition = 524288L;

		protected int lnYesNoConditionValue;

		/// <summary>
		/// Member bit: condition, is only internally used
		/// </summary>
		public const long mbCondition = 1048576L;

		protected int lnConditionValue;

		/// <summary>
		/// Member bit: Condition result.
		/// </summary>
		public const long mbResult = 2097152L;

		/// <summary>
		/// Member bit: The ID of the user who has forwarded the node.
		/// </summary>
		/// <remarks>
		/// Not valid for template workflows.
		/// Only valid for person nodes.
		/// DB column: wf_userterminate
		/// </remarks>
		public const long mbUserTerminate = 4194304L;

		/// <summary>
		/// Member bit: reserved.
		/// </summary>
		/// <remarks>
		/// DB column: wf_tag
		/// </remarks>
		public const long mbTag = 8388608L;

		/// <summary>
		/// Member bit: A group ID or user ID that was originally assigned in the designer.
		/// </summary>
		/// <remarks>
		/// DB column: wf_designdepartment
		/// </remarks>
		public const long mbDesignDepartment = 16777216L;

		/// <summary>
		/// Member bit: If a cycle is re-entered, the nodes in the cycle are duplicated.
		/// </summary>
		/// <remarks>
		/// The copied
		/// nodes will be placed in the designer moved by this value to the right. If
		/// this value is 0, the nodes are moved 60 points right and 20 points up.
		/// DB column: wf_dx
		/// </remarks>
		public const long mbMoveCyclePosX = 33554432L;

		/// <summary>
		/// Member bit: A group ID to constrain access to the node.
		/// </summary>
		/// <remarks>
		/// Only members of this group
		/// are allowed to see and process the node.
		/// Only valid for person nodes.
		/// DB column: wf_department2
		/// </remarks>
		public const long mbDepartment2 = 67108864L;

		/// <summary>
		/// Member bit: An active person node (Activate is set) might be displayed to the user
		/// delayed by this number of days.
		/// </summary>
		/// <remarks>
		/// Only valid for person nodes.
		/// DB column: wf_deldays
		/// </remarks>
		public const long mbDelayDays = 134217728L;

		/// <summary>
		/// Member bit: DelayDaye.
		/// </summary>
		/// <remarks>
		/// Not valid for template workflows.
		/// Only valid for person nodes.
		/// DB column: wf_duedate
		/// </remarks>
		public const long mbDelayDate = 268435456L;

		/// <summary>
		/// Member bit: UserDelayDate.
		/// </summary>
		/// <remarks>
		/// Not valid for template workflows.
		/// Only valid for person nodes.
		/// DB column: wf_duedate
		/// </remarks>
		public const long mbUserDelayDate = 536870912L;

		/// <summary>
		/// Member bit: processOnServerId;
		/// </summary>
		public const long mbProcessOnServerId = 1073741824L;

		protected int lnProcessOnServerIdValue;

		/// <summary>
		/// Member bit: timeLimitEscalation
		/// </summary>
		public const long mbTimeLimitEscalations = 2147483648L;

		/// <summary>
		/// Member bit: objKeyNames
		/// </summary>
		public const long mbObjKeyNames = 4294967296L;

		/// <summary>
		/// Member bit: scriptNames
		/// </summary>
		public const long mbScriptNames = 8589934592L;

		/// <summary>
		/// Member bit: Icon GUID.
		/// </summary>
		public const long mbIconId = 17179869184L;

		/// <summary>
		/// Member bit: FormSpec.
		/// </summary>
		public const long mbFormSpec = 34359738368L;

		protected int lnFormSpecValue;

		/// <summary>
		/// Member bit: NameTranslationKey
		/// </summary>
		public const long mbNameTranslationKey = 68719476736L;

		protected int lnNameTranslationKeyValue;

		/// <summary>
		/// Member bit: CommentTranslationKey
		/// </summary>
		public const long mbCommentTranslationKey = 137438953472L;

		protected int lnCommentTranslationKeyValue;

		/// <summary>
		/// Member bit: label
		/// </summary>
		public const long mbLabel = 274877906944L;

		protected int lnLabelValue;

		protected int lnLabelTranslationKeyValue;

		/// <summary>
		/// Member bit: properties
		/// </summary>
		public const long mbProperties = 549755813888L;

		protected int lnPropertiesValue;

		/// <summary>
		/// Member bit: departmentGroup
		/// </summary>
		public const long mbDepartmentGroup = 1099511627776L;

		/// <summary>
		/// Member bit: subFlowId
		/// </summary>
		public const long mbSubFlowId = 2199023255552L;

		/// <summary>
		/// Member bit: retVal
		/// </summary>
		public const long mbRetVal = 4398046511104L;

		/// <summary>
		/// reserved.
		/// </summary>
		public const long mbSubTemplateName = 8796093022208L;

		/// <summary>
		/// Member bit: subTemplateId
		/// </summary>
		public const long mbSubTemplateId = 8796093022208L;

		/// <summary>
		/// Member bit: labelTranslationKey
		/// </summary>
		public const long mbLabelTranslationKey = 17592186044416L;

		/// <summary>
		/// Member bit: returnValue
		/// </summary>
		public const long mbReturnValue = 35184372088832L;

		/// <summary>
		/// Member bit: returnValue
		/// </summary>
		public const long mbPrio = 70368744177664L;

		public const long mbEnterDateIso = 4L;

		public const long mbExitDateIso = 8L;

		public const long mbInUseDateIso = 16L;

		public const long mbTimeLimitIso = 512L;

		public const long mbUserName = 64L;

		public const long mbDelayDateIso = 268435456L;

		public const long mbUserDelayDateIso = 536870912L;

		/// <summary>
		/// All members.
		/// </summary>
		public const long mbAllMembers = 140737488355327L;

		/// <summary>
		/// All members.
		/// </summary>
		public readonly static EloixClient.IndexServer.WFNodeZ mbAll = new WFNodeZ(140737488355327L);

		/// <summary>
		/// Node flag: Only one user can receive this node.
		/// </summary>
		public const int FLAG_ONE_SUCCESSOR = 1;

		/// <summary>
		/// Node flag: The start node of an Adhoc workflow has this flag.
		/// </summary>
		public const int FLAG_ROOT_ADHOC = 1;

		/// <summary>
		/// Node flag: Not released.
		/// </summary>
		/// <remarks>
		/// A personal node of an Adhoc workflow has this flag
		/// set, if the user has not released the node.
		/// The IndexServer does not use this flag anywhere.
		/// </remarks>
		public const int FLAG_NOT_VALID = 2;

		/// <summary>
		/// Node flag: End of workflow.
		/// </summary>
		/// <remarks>
		/// This flag is set to the end node of an Adhoc workflow.
		/// The IndexServer does not need this flag but maybe the ELO Windows Client.
		/// </remarks>
		public const int FLAG_TERMINATE_USER = 4;

		/// <summary>
		/// Node flag: Reset the ExitDate of the following nodes, if this node is activated.
		/// </summary>
		public const int FLAG_RESET_CHILDREN = 8;

		/// <summary>
		/// Node flag: This flag denotes, whether a cycle node (TYPE_CYCLE) is the
		/// end of a cycle.
		/// </summary>
		public const int FLAG_CYCLE_END = 16;

		/// <summary>
		/// Node flag: This is a copied start node of a cylce.
		/// </summary>
		/// <remarks>
		/// Do not use this flag in
		/// workflow templates. The workflow engine will mark copied cycle.
		/// nodes with this flag.
		/// </remarks>
		public const int FLAG_CYCLE_X = 32;

		/// <summary>
		/// Node flag: This flag indicates that all nodes in the cycle should be copied
		/// when entering the begin cycle node.
		/// </summary>
		/// <remarks>
		/// This flag is only used for the begin
		/// cycle node.
		/// </remarks>
		public const int FLAG_COPY_CHILDREN = 5;

		/// <summary>
		/// Node flag: This flag indicates that weekend days should be skipped when
		/// evaluating time limits.
		/// </summary>
		public const int FLAG_WORKINGDAYS = 128;

		/// <summary>
		/// Node flag: Reset all person nodes.
		/// </summary>
		/// <remarks>
		/// This flag is only used for parallel for
		/// validation workflow.
		/// </remarks>
		public const int FLAG_RESETADHOCNODE = 512;

		/// <summary>
		/// Node flag: Hide this workflow from default searches and listings.
		/// </summary>
		public const int FLAG_HIDDEN = 1024;

		/// <summary>
		/// Node flag: This flag indicates whether the sub workflow can be started manually.
		/// </summary>
		/// <remarks>
		/// The sub workflow of. This flag is used for sub workflows.
		/// </remarks>
		public const int FLAG_DO_NOT_START_MANUALLY = 2048;

		/// <summary>
		/// Node flag: This flag indicates whether the person node was delegated.
		/// </summary>
		/// <remarks>
		/// This flag
		/// is only used for the person node.
		/// </remarks>
		public const int FLAG_DELEGATED = 4096;

		/// <summary>
		/// Node type: undefined or deleted
		/// </summary>
		public const int TYPE_NOTHING = 0;

		/// <summary>
		/// Node type: Start of workflow.
		/// </summary>
		public const int TYPE_BEGINNODE = 1;

		/// <summary>
		/// Node type: Personal node.
		/// </summary>
		/// <remarks>
		/// A user must edit the node to continue the workflow.
		/// </remarks>
		public const int TYPE_PERSONNODE = 2;

		/// <summary>
		/// Node type: Distribute to many following nodes.
		/// </summary>
		public const int TYPE_SPLITNODE = 3;

		/// <summary>
		/// Node type: Decision node.
		/// </summary>
		public const int TYPE_IFNODE = 4;

		/// <summary>
		/// Node type: Collects many workflow paths.
		/// </summary>
		public const int TYPE_COLLECTNODE = 5;

		/// <summary>
		/// Node type: End of workflow.
		/// </summary>
		public const int TYPE_ENDNODE = 6;

		/// <summary>
		/// Node type: Cycle
		/// Cycle nodes are contained in pairs in a workflow.
		/// </summary>
		/// <remarks>
		/// One cycle node denotes the
		/// beginning of a cycle and an associated cycle node marks the end. Both cycle
		/// nodes must have the same name (WFNode.name). The begin node must be flagged
		/// with FLAG_CYCLE_END.
		/// </remarks>
		public const int TYPE_CYCLE = 7;

		/// <summary>
		/// Note type: Set the server ID where the WF can be continued.
		/// </summary>
		/// <remarks>
		/// This node is used in replicated workflows.
		/// </remarks>
		public const int TYPE_SET_SERVER_ID = 8;

		/// <summary>
		/// Note type: Call sub workflow.
		/// </summary>
		public const int TYPE_CALL_SUB_WORKFLOW = 9;

		/// <summary>
		/// Set WFNode.userId to this value, if a workflow node should belong to the
		/// owner of the associated Sord object.
		/// </summary>
		public const int USERID_OWNER = -2;

		/// <summary>
		/// This value can be used in Node.department2 to make clear,
		/// that Node.department2 has to be ignored.
		/// </summary>
		public const int USERID_IGNORE = -3;

		/// <summary>
		/// This ID is a placeholder for the superior of the
		/// workflow owner.
		/// </summary>
		public const int USERID_SUPERIOR = -4;

		/// <summary>
		/// Indicates that all predecessor of the collect node should be terminated.
		/// </summary>
		public const String DEACTIVATE_ALL_PREDS = "All Preds";

		#endregion
		
		
		public static readonly long serialVersionUID = 1514069164L;		
	} // end class
}  // end namespace

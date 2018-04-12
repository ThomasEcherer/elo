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
	/// <p>Bit constants for members of WorkFlowActiveDoc</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class WorkFlowActiveDocC : BSerializable
	{
	
		#region Constructors
		
		public WorkFlowActiveDocC() {
		}		
		
		public WorkFlowActiveDocC(int @lnFlowName, int @lnName, int @lnYNCondition, int @lnCondition, int @lnComment, int @lnOnActivate, int @lnOnTerminate, int @lnUserTerminate, int @lnVersionName, int @lnNextServerId, int @lnVersionTag, int @lnIconId, int @lnFormSpec, int @lnFlowNameTranslationKey, int @lnNameTranslationKey, int @lnCommentTranslationKey, int @lnLabel, int @lnProperties, int @lnReturnValue, int @lnLabelTranslationKey) {
			this.lnFlowNameValue = @lnFlowName;
			this.lnNameValue = @lnName;
			this.lnYNConditionValue = @lnYNCondition;
			this.lnConditionValue = @lnCondition;
			this.lnCommentValue = @lnComment;
			this.lnOnActivateValue = @lnOnActivate;
			this.lnOnTerminateValue = @lnOnTerminate;
			this.lnUserTerminateValue = @lnUserTerminate;
			this.lnVersionNameValue = @lnVersionName;
			this.lnNextServerIdValue = @lnNextServerId;
			this.lnVersionTagValue = @lnVersionTag;
			this.lnIconIdValue = @lnIconId;
			this.lnFormSpecValue = @lnFormSpec;
			this.lnFlowNameTranslationKeyValue = @lnFlowNameTranslationKey;
			this.lnNameTranslationKeyValue = @lnNameTranslationKey;
			this.lnCommentTranslationKeyValue = @lnCommentTranslationKey;
			this.lnLabelValue = @lnLabel;
			this.lnPropertiesValue = @lnProperties;
			this.lnReturnValueValue = @lnReturnValue;
			this.lnLabelTranslationKeyValue = @lnLabelTranslationKey;
		}		
		
		public WorkFlowActiveDocC(WorkFlowActiveDocC rhs)
		{
			this.lnFlowNameValue = rhs.lnFlowNameValue;
			this.lnNameValue = rhs.lnNameValue;
			this.lnYNConditionValue = rhs.lnYNConditionValue;
			this.lnConditionValue = rhs.lnConditionValue;
			this.lnCommentValue = rhs.lnCommentValue;
			this.lnOnActivateValue = rhs.lnOnActivateValue;
			this.lnOnTerminateValue = rhs.lnOnTerminateValue;
			this.lnUserTerminateValue = rhs.lnUserTerminateValue;
			this.lnVersionNameValue = rhs.lnVersionNameValue;
			this.lnNextServerIdValue = rhs.lnNextServerIdValue;
			this.lnVersionTagValue = rhs.lnVersionTagValue;
			this.lnIconIdValue = rhs.lnIconIdValue;
			this.lnFormSpecValue = rhs.lnFormSpecValue;
			this.lnFlowNameTranslationKeyValue = rhs.lnFlowNameTranslationKeyValue;
			this.lnNameTranslationKeyValue = rhs.lnNameTranslationKeyValue;
			this.lnCommentTranslationKeyValue = rhs.lnCommentTranslationKeyValue;
			this.lnLabelValue = rhs.lnLabelValue;
			this.lnPropertiesValue = rhs.lnPropertiesValue;
			this.lnReturnValueValue = rhs.lnReturnValueValue;
			this.lnLabelTranslationKeyValue = rhs.lnLabelTranslationKeyValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: wf_flow_name
		/// </summary>
		public int lnFlowName
		{
			get
			{
				return lnFlowNameValue;
			}
			set
			{
				this.lnFlowNameValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_name
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
		/// DB column: wf_yesnocondition
		/// </summary>
		public int lnYNCondition
		{
			get
			{
				return lnYNConditionValue;
			}
			set
			{
				this.lnYNConditionValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_condition
		/// </summary>
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
		/// DB column: wf_comment
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
		
		
		/// <summary>
		/// DB column: wf_ev_on_activate
		/// </summary>
		public int lnOnActivate
		{
			get
			{
				return lnOnActivateValue;
			}
			set
			{
				this.lnOnActivateValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_ev_on_terminate
		/// </summary>
		public int lnOnTerminate
		{
			get
			{
				return lnOnTerminateValue;
			}
			set
			{
				this.lnOnTerminateValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_userterminate
		/// </summary>
		public int lnUserTerminate
		{
			get
			{
				return lnUserTerminateValue;
			}
			set
			{
				this.lnUserTerminateValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Version comment.
		/// </summary>
		/// <remarks>
		/// DB column: wf_version_name
		/// </remarks>
		public int lnVersionName
		{
			get
			{
				return lnVersionNameValue;
			}
			set
			{
				this.lnVersionNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Next server name.
		/// </summary>
		/// <remarks>
		/// This value is used in replication environments
		/// DB column: nextserverid
		/// </remarks>
		public int lnNextServerId
		{
			get
			{
				return lnNextServerIdValue;
			}
			set
			{
				this.lnNextServerIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Version number.
		/// </summary>
		/// <remarks>
		/// DB column: wf_version_tag
		/// </remarks>
		public int lnVersionTag
		{
			get
			{
				return lnVersionTagValue;
			}
			set
			{
				this.lnVersionTagValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Object-GUID of an icon file that is displayed in the designer.
		/// </summary>
		/// <remarks>
		/// DB column: wf_icon_guid
		/// </remarks>
		public int lnIconId
		{
			get
			{
				return lnIconIdValue;
			}
			set
			{
				this.lnIconIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: User defined data to be stored in the database.
		/// </summary>
		/// <remarks>
		/// DB column: wf_form_spec
		/// </remarks>
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
		/// Column length: Translation-keyword for {@link WFDiagram#name}.
		/// </summary>
		/// <remarks>
		/// DB column: wf_flownametrkey
		/// </remarks>
		public int lnFlowNameTranslationKey
		{
			get
			{
				return lnFlowNameTranslationKeyValue;
			}
			set
			{
				this.lnFlowNameTranslationKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Translation-keyword for {@link WFNode#name}.
		/// </summary>
		/// <remarks>
		/// DB column: wf_nametrkey
		/// </remarks>
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
		/// Column length: Translation-keyword for {@link WFNode#comment}.
		/// </summary>
		/// <remarks>
		/// DB column: wf_commenttrkey
		/// </remarks>
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
		/// Column length: Display name by forwarding.
		/// </summary>
		/// <remarks>
		/// DB column: wf_label
		/// </remarks>
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
		/// Column length: Properties field of node.
		/// </summary>
		/// <remarks>
		/// DB column: wf_properties
		/// </remarks>
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
		
		
		/// <summary>
		/// Column length: Return value of an end node.
		/// </summary>
		/// <remarks>
		/// DB column: wf_returnvalue
		/// </remarks>
		public int lnReturnValue
		{
			get
			{
				return lnReturnValueValue;
			}
			set
			{
				this.lnReturnValueValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_labeltrkey
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
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: wf_flowid
		/// </summary>
		public const long mbFlowId = 1L;

		/// <summary>
		/// DB column: wf_nodeid
		/// </summary>
		public const long mbNodeId = 2L;

		/// <summary>
		/// DB column: wf_flow_name
		/// </summary>
		public const long mbFlowName = 4L;

		protected int lnFlowNameValue;

		/// <summary>
		/// DB column: wf_name
		/// </summary>
		public const long mbName = 8L;

		protected int lnNameValue;

		/// <summary>
		/// DB column: wf_node_type
		/// </summary>
		public const long mbNodeType = 16L;

		/// <summary>
		/// DB column: wf_department
		/// </summary>
		public const long mbDepartment = 32L;

		/// <summary>
		/// DB column: wf_alert_to
		/// </summary>
		public const long mbAlertTo = 64L;

		/// <summary>
		/// DB column: wf_alert_from_begin
		/// </summary>
		public const long mbAlertFromBegin = 128L;

		/// <summary>
		/// DB column: wf_alert_wait
		/// </summary>
		public const long mbAlertWait = 256L;

		/// <summary>
		/// DB column: wf_yesnocondition
		/// </summary>
		public const long mbYNCondition = 512L;

		protected int lnYNConditionValue;

		/// <summary>
		/// DB column: wf_condition
		/// </summary>
		public const long mbCondition = 1024L;

		protected int lnConditionValue;

		/// <summary>
		/// DB column: wf_comment
		/// </summary>
		public const long mbComment = 2048L;

		protected int lnCommentValue;

		/// <summary>
		/// DB column: wf_locked
		/// </summary>
		public const long mbLocked = 4096L;

		/// <summary>
		/// DB column: pos_x
		/// </summary>
		public const long mbPosX = 8192L;

		/// <summary>
		/// DB column: pos_y
		/// </summary>
		public const long mbPosY = 16384L;

		/// <summary>
		/// DB column: wf_ev_on_activate
		/// </summary>
		public const long mbOnActivate = 32768L;

		protected int lnOnActivateValue;

		/// <summary>
		/// DB column: wf_ev_on_terminate
		/// </summary>
		public const long mbOnTerminate = 65536L;

		protected int lnOnTerminateValue;

		/// <summary>
		/// DB column: wf_nodeflags
		/// </summary>
		public const long mbNodeFlags = 131072L;

		/// <summary>
		/// DB column: wf_eloobjid
		/// </summary>
		public const long mbEloObjId = 262144L;

		/// <summary>
		/// DB column: wf_locked_owner
		/// </summary>
		public const long mbLockId = 524288L;

		/// <summary>
		/// DB column: wf_is_next
		/// </summary>
		public const long mbIsNext = 1048576L;

		/// <summary>
		/// DB column: wf_activate
		/// </summary>
		public const long mbActivate = 2097152L;

		/// <summary>
		/// DB column: wf_terminate
		/// </summary>
		public const long mbTerminate = 4194304L;

		/// <summary>
		/// DB column: wf_in_use_date
		/// </summary>
		public const long mbInUseDate = 8388608L;

		/// <summary>
		/// DB column: wf_completion_date
		/// </summary>
		public const long mbCompletionDate = 16777216L;

		/// <summary>
		/// DB column: wf_template
		/// </summary>
		public const long mbTemplateId = 33554432L;

		/// <summary>
		/// DB column: wf_userterminate
		/// </summary>
		public const long mbUserTerminate = 67108864L;

		protected int lnUserTerminateValue;

		/// <summary>
		/// DB column: wf_tag
		/// </summary>
		public const long mbTag = 134217728L;

		/// <summary>
		/// DB column: wf_designdepartment
		/// </summary>
		public const long mbDesignDepartment = 268435456L;

		/// <summary>
		/// DB column: wf_dx
		/// </summary>
		public const long mbMoveCyclePosX = 536870912L;

		/// <summary>
		/// DB column: wf_department2
		/// </summary>
		public const long mbDepartment2 = 1073741824L;

		/// <summary>
		/// DB column: wf_delaydays
		/// </summary>
		public const long mbDelayDays = 2147483648L;

		/// <summary>
		/// DB column: wf_duedate
		/// </summary>
		public const long mbDelayDate = 4294967296L;

		/// <summary>
		/// DB column: wf_deleted
		/// </summary>
		public const long mbDeleted = 8589934592L;

		/// <summary>
		/// DB column: wf_prio
		/// </summary>
		public const long mbPrio = 17179869184L;

		/// <summary>
		/// Member bit: The workflow node is deferred until this date.
		/// </summary>
		/// <remarks>
		/// DB column: wf_user_delaydate
		/// </remarks>
		public const long mbUserDelayDate = 34359738368L;

		/// <summary>
		/// Member bit: Version ID.
		/// </summary>
		/// <remarks>
		/// DB column: wf_version
		/// </remarks>
		public const long mbVersionId = 68719476736L;

		/// <summary>
		/// Member bit: Version comment.
		/// </summary>
		/// <remarks>
		/// DB column: wf_version_name
		/// </remarks>
		public const long mbVersionName = 137438953472L;

		protected int lnVersionNameValue;

		/// <summary>
		/// Member bit: ID of user who should be informed,
		/// DB column: wf_alert_to2
		/// </summary>
		public const long mbAlertTo2 = 274877906944L;

		/// <summary>
		/// Member bit: Second Time-limit for a person node or begin node.
		/// </summary>
		/// <remarks>
		/// DB column: wf_alert_wait2
		/// </remarks>
		public const long mbAlertWait2 = 549755813888L;

		/// <summary>
		/// Member bit: ID of user who should be informed,
		/// DB column: wf_alert_to3
		/// </summary>
		public const long mbAlertTo3 = 1099511627776L;

		/// <summary>
		/// Member bit: Third Time-limit for a person node or begin node.
		/// </summary>
		/// <remarks>
		/// DB column: wf_alert_wait3
		/// </remarks>
		public const long mbAlertWait3 = 2199023255552L;

		/// <summary>
		/// Member bit: Next server name.
		/// </summary>
		/// <remarks>
		/// This value is used in replication environments
		/// DB column: nextserverid
		/// </remarks>
		public const long mbNextServerId = 4398046511104L;

		protected int lnNextServerIdValue;

		/// <summary>
		/// Member bit: Version number.
		/// </summary>
		/// <remarks>
		/// DB column: wf_version_tag
		/// </remarks>
		public const long mbVersionTag = 8796093022208L;

		protected int lnVersionTagValue;

		/// <summary>
		/// Member bit: ID of the user who created the workflow version.
		/// </summary>
		/// <remarks>
		/// DB column: wf_version_userid
		/// </remarks>
		public const long mbVersionUserId = 17592186044416L;

		/// <summary>
		/// Member bit: ID of the user who created the workflow version.
		/// </summary>
		/// <remarks>
		/// DB column: wf_version_createdate
		/// </remarks>
		public const long mbVersionCreateDate = 35184372088832L;

		/// <summary>
		/// Member bit: Object-GUID of an icon file that is displayed in the designer.
		/// </summary>
		/// <remarks>
		/// DB column: wf_icon_guid
		/// </remarks>
		public const long mbIconId = 70368744177664L;

		protected int lnIconIdValue;

		/// <summary>
		/// Member bit: User defined data to be stored in the database.
		/// </summary>
		/// <remarks>
		/// DB column: wf_form_spec
		/// </remarks>
		public const long mbFormSpec = 140737488355328L;

		protected int lnFormSpecValue;

		/// <summary>
		/// Member bit: Translation-keyword for {@link WFDiagram#name}.
		/// </summary>
		/// <remarks>
		/// DB column: wf_flownametrkey
		/// </remarks>
		public const long mbFlowNameTranslationKey = 281474976710656L;

		protected int lnFlowNameTranslationKeyValue;

		/// <summary>
		/// Member bit: Translation-keyword for {@link WFNode#name}.
		/// </summary>
		/// <remarks>
		/// DB column: wf_nametrkey
		/// </remarks>
		public const long mbNameTranslationKey = 562949953421312L;

		protected int lnNameTranslationKeyValue;

		/// <summary>
		/// Member bit: Translation-keyword for {@link WFNode#comment}.
		/// </summary>
		/// <remarks>
		/// DB column: wf_commenttrkey
		/// </remarks>
		public const long mbCommentTranslationKey = 1125899906842624L;

		protected int lnCommentTranslationKeyValue;

		/// <summary>
		/// Member bit: Display name by forwarding.
		/// </summary>
		/// <remarks>
		/// DB column: wf_label
		/// </remarks>
		public const long mbLabel = 2251799813685248L;

		protected int lnLabelValue;

		/// <summary>
		/// Member bit: Properties field of node.
		/// </summary>
		/// <remarks>
		/// DB column: wf_properties
		/// </remarks>
		public const long mbProperties = 4503599627370496L;

		protected int lnPropertiesValue;

		/// <summary>
		/// Member bit: Grouping of nodes for function takeWorkFlowNode.
		/// </summary>
		/// <remarks>
		/// DB column: wf_departmentgroup
		/// </remarks>
		public const long mbDepartmentGroup = 9007199254740992L;

		/// <summary>
		/// Member bit: Return value of an end node.
		/// </summary>
		/// <remarks>
		/// DB column: wf_retval
		/// </remarks>
		public const long mbRetVal = 18014398509481984L;

		/// <summary>
		/// Member bit: Return value of an end node.
		/// </summary>
		/// <remarks>
		/// DB column: wf_returnvalue
		/// </remarks>
		public const long mbReturnValue = 36028797018963968L;

		protected int lnReturnValueValue;

		/// <summary>
		/// Member bit: ID of the active sub-workflow.
		/// </summary>
		/// <remarks>
		/// DB column: wf_sub_wf
		/// </remarks>
		public const long mbSubWorkflow = 72057594037927936L;

		/// <summary>
		/// DB column: wf_labeltrkey
		/// </summary>
		public const long mbLabelTranslationKey = 144115188075855872L;

		protected int lnLabelTranslationKeyValue;

		/// <summary>
		/// Member bit: ID of the sub-workflow template.
		/// </summary>
		/// <remarks>
		/// DB column: wf_sub_wf_templ
		/// </remarks>
		public const long mbSubWorkflowTemplate = 288230376151711744L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 576460752303423487L;

		#endregion
		
		
		public static readonly long serialVersionUID = 509854692L;		
	} // end class
}  // end namespace

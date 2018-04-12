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
	/// Internal class.
	/// </summary>
	public class WorkFlowActiveDoc : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WorkFlowActiveDoc() {
		}		
		
		public WorkFlowActiveDoc(int @flowId, int @nodeId, String @flowName, String @name, int @nodeType, int @succType, int @department, int @alertTo, int @alertFromBegin, int @alertWait, String @yNCondition, String @condition, String @comment, int @succ_0, int @succ_1, int @succ_2, int @succ_3, int @succ_4, int @succ_5, int @succ_6, int @succ_7, int @succ_8, int @succ_9, int @succ_10, int @succ_11, int @succ_12, int @succ_13, int @succ_14, int @succ_15, int @succ_16, int @succ_17, int @succ_18, int @succ_19, int @locked, int @posX, int @posY, String @onActivate, String @onTerminate, int @nodeFlags, int @eloObjId, int @lockId, int @isNext, int @activate, int @terminate, int @inUseDate, int @completionDate, int @templateId, String @userTerminate, int @tag, int @designDepartment, int @moveCyclePosX, int @department2, int @delayDays, int @delayDate, int @deleted, int @prio, int @userDelayDate, int @versionId, String @versionName, int @alertTo2, int @alertWait2, int @alertTo3, int @alertWait3, String @nextServerId, String @versionTag, int @versionUserId, int @versionCreateDate, String @iconId, String @formSpec, String @flowNameTranslationKey, String @nameTranslationKey, String @commentTranslationKey, String @label, String @properties, int @departmentGroup, int @retVal, String @returnValue, int @subWorkflow, String @labelTranslationKey, int @subWorkflowTemplate) {
			this.flowIdValue = @flowId;
			this.nodeIdValue = @nodeId;
			this.flowNameValue = @flowName;
			this.nameValue = @name;
			this.nodeTypeValue = @nodeType;
			this.succTypeValue = @succType;
			this.departmentValue = @department;
			this.alertToValue = @alertTo;
			this.alertFromBeginValue = @alertFromBegin;
			this.alertWaitValue = @alertWait;
			this.yNConditionValue = @yNCondition;
			this.conditionValue = @condition;
			this.commentValue = @comment;
			this.succ_0Value = @succ_0;
			this.succ_1Value = @succ_1;
			this.succ_2Value = @succ_2;
			this.succ_3Value = @succ_3;
			this.succ_4Value = @succ_4;
			this.succ_5Value = @succ_5;
			this.succ_6Value = @succ_6;
			this.succ_7Value = @succ_7;
			this.succ_8Value = @succ_8;
			this.succ_9Value = @succ_9;
			this.succ_10Value = @succ_10;
			this.succ_11Value = @succ_11;
			this.succ_12Value = @succ_12;
			this.succ_13Value = @succ_13;
			this.succ_14Value = @succ_14;
			this.succ_15Value = @succ_15;
			this.succ_16Value = @succ_16;
			this.succ_17Value = @succ_17;
			this.succ_18Value = @succ_18;
			this.succ_19Value = @succ_19;
			this.lockedValue = @locked;
			this.posXValue = @posX;
			this.posYValue = @posY;
			this.onActivateValue = @onActivate;
			this.onTerminateValue = @onTerminate;
			this.nodeFlagsValue = @nodeFlags;
			this.eloObjIdValue = @eloObjId;
			this.lockIdValue = @lockId;
			this.isNextValue = @isNext;
			this.activateValue = @activate;
			this.terminateValue = @terminate;
			this.inUseDateValue = @inUseDate;
			this.completionDateValue = @completionDate;
			this.templateIdValue = @templateId;
			this.userTerminateValue = @userTerminate;
			this.tagValue = @tag;
			this.designDepartmentValue = @designDepartment;
			this.moveCyclePosXValue = @moveCyclePosX;
			this.department2Value = @department2;
			this.delayDaysValue = @delayDays;
			this.delayDateValue = @delayDate;
			this.deletedValue = @deleted;
			this.prioValue = @prio;
			this.userDelayDateValue = @userDelayDate;
			this.versionIdValue = @versionId;
			this.versionNameValue = @versionName;
			this.alertTo2Value = @alertTo2;
			this.alertWait2Value = @alertWait2;
			this.alertTo3Value = @alertTo3;
			this.alertWait3Value = @alertWait3;
			this.nextServerIdValue = @nextServerId;
			this.versionTagValue = @versionTag;
			this.versionUserIdValue = @versionUserId;
			this.versionCreateDateValue = @versionCreateDate;
			this.iconIdValue = @iconId;
			this.formSpecValue = @formSpec;
			this.flowNameTranslationKeyValue = @flowNameTranslationKey;
			this.nameTranslationKeyValue = @nameTranslationKey;
			this.commentTranslationKeyValue = @commentTranslationKey;
			this.labelValue = @label;
			this.propertiesValue = @properties;
			this.departmentGroupValue = @departmentGroup;
			this.retValValue = @retVal;
			this.returnValueValue = @returnValue;
			this.subWorkflowValue = @subWorkflow;
			this.labelTranslationKeyValue = @labelTranslationKey;
			this.subWorkflowTemplateValue = @subWorkflowTemplate;
		}		
		
		public WorkFlowActiveDoc(WorkFlowActiveDoc rhs) : base(rhs)
		{
			this.flowIdValue = rhs.flowIdValue;
			this.nodeIdValue = rhs.nodeIdValue;
			this.flowNameValue = rhs.flowNameValue;
			this.nameValue = rhs.nameValue;
			this.nodeTypeValue = rhs.nodeTypeValue;
			this.succTypeValue = rhs.succTypeValue;
			this.departmentValue = rhs.departmentValue;
			this.alertToValue = rhs.alertToValue;
			this.alertFromBeginValue = rhs.alertFromBeginValue;
			this.alertWaitValue = rhs.alertWaitValue;
			this.yNConditionValue = rhs.yNConditionValue;
			this.conditionValue = rhs.conditionValue;
			this.commentValue = rhs.commentValue;
			this.succ_0Value = rhs.succ_0Value;
			this.succ_1Value = rhs.succ_1Value;
			this.succ_2Value = rhs.succ_2Value;
			this.succ_3Value = rhs.succ_3Value;
			this.succ_4Value = rhs.succ_4Value;
			this.succ_5Value = rhs.succ_5Value;
			this.succ_6Value = rhs.succ_6Value;
			this.succ_7Value = rhs.succ_7Value;
			this.succ_8Value = rhs.succ_8Value;
			this.succ_9Value = rhs.succ_9Value;
			this.succ_10Value = rhs.succ_10Value;
			this.succ_11Value = rhs.succ_11Value;
			this.succ_12Value = rhs.succ_12Value;
			this.succ_13Value = rhs.succ_13Value;
			this.succ_14Value = rhs.succ_14Value;
			this.succ_15Value = rhs.succ_15Value;
			this.succ_16Value = rhs.succ_16Value;
			this.succ_17Value = rhs.succ_17Value;
			this.succ_18Value = rhs.succ_18Value;
			this.succ_19Value = rhs.succ_19Value;
			this.lockedValue = rhs.lockedValue;
			this.posXValue = rhs.posXValue;
			this.posYValue = rhs.posYValue;
			this.onActivateValue = rhs.onActivateValue;
			this.onTerminateValue = rhs.onTerminateValue;
			this.nodeFlagsValue = rhs.nodeFlagsValue;
			this.eloObjIdValue = rhs.eloObjIdValue;
			this.lockIdValue = rhs.lockIdValue;
			this.isNextValue = rhs.isNextValue;
			this.activateValue = rhs.activateValue;
			this.terminateValue = rhs.terminateValue;
			this.inUseDateValue = rhs.inUseDateValue;
			this.completionDateValue = rhs.completionDateValue;
			this.templateIdValue = rhs.templateIdValue;
			this.userTerminateValue = rhs.userTerminateValue;
			this.tagValue = rhs.tagValue;
			this.designDepartmentValue = rhs.designDepartmentValue;
			this.moveCyclePosXValue = rhs.moveCyclePosXValue;
			this.department2Value = rhs.department2Value;
			this.delayDaysValue = rhs.delayDaysValue;
			this.delayDateValue = rhs.delayDateValue;
			this.deletedValue = rhs.deletedValue;
			this.prioValue = rhs.prioValue;
			this.userDelayDateValue = rhs.userDelayDateValue;
			this.versionIdValue = rhs.versionIdValue;
			this.versionNameValue = rhs.versionNameValue;
			this.alertTo2Value = rhs.alertTo2Value;
			this.alertWait2Value = rhs.alertWait2Value;
			this.alertTo3Value = rhs.alertTo3Value;
			this.alertWait3Value = rhs.alertWait3Value;
			this.nextServerIdValue = rhs.nextServerIdValue;
			this.versionTagValue = rhs.versionTagValue;
			this.versionUserIdValue = rhs.versionUserIdValue;
			this.versionCreateDateValue = rhs.versionCreateDateValue;
			this.iconIdValue = rhs.iconIdValue;
			this.formSpecValue = rhs.formSpecValue;
			this.flowNameTranslationKeyValue = rhs.flowNameTranslationKeyValue;
			this.nameTranslationKeyValue = rhs.nameTranslationKeyValue;
			this.commentTranslationKeyValue = rhs.commentTranslationKeyValue;
			this.labelValue = rhs.labelValue;
			this.propertiesValue = rhs.propertiesValue;
			this.departmentGroupValue = rhs.departmentGroupValue;
			this.retValValue = rhs.retValValue;
			this.returnValueValue = rhs.returnValueValue;
			this.subWorkflowValue = rhs.subWorkflowValue;
			this.labelTranslationKeyValue = rhs.labelTranslationKeyValue;
			this.subWorkflowTemplateValue = rhs.subWorkflowTemplateValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Workflow ID.
		/// </summary>
		/// <remarks>
		/// DB column: wf_flowid
		/// </remarks>
		public int flowId
		{
			get
			{
				return flowIdValue;
			}
			set
			{
				this.flowIdValue = value;
				setChangedMember(WorkFlowActiveDocC.mbFlowId);
			}
		}
		
		
		/// <summary>
		/// Node ID.
		/// </summary>
		/// <remarks>
		/// DB column: wf_nodeid
		/// </remarks>
		public int nodeId
		{
			get
			{
				return nodeIdValue;
			}
			set
			{
				this.nodeIdValue = value;
				setChangedMember(WorkFlowActiveDocC.mbNodeId);
			}
		}
		
		
		/// <summary>
		/// Workflow name.
		/// </summary>
		/// <remarks>
		/// DB column: wf_flow_name
		/// </remarks>
		public String flowName
		{
			get
			{
				return flowNameValue;
			}
			set
			{
				this.flowNameValue = value;
				setChangedMember(WorkFlowActiveDocC.mbFlowName);
			}
		}
		
		
		/// <summary>
		/// Node name (work instruction).
		/// </summary>
		/// <remarks>
		/// DB column: wf_name
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
				setChangedMember(WorkFlowActiveDocC.mbName);
			}
		}
		
		
		/// <summary>
		/// Node type (begin node, split node, etc.).
		/// </summary>
		/// <remarks>
		/// DB column: wf_node_type
		/// </remarks>
		public int nodeType
		{
			get
			{
				return nodeTypeValue;
			}
			set
			{
				this.nodeTypeValue = value;
				setChangedMember(WorkFlowActiveDocC.mbNodeType);
			}
		}
		
		
		/// <summary>
		/// This value depends on the node type and is not processed anymore by IndexServer.
		/// </summary>
		/// <remarks>
		/// It is written for compability with workflows of older CLIENT versions.
		/// DB column: wf_succ_type
		/// </remarks>
		public int succType
		{
			get
			{
				return succTypeValue;
			}
			set
			{
				this.succTypeValue = value;
			}
		}
		
		
		/// <summary>
		/// ID of user who has to process the node.
		/// </summary>
		/// <remarks>
		/// Might
		/// be a group ID too. Only valid for person nodes.
		/// DB column: wf_department
		/// </remarks>
		public int department
		{
			get
			{
				return departmentValue;
			}
			set
			{
				this.departmentValue = value;
				setChangedMember(WorkFlowActiveDocC.mbDepartment);
			}
		}
		
		
		/// <summary>
		/// ID of user who should be informed, if a time-limit exceeds.
		/// </summary>
		/// <remarks>
		/// It might be
		/// the time-limit for the entire workflow or for a signle person node.
		/// DB column: wf_alert_to
		/// </remarks>
		public int alertTo
		{
			get
			{
				return alertToValue;
			}
			set
			{
				this.alertToValue = value;
				setChangedMember(WorkFlowActiveDocC.mbAlertTo);
			}
		}
		
		
		/// <summary>
		/// Time-limt for the entire workflow in minutes.
		/// </summary>
		/// <remarks>
		/// This value is only valid for
		/// the begin node.
		/// DB column: wf_alert_from_begin
		/// </remarks>
		public int alertFromBegin
		{
			get
			{
				return alertFromBeginValue;
			}
			set
			{
				this.alertFromBeginValue = value;
				setChangedMember(WorkFlowActiveDocC.mbAlertFromBegin);
			}
		}
		
		
		/// <summary>
		/// Time-limit for a single node.
		/// </summary>
		/// <remarks>
		/// This value is only valid for person nodes.
		/// DB column: wf_alert_wait
		/// </remarks>
		public int alertWait
		{
			get
			{
				return alertWaitValue;
			}
			set
			{
				this.alertWaitValue = value;
				setChangedMember(WorkFlowActiveDocC.mbAlertWait);
			}
		}
		
		
		/// <summary>
		/// IF-Nodes: test condition,
		/// person nodes: index values or scripts,
		/// split nodes: workflow status.
		/// </summary>
		/// <remarks>
		/// DB column: wf_yesnocondition
		/// </remarks>
		public String yNCondition
		{
			get
			{
				return yNConditionValue;
			}
			set
			{
				this.yNConditionValue = value;
				setChangedMember(WorkFlowActiveDocC.mbYNCondition);
			}
		}
		
		
		/// <summary>
		/// Contains the ACL of the workflow.
		/// </summary>
		/// <remarks>
		/// Only valid for begin nodes.
		/// DB column: wf_condition
		/// </remarks>
		public String condition
		{
			get
			{
				return conditionValue;
			}
			set
			{
				this.conditionValue = value;
				setChangedMember(WorkFlowActiveDocC.mbCondition);
			}
		}
		
		
		/// <summary>
		/// Comment, only valid for person nodes.
		/// </summary>
		/// <remarks>
		/// DB column: wf_comment
		/// </remarks>
		public String comment
		{
			get
			{
				return commentValue;
			}
			set
			{
				this.commentValue = value;
				setChangedMember(WorkFlowActiveDocC.mbComment);
			}
		}
		
		
		/// <summary>
		/// Successor node(s) succ_0 ...
		/// </summary>
		/// <remarks>
		/// Succ 19
		/// DB column: wf_succ_0
		/// This mebers are moved into WorkFlowNodeMatrix.
		/// They are still here due to compatibiltiy with older stream versions.
		/// </remarks>
		public int succ_0
		{
			get
			{
				return succ_0Value;
			}
			set
			{
				this.succ_0Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_1
		/// </summary>
		public int succ_1
		{
			get
			{
				return succ_1Value;
			}
			set
			{
				this.succ_1Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_2
		/// </summary>
		public int succ_2
		{
			get
			{
				return succ_2Value;
			}
			set
			{
				this.succ_2Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_3
		/// </summary>
		public int succ_3
		{
			get
			{
				return succ_3Value;
			}
			set
			{
				this.succ_3Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_4
		/// </summary>
		public int succ_4
		{
			get
			{
				return succ_4Value;
			}
			set
			{
				this.succ_4Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_5
		/// </summary>
		public int succ_5
		{
			get
			{
				return succ_5Value;
			}
			set
			{
				this.succ_5Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_6
		/// </summary>
		public int succ_6
		{
			get
			{
				return succ_6Value;
			}
			set
			{
				this.succ_6Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_7
		/// </summary>
		public int succ_7
		{
			get
			{
				return succ_7Value;
			}
			set
			{
				this.succ_7Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_8
		/// </summary>
		public int succ_8
		{
			get
			{
				return succ_8Value;
			}
			set
			{
				this.succ_8Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_9
		/// </summary>
		public int succ_9
		{
			get
			{
				return succ_9Value;
			}
			set
			{
				this.succ_9Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_10
		/// </summary>
		public int succ_10
		{
			get
			{
				return succ_10Value;
			}
			set
			{
				this.succ_10Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_11
		/// </summary>
		public int succ_11
		{
			get
			{
				return succ_11Value;
			}
			set
			{
				this.succ_11Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_12
		/// </summary>
		public int succ_12
		{
			get
			{
				return succ_12Value;
			}
			set
			{
				this.succ_12Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_13
		/// </summary>
		public int succ_13
		{
			get
			{
				return succ_13Value;
			}
			set
			{
				this.succ_13Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_14
		/// </summary>
		public int succ_14
		{
			get
			{
				return succ_14Value;
			}
			set
			{
				this.succ_14Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_15
		/// </summary>
		public int succ_15
		{
			get
			{
				return succ_15Value;
			}
			set
			{
				this.succ_15Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_16
		/// </summary>
		public int succ_16
		{
			get
			{
				return succ_16Value;
			}
			set
			{
				this.succ_16Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_17
		/// </summary>
		public int succ_17
		{
			get
			{
				return succ_17Value;
			}
			set
			{
				this.succ_17Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_18
		/// </summary>
		public int succ_18
		{
			get
			{
				return succ_18Value;
			}
			set
			{
				this.succ_18Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_succ_19
		/// </summary>
		public int succ_19
		{
			get
			{
				return succ_19Value;
			}
			set
			{
				this.succ_19Value = value;
			}
		}
		
		
		/// <summary>
		/// If node is locked, it contains 1 otherwise 0
		/// DB column: wf_locked
		/// </summary>
		public int locked
		{
			get
			{
				return lockedValue;
			}
			set
			{
				this.lockedValue = value;
				setChangedMember(WorkFlowActiveDocC.mbLocked);
			}
		}
		
		
		/// <summary>
		/// Node X position in designer view.
		/// </summary>
		/// <remarks>
		/// DB column: pos_x
		/// </remarks>
		public int posX
		{
			get
			{
				return posXValue;
			}
			set
			{
				this.posXValue = value;
				setChangedMember(WorkFlowActiveDocC.mbPosX);
			}
		}
		
		
		/// <summary>
		/// Node Y position in designer view.
		/// </summary>
		/// <remarks>
		/// DB column: pos_y
		/// </remarks>
		public int posY
		{
			get
			{
				return posYValue;
			}
			set
			{
				this.posYValue = value;
				setChangedMember(WorkFlowActiveDocC.mbPosY);
			}
		}
		
		
		/// <summary>
		/// Name of script to be executed, if the node is activated (entered).
		/// </summary>
		/// <remarks>
		/// DB column: wf_ev_on_activate
		/// </remarks>
		public String onActivate
		{
			get
			{
				return onActivateValue;
			}
			set
			{
				this.onActivateValue = value;
				setChangedMember(WorkFlowActiveDocC.mbOnActivate);
			}
		}
		
		
		/// <summary>
		/// Name of script to be executed, if the node is leaved (exited).
		/// </summary>
		/// <remarks>
		/// DB column: wf_ev_on_terminate
		/// </remarks>
		public String onTerminate
		{
			get
			{
				return onTerminateValue;
			}
			set
			{
				this.onTerminateValue = value;
				setChangedMember(WorkFlowActiveDocC.mbOnTerminate);
			}
		}
		
		
		/// <summary>
		/// Node flags.
		/// </summary>
		/// <remarks>
		/// DB column: wf_nodeflags
		/// </remarks>
		public int nodeFlags
		{
			get
			{
				return nodeFlagsValue;
			}
			set
			{
				this.nodeFlagsValue = value;
				setChangedMember(WorkFlowActiveDocC.mbNodeFlags);
			}
		}
		
		
		/// <summary>
		/// Associated object ID.
		/// </summary>
		/// <remarks>
		/// Only valid for non-template workflows.
		/// DB column: wf_eloobjid
		/// </remarks>
		public int eloObjId
		{
			get
			{
				return eloObjIdValue;
			}
			set
			{
				this.eloObjIdValue = value;
				setChangedMember(WorkFlowActiveDocC.mbEloObjId);
			}
		}
		
		
		/// <summary>
		/// User ID of the owner of the lock.
		/// </summary>
		/// <remarks>
		/// DB column: wf_locked_owner
		/// </remarks>
		public int lockId
		{
			get
			{
				return lockIdValue;
			}
			set
			{
				this.lockIdValue = value;
				setChangedMember(WorkFlowActiveDocC.mbLockId);
			}
		}
		
		
		/// <summary>
		/// Contains 1, if this node is active.
		/// </summary>
		/// <remarks>
		/// DB column: wf_is_next
		/// </remarks>
		public int isNext
		{
			get
			{
				return isNextValue;
			}
			set
			{
				this.isNextValue = value;
				setChangedMember(WorkFlowActiveDocC.mbIsNext);
			}
		}
		
		
		/// <summary>
		/// ELO-date when the node was entered.
		/// </summary>
		/// <remarks>
		/// DB column: wf_activate
		/// </remarks>
		public int activate
		{
			get
			{
				return activateValue;
			}
			set
			{
				this.activateValue = value;
				setChangedMember(WorkFlowActiveDocC.mbActivate);
			}
		}
		
		
		/// <summary>
		/// ELO-date when the node was exited.
		/// </summary>
		/// <remarks>
		/// DB column: wf_terminate
		/// </remarks>
		public int terminate
		{
			get
			{
				return terminateValue;
			}
			set
			{
				this.terminateValue = value;
				setChangedMember(WorkFlowActiveDocC.mbTerminate);
			}
		}
		
		
		/// <summary>
		/// ELO-date when the node was visited the last time.
		/// </summary>
		/// <remarks>
		/// DB column: wf_in_use_date
		/// </remarks>
		public int inUseDate
		{
			get
			{
				return inUseDateValue;
			}
			set
			{
				this.inUseDateValue = value;
				setChangedMember(WorkFlowActiveDocC.mbInUseDate);
			}
		}
		
		
		/// <summary>
		/// ELO-date when the workflow was finished.
		/// </summary>
		/// <remarks>
		/// All nodes contain the same value.
		/// DB column: wf_completion_date
		/// </remarks>
		public int completionDate
		{
			get
			{
				return completionDateValue;
			}
			set
			{
				this.completionDateValue = value;
				setChangedMember(WorkFlowActiveDocC.mbCompletionDate);
			}
		}
		
		
		/// <summary>
		/// Workflow template ID.
		/// </summary>
		/// <remarks>
		/// Not valid for template workflows. For active and
		/// finished workflows this member specifies the template ID that was used
		/// to start the workflow. If the workflow is started as an adhoc workflow,
		/// this member is 0 and flags contains the bit FLAG_ROOT_ADHOC.
		/// DB column: wf_template
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
				setChangedMember(WorkFlowActiveDocC.mbTemplateId);
			}
		}
		
		
		/// <summary>
		/// The ID of the user who has forwarded the node.
		/// </summary>
		/// <remarks>
		/// Not valid for template workflows.
		/// Only valid for person nodes.
		/// DB column: wf_userterminate
		/// </remarks>
		public String userTerminate
		{
			get
			{
				return userTerminateValue;
			}
			set
			{
				this.userTerminateValue = value;
				setChangedMember(WorkFlowActiveDocC.mbUserTerminate);
			}
		}
		
		
		/// <summary>
		/// reserved.
		/// </summary>
		/// <remarks>
		/// DB column: wf_tag
		/// </remarks>
		public int tag
		{
			get
			{
				return tagValue;
			}
			set
			{
				this.tagValue = value;
				setChangedMember(WorkFlowActiveDocC.mbTag);
			}
		}
		
		
		/// <summary>
		/// A group ID or user ID that was originally assigned in the designer.
		/// </summary>
		/// <remarks>
		/// DB column: wf_designdepartment
		/// </remarks>
		public int designDepartment
		{
			get
			{
				return designDepartmentValue;
			}
			set
			{
				this.designDepartmentValue = value;
				setChangedMember(WorkFlowActiveDocC.mbDesignDepartment);
			}
		}
		
		
		/// <summary>
		/// If a cycle is re-entered, the nodes in the cycle are duplicated.
		/// </summary>
		/// <remarks>
		/// The copied
		/// nodes will be placed in the designer moved by this value to the right. If
		/// this value is 0, the nodes are moved 60 points right and 20 points up.
		/// DB column: wf_dx
		/// </remarks>
		public int moveCyclePosX
		{
			get
			{
				return moveCyclePosXValue;
			}
			set
			{
				this.moveCyclePosXValue = value;
				setChangedMember(WorkFlowActiveDocC.mbMoveCyclePosX);
			}
		}
		
		
		/// <summary>
		/// A group ID to constrain access to the node.
		/// </summary>
		/// <remarks>
		/// Only members of this group
		/// are allowed to see and process the node.
		/// Only valid for person nodes.
		/// DB column: wf_department2
		/// </remarks>
		public int department2
		{
			get
			{
				return department2Value;
			}
			set
			{
				this.department2Value = value;
				setChangedMember(WorkFlowActiveDocC.mbDepartment2);
			}
		}
		
		
		/// <summary>
		/// An active person node (Activate is set) might be displayed to the user
		/// delayed by this number of days.
		/// </summary>
		/// <remarks>
		/// Only valid for person nodes.
		/// DB column: wf_delaydays
		/// </remarks>
		public int delayDays
		{
			get
			{
				return delayDaysValue;
			}
			set
			{
				this.delayDaysValue = value;
				setChangedMember(WorkFlowActiveDocC.mbDelayDays);
			}
		}
		
		
		/// <summary>
		/// Activate + DelayDays.
		/// </summary>
		/// <remarks>
		/// Not valid for template workflows.
		/// Only valid for person nodes.
		/// DB column: wf_duedate
		/// </remarks>
		public int delayDate
		{
			get
			{
				return delayDateValue;
			}
			set
			{
				this.delayDateValue = value;
				setChangedMember(WorkFlowActiveDocC.mbDelayDate);
			}
		}
		
		
		/// <summary>
		/// Flag that indicates whether the workflow template is deleted.
		/// </summary>
		/// <remarks>
		/// If the value is not 0, the workflow template is deleted.
		/// Only valid for template workflows.
		/// DB column: wf_deleted
		/// </remarks>
		public int deleted
		{
			get
			{
				return deletedValue;
			}
			set
			{
				this.deletedValue = value;
				setChangedMember(WorkFlowActiveDocC.mbDeleted);
			}
		}
		
		
		/// <summary>
		/// Workflow priority: 0...high, 1...medium, 2...low.
		/// </summary>
		/// <remarks>
		/// DB column: wf_prio
		/// </remarks>
		public int prio
		{
			get
			{
				return prioValue;
			}
			set
			{
				this.prioValue = value;
				setChangedMember(WorkFlowActiveDocC.mbPrio);
			}
		}
		
		
		/// <summary>
		/// The workflow node is deferred until this date.
		/// </summary>
		/// <remarks>
		/// ELO date format.
		/// DB column: wf_user_delaydate
		/// </remarks>
		public int userDelayDate
		{
			get
			{
				return userDelayDateValue;
			}
			set
			{
				this.userDelayDateValue = value;
				setChangedMember(WorkFlowActiveDocC.mbUserDelayDate);
			}
		}
		
		
		/// <summary>
		/// Version ID.
		/// </summary>
		public int versionId
		{
			get
			{
				return versionIdValue;
			}
			set
			{
				this.versionIdValue = value;
				setChangedMember(WorkFlowActiveDocC.mbVersionId);
			}
		}
		
		
		/// <summary>
		/// Version comment.
		/// </summary>
		public String versionName
		{
			get
			{
				return versionNameValue;
			}
			set
			{
				this.versionNameValue = value;
				setChangedMember(WorkFlowActiveDocC.mbVersionName);
			}
		}
		
		
		/// <summary>
		/// ID of user who should be informed,
		/// if the time-limit alertWait2 exceeds.
		/// </summary>
		public int alertTo2
		{
			get
			{
				return alertTo2Value;
			}
			set
			{
				this.alertTo2Value = value;
				setChangedMember(WorkFlowActiveDocC.mbAlertTo2);
			}
		}
		
		
		/// <summary>
		/// Second Time-limit for a person node or begin node.
		/// </summary>
		public int alertWait2
		{
			get
			{
				return alertWait2Value;
			}
			set
			{
				this.alertWait2Value = value;
				setChangedMember(WorkFlowActiveDocC.mbAlertWait2);
			}
		}
		
		
		/// <summary>
		/// ID of user who should be informed,
		/// if the time-limit alertWait2 exceeds.
		/// </summary>
		public int alertTo3
		{
			get
			{
				return alertTo3Value;
			}
			set
			{
				this.alertTo3Value = value;
				setChangedMember(WorkFlowActiveDocC.mbAlertTo3);
			}
		}
		
		
		/// <summary>
		/// Third Time-limit for a person node or begin node.
		/// </summary>
		public int alertWait3
		{
			get
			{
				return alertWait3Value;
			}
			set
			{
				this.alertWait3Value = value;
				setChangedMember(WorkFlowActiveDocC.mbAlertWait3);
			}
		}
		
		
		/// <summary>
		/// Next server name.
		/// </summary>
		/// <remarks>
		/// This value is used in replication environments
		/// and defines the ID of the next server (resp. replication branch)
		/// where the workflow continues processing.
		/// </remarks>
		public String nextServerId
		{
			get
			{
				return nextServerIdValue;
			}
			set
			{
				this.nextServerIdValue = value;
				setChangedMember(WorkFlowActiveDocC.mbNextServerId);
			}
		}
		
		
		/// <summary>
		/// Version number.
		/// </summary>
		public String versionTag
		{
			get
			{
				return versionTagValue;
			}
			set
			{
				this.versionTagValue = value;
				setChangedMember(WorkFlowActiveDocC.mbVersionTag);
			}
		}
		
		
		/// <summary>
		/// ID of the user who created the workflow version.
		/// </summary>
		public int versionUserId
		{
			get
			{
				return versionUserIdValue;
			}
			set
			{
				this.versionUserIdValue = value;
				setChangedMember(WorkFlowActiveDocC.mbVersionUserId);
			}
		}
		
		
		/// <summary>
		/// ID of the user who created the workflow version.
		/// </summary>
		public int versionCreateDate
		{
			get
			{
				return versionCreateDateValue;
			}
			set
			{
				this.versionCreateDateValue = value;
				setChangedMember(WorkFlowActiveDocC.mbVersionCreateDate);
			}
		}
		
		
		/// <summary>
		/// Object-GUID of an icon file that is displayed in the designer.
		/// </summary>
		public String iconId
		{
			get
			{
				return iconIdValue;
			}
			set
			{
				this.iconIdValue = value;
				setChangedMember(WorkFlowActiveDocC.mbIconId);
			}
		}
		
		
		/// <summary>
		/// User defined data to be stored in the database.
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
				setChangedMember(WorkFlowActiveDocC.mbFormSpec);
			}
		}
		
		
		/// <summary>
		/// Translation-keyword for {@link WFDiagram#name}.
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
				setChangedMember(WorkFlowActiveDocC.mbFlowNameTranslationKey);
			}
		}
		
		
		/// <summary>
		/// Translation-keyword for {@link WFNode#name}.
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
				setChangedMember(WorkFlowActiveDocC.mbNameTranslationKey);
			}
		}
		
		
		/// <summary>
		/// Translation-keyword for {@link WFNode#comment}.
		/// </summary>
		public String commentTranslationKey
		{
			get
			{
				return commentTranslationKeyValue;
			}
			set
			{
				this.commentTranslationKeyValue = value;
				setChangedMember(WorkFlowActiveDocC.mbCommentTranslationKey);
			}
		}
		
		
		/// <summary>
		/// Display name by forwarding.
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
				setChangedMember(WorkFlowActiveDocC.mbLabel);
			}
		}
		
		
		/// <summary>
		/// Properties field of node.
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
				setChangedMember(WorkFlowActiveDocC.mbProperties);
			}
		}
		
		
		/// <summary>
		/// Grouping of nodes for function takeWorkFlowNode.
		/// </summary>
		public int departmentGroup
		{
			get
			{
				return departmentGroupValue;
			}
			set
			{
				this.departmentGroupValue = value;
				setChangedMember(WorkFlowActiveDocC.mbDepartmentGroup);
			}
		}
		
		
		/// <summary>
		/// Return value of an end node.
		/// </summary>
		public int retVal
		{
			get
			{
				return retValValue;
			}
			set
			{
				this.retValValue = value;
				setChangedMember(WorkFlowActiveDocC.mbRetVal);
			}
		}
		
		
		/// <summary>
		/// Return value of an end node.
		/// </summary>
		public String returnValue
		{
			get
			{
				return returnValueValue;
			}
			set
			{
				this.returnValueValue = value;
				setChangedMember(WorkFlowActiveDocC.mbReturnValue);
			}
		}
		
		
		/// <summary>
		/// ID of the active sub-workflow.
		/// </summary>
		public int subWorkflow
		{
			get
			{
				return subWorkflowValue;
			}
			set
			{
				this.subWorkflowValue = value;
				setChangedMember(WorkFlowActiveDocC.mbSubWorkflow);
			}
		}
		
		
		public String labelTranslationKey
		{
			get
			{
				return labelTranslationKeyValue;
			}
			set
			{
				this.labelTranslationKeyValue = value;
				setChangedMember(WorkFlowActiveDocC.mbLabelTranslationKey);
			}
		}
		
		
		/// <summary>
		/// ID of the sub-workflow template.
		/// </summary>
		public int subWorkflowTemplate
		{
			get
			{
				return subWorkflowTemplateValue;
			}
			set
			{
				this.subWorkflowTemplateValue = value;
				setChangedMember(WorkFlowActiveDocC.mbSubWorkflowTemplate);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int flowIdValue;

		protected int nodeIdValue;

		protected String flowNameValue;

		protected String nameValue;

		protected int nodeTypeValue;

		protected int succTypeValue;

		protected int departmentValue;

		protected int alertToValue;

		protected int alertFromBeginValue;

		protected int alertWaitValue;

		protected String yNConditionValue;

		protected String conditionValue;

		protected String commentValue;

		protected int succ_0Value;

		protected int succ_1Value;

		protected int succ_2Value;

		protected int succ_3Value;

		protected int succ_4Value;

		protected int succ_5Value;

		protected int succ_6Value;

		protected int succ_7Value;

		protected int succ_8Value;

		protected int succ_9Value;

		protected int succ_10Value;

		protected int succ_11Value;

		protected int succ_12Value;

		protected int succ_13Value;

		protected int succ_14Value;

		protected int succ_15Value;

		protected int succ_16Value;

		protected int succ_17Value;

		protected int succ_18Value;

		protected int succ_19Value;

		protected int lockedValue;

		protected int posXValue;

		protected int posYValue;

		protected String onActivateValue;

		protected String onTerminateValue;

		protected int nodeFlagsValue;

		protected int eloObjIdValue;

		protected int lockIdValue;

		protected int isNextValue;

		protected int activateValue;

		protected int terminateValue;

		protected int inUseDateValue;

		protected int completionDateValue;

		protected int templateIdValue;

		protected String userTerminateValue;

		protected int tagValue;

		protected int designDepartmentValue;

		protected int moveCyclePosXValue;

		protected int department2Value;

		protected int delayDaysValue;

		protected int delayDateValue;

		protected int deletedValue;

		protected int prioValue;

		protected int userDelayDateValue;

		protected int versionIdValue;

		protected String versionNameValue;

		protected int alertTo2Value;

		protected int alertWait2Value;

		protected int alertTo3Value;

		protected int alertWait3Value;

		protected String nextServerIdValue;

		protected String versionTagValue;

		protected int versionUserIdValue;

		protected int versionCreateDateValue;

		protected String iconIdValue;

		protected String formSpecValue;

		protected String flowNameTranslationKeyValue;

		protected String nameTranslationKeyValue;

		protected String commentTranslationKeyValue;

		protected String labelValue;

		protected String propertiesValue;

		protected int departmentGroupValue;

		protected int retValValue;

		protected String returnValueValue;

		protected int subWorkflowValue;

		protected String labelTranslationKeyValue;

		protected int subWorkflowTemplateValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1807635378L;		
	} // end class
}  // end namespace

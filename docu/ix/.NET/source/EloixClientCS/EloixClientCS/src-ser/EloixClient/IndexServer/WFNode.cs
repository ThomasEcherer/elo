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
	/// <p>Objects of this class represent a workflow node.
	/// </summary>
	/// <remarks>
	/// </p>
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class WFNode : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WFNode() {
		}		
		
		public WFNode(bool @allowActivate, String @comment, int @delayDays, int @department2, int @designDepartment, String @enterDateIso, String @exitDateIso, int @flags, int @id, String @inUseDateIso, int @isNext, int @moveCyclePosX, String @name, int @nbOfDonesToExit, String @onEnter, String @onExit, int @posX, int @posY, int @tag, int @timeLimit, String @timeLimitIso, int @type, int @userId, String @userName, String @userTerminate, String @yesNoCondition, String @delayDateIso, bool @overTimeLimit, String @userDelayDateIso, String @processOnServerId, EloixClient.IndexServer.WFTimeLimit[] @timeLimitEscalations, String[] @objKeyNames, String[] @scriptNames, String @iconId, String @formSpec, String @nameTranslationKey, String @commentTranslationKey, String @label, String @properties, int @departmentGroup, int @subFlowId, int @retVal, String @returnValue, String @labelTranslationKey, int @subTemplateId, int @prio) {
			this.allowActivateValue = @allowActivate;
			this.commentValue = @comment;
			this.delayDaysValue = @delayDays;
			this.department2Value = @department2;
			this.designDepartmentValue = @designDepartment;
			this.enterDateIsoValue = @enterDateIso;
			this.exitDateIsoValue = @exitDateIso;
			this.flagsValue = @flags;
			this.idValue = @id;
			this.inUseDateIsoValue = @inUseDateIso;
			this.isNextValue = @isNext;
			this.moveCyclePosXValue = @moveCyclePosX;
			this.nameValue = @name;
			this.nbOfDonesToExitValue = @nbOfDonesToExit;
			this.onEnterValue = @onEnter;
			this.onExitValue = @onExit;
			this.posXValue = @posX;
			this.posYValue = @posY;
			this.tagValue = @tag;
			this.timeLimitValue = @timeLimit;
			this.timeLimitIsoValue = @timeLimitIso;
			this.typeValue = @type;
			this.userIdValue = @userId;
			this.userNameValue = @userName;
			this.userTerminateValue = @userTerminate;
			this.yesNoConditionValue = @yesNoCondition;
			this.delayDateIsoValue = @delayDateIso;
			this.overTimeLimitValue = @overTimeLimit;
			this.userDelayDateIsoValue = @userDelayDateIso;
			this.processOnServerIdValue = @processOnServerId;
			this.timeLimitEscalationsValue = @timeLimitEscalations;
			this.objKeyNamesValue = @objKeyNames;
			this.scriptNamesValue = @scriptNames;
			this.iconIdValue = @iconId;
			this.formSpecValue = @formSpec;
			this.nameTranslationKeyValue = @nameTranslationKey;
			this.commentTranslationKeyValue = @commentTranslationKey;
			this.labelValue = @label;
			this.propertiesValue = @properties;
			this.departmentGroupValue = @departmentGroup;
			this.subFlowIdValue = @subFlowId;
			this.retValValue = @retVal;
			this.returnValueValue = @returnValue;
			this.labelTranslationKeyValue = @labelTranslationKey;
			this.subTemplateIdValue = @subTemplateId;
			this.prioValue = @prio;
		}		
		
		public WFNode(WFNode rhs) : base(rhs)
		{
			this.allowActivateValue = rhs.allowActivateValue;
			this.commentValue = rhs.commentValue;
			this.delayDaysValue = rhs.delayDaysValue;
			this.department2Value = rhs.department2Value;
			this.designDepartmentValue = rhs.designDepartmentValue;
			this.enterDateIsoValue = rhs.enterDateIsoValue;
			this.exitDateIsoValue = rhs.exitDateIsoValue;
			this.flagsValue = rhs.flagsValue;
			this.idValue = rhs.idValue;
			this.inUseDateIsoValue = rhs.inUseDateIsoValue;
			this.isNextValue = rhs.isNextValue;
			this.moveCyclePosXValue = rhs.moveCyclePosXValue;
			this.nameValue = rhs.nameValue;
			this.nbOfDonesToExitValue = rhs.nbOfDonesToExitValue;
			this.onEnterValue = rhs.onEnterValue;
			this.onExitValue = rhs.onExitValue;
			this.posXValue = rhs.posXValue;
			this.posYValue = rhs.posYValue;
			this.tagValue = rhs.tagValue;
			this.timeLimitValue = rhs.timeLimitValue;
			this.timeLimitIsoValue = rhs.timeLimitIsoValue;
			this.typeValue = rhs.typeValue;
			this.userIdValue = rhs.userIdValue;
			this.userNameValue = rhs.userNameValue;
			this.userTerminateValue = rhs.userTerminateValue;
			this.yesNoConditionValue = rhs.yesNoConditionValue;
			this.delayDateIsoValue = rhs.delayDateIsoValue;
			this.overTimeLimitValue = rhs.overTimeLimitValue;
			this.userDelayDateIsoValue = rhs.userDelayDateIsoValue;
			this.processOnServerIdValue = rhs.processOnServerIdValue;
			this.timeLimitEscalationsValue = rhs.timeLimitEscalationsValue;
			this.objKeyNamesValue = rhs.objKeyNamesValue;
			this.scriptNamesValue = rhs.scriptNamesValue;
			this.iconIdValue = rhs.iconIdValue;
			this.formSpecValue = rhs.formSpecValue;
			this.nameTranslationKeyValue = rhs.nameTranslationKeyValue;
			this.commentTranslationKeyValue = rhs.commentTranslationKeyValue;
			this.labelValue = rhs.labelValue;
			this.propertiesValue = rhs.propertiesValue;
			this.departmentGroupValue = rhs.departmentGroupValue;
			this.subFlowIdValue = rhs.subFlowIdValue;
			this.retValValue = rhs.retValValue;
			this.returnValueValue = rhs.returnValueValue;
			this.labelTranslationKeyValue = rhs.labelTranslationKeyValue;
			this.subTemplateIdValue = rhs.subTemplateIdValue;
			this.prioValue = rhs.prioValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Can this node be activated?
		/// </summary>
		/// <remarks>
		/// A script can set this value to prevent the activation of the node.
		/// This member is valid for all node types.
		/// </remarks>
		public bool allowActivate
		{
			get
			{
				return allowActivateValue;
			}
			set
			{
				this.allowActivateValue = value;
			}
		}
		
		
		/// <summary>
		/// Comment text for the node.
		/// </summary>
		/// <remarks>
		/// This member is valid for all node types.
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
				setChangedMember(WFNodeC.mbComment);
			}
		}
		
		
		/// <summary>
		/// An active person node (Activate is set) might be displayed to the user
		/// delayed by this number of days.
		/// </summary>
		/// <remarks>
		/// Only valid for person nodes.
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
				setChangedMember(WFNodeC.mbDelayDays);
			}
		}
		
		
		/// <summary>
		/// A group ID to constrain access to the node.
		/// </summary>
		/// <remarks>
		/// Only members of this group
		/// are allowed to see and process the node.
		/// Only valid for person nodes.
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
				setChangedMember(WFNodeC.mbDepartment2);
			}
		}
		
		
		/// <summary>
		/// A group ID or user ID that was originally assigned in the designer.
		/// </summary>
		/// <remarks>
		/// Only valid for person nodes.
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
				setChangedMember(WFNodeC.mbDesignDepartment);
			}
		}
		
		
		/// <summary>
		/// The node was activated on this date.
		/// </summary>
		/// <remarks>
		/// This member is valid for all node types.
		/// </remarks>
		public String enterDateIso
		{
			get
			{
				return enterDateIsoValue;
			}
			set
			{
				this.enterDateIsoValue = value;
				setChangedMember(WFNodeC.mbEnterDateIso);
			}
		}
		
		
		/// <summary>
		/// The node was exited/completed on this date.
		/// </summary>
		/// <remarks>
		/// This member is valid for all node types.
		/// </remarks>
		public String exitDateIso
		{
			get
			{
				return exitDateIsoValue;
			}
			set
			{
				this.exitDateIsoValue = value;
				setChangedMember(WFNodeC.mbExitDateIso);
			}
		}
		
		
		/// <summary>
		/// Control flags for the node, a combination of WFNodeC.FLAG_* constants.
		/// </summary>
		/// <remarks>
		/// For start nodes (TYPE_BEGINNODE), the flags should be specified in
		/// WFDiagram.flags. To ensure compatibility with older client programs,
		/// the WFNode.flags of the start node are or-ed with the WFDiagram.flags.
		/// This member is valid for all node types.
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
				setChangedMember(WFNodeC.mbFlags);
			}
		}
		
		
		/// <summary>
		/// Node ID.
		/// </summary>
		/// <remarks>
		/// This member is valid for all node types.
		/// </remarks>
		public int id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
				setChangedMember(WFNodeC.mbId);
			}
		}
		
		
		/// <summary>
		/// The date when the node was last used(activated or completed).
		/// </summary>
		/// <remarks>
		/// This member is valid for all node types.
		/// </remarks>
		public String inUseDateIso
		{
			get
			{
				return inUseDateIsoValue;
			}
			set
			{
				this.inUseDateIsoValue = value;
				setChangedMember(WFNodeC.mbInUseDateIso);
			}
		}
		
		
		/// <summary>
		/// The activation state of the node.
		/// </summary>
		/// <remarks>
		/// This member is valid for all node types.
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
				setChangedMember(WFNodeC.mbIsNext);
			}
		}
		
		
		/// <summary>
		/// If a cycle is re-entered, the nodes in the cycle are duplicated.
		/// </summary>
		/// <remarks>
		/// The copied
		/// nodes will be placed in the designer moved by this value to the right. If
		/// this value is 0, the nodes are moved 60 points right and 20 points up.
		/// This member is valid for all node types.
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
				setChangedMember(WFNodeC.mbMoveCyclePosX);
			}
		}
		
		
		/// <summary>
		/// The node description (work instruction).
		/// </summary>
		/// <remarks>
		/// This member is valid for all node types.
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
				setChangedMember(WFNodeC.mbName);
			}
		}
		
		
		/// <summary>
		/// The number of predecessor nodes that must be processed to forward this
		/// collector node.
		/// </summary>
		/// <remarks>
		/// A value of -1 means that all predecessor nodes must be processed. If set to
		/// 0, the collect node switches when it is activated regardless of the state of
		/// the predecessor nodes.
		/// This member is only valid for collect nodes.
		/// </remarks>
		public int nbOfDonesToExit
		{
			get
			{
				return nbOfDonesToExitValue;
			}
			set
			{
				this.nbOfDonesToExitValue = value;
				setChangedMember(WFNodeC.mbNbOfDonesToExit);
			}
		}
		
		
		/// <summary>
		/// The script name that is executed when the node is activated.
		/// </summary>
		/// <remarks>
		/// This member is valid for all node types.
		/// </remarks>
		public String onEnter
		{
			get
			{
				return onEnterValue;
			}
			set
			{
				this.onEnterValue = value;
				setChangedMember(WFNodeC.mbOnEnter);
			}
		}
		
		
		/// <summary>
		/// The script name that is executed when the node is exited/completed.
		/// </summary>
		/// <remarks>
		/// This member is valid for all node types.
		/// </remarks>
		public String onExit
		{
			get
			{
				return onExitValue;
			}
			set
			{
				this.onExitValue = value;
				setChangedMember(WFNodeC.mbOnExit);
			}
		}
		
		
		/// <summary>
		/// The X position in the designer view.
		/// </summary>
		/// <remarks>
		/// This member is valid for all node types.
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
				setChangedMember(WFNodeC.mbPosX);
			}
		}
		
		
		/// <summary>
		/// The Y position in the designer view.
		/// </summary>
		/// <remarks>
		/// This member is valid for all node types.
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
				setChangedMember(WFNodeC.mbPosY);
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
				setChangedMember(WFNodeC.mbTag);
			}
		}
		
		
		/// <summary>
		/// The time-limit to process the node.
		/// </summary>
		/// <remarks>
		/// Measured in minutes.
		/// This member is only valid for person nodes.
		/// </remarks>
		public int timeLimit
		{
			get
			{
				return timeLimitValue;
			}
			set
			{
				this.timeLimitValue = value;
				setChangedMember(WFNodeC.mbTimeLimit);
			}
		}
		
		
		/// <summary>
		/// After this date the node exceeds the time-limit for processing.
		/// </summary>
		/// <remarks>
		/// This member is only valid for person nodes.
		/// Read-only.
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
				setChangedMember(WFNodeC.mbTimeLimitIso);
			}
		}
		
		
		/// <summary>
		/// The node type.
		/// </summary>
		/// <remarks>
		/// This member is set to one of the TYPE_* constants in WFNodeC.
		/// </remarks>
		public int type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
				setChangedMember(WFNodeC.mbType);
			}
		}
		
		
		/// <summary>
		/// This user has to edit the node.
		/// </summary>
		/// <remarks>
		/// This member is only valid for person nodes.
		/// </remarks>
		public int userId
		{
			get
			{
				return userIdValue;
			}
			set
			{
				this.userIdValue = value;
				setChangedMember(WFNodeC.mbUserId);
			}
		}
		
		
		/// <summary>
		/// The name of the user that has the ID <code>userId</code>
		/// This member is only valid for person nodes.
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
				setChangedMember(WFNodeC.mbUserName);
			}
		}
		
		
		/// <summary>
		/// The ID of the user who has forwarded the node.
		/// </summary>
		/// <remarks>
		/// Not valid for template workflows.
		/// This member is only valid for person nodes.
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
				setChangedMember(WFNodeC.mbUserTerminate);
			}
		}
		
		
		/// <summary>
		/// IF node: test condition, numeric values must be formatted according to the servers locale.
		/// </summary>
		/// <remarks>
		/// split node: sets the workflow status to this value,
		/// begin node: contains workflow status
		/// cycle node: condition that evaluates true to leave the cycle
		/// </remarks>
		public String yesNoCondition
		{
			get
			{
				return yesNoConditionValue;
			}
			set
			{
				this.yesNoConditionValue = value;
				setChangedMember(WFNodeC.mbYesNoCondition);
			}
		}
		
		
		/// <summary>
		/// The node is displayed to the user at this date.
		/// </summary>
		/// <remarks>
		/// This date is computed by
		/// enterDateIso + delayDays.
		/// This member is only valid for person nodes.
		/// Read-only.
		/// </remarks>
		public String delayDateIso
		{
			get
			{
				return delayDateIsoValue;
			}
			set
			{
				this.delayDateIsoValue = value;
				setChangedMember(WFNodeC.mbDelayDateIso);
			}
		}
		
		
		/// <summary>
		/// True, if the node exceeds the time limit.
		/// </summary>
		/// <remarks>
		/// This member is only valid for person nodes in active or finished workflows.
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
		/// The workflow node is deferred until this date.
		/// </summary>
		/// <remarks>
		/// This member is only valid for person nodes in active or finished workflows.
		/// ISO date format.
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
				setChangedMember(WFNodeC.mbUserDelayDateIso);
			}
		}
		
		
		/// <summary>
		/// Server ID (resp. replication branch).
		/// </summary>
		/// <remarks>
		/// If the node is activated, the server ID is set to this value.
		/// This member is only valid for nodes of type WFNodeC.TYPE_SET_SERVER_ID.
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
				setChangedMember(WFNodeC.mbProcessOnServerId);
			}
		}
		
		
		/// <summary>
		/// Additional definitions for time limits.
		/// </summary>
		/// <remarks>
		/// This member is only valid for person nodes.
		/// </remarks>
		public EloixClient.IndexServer.WFTimeLimit[] timeLimitEscalations
		{
			get
			{
				return timeLimitEscalationsValue;
			}
			set
			{
				this.timeLimitEscalationsValue = value;
				setChangedMember(WFNodeC.mbTimeLimitEscalations);
			}
		}
		
		
		/// <summary>
		/// Group names of index values (DocMaskLine.key resp.
		/// </summary>
		/// <remarks>
		/// ObjKey.name)
		/// for which an edit box is to be displayed when forwarding a person node.
		/// This member is only valid for person nodes.
		/// </remarks>
		public String[] objKeyNames
		{
			get
			{
				return objKeyNamesValue;
			}
			set
			{
				this.objKeyNamesValue = value;
				setChangedMember(WFNodeC.mbObjKeyNames);
			}
		}
		
		
		/// <summary>
		/// Script names used as action scripts in buttons
		/// when forwarding a person node.
		/// </summary>
		/// <remarks>
		/// Script files for the Windows CLIENT have to be named
		/// as ELOWF_ + scriptNames[.].
		/// This member is only valid for person nodes.
		/// </remarks>
		public String[] scriptNames
		{
			get
			{
				return scriptNamesValue;
			}
			set
			{
				this.scriptNamesValue = value;
				setChangedMember(WFNodeC.mbScriptNames);
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
				setChangedMember(WFNodeC.mbIconId);
			}
		}
		
		
		/// <summary>
		/// Multipurpose field.
		/// </summary>
		/// <remarks>
		/// <p>
		/// If the node is a collect node (type={@link WFNodeC#TYPE_COLLECTNODE}),
		/// formSpec contains a comma separated list of node IDs. This nodes are
		/// deactivated when the collect node forwards the workflow. In addition to
		/// a list of IDs, the value of {@link WFNodeC#DEACTIVATE_ALL_PREDS} causes
		/// to deactivate all predecessor nodes.
		/// </p>
		/// <p>
		/// In case of a person node ({@link WFNodeC#TYPE_PERSONNODE}),
		/// formSpec can contain proprietary encoded information about a workflow form.
		/// </p>
		/// </remarks>
		public String formSpec
		{
			get
			{
				return formSpecValue;
			}
			set
			{
				this.formSpecValue = value;
				setChangedMember(WFNodeC.mbFormSpec);
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
				setChangedMember(WFNodeC.mbNameTranslationKey);
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
				setChangedMember(WFNodeC.mbCommentTranslationKey);
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
				setChangedMember(WFNodeC.mbLabel);
			}
		}
		
		
		/// <summary>
		/// Node properties.
		/// </summary>
		/// <remarks>
		/// Maximum byte size of this string in UTF-8 encoding is constrained to {@link FileDataC#MAX_BLOB_LENGTH}.
		/// </remarks>
		public String properties
		{
			get
			{
				return propertiesValue;
			}
			set
			{
				this.propertiesValue = value;
				setChangedMember(WFNodeC.mbProperties);
			}
		}
		
		
		/// <summary>
		/// Grouping of nodes for function takeWorkFlowNode.
		/// </summary>
		/// <remarks>
		/// A non-zero value binds nodes with the same value to a group of nodes that is evaluated in {@link IXServicePortIF#takeWorkFlowNode(ClientInfo, int, int, String, int, LockZ)}.
		/// The function takeWorkFlowNodes takes - in addition to the given node - all nodes with the same group assignment specified by this member.
		/// This member is only used as a marker and is not interpreted as a group or user ID.
		/// </remarks>
		public int departmentGroup
		{
			get
			{
				return departmentGroupValue;
			}
			set
			{
				this.departmentGroupValue = value;
				setChangedMember(WFNodeC.mbDepartmentGroup);
			}
		}
		
		
		/// <summary>
		/// Id of the active sub-workflow.
		/// </summary>
		/// <remarks>
		/// Only valid for TYPE_CALL_SUB_WORKFLOW.
		/// </remarks>
		public int subFlowId
		{
			get
			{
				return subFlowIdValue;
			}
			set
			{
				this.subFlowIdValue = value;
				setChangedMember(WFNodeC.mbSubFlowId);
			}
		}
		
		
		/// <summary>
		/// Return value of an end node.
		/// </summary>
		/// <remarks>
		/// Only valid for TYPE_END.
		/// </remarks>
		public int retVal
		{
			get
			{
				return retValValue;
			}
			set
			{
				this.retValValue = value;
				setChangedMember(WFNodeC.mbRetVal);
			}
		}
		
		
		/// <summary>
		/// Return value of a sub-workflow.
		/// </summary>
		/// <remarks>
		/// The value defines the name of the successor node of the call-node {@link WFNodeC#TYPE_CALL_SUB_WORKFLOW}
		/// that will be activated when the sub-workflow returns.
		/// If the sub-workflow returns a node name that does not exist in the main workflow, a new person node is inserted
		/// between the call-node and its successors. This new node is named as the return value and is assigned to
		/// the workflow owner.
		/// </remarks>
		public String returnValue
		{
			get
			{
				return returnValueValue;
			}
			set
			{
				this.returnValueValue = value;
				setChangedMember(WFNodeC.mbReturnValue);
			}
		}
		
		
		/// <summary>
		/// Translation-keyword for {@link WFNode#label}.
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
				setChangedMember(WFNodeC.mbLabelTranslationKey);
			}
		}
		
		
		/// <summary>
		/// ID, GUID or name of the sub-workflow template.
		/// </summary>
		public int subTemplateId
		{
			get
			{
				return subTemplateIdValue;
			}
			set
			{
				this.subTemplateIdValue = value;
				setChangedMember(WFNodeC.mbSubTemplateId);
			}
		}
		
		
		/// <summary>
		/// Node priortiy: 0...high, 1...medium, 2...low.
		/// </summary>
		/// <remarks>
		/// Only valid for person nodes, type=={@link WFNodeC#TYPE_PERSONNODE}.
		/// The user assigned to the person node can change this value by conn.ix().forwardWorkflowNode():
		/// <pre>
		/// <code>
		/// WFEditNode editNode = conn.ix().beginForwardWorkflowNode(flowId, nodeId, null, LockC.NO);
		/// WFNode activeNode = editNode.getNode();
		/// activeNode.setPrio(activeNode.getPrio()-1); // One level higher.
		/// ForwardWorkflowNodeInfo fwdInfo = new ForwardWorkflowNodeInfo();
		/// fwdInfo.setNode(activeNode);
		/// conn.ix().forwardWorkflowNode(wfActive.getId(), activeNode.getId(), fwdInfo, LockC.NO);
		/// 
		/// </code>
		/// </pre>
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
				setChangedMember(WFNodeC.mbPrio);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool allowActivateValue;

		protected String commentValue;

		protected int delayDaysValue;

		protected int department2Value;

		protected int designDepartmentValue;

		protected String enterDateIsoValue;

		protected String exitDateIsoValue;

		protected int flagsValue;

		protected int idValue;

		protected String inUseDateIsoValue;

		protected int isNextValue;

		protected int moveCyclePosXValue;

		protected String nameValue;

		protected int nbOfDonesToExitValue;

		protected String onEnterValue;

		protected String onExitValue;

		protected int posXValue;

		protected int posYValue;

		protected int tagValue;

		protected int timeLimitValue;

		protected String timeLimitIsoValue;

		protected int typeValue;

		protected int userIdValue;

		protected String userNameValue;

		protected String userTerminateValue;

		protected String yesNoConditionValue;

		protected String delayDateIsoValue;

		protected bool overTimeLimitValue;

		protected String userDelayDateIsoValue;

		protected String processOnServerIdValue;

		protected EloixClient.IndexServer.WFTimeLimit[] timeLimitEscalationsValue;

		protected String[] objKeyNamesValue;

		protected String[] scriptNamesValue;

		protected String iconIdValue;

		protected String formSpecValue;

		protected String nameTranslationKeyValue;

		protected String commentTranslationKeyValue;

		protected String labelValue;

		protected String propertiesValue;

		protected int departmentGroupValue;

		protected int subFlowIdValue;

		protected int retValValue;

		protected String returnValueValue;

		protected String labelTranslationKeyValue;

		protected int subTemplateIdValue;

		protected int prioValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2015686193L;		
	} // end class
}  // end namespace

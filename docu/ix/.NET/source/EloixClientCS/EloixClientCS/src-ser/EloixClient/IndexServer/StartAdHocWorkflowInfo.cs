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
	/// This class contains several options that are used to start the AdHocWorkflow
	/// </summary>
	public class StartAdHocWorkflowInfo : BSerializable
	{
	
		#region Constructors
		
		public StartAdHocWorkflowInfo() {
		}		
		
		public StartAdHocWorkflowInfo(bool @forValidation, bool @serialFlow, String @cancelUserId, String @cancelMessage, String @finishedUserId, String @finishedMessage, String @finishedScript, String @nodeName, String @workflowRepeatMessage, String @breakWorkflowMessage, String[] @userIdsToDeactivate, bool @deactivateNodes, String @acceptMessage, String @noticeMessage, String @actionRejectMessage, String @successMessage, EloixClient.IndexServer.WFTimeLimit @timeLimit, EloixClient.IndexServer.WFTimeLimit[] @timeLimitEscalations, int @flags, IList<EloixClient.IndexServer.ValueClass> @nodeInfos) {
			this.forValidationValue = @forValidation;
			this.serialFlowValue = @serialFlow;
			this.cancelUserIdValue = @cancelUserId;
			this.cancelMessageValue = @cancelMessage;
			this.finishedUserIdValue = @finishedUserId;
			this.finishedMessageValue = @finishedMessage;
			this.finishedScriptValue = @finishedScript;
			this.nodeNameValue = @nodeName;
			this.workflowRepeatMessageValue = @workflowRepeatMessage;
			this.breakWorkflowMessageValue = @breakWorkflowMessage;
			this.userIdsToDeactivateValue = @userIdsToDeactivate;
			this.deactivateNodesValue = @deactivateNodes;
			this.acceptMessageValue = @acceptMessage;
			this.noticeMessageValue = @noticeMessage;
			this.actionRejectMessageValue = @actionRejectMessage;
			this.successMessageValue = @successMessage;
			this.timeLimitValue = @timeLimit;
			this.timeLimitEscalationsValue = @timeLimitEscalations;
			this.flagsValue = @flags;
			this.nodeInfosValue = @nodeInfos;
		}		
		
		public StartAdHocWorkflowInfo(StartAdHocWorkflowInfo rhs)
		{
			this.forValidationValue = rhs.forValidationValue;
			this.serialFlowValue = rhs.serialFlowValue;
			this.cancelUserIdValue = rhs.cancelUserIdValue;
			this.cancelMessageValue = rhs.cancelMessageValue;
			this.finishedUserIdValue = rhs.finishedUserIdValue;
			this.finishedMessageValue = rhs.finishedMessageValue;
			this.finishedScriptValue = rhs.finishedScriptValue;
			this.nodeNameValue = rhs.nodeNameValue;
			this.workflowRepeatMessageValue = rhs.workflowRepeatMessageValue;
			this.breakWorkflowMessageValue = rhs.breakWorkflowMessageValue;
			this.userIdsToDeactivateValue = rhs.userIdsToDeactivateValue;
			this.deactivateNodesValue = rhs.deactivateNodesValue;
			this.acceptMessageValue = rhs.acceptMessageValue;
			this.noticeMessageValue = rhs.noticeMessageValue;
			this.actionRejectMessageValue = rhs.actionRejectMessageValue;
			this.successMessageValue = rhs.successMessageValue;
			this.timeLimitValue = rhs.timeLimitValue;
			this.timeLimitEscalationsValue = rhs.timeLimitEscalationsValue;
			this.flagsValue = rhs.flagsValue;
			this.nodeInfosValue = rhs.nodeInfosValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// If true, the workflow comes back to the user who started it.
		/// </summary>
		public bool forValidation
		{
			get
			{
				return forValidationValue;
			}
			set
			{
				this.forValidationValue = value;
			}
		}
		
		
		/// <summary>
		/// If true, the workflow routes the object from user to user.
		/// </summary>
		/// <remarks>
		/// The workflow
		/// finishes when the last user has edited their node. If
		/// <code>serialFlow</code> is false, the workflow routes the object to all
		/// users. The first user who edits their node terminates the workflow.
		/// </remarks>
		public bool serialFlow
		{
			get
			{
				return serialFlowValue;
			}
			set
			{
				this.serialFlowValue = value;
			}
		}
		
		
		/// <summary>
		/// If the workflow is canceled, this user receives a message,
		/// <code>cancelMessage</code>.
		/// </summary>
		public String cancelUserId
		{
			get
			{
				return cancelUserIdValue;
			}
			set
			{
				this.cancelUserIdValue = value;
			}
		}
		
		
		/// <summary>
		/// The message that is send to the user specified with
		/// <code>cancelUserId</code>, if the workflow is canceled.
		/// </summary>
		public String cancelMessage
		{
			get
			{
				return cancelMessageValue;
			}
			set
			{
				this.cancelMessageValue = value;
			}
		}
		
		
		/// <summary>
		/// If the workflow is finished, this user receives a message,
		/// <code>finishedMessage</code>.
		/// </summary>
		public String finishedUserId
		{
			get
			{
				return finishedUserIdValue;
			}
			set
			{
				this.finishedUserIdValue = value;
			}
		}
		
		
		/// <summary>
		/// The message that is send to the user specified with
		/// <code>finishedUserId</code>, if the workflow is finished.
		/// </summary>
		public String finishedMessage
		{
			get
			{
				return finishedMessageValue;
			}
			set
			{
				this.finishedMessageValue = value;
			}
		}
		
		
		/// <summary>
		/// This script is executed, when the workflow is finished.
		/// </summary>
		public String finishedScript
		{
			get
			{
				return finishedScriptValue;
			}
			set
			{
				this.finishedScriptValue = value;
			}
		}
		
		
		/// <summary>
		/// Start node name.
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
		/// This message is send to the user who started the workflow if the workflow is repeated.
		/// </summary>
		public String workflowRepeatMessage
		{
			get
			{
				return workflowRepeatMessageValue;
			}
			set
			{
				this.workflowRepeatMessageValue = value;
			}
		}
		
		
		/// <summary>
		/// This message is send to the user who started the workflow if the workflow is canceled.
		/// </summary>
		public String breakWorkflowMessage
		{
			get
			{
				return breakWorkflowMessageValue;
			}
			set
			{
				this.breakWorkflowMessageValue = value;
			}
		}
		
		
		/// <summary>
		/// The list of the person nodes to be deactivated when the workflow is canceled.
		/// </summary>
		/// <remarks>
		/// This option is only used for "parallel for validation" workflow. Otherwise this option is ignored.
		/// </remarks>
		public String[] userIdsToDeactivate
		{
			get
			{
				return userIdsToDeactivateValue;
			}
			set
			{
				this.userIdsToDeactivateValue = value;
			}
		}
		
		
		/// <summary>
		/// If true, all person nodes are deactivated when the workflow is canceled.
		/// </summary>
		/// <remarks>
		/// This option is only used for "parallel for validation" workflow. Otherwise this option is ignored.
		/// </remarks>
		public bool deactivateNodes
		{
			get
			{
				return deactivateNodesValue;
			}
			set
			{
				this.deactivateNodesValue = value;
			}
		}
		
		
		/// <summary>
		/// This message is shown if the workflow is accepted by a person.
		/// </summary>
		public String acceptMessage
		{
			get
			{
				return acceptMessageValue;
			}
			set
			{
				this.acceptMessageValue = value;
			}
		}
		
		
		/// <summary>
		/// This message is shown if the a person was informed about the workflow.
		/// </summary>
		public String noticeMessage
		{
			get
			{
				return noticeMessageValue;
			}
			set
			{
				this.noticeMessageValue = value;
			}
		}
		
		
		/// <summary>
		/// This message is shown if the workflow is rejected.
		/// </summary>
		public String actionRejectMessage
		{
			get
			{
				return actionRejectMessageValue;
			}
			set
			{
				this.actionRejectMessageValue = value;
			}
		}
		
		
		/// <summary>
		/// This message is shown if the workflow is successfully processed.
		/// </summary>
		public String successMessage
		{
			get
			{
				return successMessageValue;
			}
			set
			{
				this.successMessageValue = value;
			}
		}
		
		
		/// <summary>
		/// Time-limit for the entire workflow.
		/// </summary>
		public EloixClient.IndexServer.WFTimeLimit timeLimit
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
		/// Control flags for the node, a combination of WFNode.C.FLAG_* constants.
		/// </summary>
		public int flags
		{
			get
			{
				return flagsValue;
			}
			set
			{
				this.flagsValue = value;
			}
		}
		
		
		/// <summary>
		/// The information of all nodes in the workflow.
		/// </summary>
		public IList<EloixClient.IndexServer.ValueClass> nodeInfos
		{
			get
			{
				return nodeInfosValue;
			}
			set
			{
				this.nodeInfosValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool forValidationValue;

		protected bool serialFlowValue;

		protected String cancelUserIdValue;

		protected String cancelMessageValue;

		protected String finishedUserIdValue;

		protected String finishedMessageValue;

		protected String finishedScriptValue;

		protected String nodeNameValue;

		protected String workflowRepeatMessageValue;

		protected String breakWorkflowMessageValue;

		protected String[] userIdsToDeactivateValue;

		protected bool deactivateNodesValue;

		protected String acceptMessageValue;

		protected String noticeMessageValue;

		protected String actionRejectMessageValue;

		protected String successMessageValue;

		protected EloixClient.IndexServer.WFTimeLimit timeLimitValue;

		protected EloixClient.IndexServer.WFTimeLimit[] timeLimitEscalationsValue;

		protected int flagsValue;

		protected IList<EloixClient.IndexServer.ValueClass> nodeInfosValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1587514612L;		
	} // end class
}  // end namespace

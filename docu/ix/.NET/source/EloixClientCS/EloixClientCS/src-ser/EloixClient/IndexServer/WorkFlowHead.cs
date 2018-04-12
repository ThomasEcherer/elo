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
	/// Helperclass to access the DB table workflowtemplhead, workflowactivedochead, ...
	/// </summary>
	public class WorkFlowHead : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WorkFlowHead() {
		}		
		
		public WorkFlowHead(int @flowId, String @tStamp, String @guid, int @status, int @type, String @actServerId, int @parentWorkflow, int @callNodeId) {
			this.flowIdValue = @flowId;
			this.tStampValue = @tStamp;
			this.guidValue = @guid;
			this.statusValue = @status;
			this.typeValue = @type;
			this.actServerIdValue = @actServerId;
			this.parentWorkflowValue = @parentWorkflow;
			this.callNodeIdValue = @callNodeId;
		}		
		
		public WorkFlowHead(WorkFlowHead rhs) : base(rhs)
		{
			this.flowIdValue = rhs.flowIdValue;
			this.tStampValue = rhs.tStampValue;
			this.guidValue = rhs.guidValue;
			this.statusValue = rhs.statusValue;
			this.typeValue = rhs.typeValue;
			this.actServerIdValue = rhs.actServerIdValue;
			this.parentWorkflowValue = rhs.parentWorkflowValue;
			this.callNodeIdValue = rhs.callNodeIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Workflow ID
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
				setChangedMember(WorkFlowHeadC.mbFlowId);
			}
		}
		
		
		/// <summary>
		/// Timestamp
		/// The format is JJJJ.MM.DD.hh.mm.ss
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
				setChangedMember(WorkFlowHeadC.mbTStamp);
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
				setChangedMember(WorkFlowHeadC.mbGuid);
			}
		}
		
		
		/// <summary>
		/// Status, !
		/// </summary>
		/// <remarks>
		/// = 0 means deleted
		/// </remarks>
		public int status
		{
			get
			{
				return statusValue;
			}
			set
			{
				this.statusValue = value;
				setChangedMember(WorkFlowHeadC.mbStatus);
			}
		}
		
		
		/// <summary>
		/// Workflow type.
		/// </summary>
		public int type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
				setChangedMember(WorkFlowHeadC.mbType);
			}
		}
		
		
		/// <summary>
		/// The current sever ID (resp. replication branch) where the
		/// workflow can be condinued.
		/// </summary>
		public String actServerId
		{
			get
			{
				return actServerIdValue;
			}
			set
			{
				this.actServerIdValue = value;
				setChangedMember(WorkFlowHeadC.mbActServerId);
			}
		}
		
		
		/// <summary>
		/// Id of the main workflow.
		/// </summary>
		public int parentWorkflow
		{
			get
			{
				return parentWorkflowValue;
			}
			set
			{
				this.parentWorkflowValue = value;
				setChangedMember(WorkFlowHeadC.mbParentWorkflow);
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
				setChangedMember(WorkFlowHeadC.mbCallNodeId);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int flowIdValue;

		protected String tStampValue;

		protected String guidValue;

		protected int statusValue;

		protected int typeValue;

		protected String actServerIdValue;

		protected int parentWorkflowValue;

		protected int callNodeIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 37271022L;		
	} // end class
}  // end namespace

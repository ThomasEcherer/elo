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
	/// Helperclass to access the node matrix.
	/// </summary>
	public class WorkFlowNodeMatrix : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WorkFlowNodeMatrix() {
		}		
		
		public WorkFlowNodeMatrix(int @flowId, int @nodeId, int @isNext, int @terminate, int @succType, int @succ_0, int @succ_1, int @succ_2, int @succ_3, int @succ_4, int @succ_5, int @succ_6, int @succ_7, int @succ_8, int @succ_9, int @succ_10, int @succ_11, int @succ_12, int @succ_13, int @succ_14, int @succ_15, int @succ_16, int @succ_17, int @succ_18, int @succ_19, int @succOvertime, int @versionId) {
			this.flowIdValue = @flowId;
			this.nodeIdValue = @nodeId;
			this.isNextValue = @isNext;
			this.terminateValue = @terminate;
			this.succTypeValue = @succType;
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
			this.succOvertimeValue = @succOvertime;
			this.versionIdValue = @versionId;
		}		
		
		public WorkFlowNodeMatrix(WorkFlowNodeMatrix rhs) : base(rhs)
		{
			this.flowIdValue = rhs.flowIdValue;
			this.nodeIdValue = rhs.nodeIdValue;
			this.isNextValue = rhs.isNextValue;
			this.terminateValue = rhs.terminateValue;
			this.succTypeValue = rhs.succTypeValue;
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
			this.succOvertimeValue = rhs.succOvertimeValue;
			this.versionIdValue = rhs.versionIdValue;
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
				setChangedMember(WorkFlowNodeMatrixC.mbFlowId);
			}
		}
		
		
		/// <summary>
		/// Node ID
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
				setChangedMember(WorkFlowNodeMatrixC.mbNodeId);
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
				setChangedMember(WorkFlowNodeMatrixC.mbIsNext);
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
				setChangedMember(WorkFlowNodeMatrixC.mbTerminate);
			}
		}
		
		
		/// <summary>
		/// Type of successor node.
		/// </summary>
		public int succType
		{
			get
			{
				return succTypeValue;
			}
			set
			{
				this.succTypeValue = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSuccType);
			}
		}
		
		
		public int succ_0
		{
			get
			{
				return succ_0Value;
			}
			set
			{
				this.succ_0Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_0);
			}
		}
		
		
		public int succ_1
		{
			get
			{
				return succ_1Value;
			}
			set
			{
				this.succ_1Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_1);
			}
		}
		
		
		public int succ_2
		{
			get
			{
				return succ_2Value;
			}
			set
			{
				this.succ_2Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_2);
			}
		}
		
		
		public int succ_3
		{
			get
			{
				return succ_3Value;
			}
			set
			{
				this.succ_3Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_3);
			}
		}
		
		
		public int succ_4
		{
			get
			{
				return succ_4Value;
			}
			set
			{
				this.succ_4Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_4);
			}
		}
		
		
		public int succ_5
		{
			get
			{
				return succ_5Value;
			}
			set
			{
				this.succ_5Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_5);
			}
		}
		
		
		public int succ_6
		{
			get
			{
				return succ_6Value;
			}
			set
			{
				this.succ_6Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_6);
			}
		}
		
		
		public int succ_7
		{
			get
			{
				return succ_7Value;
			}
			set
			{
				this.succ_7Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_7);
			}
		}
		
		
		public int succ_8
		{
			get
			{
				return succ_8Value;
			}
			set
			{
				this.succ_8Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_8);
			}
		}
		
		
		public int succ_9
		{
			get
			{
				return succ_9Value;
			}
			set
			{
				this.succ_9Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_9);
			}
		}
		
		
		public int succ_10
		{
			get
			{
				return succ_10Value;
			}
			set
			{
				this.succ_10Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_10);
			}
		}
		
		
		public int succ_11
		{
			get
			{
				return succ_11Value;
			}
			set
			{
				this.succ_11Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_11);
			}
		}
		
		
		public int succ_12
		{
			get
			{
				return succ_12Value;
			}
			set
			{
				this.succ_12Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_12);
			}
		}
		
		
		public int succ_13
		{
			get
			{
				return succ_13Value;
			}
			set
			{
				this.succ_13Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_13);
			}
		}
		
		
		public int succ_14
		{
			get
			{
				return succ_14Value;
			}
			set
			{
				this.succ_14Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_14);
			}
		}
		
		
		public int succ_15
		{
			get
			{
				return succ_15Value;
			}
			set
			{
				this.succ_15Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_15);
			}
		}
		
		
		public int succ_16
		{
			get
			{
				return succ_16Value;
			}
			set
			{
				this.succ_16Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_16);
			}
		}
		
		
		public int succ_17
		{
			get
			{
				return succ_17Value;
			}
			set
			{
				this.succ_17Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_17);
			}
		}
		
		
		public int succ_18
		{
			get
			{
				return succ_18Value;
			}
			set
			{
				this.succ_18Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_18);
			}
		}
		
		
		public int succ_19
		{
			get
			{
				return succ_19Value;
			}
			set
			{
				this.succ_19Value = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSucc_19);
			}
		}
		
		
		/// <summary>
		/// Id of successor node, which should be activated by the escalation.
		/// </summary>
		public int succOvertime
		{
			get
			{
				return succOvertimeValue;
			}
			set
			{
				this.succOvertimeValue = value;
				setChangedMember(WorkFlowNodeMatrixC.mbSuccOvertime);
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
				setChangedMember(WorkFlowNodeMatrixC.mbVersionId);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int flowIdValue;

		protected int nodeIdValue;

		protected int isNextValue;

		protected int terminateValue;

		protected int succTypeValue;

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

		protected int succOvertimeValue;

		protected int versionIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1337377725L;		
	} // end class
}  // end namespace

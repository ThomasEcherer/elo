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
	/// <p>Bit constants for members of WorkFlowNodeMatrix</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class WorkFlowNodeMatrixC : BSerializable
	{
	
		#region Constructors
		
		public WorkFlowNodeMatrixC() {
		}		
		
		public WorkFlowNodeMatrixC(int @lnEdgesOrdinals) {
			this.lnEdgesOrdinalsValue = @lnEdgesOrdinals;
		}		
		
		public WorkFlowNodeMatrixC(WorkFlowNodeMatrixC rhs)
		{
			this.lnEdgesOrdinalsValue = rhs.lnEdgesOrdinalsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: Sort order of edges.
		/// </summary>
		/// <remarks>
		/// DB column: wf_edges_ordinals
		/// </remarks>
		public int lnEdgesOrdinals
		{
			get
			{
				return lnEdgesOrdinalsValue;
			}
			set
			{
				this.lnEdgesOrdinalsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: Sort order of edges.
		/// </summary>
		/// <remarks>
		/// DB column: wf_edges_ordinals
		/// </remarks>
		public const long mbEdgesOrdinals = 1L;

		protected int lnEdgesOrdinalsValue;

		/// <summary>
		/// Member bit: Workflow ID
		/// DB column: wf_flowid
		/// </summary>
		public const long mbFlowId = 2L;

		/// <summary>
		/// Member bit: Node ID
		/// DB column: wf_nodeid
		/// </summary>
		public const long mbNodeId = 4L;

		/// <summary>
		/// Member bit: Contains 1, if this node is active.
		/// </summary>
		/// <remarks>
		/// DB column: wf_is_next
		/// </remarks>
		public const long mbIsNext = 8L;

		/// <summary>
		/// Member bit: ELO-date when the node was exited.
		/// </summary>
		/// <remarks>
		/// DB column: wf_terminate
		/// </remarks>
		public const long mbTerminate = 16L;

		/// <summary>
		/// Member bit: Type of successor node.
		/// </summary>
		/// <remarks>
		/// DB column: wf_succ_type
		/// </remarks>
		public const long mbSuccType = 32L;

		/// <summary>
		/// DB column: wf_succ_0
		/// </summary>
		public const long mbSucc_0 = 64L;

		/// <summary>
		/// DB column: wf_succ_1
		/// </summary>
		public const long mbSucc_1 = 128L;

		/// <summary>
		/// DB column: wf_succ_2
		/// </summary>
		public const long mbSucc_2 = 256L;

		/// <summary>
		/// DB column: wf_succ_3
		/// </summary>
		public const long mbSucc_3 = 512L;

		/// <summary>
		/// DB column: wf_succ_4
		/// </summary>
		public const long mbSucc_4 = 1024L;

		/// <summary>
		/// DB column: wf_succ_5
		/// </summary>
		public const long mbSucc_5 = 2048L;

		/// <summary>
		/// DB column: wf_succ_6
		/// </summary>
		public const long mbSucc_6 = 4096L;

		/// <summary>
		/// DB column: wf_succ_7
		/// </summary>
		public const long mbSucc_7 = 8192L;

		/// <summary>
		/// DB column: wf_succ_8
		/// </summary>
		public const long mbSucc_8 = 16384L;

		/// <summary>
		/// DB column: wf_succ_9
		/// </summary>
		public const long mbSucc_9 = 32768L;

		/// <summary>
		/// DB column: wf_succ_10
		/// </summary>
		public const long mbSucc_10 = 65536L;

		/// <summary>
		/// DB column: wf_succ_11
		/// </summary>
		public const long mbSucc_11 = 131072L;

		/// <summary>
		/// DB column: wf_succ_12
		/// </summary>
		public const long mbSucc_12 = 262144L;

		/// <summary>
		/// DB column: wf_succ_13
		/// </summary>
		public const long mbSucc_13 = 524288L;

		/// <summary>
		/// DB column: wf_succ_14
		/// </summary>
		public const long mbSucc_14 = 1048576L;

		/// <summary>
		/// DB column: wf_succ_15
		/// </summary>
		public const long mbSucc_15 = 2097152L;

		/// <summary>
		/// DB column: wf_succ_16
		/// </summary>
		public const long mbSucc_16 = 4194304L;

		/// <summary>
		/// DB column: wf_succ_17
		/// </summary>
		public const long mbSucc_17 = 8388608L;

		/// <summary>
		/// DB column: wf_succ_18
		/// </summary>
		public const long mbSucc_18 = 16777216L;

		/// <summary>
		/// DB column: wf_succ_19
		/// </summary>
		public const long mbSucc_19 = 33554432L;

		/// <summary>
		/// Member bit: Id of successor node, which should be activated by the escalation.
		/// </summary>
		/// <remarks>
		/// DB column: wf_succ_overtime
		/// </remarks>
		public const long mbSuccOvertime = 67108864L;

		/// <summary>
		/// Member bit: Version ID.
		/// </summary>
		/// <remarks>
		/// DB column: wf_version
		/// </remarks>
		public const long mbVersionId = 134217728L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 268435455L;

		#endregion
		
		
		public static readonly long serialVersionUID = 813423307L;		
	} // end class
}  // end namespace

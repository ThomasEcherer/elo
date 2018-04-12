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
	/// <p>Bit constants for members of WorkFlowHead</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class WorkFlowHeadC : BSerializable
	{
	
		#region Constructors
		
		public WorkFlowHeadC() {
		}		
		
		public WorkFlowHeadC(int @lnTStamp, int @lnGuid, int @lnActServerId) {
			this.lnTStampValue = @lnTStamp;
			this.lnGuidValue = @lnGuid;
			this.lnActServerIdValue = @lnActServerId;
		}		
		
		public WorkFlowHeadC(WorkFlowHeadC rhs)
		{
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnActServerIdValue = rhs.lnActServerIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: Timestamp
		/// DB column: wftstamp
		/// </summary>
		public int lnTStamp
		{
			get
			{
				return lnTStampValue;
			}
			set
			{
				this.lnTStampValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: GUID
		/// DB column: wfguid
		/// </summary>
		public int lnGuid
		{
			get
			{
				return lnGuidValue;
			}
			set
			{
				this.lnGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: The current sever ID (resp. replication branch) where the
		/// DB column: actserverid
		/// </summary>
		public int lnActServerId
		{
			get
			{
				return lnActServerIdValue;
			}
			set
			{
				this.lnActServerIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: Workflow ID
		/// DB column: wfflowid
		/// </summary>
		public const long mbFlowId = 1L;

		/// <summary>
		/// Member bit: Timestamp
		/// DB column: wftstamp
		/// </summary>
		public const long mbTStamp = 2L;

		protected int lnTStampValue;

		/// <summary>
		/// Member bit: GUID
		/// DB column: wfguid
		/// </summary>
		public const long mbGuid = 4L;

		protected int lnGuidValue;

		/// <summary>
		/// Member bit: Status, !
		/// </summary>
		/// <remarks>
		/// = 0 means deleted
		/// DB column: wfstatus
		/// </remarks>
		public const long mbStatus = 8L;

		/// <summary>
		/// Member bit: Workflow type.
		/// </summary>
		/// <remarks>
		/// DB column: wftype
		/// </remarks>
		public const long mbType = 16L;

		/// <summary>
		/// Member bit: The current sever ID (resp. replication branch) where the
		/// DB column: actserverid
		/// </summary>
		public const long mbActServerId = 32L;

		protected int lnActServerIdValue;

		/// <summary>
		/// Member bit: Id of the main workflow.
		/// </summary>
		/// <remarks>
		/// DB column: wfParent
		/// </remarks>
		public const long mbParentWorkflow = 64L;

		/// <summary>
		/// Member bit: The call node id of the main workflow, which call this sub workflow.
		/// </summary>
		/// <remarks>
		/// DB column: callnodeid
		/// </remarks>
		public const long mbCallNodeId = 128L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 255L;

		#endregion
		
		
		public static readonly long serialVersionUID = 807993720L;		
	} // end class
}  // end namespace

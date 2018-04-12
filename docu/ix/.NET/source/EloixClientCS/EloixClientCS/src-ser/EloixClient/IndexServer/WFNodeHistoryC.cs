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
	/// <p>Bit constants for members of WFNodeHistory</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class WFNodeHistoryC : BSerializable
	{
	
		#region Constructors
		
		public WFNodeHistoryC() {
		}		
		
		public WFNodeHistoryC(int @lnHistGuid, int @lnFlowGuid, int @lnUserName) {
			this.lnHistGuidValue = @lnHistGuid;
			this.lnFlowGuidValue = @lnFlowGuid;
			this.lnUserNameValue = @lnUserName;
		}		
		
		public WFNodeHistoryC(WFNodeHistoryC rhs)
		{
			this.lnHistGuidValue = rhs.lnHistGuidValue;
			this.lnFlowGuidValue = rhs.lnFlowGuidValue;
			this.lnUserNameValue = rhs.lnUserNameValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: wfhistguid
		/// </summary>
		public int lnHistGuid
		{
			get
			{
				return lnHistGuidValue;
			}
			set
			{
				this.lnHistGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wfguid
		/// </summary>
		public int lnFlowGuid
		{
			get
			{
				return lnFlowGuidValue;
			}
			set
			{
				this.lnFlowGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: wf_username
		/// </summary>
		public int lnUserName
		{
			get
			{
				return lnUserNameValue;
			}
			set
			{
				this.lnUserNameValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: wfhistguid
		/// </summary>
		public const long mbHistGuid = 1L;

		protected int lnHistGuidValue;

		/// <summary>
		/// DB column: wfguid
		/// </summary>
		public const long mbFlowGuid = 2L;

		protected int lnFlowGuidValue;

		/// <summary>
		/// DB column: wf_nodeid
		/// </summary>
		public const long mbNodeId = 4L;

		/// <summary>
		/// DB column: wf_activate
		/// </summary>
		public const long mbActivate = 8L;

		/// <summary>
		/// DB column: wf_terminate
		/// </summary>
		public const long mbTerminate = 16L;

		/// <summary>
		/// DB column: wf_user
		/// </summary>
		public const long mbUserId = 32L;

		/// <summary>
		/// DB column: wf_username
		/// </summary>
		public const long mbUserName = 64L;

		protected int lnUserNameValue;

		/// <summary>
		/// DB column: wf_succ_0
		/// </summary>
		public const long mbSucc_0 = 128L;

		/// <summary>
		/// DB column: wf_succ_1
		/// </summary>
		public const long mbSucc_1 = 256L;

		/// <summary>
		/// DB column: wf_succ_2
		/// </summary>
		public const long mbSucc_2 = 512L;

		/// <summary>
		/// DB column: wf_succ_3
		/// </summary>
		public const long mbSucc_3 = 1024L;

		/// <summary>
		/// DB column: wf_succ_4
		/// </summary>
		public const long mbSucc_4 = 2048L;

		/// <summary>
		/// DB column: wf_succ_5
		/// </summary>
		public const long mbSucc_5 = 4096L;

		/// <summary>
		/// DB column: wf_succ_6
		/// </summary>
		public const long mbSucc_6 = 8192L;

		/// <summary>
		/// DB column: wf_succ_7
		/// </summary>
		public const long mbSucc_7 = 16384L;

		/// <summary>
		/// DB column: wf_succ_8
		/// </summary>
		public const long mbSucc_8 = 32768L;

		/// <summary>
		/// DB column: wf_succ_9
		/// </summary>
		public const long mbSucc_9 = 65536L;

		/// <summary>
		/// DB column: wf_succ_10
		/// </summary>
		public const long mbSucc_10 = 131072L;

		/// <summary>
		/// DB column: wf_succ_11
		/// </summary>
		public const long mbSucc_11 = 262144L;

		/// <summary>
		/// DB column: wf_succ_12
		/// </summary>
		public const long mbSucc_12 = 524288L;

		/// <summary>
		/// DB column: wf_succ_13
		/// </summary>
		public const long mbSucc_13 = 1048576L;

		/// <summary>
		/// DB column: wf_succ_14
		/// </summary>
		public const long mbSucc_14 = 2097152L;

		/// <summary>
		/// DB column: wf_succ_15
		/// </summary>
		public const long mbSucc_15 = 4194304L;

		/// <summary>
		/// DB column: wf_succ_16
		/// </summary>
		public const long mbSucc_16 = 8388608L;

		/// <summary>
		/// DB column: wf_succ_17
		/// </summary>
		public const long mbSucc_17 = 16777216L;

		/// <summary>
		/// DB column: wf_succ_18
		/// </summary>
		public const long mbSucc_18 = 33554432L;

		/// <summary>
		/// DB column: wf_succ_19
		/// </summary>
		public const long mbSucc_19 = 67108864L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 134217727L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1457412372L;		
	} // end class
}  // end namespace

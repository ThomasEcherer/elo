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
	/// Version history for a workflow node.
	/// </summary>
	/// <remarks>
	/// A version history is created while
	/// leaving a workflow node.
	/// 
	/// <p>
	/// Copyright: Copyright (c) 2015
	/// </p>
	/// <p>
	/// Organisation: ELO Digital Office GmbH
	/// </p>
	/// </remarks>
	public class WFNodeHistory : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WFNodeHistory() {
		}		
		
		public WFNodeHistory(String @histGuid, String @flowGuid, int @nodeId, int @userId, String @userName, String @enterDateIso, String @exitDateIso, int @succ_0, int @succ_1, int @succ_2, int @succ_3, int @succ_4, int @succ_5, int @succ_6, int @succ_7, int @succ_8, int @succ_9, int @succ_10, int @succ_11, int @succ_12, int @succ_13, int @succ_14, int @succ_15, int @succ_16, int @succ_17, int @succ_18, int @succ_19) {
			this.histGuidValue = @histGuid;
			this.flowGuidValue = @flowGuid;
			this.nodeIdValue = @nodeId;
			this.userIdValue = @userId;
			this.userNameValue = @userName;
			this.enterDateIsoValue = @enterDateIso;
			this.exitDateIsoValue = @exitDateIso;
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
		}		
		
		public WFNodeHistory(WFNodeHistory rhs) : base(rhs)
		{
			this.histGuidValue = rhs.histGuidValue;
			this.flowGuidValue = rhs.flowGuidValue;
			this.nodeIdValue = rhs.nodeIdValue;
			this.userIdValue = rhs.userIdValue;
			this.userNameValue = rhs.userNameValue;
			this.enterDateIsoValue = rhs.enterDateIsoValue;
			this.exitDateIsoValue = rhs.exitDateIsoValue;
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
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// GUID of the WorkflowHist object.
		/// </summary>
		/// <remarks>
		/// DB column: wfhistguid
		/// </remarks>
		public String histGuid
		{
			get
			{
				return histGuidValue;
			}
			set
			{
				this.histGuidValue = value;
				setChangedMember(WFNodeHistoryC.mbHistGuid);
			}
		}
		
		
		/// <summary>
		/// GUID of the workflow.
		/// </summary>
		/// <remarks>
		/// DB column: wfguid
		/// </remarks>
		public String flowGuid
		{
			get
			{
				return flowGuidValue;
			}
			set
			{
				this.flowGuidValue = value;
				setChangedMember(WFNodeHistoryC.mbFlowGuid);
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
				setChangedMember(WFNodeHistoryC.mbNodeId);
			}
		}
		
		
		/// <summary>
		/// ID of user who has to process the node.
		/// </summary>
		/// <remarks>
		/// Might be a group ID too. Only valid
		/// for person nodes. DB column: wf_userid
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
				setChangedMember(WFNodeHistoryC.mbUserId);
			}
		}
		
		
		/// <summary>
		/// Name of user who has to process the node.
		/// </summary>
		/// <remarks>
		/// Might be a group name too. Only valid
		/// for person nodes. DB column: wf_username
		/// </remarks>
		public String userName
		{
			get
			{
				return userNameValue;
			}
			set
			{
				this.userNameValue = value;
				setChangedMember(WFNodeHistoryC.mbUserName);
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
			}
		}
		
		
		/// <summary>
		/// Successor node(s) succ_0 ...
		/// </summary>
		/// <remarks>
		/// Succ 19 DB column: wf_succ_0
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
				setChangedMember(WFNodeHistoryC.mbSucc_0);
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
				setChangedMember(WFNodeHistoryC.mbSucc_1);
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
				setChangedMember(WFNodeHistoryC.mbSucc_2);
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
				setChangedMember(WFNodeHistoryC.mbSucc_3);
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
				setChangedMember(WFNodeHistoryC.mbSucc_4);
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
				setChangedMember(WFNodeHistoryC.mbSucc_5);
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
				setChangedMember(WFNodeHistoryC.mbSucc_6);
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
				setChangedMember(WFNodeHistoryC.mbSucc_7);
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
				setChangedMember(WFNodeHistoryC.mbSucc_8);
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
				setChangedMember(WFNodeHistoryC.mbSucc_9);
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
				setChangedMember(WFNodeHistoryC.mbSucc_10);
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
				setChangedMember(WFNodeHistoryC.mbSucc_11);
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
				setChangedMember(WFNodeHistoryC.mbSucc_12);
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
				setChangedMember(WFNodeHistoryC.mbSucc_13);
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
				setChangedMember(WFNodeHistoryC.mbSucc_14);
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
				setChangedMember(WFNodeHistoryC.mbSucc_15);
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
				setChangedMember(WFNodeHistoryC.mbSucc_16);
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
				setChangedMember(WFNodeHistoryC.mbSucc_17);
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
				setChangedMember(WFNodeHistoryC.mbSucc_18);
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
				setChangedMember(WFNodeHistoryC.mbSucc_19);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String histGuidValue;

		protected String flowGuidValue;

		protected int nodeIdValue;

		protected int userIdValue;

		protected String userNameValue;

		protected String enterDateIsoValue;

		protected String exitDateIsoValue;

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

		#endregion
		
		
		public static readonly new long serialVersionUID = 784568809L;		
	} // end class
}  // end namespace

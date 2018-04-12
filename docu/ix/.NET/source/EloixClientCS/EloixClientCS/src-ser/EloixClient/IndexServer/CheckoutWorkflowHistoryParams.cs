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
	/// Parameter class for the method checkoutWorkflowHistory.
	/// </summary>
	public class CheckoutWorkflowHistoryParams : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public CheckoutWorkflowHistoryParams() {
		}		
		
		public CheckoutWorkflowHistoryParams(String @flowId, int @nodeId) {
			this.flowIdValue = @flowId;
			this.nodeIdValue = @nodeId;
		}		
		
		public CheckoutWorkflowHistoryParams(CheckoutWorkflowHistoryParams rhs) : base(rhs)
		{
			this.flowIdValue = rhs.flowIdValue;
			this.nodeIdValue = rhs.nodeIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Workflow ID or workflow GUID.
		/// </summary>
		public String flowId
		{
			get
			{
				return flowIdValue;
			}
			set
			{
				this.flowIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Node ID.
		/// </summary>
		/// <remarks>
		/// If node ID is 0, histories of all node are return.
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
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String flowIdValue;

		protected int nodeIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 299426984L;		
	} // end class
}  // end namespace

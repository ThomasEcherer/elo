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
	/// This class controls workflow node forwarding in {@link IXServicePortIF#forwardWorkflowNode(ClientInfo, int, int, ForwardWorkflowNodeInfo, LockZ)}.
	/// </summary>
	public class ForwardWorkflowNodeInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ForwardWorkflowNodeInfo() {
		}		
		
		public ForwardWorkflowNodeInfo(bool @terminateWorkflow, IList<int> @successorNodesToActivate, EloixClient.IndexServer.WFNode @node) {
			this.terminateWorkflowValue = @terminateWorkflow;
			this.successorNodesToActivateValue = @successorNodesToActivate;
			this.nodeValue = @node;
		}		
		
		public ForwardWorkflowNodeInfo(ForwardWorkflowNodeInfo rhs) : base(rhs)
		{
			this.terminateWorkflowValue = rhs.terminateWorkflowValue;
			this.successorNodesToActivateValue = rhs.successorNodesToActivateValue;
			this.nodeValue = rhs.nodeValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Terminate the workflow instead of forwarding.
		/// </summary>
		/// <remarks>
		/// If this member is true, {@link #successorNodesToActivate} and {@link #node} are ignored.
		/// </remarks>
		public bool terminateWorkflow
		{
			get
			{
				return terminateWorkflowValue;
			}
			set
			{
				this.terminateWorkflowValue = value;
			}
		}
		
		
		/// <summary>
		/// List of successor nodes to be activated.
		/// </summary>
		/// <remarks>
		/// Set this member as null, if only node data should be changed. In this case, the the workflow is not forwarded.
		/// </remarks>
		public IList<int> successorNodesToActivate
		{
			get
			{
				return successorNodesToActivateValue;
			}
			set
			{
				this.successorNodesToActivateValue = value;
			}
		}
		
		
		/// <summary>
		/// Workflow node to forward.
		/// </summary>
		/// <remarks>
		/// The following members of this value are taken into account and update the related database values:
		/// {@link WFNode#name}, {@link WFNode#comment}, {@link WFNode#prio}.
		/// </remarks>
		public EloixClient.IndexServer.WFNode node
		{
			get
			{
				return nodeValue;
			}
			set
			{
				this.nodeValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool terminateWorkflowValue;

		protected IList<int> successorNodesToActivateValue;

		protected EloixClient.IndexServer.WFNode nodeValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 523867474L;		
	} // end class
}  // end namespace

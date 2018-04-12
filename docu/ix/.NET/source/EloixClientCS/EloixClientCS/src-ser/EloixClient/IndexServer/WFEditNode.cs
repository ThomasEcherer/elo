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
	/// Data required for processing a workflow person node.
	/// </summary>
	public class WFEditNode : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WFEditNode() {
		}		
		
		public WFEditNode(int @flowId, EloixClient.IndexServer.WFNode @node, int @nodeId, EloixClient.IndexServer.WFNode[] @succNodes) {
			this.flowIdValue = @flowId;
			this.nodeValue = @node;
			this.nodeIdValue = @nodeId;
			this.succNodesValue = @succNodes;
		}		
		
		public WFEditNode(WFEditNode rhs) : base(rhs)
		{
			this.flowIdValue = rhs.flowIdValue;
			this.nodeValue = rhs.nodeValue;
			this.nodeIdValue = rhs.nodeIdValue;
			this.succNodesValue = rhs.succNodesValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Workflow identifier
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
			}
		}
		
		
		/// <summary>
		/// The node to be processed
		/// </summary>
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
		
		
		/// <summary>
		/// Node identifier
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
			}
		}
		
		
		/// <summary>
		/// Choice of following nodes.
		/// </summary>
		/// <remarks>
		/// Array of ELOWorkFlowNode objects.
		/// </remarks>
		public EloixClient.IndexServer.WFNode[] succNodes
		{
			get
			{
				return succNodesValue;
			}
			set
			{
				this.succNodesValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int flowIdValue;

		protected EloixClient.IndexServer.WFNode nodeValue;

		protected int nodeIdValue;

		protected EloixClient.IndexServer.WFNode[] succNodesValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1822579866L;		
	} // end class
}  // end namespace

//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class WorkflowNodeInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WorkflowNodeInfo() {
		}		
		
		public WorkflowNodeInfo(String @nodeName, int @flags, String @workflow) {
			this.nodeNameValue = @nodeName;
			this.flagsValue = @flags;
			this.workflowValue = @workflow;
		}		
		
		public WorkflowNodeInfo(WorkflowNodeInfo rhs) : base(rhs)
		{
			this.nodeNameValue = rhs.nodeNameValue;
			this.flagsValue = rhs.flagsValue;
			this.workflowValue = rhs.workflowValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The node name
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
		/// The template ID of the subworkflow to start.
		/// </summary>
		public String workflow
		{
			get
			{
				return workflowValue;
			}
			set
			{
				this.workflowValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String nodeNameValue;

		protected int flagsValue;

		protected String workflowValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1659862348L;		
	} // end class
}  // end namespace

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
	/// This class represents a workflow export data.
	/// </summary>
	public class WorkflowExchangeInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WorkflowExchangeInfo() {
		}		
		
		public WorkflowExchangeInfo(EloixClient.IndexServer.WFDiagram @workflow, IDictionary<int,EloixClient.IndexServer.UserName> @userNames, IDictionary<int,EloixClient.IndexServer.WFDiagram> @subWorkflowMap, EloixClient.IndexServer.WFDiagram[] @workflowVersions, IDictionary<int,List<EloixClient.IndexServer.WFDiagram>> @subWorkflowVersionMap) {
			this.workflowValue = @workflow;
			this.userNamesValue = @userNames;
			this.subWorkflowMapValue = @subWorkflowMap;
			this.workflowVersionsValue = @workflowVersions;
			this.subWorkflowVersionMapValue = @subWorkflowVersionMap;
		}		
		
		public WorkflowExchangeInfo(WorkflowExchangeInfo rhs) : base(rhs)
		{
			this.workflowValue = rhs.workflowValue;
			this.userNamesValue = rhs.userNamesValue;
			this.subWorkflowMapValue = rhs.subWorkflowMapValue;
			this.workflowVersionsValue = rhs.workflowVersionsValue;
			this.subWorkflowVersionMapValue = rhs.subWorkflowVersionMapValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The exchanged workflow.
		/// </summary>
		public EloixClient.IndexServer.WFDiagram workflow
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
		
		
		/// <summary>
		/// The users associated with the workflow
		/// </summary>
		public IDictionary<int,EloixClient.IndexServer.UserName> userNames
		{
			get
			{
				return userNamesValue;
			}
			set
			{
				this.userNamesValue = value;
			}
		}
		
		
		/// <summary>
		/// Map contains the all direct und indirect subworkflows.
		/// </summary>
		/// <remarks>
		/// The workflow ID is the key.
		/// </remarks>
		public IDictionary<int,EloixClient.IndexServer.WFDiagram> subWorkflowMap
		{
			get
			{
				return subWorkflowMapValue;
			}
			set
			{
				this.subWorkflowMapValue = value;
			}
		}
		
		
		/// <summary>
		/// The workflow version.
		/// </summary>
		public EloixClient.IndexServer.WFDiagram[] workflowVersions
		{
			get
			{
				return workflowVersionsValue;
			}
			set
			{
				this.workflowVersionsValue = value;
			}
		}
		
		
		/// <summary>
		/// Map contains the workflow verions of the sub workflows.
		/// </summary>
		public IDictionary<int,List<EloixClient.IndexServer.WFDiagram>> subWorkflowVersionMap
		{
			get
			{
				return subWorkflowVersionMapValue;
			}
			set
			{
				this.subWorkflowVersionMapValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.WFDiagram workflowValue;

		protected IDictionary<int,EloixClient.IndexServer.UserName> userNamesValue;

		protected IDictionary<int,EloixClient.IndexServer.WFDiagram> subWorkflowMapValue;

		protected EloixClient.IndexServer.WFDiagram[] workflowVersionsValue;

		protected IDictionary<int,List<EloixClient.IndexServer.WFDiagram>> subWorkflowVersionMapValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2070549585L;		
	} // end class
}  // end namespace

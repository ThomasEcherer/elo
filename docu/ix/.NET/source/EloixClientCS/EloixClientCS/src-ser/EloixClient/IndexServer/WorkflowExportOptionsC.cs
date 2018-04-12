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
	/// Contants related to the workflow export.
	/// </summary>
	public class WorkflowExportOptionsC : BSerializable
	{
	
		#region Constructors
		
		public WorkflowExportOptionsC() {
		}		
		
		public WorkflowExportOptionsC(WorkflowExportOptionsC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// JSON format.
		/// </summary>
		public const int FORMAT_JSON = 1;

		/// <summary>
		/// Workflow table format for compatibility with Windows Client.
		/// </summary>
		public const int FORMAT_PLAIN_TABLE = 2;

		#endregion
		
		
		public static readonly long serialVersionUID = 1063132081L;		
	} // end class
}  // end namespace

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
	/// Options for the workflow import.
	/// </summary>
	public class WorkflowImportOptions : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WorkflowImportOptions() {
		}		
		
		public WorkflowImportOptions(String @replaceMissingUserByUserId) {
			this.replaceMissingUserByUserIdValue = @replaceMissingUserByUserId;
		}		
		
		public WorkflowImportOptions(WorkflowImportOptions rhs) : base(rhs)
		{
			this.replaceMissingUserByUserIdValue = rhs.replaceMissingUserByUserIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// If this variable is set, the missing user is replaced by this user.
		/// </summary>
		/// <remarks>
		/// Otherwise the missing user will be created using a random password.
		/// </remarks>
		public String replaceMissingUserByUserId
		{
			get
			{
				return replaceMissingUserByUserIdValue;
			}
			set
			{
				this.replaceMissingUserByUserIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String replaceMissingUserByUserIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 449037977L;		
	} // end class
}  // end namespace

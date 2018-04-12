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
	/// This class defines options for the API function deleteActivity.
	/// </summary>
	public class DeleteActivityOptions : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public DeleteActivityOptions() {
		}		
		
		public DeleteActivityOptions(bool @deleteFinally) {
			this.deleteFinallyValue = @deleteFinally;
		}		
		
		public DeleteActivityOptions(DeleteActivityOptions rhs) : base(rhs)
		{
			this.deleteFinallyValue = rhs.deleteFinallyValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Delete activity finally.
		/// </summary>
		/// <remarks>
		/// The database information for the activity is deleted, if this member is true.
		/// Otherwise the Activity.backAt is set to the current date.
		/// </remarks>
		public bool deleteFinally
		{
			get
			{
				return deleteFinallyValue;
			}
			set
			{
				this.deleteFinallyValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool deleteFinallyValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 78913228L;		
	} // end class
}  // end namespace

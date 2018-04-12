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
	/// The function executeScript returns an object of this class
	/// to provide returned information or error information.
	/// </summary>
	public class ExecuteScriptResult : BSerializable
	{
	
		#region Constructors
		
		public ExecuteScriptResult() {
		}		
		
		public ExecuteScriptResult(String @returnedString, String @errorMessage, int @errorLine, int @errorColumn) {
			this.returnedStringValue = @returnedString;
			this.errorMessageValue = @errorMessage;
			this.errorLineValue = @errorLine;
			this.errorColumnValue = @errorColumn;
		}		
		
		public ExecuteScriptResult(ExecuteScriptResult rhs)
		{
			this.returnedStringValue = rhs.returnedStringValue;
			this.errorMessageValue = rhs.errorMessageValue;
			this.errorLineValue = rhs.errorLineValue;
			this.errorColumnValue = rhs.errorColumnValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Return value as string.
		/// </summary>
		public String returnedString
		{
			get
			{
				return returnedStringValue;
			}
			set
			{
				this.returnedStringValue = value;
			}
		}
		
		
		/// <summary>
		/// Error message.
		/// </summary>
		public String errorMessage
		{
			get
			{
				return errorMessageValue;
			}
			set
			{
				this.errorMessageValue = value;
			}
		}
		
		
		/// <summary>
		/// Line where the error occured.
		/// </summary>
		public int errorLine
		{
			get
			{
				return errorLineValue;
			}
			set
			{
				this.errorLineValue = value;
			}
		}
		
		
		/// <summary>
		/// Column where the error occured.
		/// </summary>
		public int errorColumn
		{
			get
			{
				return errorColumnValue;
			}
			set
			{
				this.errorColumnValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String returnedStringValue;

		protected String errorMessageValue;

		protected int errorLineValue;

		protected int errorColumnValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 63967077L;		
	} // end class
}  // end namespace

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
	/// Options for function
	/// {@link IXServerEvents#onBeforeLogin(IXServerEventsContext, String, LoginScriptOptions)}
	/// </summary>
	public class LoginScriptOptions : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public LoginScriptOptions() {
		}		
		
		public LoginScriptOptions(String @clientName, String @techUser) {
			this.clientNameValue = @clientName;
			this.techUserValue = @techUser;
		}		
		
		public LoginScriptOptions(LoginScriptOptions rhs) : base(rhs)
		{
			this.clientNameValue = rhs.clientNameValue;
			this.techUserValue = rhs.techUserValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Unified Name for the client application.
		/// </summary>
		/// <remarks>
		/// The value of this field must be
		/// one value of {{@link LoginScriptOptionsC}.CLIENT_NAME_*}.
		/// </remarks>
		public String clientName
		{
			get
			{
				return clientNameValue;
			}
			set
			{
				this.clientNameValue = value;
			}
		}
		
		
		/// <summary>
		/// User name used for authentication.
		/// </summary>
		/// <remarks>
		/// This member is only valid for run-as logins. It contains the name of the technical user used for authentication.
		/// </remarks>
		public String techUser
		{
			get
			{
				return techUserValue;
			}
			set
			{
				this.techUserValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String clientNameValue;

		protected String techUserValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1536364115L;		
	} // end class
}  // end namespace

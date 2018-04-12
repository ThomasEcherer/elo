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
	/// This class contains constant definitions for IndexServer error numbers used
	/// in IndexServer exceptions.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class IXExceptionC : BSerializable
	{
	
		#region Constructors
		
		public IXExceptionC() {
		}		
		
		public IXExceptionC(IXExceptionC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Problem in the server configuration.
		/// </summary>
		public const int SERVER_ERROR = 1000;

		/// <summary>
		/// Unsupported protocol version.
		/// </summary>
		/// <remarks>
		/// This error is thrown, if the protocol version cannot be negotiated.
		/// A reason for this can be different major release versions of client and server.
		/// </remarks>
		public const int UNSUPPORTED_PROTOCOL_VERSION = 1001;

		/// <summary>
		/// Invalid parameter was given.
		/// </summary>
		public const int INVALID_PARAM = 2000;

		/// <summary>
		/// Session is not (or no longer) valid.
		/// </summary>
		public const int INVALID_SESSION = 2001;

		/// <summary>
		/// Temporarily problem, a later try should succeed.
		/// </summary>
		/// <remarks>
		/// The value of TEMP_PROBLEM must be changed in IX 8.00.054, because the current client
		/// libraries recognize it as an exception where relogin is required. This could lead
		/// to the effect described in TTS001661.
		/// </remarks>
		public const int TEMP_PROBLEM_OLD = 2002;

		/// <summary>
		/// Temporarily problem, a later try should succeed.
		/// </summary>
		public const int TEMP_PROBLEM = 2003;

		/// <summary>
		/// Encryption key must be set before documents can be encrypted.
		/// </summary>
		public const int INVALID_CRYPT_KEY = 2004;

		/// <summary>
		/// Syntax error e.g. in search request.
		/// </summary>
		public const int SYNTAX_ERROR = 2007;

		/// <summary>
		/// The given password violates the password rules.
		/// </summary>
		/// <remarks>
		/// The passord rules are stored in the user profile value {@link UserProfileC#KEY_PASSWORD_RULES}.
		/// </remarks>
		public const int PASSWORD_DENIED = 3007;

		/// <summary>
		/// Specified object to be created already exists.
		/// </summary>
		public const int ALREADY_EXISTS = 5005;

		/// <summary>
		/// Specified data is locked.
		/// </summary>
		public const int LOCKED = 5022;

		/// <summary>
		/// Specified data could not be found.
		/// </summary>
		public const int NOT_FOUND = 5023;

		/// <summary>
		/// Access to the specified object was denied, there are rights missing.
		/// </summary>
		public const int ACCESS_DENIED = 5024;

		/// <summary>
		/// Specified data could not be found.
		/// </summary>
		public const int NOT_EMPTY = 5066;

		/// <summary>
		/// An error thrown in a script file is passed to the client application with this error code.
		/// </summary>
		/// <remarks>
		/// E.g. [ELOIX:6000] "Message text thrown in script".
		/// </remarks>
		public const int SCRIPT_ERROR = 6000;

		/// <summary>
		/// Not a ELO IX Exception
		/// </summary>
		public const int NOT_IX = -1;

		/// <summary>
		/// Internal error.
		/// </summary>
		public const int INTERNAL = 9000;

		/// <summary>
		/// Function is not currently supported.
		/// </summary>
		public const int UNSUPPORTED_FUNCTION = 9999;

		#endregion
		
		
		public static readonly long serialVersionUID = 1204588365L;		
	} // end class
}  // end namespace

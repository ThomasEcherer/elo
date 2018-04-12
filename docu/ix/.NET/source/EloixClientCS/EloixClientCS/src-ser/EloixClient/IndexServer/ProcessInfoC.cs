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
	/// Constants class for the ProcessInfo class.
	/// </summary>
	/// <remarks>
	/// Errors:
	/// The error modes are ordered by increasing failure tolerance. In most cases a tree walk will traverse nodes in prefix mode
	/// except scripts, that may have an user defined processing position, so the operational success of a given node directly
	/// influences further processing. ERRORMODE_ALL, the zero failure tolerance, stops the job (nearly) immediately, while
	/// ERRORMODE_SKIP_SUBTREE just skips subtree traversals, but continues with lists or siblings. If you pass ERRORMODE_SKIP_PROCINFO
	/// the sequence of ProcessInfo members will be executed completely, whether errors occur or not. The most tolerant mode is
	/// ERRORMODE_SKIP_PROCINFO where only errors impeding further traversing stop the job.
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ProcessInfoC : BSerializable
	{
	
		#region Constructors
		
		public ProcessInfoC() {
		}		
		
		public ProcessInfoC(ProcessInfoC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Do not filter by SORD status.
		/// </summary>
		public const int DELSTATUS_ALL = -1;

		/// <summary>
		/// filter ony deleted SORDs.
		/// </summary>
		public const int DELSTATUS_DELETED = 1;

		/// <summary>
		/// Filter only undeleted SORDs.
		/// </summary>
		public const int DELSTATUS_VALID = 0;

		/// <summary>
		/// Processing will be stopped when an error occurs, regardless of the error type.
		/// </summary>
		public const int ERRORMODE_ALL = 0;

		/// <summary>
		/// Stop only on non-recoverable errors.
		/// </summary>
		public const int ERRORMODE_CRITICAL_ONLY = 3;

		/// <summary>
		/// Stop the ProcessInfo sequence for the current Node.
		/// </summary>
		public const int ERRORMODE_SKIP_PROCINFO = 2;

		/// <summary>
		/// Stop the subtree processing (processTrees only), but continue with list
		/// elements respectively siblings.
		/// </summary>
		public const int ERRORMODE_SKIP_SUBTREE = 1;

		/// <summary>
		/// Maximum allowed amount of error messages.
		/// </summary>
		public const int PROCMSGMAX = 100;

		#endregion
		
		
		public static readonly long serialVersionUID = 659513392L;		
	} // end class
}  // end namespace

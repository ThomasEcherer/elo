//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	/// <summary>
	/// Predefined value names for HealthCheckInfo objects.
	/// </summary>
	public class HealthCheckValueNameC : BSerializable
	{
	
		#region Constructors
		
		public HealthCheckValueNameC() {
		}		
		
		public HealthCheckValueNameC(HealthCheckValueNameC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Name of dynamically evaluated values starts with this prefix.
		/// </summary>
		public const String DYNAMIC = "elo.archive.dynamic.";

		/// <summary>
		/// Number of logically documents.
		/// </summary>
		public const String NB_OF_DOCUMENTS = "elo.archive.dynamic.nbOfDocuments";

		/// <summary>
		/// Number of document files (resp. number of document versions).
		/// </summary>
		public const String NB_OF_DOCUMENT_FILES = "elo.archive.dynamic.nbOfDocumentFiles";

		/// <summary>
		/// Total size of document files (resp. document versions).
		/// </summary>
		public const String TOTAL_SIZE_OF_DOCUMENT_FILES = "elo.archive.dynamic.totalSizeOfDocumentFiles";

		/// <summary>
		/// Number of document files with backup.
		/// </summary>
		public const String NB_OF_DOCUMENT_FILES_WITH_BACKUP = "elo.archive.dynamic.nbOfDocumentFilesWithBackup";

		/// <summary>
		/// Number of logically documents without backup.
		/// </summary>
		public const String NB_OF_DOCUMENT_FILES_WITHOUT_BACKUP = "elo.archive.dynamic.nbOfDocumentFilesWithoutBackup";

		/// <summary>
		/// Number of failed logins.
		/// </summary>
		/// <remarks>
		/// Due to wrong name or password.
		/// </remarks>
		public const String NB_OF_FAILED_LOGINS = "elo.nbOfFailedLogins";

		#endregion
		
		
		public static readonly long serialVersionUID = 2106201675L;		
	} // end class
}  // end namespace

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
	/// Defines the Options of an Import.
	/// </summary>
	/// <remarks>
	/// Each Option is represented by one bit. Several Options can be
	/// put together by a bit-logic and.
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ImportOptionsC : BSerializable
	{
	
		#region Constructors
		
		public ImportOptionsC() {
		}		
		
		public ImportOptionsC(ImportOptionsC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Import all data in a new structure.
		/// </summary>
		public const long CREATE_SEPARATE_STRUCTURE = 2L;

		/// <summary>
		/// Keep guids on import, generate new guid if guid is already used.
		/// </summary>
		public const long GUIDS_KEEP = 1L;

		/// <summary>
		/// import only guids that are not already used.
		/// </summary>
		public const long GUIDS_KEEP_AND_SKIP = 2L;

		/// <summary>
		/// generate new guids during import.
		/// </summary>
		public const long GUIDS_NEW = 0L;

		/// <summary>
		/// make a new version for document with this guid.
		/// </summary>
		public const long GUIDS_SCRIPT = 3L;

		/// <summary>
		/// Use original filing-date (Sord.iDateIso saved in export) when filing during import.
		/// </summary>
		public const long KEEP_FILING_DATE = 4L;

		/// <summary>
		/// Use original filing-path for import (original path of exporting archive was saved during
		/// export)
		/// </summary>
		public const long USE_EXPORTED_PATH = 1L;

		/// <summary>
		/// Import keywords
		/// </summary>
		public const long IMPORT_KEYWORDS = 8L;

		/// <summary>
		/// Use parent's ACL in archive
		/// </summary>
		public const long USE_PARENT_ACL = 16L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1908370444L;		
	} // end class
}  // end namespace

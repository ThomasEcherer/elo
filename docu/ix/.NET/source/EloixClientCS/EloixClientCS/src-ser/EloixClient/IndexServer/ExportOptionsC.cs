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
	/// Constants class for the ExportOptions class.
	/// </summary>
	/// <remarks>
	/// Contains constants used when
	/// exporting objects from the ELO archive.
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ExportOptionsC : BSerializable
	{
	
		#region Constructors
		
		public ExportOptionsC() {
		}		
		
		public ExportOptionsC(ExportOptionsC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Include other versions in the export.
		/// </summary>
		/// <remarks>
		/// The default is to only export the
		/// current active document.
		/// </remarks>
		public const long EXPORT_ALL_VERSIONS = 8L;

		/// <summary>
		/// Include the document-files in the export.
		/// </summary>
		public const long EXPORT_DOCUMENTS = 1L;

		/// <summary>
		/// Include the used keyword-lists in the export.
		/// </summary>
		public const long EXPORT_KEYWORDS = 2L;

		/// <summary>
		/// Include refereced documents in the export.
		/// </summary>
		public const long EXPORT_REFERENCED_DOCUMENTS = 4L;

		#endregion
		
		
		public static readonly long serialVersionUID = 2043834611L;		
	} // end class
}  // end namespace

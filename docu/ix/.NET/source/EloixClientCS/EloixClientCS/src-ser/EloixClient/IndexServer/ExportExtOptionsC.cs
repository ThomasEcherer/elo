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
	/// Constant class for the ExportExtOptions class.
	/// </summary>
	/// <remarks>
	/// (The default value are always 0)
	/// </remarks>
	public class ExportExtOptionsC : BSerializable
	{
	
		#region Constructors
		
		public ExportExtOptionsC() {
		}		
		
		public ExportExtOptionsC(ExportExtOptionsC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Objects from archive are exported
		/// </summary>
		public const int EXPORT_SRC_TYPE_ARCHIVE = 0;

		/// <summary>
		/// Search results are exported
		/// </summary>
		public const int EXPORT_SRC_TYPE_SEARCH = 1;

		/// <summary>
		/// Export filtered according document date
		/// </summary>
		public const int EXPORT_DATE_TYPE_DOC = 0;

		/// <summary>
		/// Export filtered according depot date
		/// </summary>
		public const int EXPORT_DATE_TYPE_DEPOT = 1;

		#endregion
		
		
		public static readonly long serialVersionUID = 162646972L;		
	} // end class
}  // end namespace

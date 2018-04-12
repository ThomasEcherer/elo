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
	/// Constants to copy or move archive entries, or to create a logical link.
	/// </summary>
	/// <remarks>
	/// These constants are used
	/// as parameters in the copySord function.
	/// <p>
	/// Copyright: Copyright (c) 2004
	/// </p>
	/// <p>
	/// Organisation: ELO Digital Office GmbH
	/// </p>
	/// </remarks>
	public class CopySordC : BSerializable
	{
	
		#region Constructors
		
		public CopySordC() {
		}		
		
		public CopySordC(CopySordC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Move an archive entry.
		/// </summary>
		public const long bsetMOVE = 1L;

		/// <summary>
		/// Create a logical link.
		/// </summary>
		public const long bsetREFERENCE = 2L;

		/// <summary>
		/// Reserved.
		/// </summary>
		/// <remarks>
		/// Use ProcessCopyElements and processTrees to copy an archive structure.
		/// </remarks>
		public const long bsetCOPY = 4L;

		/// <summary>
		/// Copy archive entry with children (CURRENTLY NOT SUPPORTED!).
		/// </summary>
		public const long bsetCOPY_WITH_CHILDREN = 8L;

		/// <summary>
		/// Copy archive entry with documents (CURRENTLY NOT SUPPORTED!).
		/// </summary>
		public const long bsetCOPY_WITH_DOCUMENTS = 16L;

		/// <summary>
		/// Copy archive entry with document versions (CURRENTLY NOT SUPPORTED!).
		/// </summary>
		public const long bsetCOPY_WITH_DOCUMENT_VERSIONS = 32L;

		/// <summary>
		/// Copy archive entry with attachments (CURRENTLY NOT SUPPORTED!).
		/// </summary>
		public const long bsetCOPY_WITH_ATTACHMENTS = 64L;

		/// <summary>
		/// Copy archive entry with attachment versions (CURRENTLY NOT SUPPORTED!).
		/// </summary>
		public const long bsetCOPY_WITH_ATTACHMENT_VERSIONS = 128L;

		/// <summary>
		/// Copy archive entry with notes (CURRENTLY NOT SUPPORTED!).
		/// </summary>
		public const long bsetCOPY_WITH_NOTES_TYPE_NORMAL = 256L;

		/// <summary>
		/// Copy archive entry with personal notes (CURRENTLY NOT SUPPORTED!).
		/// </summary>
		public const long bsetCOPY_WITH_NOTES_TYPE_PERSONAL = 512L;

		/// <summary>
		/// Copy archive entry with stamps (CURRENTLY NOT SUPPORTED!).
		/// </summary>
		public const long bsetCOPY_WITH_NOTES_TYPE_STAMP = 1024L;

		/// <summary>
		/// RESERVED.
		/// </summary>
		/// <remarks>
		/// Use ProcessCopyElements and processTrees to copy an archive structure.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CopySordZ COPY = new CopySordZ(4L);

		/// <summary>
		/// Move the sord.
		/// </summary>
		/// <remarks>
		/// Used in ix.copySord(...).
		/// </remarks>
		public readonly static EloixClient.IndexServer.CopySordZ MOVE = new CopySordZ(1L);

		/// <summary>
		/// Create a reference to the sord.
		/// </summary>
		/// <remarks>
		/// Used in ix.copySord(...).
		/// </remarks>
		public readonly static EloixClient.IndexServer.CopySordZ REFERENCE = new CopySordZ(2L);

		#endregion
		
		
		public static readonly long serialVersionUID = 1616091412L;		
	} // end class
}  // end namespace

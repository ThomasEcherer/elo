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
	/// Options for extended export.
	/// </summary>
	public class ExportExtOptions : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ExportExtOptions() {
		}		
		
		public ExportExtOptions(int @srcType, String[] @srcList, String @searchId, bool @exportDocs, bool @exportDocsVersions, bool @exportAttachments, bool @exportKeywords, bool @exportReminders, bool @replaceRefWithOriginal, bool @exportEncrytedDocs, bool @exportStructure, bool @ignoreEmptyFolders, String @dateStartIso, String @dateEndIso, int @dateType, String[] @masksList) {
			this.srcTypeValue = @srcType;
			this.srcListValue = @srcList;
			this.searchIdValue = @searchId;
			this.exportDocsValue = @exportDocs;
			this.exportDocsVersionsValue = @exportDocsVersions;
			this.exportAttachmentsValue = @exportAttachments;
			this.exportKeywordsValue = @exportKeywords;
			this.exportRemindersValue = @exportReminders;
			this.replaceRefWithOriginalValue = @replaceRefWithOriginal;
			this.exportEncrytedDocsValue = @exportEncrytedDocs;
			this.exportStructureValue = @exportStructure;
			this.ignoreEmptyFoldersValue = @ignoreEmptyFolders;
			this.dateStartIsoValue = @dateStartIso;
			this.dateEndIsoValue = @dateEndIso;
			this.dateTypeValue = @dateType;
			this.masksListValue = @masksList;
		}		
		
		public ExportExtOptions(ExportExtOptions rhs) : base(rhs)
		{
			this.srcTypeValue = rhs.srcTypeValue;
			this.srcListValue = rhs.srcListValue;
			this.searchIdValue = rhs.searchIdValue;
			this.exportDocsValue = rhs.exportDocsValue;
			this.exportDocsVersionsValue = rhs.exportDocsVersionsValue;
			this.exportAttachmentsValue = rhs.exportAttachmentsValue;
			this.exportKeywordsValue = rhs.exportKeywordsValue;
			this.exportRemindersValue = rhs.exportRemindersValue;
			this.replaceRefWithOriginalValue = rhs.replaceRefWithOriginalValue;
			this.exportEncrytedDocsValue = rhs.exportEncrytedDocsValue;
			this.exportStructureValue = rhs.exportStructureValue;
			this.ignoreEmptyFoldersValue = rhs.ignoreEmptyFoldersValue;
			this.dateStartIsoValue = rhs.dateStartIsoValue;
			this.dateEndIsoValue = rhs.dateEndIsoValue;
			this.dateTypeValue = rhs.dateTypeValue;
			this.masksListValue = rhs.masksListValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Type of the export's source (archive or search results)
		/// </summary>
		public int srcType
		{
			get
			{
				return srcTypeValue;
			}
			set
			{
				this.srcTypeValue = value;
			}
		}
		
		
		/// <summary>
		/// List of the source objects IDs (folders in archive or search results)
		/// </summary>
		public String[] srcList
		{
			get
			{
				return srcListValue;
			}
			set
			{
				this.srcListValue = value;
			}
		}
		
		
		/// <summary>
		/// If the source is the search and if all results have to be exported,
		/// then this option must be set with the search's ID.
		/// </summary>
		public String searchId
		{
			get
			{
				return searchIdValue;
			}
			set
			{
				this.searchIdValue = value;
			}
		}
		
		
		public bool exportDocs
		{
			get
			{
				return exportDocsValue;
			}
			set
			{
				this.exportDocsValue = value;
			}
		}
		
		
		public bool exportDocsVersions
		{
			get
			{
				return exportDocsVersionsValue;
			}
			set
			{
				this.exportDocsVersionsValue = value;
			}
		}
		
		
		public bool exportAttachments
		{
			get
			{
				return exportAttachmentsValue;
			}
			set
			{
				this.exportAttachmentsValue = value;
			}
		}
		
		
		public bool exportKeywords
		{
			get
			{
				return exportKeywordsValue;
			}
			set
			{
				this.exportKeywordsValue = value;
			}
		}
		
		
		public bool exportReminders
		{
			get
			{
				return exportRemindersValue;
			}
			set
			{
				this.exportRemindersValue = value;
			}
		}
		
		
		public bool replaceRefWithOriginal
		{
			get
			{
				return replaceRefWithOriginalValue;
			}
			set
			{
				this.replaceRefWithOriginalValue = value;
			}
		}
		
		
		/// <summary>
		/// Export encrypted documents too?
		/// </summary>
		public bool exportEncrytedDocs
		{
			get
			{
				return exportEncrytedDocsValue;
			}
			set
			{
				this.exportEncrytedDocsValue = value;
			}
		}
		
		
		/// <summary>
		/// Export documents to filesystem structure.
		/// </summary>
		/// <remarks>
		/// If this member is false, only documents are exported and
		/// they are all located at the root export folder.
		/// </remarks>
		public bool exportStructure
		{
			get
			{
				return exportStructureValue;
			}
			set
			{
				this.exportStructureValue = value;
			}
		}
		
		
		/// <summary>
		/// Do not export empty branches (without any document).
		/// </summary>
		public bool ignoreEmptyFolders
		{
			get
			{
				return ignoreEmptyFoldersValue;
			}
			set
			{
				this.ignoreEmptyFoldersValue = value;
			}
		}
		
		
		/// <summary>
		/// Beginning date for filter in ISO format (null for no date)
		/// </summary>
		public String dateStartIso
		{
			get
			{
				return dateStartIsoValue;
			}
			set
			{
				this.dateStartIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Ending date for filter in ISO format (null for no date)
		/// </summary>
		public String dateEndIso
		{
			get
			{
				return dateEndIsoValue;
			}
			set
			{
				this.dateEndIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Which type of date must be considered?
		/// </summary>
		public int dateType
		{
			get
			{
				return dateTypeValue;
			}
			set
			{
				this.dateTypeValue = value;
			}
		}
		
		
		/// <summary>
		/// List of masks IDs to export
		/// Empty list means: export all objects regardless of the masks.
		/// </summary>
		public String[] masksList
		{
			get
			{
				return masksListValue;
			}
			set
			{
				this.masksListValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int srcTypeValue;

		protected String[] srcListValue;

		protected String searchIdValue;

		protected bool exportDocsValue;

		protected bool exportDocsVersionsValue;

		protected bool exportAttachmentsValue;

		protected bool exportKeywordsValue;

		protected bool exportRemindersValue;

		protected bool replaceRefWithOriginalValue;

		protected bool exportEncrytedDocsValue;

		protected bool exportStructureValue;

		protected bool ignoreEmptyFoldersValue;

		protected String dateStartIsoValue;

		protected String dateEndIsoValue;

		protected int dateTypeValue;

		protected String[] masksListValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 291967L;		
	} // end class
}  // end namespace

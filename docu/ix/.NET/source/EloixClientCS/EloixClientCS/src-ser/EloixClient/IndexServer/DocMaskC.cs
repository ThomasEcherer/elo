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
	/// <p>Constants related to class <code>DocMask</code>.
	/// </summary>
	/// <remarks>
	/// Some of the <code>MFG_</code> values are used in the member
	/// <code>Flags</code> of class <code>Sord</code> too.
	/// Each member of this class with prefix "mb" has a corresponding member in
	/// class <code>DocMask</code></p> * </p>
	/// </remarks>
	public class DocMaskC : EloixClient.IndexServer.DocMaskDataC, BSerializable
	{
	
		#region Constructors
		
		public DocMaskC() {
		}		
		
		public DocMaskC(String @GUID_BASIC, String @GUID_EMAIL, String @GUID_STRUCTURE_ELEMENT, String @GUID_CONTACT, String @GUID_FOLDER, String @GUID_SEARCH, String @GUID_ELOSCRIPTS, String @GUID_USER_FOLDER, String @GUID_MS_SHAREPOINT_DOCUMENT, int @lnAcl) {
			this.GUID_BASICValue = @GUID_BASIC;
			this.GUID_EMAILValue = @GUID_EMAIL;
			this.GUID_STRUCTURE_ELEMENTValue = @GUID_STRUCTURE_ELEMENT;
			this.GUID_CONTACTValue = @GUID_CONTACT;
			this.GUID_FOLDERValue = @GUID_FOLDER;
			this.GUID_SEARCHValue = @GUID_SEARCH;
			this.GUID_ELOSCRIPTSValue = @GUID_ELOSCRIPTS;
			this.GUID_USER_FOLDERValue = @GUID_USER_FOLDER;
			this.GUID_MS_SHAREPOINT_DOCUMENTValue = @GUID_MS_SHAREPOINT_DOCUMENT;
			this.lnAclValue = @lnAcl;
		}		
		
		public DocMaskC(DocMaskC rhs) : base(rhs)
		{
			this.GUID_BASICValue = rhs.GUID_BASICValue;
			this.GUID_EMAILValue = rhs.GUID_EMAILValue;
			this.GUID_STRUCTURE_ELEMENTValue = rhs.GUID_STRUCTURE_ELEMENTValue;
			this.GUID_CONTACTValue = rhs.GUID_CONTACTValue;
			this.GUID_FOLDERValue = rhs.GUID_FOLDERValue;
			this.GUID_SEARCHValue = rhs.GUID_SEARCHValue;
			this.GUID_ELOSCRIPTSValue = rhs.GUID_ELOSCRIPTSValue;
			this.GUID_USER_FOLDERValue = rhs.GUID_USER_FOLDERValue;
			this.GUID_MS_SHAREPOINT_DOCUMENTValue = rhs.GUID_MS_SHAREPOINT_DOCUMENTValue;
			this.lnAclValue = rhs.lnAclValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Predefined GUID for keywording form "Freie Eingabe".
		/// </summary>
		public String GUID_BASIC
		{
			get
			{
				return GUID_BASICValue;
			}
			set
			{
				this.GUID_BASICValue = value;
			}
		}
		
		
		/// <summary>
		/// Predefined GUID for keywording form "EMail".
		/// </summary>
		public String GUID_EMAIL
		{
			get
			{
				return GUID_EMAILValue;
			}
			set
			{
				this.GUID_EMAILValue = value;
			}
		}
		
		
		/// <summary>
		/// Predefined GUID for keywording form "Strukturelement".
		/// </summary>
		public String GUID_STRUCTURE_ELEMENT
		{
			get
			{
				return GUID_STRUCTURE_ELEMENTValue;
			}
			set
			{
				this.GUID_STRUCTURE_ELEMENTValue = value;
			}
		}
		
		
		/// <summary>
		/// Predefined GUID for keywording form "Kontakt".
		/// </summary>
		public String GUID_CONTACT
		{
			get
			{
				return GUID_CONTACTValue;
			}
			set
			{
				this.GUID_CONTACTValue = value;
			}
		}
		
		
		/// <summary>
		/// Predefined GUID for the keywording form used for folders by default.
		/// </summary>
		public String GUID_FOLDER
		{
			get
			{
				return GUID_FOLDERValue;
			}
			set
			{
				this.GUID_FOLDERValue = value;
			}
		}
		
		
		/// <summary>
		/// Predefined GUID for the keywording form used to search entries regardless of their storage mask.
		/// </summary>
		public String GUID_SEARCH
		{
			get
			{
				return GUID_SEARCHValue;
			}
			set
			{
				this.GUID_SEARCHValue = value;
			}
		}
		
		
		/// <summary>
		/// Predefined GUID for the keywording form used for scripts.
		/// </summary>
		public String GUID_ELOSCRIPTS
		{
			get
			{
				return GUID_ELOSCRIPTSValue;
			}
			set
			{
				this.GUID_ELOSCRIPTSValue = value;
			}
		}
		
		
		/// <summary>
		/// Predefined GUID for the keywording form used by user folders.
		/// </summary>
		public String GUID_USER_FOLDER
		{
			get
			{
				return GUID_USER_FOLDERValue;
			}
			set
			{
				this.GUID_USER_FOLDERValue = value;
			}
		}
		
		
		/// <summary>
		/// Prefefined GUID for a keywording form for MS Sharepoint documents.
		/// </summary>
		public String GUID_MS_SHAREPOINT_DOCUMENT
		{
			get
			{
				return GUID_MS_SHAREPOINT_DOCUMENTValue;
			}
			set
			{
				this.GUID_MS_SHAREPOINT_DOCUMENTValue = value;
			}
		}
		
		
		/// <summary>
		/// ACL length
		/// </summary>
		public int lnAcl
		{
			get
			{
				return lnAclValue;
			}
			set
			{
				this.lnAclValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String GUID_BASICValue;

		protected String GUID_EMAILValue;

		protected String GUID_STRUCTURE_ELEMENTValue;

		protected String GUID_CONTACTValue;

		protected String GUID_FOLDERValue;

		protected String GUID_SEARCHValue;

		protected String GUID_ELOSCRIPTSValue;

		protected String GUID_USER_FOLDERValue;

		protected String GUID_MS_SHAREPOINT_DOCUMENTValue;

		/// <summary>
		/// Member bit: ACL
		/// </summary>
		public const long mbAcl = 262144L;

		protected int lnAclValue;

		/// <summary>
		/// Member bit: use the ACL items in the member
		/// DocMask.aclItems and DocMask.docAclItems for reading and writing.
		/// </summary>
		public const long mbAclItems = 1125899906842624L;

		/// <summary>
		/// Member bit: read or write index lines.
		/// </summary>
		public const long mbMaskLines = 2251799813685248L;

		/// <summary>
		/// Member bit: read or write all elements.
		/// </summary>
		public new const long mbAllMembers = 4503599627370495L;

		/// <summary>
		/// Member bit: this bit should be set if the Mask is to be used for structure elements and not for
		/// documents.
		/// </summary>
		/// <remarks>
		/// The effect is that the member DocMask.details.sortOrder is
		/// filled instead of DocMask.details.archivingMode.
		/// </remarks>
		public const long mbSortOrderNotArchivingMode = 9007199254740992L;

		/// <summary>
		/// Read or write all elements.
		/// </summary>
		public readonly static EloixClient.IndexServer.DocMaskZ mbAll = new DocMaskZ(4503599627370495L);

		/// <summary>
		/// Only lock or unlock
		/// </summary>
		public readonly static EloixClient.IndexServer.DocMaskZ mbOnlyLock = new DocMaskZ(0L);

		public const long mbDetails = 512L;

		public const long mbDocAclItems = 2048L;

		public const long mbLines = 2251799813685248L;

		public const long mbDeleted = 131072L;

		/// <summary>
		/// Store index values as key-value-pairs in the objkeys table.
		/// </summary>
		public const int DATA_ORGANISATION_OBJKEYS = 0;

		/// <summary>
		/// Store index values in columns of a dedicated table.
		/// </summary>
		public const int DATA_ORGANISATION_TABLE = 1;

		#endregion
		
		
		public static readonly new long serialVersionUID = 387842089L;		
	} // end class
}  // end namespace

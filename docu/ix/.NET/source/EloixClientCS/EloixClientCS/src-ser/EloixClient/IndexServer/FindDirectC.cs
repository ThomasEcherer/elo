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
	/// Constants used in class FindDirect
	/// </summary>
	public class FindDirectC : BSerializable
	{
	
		#region Constructors
		
		public FindDirectC() {
		}		
		
		public FindDirectC(String @FIELD_DESC, String @FIELD_EXT, String @FIELD_OWNER, String @FIELD_TSTAMP, String @FIELD_GUID, String @FIELD_ID, String @FIELD_DELDATE, String @FIELD_DELDATE_YEAR, String @FIELD_DELDATE_MONTH, String @FIELD_IDATE, String @FIELD_IDATE_YEAR, String @FIELD_IDATE_MONTH, String @FIELD_XDATE, String @FIELD_XDATE_YEAR, String @FIELD_XDATE_MONTH, String @FIELD_MASK_ID, String @FIELD_MASK_NAME, String @FIELD_NAME, String @FIELD_OWNER_ID, String @FIELD_TYPE, String @FIELD_OBJ_KEY, String @FIELD_OBJ_KEY_TOKENIZED, String @FIELD_OBJ_KEY_NUMERIC, String @FIELD_OBJ_KEY_DATE, String @FIELD_DOC_SIZE, String @FIELD_VERSION_NUMBER, String @FIELD_VERSION_COMMENT, String @FIELD_VERSION_OWNER) {
			this.FIELD_DESCValue = @FIELD_DESC;
			this.FIELD_EXTValue = @FIELD_EXT;
			this.FIELD_OWNERValue = @FIELD_OWNER;
			this.FIELD_TSTAMPValue = @FIELD_TSTAMP;
			this.FIELD_GUIDValue = @FIELD_GUID;
			this.FIELD_IDValue = @FIELD_ID;
			this.FIELD_DELDATEValue = @FIELD_DELDATE;
			this.FIELD_DELDATE_YEARValue = @FIELD_DELDATE_YEAR;
			this.FIELD_DELDATE_MONTHValue = @FIELD_DELDATE_MONTH;
			this.FIELD_IDATEValue = @FIELD_IDATE;
			this.FIELD_IDATE_YEARValue = @FIELD_IDATE_YEAR;
			this.FIELD_IDATE_MONTHValue = @FIELD_IDATE_MONTH;
			this.FIELD_XDATEValue = @FIELD_XDATE;
			this.FIELD_XDATE_YEARValue = @FIELD_XDATE_YEAR;
			this.FIELD_XDATE_MONTHValue = @FIELD_XDATE_MONTH;
			this.FIELD_MASK_IDValue = @FIELD_MASK_ID;
			this.FIELD_MASK_NAMEValue = @FIELD_MASK_NAME;
			this.FIELD_NAMEValue = @FIELD_NAME;
			this.FIELD_OWNER_IDValue = @FIELD_OWNER_ID;
			this.FIELD_TYPEValue = @FIELD_TYPE;
			this.FIELD_OBJ_KEYValue = @FIELD_OBJ_KEY;
			this.FIELD_OBJ_KEY_TOKENIZEDValue = @FIELD_OBJ_KEY_TOKENIZED;
			this.FIELD_OBJ_KEY_NUMERICValue = @FIELD_OBJ_KEY_NUMERIC;
			this.FIELD_OBJ_KEY_DATEValue = @FIELD_OBJ_KEY_DATE;
			this.FIELD_DOC_SIZEValue = @FIELD_DOC_SIZE;
			this.FIELD_VERSION_NUMBERValue = @FIELD_VERSION_NUMBER;
			this.FIELD_VERSION_COMMENTValue = @FIELD_VERSION_COMMENT;
			this.FIELD_VERSION_OWNERValue = @FIELD_VERSION_OWNER;
		}		
		
		public FindDirectC(FindDirectC rhs)
		{
			this.FIELD_DESCValue = rhs.FIELD_DESCValue;
			this.FIELD_EXTValue = rhs.FIELD_EXTValue;
			this.FIELD_OWNERValue = rhs.FIELD_OWNERValue;
			this.FIELD_TSTAMPValue = rhs.FIELD_TSTAMPValue;
			this.FIELD_GUIDValue = rhs.FIELD_GUIDValue;
			this.FIELD_IDValue = rhs.FIELD_IDValue;
			this.FIELD_DELDATEValue = rhs.FIELD_DELDATEValue;
			this.FIELD_DELDATE_YEARValue = rhs.FIELD_DELDATE_YEARValue;
			this.FIELD_DELDATE_MONTHValue = rhs.FIELD_DELDATE_MONTHValue;
			this.FIELD_IDATEValue = rhs.FIELD_IDATEValue;
			this.FIELD_IDATE_YEARValue = rhs.FIELD_IDATE_YEARValue;
			this.FIELD_IDATE_MONTHValue = rhs.FIELD_IDATE_MONTHValue;
			this.FIELD_XDATEValue = rhs.FIELD_XDATEValue;
			this.FIELD_XDATE_YEARValue = rhs.FIELD_XDATE_YEARValue;
			this.FIELD_XDATE_MONTHValue = rhs.FIELD_XDATE_MONTHValue;
			this.FIELD_MASK_IDValue = rhs.FIELD_MASK_IDValue;
			this.FIELD_MASK_NAMEValue = rhs.FIELD_MASK_NAMEValue;
			this.FIELD_NAMEValue = rhs.FIELD_NAMEValue;
			this.FIELD_OWNER_IDValue = rhs.FIELD_OWNER_IDValue;
			this.FIELD_TYPEValue = rhs.FIELD_TYPEValue;
			this.FIELD_OBJ_KEYValue = rhs.FIELD_OBJ_KEYValue;
			this.FIELD_OBJ_KEY_TOKENIZEDValue = rhs.FIELD_OBJ_KEY_TOKENIZEDValue;
			this.FIELD_OBJ_KEY_NUMERICValue = rhs.FIELD_OBJ_KEY_NUMERICValue;
			this.FIELD_OBJ_KEY_DATEValue = rhs.FIELD_OBJ_KEY_DATEValue;
			this.FIELD_DOC_SIZEValue = rhs.FIELD_DOC_SIZEValue;
			this.FIELD_VERSION_NUMBERValue = rhs.FIELD_VERSION_NUMBERValue;
			this.FIELD_VERSION_COMMENTValue = rhs.FIELD_VERSION_COMMENTValue;
			this.FIELD_VERSION_OWNERValue = rhs.FIELD_VERSION_OWNERValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// ELO iSearch field: descripton (memo text, Sord.desc)
		/// </summary>
		public String FIELD_DESC
		{
			get
			{
				return FIELD_DESCValue;
			}
			set
			{
				this.FIELD_DESCValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: document file extension without leading dot (DocVersion.ext)
		/// </summary>
		public String FIELD_EXT
		{
			get
			{
				return FIELD_EXTValue;
			}
			set
			{
				this.FIELD_EXTValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: owner name (Sord.ownerName)
		/// </summary>
		public String FIELD_OWNER
		{
			get
			{
				return FIELD_OWNERValue;
			}
			set
			{
				this.FIELD_OWNERValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: last modified time stamp, UTC (Sord.tStamp)
		/// </summary>
		public String FIELD_TSTAMP
		{
			get
			{
				return FIELD_TSTAMPValue;
			}
			set
			{
				this.FIELD_TSTAMPValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: GUID (Sord.guid)
		/// </summary>
		public String FIELD_GUID
		{
			get
			{
				return FIELD_GUIDValue;
			}
			set
			{
				this.FIELD_GUIDValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: ID (Sord.id)
		/// </summary>
		public String FIELD_ID
		{
			get
			{
				return FIELD_IDValue;
			}
			set
			{
				this.FIELD_IDValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: ISO formatted delete date, UTC (Sord.delDateIso)
		/// </summary>
		public String FIELD_DELDATE
		{
			get
			{
				return FIELD_DELDATEValue;
			}
			set
			{
				this.FIELD_DELDATEValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: Year of delete date, UTC (Sord.delDateIso)
		/// </summary>
		public String FIELD_DELDATE_YEAR
		{
			get
			{
				return FIELD_DELDATE_YEARValue;
			}
			set
			{
				this.FIELD_DELDATE_YEARValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: Month of delete date, UTC (Sord.delDateIso), always 2 characters, e.g. 01 for January.
		/// </summary>
		public String FIELD_DELDATE_MONTH
		{
			get
			{
				return FIELD_DELDATE_MONTHValue;
			}
			set
			{
				this.FIELD_DELDATE_MONTHValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: ISO formatted archiving date, UTC (Sord.iDateIso)
		/// </summary>
		public String FIELD_IDATE
		{
			get
			{
				return FIELD_IDATEValue;
			}
			set
			{
				this.FIELD_IDATEValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: Year of archiving date, UTC (Sord.iDateIso)
		/// </summary>
		public String FIELD_IDATE_YEAR
		{
			get
			{
				return FIELD_IDATE_YEARValue;
			}
			set
			{
				this.FIELD_IDATE_YEARValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: Month of archiving date, UTC (Sord.iDateIso), always 2 characters, e.g. 01 for January.
		/// </summary>
		public String FIELD_IDATE_MONTH
		{
			get
			{
				return FIELD_IDATE_MONTHValue;
			}
			set
			{
				this.FIELD_IDATE_MONTHValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: ISO formatted document date, UTC (Sord.xDateIso)
		/// </summary>
		public String FIELD_XDATE
		{
			get
			{
				return FIELD_XDATEValue;
			}
			set
			{
				this.FIELD_XDATEValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: Year of document date, UTC (Sord.xDateIso)
		/// </summary>
		public String FIELD_XDATE_YEAR
		{
			get
			{
				return FIELD_XDATE_YEARValue;
			}
			set
			{
				this.FIELD_XDATE_YEARValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: Month of document date, UTC (Sord.xDateIso), always 2 characters, e.g. 01 for January.
		/// </summary>
		public String FIELD_XDATE_MONTH
		{
			get
			{
				return FIELD_XDATE_MONTHValue;
			}
			set
			{
				this.FIELD_XDATE_MONTHValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: Keywording form ID, (Sord.mask)
		/// </summary>
		public String FIELD_MASK_ID
		{
			get
			{
				return FIELD_MASK_IDValue;
			}
			set
			{
				this.FIELD_MASK_IDValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: Keywording form name, (Sord.maskName)
		/// </summary>
		public String FIELD_MASK_NAME
		{
			get
			{
				return FIELD_MASK_NAMEValue;
			}
			set
			{
				this.FIELD_MASK_NAMEValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: short description (Sord.name)
		/// </summary>
		public String FIELD_NAME
		{
			get
			{
				return FIELD_NAMEValue;
			}
			set
			{
				this.FIELD_NAMEValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: owner ID (Sord.ownerId)
		/// </summary>
		public String FIELD_OWNER_ID
		{
			get
			{
				return FIELD_OWNER_IDValue;
			}
			set
			{
				this.FIELD_OWNER_IDValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: folder or document type (Sord.type)
		/// </summary>
		public String FIELD_TYPE
		{
			get
			{
				return FIELD_TYPEValue;
			}
			set
			{
				this.FIELD_TYPEValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: group name of index field (Sord.objKey[.].name, DocMask.line[.].key)
		/// </summary>
		public String FIELD_OBJ_KEY
		{
			get
			{
				return FIELD_OBJ_KEYValue;
			}
			set
			{
				this.FIELD_OBJ_KEYValue = value;
			}
		}
		
		
		/// <summary>
		/// ELO iSearch field: group name of index field (Sord.objKey[.].name, DocMask.line[.].key)
		/// This field contains tokenized content (linguistic processing applied)
		/// </summary>
		public String FIELD_OBJ_KEY_TOKENIZED
		{
			get
			{
				return FIELD_OBJ_KEY_TOKENIZEDValue;
			}
			set
			{
				this.FIELD_OBJ_KEY_TOKENIZEDValue = value;
			}
		}
		
		
		/// <summary>
		/// Numeric Indexfields (nLINE)
		/// </summary>
		public String FIELD_OBJ_KEY_NUMERIC
		{
			get
			{
				return FIELD_OBJ_KEY_NUMERICValue;
			}
			set
			{
				this.FIELD_OBJ_KEY_NUMERICValue = value;
			}
		}
		
		
		/// <summary>
		/// Date Indexfields (dLINE)
		/// </summary>
		public String FIELD_OBJ_KEY_DATE
		{
			get
			{
				return FIELD_OBJ_KEY_DATEValue;
			}
			set
			{
				this.FIELD_OBJ_KEY_DATEValue = value;
			}
		}
		
		
		/// <summary>
		/// Document size
		/// </summary>
		public String FIELD_DOC_SIZE
		{
			get
			{
				return FIELD_DOC_SIZEValue;
			}
			set
			{
				this.FIELD_DOC_SIZEValue = value;
			}
		}
		
		
		/// <summary>
		/// DocVersion.version
		/// </summary>
		public String FIELD_VERSION_NUMBER
		{
			get
			{
				return FIELD_VERSION_NUMBERValue;
			}
			set
			{
				this.FIELD_VERSION_NUMBERValue = value;
			}
		}
		
		
		/// <summary>
		/// DocVersion.comment
		/// </summary>
		public String FIELD_VERSION_COMMENT
		{
			get
			{
				return FIELD_VERSION_COMMENTValue;
			}
			set
			{
				this.FIELD_VERSION_COMMENTValue = value;
			}
		}
		
		
		/// <summary>
		/// DocVersion.ownerId
		/// </summary>
		public String FIELD_VERSION_OWNER
		{
			get
			{
				return FIELD_VERSION_OWNERValue;
			}
			set
			{
				this.FIELD_VERSION_OWNERValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String FIELD_DESCValue;

		protected String FIELD_EXTValue;

		protected String FIELD_OWNERValue;

		protected String FIELD_TSTAMPValue;

		protected String FIELD_GUIDValue;

		protected String FIELD_IDValue;

		protected String FIELD_DELDATEValue;

		protected String FIELD_DELDATE_YEARValue;

		protected String FIELD_DELDATE_MONTHValue;

		protected String FIELD_IDATEValue;

		protected String FIELD_IDATE_YEARValue;

		protected String FIELD_IDATE_MONTHValue;

		protected String FIELD_XDATEValue;

		protected String FIELD_XDATE_YEARValue;

		protected String FIELD_XDATE_MONTHValue;

		protected String FIELD_MASK_IDValue;

		protected String FIELD_MASK_NAMEValue;

		protected String FIELD_NAMEValue;

		protected String FIELD_OWNER_IDValue;

		protected String FIELD_TYPEValue;

		protected String FIELD_OBJ_KEYValue;

		protected String FIELD_OBJ_KEY_TOKENIZEDValue;

		protected String FIELD_OBJ_KEY_NUMERICValue;

		protected String FIELD_OBJ_KEY_DATEValue;

		protected String FIELD_DOC_SIZEValue;

		protected String FIELD_VERSION_NUMBERValue;

		protected String FIELD_VERSION_COMMENTValue;

		protected String FIELD_VERSION_OWNERValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 627433249L;		
	} // end class
}  // end namespace

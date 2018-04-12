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
	/// Document version data, e. g. document version ID and GUID, version comment,
	/// MD5 hash of document file.
	/// </summary>
	/// <remarks>
	/// Internal use only.
	/// </remarks>
	public class DocHistory : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public DocHistory() {
		}		
		
		public DocHistory(int @objId, int @docId, int @user, int @createDate, String @comment, String @version, String @docMD5, String @guid, String @tStamp, int @sigId, int @status, int @flags, int @deleteDate, int @nbOfValidSignatures, int @type, String @TStampSync) {
			this.objIdValue = @objId;
			this.docIdValue = @docId;
			this.userValue = @user;
			this.createDateValue = @createDate;
			this.commentValue = @comment;
			this.versionValue = @version;
			this.docMD5Value = @docMD5;
			this.guidValue = @guid;
			this.tStampValue = @tStamp;
			this.sigIdValue = @sigId;
			this.statusValue = @status;
			this.flagsValue = @flags;
			this.deleteDateValue = @deleteDate;
			this.nbOfValidSignaturesValue = @nbOfValidSignatures;
			this.typeValue = @type;
			this.TStampSyncValue = @TStampSync;
		}		
		
		public DocHistory(DocHistory rhs) : base(rhs)
		{
			this.objIdValue = rhs.objIdValue;
			this.docIdValue = rhs.docIdValue;
			this.userValue = rhs.userValue;
			this.createDateValue = rhs.createDateValue;
			this.commentValue = rhs.commentValue;
			this.versionValue = rhs.versionValue;
			this.docMD5Value = rhs.docMD5Value;
			this.guidValue = rhs.guidValue;
			this.tStampValue = rhs.tStampValue;
			this.sigIdValue = rhs.sigIdValue;
			this.statusValue = rhs.statusValue;
			this.flagsValue = rhs.flagsValue;
			this.deleteDateValue = rhs.deleteDateValue;
			this.nbOfValidSignaturesValue = rhs.nbOfValidSignaturesValue;
			this.typeValue = rhs.typeValue;
			this.TStampSyncValue = rhs.TStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Document version belongs to this object.
		/// </summary>
		/// <remarks>
		/// DB column: objectid
		/// </remarks>
		public int objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
				setChangedMember(DocHistoryC.mbObjId);
			}
		}
		
		
		/// <summary>
		/// Document version ID.
		/// </summary>
		/// <remarks>
		/// DB column: documentid
		/// </remarks>
		public int docId
		{
			get
			{
				return docIdValue;
			}
			set
			{
				this.docIdValue = value;
				setChangedMember(DocHistoryC.mbDocId);
			}
		}
		
		
		/// <summary>
		/// The user who inserts the version into the archive.
		/// </summary>
		/// <remarks>
		/// DB column: userid
		/// </remarks>
		public int user
		{
			get
			{
				return userValue;
			}
			set
			{
				this.userValue = value;
				setChangedMember(DocHistoryC.mbUser);
			}
		}
		
		
		/// <summary>
		/// The version is created at this date.
		/// </summary>
		/// <remarks>
		/// The value is an ELO date format.
		/// DB column: createdate
		/// </remarks>
		public int createDate
		{
			get
			{
				return createDateValue;
			}
			set
			{
				this.createDateValue = value;
				setChangedMember(DocHistoryC.mbCreateDate);
			}
		}
		
		
		/// <summary>
		/// The user can enter a comment that describes the version.
		/// </summary>
		/// <remarks>
		/// DB column: histcomment
		/// </remarks>
		public String comment
		{
			get
			{
				return commentValue;
			}
			set
			{
				this.commentValue = value;
				setChangedMember(DocHistoryC.mbComment);
			}
		}
		
		
		/// <summary>
		/// The version number (like 1.0) of the document version.
		/// </summary>
		/// <remarks>
		/// DB column: histversion
		/// </remarks>
		public String version
		{
			get
			{
				return versionValue;
			}
			set
			{
				this.versionValue = value;
				setChangedMember(DocHistoryC.mbVersion);
			}
		}
		
		
		/// <summary>
		/// The MD5 hash of the document file.
		/// </summary>
		/// <remarks>
		/// DB column: docmd5
		/// </remarks>
		public String docMD5
		{
			get
			{
				return docMD5Value;
			}
			set
			{
				this.docMD5Value = value;
				setChangedMember(DocHistoryC.mbDocMD5);
			}
		}
		
		
		/// <summary>
		/// GUID of the document version.
		/// </summary>
		/// <remarks>
		/// DB column: docguid
		/// </remarks>
		public String guid
		{
			get
			{
				return guidValue;
			}
			set
			{
				this.guidValue = value;
				setChangedMember(DocHistoryC.mbGuid);
			}
		}
		
		
		/// <summary>
		/// The last update time of the version in ISO format (with dots).
		/// </summary>
		/// <remarks>
		/// DB column: doctstamp
		/// </remarks>
		public String tStamp
		{
			get
			{
				return tStampValue;
			}
			set
			{
				this.tStampValue = value;
				setChangedMember(DocHistoryC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// Document signature ID.
		/// </summary>
		/// <remarks>
		/// DB column: docsignature
		/// </remarks>
		public int sigId
		{
			get
			{
				return sigIdValue;
			}
			set
			{
				this.sigIdValue = value;
				setChangedMember(DocHistoryC.mbSigId);
			}
		}
		
		
		/// <summary>
		/// Deleted versions have Status=1.
		/// </summary>
		/// <remarks>
		/// DB column: docstatus
		/// </remarks>
		public int status
		{
			get
			{
				return statusValue;
			}
			set
			{
				this.statusValue = value;
				setChangedMember(DocHistoryC.mbStatus);
			}
		}
		
		
		/// <summary>
		/// MFG_BURNIN
		/// DB column: docflags
		/// </summary>
		public int flags
		{
			get
			{
				return flagsValue;
			}
			set
			{
				this.flagsValue = value;
				setChangedMember(DocHistoryC.mbFlags);
			}
		}
		
		
		/// <summary>
		/// The version is deleted at this date.
		/// </summary>
		/// <remarks>
		/// The value is an ELO date format. The
		/// value is zero, if isDeleted() returns false.
		/// </remarks>
		public int deleteDate
		{
			get
			{
				return deleteDateValue;
			}
			set
			{
				this.deleteDateValue = value;
				setChangedMember(DocHistoryC.mbDeleteDate);
			}
		}
		
		
		/// <summary>
		/// Number of valid signatures.
		/// </summary>
		public int nbOfValidSignatures
		{
			get
			{
				return nbOfValidSignaturesValue;
			}
			set
			{
				this.nbOfValidSignaturesValue = value;
				setChangedMember(DocHistoryC.mbNbOfValidSignatures);
			}
		}
		
		
		/// <summary>
		/// The type of this DocHistory makes the difference between attachments and
		/// document versions.
		/// </summary>
		public int type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
				setChangedMember(DocHistoryC.mbType);
			}
		}
		
		
		/// <summary>
		/// Timestamp of this object's last export by the replication.
		/// </summary>
		public String TStampSync
		{
			get
			{
				return TStampSyncValue;
			}
			set
			{
				this.TStampSyncValue = value;
				setChangedMember(DocHistoryC.mbTStampSync);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int objIdValue;

		protected int docIdValue;

		protected int userValue;

		protected int createDateValue;

		protected String commentValue;

		protected String versionValue;

		protected String docMD5Value;

		protected String guidValue;

		protected String tStampValue;

		protected int sigIdValue;

		protected int statusValue;

		protected int flagsValue;

		protected int deleteDateValue;

		protected int nbOfValidSignaturesValue;

		protected int typeValue;

		protected String TStampSyncValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 189452795L;		
	} // end class
}  // end namespace

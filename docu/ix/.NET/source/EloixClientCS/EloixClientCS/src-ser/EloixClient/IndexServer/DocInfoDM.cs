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
	/// <p>Document information table of DM.
	/// </summary>
	/// <remarks>
	/// For performance reason directly read by IX</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class DocInfoDM : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public DocInfoDM() {
		}		
		
		public DocInfoDM(int @id, String @guid, int @size, String @md5, int @pathId, int @pathId2, String @createDateIso, String @lastAccessIso, String @lastUpdateIso, int @owner, String @ext, String @fclip, String @extOrig, int @sizeOrig, int @encrSet, int @previewSize, String @previewExt, String @fulltextContentTStamp, int @fulltextContentSize, long @sizeL, long @sizeOrigL, long @previewSizeL, String @relFilePath) {
			this.idValue = @id;
			this.guidValue = @guid;
			this.sizeValue = @size;
			this.md5Value = @md5;
			this.pathIdValue = @pathId;
			this.pathId2Value = @pathId2;
			this.createDateIsoValue = @createDateIso;
			this.lastAccessIsoValue = @lastAccessIso;
			this.lastUpdateIsoValue = @lastUpdateIso;
			this.ownerValue = @owner;
			this.extValue = @ext;
			this.fclipValue = @fclip;
			this.extOrigValue = @extOrig;
			this.sizeOrigValue = @sizeOrig;
			this.encrSetValue = @encrSet;
			this.previewSizeValue = @previewSize;
			this.previewExtValue = @previewExt;
			this.fulltextContentTStampValue = @fulltextContentTStamp;
			this.fulltextContentSizeValue = @fulltextContentSize;
			this.sizeLValue = @sizeL;
			this.sizeOrigLValue = @sizeOrigL;
			this.previewSizeLValue = @previewSizeL;
			this.relFilePathValue = @relFilePath;
		}		
		
		public DocInfoDM(DocInfoDM rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.guidValue = rhs.guidValue;
			this.sizeValue = rhs.sizeValue;
			this.md5Value = rhs.md5Value;
			this.pathIdValue = rhs.pathIdValue;
			this.pathId2Value = rhs.pathId2Value;
			this.createDateIsoValue = rhs.createDateIsoValue;
			this.lastAccessIsoValue = rhs.lastAccessIsoValue;
			this.lastUpdateIsoValue = rhs.lastUpdateIsoValue;
			this.ownerValue = rhs.ownerValue;
			this.extValue = rhs.extValue;
			this.fclipValue = rhs.fclipValue;
			this.extOrigValue = rhs.extOrigValue;
			this.sizeOrigValue = rhs.sizeOrigValue;
			this.encrSetValue = rhs.encrSetValue;
			this.previewSizeValue = rhs.previewSizeValue;
			this.previewExtValue = rhs.previewExtValue;
			this.fulltextContentTStampValue = rhs.fulltextContentTStampValue;
			this.fulltextContentSizeValue = rhs.fulltextContentSizeValue;
			this.sizeLValue = rhs.sizeLValue;
			this.sizeOrigLValue = rhs.sizeOrigLValue;
			this.previewSizeLValue = rhs.previewSizeLValue;
			this.relFilePathValue = rhs.relFilePathValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Document version ID.
		/// </summary>
		/// <remarks>
		/// DB column: docid
		/// </remarks>
		public int id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
				setChangedMember(DocInfoDMC.mbId);
			}
		}
		
		
		/// <summary>
		/// Document GUID.
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
				setChangedMember(DocInfoDMC.mbGuid);
			}
		}
		
		
		/// <summary>
		/// File size.
		/// </summary>
		/// <remarks>
		/// DB column: docsize
		/// </remarks>
		public int size
		{
			get
			{
				return sizeValue;
			}
			set
			{
				this.sizeValue = value;
				setChangedMember(DocInfoDMC.mbSize);
			}
		}
		
		
		/// <summary>
		/// MD5 hash.
		/// </summary>
		/// <remarks>
		/// DB column: md5
		/// </remarks>
		public String md5
		{
			get
			{
				return md5Value;
			}
			set
			{
				this.md5Value = value;
				setChangedMember(DocInfoDMC.mbMd5);
			}
		}
		
		
		/// <summary>
		/// Storage path ID
		/// DB column: pathid
		/// </summary>
		public int pathId
		{
			get
			{
				return pathIdValue;
			}
			set
			{
				this.pathIdValue = value;
				setChangedMember(DocInfoDMC.mbPathId);
			}
		}
		
		
		/// <summary>
		/// reserved
		/// DB column: pathid2
		/// </summary>
		public int pathId2
		{
			get
			{
				return pathId2Value;
			}
			set
			{
				this.pathId2Value = value;
				setChangedMember(DocInfoDMC.mbPathId2);
			}
		}
		
		
		/// <summary>
		/// Create date ISO.
		/// </summary>
		/// <remarks>
		/// DB column: createdate
		/// </remarks>
		public String createDateIso
		{
			get
			{
				return createDateIsoValue;
			}
			set
			{
				this.createDateIsoValue = value;
				setChangedMember(DocInfoDMC.mbCreateDateIso);
			}
		}
		
		
		/// <summary>
		/// Last access date ISO.
		/// </summary>
		/// <remarks>
		/// DB column: lastaccess
		/// </remarks>
		public String lastAccessIso
		{
			get
			{
				return lastAccessIsoValue;
			}
			set
			{
				this.lastAccessIsoValue = value;
				setChangedMember(DocInfoDMC.mbLastAccessIso);
			}
		}
		
		
		/// <summary>
		/// Last update date ISO.
		/// </summary>
		/// <remarks>
		/// DB column: lastupdate
		/// </remarks>
		public String lastUpdateIso
		{
			get
			{
				return lastUpdateIsoValue;
			}
			set
			{
				this.lastUpdateIsoValue = value;
				setChangedMember(DocInfoDMC.mbLastUpdateIso);
			}
		}
		
		
		/// <summary>
		/// User ID.
		/// </summary>
		/// <remarks>
		/// DB column: owner
		/// </remarks>
		public int owner
		{
			get
			{
				return ownerValue;
			}
			set
			{
				this.ownerValue = value;
				setChangedMember(DocInfoDMC.mbOwner);
			}
		}
		
		
		/// <summary>
		/// File extension
		/// DB column: ext
		/// </summary>
		public String ext
		{
			get
			{
				return extValue;
			}
			set
			{
				this.extValue = value;
				setChangedMember(DocInfoDMC.mbExt);
			}
		}
		
		
		/// <summary>
		/// reserved
		/// DB column: fclip
		/// </summary>
		public String fclip
		{
			get
			{
				return fclipValue;
			}
			set
			{
				this.fclipValue = value;
				setChangedMember(DocInfoDMC.mbFclip);
			}
		}
		
		
		/// <summary>
		/// Original file extension for encrypted documents
		/// </summary>
		public String extOrig
		{
			get
			{
				return extOrigValue;
			}
			set
			{
				this.extOrigValue = value;
				setChangedMember(DocInfoDMC.mbExtOrig);
			}
		}
		
		
		/// <summary>
		/// Original file size for encrypted documents
		/// </summary>
		public int sizeOrig
		{
			get
			{
				return sizeOrigValue;
			}
			set
			{
				this.sizeOrigValue = value;
				setChangedMember(DocInfoDMC.mbSizeOrig);
			}
		}
		
		
		/// <summary>
		/// Encryption set.
		/// </summary>
		public int encrSet
		{
			get
			{
				return encrSetValue;
			}
			set
			{
				this.encrSetValue = value;
				setChangedMember(DocInfoDMC.mbEncrSet);
			}
		}
		
		
		/// <summary>
		/// Size of preview file.
		/// </summary>
		/// <remarks>
		/// Is 0, if there is no preview file assigned.
		/// Is -1, if preview creation has failed.
		/// </remarks>
		public int previewSize
		{
			get
			{
				return previewSizeValue;
			}
			set
			{
				this.previewSizeValue = value;
				setChangedMember(DocInfoDMC.mbPreviewSize);
			}
		}
		
		
		/// <summary>
		/// Preview file extension.
		/// </summary>
		public String previewExt
		{
			get
			{
				return previewExtValue;
			}
			set
			{
				this.previewExtValue = value;
				setChangedMember(DocInfoDMC.mbPreviewExt);
			}
		}
		
		
		/// <summary>
		/// Fulltext content timestamp
		/// </summary>
		public String fulltextContentTStamp
		{
			get
			{
				return fulltextContentTStampValue;
			}
			set
			{
				this.fulltextContentTStampValue = value;
				setChangedMember(DocInfoDMC.mbFulltextContentTStamp);
			}
		}
		
		
		/// <summary>
		/// Fulltext content file size.
		/// </summary>
		/// <remarks>
		/// Since the fulltext content file is usually stored in UTF-8 encoding,
		/// the file size might be different from the number of characters.
		/// </remarks>
		public int fulltextContentSize
		{
			get
			{
				return fulltextContentSizeValue;
			}
			set
			{
				this.fulltextContentSizeValue = value;
				setChangedMember(DocInfoDMC.mbFulltextContentSize);
			}
		}
		
		
		/// <summary>
		/// Document file size.
		/// </summary>
		public long sizeL
		{
			get
			{
				return sizeLValue;
			}
			set
			{
				this.sizeLValue = value;
				setChangedMember(DocInfoDMC.mbSizeL);
			}
		}
		
		
		/// <summary>
		/// Original file extension for encrypted documents
		/// </summary>
		public long sizeOrigL
		{
			get
			{
				return sizeOrigLValue;
			}
			set
			{
				this.sizeOrigLValue = value;
				setChangedMember(DocInfoDMC.mbSizeOrigL);
			}
		}
		
		
		/// <summary>
		/// Size of preview file.
		/// </summary>
		/// <remarks>
		/// Is 0, if there is no preview file assigned.
		/// Is -1, if preview creation has failed.
		/// </remarks>
		public long previewSizeL
		{
			get
			{
				return previewSizeLValue;
			}
			set
			{
				this.previewSizeLValue = value;
				setChangedMember(DocInfoDMC.mbPreviewSizeL);
			}
		}
		
		
		/// <summary>
		/// Relative file path
		/// </summary>
		public String relFilePath
		{
			get
			{
				return relFilePathValue;
			}
			set
			{
				this.relFilePathValue = value;
				setChangedMember(DocInfoDMC.mbRelFilePath);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int idValue;

		protected String guidValue;

		protected int sizeValue;

		protected String md5Value;

		protected int pathIdValue;

		protected int pathId2Value;

		protected String createDateIsoValue;

		protected String lastAccessIsoValue;

		protected String lastUpdateIsoValue;

		protected int ownerValue;

		protected String extValue;

		protected String fclipValue;

		protected String extOrigValue;

		protected int sizeOrigValue;

		protected int encrSetValue;

		protected int previewSizeValue;

		protected String previewExtValue;

		protected String fulltextContentTStampValue;

		protected int fulltextContentSizeValue;

		protected long sizeLValue;

		protected long sizeOrigLValue;

		protected long previewSizeLValue;

		protected String relFilePathValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 673204378L;		
	} // end class
}  // end namespace

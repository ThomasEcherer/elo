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
	/// <p>Bit constants for members of DocInfoDM</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class DocInfoDMC : BSerializable
	{
	
		#region Constructors
		
		public DocInfoDMC() {
		}		
		
		public DocInfoDMC(int @lnGuid, int @lnMd5, int @lnCreateDateIso, int @lnLastAccessIso, int @lnLastUpdateIso, int @lnExt, int @lnFclip, int @lnExtOrig, int @lnPreviewExt, int @lnFulltextContentTStamp, int @lnSizeL, int @lnSizeOrigL, int @lnPreviewSizeL, int @lnRelFilePath) {
			this.lnGuidValue = @lnGuid;
			this.lnMd5Value = @lnMd5;
			this.lnCreateDateIsoValue = @lnCreateDateIso;
			this.lnLastAccessIsoValue = @lnLastAccessIso;
			this.lnLastUpdateIsoValue = @lnLastUpdateIso;
			this.lnExtValue = @lnExt;
			this.lnFclipValue = @lnFclip;
			this.lnExtOrigValue = @lnExtOrig;
			this.lnPreviewExtValue = @lnPreviewExt;
			this.lnFulltextContentTStampValue = @lnFulltextContentTStamp;
			this.lnSizeLValue = @lnSizeL;
			this.lnSizeOrigLValue = @lnSizeOrigL;
			this.lnPreviewSizeLValue = @lnPreviewSizeL;
			this.lnRelFilePathValue = @lnRelFilePath;
		}		
		
		public DocInfoDMC(DocInfoDMC rhs)
		{
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnMd5Value = rhs.lnMd5Value;
			this.lnCreateDateIsoValue = rhs.lnCreateDateIsoValue;
			this.lnLastAccessIsoValue = rhs.lnLastAccessIsoValue;
			this.lnLastUpdateIsoValue = rhs.lnLastUpdateIsoValue;
			this.lnExtValue = rhs.lnExtValue;
			this.lnFclipValue = rhs.lnFclipValue;
			this.lnExtOrigValue = rhs.lnExtOrigValue;
			this.lnPreviewExtValue = rhs.lnPreviewExtValue;
			this.lnFulltextContentTStampValue = rhs.lnFulltextContentTStampValue;
			this.lnSizeLValue = rhs.lnSizeLValue;
			this.lnSizeOrigLValue = rhs.lnSizeOrigLValue;
			this.lnPreviewSizeLValue = rhs.lnPreviewSizeLValue;
			this.lnRelFilePathValue = rhs.lnRelFilePathValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: docguid
		/// </summary>
		public int lnGuid
		{
			get
			{
				return lnGuidValue;
			}
			set
			{
				this.lnGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: md5
		/// </summary>
		public int lnMd5
		{
			get
			{
				return lnMd5Value;
			}
			set
			{
				this.lnMd5Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: createdate
		/// </summary>
		public int lnCreateDateIso
		{
			get
			{
				return lnCreateDateIsoValue;
			}
			set
			{
				this.lnCreateDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: lastaccess
		/// </summary>
		public int lnLastAccessIso
		{
			get
			{
				return lnLastAccessIsoValue;
			}
			set
			{
				this.lnLastAccessIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: lastupdate
		/// </summary>
		public int lnLastUpdateIso
		{
			get
			{
				return lnLastUpdateIsoValue;
			}
			set
			{
				this.lnLastUpdateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: ext
		/// </summary>
		public int lnExt
		{
			get
			{
				return lnExtValue;
			}
			set
			{
				this.lnExtValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: fclip
		/// </summary>
		public int lnFclip
		{
			get
			{
				return lnFclipValue;
			}
			set
			{
				this.lnFclipValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Original file extension for encrypted documents
		/// DB column: extorig
		/// </summary>
		public int lnExtOrig
		{
			get
			{
				return lnExtOrigValue;
			}
			set
			{
				this.lnExtOrigValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Preview file extension.
		/// </summary>
		/// <remarks>
		/// DB column: previewext
		/// </remarks>
		public int lnPreviewExt
		{
			get
			{
				return lnPreviewExtValue;
			}
			set
			{
				this.lnPreviewExtValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Fulltext content timestamp
		/// DB column: fttstamp
		/// </summary>
		public int lnFulltextContentTStamp
		{
			get
			{
				return lnFulltextContentTStampValue;
			}
			set
			{
				this.lnFulltextContentTStampValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Document file size.
		/// </summary>
		/// <remarks>
		/// DB column: docsize
		/// </remarks>
		public int lnSizeL
		{
			get
			{
				return lnSizeLValue;
			}
			set
			{
				this.lnSizeLValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Original file extension for encrypted documents
		/// DB column: docsizeorig
		/// </summary>
		public int lnSizeOrigL
		{
			get
			{
				return lnSizeOrigLValue;
			}
			set
			{
				this.lnSizeOrigLValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Size of preview file.
		/// </summary>
		/// <remarks>
		/// DB column: previewsize
		/// </remarks>
		public int lnPreviewSizeL
		{
			get
			{
				return lnPreviewSizeLValue;
			}
			set
			{
				this.lnPreviewSizeLValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Relative file path
		/// DB column: relfilepath
		/// </summary>
		public int lnRelFilePath
		{
			get
			{
				return lnRelFilePathValue;
			}
			set
			{
				this.lnRelFilePathValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: docid
		/// </summary>
		public const long mbId = 1L;

		/// <summary>
		/// DB column: docguid
		/// </summary>
		public const long mbGuid = 2L;

		protected int lnGuidValue;

		/// <summary>
		/// DB column: md5
		/// </summary>
		public const long mbMd5 = 4L;

		protected int lnMd5Value;

		/// <summary>
		/// DB column: pathid
		/// </summary>
		public const long mbPathId = 8L;

		/// <summary>
		/// DB column: pathid2
		/// </summary>
		public const long mbPathId2 = 16L;

		/// <summary>
		/// DB column: createdate
		/// </summary>
		public const long mbCreateDateIso = 32L;

		protected int lnCreateDateIsoValue;

		/// <summary>
		/// DB column: lastaccess
		/// </summary>
		public const long mbLastAccessIso = 64L;

		protected int lnLastAccessIsoValue;

		/// <summary>
		/// DB column: lastupdate
		/// </summary>
		public const long mbLastUpdateIso = 128L;

		protected int lnLastUpdateIsoValue;

		/// <summary>
		/// DB column: owner
		/// </summary>
		public const long mbOwner = 256L;

		/// <summary>
		/// DB column: ext
		/// </summary>
		public const long mbExt = 512L;

		protected int lnExtValue;

		/// <summary>
		/// DB column: fclip
		/// </summary>
		public const long mbFclip = 1024L;

		protected int lnFclipValue;

		/// <summary>
		/// DB column: null
		/// </summary>
		public const long mbSize = 2048L;

		/// <summary>
		/// DB column: null
		/// </summary>
		public const long mbPreviewSize = 4096L;

		/// <summary>
		/// DB column: null
		/// </summary>
		public const long mbSizeOrig = 8192L;

		/// <summary>
		/// Member bit: Original file extension for encrypted documents
		/// DB column: extorig
		/// </summary>
		public const long mbExtOrig = 16384L;

		protected int lnExtOrigValue;

		/// <summary>
		/// Member bit: Encryption set.
		/// </summary>
		/// <remarks>
		/// DB column: cryptno
		/// </remarks>
		public const long mbEncrSet = 32768L;

		/// <summary>
		/// Member bit: Preview file extension.
		/// </summary>
		/// <remarks>
		/// DB column: previewext
		/// </remarks>
		public const long mbPreviewExt = 65536L;

		protected int lnPreviewExtValue;

		/// <summary>
		/// Member bit: Fulltext content timestamp
		/// DB column: fttstamp
		/// </summary>
		public const long mbFulltextContentTStamp = 131072L;

		protected int lnFulltextContentTStampValue;

		/// <summary>
		/// Member bit: Fulltext content file size.
		/// </summary>
		/// <remarks>
		/// DB column: ftsize
		/// </remarks>
		public const long mbFulltextContentSize = 262144L;

		/// <summary>
		/// Member bit: Document file size.
		/// </summary>
		/// <remarks>
		/// DB column: docsize
		/// </remarks>
		public const long mbSizeL = 524288L;

		protected int lnSizeLValue;

		/// <summary>
		/// Member bit: Original file extension for encrypted documents
		/// DB column: docsizeorig
		/// </summary>
		public const long mbSizeOrigL = 1048576L;

		protected int lnSizeOrigLValue;

		/// <summary>
		/// Member bit: Size of preview file.
		/// </summary>
		/// <remarks>
		/// DB column: previewsize
		/// </remarks>
		public const long mbPreviewSizeL = 2097152L;

		protected int lnPreviewSizeLValue;

		/// <summary>
		/// Member bit: Relative file path
		/// DB column: relfilepath
		/// </summary>
		public const long mbRelFilePath = 4194304L;

		protected int lnRelFilePathValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 8388607L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1042422760L;		
	} // end class
}  // end namespace

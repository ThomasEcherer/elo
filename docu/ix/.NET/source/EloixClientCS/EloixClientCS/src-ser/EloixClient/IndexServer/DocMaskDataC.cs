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
	/// <p>Bit constants for members of DocMask</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class DocMaskDataC : BSerializable
	{
	
		#region Constructors
		
		public DocMaskDataC() {
		}		
		
		public DocMaskDataC(int @lnName, int @lnIndex, int @lnBarcode, int @lnDAcl, int @lnLifetime, int @lnText, int @lnTStamp, int @lnRawPosInfo, int @lnGuid, int @lnInternalAcl, int @lnTStampSync, int @lnTextTranslationKey, int @lnNameTranslationKey) {
			this.lnNameValue = @lnName;
			this.lnIndexValue = @lnIndex;
			this.lnBarcodeValue = @lnBarcode;
			this.lnDAclValue = @lnDAcl;
			this.lnLifetimeValue = @lnLifetime;
			this.lnTextValue = @lnText;
			this.lnTStampValue = @lnTStamp;
			this.lnRawPosInfoValue = @lnRawPosInfo;
			this.lnGuidValue = @lnGuid;
			this.lnInternalAclValue = @lnInternalAcl;
			this.lnTStampSyncValue = @lnTStampSync;
			this.lnTextTranslationKeyValue = @lnTextTranslationKey;
			this.lnNameTranslationKeyValue = @lnNameTranslationKey;
		}		
		
		public DocMaskDataC(DocMaskDataC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
			this.lnIndexValue = rhs.lnIndexValue;
			this.lnBarcodeValue = rhs.lnBarcodeValue;
			this.lnDAclValue = rhs.lnDAclValue;
			this.lnLifetimeValue = rhs.lnLifetimeValue;
			this.lnTextValue = rhs.lnTextValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnRawPosInfoValue = rhs.lnRawPosInfoValue;
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnInternalAclValue = rhs.lnInternalAclValue;
			this.lnTStampSyncValue = rhs.lnTStampSyncValue;
			this.lnTextTranslationKeyValue = rhs.lnTextTranslationKeyValue;
			this.lnNameTranslationKeyValue = rhs.lnNameTranslationKeyValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: maskname
		/// </summary>
		public int lnName
		{
			get
			{
				return lnNameValue;
			}
			set
			{
				this.lnNameValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: maskindex
		/// </summary>
		public int lnIndex
		{
			get
			{
				return lnIndexValue;
			}
			set
			{
				this.lnIndexValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: maskbarcode
		/// </summary>
		public int lnBarcode
		{
			get
			{
				return lnBarcodeValue;
			}
			set
			{
				this.lnBarcodeValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: maskdacl
		/// </summary>
		public int lnDAcl
		{
			get
			{
				return lnDAclValue;
			}
			set
			{
				this.lnDAclValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: lifetime
		/// </summary>
		public int lnLifetime
		{
			get
			{
				return lnLifetimeValue;
			}
			set
			{
				this.lnLifetimeValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: masktext
		/// </summary>
		public int lnText
		{
			get
			{
				return lnTextValue;
			}
			set
			{
				this.lnTextValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: masktstamp
		/// </summary>
		public int lnTStamp
		{
			get
			{
				return lnTStampValue;
			}
			set
			{
				this.lnTStampValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: maskposinfo
		/// </summary>
		public int lnRawPosInfo
		{
			get
			{
				return lnRawPosInfoValue;
			}
			set
			{
				this.lnRawPosInfoValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: GUID
		/// DB column: maskguid
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
		/// Column length: Internal acl.
		/// </summary>
		/// <remarks>
		/// DB column: maskacl
		/// </remarks>
		public int lnInternalAcl
		{
			get
			{
				return lnInternalAclValue;
			}
			set
			{
				this.lnInternalAclValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: masktstampsync
		/// </remarks>
		public int lnTStampSync
		{
			get
			{
				return lnTStampSyncValue;
			}
			set
			{
				this.lnTStampSyncValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Translation-keyword for {@link DocMask#text}.
		/// </summary>
		/// <remarks>
		/// DB column: masktexttrkey
		/// </remarks>
		public int lnTextTranslationKey
		{
			get
			{
				return lnTextTranslationKeyValue;
			}
			set
			{
				this.lnTextTranslationKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Translation-keyword for {@link DocMask#name}.
		/// </summary>
		/// <remarks>
		/// DB column: masknametrkey
		/// </remarks>
		public int lnNameTranslationKey
		{
			get
			{
				return lnNameTranslationKeyValue;
			}
			set
			{
				this.lnNameTranslationKeyValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: maskno
		/// </summary>
		public const long mbId = 1L;

		/// <summary>
		/// DB column: maskname
		/// </summary>
		public const long mbName = 2L;

		protected int lnNameValue;

		/// <summary>
		/// DB column: maskindex
		/// </summary>
		public const long mbIndex = 4L;

		protected int lnIndexValue;

		/// <summary>
		/// DB column: maskbarcode
		/// </summary>
		public const long mbBarcode = 8L;

		protected int lnBarcodeValue;

		/// <summary>
		/// DB column: maskkey
		/// </summary>
		public const long mbKey = 16L;

		/// <summary>
		/// DB column: maskdpath
		/// </summary>
		public const long mbDPath = 32L;

		/// <summary>
		/// DB column: maskdkind
		/// </summary>
		public const long mbDKind = 64L;

		/// <summary>
		/// DB column: maskdkey
		/// </summary>
		public const long mbDKey = 128L;

		/// <summary>
		/// DB column: masklock
		/// </summary>
		public const long mbLockId = 256L;

		/// <summary>
		/// DB column: maskflags
		/// </summary>
		public const long mbFlags = 512L;

		/// <summary>
		/// DB column: maskflowid
		/// </summary>
		public const long mbFlowId = 1024L;

		/// <summary>
		/// DB column: maskdacl
		/// </summary>
		public const long mbDAcl = 2048L;

		protected int lnDAclValue;

		/// <summary>
		/// DB column: lifetime
		/// </summary>
		public const long mbLifetime = 4096L;

		protected int lnLifetimeValue;

		/// <summary>
		/// DB column: masktext
		/// </summary>
		public const long mbText = 8192L;

		protected int lnTextValue;

		/// <summary>
		/// DB column: masktstamp
		/// </summary>
		public const long mbTStamp = 16384L;

		protected int lnTStampValue;

		/// <summary>
		/// DB column: maskposinfo
		/// </summary>
		public const long mbRawPosInfo = 32768L;

		protected int lnRawPosInfoValue;

		/// <summary>
		/// Member bit: GUID
		/// DB column: maskguid
		/// </summary>
		public const long mbGuid = 65536L;

		protected int lnGuidValue;

		/// <summary>
		/// Member bit: Deleted status.
		/// </summary>
		/// <remarks>
		/// DB column: maskstatus
		/// </remarks>
		public const long mbStatus = 131072L;

		/// <summary>
		/// Member bit: Internal acl.
		/// </summary>
		/// <remarks>
		/// DB column: maskacl
		/// </remarks>
		public const long mbInternalAcl = 262144L;

		protected int lnInternalAclValue;

		/// <summary>
		/// Member bit: The ID of a workflow that is to be started if a new version of an associated
		/// DB column: maskflowid2
		/// </summary>
		public const long mbFlowId2 = 524288L;

		/// <summary>
		/// Member bit: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: masktstampsync
		/// </remarks>
		public const long mbTStampSync = 1048576L;

		protected int lnTStampSyncValue;

		/// <summary>
		/// Member bit: Translation-keyword for {@link DocMask#text}.
		/// </summary>
		/// <remarks>
		/// DB column: masktexttrkey
		/// </remarks>
		public const long mbTextTranslationKey = 2097152L;

		protected int lnTextTranslationKeyValue;

		/// <summary>
		/// Member bit: Translation-keyword for {@link DocMask#name}.
		/// </summary>
		/// <remarks>
		/// DB column: masknametrkey
		/// </remarks>
		public const long mbNameTranslationKey = 4194304L;

		protected int lnNameTranslationKeyValue;

		/// <summary>
		/// Member bit: This member specifies how the index values are stored in database.
		/// </summary>
		/// <remarks>
		/// DB column: dataorg
		/// </remarks>
		public const long mbDataOrganisation = 8388608L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 16777215L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1968969939L;		
	} // end class
}  // end namespace

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
	/// <p>Bit constants for members of Sord</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ObjDataC : BSerializable
	{
	
		#region Constructors
		
		public ObjDataC() {
		}		
		
		public ObjDataC(int @lnGuid, int @lnName, int @lnSReg, int @lnInternalDesc, int @lnAcl, int @lnTStamp, int @lnSName, int @lnSDesc, int @lnTStampSync, int @lnTStampAcl, int @lnTStampAclSync) {
			this.lnGuidValue = @lnGuid;
			this.lnNameValue = @lnName;
			this.lnSRegValue = @lnSReg;
			this.lnInternalDescValue = @lnInternalDesc;
			this.lnAclValue = @lnAcl;
			this.lnTStampValue = @lnTStamp;
			this.lnSNameValue = @lnSName;
			this.lnSDescValue = @lnSDesc;
			this.lnTStampSyncValue = @lnTStampSync;
			this.lnTStampAclValue = @lnTStampAcl;
			this.lnTStampAclSyncValue = @lnTStampAclSync;
		}		
		
		public ObjDataC(ObjDataC rhs)
		{
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnNameValue = rhs.lnNameValue;
			this.lnSRegValue = rhs.lnSRegValue;
			this.lnInternalDescValue = rhs.lnInternalDescValue;
			this.lnAclValue = rhs.lnAclValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnSNameValue = rhs.lnSNameValue;
			this.lnSDescValue = rhs.lnSDescValue;
			this.lnTStampSyncValue = rhs.lnTStampSyncValue;
			this.lnTStampAclValue = rhs.lnTStampAclValue;
			this.lnTStampAclSyncValue = rhs.lnTStampAclSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: objguid
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
		/// DB column: objshort
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
		/// DB column: objsreg
		/// </summary>
		public int lnSReg
		{
			get
			{
				return lnSRegValue;
			}
			set
			{
				this.lnSRegValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: objdesc
		/// </summary>
		public int lnInternalDesc
		{
			get
			{
				return lnInternalDescValue;
			}
			set
			{
				this.lnInternalDescValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: objacl
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
		
		
		/// <summary>
		/// DB column: objtstamp
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
		/// DB column: objsdata_off
		/// </summary>
		public int lnSName
		{
			get
			{
				return lnSNameValue;
			}
			set
			{
				this.lnSNameValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: objsdesc_off
		/// </summary>
		public int lnSDesc
		{
			get
			{
				return lnSDescValue;
			}
			set
			{
				this.lnSDescValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: objtstampsync
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
		/// Column length: Timestamp of the last ACL change.
		/// </summary>
		/// <remarks>
		/// DB column: objtstampacl
		/// </remarks>
		public int lnTStampAcl
		{
			get
			{
				return lnTStampAclValue;
			}
			set
			{
				this.lnTStampAclValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Timestamp of this object's ACLs last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: objtstampaclsync
		/// </remarks>
		public int lnTStampAclSync
		{
			get
			{
				return lnTStampAclSyncValue;
			}
			set
			{
				this.lnTStampAclSyncValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: Serialisation version ID
		/// DB column: objid
		/// </summary>
		public const long mbId = 1L;

		/// <summary>
		/// DB column: objguid
		/// </summary>
		public const long mbGuid = 2L;

		protected int lnGuidValue;

		/// <summary>
		/// DB column: objparent
		/// </summary>
		public const long mbParentId = 4L;

		/// <summary>
		/// DB column: objtype
		/// </summary>
		public const long mbType = 8L;

		/// <summary>
		/// DB column: objflags
		/// </summary>
		public const long mbFlags = 16L;

		/// <summary>
		/// DB column: objshort
		/// </summary>
		public const long mbName = 32L;

		protected int lnNameValue;

		/// <summary>
		/// DB column: objsreg
		/// </summary>
		public const long mbSReg = 64L;

		protected int lnSRegValue;

		/// <summary>
		/// DB column: objidate
		/// </summary>
		public const long mbIDate = 128L;

		/// <summary>
		/// DB column: objxdate
		/// </summary>
		public const long mbXDate = 256L;

		/// <summary>
		/// DB column: objkey
		/// </summary>
		public const long mbKey = 512L;

		/// <summary>
		/// DB column: objkind
		/// </summary>
		public const long mbKind = 1024L;

		/// <summary>
		/// DB column: objpath
		/// </summary>
		public const long mbPath = 2048L;

		/// <summary>
		/// DB column: objinfo
		/// </summary>
		public const long mbInfo = 4096L;

		/// <summary>
		/// DB column: objmask
		/// </summary>
		public const long mbMask = 8192L;

		/// <summary>
		/// DB column: objdoc
		/// </summary>
		public const long mbDoc = 16384L;

		/// <summary>
		/// DB column: objakey1
		/// </summary>
		public const long mbSig = 32768L;

		/// <summary>
		/// DB column: objattach
		/// </summary>
		public const long mbAtt = 65536L;

		/// <summary>
		/// DB column: objuser
		/// </summary>
		public const long mbOwnerId = 131072L;

		/// <summary>
		/// DB column: objlock
		/// </summary>
		public const long mbLockId = 262144L;

		/// <summary>
		/// DB column: objstatus
		/// </summary>
		public const long mbStatus = 524288L;

		/// <summary>
		/// DB column: objhistcount
		/// </summary>
		public const long mbHistCount = 1048576L;

		/// <summary>
		/// DB column: objdesc
		/// </summary>
		public const long mbInternalDesc = 2097152L;

		protected int lnInternalDescValue;

		/// <summary>
		/// DB column: objchildcount
		/// </summary>
		public const long mbChildCount = 4194304L;

		/// <summary>
		/// DB column: objdeldate
		/// </summary>
		public const long mbDelDate = 8388608L;

		/// <summary>
		/// DB column: objsyncdateloc
		/// </summary>
		public const long mbSyncDateLoc = 16777216L;

		/// <summary>
		/// DB column: objsyncdaterem
		/// </summary>
		public const long mbSyncDateRem = 33554432L;

		/// <summary>
		/// DB column: objvtrep
		/// </summary>
		public const long mbVtRep = 67108864L;

		/// <summary>
		/// DB column: objacl
		/// </summary>
		public const long mbAcl = 134217728L;

		protected int lnAclValue;

		/// <summary>
		/// DB column: objtstamp
		/// </summary>
		public const long mbTStamp = 268435456L;

		protected int lnTStampValue;

		/// <summary>
		/// DB column: objsdata_off
		/// </summary>
		public const long mbSName = 536870912L;

		protected int lnSNameValue;

		/// <summary>
		/// DB column: objsdesc_off
		/// </summary>
		public const long mbSDesc = 1073741824L;

		protected int lnSDescValue;

		/// <summary>
		/// Member bit: The Sord is deleted at this date.
		/// </summary>
		/// <remarks>
		/// ClientInfo determines the Timezone.
		/// DB column: deletedate
		/// </remarks>
		public const long mbDeleteDate = 2147483648L;

		/// <summary>
		/// Member bit: This is the id of the user who has a lock on the object (not the document).
		/// </summary>
		/// <remarks>
		/// DB column: objlock_off
		/// </remarks>
		public const long mbLockIdSord = 4294967296L;

		/// <summary>
		/// Member bit: This is the id of the user who has a lock on the document (not the object).
		/// </summary>
		/// <remarks>
		/// DB column: doclock
		/// </remarks>
		public const long mbLockIdDoc = 8589934592L;

		/// <summary>
		/// Member bit: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: objtstampsync
		/// </remarks>
		public const long mbTStampSync = 17179869184L;

		protected int lnTStampSyncValue;

		/// <summary>
		/// Member bit: Timestamp of the last ACL change.
		/// </summary>
		/// <remarks>
		/// DB column: objtstampacl
		/// </remarks>
		public const long mbTStampAcl = 34359738368L;

		protected int lnTStampAclValue;

		/// <summary>
		/// Member bit: Timestamp of this object's ACLs last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: objtstampaclsync
		/// </remarks>
		public const long mbTStampAclSync = 68719476736L;

		protected int lnTStampAclSyncValue;

		/// <summary>
		/// Member bit: The Sord is deleted at this user.
		/// </summary>
		/// <remarks>
		/// DB column: deleteuser
		/// </remarks>
		public const long mbDeleteUser = 137438953472L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 274877906943L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1521332903L;		
	} // end class
}  // end namespace

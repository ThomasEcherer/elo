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
	/// <p>Bit constants for members of Activity</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ActivityDataC : BSerializable
	{
	
		#region Constructors
		
		public ActivityDataC() {
		}		
		
		public ActivityDataC(int @lnGuid, int @lnObjGuid, int @lnTStamp, int @lnProject, int @lnRevVers, int @lnName, int @lnDestination, int @lnSentAtIso, int @lnSentMode, int @lnDueDateIso, int @lnBackAt, int @lnBackMode, int @lnComment, int @lnFileName, int @lnUd0, int @lnUd1, int @lnUd2, int @lnUd3, int @lnUd4, int @lnUd5, int @lnUd6, int @lnUd7, int @lnUd8, int @lnUd9, int @lnTransId, int @lnTStampSync) {
			this.lnGuidValue = @lnGuid;
			this.lnObjGuidValue = @lnObjGuid;
			this.lnTStampValue = @lnTStamp;
			this.lnProjectValue = @lnProject;
			this.lnRevVersValue = @lnRevVers;
			this.lnNameValue = @lnName;
			this.lnDestinationValue = @lnDestination;
			this.lnSentAtIsoValue = @lnSentAtIso;
			this.lnSentModeValue = @lnSentMode;
			this.lnDueDateIsoValue = @lnDueDateIso;
			this.lnBackAtValue = @lnBackAt;
			this.lnBackModeValue = @lnBackMode;
			this.lnCommentValue = @lnComment;
			this.lnFileNameValue = @lnFileName;
			this.lnUd0Value = @lnUd0;
			this.lnUd1Value = @lnUd1;
			this.lnUd2Value = @lnUd2;
			this.lnUd3Value = @lnUd3;
			this.lnUd4Value = @lnUd4;
			this.lnUd5Value = @lnUd5;
			this.lnUd6Value = @lnUd6;
			this.lnUd7Value = @lnUd7;
			this.lnUd8Value = @lnUd8;
			this.lnUd9Value = @lnUd9;
			this.lnTransIdValue = @lnTransId;
			this.lnTStampSyncValue = @lnTStampSync;
		}		
		
		public ActivityDataC(ActivityDataC rhs)
		{
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnObjGuidValue = rhs.lnObjGuidValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnProjectValue = rhs.lnProjectValue;
			this.lnRevVersValue = rhs.lnRevVersValue;
			this.lnNameValue = rhs.lnNameValue;
			this.lnDestinationValue = rhs.lnDestinationValue;
			this.lnSentAtIsoValue = rhs.lnSentAtIsoValue;
			this.lnSentModeValue = rhs.lnSentModeValue;
			this.lnDueDateIsoValue = rhs.lnDueDateIsoValue;
			this.lnBackAtValue = rhs.lnBackAtValue;
			this.lnBackModeValue = rhs.lnBackModeValue;
			this.lnCommentValue = rhs.lnCommentValue;
			this.lnFileNameValue = rhs.lnFileNameValue;
			this.lnUd0Value = rhs.lnUd0Value;
			this.lnUd1Value = rhs.lnUd1Value;
			this.lnUd2Value = rhs.lnUd2Value;
			this.lnUd3Value = rhs.lnUd3Value;
			this.lnUd4Value = rhs.lnUd4Value;
			this.lnUd5Value = rhs.lnUd5Value;
			this.lnUd6Value = rhs.lnUd6Value;
			this.lnUd7Value = rhs.lnUd7Value;
			this.lnUd8Value = rhs.lnUd8Value;
			this.lnUd9Value = rhs.lnUd9Value;
			this.lnTransIdValue = rhs.lnTransIdValue;
			this.lnTStampSyncValue = rhs.lnTStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: actguid
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
		/// DB column: docguid
		/// </summary>
		public int lnObjGuid
		{
			get
			{
				return lnObjGuidValue;
			}
			set
			{
				this.lnObjGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: acttstamp
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
		/// DB column: project
		/// </summary>
		public int lnProject
		{
			get
			{
				return lnProjectValue;
			}
			set
			{
				this.lnProjectValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: revvers
		/// </summary>
		public int lnRevVers
		{
			get
			{
				return lnRevVersValue;
			}
			set
			{
				this.lnRevVersValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: shortdesc
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
		/// DB column: destination
		/// </summary>
		public int lnDestination
		{
			get
			{
				return lnDestinationValue;
			}
			set
			{
				this.lnDestinationValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: sentat
		/// </summary>
		public int lnSentAtIso
		{
			get
			{
				return lnSentAtIsoValue;
			}
			set
			{
				this.lnSentAtIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: sentmode
		/// </summary>
		public int lnSentMode
		{
			get
			{
				return lnSentModeValue;
			}
			set
			{
				this.lnSentModeValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: duedate
		/// </summary>
		public int lnDueDateIso
		{
			get
			{
				return lnDueDateIsoValue;
			}
			set
			{
				this.lnDueDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: backat
		/// </summary>
		public int lnBackAt
		{
			get
			{
				return lnBackAtValue;
			}
			set
			{
				this.lnBackAtValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: backmode
		/// </summary>
		public int lnBackMode
		{
			get
			{
				return lnBackModeValue;
			}
			set
			{
				this.lnBackModeValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: actcomment
		/// </summary>
		public int lnComment
		{
			get
			{
				return lnCommentValue;
			}
			set
			{
				this.lnCommentValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: filename
		/// </summary>
		public int lnFileName
		{
			get
			{
				return lnFileNameValue;
			}
			set
			{
				this.lnFileNameValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: ud0
		/// </summary>
		public int lnUd0
		{
			get
			{
				return lnUd0Value;
			}
			set
			{
				this.lnUd0Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: ud1
		/// </summary>
		public int lnUd1
		{
			get
			{
				return lnUd1Value;
			}
			set
			{
				this.lnUd1Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: ud2
		/// </summary>
		public int lnUd2
		{
			get
			{
				return lnUd2Value;
			}
			set
			{
				this.lnUd2Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: ud3
		/// </summary>
		public int lnUd3
		{
			get
			{
				return lnUd3Value;
			}
			set
			{
				this.lnUd3Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: ud4
		/// </summary>
		public int lnUd4
		{
			get
			{
				return lnUd4Value;
			}
			set
			{
				this.lnUd4Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: ud5
		/// </summary>
		public int lnUd5
		{
			get
			{
				return lnUd5Value;
			}
			set
			{
				this.lnUd5Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: ud6
		/// </summary>
		public int lnUd6
		{
			get
			{
				return lnUd6Value;
			}
			set
			{
				this.lnUd6Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: ud7
		/// </summary>
		public int lnUd7
		{
			get
			{
				return lnUd7Value;
			}
			set
			{
				this.lnUd7Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: ud8
		/// </summary>
		public int lnUd8
		{
			get
			{
				return lnUd8Value;
			}
			set
			{
				this.lnUd8Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: ud9
		/// </summary>
		public int lnUd9
		{
			get
			{
				return lnUd9Value;
			}
			set
			{
				this.lnUd9Value = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Application defined value.
		/// </summary>
		/// <remarks>
		/// DB column: transmitid
		/// </remarks>
		public int lnTransId
		{
			get
			{
				return lnTransIdValue;
			}
			set
			{
				this.lnTransIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: acttstampsync
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
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: actguid
		/// </summary>
		public const long mbGuid = 1L;

		protected int lnGuidValue;

		/// <summary>
		/// DB column: docguid
		/// </summary>
		public const long mbObjGuid = 2L;

		protected int lnObjGuidValue;

		/// <summary>
		/// DB column: acttstamp
		/// </summary>
		public const long mbTStamp = 4L;

		protected int lnTStampValue;

		/// <summary>
		/// DB column: project
		/// </summary>
		public const long mbProject = 8L;

		protected int lnProjectValue;

		/// <summary>
		/// DB column: revvers
		/// </summary>
		public const long mbRevVers = 16L;

		protected int lnRevVersValue;

		/// <summary>
		/// DB column: owner
		/// </summary>
		public const long mbReceiverId = 32L;

		/// <summary>
		/// DB column: creator
		/// </summary>
		public const long mbSenderId = 64L;

		/// <summary>
		/// DB column: prio
		/// </summary>
		public const long mbPrio = 128L;

		/// <summary>
		/// DB column: shortdesc
		/// </summary>
		public const long mbName = 256L;

		protected int lnNameValue;

		/// <summary>
		/// DB column: destination
		/// </summary>
		public const long mbDestination = 512L;

		protected int lnDestinationValue;

		/// <summary>
		/// DB column: sentat
		/// </summary>
		public const long mbSentAtIso = 1024L;

		protected int lnSentAtIsoValue;

		/// <summary>
		/// DB column: sentmode
		/// </summary>
		public const long mbSentMode = 2048L;

		protected int lnSentModeValue;

		/// <summary>
		/// DB column: duedate
		/// </summary>
		public const long mbDueDateIso = 4096L;

		protected int lnDueDateIsoValue;

		/// <summary>
		/// DB column: backat
		/// </summary>
		public const long mbBackAt = 8192L;

		protected int lnBackAtValue;

		/// <summary>
		/// DB column: backmode
		/// </summary>
		public const long mbBackMode = 16384L;

		protected int lnBackModeValue;

		/// <summary>
		/// DB column: actcomment
		/// </summary>
		public const long mbComment = 32768L;

		protected int lnCommentValue;

		/// <summary>
		/// DB column: filename
		/// </summary>
		public const long mbFileName = 65536L;

		protected int lnFileNameValue;

		/// <summary>
		/// DB column: ud0
		/// </summary>
		public const long mbUd0 = 131072L;

		protected int lnUd0Value;

		/// <summary>
		/// DB column: ud1
		/// </summary>
		public const long mbUd1 = 262144L;

		protected int lnUd1Value;

		/// <summary>
		/// DB column: ud2
		/// </summary>
		public const long mbUd2 = 524288L;

		protected int lnUd2Value;

		/// <summary>
		/// DB column: ud3
		/// </summary>
		public const long mbUd3 = 1048576L;

		protected int lnUd3Value;

		/// <summary>
		/// DB column: ud4
		/// </summary>
		public const long mbUd4 = 2097152L;

		protected int lnUd4Value;

		/// <summary>
		/// DB column: ud5
		/// </summary>
		public const long mbUd5 = 4194304L;

		protected int lnUd5Value;

		/// <summary>
		/// DB column: ud6
		/// </summary>
		public const long mbUd6 = 8388608L;

		protected int lnUd6Value;

		/// <summary>
		/// DB column: ud7
		/// </summary>
		public const long mbUd7 = 16777216L;

		protected int lnUd7Value;

		/// <summary>
		/// DB column: ud8
		/// </summary>
		public const long mbUd8 = 33554432L;

		protected int lnUd8Value;

		/// <summary>
		/// DB column: ud9
		/// </summary>
		public const long mbUd9 = 67108864L;

		protected int lnUd9Value;

		/// <summary>
		/// Member bit: Application defined value.
		/// </summary>
		/// <remarks>
		/// DB column: transmitid
		/// </remarks>
		public const long mbTransId = 134217728L;

		protected int lnTransIdValue;

		/// <summary>
		/// Member bit: Object ID of the associated folder or document.
		/// </summary>
		/// <remarks>
		/// DB column: objid
		/// </remarks>
		public const long mbObjId = 268435456L;

		/// <summary>
		/// Member bit: Object type of the associated folder or document.
		/// </summary>
		/// <remarks>
		/// DB column: objtype
		/// </remarks>
		public const long mbObjType = 536870912L;

		/// <summary>
		/// Member bit: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: acttstampsync
		/// </remarks>
		public const long mbTStampSync = 1073741824L;

		protected int lnTStampSyncValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 2147483647L;

		#endregion
		
		
		public static readonly long serialVersionUID = 72578008L;		
	} // end class
}  // end namespace

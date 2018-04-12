//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	/// <summary>
	/// <p>Bit constants for members of Action</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ActionDataC : BSerializable
	{
	
		#region Constructors
		
		public ActionDataC() {
		}		
		
		public ActionDataC(int @lnGuid, int @lnFeedGuid, int @lnParentGuid, int @lnUserGuid, int @lnCreateDateIso, int @lnUpdateDateIso, int @lnText, int @lnDocVersionGuid, int @lnWorkflowGuid, int @lnTStamp, int @lnAcl, int @lnTStampSync) {
			this.lnGuidValue = @lnGuid;
			this.lnFeedGuidValue = @lnFeedGuid;
			this.lnParentGuidValue = @lnParentGuid;
			this.lnUserGuidValue = @lnUserGuid;
			this.lnCreateDateIsoValue = @lnCreateDateIso;
			this.lnUpdateDateIsoValue = @lnUpdateDateIso;
			this.lnTextValue = @lnText;
			this.lnDocVersionGuidValue = @lnDocVersionGuid;
			this.lnWorkflowGuidValue = @lnWorkflowGuid;
			this.lnTStampValue = @lnTStamp;
			this.lnAclValue = @lnAcl;
			this.lnTStampSyncValue = @lnTStampSync;
		}		
		
		public ActionDataC(ActionDataC rhs)
		{
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnFeedGuidValue = rhs.lnFeedGuidValue;
			this.lnParentGuidValue = rhs.lnParentGuidValue;
			this.lnUserGuidValue = rhs.lnUserGuidValue;
			this.lnCreateDateIsoValue = rhs.lnCreateDateIsoValue;
			this.lnUpdateDateIsoValue = rhs.lnUpdateDateIsoValue;
			this.lnTextValue = rhs.lnTextValue;
			this.lnDocVersionGuidValue = rhs.lnDocVersionGuidValue;
			this.lnWorkflowGuidValue = rhs.lnWorkflowGuidValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnAclValue = rhs.lnAclValue;
			this.lnTStampSyncValue = rhs.lnTStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: Action GUID.
		/// </summary>
		/// <remarks>
		/// DB column: actionguid
		/// </remarks>
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
		/// Column length: Feed GUID.
		/// </summary>
		/// <remarks>
		/// DB column: feedguid
		/// </remarks>
		public int lnFeedGuid
		{
			get
			{
				return lnFeedGuidValue;
			}
			set
			{
				this.lnFeedGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Parent action GUID.
		/// </summary>
		/// <remarks>
		/// DB column: parentguid
		/// </remarks>
		public int lnParentGuid
		{
			get
			{
				return lnParentGuidValue;
			}
			set
			{
				this.lnParentGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: User GUID.
		/// </summary>
		/// <remarks>
		/// DB column: userguid
		/// </remarks>
		public int lnUserGuid
		{
			get
			{
				return lnUserGuidValue;
			}
			set
			{
				this.lnUserGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Create date.
		/// </summary>
		/// <remarks>
		/// DB column: createdateiso
		/// </remarks>
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
		/// Column length: Update date.
		/// </summary>
		/// <remarks>
		/// DB column: updatedateiso
		/// </remarks>
		public int lnUpdateDateIso
		{
			get
			{
				return lnUpdateDateIsoValue;
			}
			set
			{
				this.lnUpdateDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Comment text.
		/// </summary>
		/// <remarks>
		/// DB column: actiontext
		/// </remarks>
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
		/// Column length: GUID of the associated document version.
		/// </summary>
		/// <remarks>
		/// DB column: docversionguid
		/// </remarks>
		public int lnDocVersionGuid
		{
			get
			{
				return lnDocVersionGuidValue;
			}
			set
			{
				this.lnDocVersionGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: GUID of the associated workflow.
		/// </summary>
		/// <remarks>
		/// DB column: workflowguid
		/// </remarks>
		public int lnWorkflowGuid
		{
			get
			{
				return lnWorkflowGuidValue;
			}
			set
			{
				this.lnWorkflowGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Time stamp.
		/// </summary>
		/// <remarks>
		/// DB column: actiontstamp
		/// </remarks>
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
		/// Column length: Raw ACL representation.
		/// </summary>
		/// <remarks>
		/// DB column: actionacl
		/// </remarks>
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
		/// Column length: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: actiontstampsync
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
		/// Member bit: Action GUID.
		/// </summary>
		/// <remarks>
		/// DB column: actionguid
		/// </remarks>
		public const long mbGuid = 1L;

		protected int lnGuidValue;

		/// <summary>
		/// Member bit: Action type.
		/// </summary>
		/// <remarks>
		/// DB column: actiontype
		/// </remarks>
		public const long mbRawType = 2L;

		/// <summary>
		/// Member bit: Feed GUID.
		/// </summary>
		/// <remarks>
		/// DB column: feedguid
		/// </remarks>
		public const long mbFeedGuid = 4L;

		protected int lnFeedGuidValue;

		/// <summary>
		/// Member bit: Parent action GUID.
		/// </summary>
		/// <remarks>
		/// DB column: parentguid
		/// </remarks>
		public const long mbParentGuid = 8L;

		protected int lnParentGuidValue;

		/// <summary>
		/// Member bit: User GUID.
		/// </summary>
		/// <remarks>
		/// DB column: userguid
		/// </remarks>
		public const long mbUserGuid = 16L;

		protected int lnUserGuidValue;

		/// <summary>
		/// Member bit: Create date.
		/// </summary>
		/// <remarks>
		/// DB column: createdateiso
		/// </remarks>
		public const long mbCreateDateIso = 32L;

		protected int lnCreateDateIsoValue;

		/// <summary>
		/// Member bit: Update date.
		/// </summary>
		/// <remarks>
		/// DB column: updatedateiso
		/// </remarks>
		public const long mbUpdateDateIso = 64L;

		protected int lnUpdateDateIsoValue;

		/// <summary>
		/// Member bit: Counts the number of updates.
		/// </summary>
		/// <remarks>
		/// DB column: changecounter
		/// </remarks>
		public const long mbChangeCounter = 128L;

		/// <summary>
		/// Member bit: Comment text.
		/// </summary>
		/// <remarks>
		/// DB column: actiontext
		/// </remarks>
		public const long mbText = 256L;

		protected int lnTextValue;

		/// <summary>
		/// Member bit: GUID of the associated document version.
		/// </summary>
		/// <remarks>
		/// DB column: docversionguid
		/// </remarks>
		public const long mbDocVersionGuid = 512L;

		protected int lnDocVersionGuidValue;

		/// <summary>
		/// Member bit: GUID of the associated workflow.
		/// </summary>
		/// <remarks>
		/// DB column: workflowguid
		/// </remarks>
		public const long mbWorkflowGuid = 1024L;

		protected int lnWorkflowGuidValue;

		/// <summary>
		/// Member bit: Time stamp.
		/// </summary>
		/// <remarks>
		/// DB column: actiontstamp
		/// </remarks>
		public const long mbTStamp = 2048L;

		protected int lnTStampValue;

		/// <summary>
		/// Member bit: Raw ACL representation.
		/// </summary>
		/// <remarks>
		/// DB column: actionacl
		/// </remarks>
		public const long mbAcl = 4096L;

		protected int lnAclValue;

		/// <summary>
		/// Member bit: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: actiontstampsync
		/// </remarks>
		public const long mbTStampSync = 8192L;

		protected int lnTStampSyncValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 16383L;

		#endregion
		
		
		public static readonly long serialVersionUID = 423487901L;		
	} // end class
}  // end namespace

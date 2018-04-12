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
	/// This class represents the relation between HashTags and Actions.
	/// </summary>
	public class HashTagRelation : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public HashTagRelation() {
		}		
		
		public HashTagRelation(String @hashtagGuid, String @actionGuid, String @tStamp, int @status) {
			this.hashtagGuidValue = @hashtagGuid;
			this.actionGuidValue = @actionGuid;
			this.tStampValue = @tStamp;
			this.statusValue = @status;
		}		
		
		public HashTagRelation(HashTagRelation rhs) : base(rhs)
		{
			this.hashtagGuidValue = rhs.hashtagGuidValue;
			this.actionGuidValue = rhs.actionGuidValue;
			this.tStampValue = rhs.tStampValue;
			this.statusValue = rhs.statusValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Guid of the HashTag.
		/// </summary>
		public String hashtagGuid
		{
			get
			{
				return hashtagGuidValue;
			}
			set
			{
				this.hashtagGuidValue = value;
				setChangedMember(HashTagRelationC.mbHashtagGuid);
			}
		}
		
		
		/// <summary>
		/// Guid of the Action in which the HashTag is used.
		/// </summary>
		public String actionGuid
		{
			get
			{
				return actionGuidValue;
			}
			set
			{
				this.actionGuidValue = value;
				setChangedMember(HashTagRelationC.mbActionGuid);
			}
		}
		
		
		/// <summary>
		/// Timestamp for replication.
		/// </summary>
		public String tStamp
		{
			get
			{
				return tStampValue;
			}
			set
			{
				this.tStampValue = value;
				setChangedMember(HashTagRelationC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// Status.
		/// </summary>
		public int status
		{
			get
			{
				return statusValue;
			}
			set
			{
				this.statusValue = value;
				setChangedMember(HashTagRelationC.mbStatus);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String hashtagGuidValue;

		protected String actionGuidValue;

		protected String tStampValue;

		protected int statusValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1313473584L;		
	} // end class
}  // end namespace

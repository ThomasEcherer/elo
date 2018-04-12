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
	/// This class provides general informations for a keyword list.
	/// </summary>
	public class KeywordList : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public KeywordList() {
		}		
		
		public KeywordList(String @id, String @guid, String @tStamp, bool @deleted, int @userId, String @userName, EloixClient.IndexServer.Keyword[] @children, int @lockId, String @TStampSync) {
			this.idValue = @id;
			this.guidValue = @guid;
			this.tStampValue = @tStamp;
			this.deletedValue = @deleted;
			this.userIdValue = @userId;
			this.userNameValue = @userName;
			this.childrenValue = @children;
			this.lockIdValue = @lockId;
			this.TStampSyncValue = @TStampSync;
		}		
		
		public KeywordList(KeywordList rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.guidValue = rhs.guidValue;
			this.tStampValue = rhs.tStampValue;
			this.deletedValue = rhs.deletedValue;
			this.userIdValue = rhs.userIdValue;
			this.userNameValue = rhs.userNameValue;
			this.childrenValue = rhs.childrenValue;
			this.lockIdValue = rhs.lockIdValue;
			this.TStampSyncValue = rhs.TStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// ID
		/// </summary>
		public String id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
				setChangedMember(KeywordListC.mbId);
			}
		}
		
		
		/// <summary>
		/// GUID
		/// </summary>
		public String guid
		{
			get
			{
				return guidValue;
			}
			set
			{
				this.guidValue = value;
				setChangedMember(KeywordListC.mbGuid);
			}
		}
		
		
		/// <summary>
		/// Last modified, ISO - UTC
		/// Read-only.
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
				setChangedMember(KeywordListC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// RESERVED
		/// </summary>
		public bool deleted
		{
			get
			{
				return deletedValue;
			}
			set
			{
				this.deletedValue = value;
			}
		}
		
		
		/// <summary>
		/// ID of the user that has written the keyword list at last.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public int userId
		{
			get
			{
				return userIdValue;
			}
			set
			{
				this.userIdValue = value;
				setChangedMember(KeywordListC.mbUserId);
			}
		}
		
		
		/// <summary>
		/// Name of the user that has written the keyword list at last.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public String userName
		{
			get
			{
				return userNameValue;
			}
			set
			{
				this.userNameValue = value;
			}
		}
		
		
		/// <summary>
		/// The keyword list entries.
		/// </summary>
		public EloixClient.IndexServer.Keyword[] children
		{
			get
			{
				return childrenValue;
			}
			set
			{
				this.childrenValue = value;
			}
		}
		
		
		/// <summary>
		/// ID of the user who holds a lock on the keyword list.
		/// </summary>
		public int lockId
		{
			get
			{
				return lockIdValue;
			}
			set
			{
				this.lockIdValue = value;
				setChangedMember(KeywordListC.mbLockId);
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
				setChangedMember(KeywordListC.mbTStampSync);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String idValue;

		protected String guidValue;

		protected String tStampValue;

		protected bool deletedValue;

		protected int userIdValue;

		protected String userNameValue;

		protected EloixClient.IndexServer.Keyword[] childrenValue;

		protected int lockIdValue;

		protected String TStampSyncValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1495731174L;		
	} // end class
}  // end namespace

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
	/// This class represents one row in the database table physdel.
	/// </summary>
	/// <remarks>
	/// This table contains the guids of physically deleted objects.
	/// Those objects can be any objects with a guid: e.g.
	/// folders, documents, versions, users, workflows...
	/// </remarks>
	public class PhysDel : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public PhysDel() {
		}		
		
		public PhysDel(String @guid, int @type, String @TStamp, String @TStampSync) {
			this.guidValue = @guid;
			this.typeValue = @type;
			this.TStampValue = @TStamp;
			this.TStampSyncValue = @TStampSync;
		}		
		
		public PhysDel(PhysDel rhs) : base(rhs)
		{
			this.guidValue = rhs.guidValue;
			this.typeValue = rhs.typeValue;
			this.TStampValue = rhs.TStampValue;
			this.TStampSyncValue = rhs.TStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// GUID of deleted object.
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
				setChangedMember(PhysDelC.mbGuid);
			}
		}
		
		
		/// <summary>
		/// Type of deleted object.
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
				setChangedMember(PhysDelC.mbType);
			}
		}
		
		
		/// <summary>
		/// The object is deleted at this timestamp.
		/// </summary>
		/// <remarks>
		/// Measured in the UTC time-zone.
		/// </remarks>
		public String TStamp
		{
			get
			{
				return TStampValue;
			}
			set
			{
				this.TStampValue = value;
				setChangedMember(PhysDelC.mbTStamp);
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
				setChangedMember(PhysDelC.mbTStampSync);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String guidValue;

		protected int typeValue;

		protected String TStampValue;

		protected String TStampSyncValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 124345500L;		
	} // end class
}  // end namespace

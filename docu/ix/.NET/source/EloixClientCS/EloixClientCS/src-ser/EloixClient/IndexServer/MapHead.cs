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
	/// Internal class.
	/// </summary>
	public class MapHead : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public MapHead() {
		}		
		
		public MapHead(String @id, int @lockId, int @objId, String @TStamp, String @guid) {
			this.idValue = @id;
			this.lockIdValue = @lockId;
			this.objIdValue = @objId;
			this.TStampValue = @TStamp;
			this.guidValue = @guid;
		}		
		
		public MapHead(MapHead rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.lockIdValue = rhs.lockIdValue;
			this.objIdValue = rhs.objIdValue;
			this.TStampValue = rhs.TStampValue;
			this.guidValue = rhs.guidValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Map id.
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
				setChangedMember(MapHeadC.mbId);
			}
		}
		
		
		/// <summary>
		/// Lock status
		/// </summary>
		/// <remarks>
		/// .
		/// -1: unlocked, &gt;=0 user-ID.
		/// </remarks>
		public int lockId
		{
			get
			{
				return lockIdValue;
			}
			set
			{
				this.lockIdValue = value;
				setChangedMember(MapHeadC.mbLockId);
			}
		}
		
		
		/// <summary>
		/// Associated object ID or 0.
		/// </summary>
		public int objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
				setChangedMember(MapHeadC.mbObjId);
			}
		}
		
		
		/// <summary>
		/// Timestamp.
		/// </summary>
		public String TStamp
		{
			get
			{
				return TStampValue;
			}
			set
			{
				this.TStampValue = value;
				setChangedMember(MapHeadC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// GUID.
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
				setChangedMember(MapHeadC.mbGuid);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String idValue;

		protected int lockIdValue;

		protected int objIdValue;

		protected String TStampValue;

		protected String guidValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1379783697L;		
	} // end class
}  // end namespace

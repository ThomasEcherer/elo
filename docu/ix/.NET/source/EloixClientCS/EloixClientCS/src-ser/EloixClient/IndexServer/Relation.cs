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
	public class Relation : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public Relation() {
		}		
		
		public Relation(int @parentId, int @objId, int @ordinal, int @status, String @tStamp, String @guid, String @deleteDateIso, bool @mainRelation, String @TStampSync) {
			this.parentIdValue = @parentId;
			this.objIdValue = @objId;
			this.ordinalValue = @ordinal;
			this.statusValue = @status;
			this.tStampValue = @tStamp;
			this.guidValue = @guid;
			this.deleteDateIsoValue = @deleteDateIso;
			this.mainRelationValue = @mainRelation;
			this.TStampSyncValue = @TStampSync;
		}		
		
		public Relation(Relation rhs) : base(rhs)
		{
			this.parentIdValue = rhs.parentIdValue;
			this.objIdValue = rhs.objIdValue;
			this.ordinalValue = rhs.ordinalValue;
			this.statusValue = rhs.statusValue;
			this.tStampValue = rhs.tStampValue;
			this.guidValue = rhs.guidValue;
			this.deleteDateIsoValue = rhs.deleteDateIsoValue;
			this.mainRelationValue = rhs.mainRelationValue;
			this.TStampSyncValue = rhs.TStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: parentid
		/// </summary>
		public int parentId
		{
			get
			{
				return parentIdValue;
			}
			set
			{
				this.parentIdValue = value;
				setChangedMember(RelationC.mbParentId);
			}
		}
		
		
		/// <summary>
		/// DB column: objectid
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
				setChangedMember(RelationC.mbObjId);
			}
		}
		
		
		/// <summary>
		/// DB column: ordinal
		/// </summary>
		public int ordinal
		{
			get
			{
				return ordinalValue;
			}
			set
			{
				this.ordinalValue = value;
				setChangedMember(RelationC.mbOrdinal);
			}
		}
		
		
		/// <summary>
		/// DB column: relstatus
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
				setChangedMember(RelationC.mbStatus);
			}
		}
		
		
		/// <summary>
		/// DB column: reltstamp
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
				setChangedMember(RelationC.mbTStamp);
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
				setChangedMember(RelationC.mbGuid);
			}
		}
		
		
		/// <summary>
		/// The Relation is deleted at this date.
		/// </summary>
		/// <remarks>
		/// ClientInfo determines the Timezone.
		/// <p>
		/// Is undefined if status==0.
		/// </p>
		/// </remarks>
		public String deleteDateIso
		{
			get
			{
				return deleteDateIsoValue;
			}
			set
			{
				this.deleteDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// This Relation represents the main relation of an object, if this value is
		/// <code>true</code>.
		/// </summary>
		public bool mainRelation
		{
			get
			{
				return mainRelationValue;
			}
			set
			{
				this.mainRelationValue = value;
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
				setChangedMember(RelationC.mbTStampSync);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int parentIdValue;

		protected int objIdValue;

		protected int ordinalValue;

		protected int statusValue;

		protected String tStampValue;

		protected String guidValue;

		protected String deleteDateIsoValue;

		protected bool mainRelationValue;

		protected String TStampSyncValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 837810375L;		
	} // end class
}  // end namespace

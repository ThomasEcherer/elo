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
	/// This class represents a map which contains
	/// user defined key-value pairs.
	/// </summary>
	public class MapData : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public MapData() {
		}		
		
		public MapData(String @domainName, String @id, int @objId, int @lockId, String @lockName, String @TStamp, EloixClient.IndexServer.KeyValue[] @items, String @guid, IDictionary<String,EloixClient.IndexServer.MapValue> @mapItems) {
			this.domainNameValue = @domainName;
			this.idValue = @id;
			this.objIdValue = @objId;
			this.lockIdValue = @lockId;
			this.lockNameValue = @lockName;
			this.TStampValue = @TStamp;
			this.itemsValue = @items;
			this.guidValue = @guid;
			this.mapItemsValue = @mapItems;
		}		
		
		public MapData(MapData rhs) : base(rhs)
		{
			this.domainNameValue = rhs.domainNameValue;
			this.idValue = rhs.idValue;
			this.objIdValue = rhs.objIdValue;
			this.lockIdValue = rhs.lockIdValue;
			this.lockNameValue = rhs.lockNameValue;
			this.TStampValue = rhs.TStampValue;
			this.itemsValue = rhs.itemsValue;
			this.guidValue = rhs.guidValue;
			this.mapItemsValue = rhs.mapItemsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Map domain name.
		/// </summary>
		/// <remarks>
		/// An arbitary name or one of the predefined names in MapDomainC.
		/// </remarks>
		public String domainName
		{
			get
			{
				return domainNameValue;
			}
			set
			{
				this.domainNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Map ID.
		/// </summary>
		/// <remarks>
		/// If the map belongs to a Sord ID, this value is equal to the member objId.
		/// </remarks>
		public String id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
			}
		}
		
		
		/// <summary>
		/// Object ID.
		/// </summary>
		/// <remarks>
		/// The ID of the associated Sord object or 0, if the map does not belong to a Sord object.
		/// </remarks>
		public int objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
			}
		}
		
		
		/// <summary>
		/// User ID of the user that owns the lock on the map.
		/// </summary>
		/// <remarks>
		/// If the map is not locked, this value is -1.
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
			}
		}
		
		
		/// <summary>
		/// User name of the user that owns the lock no the map.
		/// </summary>
		/// <remarks>
		/// If the map is not locked, this value is an empty string.
		/// </remarks>
		public String lockName
		{
			get
			{
				return lockNameValue;
			}
			set
			{
				this.lockNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Timestamp
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
			}
		}
		
		
		/// <summary>
		/// Map items.
		/// </summary>
		/// <remarks>
		/// Since stream version 10.00.020.007, the items of this array can be cased to {@link MapValue},
		/// in order to access BLOB data.
		/// </remarks>
		public EloixClient.IndexServer.KeyValue[] items
		{
			get
			{
				return itemsValue;
			}
			set
			{
				this.itemsValue = value;
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
			}
		}
		
		
		/// <summary>
		/// Map items represented by class MapValue which gives access to BLOB values.
		/// </summary>
		public IDictionary<String,EloixClient.IndexServer.MapValue> mapItems
		{
			get
			{
				return mapItemsValue;
			}
			set
			{
				this.mapItemsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String domainNameValue;

		protected String idValue;

		protected int objIdValue;

		protected int lockIdValue;

		protected String lockNameValue;

		protected String TStampValue;

		protected EloixClient.IndexServer.KeyValue[] itemsValue;

		protected String guidValue;

		protected IDictionary<String,EloixClient.IndexServer.MapValue> mapItemsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2011132580L;		
	} // end class
}  // end namespace

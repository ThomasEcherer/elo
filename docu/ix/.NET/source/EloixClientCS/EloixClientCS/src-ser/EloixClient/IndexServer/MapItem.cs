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
	public class MapItem : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public MapItem() {
		}		
		
		public MapItem(String @id, String @key, String @value, String @contentType, System.IO.Stream @blobData) {
			this.idValue = @id;
			this.keyValue = @key;
			this.valueValue = @value;
			this.contentTypeValue = @contentType;
			this.blobDataValue = @blobData;
		}		
		
		public MapItem(MapItem rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.keyValue = rhs.keyValue;
			this.valueValue = rhs.valueValue;
			this.contentTypeValue = rhs.contentTypeValue;
			this.blobDataValue = rhs.blobDataValue;
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
				setChangedMember(MapItemC.mbId);
			}
		}
		
		
		/// <summary>
		/// Map key.
		/// </summary>
		public String key
		{
			get
			{
				return keyValue;
			}
			set
			{
				this.keyValue = value;
				setChangedMember(MapItemC.mbKey);
			}
		}
		
		
		/// <summary>
		/// Map value.
		/// </summary>
		public String value
		{
			get
			{
				return valueValue;
			}
			set
			{
				this.valueValue = value;
				setChangedMember(MapItemC.mbValue);
			}
		}
		
		
		/// <summary>
		/// Content Type.
		/// </summary>
		public String contentType
		{
			get
			{
				return contentTypeValue;
			}
			set
			{
				this.contentTypeValue = value;
				setChangedMember(MapItemC.mbContentType);
			}
		}
		
		
		/// <summary>
		/// Blob data.
		/// </summary>
		public System.IO.Stream blobData
		{
			get
			{
				return blobDataValue;
			}
			set
			{
				this.blobDataValue = value;
				setChangedMember(MapItemC.mbBlobData);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String idValue;

		protected String keyValue;

		protected String valueValue;

		protected String contentTypeValue;

		protected System.IO.Stream blobDataValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1461301521L;		
	} // end class
}  // end namespace

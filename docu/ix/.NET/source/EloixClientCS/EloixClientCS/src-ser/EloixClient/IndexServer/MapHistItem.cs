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
	/// This class provides the version information for a map attribute
	/// that has been modified.
	/// </summary>
	public class MapHistItem : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public MapHistItem() {
		}		
		
		public MapHistItem(String @histGuid, String @key, String @value, EloixClient.IndexServer.FileData @blobValue) {
			this.histGuidValue = @histGuid;
			this.keyValue = @key;
			this.valueValue = @value;
			this.blobValueValue = @blobValue;
		}		
		
		public MapHistItem(MapHistItem rhs) : base(rhs)
		{
			this.histGuidValue = rhs.histGuidValue;
			this.keyValue = rhs.keyValue;
			this.valueValue = rhs.valueValue;
			this.blobValueValue = rhs.blobValueValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// GUID of the assigned SordHist object.
		/// </summary>
		public String histGuid
		{
			get
			{
				return histGuidValue;
			}
			set
			{
				this.histGuidValue = value;
				setChangedMember(MapHistItemC.mbHistGuid);
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
				setChangedMember(MapHistItemC.mbKey);
			}
		}
		
		
		/// <summary>
		/// Map value.
		/// </summary>
		/// <remarks>
		/// An empty value means, that the map item has been deleted.
		/// </remarks>
		public String value
		{
			get
			{
				return valueValue;
			}
			set
			{
				this.valueValue = value;
				setChangedMember(MapHistItemC.mbValue);
			}
		}
		
		
		/// <summary>
		/// BLOB value.
		/// </summary>
		public EloixClient.IndexServer.FileData blobValue
		{
			get
			{
				return blobValueValue;
			}
			set
			{
				this.blobValueValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String histGuidValue;

		protected String keyValue;

		protected String valueValue;

		protected EloixClient.IndexServer.FileData blobValueValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 342049067L;		
	} // end class
}  // end namespace

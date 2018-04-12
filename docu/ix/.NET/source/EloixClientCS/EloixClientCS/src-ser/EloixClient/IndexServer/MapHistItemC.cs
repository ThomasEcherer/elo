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
	/// <p>Bit constants for members of MapHistItem</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class MapHistItemC : BSerializable
	{
	
		#region Constructors
		
		public MapHistItemC() {
		}		
		
		public MapHistItemC(int @lnHistGuid, int @lnKey, int @lnValue, int @lnContentType, int @lnBlobData) {
			this.lnHistGuidValue = @lnHistGuid;
			this.lnKeyValue = @lnKey;
			this.lnValueValue = @lnValue;
			this.lnContentTypeValue = @lnContentType;
			this.lnBlobDataValue = @lnBlobData;
		}		
		
		public MapHistItemC(MapHistItemC rhs)
		{
			this.lnHistGuidValue = rhs.lnHistGuidValue;
			this.lnKeyValue = rhs.lnKeyValue;
			this.lnValueValue = rhs.lnValueValue;
			this.lnContentTypeValue = rhs.lnContentTypeValue;
			this.lnBlobDataValue = rhs.lnBlobDataValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: Serialisation version ID
		/// DB column: maphistguid
		/// </summary>
		public int lnHistGuid
		{
			get
			{
				return lnHistGuidValue;
			}
			set
			{
				this.lnHistGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: mapkey
		/// </summary>
		public int lnKey
		{
			get
			{
				return lnKeyValue;
			}
			set
			{
				this.lnKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: mapvalue
		/// </summary>
		public int lnValue
		{
			get
			{
				return lnValueValue;
			}
			set
			{
				this.lnValueValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: mapcontenttype
		/// </summary>
		public int lnContentType
		{
			get
			{
				return lnContentTypeValue;
			}
			set
			{
				this.lnContentTypeValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: mapblob
		/// </summary>
		public int lnBlobData
		{
			get
			{
				return lnBlobDataValue;
			}
			set
			{
				this.lnBlobDataValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: Serialisation version ID
		/// DB column: maphistguid
		/// </summary>
		public const long mbHistGuid = 1L;

		protected int lnHistGuidValue;

		/// <summary>
		/// DB column: mapkey
		/// </summary>
		public const long mbKey = 2L;

		protected int lnKeyValue;

		/// <summary>
		/// DB column: mapvalue
		/// </summary>
		public const long mbValue = 4L;

		protected int lnValueValue;

		/// <summary>
		/// DB column: mapcontenttype
		/// </summary>
		public const long mbContentType = 8L;

		protected int lnContentTypeValue;

		/// <summary>
		/// DB column: mapblob
		/// </summary>
		public const long mbBlobData = 16L;

		protected int lnBlobDataValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 31L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1314989638L;		
	} // end class
}  // end namespace

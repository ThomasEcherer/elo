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
	/// <p>Bit constants for members of MapItem</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class MapItemC : BSerializable
	{
	
		#region Constructors
		
		public MapItemC() {
		}		
		
		public MapItemC(int @lnId, int @lnKey, int @lnValue, int @lnContentType, int @lnBlobData) {
			this.lnIdValue = @lnId;
			this.lnKeyValue = @lnKey;
			this.lnValueValue = @lnValue;
			this.lnContentTypeValue = @lnContentType;
			this.lnBlobDataValue = @lnBlobData;
		}		
		
		public MapItemC(MapItemC rhs)
		{
			this.lnIdValue = rhs.lnIdValue;
			this.lnKeyValue = rhs.lnKeyValue;
			this.lnValueValue = rhs.lnValueValue;
			this.lnContentTypeValue = rhs.lnContentTypeValue;
			this.lnBlobDataValue = rhs.lnBlobDataValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: mapid
		/// </summary>
		public int lnId
		{
			get
			{
				return lnIdValue;
			}
			set
			{
				this.lnIdValue = value;
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
		/// Column length: Content Type.
		/// </summary>
		/// <remarks>
		/// DB column: mapcontenttype
		/// </remarks>
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
		/// Column length: Blob data.
		/// </summary>
		/// <remarks>
		/// DB column: mapblob
		/// </remarks>
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
		/// DB column: mapid
		/// </summary>
		public const long mbId = 1L;

		protected int lnIdValue;

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
		/// Member bit: Content Type.
		/// </summary>
		/// <remarks>
		/// DB column: mapcontenttype
		/// </remarks>
		public const long mbContentType = 8L;

		protected int lnContentTypeValue;

		/// <summary>
		/// Member bit: Blob data.
		/// </summary>
		/// <remarks>
		/// DB column: mapblob
		/// </remarks>
		public const long mbBlobData = 16L;

		protected int lnBlobDataValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 31L;

		#endregion
		
		
		public static readonly long serialVersionUID = 812006040L;		
	} // end class
}  // end namespace

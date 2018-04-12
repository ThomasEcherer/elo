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
	/// Constant class for MapData
	/// </summary>
	public class MapDataC : BSerializable
	{
	
		#region Constructors
		
		public MapDataC() {
		}		
		
		public MapDataC(int @lnValue, int @lnKey, int @lnId, int @lnBlob) {
			this.lnValueValue = @lnValue;
			this.lnKeyValue = @lnKey;
			this.lnIdValue = @lnId;
			this.lnBlobValue = @lnBlob;
		}		
		
		public MapDataC(MapDataC rhs)
		{
			this.lnValueValue = rhs.lnValueValue;
			this.lnKeyValue = rhs.lnKeyValue;
			this.lnIdValue = rhs.lnIdValue;
			this.lnBlobValue = rhs.lnBlobValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Maximum length of map item value.
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
		/// Maximum length of map item key.
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
		/// Maximum length of map id.
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
		/// Maximum length of blob value.
		/// 1048576 Bytes
		/// </summary>
		public int lnBlob
		{
			get
			{
				return lnBlobValue;
			}
			set
			{
				this.lnBlobValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int lnValueValue;

		protected int lnKeyValue;

		protected int lnIdValue;

		protected int lnBlobValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1277095765L;		
	} // end class
}  // end namespace

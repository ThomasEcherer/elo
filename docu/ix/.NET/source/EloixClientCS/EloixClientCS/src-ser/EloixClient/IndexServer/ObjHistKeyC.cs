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
	/// <p>Bit constants for members of SordHistKey</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ObjHistKeyC : BSerializable
	{
	
		#region Constructors
		
		public ObjHistKeyC() {
		}		
		
		public ObjHistKeyC(int @lnHistGuid, int @lnKeyName, int @lnKeyData, int @lnKeyDataDesc) {
			this.lnHistGuidValue = @lnHistGuid;
			this.lnKeyNameValue = @lnKeyName;
			this.lnKeyDataValue = @lnKeyData;
			this.lnKeyDataDescValue = @lnKeyDataDesc;
		}		
		
		public ObjHistKeyC(ObjHistKeyC rhs)
		{
			this.lnHistGuidValue = rhs.lnHistGuidValue;
			this.lnKeyNameValue = rhs.lnKeyNameValue;
			this.lnKeyDataValue = rhs.lnKeyDataValue;
			this.lnKeyDataDescValue = rhs.lnKeyDataDescValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: Serialisation version ID
		/// DB column: objhistguid
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
		/// DB column: okeyname
		/// </summary>
		public int lnKeyName
		{
			get
			{
				return lnKeyNameValue;
			}
			set
			{
				this.lnKeyNameValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: okeydata
		/// </summary>
		public int lnKeyData
		{
			get
			{
				return lnKeyDataValue;
			}
			set
			{
				this.lnKeyDataValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Internal helper column for memo text.
		/// </summary>
		/// <remarks>
		/// DB column: objdesc
		/// </remarks>
		public int lnKeyDataDesc
		{
			get
			{
				return lnKeyDataDescValue;
			}
			set
			{
				this.lnKeyDataDescValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: Serialisation version ID
		/// DB column: objhistguid
		/// </summary>
		public const long mbHistGuid = 1L;

		protected int lnHistGuidValue;

		/// <summary>
		/// DB column: okeyno
		/// </summary>
		public const long mbKeyNo = 2L;

		/// <summary>
		/// DB column: okeyname
		/// </summary>
		public const long mbKeyName = 4L;

		protected int lnKeyNameValue;

		/// <summary>
		/// DB column: okeydata
		/// </summary>
		public const long mbKeyData = 8L;

		protected int lnKeyDataValue;

		/// <summary>
		/// Member bit: Internal helper column for memo text.
		/// </summary>
		/// <remarks>
		/// DB column: objdesc
		/// </remarks>
		public const long mbKeyDataDesc = 16L;

		protected int lnKeyDataDescValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 31L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1013854536L;		
	} // end class
}  // end namespace

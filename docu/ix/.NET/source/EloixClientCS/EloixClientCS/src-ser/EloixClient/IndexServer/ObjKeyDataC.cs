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
	/// <p>Bit constants for members of ObjKeyData</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ObjKeyDataC : BSerializable
	{
	
		#region Constructors
		
		public ObjKeyDataC() {
		}		
		
		public ObjKeyDataC(int @lnName, int @lnData, int @lnUdata, int @lnSdata, int @lnOdouble) {
			this.lnNameValue = @lnName;
			this.lnDataValue = @lnData;
			this.lnUdataValue = @lnUdata;
			this.lnSdataValue = @lnSdata;
			this.lnOdoubleValue = @lnOdouble;
		}		
		
		public ObjKeyDataC(ObjKeyDataC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
			this.lnDataValue = rhs.lnDataValue;
			this.lnUdataValue = rhs.lnUdataValue;
			this.lnSdataValue = rhs.lnSdataValue;
			this.lnOdoubleValue = rhs.lnOdoubleValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: okeyname
		/// </summary>
		public int lnName
		{
			get
			{
				return lnNameValue;
			}
			set
			{
				this.lnNameValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: okeydata
		/// </summary>
		public int lnData
		{
			get
			{
				return lnDataValue;
			}
			set
			{
				this.lnDataValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: okeyudata
		/// </summary>
		public int lnUdata
		{
			get
			{
				return lnUdataValue;
			}
			set
			{
				this.lnUdataValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: okeysdata_off
		/// </summary>
		public int lnSdata
		{
			get
			{
				return lnSdataValue;
			}
			set
			{
				this.lnSdataValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: DB column: odouble
		/// DB column: okeydouble
		/// </summary>
		public int lnOdouble
		{
			get
			{
				return lnOdoubleValue;
			}
			set
			{
				this.lnOdoubleValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: parentid
		/// </summary>
		public const long mbObjId = 1L;

		/// <summary>
		/// DB column: okeyno
		/// </summary>
		public const long mbId = 2L;

		/// <summary>
		/// DB column: okeyname
		/// </summary>
		public const long mbName = 4L;

		protected int lnNameValue;

		/// <summary>
		/// DB column: okeydata
		/// </summary>
		public const long mbData = 8L;

		protected int lnDataValue;

		/// <summary>
		/// DB column: okeyudata
		/// </summary>
		public const long mbUdata = 16L;

		protected int lnUdataValue;

		/// <summary>
		/// DB column: okeysdata_off
		/// </summary>
		public const long mbSdata = 32L;

		protected int lnSdataValue;

		/// <summary>
		/// Member bit: DB column: odouble
		/// DB column: okeydouble
		/// </summary>
		public const long mbOdouble = 64L;

		protected int lnOdoubleValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 127L;

		#endregion
		
		
		public static readonly long serialVersionUID = 2463451L;		
	} // end class
}  // end namespace

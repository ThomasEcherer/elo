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
	/// <p>Bit constants for members of Alert</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class AlertDataC : BSerializable
	{
	
		#region Constructors
		
		public AlertDataC() {
		}		
		
		public AlertDataC(int @lnMemo) {
			this.lnMemoValue = @lnMemo;
		}		
		
		public AlertDataC(AlertDataC rhs)
		{
			this.lnMemoValue = rhs.lnMemoValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: alertmemo
		/// </summary>
		public int lnMemo
		{
			get
			{
				return lnMemoValue;
			}
			set
			{
				this.lnMemoValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: destination
		/// </summary>
		public const long mbDest = 1L;

		/// <summary>
		/// DB column: source
		/// </summary>
		public const long mbSource = 2L;

		/// <summary>
		/// DB column: alerttype
		/// </summary>
		public const long mbType = 4L;

		/// <summary>
		/// DB column: objid
		/// </summary>
		public const long mbObjId = 8L;

		/// <summary>
		/// DB column: extra1
		/// </summary>
		public const long mbExtra1 = 16L;

		/// <summary>
		/// DB column: extra2
		/// </summary>
		public const long mbExtra2 = 32L;

		/// <summary>
		/// DB column: alertmemo
		/// </summary>
		public const long mbMemo = 64L;

		protected int lnMemoValue;

		/// <summary>
		/// DB column: alerttime
		/// </summary>
		public const long mbTime = 128L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 255L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1498169909L;		
	} // end class
}  // end namespace

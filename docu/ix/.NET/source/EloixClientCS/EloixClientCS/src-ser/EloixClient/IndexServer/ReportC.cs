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
	/// <p>Bit constants for members of ReportInfo</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ReportC : BSerializable
	{
	
		#region Constructors
		
		public ReportC() {
		}		
		
		public ReportC(int @lnId, int @lnText, int @lnExtra3) {
			this.lnIdValue = @lnId;
			this.lnTextValue = @lnText;
			this.lnExtra3Value = @lnExtra3;
		}		
		
		public ReportC(ReportC rhs)
		{
			this.lnIdValue = rhs.lnIdValue;
			this.lnTextValue = rhs.lnTextValue;
			this.lnExtra3Value = rhs.lnExtra3Value;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: reportid
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
		/// DB column: addtext
		/// </summary>
		public int lnText
		{
			get
			{
				return lnTextValue;
			}
			set
			{
				this.lnTextValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Reserved.
		/// </summary>
		/// <remarks>
		/// DB column: extra3
		/// </remarks>
		public int lnExtra3
		{
			get
			{
				return lnExtra3Value;
			}
			set
			{
				this.lnExtra3Value = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: reportid
		/// </summary>
		public const long mbId = 1L;

		protected int lnIdValue;

		/// <summary>
		/// DB column: actionno
		/// </summary>
		public const long mbActionNo = 2L;

		/// <summary>
		/// DB column: userid
		/// </summary>
		public const long mbUserId = 4L;

		/// <summary>
		/// DB column: acttime
		/// </summary>
		public const long mbActTime = 8L;

		/// <summary>
		/// DB column: docid
		/// </summary>
		public const long mbObjId = 16L;

		/// <summary>
		/// DB column: extra1
		/// </summary>
		public const long mbExtra1 = 32L;

		/// <summary>
		/// DB column: extra2
		/// </summary>
		public const long mbExtra2 = 64L;

		/// <summary>
		/// DB column: sessionno
		/// </summary>
		public const long mbSessionNo = 128L;

		/// <summary>
		/// DB column: addtext
		/// </summary>
		public const long mbText = 256L;

		protected int lnTextValue;

		/// <summary>
		/// Member bit: Reserved.
		/// </summary>
		/// <remarks>
		/// DB column: extra3
		/// </remarks>
		public const long mbExtra3 = 512L;

		protected int lnExtra3Value;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 1023L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1285453013L;		
	} // end class
}  // end namespace

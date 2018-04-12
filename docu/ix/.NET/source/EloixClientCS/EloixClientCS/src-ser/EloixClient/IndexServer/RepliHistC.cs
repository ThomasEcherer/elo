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
	/// <p>Bit constants for members of RepliHist</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class RepliHistC : BSerializable
	{
	
		#region Constructors
		
		public RepliHistC() {
		}		
		
		public RepliHistC(int @lnTSDate, int @lnArcGuid, int @lnArcShort, int @lnArcDesc, int @lnTSBegin, int @lnTSEnd) {
			this.lnTSDateValue = @lnTSDate;
			this.lnArcGuidValue = @lnArcGuid;
			this.lnArcShortValue = @lnArcShort;
			this.lnArcDescValue = @lnArcDesc;
			this.lnTSBeginValue = @lnTSBegin;
			this.lnTSEndValue = @lnTSEnd;
		}		
		
		public RepliHistC(RepliHistC rhs)
		{
			this.lnTSDateValue = rhs.lnTSDateValue;
			this.lnArcGuidValue = rhs.lnArcGuidValue;
			this.lnArcShortValue = rhs.lnArcShortValue;
			this.lnArcDescValue = rhs.lnArcDescValue;
			this.lnTSBeginValue = rhs.lnTSBeginValue;
			this.lnTSEndValue = rhs.lnTSEndValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: rhtsdate
		/// </summary>
		public int lnTSDate
		{
			get
			{
				return lnTSDateValue;
			}
			set
			{
				this.lnTSDateValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: rharcguid
		/// </summary>
		public int lnArcGuid
		{
			get
			{
				return lnArcGuidValue;
			}
			set
			{
				this.lnArcGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: rharcshort
		/// </summary>
		public int lnArcShort
		{
			get
			{
				return lnArcShortValue;
			}
			set
			{
				this.lnArcShortValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: rharcdesc
		/// </summary>
		public int lnArcDesc
		{
			get
			{
				return lnArcDescValue;
			}
			set
			{
				this.lnArcDescValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: rhtsbegin
		/// </summary>
		public int lnTSBegin
		{
			get
			{
				return lnTSBeginValue;
			}
			set
			{
				this.lnTSBeginValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: rhtsend
		/// </summary>
		public int lnTSEnd
		{
			get
			{
				return lnTSEndValue;
			}
			set
			{
				this.lnTSEndValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: rhrowid
		/// </summary>
		public const long mbId = 1L;

		/// <summary>
		/// DB column: rhtsdate
		/// </summary>
		public const long mbTSDate = 2L;

		protected int lnTSDateValue;

		/// <summary>
		/// DB column: rhimex
		/// </summary>
		public const long mbImEx = 4L;

		/// <summary>
		/// DB column: rhsucc
		/// </summary>
		public const long mbSucc = 8L;

		/// <summary>
		/// DB column: rharcguid
		/// </summary>
		public const long mbArcGuid = 16L;

		protected int lnArcGuidValue;

		/// <summary>
		/// DB column: rharcshort
		/// </summary>
		public const long mbArcShort = 32L;

		protected int lnArcShortValue;

		/// <summary>
		/// DB column: rharcdesc
		/// </summary>
		public const long mbArcDesc = 64L;

		protected int lnArcDescValue;

		/// <summary>
		/// DB column: rhtsbegin
		/// </summary>
		public const long mbTSBegin = 128L;

		protected int lnTSBeginValue;

		/// <summary>
		/// DB column: rhtsend
		/// </summary>
		public const long mbTSEnd = 256L;

		protected int lnTSEndValue;

		/// <summary>
		/// DB column: rhpriolocal
		/// </summary>
		public const long mbArcPriorityLocal = 512L;

		/// <summary>
		/// DB column: rhprioremote
		/// </summary>
		public const long mbArcPriorityRemote = 1024L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 2047L;

		#endregion
		
		
		public static readonly long serialVersionUID = 104551413L;		
	} // end class
}  // end namespace

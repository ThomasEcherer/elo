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
	/// <p>Bit constants for members of TranslateTermData</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class TranslateTermDataC : BSerializable
	{
	
		#region Constructors
		
		public TranslateTermDataC() {
		}		
		
		public TranslateTermDataC(int @lnGuid, int @lnTStamp, int @lnLang1, int @lnLang2, int @lnLang3, int @lnLang4, int @lnLang5, int @lnLang6, int @lnLang7, int @lnLang8, int @lnLang9, int @lnTStampSync) {
			this.lnGuidValue = @lnGuid;
			this.lnTStampValue = @lnTStamp;
			this.lnLang1Value = @lnLang1;
			this.lnLang2Value = @lnLang2;
			this.lnLang3Value = @lnLang3;
			this.lnLang4Value = @lnLang4;
			this.lnLang5Value = @lnLang5;
			this.lnLang6Value = @lnLang6;
			this.lnLang7Value = @lnLang7;
			this.lnLang8Value = @lnLang8;
			this.lnLang9Value = @lnLang9;
			this.lnTStampSyncValue = @lnTStampSync;
		}		
		
		public TranslateTermDataC(TranslateTermDataC rhs)
		{
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnLang1Value = rhs.lnLang1Value;
			this.lnLang2Value = rhs.lnLang2Value;
			this.lnLang3Value = rhs.lnLang3Value;
			this.lnLang4Value = rhs.lnLang4Value;
			this.lnLang5Value = rhs.lnLang5Value;
			this.lnLang6Value = rhs.lnLang6Value;
			this.lnLang7Value = rhs.lnLang7Value;
			this.lnLang8Value = rhs.lnLang8Value;
			this.lnLang9Value = rhs.lnLang9Value;
			this.lnTStampSyncValue = rhs.lnTStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: GUID
		/// DB column: guid
		/// </summary>
		public int lnGuid
		{
			get
			{
				return lnGuidValue;
			}
			set
			{
				this.lnGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Timestamp.
		/// </summary>
		/// <remarks>
		/// DB column: tstamp
		/// </remarks>
		public int lnTStamp
		{
			get
			{
				return lnTStampValue;
			}
			set
			{
				this.lnTStampValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Language 1.
		/// </summary>
		/// <remarks>
		/// System language.
		/// DB column: lang1
		/// </remarks>
		public int lnLang1
		{
			get
			{
				return lnLang1Value;
			}
			set
			{
				this.lnLang1Value = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Language 2
		/// DB column: lang2
		/// </summary>
		public int lnLang2
		{
			get
			{
				return lnLang2Value;
			}
			set
			{
				this.lnLang2Value = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Language 3
		/// DB column: lang3
		/// </summary>
		public int lnLang3
		{
			get
			{
				return lnLang3Value;
			}
			set
			{
				this.lnLang3Value = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Language 4
		/// DB column: lang4
		/// </summary>
		public int lnLang4
		{
			get
			{
				return lnLang4Value;
			}
			set
			{
				this.lnLang4Value = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Language 5
		/// DB column: lang5
		/// </summary>
		public int lnLang5
		{
			get
			{
				return lnLang5Value;
			}
			set
			{
				this.lnLang5Value = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Language 6
		/// DB column: lang6
		/// </summary>
		public int lnLang6
		{
			get
			{
				return lnLang6Value;
			}
			set
			{
				this.lnLang6Value = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Language 7
		/// DB column: lang7
		/// </summary>
		public int lnLang7
		{
			get
			{
				return lnLang7Value;
			}
			set
			{
				this.lnLang7Value = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Language 8
		/// DB column: lang8
		/// </summary>
		public int lnLang8
		{
			get
			{
				return lnLang8Value;
			}
			set
			{
				this.lnLang8Value = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Language 9
		/// DB column: lang9
		/// </summary>
		public int lnLang9
		{
			get
			{
				return lnLang9Value;
			}
			set
			{
				this.lnLang9Value = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Timestamp.
		/// </summary>
		/// <remarks>
		/// DB column: tstampsync
		/// </remarks>
		public int lnTStampSync
		{
			get
			{
				return lnTStampSyncValue;
			}
			set
			{
				this.lnTStampSyncValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: GUID
		/// DB column: guid
		/// </summary>
		public const long mbGuid = 1L;

		protected int lnGuidValue;

		/// <summary>
		/// Member bit: Timestamp.
		/// </summary>
		/// <remarks>
		/// DB column: tstamp
		/// </remarks>
		public const long mbTStamp = 2L;

		protected int lnTStampValue;

		/// <summary>
		/// Member bit: Status.
		/// </summary>
		/// <remarks>
		/// DB column: status
		/// </remarks>
		public const long mbStatus = 4L;

		/// <summary>
		/// Member bit: Language 1.
		/// </summary>
		/// <remarks>
		/// System language.
		/// DB column: lang1
		/// </remarks>
		public const long mbLang1 = 8L;

		protected int lnLang1Value;

		/// <summary>
		/// Member bit: Language 2
		/// DB column: lang2
		/// </summary>
		public const long mbLang2 = 16L;

		protected int lnLang2Value;

		/// <summary>
		/// Member bit: Language 3
		/// DB column: lang3
		/// </summary>
		public const long mbLang3 = 32L;

		protected int lnLang3Value;

		/// <summary>
		/// Member bit: Language 4
		/// DB column: lang4
		/// </summary>
		public const long mbLang4 = 64L;

		protected int lnLang4Value;

		/// <summary>
		/// Member bit: Language 5
		/// DB column: lang5
		/// </summary>
		public const long mbLang5 = 128L;

		protected int lnLang5Value;

		/// <summary>
		/// Member bit: Language 6
		/// DB column: lang6
		/// </summary>
		public const long mbLang6 = 256L;

		protected int lnLang6Value;

		/// <summary>
		/// Member bit: Language 7
		/// DB column: lang7
		/// </summary>
		public const long mbLang7 = 512L;

		protected int lnLang7Value;

		/// <summary>
		/// Member bit: Language 8
		/// DB column: lang8
		/// </summary>
		public const long mbLang8 = 1024L;

		protected int lnLang8Value;

		/// <summary>
		/// Member bit: Language 9
		/// DB column: lang9
		/// </summary>
		public const long mbLang9 = 2048L;

		protected int lnLang9Value;

		/// <summary>
		/// Member bit: Timestamp.
		/// </summary>
		/// <remarks>
		/// DB column: tstampsync
		/// </remarks>
		public const long mbTStampSync = 4096L;

		protected int lnTStampSyncValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 8191L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1699470707L;		
	} // end class
}  // end namespace

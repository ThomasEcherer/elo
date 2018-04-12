//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	/// <summary>
	/// <p>Bit constants for members of HashTag</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class HashTagDataC : BSerializable
	{
	
		#region Constructors
		
		public HashTagDataC() {
		}		
		
		public HashTagDataC(int @lnHstgGuid, int @lnHstgName, int @lnCreateDateIso, int @lnLastUsedIso, int @lnTStamp) {
			this.lnHstgGuidValue = @lnHstgGuid;
			this.lnHstgNameValue = @lnHstgName;
			this.lnCreateDateIsoValue = @lnCreateDateIso;
			this.lnLastUsedIsoValue = @lnLastUsedIso;
			this.lnTStampValue = @lnTStamp;
		}		
		
		public HashTagDataC(HashTagDataC rhs)
		{
			this.lnHstgGuidValue = rhs.lnHstgGuidValue;
			this.lnHstgNameValue = rhs.lnHstgNameValue;
			this.lnCreateDateIsoValue = rhs.lnCreateDateIsoValue;
			this.lnLastUsedIsoValue = rhs.lnLastUsedIsoValue;
			this.lnTStampValue = rhs.lnTStampValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: HashTag GUID.
		/// </summary>
		/// <remarks>
		/// DB column: hstgguid
		/// </remarks>
		public int lnHstgGuid
		{
			get
			{
				return lnHstgGuidValue;
			}
			set
			{
				this.lnHstgGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: HashTag Name.
		/// </summary>
		/// <remarks>
		/// DB column: hstgname
		/// </remarks>
		public int lnHstgName
		{
			get
			{
				return lnHstgNameValue;
			}
			set
			{
				this.lnHstgNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Create date.
		/// </summary>
		/// <remarks>
		/// DB column: createdateiso
		/// </remarks>
		public int lnCreateDateIso
		{
			get
			{
				return lnCreateDateIsoValue;
			}
			set
			{
				this.lnCreateDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Last used.
		/// </summary>
		/// <remarks>
		/// DB column: lastusediso
		/// </remarks>
		public int lnLastUsedIso
		{
			get
			{
				return lnLastUsedIsoValue;
			}
			set
			{
				this.lnLastUsedIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Timestamp for replication.
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
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: HashTag GUID.
		/// </summary>
		/// <remarks>
		/// DB column: hstgguid
		/// </remarks>
		public const long mbHstgGuid = 1L;

		protected int lnHstgGuidValue;

		/// <summary>
		/// Member bit: HashTag Name.
		/// </summary>
		/// <remarks>
		/// DB column: hstgname
		/// </remarks>
		public const long mbHstgName = 2L;

		protected int lnHstgNameValue;

		/// <summary>
		/// Member bit: Create date.
		/// </summary>
		/// <remarks>
		/// DB column: createdateiso
		/// </remarks>
		public const long mbCreateDateIso = 4L;

		protected int lnCreateDateIsoValue;

		/// <summary>
		/// Member bit: Last used.
		/// </summary>
		/// <remarks>
		/// DB column: lastusediso
		/// </remarks>
		public const long mbLastUsedIso = 8L;

		protected int lnLastUsedIsoValue;

		/// <summary>
		/// Member bit: Timestamp for replication.
		/// </summary>
		/// <remarks>
		/// DB column: tstamp
		/// </remarks>
		public const long mbTStamp = 16L;

		protected int lnTStampValue;

		/// <summary>
		/// Member bit: Status.
		/// </summary>
		/// <remarks>
		/// DB column: status
		/// </remarks>
		public const long mbStatus = 32L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 63L;

		#endregion
		
		
		public static readonly long serialVersionUID = 513648569L;		
	} // end class
}  // end namespace

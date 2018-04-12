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
	/// <p>Bit constants for members of Thesaurus</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ThesaurusC : BSerializable
	{
	
		#region Constructors
		
		public ThesaurusC() {
		}		
		
		public ThesaurusC(int @lnData, int @lnCompare) {
			this.lnDataValue = @lnData;
			this.lnCompareValue = @lnCompare;
		}		
		
		public ThesaurusC(ThesaurusC rhs)
		{
			this.lnDataValue = rhs.lnDataValue;
			this.lnCompareValue = rhs.lnCompareValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: data
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
		/// DB column: compare
		/// </summary>
		public int lnCompare
		{
			get
			{
				return lnCompareValue;
			}
			set
			{
				this.lnCompareValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: groupid
		/// </summary>
		public const long mbGroupId = 1L;

		/// <summary>
		/// DB column: prio
		/// </summary>
		public const long mbPrio = 2L;

		/// <summary>
		/// DB column: data
		/// </summary>
		public const long mbData = 4L;

		protected int lnDataValue;

		/// <summary>
		/// DB column: compare
		/// </summary>
		public const long mbCompare = 8L;

		protected int lnCompareValue;

		/// <summary>
		/// DB column: listid
		/// </summary>
		public const long mbListId = 16L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 31L;

		#endregion
		
		
		public static readonly long serialVersionUID = 670698541L;		
	} // end class
}  // end namespace

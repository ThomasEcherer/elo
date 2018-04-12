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
	/// <p>Bit constants for members of NoteTemplate</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class NoteTemplateDataC : BSerializable
	{
	
		#region Constructors
		
		public NoteTemplateDataC() {
		}		
		
		public NoteTemplateDataC(int @lnOptKey, int @lnOptValue) {
			this.lnOptKeyValue = @lnOptKey;
			this.lnOptValueValue = @lnOptValue;
		}		
		
		public NoteTemplateDataC(NoteTemplateDataC rhs)
		{
			this.lnOptKeyValue = rhs.lnOptKeyValue;
			this.lnOptValueValue = rhs.lnOptValueValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: optkey
		/// </summary>
		public int lnOptKey
		{
			get
			{
				return lnOptKeyValue;
			}
			set
			{
				this.lnOptKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: optvalue
		/// </summary>
		public int lnOptValue
		{
			get
			{
				return lnOptValueValue;
			}
			set
			{
				this.lnOptValueValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: userid
		/// </summary>
		public const long mbUserIdInt = 1L;

		/// <summary>
		/// DB column: optkey
		/// </summary>
		public const long mbOptKey = 2L;

		protected int lnOptKeyValue;

		/// <summary>
		/// DB column: optvalue
		/// </summary>
		public const long mbOptValue = 4L;

		protected int lnOptValueValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 7L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1775437403L;		
	} // end class
}  // end namespace

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
	/// <p>Bit constants for members of Reminder</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ReminderDataC : BSerializable
	{
	
		#region Constructors
		
		public ReminderDataC() {
		}		
		
		public ReminderDataC(int @lnName, int @lnDesc) {
			this.lnNameValue = @lnName;
			this.lnDescValue = @lnDesc;
		}		
		
		public ReminderDataC(ReminderDataC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
			this.lnDescValue = rhs.lnDescValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: short
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
		/// DB column: wvdesc
		/// </summary>
		public int lnDesc
		{
			get
			{
				return lnDescValue;
			}
			set
			{
				this.lnDescValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: wvident
		/// </summary>
		public const long mbId = 1L;

		/// <summary>
		/// DB column: parentid
		/// </summary>
		public const long mbObjId = 2L;

		/// <summary>
		/// DB column: userowner
		/// </summary>
		public const long mbReceiverId = 4L;

		/// <summary>
		/// DB column: userfrom
		/// </summary>
		public const long mbSenderId = 8L;

		/// <summary>
		/// DB column: wvdate
		/// </summary>
		public const long mbPromptDate = 16L;

		/// <summary>
		/// DB column: createdate
		/// </summary>
		public const long mbCreateDate = 32L;

		/// <summary>
		/// DB column: duedate
		/// </summary>
		public const long mbDueDate = 64L;

		/// <summary>
		/// DB column: prio
		/// </summary>
		public const long mbPrio = 128L;

		/// <summary>
		/// DB column: action
		/// </summary>
		public const long mbActionCode = 256L;

		/// <summary>
		/// DB column: wvlock
		/// </summary>
		public const long mbLockId = 512L;

		/// <summary>
		/// DB column: parenttype
		/// </summary>
		public const long mbObjType = 1024L;

		/// <summary>
		/// DB column: short
		/// </summary>
		public const long mbName = 2048L;

		protected int lnNameValue;

		/// <summary>
		/// DB column: wvdesc
		/// </summary>
		public const long mbDesc = 4096L;

		protected int lnDescValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 8191L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1099169893L;		
	} // end class
}  // end namespace

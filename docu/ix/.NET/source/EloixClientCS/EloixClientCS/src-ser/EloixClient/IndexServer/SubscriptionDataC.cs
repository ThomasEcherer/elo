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
	/// <p>Bit constants for members of Subscription</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class SubscriptionDataC : BSerializable
	{
	
		#region Constructors
		
		public SubscriptionDataC() {
		}		
		
		public SubscriptionDataC(int @lnUserGuid, int @lnWatchGuid, int @lnCreateDateIso) {
			this.lnUserGuidValue = @lnUserGuid;
			this.lnWatchGuidValue = @lnWatchGuid;
			this.lnCreateDateIsoValue = @lnCreateDateIso;
		}		
		
		public SubscriptionDataC(SubscriptionDataC rhs)
		{
			this.lnUserGuidValue = rhs.lnUserGuidValue;
			this.lnWatchGuidValue = rhs.lnWatchGuidValue;
			this.lnCreateDateIsoValue = rhs.lnCreateDateIsoValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: GUID of user who registered the subscription.
		/// </summary>
		/// <remarks>
		/// DB column: userguid
		/// </remarks>
		public int lnUserGuid
		{
			get
			{
				return lnUserGuidValue;
			}
			set
			{
				this.lnUserGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: GUID of Object to be watched.
		/// </summary>
		/// <remarks>
		/// DB column: watchguid
		/// </remarks>
		public int lnWatchGuid
		{
			get
			{
				return lnWatchGuidValue;
			}
			set
			{
				this.lnWatchGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Create date of the subscription.
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
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: GUID of user who registered the subscription.
		/// </summary>
		/// <remarks>
		/// DB column: userguid
		/// </remarks>
		public const long mbUserGuid = 1L;

		protected int lnUserGuidValue;

		/// <summary>
		/// Member bit: GUID of Object to be watched.
		/// </summary>
		/// <remarks>
		/// DB column: watchguid
		/// </remarks>
		public const long mbWatchGuid = 2L;

		protected int lnWatchGuidValue;

		/// <summary>
		/// Member bit: Create date of the subscription.
		/// </summary>
		/// <remarks>
		/// DB column: createdateiso
		/// </remarks>
		public const long mbCreateDateIso = 4L;

		protected int lnCreateDateIsoValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 7L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1152087606L;		
	} // end class
}  // end namespace

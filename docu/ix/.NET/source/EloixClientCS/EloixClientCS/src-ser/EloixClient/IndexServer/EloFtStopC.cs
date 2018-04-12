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
	/// <p>Bit constants for members of EloFtStop</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class EloFtStopC : BSerializable
	{
	
		#region Constructors
		
		public EloFtStopC() {
		}		
		
		public EloFtStopC(int @lnStopword) {
			this.lnStopwordValue = @lnStopword;
		}		
		
		public EloFtStopC(EloFtStopC rhs)
		{
			this.lnStopwordValue = rhs.lnStopwordValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: stopword
		/// </summary>
		public int lnStopword
		{
			get
			{
				return lnStopwordValue;
			}
			set
			{
				this.lnStopwordValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: stopword
		/// </summary>
		public const long mbStopword = 1L;

		protected int lnStopwordValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 1L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1842033553L;		
	} // end class
}  // end namespace

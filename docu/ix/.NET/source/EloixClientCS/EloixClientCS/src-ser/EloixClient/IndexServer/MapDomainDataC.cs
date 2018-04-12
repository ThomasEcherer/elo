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
	/// <p>Bit constants for members of MapDomain</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class MapDomainDataC : BSerializable
	{
	
		#region Constructors
		
		public MapDomainDataC() {
		}		
		
		public MapDomainDataC(int @lnName) {
			this.lnNameValue = @lnName;
		}		
		
		public MapDomainDataC(MapDomainDataC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: mapdname
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
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: mapdflags
		/// </summary>
		public const long mbFlags = 1L;

		/// <summary>
		/// DB column: mapdname
		/// </summary>
		public const long mbName = 2L;

		protected int lnNameValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 3L;

		#endregion
		
		
		public static readonly long serialVersionUID = 915355095L;		
	} // end class
}  // end namespace

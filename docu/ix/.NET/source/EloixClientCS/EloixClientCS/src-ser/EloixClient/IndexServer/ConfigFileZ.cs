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
	/// This class encapsulates the constants of ConfigFileC.
	/// </summary>
	public class ConfigFileZ : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ConfigFileZ() {
		}		
		
		public ConfigFileZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public ConfigFileZ(ConfigFileZ rhs) : base(rhs)
		{
			this.bsetValue = rhs.bsetValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Bitset field for constants of the ConfigFileC class.
		/// </summary>
		public long bset
		{
			get
			{
				return bsetValue;
			}
			set
			{
				this.bsetValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected long bsetValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 821574897L;		
	} // end class
}  // end namespace

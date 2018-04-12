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
	/// <p>This class encapsulates the constants of <code>SearchModeC</code></p>
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class SearchModeZ : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public SearchModeZ() {
		}		
		
		public SearchModeZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public SearchModeZ(SearchModeZ rhs) : base(rhs)
		{
			this.bsetValue = rhs.bsetValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Bitset field for constants from SearchModeC class.
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
		
		
		public static readonly new long serialVersionUID = 424689505L;		
	} // end class
}  // end namespace

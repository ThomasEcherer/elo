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
	/// This class encapsulates the constants of the WFNodeC class.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2011</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class WFNodeZ : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WFNodeZ() {
		}		
		
		public WFNodeZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public WFNodeZ(WFNodeZ rhs) : base(rhs)
		{
			this.bsetValue = rhs.bsetValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Bitset field for constants from the WFNodeC class.
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
		
		
		public static readonly new long serialVersionUID = 226200225L;		
	} // end class
}  // end namespace

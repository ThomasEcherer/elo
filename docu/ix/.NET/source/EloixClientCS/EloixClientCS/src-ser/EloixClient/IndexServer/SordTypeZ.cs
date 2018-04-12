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
	/// <p>This class encapsulates the constants of <code>SordTypeC</code></p>
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class SordTypeZ : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public SordTypeZ() {
		}		
		
		public SordTypeZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public SordTypeZ(SordTypeZ rhs) : base(rhs)
		{
			this.bsetValue = rhs.bsetValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Bitset field for constants from SordTypeC class.
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
		
		
		public static readonly new long serialVersionUID = 314474107L;		
	} // end class
}  // end namespace

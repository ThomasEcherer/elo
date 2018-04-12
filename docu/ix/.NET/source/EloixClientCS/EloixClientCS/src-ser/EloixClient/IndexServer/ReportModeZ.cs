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
	/// <p>This class encapsulates the constants of <code>ReportModeC</code></p>
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ReportModeZ : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ReportModeZ() {
		}		
		
		public ReportModeZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public ReportModeZ(ReportModeZ rhs) : base(rhs)
		{
			this.bsetValue = rhs.bsetValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Bitset field for constants from ReportModeC class.
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
		
		
		public static readonly new long serialVersionUID = 1248158950L;		
	} // end class
}  // end namespace

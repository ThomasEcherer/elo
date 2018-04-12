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
	/// Typed element selector for class Activity.
	/// </summary>
	public class ActivityZ : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ActivityZ() {
		}		
		
		public ActivityZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public ActivityZ(ActivityZ rhs) : base(rhs)
		{
			this.bsetValue = rhs.bsetValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Bitset field.
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
		
		
		public static readonly new long serialVersionUID = 730005706L;		
	} // end class
}  // end namespace

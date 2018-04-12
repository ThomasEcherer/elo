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
	/// This class is used in the scripting API of IndexServer and
	/// provides bit operations on 64 bit integers.
	/// </summary>
	/// <remarks>
	/// JavaScript does
	/// not support bit operations for 64 bit integers.
	/// The global context of the JavaScripts executed by IndexServer
	/// contain an object named Bitset which is an instance of
	/// this class.
	/// </remarks>
	public class Bitset : BSerializable
	{
	
		#region Constructors
		
		public Bitset() {
		}		
		
		public Bitset(long @v) {
			this.vValue = @v;
		}		
		
		public Bitset(Bitset rhs)
		{
			this.vValue = rhs.vValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Internal 64 bit integer value
		/// </summary>
		public long v
		{
			get
			{
				return vValue;
			}
			set
			{
				this.vValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected long vValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1084624222L;		
	} // end class
}  // end namespace

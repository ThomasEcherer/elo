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
	/// Member selector for class FileData.
	/// </summary>
	public class FileDataZ : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FileDataZ() {
		}		
		
		public FileDataZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public FileDataZ(FileDataZ rhs) : base(rhs)
		{
			this.bsetValue = rhs.bsetValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Bitset field for constants from the DocMaskC class.
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
		
		
		public static readonly new long serialVersionUID = 686143141L;		
	} // end class
}  // end namespace

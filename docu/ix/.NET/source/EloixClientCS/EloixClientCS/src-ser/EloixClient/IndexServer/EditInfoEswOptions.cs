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
	/// Options for reading or writing of esw-files.
	/// </summary>
	public class EditInfoEswOptions : BSerializable
	{
	
		#region Constructors
		
		public EditInfoEswOptions() {
		}		
		
		public EditInfoEswOptions(int @reserved) {
			this.reservedValue = @reserved;
		}		
		
		public EditInfoEswOptions(EditInfoEswOptions rhs)
		{
			this.reservedValue = rhs.reservedValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Reserved
		/// </summary>
		public int reserved
		{
			get
			{
				return reservedValue;
			}
			set
			{
				this.reservedValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int reservedValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 522299581L;		
	} // end class
}  // end namespace

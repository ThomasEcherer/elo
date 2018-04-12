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
	/// This class represents map values.
	/// </summary>
	/// <remarks>
	/// A map value is either a string, stored in member {@link KeyValue#value} of the super class.
	/// Or a map value is a BLOB available in {@link #blobValue}.
	/// </remarks>
	public class MapValue : EloixClient.IndexServer.KeyValue, BSerializable
	{
	
		#region Constructors
		
		public MapValue() {
		}		
		
		public MapValue(EloixClient.IndexServer.FileData @blobValue) {
			this.blobValueValue = @blobValue;
		}		
		
		public MapValue(MapValue rhs) : base(rhs)
		{
			this.blobValueValue = rhs.blobValueValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// BLOB value.
		/// </summary>
		public EloixClient.IndexServer.FileData blobValue
		{
			get
			{
				return blobValueValue;
			}
			set
			{
				this.blobValueValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.FileData blobValueValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 408347242L;		
	} // end class
}  // end namespace

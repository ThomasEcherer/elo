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
	/// Member constants for class FileData.
	/// </summary>
	public class FileDataC : BSerializable
	{
	
		#region Constructors
		
		public FileDataC() {
		}		
		
		public FileDataC(int @lnContentType) {
			this.lnContentTypeValue = @lnContentType;
		}		
		
		public FileDataC(FileDataC rhs)
		{
			this.lnContentTypeValue = rhs.lnContentTypeValue;
		}		
		
		#endregion
		
		#region Properties
		
		public int lnContentType
		{
			get
			{
				return lnContentTypeValue;
			}
			set
			{
				this.lnContentTypeValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		public const long mbContentType = 1L;

		public const long mbData = 2L;

		public const long mbStream = 4L;

		public readonly static EloixClient.IndexServer.FileDataZ mbDataArray = new FileDataZ(3L);

		public readonly static EloixClient.IndexServer.FileDataZ mbDataStream = new FileDataZ(5L);

		/// <summary>
		/// Maximum length of BLOB fields.
		/// </summary>
		/// <remarks>
		/// This value is set to 1MB.
		/// </remarks>
		public const long MAX_BLOB_LENGTH = 1048576L;

		protected int lnContentTypeValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1011013570L;		
	} // end class
}  // end namespace

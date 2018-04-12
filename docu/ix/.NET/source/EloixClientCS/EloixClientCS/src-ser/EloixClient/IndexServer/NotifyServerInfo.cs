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
	/// This class is used in IXServicePortIF.notifyServer to describe which
	/// operation(s) has (have) been processed by the client application.
	/// </summary>
	public class NotifyServerInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public NotifyServerInfo() {
		}		
		
		public NotifyServerInfo(int @scanCount, int @ocrCount) {
			this.scanCountValue = @scanCount;
			this.ocrCountValue = @ocrCount;
		}		
		
		public NotifyServerInfo(NotifyServerInfo rhs) : base(rhs)
		{
			this.scanCountValue = rhs.scanCountValue;
			this.ocrCountValue = rhs.ocrCountValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The number of scanned documents.
		/// </summary>
		public int scanCount
		{
			get
			{
				return scanCountValue;
			}
			set
			{
				this.scanCountValue = value;
			}
		}
		
		
		/// <summary>
		/// The number of documents for which OCR was processed.
		/// </summary>
		public int ocrCount
		{
			get
			{
				return ocrCountValue;
			}
			set
			{
				this.ocrCountValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int scanCountValue;

		protected int ocrCountValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 539899885L;		
	} // end class
}  // end namespace

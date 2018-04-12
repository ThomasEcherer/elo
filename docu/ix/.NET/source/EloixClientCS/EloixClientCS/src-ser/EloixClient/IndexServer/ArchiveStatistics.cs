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
	/// Characteristic properties of the archive.
	/// </summary>
	public class ArchiveStatistics : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ArchiveStatistics() {
		}		
		
		public ArchiveStatistics(int @maxDocId, int @maxObjId) {
			this.maxDocIdValue = @maxDocId;
			this.maxObjIdValue = @maxObjId;
		}		
		
		public ArchiveStatistics(ArchiveStatistics rhs) : base(rhs)
		{
			this.maxDocIdValue = rhs.maxDocIdValue;
			this.maxObjIdValue = rhs.maxObjIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Last document (version) ID.
		/// </summary>
		public int maxDocId
		{
			get
			{
				return maxDocIdValue;
			}
			set
			{
				this.maxDocIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Last object ID.
		/// </summary>
		public int maxObjId
		{
			get
			{
				return maxObjIdValue;
			}
			set
			{
				this.maxObjIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int maxDocIdValue;

		protected int maxObjIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2056457945L;		
	} // end class
}  // end namespace

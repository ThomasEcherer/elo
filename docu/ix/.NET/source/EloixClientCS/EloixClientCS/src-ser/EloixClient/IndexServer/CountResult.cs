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
	/// Class for the results of one count process.
	/// </summary>
	public class CountResult : BSerializable
	{
	
		#region Constructors
		
		public CountResult() {
		}		
		
		public CountResult(int @docCount, int @structCount, int @docAttachCount, int @docVersionsCount, int @otherAttachVersionsCount, long @docBytesCount, long @otherDocVersBytesCount, long @attBytesCount, long @otherAttVersBytesCount) {
			this.docCountValue = @docCount;
			this.structCountValue = @structCount;
			this.docAttachCountValue = @docAttachCount;
			this.docVersionsCountValue = @docVersionsCount;
			this.otherAttachVersionsCountValue = @otherAttachVersionsCount;
			this.docBytesCountValue = @docBytesCount;
			this.otherDocVersBytesCountValue = @otherDocVersBytesCount;
			this.attBytesCountValue = @attBytesCount;
			this.otherAttVersBytesCountValue = @otherAttVersBytesCount;
		}		
		
		public CountResult(CountResult rhs)
		{
			this.docCountValue = rhs.docCountValue;
			this.structCountValue = rhs.structCountValue;
			this.docAttachCountValue = rhs.docAttachCountValue;
			this.docVersionsCountValue = rhs.docVersionsCountValue;
			this.otherAttachVersionsCountValue = rhs.otherAttachVersionsCountValue;
			this.docBytesCountValue = rhs.docBytesCountValue;
			this.otherDocVersBytesCountValue = rhs.otherDocVersBytesCountValue;
			this.attBytesCountValue = rhs.attBytesCountValue;
			this.otherAttVersBytesCountValue = rhs.otherAttVersBytesCountValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// count of the found documents
		/// </summary>
		public int docCount
		{
			get
			{
				return docCountValue;
			}
			set
			{
				this.docCountValue = value;
			}
		}
		
		
		/// <summary>
		/// count of the found structures
		/// </summary>
		public int structCount
		{
			get
			{
				return structCountValue;
			}
			set
			{
				this.structCountValue = value;
			}
		}
		
		
		/// <summary>
		/// count of the found document attachments
		/// </summary>
		public int docAttachCount
		{
			get
			{
				return docAttachCountValue;
			}
			set
			{
				this.docAttachCountValue = value;
			}
		}
		
		
		/// <summary>
		/// count of the documents in the version history
		/// </summary>
		public int docVersionsCount
		{
			get
			{
				return docVersionsCountValue;
			}
			set
			{
				this.docVersionsCountValue = value;
			}
		}
		
		
		/// <summary>
		/// count of the other attachment versions
		/// </summary>
		public int otherAttachVersionsCount
		{
			get
			{
				return otherAttachVersionsCountValue;
			}
			set
			{
				this.otherAttachVersionsCountValue = value;
			}
		}
		
		
		/// <summary>
		/// count of the bytes of the current document version
		/// </summary>
		public long docBytesCount
		{
			get
			{
				return docBytesCountValue;
			}
			set
			{
				this.docBytesCountValue = value;
			}
		}
		
		
		/// <summary>
		/// count of the bytes of other document versions
		/// </summary>
		public long otherDocVersBytesCount
		{
			get
			{
				return otherDocVersBytesCountValue;
			}
			set
			{
				this.otherDocVersBytesCountValue = value;
			}
		}
		
		
		/// <summary>
		/// count of the bytes of the current attachment version
		/// </summary>
		public long attBytesCount
		{
			get
			{
				return attBytesCountValue;
			}
			set
			{
				this.attBytesCountValue = value;
			}
		}
		
		
		/// <summary>
		/// count of the bytes of other attachment versions
		/// </summary>
		public long otherAttVersBytesCount
		{
			get
			{
				return otherAttVersBytesCountValue;
			}
			set
			{
				this.otherAttVersBytesCountValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int docCountValue;

		protected int structCountValue;

		protected int docAttachCountValue;

		protected int docVersionsCountValue;

		protected int otherAttachVersionsCountValue;

		protected long docBytesCountValue;

		protected long otherDocVersBytesCountValue;

		protected long attBytesCountValue;

		protected long otherAttVersBytesCountValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1581335066L;		
	} // end class
}  // end namespace

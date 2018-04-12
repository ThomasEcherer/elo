//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class SystemReport : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public SystemReport() {
		}		
		
		public SystemReport(long @doccount, long @docsize, long @ftsize, long @previewsize) {
			this.doccountValue = @doccount;
			this.docsizeValue = @docsize;
			this.ftsizeValue = @ftsize;
			this.previewsizeValue = @previewsize;
		}		
		
		public SystemReport(SystemReport rhs) : base(rhs)
		{
			this.doccountValue = rhs.doccountValue;
			this.docsizeValue = rhs.docsizeValue;
			this.ftsizeValue = rhs.ftsizeValue;
			this.previewsizeValue = rhs.previewsizeValue;
		}		
		
		#endregion
		
		#region Properties
		
		public long doccount
		{
			get
			{
				return doccountValue;
			}
			set
			{
				this.doccountValue = value;
			}
		}
		
		
		public long docsize
		{
			get
			{
				return docsizeValue;
			}
			set
			{
				this.docsizeValue = value;
			}
		}
		
		
		public long ftsize
		{
			get
			{
				return ftsizeValue;
			}
			set
			{
				this.ftsizeValue = value;
			}
		}
		
		
		public long previewsize
		{
			get
			{
				return previewsizeValue;
			}
			set
			{
				this.previewsizeValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected long doccountValue;

		protected long docsizeValue;

		protected long ftsizeValue;

		protected long previewsizeValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 276702696L;		
	} // end class
}  // end namespace

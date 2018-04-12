//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace de.elo.ix.client.search
{
	
	/// <summary>
	/// Configuration and status of Re-indexer process.
	/// </summary>
	public class ReindexerConfig : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ReindexerConfig() {
		}		
		
		public ReindexerConfig(SearchIndexerStatus @status, DateTime @startedAt, int @progressInPercent, String @ixid, String @lastException, String @objIdRange, String @lockName) {
			this.statusValue = @status;
			this.startedAtValue = @startedAt;
			this.progressInPercentValue = @progressInPercent;
			this.ixidValue = @ixid;
			this.lastExceptionValue = @lastException;
			this.objIdRangeValue = @objIdRange;
			this.lockNameValue = @lockName;
		}		
		
		public ReindexerConfig(ReindexerConfig rhs) : base(rhs)
		{
			this.statusValue = rhs.statusValue;
			this.startedAtValue = rhs.startedAtValue;
			this.progressInPercentValue = rhs.progressInPercentValue;
			this.ixidValue = rhs.ixidValue;
			this.lastExceptionValue = rhs.lastExceptionValue;
			this.objIdRangeValue = rhs.objIdRangeValue;
			this.lockNameValue = rhs.lockNameValue;
		}		
		
		#endregion
		
		#region Properties
		
		public SearchIndexerStatus status
		{
			get
			{
				return statusValue;
			}
			set
			{
				this.statusValue = value;
			}
		}
		
		
		public DateTime startedAt
		{
			get
			{
				return startedAtValue;
			}
			set
			{
				this.startedAtValue = value;
			}
		}
		
		
		public int progressInPercent
		{
			get
			{
				return progressInPercentValue;
			}
			set
			{
				this.progressInPercentValue = value;
			}
		}
		
		
		/// <summary>
		/// This Indexserver instance is processing the update.
		/// </summary>
		public String ixid
		{
			get
			{
				return ixidValue;
			}
			set
			{
				this.ixidValue = value;
			}
		}
		
		
		/// <summary>
		/// Last exception occured during processing.
		/// </summary>
		public String lastException
		{
			get
			{
				return lastExceptionValue;
			}
			set
			{
				this.lastExceptionValue = value;
			}
		}
		
		
		/// <summary>
		/// Lower and upper limit of object IDs processed by re-indexing process.
		/// </summary>
		public String objIdRange
		{
			get
			{
				return objIdRangeValue;
			}
			set
			{
				this.objIdRangeValue = value;
			}
		}
		
		
		/// <summary>
		/// Process runs under this user account.
		/// </summary>
		public String lockName
		{
			get
			{
				return lockNameValue;
			}
			set
			{
				this.lockNameValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected SearchIndexerStatus statusValue;

		protected DateTime startedAtValue;

		protected int progressInPercentValue;

		protected String ixidValue;

		protected String lastExceptionValue;

		protected String objIdRangeValue;

		protected String lockNameValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1470978622L;		
	} // end class
}  // end namespace

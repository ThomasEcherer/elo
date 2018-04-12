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
	/// Configuration and status of updater process.
	/// </summary>
	public class UpdaterConfig : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public UpdaterConfig() {
		}		
		
		public UpdaterConfig(SearchIndexerStatus @status, DateTime @nextRunAt, int @intervalMinutes, DateTime @updateNewerThan, int @progressInPercent, String @ixid, String @lastException, String @lockName) {
			this.statusValue = @status;
			this.nextRunAtValue = @nextRunAt;
			this.intervalMinutesValue = @intervalMinutes;
			this.updateNewerThanValue = @updateNewerThan;
			this.progressInPercentValue = @progressInPercent;
			this.ixidValue = @ixid;
			this.lastExceptionValue = @lastException;
			this.lockNameValue = @lockName;
		}		
		
		public UpdaterConfig(UpdaterConfig rhs) : base(rhs)
		{
			this.statusValue = rhs.statusValue;
			this.nextRunAtValue = rhs.nextRunAtValue;
			this.intervalMinutesValue = rhs.intervalMinutesValue;
			this.updateNewerThanValue = rhs.updateNewerThanValue;
			this.progressInPercentValue = rhs.progressInPercentValue;
			this.ixidValue = rhs.ixidValue;
			this.lastExceptionValue = rhs.lastExceptionValue;
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
		
		
		public DateTime nextRunAt
		{
			get
			{
				return nextRunAtValue;
			}
			set
			{
				this.nextRunAtValue = value;
			}
		}
		
		
		public int intervalMinutes
		{
			get
			{
				return intervalMinutesValue;
			}
			set
			{
				this.intervalMinutesValue = value;
			}
		}
		
		
		public DateTime updateNewerThan
		{
			get
			{
				return updateNewerThanValue;
			}
			set
			{
				this.updateNewerThanValue = value;
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

		protected DateTime nextRunAtValue;

		protected int intervalMinutesValue;

		protected DateTime updateNewerThanValue;

		protected int progressInPercentValue;

		protected String ixidValue;

		protected String lastExceptionValue;

		protected String lockNameValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1275243126L;		
	} // end class
}  // end namespace

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
	/// Configuration and status of optimizer process.
	/// </summary>
	public class OptimizerConfig : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public OptimizerConfig() {
		}		
		
		public OptimizerConfig(SearchIndexerStatus @status, DateTime @nextRunAt, int @intervalHours, String @ixid, String @lastException, String @lockName) {
			this.statusValue = @status;
			this.nextRunAtValue = @nextRunAt;
			this.intervalHoursValue = @intervalHours;
			this.ixidValue = @ixid;
			this.lastExceptionValue = @lastException;
			this.lockNameValue = @lockName;
		}		
		
		public OptimizerConfig(OptimizerConfig rhs) : base(rhs)
		{
			this.statusValue = rhs.statusValue;
			this.nextRunAtValue = rhs.nextRunAtValue;
			this.intervalHoursValue = rhs.intervalHoursValue;
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
		
		
		public int intervalHours
		{
			get
			{
				return intervalHoursValue;
			}
			set
			{
				this.intervalHoursValue = value;
			}
		}
		
		
		/// <summary>
		/// This Indexserver instance is processing the optimization.
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

		protected int intervalHoursValue;

		protected String ixidValue;

		protected String lastExceptionValue;

		protected String lockNameValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 645566676L;		
	} // end class
}  // end namespace

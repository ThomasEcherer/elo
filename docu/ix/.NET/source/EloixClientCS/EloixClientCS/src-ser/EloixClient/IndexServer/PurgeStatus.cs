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
	/// This class represents the status of the ELOdm purge task
	/// </summary>
	public class PurgeStatus : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public PurgeStatus() {
		}		
		
		public PurgeStatus(bool @isRunning, int @numberOfDocsPurged, String @lastPurgeTime, String @errorMessage) {
			this.isRunningValue = @isRunning;
			this.numberOfDocsPurgedValue = @numberOfDocsPurged;
			this.lastPurgeTimeValue = @lastPurgeTime;
			this.errorMessageValue = @errorMessage;
		}		
		
		public PurgeStatus(PurgeStatus rhs) : base(rhs)
		{
			this.isRunningValue = rhs.isRunningValue;
			this.numberOfDocsPurgedValue = rhs.numberOfDocsPurgedValue;
			this.lastPurgeTimeValue = rhs.lastPurgeTimeValue;
			this.errorMessageValue = rhs.errorMessageValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// if the ELOdm purge task is running (it can only run in combination with the
		/// backup task)
		/// </summary>
		public bool isRunning
		{
			get
			{
				return isRunningValue;
			}
			set
			{
				this.isRunningValue = value;
			}
		}
		
		
		/// <summary>
		/// number of purged documents
		/// </summary>
		public int numberOfDocsPurged
		{
			get
			{
				return numberOfDocsPurgedValue;
			}
			set
			{
				this.numberOfDocsPurgedValue = value;
			}
		}
		
		
		/// <summary>
		/// last purge work time (ISO UTC date and time without dots)
		/// If no purge has been done yet, the variable is empty.
		/// </summary>
		public String lastPurgeTime
		{
			get
			{
				return lastPurgeTimeValue;
			}
			set
			{
				this.lastPurgeTimeValue = value;
			}
		}
		
		
		/// <summary>
		/// an error message, if an error occured, else an empty String
		/// </summary>
		public String errorMessage
		{
			get
			{
				return errorMessageValue;
			}
			set
			{
				this.errorMessageValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool isRunningValue;

		protected int numberOfDocsPurgedValue;

		protected String lastPurgeTimeValue;

		protected String errorMessageValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2053888643L;		
	} // end class
}  // end namespace

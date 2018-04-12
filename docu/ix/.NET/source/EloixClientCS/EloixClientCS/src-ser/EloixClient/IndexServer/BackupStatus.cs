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
	/// This class represents the status of the ELOdm backup task
	/// </summary>
	public class BackupStatus : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public BackupStatus() {
		}		
		
		public BackupStatus(bool @isRunning, int @numberOfDocsCopied, int @secondsUntilNextCheck, String @errorMessage) {
			this.isRunningValue = @isRunning;
			this.numberOfDocsCopiedValue = @numberOfDocsCopied;
			this.secondsUntilNextCheckValue = @secondsUntilNextCheck;
			this.errorMessageValue = @errorMessage;
		}		
		
		public BackupStatus(BackupStatus rhs) : base(rhs)
		{
			this.isRunningValue = rhs.isRunningValue;
			this.numberOfDocsCopiedValue = rhs.numberOfDocsCopiedValue;
			this.secondsUntilNextCheckValue = rhs.secondsUntilNextCheckValue;
			this.errorMessageValue = rhs.errorMessageValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// if the ELOdm backup task is running (the purge task can only run in
		/// combination with the backup task)
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
		/// number of copied documents since start of the backup task
		/// </summary>
		public int numberOfDocsCopied
		{
			get
			{
				return numberOfDocsCopiedValue;
			}
			set
			{
				this.numberOfDocsCopiedValue = value;
			}
		}
		
		
		/// <summary>
		/// waiting time in seconds until the next proccessing
		/// (when the backup profiles are traversed)
		/// </summary>
		public int secondsUntilNextCheck
		{
			get
			{
				return secondsUntilNextCheckValue;
			}
			set
			{
				this.secondsUntilNextCheckValue = value;
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

		protected int numberOfDocsCopiedValue;

		protected int secondsUntilNextCheckValue;

		protected String errorMessageValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1288074907L;		
	} // end class
}  // end namespace

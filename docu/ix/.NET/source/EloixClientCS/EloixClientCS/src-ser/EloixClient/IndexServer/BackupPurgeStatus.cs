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
	/// This class represents the status of the ELOdm backup and purge tasks
	/// </summary>
	public class BackupPurgeStatus : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public BackupPurgeStatus() {
		}		
		
		public BackupPurgeStatus(EloixClient.IndexServer.BackupStatus @backupStatus, EloixClient.IndexServer.PurgeStatus @purgeStatus) {
			this.backupStatusValue = @backupStatus;
			this.purgeStatusValue = @purgeStatus;
		}		
		
		public BackupPurgeStatus(BackupPurgeStatus rhs) : base(rhs)
		{
			this.backupStatusValue = rhs.backupStatusValue;
			this.purgeStatusValue = rhs.purgeStatusValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Status of the ELOdm backup task
		/// </summary>
		public EloixClient.IndexServer.BackupStatus backupStatus
		{
			get
			{
				return backupStatusValue;
			}
			set
			{
				this.backupStatusValue = value;
			}
		}
		
		
		/// <summary>
		/// Status of the ELOdm purge task
		/// </summary>
		public EloixClient.IndexServer.PurgeStatus purgeStatus
		{
			get
			{
				return purgeStatusValue;
			}
			set
			{
				this.purgeStatusValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.BackupStatus backupStatusValue;

		protected EloixClient.IndexServer.PurgeStatus purgeStatusValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 52201250L;		
	} // end class
}  // end namespace

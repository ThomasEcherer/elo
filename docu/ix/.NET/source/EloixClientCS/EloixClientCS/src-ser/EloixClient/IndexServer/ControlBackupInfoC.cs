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
	/// Constants for class ControlBackupInfo
	/// (mode for the ELOdm backup and purge tasks)
	/// </summary>
	public class ControlBackupInfoC : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ControlBackupInfoC() {
		}		
		
		public ControlBackupInfoC(ControlBackupInfoC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Query the status of the backup and purge tasks
		/// </summary>
		public const int MODE_STATUS = 0;

		/// <summary>
		/// Start the backup task (if it is already running, nothing happens).
		/// </summary>
		/// <remarks>
		/// If the purge task is already running, it is stopped.
		/// </remarks>
		public const int MODE_START_BACKUP = 1;

		/// <summary>
		/// Start the backup and the purge task.
		/// </summary>
		/// <remarks>
		/// If the backup task is already running, only the purge task is started.
		/// </remarks>
		public const int MODE_START_BACKUP_PURGE = 2;

		/// <summary>
		/// Stop the backup and purge tasks
		/// </summary>
		public const int MODE_STOP = 3;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1165618755L;		
	} // end class
}  // end namespace

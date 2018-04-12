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
	/// Mode for the ELOdm backup and purge tasks
	/// </summary>
	public class ControlBackupInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ControlBackupInfo() {
		}		
		
		public ControlBackupInfo(int @mode) {
			this.modeValue = @mode;
		}		
		
		public ControlBackupInfo(ControlBackupInfo rhs) : base(rhs)
		{
			this.modeValue = rhs.modeValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Start, stop and status of the ELOdm backup and purge tasks
		/// (constants in ControlBackupInfoC)
		/// </summary>
		public int mode
		{
			get
			{
				return modeValue;
			}
			set
			{
				this.modeValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int modeValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1738666671L;		
	} // end class
}  // end namespace

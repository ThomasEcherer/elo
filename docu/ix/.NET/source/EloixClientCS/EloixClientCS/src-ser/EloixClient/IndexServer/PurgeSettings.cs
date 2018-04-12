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
	/// This class represents the purge settings of the ELOdm purge task
	/// </summary>
	public class PurgeSettings : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public PurgeSettings() {
		}		
		
		public PurgeSettings(int @dayLimit, int @pathId, int @fileCheckMode, int @startHour, IList<int> @excludePathIds) {
			this.dayLimitValue = @dayLimit;
			this.pathIdValue = @pathId;
			this.fileCheckModeValue = @fileCheckMode;
			this.startHourValue = @startHour;
			this.excludePathIdsValue = @excludePathIds;
		}		
		
		public PurgeSettings(PurgeSettings rhs) : base(rhs)
		{
			this.dayLimitValue = rhs.dayLimitValue;
			this.pathIdValue = rhs.pathIdValue;
			this.fileCheckModeValue = rhs.fileCheckModeValue;
			this.startHourValue = rhs.startHourValue;
			this.excludePathIdsValue = rhs.excludePathIdsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Original documents older than the specified number of days are deleted
		/// (0 or higher), e.g. 0 for no limit, 1 for 24 hours, 365 for a year
		/// </summary>
		public int dayLimit
		{
			get
			{
				return dayLimitValue;
			}
			set
			{
				this.dayLimitValue = value;
			}
		}
		
		
		/// <summary>
		/// Possible path restriction for filing paths: <br>
		/// 0: include all paths <br>
		/// 1 and higher: only include a path with this ID where documents should be
		/// deleted
		/// </summary>
		public int pathId
		{
			get
			{
				return pathIdValue;
			}
			set
			{
				this.pathIdValue = value;
			}
		}
		
		
		/// <summary>
		/// The original and the backup document can be compared before cleanup.
		/// </summary>
		/// <remarks>
		/// Possible values (1 to 3) are defined in PurgeSettingsC.
		/// </remarks>
		public int fileCheckMode
		{
			get
			{
				return fileCheckModeValue;
			}
			set
			{
				this.fileCheckModeValue = value;
			}
		}
		
		
		/// <summary>
		/// When processing should take place: <br>
		/// START_EVERY_HOUR: when the purge task is starting and then every 60 minutes <br>
		/// 0 to 23: hour of the day, such as 8:00 p.m.
		/// </summary>
		public int startHour
		{
			get
			{
				return startHourValue;
			}
			set
			{
				this.startHourValue = value;
			}
		}
		
		
		/// <summary>
		/// List of path ids to exclude from purging if pathId=0 is set.
		/// </summary>
		public IList<int> excludePathIds
		{
			get
			{
				return excludePathIdsValue;
			}
			set
			{
				this.excludePathIdsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int dayLimitValue;

		protected int pathIdValue;

		protected int fileCheckModeValue;

		protected int startHourValue;

		protected IList<int> excludePathIdsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1576340510L;		
	} // end class
}  // end namespace

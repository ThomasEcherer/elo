//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class SystemInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public SystemInfo() {
		}		
		
		public SystemInfo(int @storePathID, long @startDate, long @endDate, long @userReportMode) {
			this.storePathIDValue = @storePathID;
			this.startDateValue = @startDate;
			this.endDateValue = @endDate;
			this.userReportModeValue = @userReportMode;
		}		
		
		public SystemInfo(SystemInfo rhs) : base(rhs)
		{
			this.storePathIDValue = rhs.storePathIDValue;
			this.startDateValue = rhs.startDateValue;
			this.endDateValue = rhs.endDateValue;
			this.userReportModeValue = rhs.userReportModeValue;
		}		
		
		#endregion
		
		#region Properties
		
		public int storePathID
		{
			get
			{
				return storePathIDValue;
			}
			set
			{
				this.storePathIDValue = value;
			}
		}
		
		
		public long startDate
		{
			get
			{
				return startDateValue;
			}
			set
			{
				this.startDateValue = value;
			}
		}
		
		
		public long endDate
		{
			get
			{
				return endDateValue;
			}
			set
			{
				this.endDateValue = value;
			}
		}
		
		
		public long userReportMode
		{
			get
			{
				return userReportModeValue;
			}
			set
			{
				this.userReportModeValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int storePathIDValue;

		protected long startDateValue;

		protected long endDateValue;

		protected long userReportModeValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2061316528L;		
	} // end class
}  // end namespace

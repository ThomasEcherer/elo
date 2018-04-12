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
	/// Objects of this class specify the selection criteria for report entries in
	/// <code>findReport</code>.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH </p>
	/// </remarks>
	public class FindReportInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindReportInfo() {
		}		
		
		public FindReportInfo(String @endDateIso, int[] @erpCodes, String @objId, String @orderBy, String @searchId, String @startDateIso, int @timeoutSeconds, int @totalCount, String @userId, bool @findLastEntryBeforeEndDate, String @extra1) {
			this.endDateIsoValue = @endDateIso;
			this.erpCodesValue = @erpCodes;
			this.objIdValue = @objId;
			this.orderByValue = @orderBy;
			this.searchIdValue = @searchId;
			this.startDateIsoValue = @startDateIso;
			this.timeoutSecondsValue = @timeoutSeconds;
			this.totalCountValue = @totalCount;
			this.userIdValue = @userId;
			this.findLastEntryBeforeEndDateValue = @findLastEntryBeforeEndDate;
			this.extra1Value = @extra1;
		}		
		
		public FindReportInfo(FindReportInfo rhs) : base(rhs)
		{
			this.endDateIsoValue = rhs.endDateIsoValue;
			this.erpCodesValue = rhs.erpCodesValue;
			this.objIdValue = rhs.objIdValue;
			this.orderByValue = rhs.orderByValue;
			this.searchIdValue = rhs.searchIdValue;
			this.startDateIsoValue = rhs.startDateIsoValue;
			this.timeoutSecondsValue = rhs.timeoutSecondsValue;
			this.totalCountValue = rhs.totalCountValue;
			this.userIdValue = rhs.userIdValue;
			this.findLastEntryBeforeEndDateValue = rhs.findLastEntryBeforeEndDateValue;
			this.extra1Value = rhs.extra1Value;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// End date (UTC)
		/// </summary>
		public String endDateIso
		{
			get
			{
				return endDateIsoValue;
			}
			set
			{
				this.endDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Constrained to this ERP codes.
		/// </summary>
		public int[] erpCodes
		{
			get
			{
				return erpCodesValue;
			}
			set
			{
				this.erpCodesValue = value;
			}
		}
		
		
		/// <summary>
		/// Object ID or GUID
		/// </summary>
		public String objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Can contain an SQL ORDER BY clause.
		/// </summary>
		public String orderBy
		{
			get
			{
				return orderByValue;
			}
			set
			{
				this.orderByValue = value;
			}
		}
		
		
		/// <summary>
		/// reserved.
		/// </summary>
		public String searchId
		{
			get
			{
				return searchIdValue;
			}
			set
			{
				this.searchIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Start date (UTC)
		/// </summary>
		public String startDateIso
		{
			get
			{
				return startDateIsoValue;
			}
			set
			{
				this.startDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Specifies the time limit for the search.
		/// </summary>
		/// <remarks>
		/// If the limit is exceeded, the search
		/// is interruped. <code>timeoutSeconds=0</code> means that the search has no time limit.
		/// </remarks>
		public int timeoutSeconds
		{
			get
			{
				return timeoutSecondsValue;
			}
			set
			{
				this.timeoutSecondsValue = value;
			}
		}
		
		
		/// <summary>
		/// The search is ended once this number of objects have been found.
		/// </summary>
		/// <remarks>
		/// A value of <code>0</code> sets no constraint to the number of objects.
		/// </remarks>
		public int totalCount
		{
			get
			{
				return totalCountValue;
			}
			set
			{
				this.totalCountValue = value;
			}
		}
		
		
		/// <summary>
		/// User ID or name.
		/// </summary>
		public String userId
		{
			get
			{
				return userIdValue;
			}
			set
			{
				this.userIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Find the last entry before the given {@link #endDateIso}.
		/// </summary>
		/// <remarks>
		/// This option e.g. allows to find the user permissions at the given {@link #endDateIso}.
		/// Therefore, set <code>erpCodes = new int[] { ReportOptionsC.ERP_LOGOPENARC, ReportOptionsC.ERP_LOGUSERDATA };</code>.
		/// </remarks>
		public bool findLastEntryBeforeEndDate
		{
			get
			{
				return findLastEntryBeforeEndDateValue;
			}
			set
			{
				this.findLastEntryBeforeEndDateValue = value;
			}
		}
		
		
		/// <summary>
		/// Specifies the extra1 value.
		/// </summary>
		/// <remarks>
		/// Only Integer values are allowed for this element.
		/// </remarks>
		public String extra1
		{
			get
			{
				return extra1Value;
			}
			set
			{
				this.extra1Value = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String endDateIsoValue;

		protected int[] erpCodesValue;

		protected String objIdValue;

		protected String orderByValue;

		protected String searchIdValue;

		protected String startDateIsoValue;

		protected int timeoutSecondsValue;

		protected int totalCountValue;

		protected String userIdValue;

		protected bool findLastEntryBeforeEndDateValue;

		protected String extra1Value;

		#endregion
		
		
		public static readonly new long serialVersionUID = 504724737L;		
	} // end class
}  // end namespace

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
	/// This class contains several options to control the search process of
	/// findFirstSords.
	/// </summary>
	public class FindOptions : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindOptions() {
		}		
		
		public FindOptions(String @escapeChar, bool @inclDeleted, String[] @objIds, String @orderBy, String @rangeDelimiter, EloixClient.IndexServer.ReplSet @replSet, long @reserved, String @searchId, EloixClient.IndexServer.SearchModeZ @searchMode, int @sortOrder, int @timeoutSeconds, int @totalCount, bool @evalCount, bool @onlyDeleted, String @TStamp, String @wildcards, EloixClient.IndexServer.LockZ @lockZ, int @searchLifetimeSeconds, bool @excludeSummary) {
			this.escapeCharValue = @escapeChar;
			this.inclDeletedValue = @inclDeleted;
			this.objIdsValue = @objIds;
			this.orderByValue = @orderBy;
			this.rangeDelimiterValue = @rangeDelimiter;
			this.replSetValue = @replSet;
			this.reservedValue = @reserved;
			this.searchIdValue = @searchId;
			this.searchModeValue = @searchMode;
			this.sortOrderValue = @sortOrder;
			this.timeoutSecondsValue = @timeoutSeconds;
			this.totalCountValue = @totalCount;
			this.evalCountValue = @evalCount;
			this.onlyDeletedValue = @onlyDeleted;
			this.TStampValue = @TStamp;
			this.wildcardsValue = @wildcards;
			this.lockZValue = @lockZ;
			this.searchLifetimeSecondsValue = @searchLifetimeSeconds;
			this.excludeSummaryValue = @excludeSummary;
		}		
		
		public FindOptions(FindOptions rhs) : base(rhs)
		{
			this.escapeCharValue = rhs.escapeCharValue;
			this.inclDeletedValue = rhs.inclDeletedValue;
			this.objIdsValue = rhs.objIdsValue;
			this.orderByValue = rhs.orderByValue;
			this.rangeDelimiterValue = rhs.rangeDelimiterValue;
			this.replSetValue = rhs.replSetValue;
			this.reservedValue = rhs.reservedValue;
			this.searchIdValue = rhs.searchIdValue;
			this.searchModeValue = rhs.searchModeValue;
			this.sortOrderValue = rhs.sortOrderValue;
			this.timeoutSecondsValue = rhs.timeoutSecondsValue;
			this.totalCountValue = rhs.totalCountValue;
			this.evalCountValue = rhs.evalCountValue;
			this.onlyDeletedValue = rhs.onlyDeletedValue;
			this.TStampValue = rhs.TStampValue;
			this.wildcardsValue = rhs.wildcardsValue;
			this.lockZValue = rhs.lockZValue;
			this.searchLifetimeSecondsValue = rhs.searchLifetimeSecondsValue;
			this.excludeSummaryValue = rhs.excludeSummaryValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// SQL escape character.
		/// </summary>
		/// <remarks>
		/// Overwrites the character that can be specified
		/// by setSessionOptions.
		/// </remarks>
		public String escapeChar
		{
			get
			{
				return escapeCharValue;
			}
			set
			{
				this.escapeCharValue = value;
			}
		}
		
		
		/// <summary>
		/// Include logically deleted objects.
		/// </summary>
		public bool inclDeleted
		{
			get
			{
				return inclDeletedValue;
			}
			set
			{
				this.inclDeletedValue = value;
			}
		}
		
		
		/// <summary>
		/// Restricts the results to objects with these IDs or GUIDs.
		/// </summary>
		public String[] objIds
		{
			get
			{
				return objIdsValue;
			}
			set
			{
				this.objIdsValue = value;
			}
		}
		
		
		/// <summary>
		/// An SQL ORDER BY clause can be provided here, if required.
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
		/// Range values can be used to search many index and date attribute values.
		/// </summary>
		/// <remarks>
		/// The delimiter between the lower limit and upper limit value is defined
		/// by rangeDelimiter. The default rangeDelimiter is "...".
		/// </remarks>
		public String rangeDelimiter
		{
			get
			{
				return rangeDelimiterValue;
			}
			set
			{
				this.rangeDelimiterValue = value;
			}
		}
		
		
		/// <summary>
		/// Results are returned only for objects that reside in this replication set.
		/// </summary>
		public EloixClient.IndexServer.ReplSet replSet
		{
			get
			{
				return replSetValue;
			}
			set
			{
				this.replSetValue = value;
			}
		}
		
		
		/// <summary>
		/// This value is reserved for internal testing purposes and must be set
		/// to 0  in all cases.
		/// </summary>
		public long reserved
		{
			get
			{
				return reservedValue;
			}
			set
			{
				this.reservedValue = value;
			}
		}
		
		
		/// <summary>
		/// Restricts the results to objects returned by a previous search.
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
		/// The searchMode describes how search terms are concatinated with the
		/// boolean operators AND or OR.
		/// </summary>
		public EloixClient.IndexServer.SearchModeZ searchMode
		{
			get
			{
				return searchModeValue;
			}
			set
			{
				this.searchModeValue = value;
			}
		}
		
		
		/// <summary>
		/// Defines the sort order of the results.
		/// </summary>
		/// <remarks>
		/// If sortOrder is 0 and the search process searches for child objects
		/// (FindInfo.findChildren!=null), the objects are sorted by the sort flags
		/// of the parent.
		/// If sortOrder is 0 and the search uses FindInfo.findByIndex, the
		/// objects are sorted alphabetically.
		/// </remarks>
		public int sortOrder
		{
			get
			{
				return sortOrderValue;
			}
			set
			{
				this.sortOrderValue = value;
			}
		}
		
		
		/// <summary>
		/// Specifies the time limit for the search.
		/// </summary>
		/// <remarks>
		/// If the limit is exceeded, the
		/// search is interruped. If the search is not to have a time limit
		/// timeoutSeconds=0 must be used.
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
		/// The search is terminated if this number of objects are found.
		/// </summary>
		/// <remarks>
		/// If the number of results should not be constrained, set this value to
		/// 2^32-1 = 2147483647 (maximum value of a positive 32bit integer minus 1).
		/// If totalCount is not set, the IndexServer option totalCount is used,
		/// which is 10000 by default.
		/// If this value is set to 1, findFirstSords will not generate a report entry
		/// {@link ReportInfoC#ACT_CLIENT_SEARCH}.
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
		/// Compute the number of results.
		/// </summary>
		/// <remarks>
		/// The number of results are returned in FindResult.count.
		/// Be aware of the fact that
		/// this option needs to read all database result rows and check user access
		/// before findFirstSords returns.
		/// </remarks>
		public bool evalCount
		{
			get
			{
				return evalCountValue;
			}
			set
			{
				this.evalCountValue = value;
			}
		}
		
		
		/// <summary>
		/// Only logically deleted objects.
		/// </summary>
		/// <remarks>
		/// If this member is true, inclDeleted is ignored.
		/// </remarks>
		public bool onlyDeleted
		{
			get
			{
				return onlyDeletedValue;
			}
			set
			{
				this.onlyDeletedValue = value;
			}
		}
		
		
		/// <summary>
		/// Return objects that were last modified at this time or in this time range.
		/// </summary>
		/// <remarks>
		/// The time stamp is an ISO formatted value in the UTC timezone. It might include dots
		/// to separate the date and time elements. A time range is separated by the <code>rangeDelimiter</code>.
		/// The selection includes the range limits.
		/// Because the FindOptions cannot be the only criteria in FindInfo, use FindByIndex.name="*" to
		/// select over the entire archive.
		/// </remarks>
		public String TStamp
		{
			get
			{
				return TStampValue;
			}
			set
			{
				this.TStampValue = value;
			}
		}
		
		
		/// <summary>
		/// This characters are used as wildcards in search terms.
		/// </summary>
		/// <remarks>
		/// The first wildcard is used for zero or more characters.
		/// The second wildcard is used for exactly one character.
		/// By default (if this member is null or empty), only the first wildcard is defined: *.
		/// </remarks>
		public String wildcards
		{
			get
			{
				return wildcardsValue;
			}
			set
			{
				this.wildcardsValue = value;
			}
		}
		
		
		/// <summary>
		/// Lock all result Sords.
		/// </summary>
		/// <remarks>
		/// If at least one of the sords cannot be locked, an exception is thrown from findFirstSords.
		/// Be aware of the fact that
		/// this option needs to read all database result rows and check user access.
		/// The objects are unlocked by a call to findClose.
		/// </remarks>
		public EloixClient.IndexServer.LockZ lockZ
		{
			get
			{
				return lockZValue;
			}
			set
			{
				this.lockZValue = value;
			}
		}
		
		
		/// <summary>
		/// Lifetime of cached search results.
		/// </summary>
		/// <remarks>
		/// This value overrides the ELOix configuration option searchLifetimeSeconds.
		/// The value determines the time in seconds, how long the search results are cached.
		/// As long the results are valid, they can be read by findNext-functions of the API.
		/// </remarks>
		public int searchLifetimeSeconds
		{
			get
			{
				return searchLifetimeSecondsValue;
			}
			set
			{
				this.searchLifetimeSecondsValue = value;
			}
		}
		
		
		/// <summary>
		/// Do not generate summary information.
		/// </summary>
		/// <remarks>
		/// Retrieving summaries is very expensive for the iSearch module.
		/// </remarks>
		public bool excludeSummary
		{
			get
			{
				return excludeSummaryValue;
			}
			set
			{
				this.excludeSummaryValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String escapeCharValue;

		protected bool inclDeletedValue;

		protected String[] objIdsValue;

		protected String orderByValue;

		protected String rangeDelimiterValue;

		protected EloixClient.IndexServer.ReplSet replSetValue;

		protected long reservedValue;

		protected String searchIdValue;

		protected EloixClient.IndexServer.SearchModeZ searchModeValue;

		protected int sortOrderValue;

		protected int timeoutSecondsValue;

		protected int totalCountValue;

		protected bool evalCountValue;

		protected bool onlyDeletedValue;

		protected String TStampValue;

		protected String wildcardsValue;

		protected EloixClient.IndexServer.LockZ lockZValue;

		protected int searchLifetimeSecondsValue;

		protected bool excludeSummaryValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1371440255L;		
	} // end class
}  // end namespace

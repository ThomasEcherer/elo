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
	/// This class contains the parameters for the interface function
	/// {@link IXServicePortIF#queryJobProtocol(ClientInfo, QueryJobProtocolInfo)}.
	/// </summary>
	public class QueryJobProtocolInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public QueryJobProtocolInfo() {
		}		
		
		public QueryJobProtocolInfo(String @jobGuid, String @startDateISO, int @startEventId, int @level) {
			this.jobGuidValue = @jobGuid;
			this.startDateISOValue = @startDateISO;
			this.startEventIdValue = @startEventId;
			this.levelValue = @level;
		}		
		
		public QueryJobProtocolInfo(QueryJobProtocolInfo rhs) : base(rhs)
		{
			this.jobGuidValue = rhs.jobGuidValue;
			this.startDateISOValue = rhs.startDateISOValue;
			this.startEventIdValue = rhs.startEventIdValue;
			this.levelValue = rhs.levelValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The GUID of the background thread to query the log informations.
		/// </summary>
		/// <remarks>
		/// Mandatory.
		/// </remarks>
		public String jobGuid
		{
			get
			{
				return jobGuidValue;
			}
			set
			{
				this.jobGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Marks the earliest date at which log information has to be reported.
		/// </summary>
		/// <remarks>
		/// As
		/// only cached values are returned, the value is ignored, if the oldest cached
		/// log information is younger that that date. Optional.
		/// </remarks>
		public String startDateISO
		{
			get
			{
				return startDateISOValue;
			}
			set
			{
				this.startDateISOValue = value;
			}
		}
		
		
		/// <summary>
		/// If the value of startEventId is &ge;0, only eventIds &ge; that value will
		/// be returned.
		/// </summary>
		/// <remarks>
		/// Optional.
		/// </remarks>
		public int startEventId
		{
			get
			{
				return startEventIdValue;
			}
			set
			{
				this.startEventIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Filter for the level of log messages.
		/// </summary>
		/// <remarks>
		/// If set, it has to be one of
		/// {@link QueryJobProtocolC#LOG_LEVEL_ERROR},
		/// {@link QueryJobProtocolC#LOG_LEVEL_WARN}, or
		/// {@link QueryJobProtocolC#LOG_LEVEL_INFO}. Multiple values can be set via
		/// the bit operation "|". If not set, only messages of LOG_LEVEL_ERROR are
		/// returned.
		/// </remarks>
		public int level
		{
			get
			{
				return levelValue;
			}
			set
			{
				this.levelValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String jobGuidValue;

		protected String startDateISOValue;

		protected int startEventIdValue;

		protected int levelValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1362638222L;		
	} // end class
}  // end namespace

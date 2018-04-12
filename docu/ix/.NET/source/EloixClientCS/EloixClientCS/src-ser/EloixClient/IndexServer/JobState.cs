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
	/// Objects of this class provide information on the state of any background processes.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class JobState : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public JobState() {
		}		
		
		public JobState(long @countErrors, long @countEstimatedMax, long @countProcessed, long @expires, String @jobEnd, String @jobGuid, String @jobName, bool @jobRunning, String @jobStart, String @lastGuid, int @lastID, EloixClient.IndexServer.ProcessInfo @procInfo, EloixClient.IndexServer.CountResult @countResult, String @strMsg, bool @doCancelJob) {
			this.countErrorsValue = @countErrors;
			this.countEstimatedMaxValue = @countEstimatedMax;
			this.countProcessedValue = @countProcessed;
			this.expiresValue = @expires;
			this.jobEndValue = @jobEnd;
			this.jobGuidValue = @jobGuid;
			this.jobNameValue = @jobName;
			this.jobRunningValue = @jobRunning;
			this.jobStartValue = @jobStart;
			this.lastGuidValue = @lastGuid;
			this.lastIDValue = @lastID;
			this.procInfoValue = @procInfo;
			this.countResultValue = @countResult;
			this.strMsgValue = @strMsg;
			this.doCancelJobValue = @doCancelJob;
		}		
		
		public JobState(JobState rhs) : base(rhs)
		{
			this.countErrorsValue = rhs.countErrorsValue;
			this.countEstimatedMaxValue = rhs.countEstimatedMaxValue;
			this.countProcessedValue = rhs.countProcessedValue;
			this.expiresValue = rhs.expiresValue;
			this.jobEndValue = rhs.jobEndValue;
			this.jobGuidValue = rhs.jobGuidValue;
			this.jobNameValue = rhs.jobNameValue;
			this.jobRunningValue = rhs.jobRunningValue;
			this.jobStartValue = rhs.jobStartValue;
			this.lastGuidValue = rhs.lastGuidValue;
			this.lastIDValue = rhs.lastIDValue;
			this.procInfoValue = rhs.procInfoValue;
			this.countResultValue = rhs.countResultValue;
			this.strMsgValue = rhs.strMsgValue;
			this.doCancelJobValue = rhs.doCancelJobValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Error status information.
		/// </summary>
		public long countErrors
		{
			get
			{
				return countErrorsValue;
			}
			set
			{
				this.countErrorsValue = value;
			}
		}
		
		
		/// <summary>
		/// Estimated maximum amount.
		/// </summary>
		public long countEstimatedMax
		{
			get
			{
				return countEstimatedMaxValue;
			}
			set
			{
				this.countEstimatedMaxValue = value;
			}
		}
		
		
		/// <summary>
		/// Progress status information.
		/// </summary>
		public long countProcessed
		{
			get
			{
				return countProcessedValue;
			}
			set
			{
				this.countProcessedValue = value;
			}
		}
		
		
		/// <summary>
		/// When the information expires (milliseconds): (jobEnd + expires &lt; current-date).
		/// </summary>
		public long expires
		{
			get
			{
				return expiresValue;
			}
			set
			{
				this.expiresValue = value;
			}
		}
		
		
		/// <summary>
		/// End or termination of the job.
		/// </summary>
		public String jobEnd
		{
			get
			{
				return jobEndValue;
			}
			set
			{
				this.jobEndValue = value;
			}
		}
		
		
		/// <summary>
		/// Job identifier.
		/// </summary>
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
		/// Thread name.
		/// </summary>
		public String jobName
		{
			get
			{
				return jobNameValue;
			}
			set
			{
				this.jobNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Set to true while the job is being executed.
		/// </summary>
		public bool jobRunning
		{
			get
			{
				return jobRunningValue;
			}
			set
			{
				this.jobRunningValue = value;
			}
		}
		
		
		/// <summary>
		/// Start of job.
		/// </summary>
		public String jobStart
		{
			get
			{
				return jobStartValue;
			}
			set
			{
				this.jobStartValue = value;
			}
		}
		
		
		/// <summary>
		/// Status information for GUIDs.
		/// </summary>
		public String lastGuid
		{
			get
			{
				return lastGuidValue;
			}
			set
			{
				this.lastGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Status information for integer IDs.
		/// </summary>
		public int lastID
		{
			get
			{
				return lastIDValue;
			}
			set
			{
				this.lastIDValue = value;
			}
		}
		
		
		/// <summary>
		/// The standard process-by-SORD job list.
		/// </summary>
		public EloixClient.IndexServer.ProcessInfo procInfo
		{
			get
			{
				return procInfoValue;
			}
			set
			{
				this.procInfoValue = value;
			}
		}
		
		
		/// <summary>
		/// Result of the count process.
		/// </summary>
		public EloixClient.IndexServer.CountResult countResult
		{
			get
			{
				return countResultValue;
			}
			set
			{
				this.countResultValue = value;
			}
		}
		
		
		/// <summary>
		/// Job-defined message string.
		/// </summary>
		public String strMsg
		{
			get
			{
				return strMsgValue;
			}
			set
			{
				this.strMsgValue = value;
			}
		}
		
		
		/// <summary>
		/// Tell the IndexServer to cancel the job.
		/// </summary>
		public bool doCancelJob
		{
			get
			{
				return doCancelJobValue;
			}
			set
			{
				this.doCancelJobValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected long countErrorsValue;

		protected long countEstimatedMaxValue;

		protected long countProcessedValue;

		protected long expiresValue;

		protected String jobEndValue;

		protected String jobGuidValue;

		protected String jobNameValue;

		protected bool jobRunningValue;

		protected String jobStartValue;

		protected String lastGuidValue;

		protected int lastIDValue;

		protected EloixClient.IndexServer.ProcessInfo procInfoValue;

		protected EloixClient.IndexServer.CountResult countResultValue;

		protected String strMsgValue;

		protected bool doCancelJobValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1436376940L;		
	} // end class
}  // end namespace

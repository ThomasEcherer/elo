//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class FindBackgroundThreadOptions : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindBackgroundThreadOptions() {
		}		
		
		public FindBackgroundThreadOptions(bool @inclActiveJobs, bool @inclFinishedJobs, bool @inclFullInfo, int @sortOrder, EloixClient.IndexServer.UserInfo[] @userInfo, String[] @guids, String @dateAfter, String @dateBefore) {
			this.inclActiveJobsValue = @inclActiveJobs;
			this.inclFinishedJobsValue = @inclFinishedJobs;
			this.inclFullInfoValue = @inclFullInfo;
			this.sortOrderValue = @sortOrder;
			this.userInfoValue = @userInfo;
			this.guidsValue = @guids;
			this.dateAfterValue = @dateAfter;
			this.dateBeforeValue = @dateBefore;
		}		
		
		public FindBackgroundThreadOptions(FindBackgroundThreadOptions rhs) : base(rhs)
		{
			this.inclActiveJobsValue = rhs.inclActiveJobsValue;
			this.inclFinishedJobsValue = rhs.inclFinishedJobsValue;
			this.inclFullInfoValue = rhs.inclFullInfoValue;
			this.sortOrderValue = rhs.sortOrderValue;
			this.userInfoValue = rhs.userInfoValue;
			this.guidsValue = rhs.guidsValue;
			this.dateAfterValue = rhs.dateAfterValue;
			this.dateBeforeValue = rhs.dateBeforeValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Includes running Jobs in the result.
		/// </summary>
		/// <remarks>
		/// Defaults to true.
		/// </remarks>
		public bool inclActiveJobs
		{
			get
			{
				return inclActiveJobsValue;
			}
			set
			{
				this.inclActiveJobsValue = value;
			}
		}
		
		
		/// <summary>
		/// Includes finished Jobs in the result.
		/// </summary>
		/// <remarks>
		/// Defaults to false.
		/// </remarks>
		public bool inclFinishedJobs
		{
			get
			{
				return inclFinishedJobsValue;
			}
			set
			{
				this.inclFinishedJobsValue = value;
			}
		}
		
		
		/// <summary>
		/// enables extended result information in the ProcessInfo member (if
		/// available)
		/// </summary>
		public bool inclFullInfo
		{
			get
			{
				return inclFullInfoValue;
			}
			set
			{
				this.inclFullInfoValue = value;
			}
		}
		
		
		/// <summary>
		/// The order in which the results has to be sorted.
		/// </summary>
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
		/// Filter jobs of specific users; Ignored if the caller is no admin.
		/// </summary>
		public EloixClient.IndexServer.UserInfo[] userInfo
		{
			get
			{
				return userInfoValue;
			}
			set
			{
				this.userInfoValue = value;
			}
		}
		
		
		/// <summary>
		/// Filter jobs with specific Job-GUIDs.
		/// </summary>
		public String[] guids
		{
			get
			{
				return guidsValue;
			}
			set
			{
				this.guidsValue = value;
			}
		}
		
		
		/// <summary>
		/// Filter jobs started after this date.
		/// </summary>
		public String dateAfter
		{
			get
			{
				return dateAfterValue;
			}
			set
			{
				this.dateAfterValue = value;
			}
		}
		
		
		/// <summary>
		/// Filter jobs started before this date.
		/// </summary>
		public String dateBefore
		{
			get
			{
				return dateBeforeValue;
			}
			set
			{
				this.dateBeforeValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool inclActiveJobsValue;

		protected bool inclFinishedJobsValue;

		protected bool inclFullInfoValue;

		protected int sortOrderValue;

		protected EloixClient.IndexServer.UserInfo[] userInfoValue;

		protected String[] guidsValue;

		protected String dateAfterValue;

		protected String dateBeforeValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1054287589L;		
	} // end class
}  // end namespace

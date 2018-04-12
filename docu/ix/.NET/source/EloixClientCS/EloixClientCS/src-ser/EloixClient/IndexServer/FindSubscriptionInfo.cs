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
	/// Find criteria for function findFirstSubscriptions.
	/// </summary>
	public class FindSubscriptionInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindSubscriptionInfo() {
		}		
		
		public FindSubscriptionInfo(EloixClient.IndexServer.SordZ @sordZ, EloixClient.IndexServer.feed.FeedZ @feedZ, String @userId) {
			this.sordZValue = @sordZ;
			this.feedZValue = @feedZ;
			this.userIdValue = @userId;
		}		
		
		public FindSubscriptionInfo(FindSubscriptionInfo rhs) : base(rhs)
		{
			this.sordZValue = rhs.sordZValue;
			this.feedZValue = rhs.feedZValue;
			this.userIdValue = rhs.userIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Element selector for Sord objects.
		/// </summary>
		/// <remarks>
		/// If this member is not null or empty, FindResult.sords contains
		/// the Sord objects associated to FindResult.subscriptions.
		/// </remarks>
		public EloixClient.IndexServer.SordZ sordZ
		{
			get
			{
				return sordZValue;
			}
			set
			{
				this.sordZValue = value;
			}
		}
		
		
		/// <summary>
		/// Element selector for Feed objects.
		/// </summary>
		/// <remarks>
		/// If this member is not null or empty, FindResult.feeds contains
		/// the Feed objects associated to FindResult.subscriptions.
		/// </remarks>
		public EloixClient.IndexServer.feed.FeedZ feedZ
		{
			get
			{
				return feedZValue;
			}
			set
			{
				this.feedZValue = value;
			}
		}
		
		
		/// <summary>
		/// Find subscriptions of this user.
		/// </summary>
		/// <remarks>
		/// If this member is empty, the current users subscriptions are returned.
		/// This member is ignored for non-administrators.
		/// User ID, GUID or Name is accepted.
		/// </remarks>
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
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.SordZ sordZValue;

		protected EloixClient.IndexServer.feed.FeedZ feedZValue;

		protected String userIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1419135016L;		
	} // end class
}  // end namespace

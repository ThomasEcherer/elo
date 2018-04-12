//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	/// <summary>
	/// FindInfo for FindFirstNotifications.
	/// </summary>
	public class FindNotificationInfo : BSerializable
	{
	
		#region Constructors
		
		public FindNotificationInfo() {
		}		
		
		public FindNotificationInfo(String @userGuidOrID, int @what, String @createDateIso, bool @inclImportant, EloixClient.IndexServer.SordZ @sordZ, EloixClient.IndexServer.feed.ActionZ @actionZ, bool @findFeeds, bool @findHashTags, bool @findSubscriptions) {
			this.userGuidOrIDValue = @userGuidOrID;
			this.whatValue = @what;
			this.createDateIsoValue = @createDateIso;
			this.inclImportantValue = @inclImportant;
			this.sordZValue = @sordZ;
			this.actionZValue = @actionZ;
			this.findFeedsValue = @findFeeds;
			this.findHashTagsValue = @findHashTags;
			this.findSubscriptionsValue = @findSubscriptions;
		}		
		
		public FindNotificationInfo(FindNotificationInfo rhs)
		{
			this.userGuidOrIDValue = rhs.userGuidOrIDValue;
			this.whatValue = rhs.whatValue;
			this.createDateIsoValue = rhs.createDateIsoValue;
			this.inclImportantValue = rhs.inclImportantValue;
			this.sordZValue = rhs.sordZValue;
			this.actionZValue = rhs.actionZValue;
			this.findFeedsValue = rhs.findFeedsValue;
			this.findHashTagsValue = rhs.findHashTagsValue;
			this.findSubscriptionsValue = rhs.findSubscriptionsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// GUID or ID or Name of the User.
		/// </summary>
		/// <remarks>
		/// If null, current user will be set.
		/// If GUID/ID is not the current user, admin rights are needed to preform the search
		/// </remarks>
		public String userGuidOrID
		{
			get
			{
				return userGuidOrIDValue;
			}
			set
			{
				this.userGuidOrIDValue = value;
			}
		}
		
		
		public int what
		{
			get
			{
				return whatValue;
			}
			set
			{
				this.whatValue = value;
			}
		}
		
		
		/// <summary>
		/// Search by create date.
		/// </summary>
		/// <remarks>
		/// A date range can be specified by using the default range delimiter "..."
		/// or the one defined in {@link de.elo.ix.client.FindOptions#getRangeDelimiter()}.
		/// </remarks>
		public String createDateIso
		{
			get
			{
				return createDateIsoValue;
			}
			set
			{
				this.createDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// If true and createDateIso is set, it will also return all Notifications marked as Important even if they are not
		/// in the specified createDate range.
		/// </summary>
		/// <remarks>
		/// If true and createDateIso is not set, it will return only Notifications marked as Important
		/// </remarks>
		public bool inclImportant
		{
			get
			{
				return inclImportantValue;
			}
			set
			{
				this.inclImportantValue = value;
			}
		}
		
		
		/// <summary>
		/// Sord element selector.
		/// </summary>
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
		/// Action element selector.
		/// </summary>
		public EloixClient.IndexServer.feed.ActionZ actionZ
		{
			get
			{
				return actionZValue;
			}
			set
			{
				this.actionZValue = value;
			}
		}
		
		
		/// <summary>
		/// If true a Map<String, Feed> will be set in the FindResult.
		/// </summary>
		/// <remarks>
		/// by default true
		/// </remarks>
		public bool findFeeds
		{
			get
			{
				return findFeedsValue;
			}
			set
			{
				this.findFeedsValue = value;
			}
		}
		
		
		/// <summary>
		/// If true a List<HashTagRelation> and a Map<String, HashTag> will be set in the FindResult
		/// </summary>
		public bool findHashTags
		{
			get
			{
				return findHashTagsValue;
			}
			set
			{
				this.findHashTagsValue = value;
			}
		}
		
		
		/// <summary>
		/// If true a Map<String, Subscription> will be set in the FindResult
		/// </summary>
		public bool findSubscriptions
		{
			get
			{
				return findSubscriptionsValue;
			}
			set
			{
				this.findSubscriptionsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String userGuidOrIDValue;

		protected int whatValue;

		protected String createDateIsoValue;

		protected bool inclImportantValue;

		protected EloixClient.IndexServer.SordZ sordZValue;

		protected EloixClient.IndexServer.feed.ActionZ actionZValue;

		protected bool findFeedsValue;

		protected bool findHashTagsValue;

		protected bool findSubscriptionsValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 432579435L;		
	} // end class
}  // end namespace

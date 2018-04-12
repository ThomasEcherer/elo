//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.myelo
{
	
	public class MyELOContent : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public MyELOContent() {
		}		
		
		public MyELOContent(EloixClient.IndexServer.WFDiagram[] @workflows, EloixClient.IndexServer.UserTask[] @tasks, EloixClient.IndexServer.Sord[] @sords, EloixClient.IndexServer.feed.Action[] @actions, IDictionary<String,EloixClient.IndexServer.feed.Feed> @feeds, IDictionary<String,EloixClient.IndexServer.Subscription> @subscriptions, IDictionary<String,EloixClient.IndexServer.Notification> @notifications, IList<EloixClient.IndexServer.feed.HashTagRelation> @hashTagRelations, IDictionary<String,EloixClient.IndexServer.feed.HashTag> @hashTags) {
			this.workflowsValue = @workflows;
			this.tasksValue = @tasks;
			this.sordsValue = @sords;
			this.actionsValue = @actions;
			this.feedsValue = @feeds;
			this.subscriptionsValue = @subscriptions;
			this.notificationsValue = @notifications;
			this.hashTagRelationsValue = @hashTagRelations;
			this.hashTagsValue = @hashTags;
		}		
		
		public MyELOContent(MyELOContent rhs) : base(rhs)
		{
			this.workflowsValue = rhs.workflowsValue;
			this.tasksValue = rhs.tasksValue;
			this.sordsValue = rhs.sordsValue;
			this.actionsValue = rhs.actionsValue;
			this.feedsValue = rhs.feedsValue;
			this.subscriptionsValue = rhs.subscriptionsValue;
			this.notificationsValue = rhs.notificationsValue;
			this.hashTagRelationsValue = rhs.hashTagRelationsValue;
			this.hashTagsValue = rhs.hashTagsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Array of WorkflowDiagrams
		/// </summary>
		public EloixClient.IndexServer.WFDiagram[] workflows
		{
			get
			{
				return workflowsValue;
			}
			set
			{
				this.workflowsValue = value;
			}
		}
		
		
		/// <summary>
		/// Array of user tasks.
		/// </summary>
		public EloixClient.IndexServer.UserTask[] tasks
		{
			get
			{
				return tasksValue;
			}
			set
			{
				this.tasksValue = value;
			}
		}
		
		
		/// <summary>
		/// Array of <code>sord</code> objects.
		/// </summary>
		/// <remarks>
		/// This member is set if <code>sordC</code>
		/// </remarks>
		public EloixClient.IndexServer.Sord[] sords
		{
			get
			{
				return sordsValue;
			}
			set
			{
				this.sordsValue = value;
			}
		}
		
		
		/// <summary>
		/// Document feed actions.
		/// </summary>
		/// <remarks>
		/// This array is filled by findFirst/findNextActions of the interface FeedService.
		/// The associated Feed objects are returned in the collection {@link #feeds}.
		/// </remarks>
		public EloixClient.IndexServer.feed.Action[] actions
		{
			get
			{
				return actionsValue;
			}
			set
			{
				this.actionsValue = value;
			}
		}
		
		
		/// <summary>
		/// Document feeds.
		/// </summary>
		/// <remarks>
		/// Feed objects mapped to their GUID.
		/// </remarks>
		public IDictionary<String,EloixClient.IndexServer.feed.Feed> feeds
		{
			get
			{
				return feedsValue;
			}
			set
			{
				this.feedsValue = value;
			}
		}
		
		
		/// <summary>
		/// Subscriptions.
		/// </summary>
		/// <remarks>
		/// Subscription objects mapped to their Subscription.watchGuid.
		/// </remarks>
		public IDictionary<String,EloixClient.IndexServer.Subscription> subscriptions
		{
			get
			{
				return subscriptionsValue;
			}
			set
			{
				this.subscriptionsValue = value;
			}
		}
		
		
		/// <summary>
		/// Notifications.
		/// </summary>
		/// <remarks>
		/// Notification objects mapped to their Notification.watchGuid
		/// </remarks>
		public IDictionary<String,EloixClient.IndexServer.Notification> notifications
		{
			get
			{
				return notificationsValue;
			}
			set
			{
				this.notificationsValue = value;
			}
		}
		
		
		/// <summary>
		/// HashTag Relations.
		/// </summary>
		public IList<EloixClient.IndexServer.feed.HashTagRelation> hashTagRelations
		{
			get
			{
				return hashTagRelationsValue;
			}
			set
			{
				this.hashTagRelationsValue = value;
			}
		}
		
		
		/// <summary>
		/// HashTags.
		/// </summary>
		/// <remarks>
		/// HashTag Objects mapped to their HashTagGuid
		/// </remarks>
		public IDictionary<String,EloixClient.IndexServer.feed.HashTag> hashTags
		{
			get
			{
				return hashTagsValue;
			}
			set
			{
				this.hashTagsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.WFDiagram[] workflowsValue;

		protected EloixClient.IndexServer.UserTask[] tasksValue;

		protected EloixClient.IndexServer.Sord[] sordsValue;

		protected EloixClient.IndexServer.feed.Action[] actionsValue;

		protected IDictionary<String,EloixClient.IndexServer.feed.Feed> feedsValue;

		protected IDictionary<String,EloixClient.IndexServer.Subscription> subscriptionsValue;

		protected IDictionary<String,EloixClient.IndexServer.Notification> notificationsValue;

		protected IList<EloixClient.IndexServer.feed.HashTagRelation> hashTagRelationsValue;

		protected IDictionary<String,EloixClient.IndexServer.feed.HashTag> hashTagsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1585309177L;		
	} // end class
}  // end namespace

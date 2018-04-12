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
	/// <p>This class contains the search results of a call to <code>IXServicePortIF.findFirstSords</code></p>
	/// or <code>IXServicePortIF.findNextSords</code>.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class FindResult : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindResult() {
		}		
		
		public FindResult(bool @breakTimeout, bool @breakTotalCount, EloixClient.IndexServer.ConfigFile[] @configFiles, String[] @ids, bool @moreResults, EloixClient.IndexServer.ReportInfo[] @reportInfos, int @count, int @estimatedCount, String @searchId, EloixClient.IndexServer.Sord[] @sords, EloixClient.IndexServer.UserTask[] @tasks, EloixClient.IndexServer.WFDiagram[] @workflows, EloixClient.IndexServer.TranslateTerm[] @translateTerms, EloixClient.IndexServer.FindByFulltextResultItem[] @fulltextResultItems, EloixClient.IndexServer.FindByFulltextCtrlResultItem[] @fulltextCtrlResultItems, String @dynamicFolder, EloixClient.IndexServer.JobState[] @jobStates, EloixClient.IndexServer.feed.Action[] @actions, IDictionary<String,EloixClient.IndexServer.feed.Feed> @feeds, IDictionary<String,EloixClient.IndexServer.Subscription> @subscriptions, IDictionary<String,EloixClient.IndexServer.Notification> @notifications, IList<EloixClient.IndexServer.feed.HashTagRelation> @hashTagRelations, IDictionary<String,EloixClient.IndexServer.feed.HashTag> @hashTags, IList<EloixClient.IndexServer.Note> @notes, IDictionary<int,EloixClient.IndexServer.UserInfo> @userInfos, IDictionary<int,EloixClient.IndexServer.UserName> @userNames) {
			this.breakTimeoutValue = @breakTimeout;
			this.breakTotalCountValue = @breakTotalCount;
			this.configFilesValue = @configFiles;
			this.idsValue = @ids;
			this.moreResultsValue = @moreResults;
			this.reportInfosValue = @reportInfos;
			this.countValue = @count;
			this.estimatedCountValue = @estimatedCount;
			this.searchIdValue = @searchId;
			this.sordsValue = @sords;
			this.tasksValue = @tasks;
			this.workflowsValue = @workflows;
			this.translateTermsValue = @translateTerms;
			this.fulltextResultItemsValue = @fulltextResultItems;
			this.fulltextCtrlResultItemsValue = @fulltextCtrlResultItems;
			this.dynamicFolderValue = @dynamicFolder;
			this.jobStatesValue = @jobStates;
			this.actionsValue = @actions;
			this.feedsValue = @feeds;
			this.subscriptionsValue = @subscriptions;
			this.notificationsValue = @notifications;
			this.hashTagRelationsValue = @hashTagRelations;
			this.hashTagsValue = @hashTags;
			this.notesValue = @notes;
			this.userInfosValue = @userInfos;
			this.userNamesValue = @userNames;
		}		
		
		public FindResult(FindResult rhs) : base(rhs)
		{
			this.breakTimeoutValue = rhs.breakTimeoutValue;
			this.breakTotalCountValue = rhs.breakTotalCountValue;
			this.configFilesValue = rhs.configFilesValue;
			this.idsValue = rhs.idsValue;
			this.moreResultsValue = rhs.moreResultsValue;
			this.reportInfosValue = rhs.reportInfosValue;
			this.countValue = rhs.countValue;
			this.estimatedCountValue = rhs.estimatedCountValue;
			this.searchIdValue = rhs.searchIdValue;
			this.sordsValue = rhs.sordsValue;
			this.tasksValue = rhs.tasksValue;
			this.workflowsValue = rhs.workflowsValue;
			this.translateTermsValue = rhs.translateTermsValue;
			this.fulltextResultItemsValue = rhs.fulltextResultItemsValue;
			this.fulltextCtrlResultItemsValue = rhs.fulltextCtrlResultItemsValue;
			this.dynamicFolderValue = rhs.dynamicFolderValue;
			this.jobStatesValue = rhs.jobStatesValue;
			this.actionsValue = rhs.actionsValue;
			this.feedsValue = rhs.feedsValue;
			this.subscriptionsValue = rhs.subscriptionsValue;
			this.notificationsValue = rhs.notificationsValue;
			this.hashTagRelationsValue = rhs.hashTagRelationsValue;
			this.hashTagsValue = rhs.hashTagsValue;
			this.notesValue = rhs.notesValue;
			this.userInfosValue = rhs.userInfosValue;
			this.userNamesValue = rhs.userNamesValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The time limit for the search is exceeded.
		/// </summary>
		public bool breakTimeout
		{
			get
			{
				return breakTimeoutValue;
			}
			set
			{
				this.breakTimeoutValue = value;
			}
		}
		
		
		/// <summary>
		/// The search is breaked because the total number of results are reached.
		/// </summary>
		public bool breakTotalCount
		{
			get
			{
				return breakTotalCountValue;
			}
			set
			{
				this.breakTotalCountValue = value;
			}
		}
		
		
		/// <summary>
		/// Array of configuration files.
		/// </summary>
		public EloixClient.IndexServer.ConfigFile[] configFiles
		{
			get
			{
				return configFilesValue;
			}
			set
			{
				this.configFilesValue = value;
			}
		}
		
		
		/// <summary>
		/// Array of IDs or GUIDs found.
		/// </summary>
		public String[] ids
		{
			get
			{
				return idsValue;
			}
			set
			{
				this.idsValue = value;
			}
		}
		
		
		/// <summary>
		/// Is true if there are more results.
		/// </summary>
		public bool moreResults
		{
			get
			{
				return moreResultsValue;
			}
			set
			{
				this.moreResultsValue = value;
			}
		}
		
		
		/// <summary>
		/// Report entries.
		/// </summary>
		public EloixClient.IndexServer.ReportInfo[] reportInfos
		{
			get
			{
				return reportInfosValue;
			}
			set
			{
				this.reportInfosValue = value;
			}
		}
		
		
		/// <summary>
		/// Number of results.
		/// </summary>
		/// <remarks>
		/// This member is only valid, if FindInfo.findOptions.evalCount is true.
		/// </remarks>
		public int count
		{
			get
			{
				return countValue;
			}
			set
			{
				this.countValue = value;
			}
		}
		
		
		/// <summary>
		/// Estimated number of hits that can be found by the query.
		/// </summary>
		/// <remarks>
		/// This number cannot be computed for any search and is usually -1.
		/// Only if the search engine supplies an estimated count, it is &gt;= 0.
		/// </remarks>
		public int estimatedCount
		{
			get
			{
				return estimatedCountValue;
			}
			set
			{
				this.estimatedCountValue = value;
			}
		}
		
		
		/// <summary>
		/// Identifier to get more results.
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
		/// Array of terms translated into different languages.
		/// </summary>
		public EloixClient.IndexServer.TranslateTerm[] translateTerms
		{
			get
			{
				return translateTermsValue;
			}
			set
			{
				this.translateTermsValue = value;
			}
		}
		
		
		/// <summary>
		/// Additional information from the fulltext database.
		/// </summary>
		/// <remarks>
		/// This member can be null, if the fulltext engine does not
		/// support additional information.
		/// </remarks>
		public EloixClient.IndexServer.FindByFulltextResultItem[] fulltextResultItems
		{
			get
			{
				return fulltextResultItemsValue;
			}
			set
			{
				this.fulltextResultItemsValue = value;
			}
		}
		
		
		/// <summary>
		/// Result items returned from a seach for new information to be added into the fulltext database.
		/// </summary>
		public EloixClient.IndexServer.FindByFulltextCtrlResultItem[] fulltextCtrlResultItems
		{
			get
			{
				return fulltextCtrlResultItemsValue;
			}
			set
			{
				this.fulltextCtrlResultItemsValue = value;
			}
		}
		
		
		/// <summary>
		/// String representation of FindInfo used to define a dynamic register.
		/// </summary>
		/// <remarks>
		/// Function {@link IXServicePortIF#findFirstSords(ClientInfo, FindInfo, int, SordZ)} returns a
		/// serialized FindInfo in this member. It can be used to define a dynamic register by setting
		/// <code>Sord.desc=FindResult.dynamicFolder</code>.
		/// </remarks>
		public String dynamicFolder
		{
			get
			{
				return dynamicFolderValue;
			}
			set
			{
				this.dynamicFolderValue = value;
			}
		}
		
		
		/// <summary>
		/// Result items returned from a search for background threads.
		/// </summary>
		public EloixClient.IndexServer.JobState[] jobStates
		{
			get
			{
				return jobStatesValue;
			}
			set
			{
				this.jobStatesValue = value;
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
		
		
		/// <summary>
		/// Notes.
		/// </summary>
		/// <remarks>
		/// This member returns the note objects found by findFirstNotes/findNextNotes.
		/// </remarks>
		public IList<EloixClient.IndexServer.Note> notes
		{
			get
			{
				return notesValue;
			}
			set
			{
				this.notesValue = value;
			}
		}
		
		
		/// <summary>
		/// User objects.
		/// </summary>
		/// <remarks>
		/// Map of user ID to user object.
		/// </remarks>
		public IDictionary<int,EloixClient.IndexServer.UserInfo> userInfos
		{
			get
			{
				return userInfosValue;
			}
			set
			{
				this.userInfosValue = value;
			}
		}
		
		
		/// <summary>
		/// Lean user objects.
		/// </summary>
		/// <remarks>
		/// Map of user ID to user object.
		/// </remarks>
		public IDictionary<int,EloixClient.IndexServer.UserName> userNames
		{
			get
			{
				return userNamesValue;
			}
			set
			{
				this.userNamesValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool breakTimeoutValue;

		protected bool breakTotalCountValue;

		protected EloixClient.IndexServer.ConfigFile[] configFilesValue;

		protected String[] idsValue;

		protected bool moreResultsValue;

		protected EloixClient.IndexServer.ReportInfo[] reportInfosValue;

		protected int countValue;

		protected int estimatedCountValue;

		protected String searchIdValue;

		protected EloixClient.IndexServer.Sord[] sordsValue;

		protected EloixClient.IndexServer.UserTask[] tasksValue;

		protected EloixClient.IndexServer.WFDiagram[] workflowsValue;

		protected EloixClient.IndexServer.TranslateTerm[] translateTermsValue;

		protected EloixClient.IndexServer.FindByFulltextResultItem[] fulltextResultItemsValue;

		protected EloixClient.IndexServer.FindByFulltextCtrlResultItem[] fulltextCtrlResultItemsValue;

		protected String dynamicFolderValue;

		protected EloixClient.IndexServer.JobState[] jobStatesValue;

		protected EloixClient.IndexServer.feed.Action[] actionsValue;

		protected IDictionary<String,EloixClient.IndexServer.feed.Feed> feedsValue;

		protected IDictionary<String,EloixClient.IndexServer.Subscription> subscriptionsValue;

		protected IDictionary<String,EloixClient.IndexServer.Notification> notificationsValue;

		protected IList<EloixClient.IndexServer.feed.HashTagRelation> hashTagRelationsValue;

		protected IDictionary<String,EloixClient.IndexServer.feed.HashTag> hashTagsValue;

		protected IList<EloixClient.IndexServer.Note> notesValue;

		protected IDictionary<int,EloixClient.IndexServer.UserInfo> userInfosValue;

		protected IDictionary<int,EloixClient.IndexServer.UserName> userNamesValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1301335819L;		
	} // end class
}  // end namespace

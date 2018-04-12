using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	/// <summary>
	/// This interface provides functions to access document feeds.
	/// </summary>
	// checkpoint byps.gen.cs.GenRemoteClass:93
	public interface FeedServiceAuth : BRemote {
	
		/// <summary>
		/// Find actions of document feeds.
		/// </summary>
		/// <remarks>
		/// <p>
		/// In order to receive all actions for a document feed, call this function with {@link FindActionsInfo#objId} set to a Sord ID, GUID, etc.
		/// The results are returned in {@link FindResult#getActions()}. The Feed object associated to the Sord is returned in {@link FindResult#getFeeds()}.
		/// </p><p>
		/// Call IXServicePortIF.findClose to release internal resources when finished.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.FindResult findFirstActions(EloixClient.IndexServer.feed.FindActionsInfo findInfo, int max, EloixClient.IndexServer.feed.ActionZ actionZ);
		void findFirstActions(EloixClient.IndexServer.feed.FindActionsInfo findInfo, int max, EloixClient.IndexServer.feed.ActionZ actionZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Continue reading results from a search started with findFirstActions.
		/// </summary>
		EloixClient.IndexServer.FindResult findNextActions(String searchId, int idx, int max, EloixClient.IndexServer.feed.ActionZ actionZ);
		void findNextActions(String searchId, int idx, int max, EloixClient.IndexServer.feed.ActionZ actionZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Initialize a document feed item object.
		/// </summary>
		/// <remarks>
		/// This function does not store the created action in the database. Use {@link #checkinAction(ClientInfo, Action, ActionZ)}
		/// to make an Action object persistent.
		/// The returned object allows read access for everyone.
		/// </remarks>
		EloixClient.IndexServer.feed.Action createAction(EloixClient.IndexServer.feed.EActionType type, String parentGuid);
		void createAction(EloixClient.IndexServer.feed.EActionType type, String parentGuid, BAsyncResult<EloixClient.IndexServer.feed.Action> asyncResult) ;
		
		/// <summary>
		/// Create or update a document feed entry.
		/// </summary>
		String checkinAction(EloixClient.IndexServer.feed.Action action, EloixClient.IndexServer.feed.ActionZ actionZ);
		void checkinAction(EloixClient.IndexServer.feed.Action action, EloixClient.IndexServer.feed.ActionZ actionZ, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// Read a document feed entry.
		/// </summary>
		EloixClient.IndexServer.feed.Action checkoutAction(String actionGuid, EloixClient.IndexServer.feed.ActionZ actionZ);
		void checkoutAction(String actionGuid, EloixClient.IndexServer.feed.ActionZ actionZ, BAsyncResult<EloixClient.IndexServer.feed.Action> asyncResult) ;
		
		/// <summary>
		/// Register a callback interface.
		/// </summary>
		/// <remarks>
		/// The server calls functions of this interface if the document feed is modified.
		/// </remarks>
		void registerNotify(String feedGuid, EloixClient.IndexServer.feed.FeedNotification notify);
		void registerNotify(String feedGuid, EloixClient.IndexServer.feed.FeedNotification notify, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Unregister a callback interface.
		/// </summary>
		/// <remarks>
		/// Remove callback interface from internal list.
		/// </remarks>
		void unregisterNotify(String feedGuid);
		void unregisterNotify(String feedGuid, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Reserved.
		/// </summary>
		EloixClient.IndexServer.feed.Action internalInsertSystemAction(EloixClient.IndexServer.feed.Action action);
		void internalInsertSystemAction(EloixClient.IndexServer.feed.Action action, BAsyncResult<EloixClient.IndexServer.feed.Action> asyncResult) ;
		
		/// <summary>
		/// Read a HashTag Object from Database
		/// </summary>
		EloixClient.IndexServer.feed.HashTag checkoutHashTag(String hashtagGuidOrName, EloixClient.IndexServer.feed.HashTagZ hstgZ);
		void checkoutHashTag(String hashtagGuidOrName, EloixClient.IndexServer.feed.HashTagZ hstgZ, BAsyncResult<EloixClient.IndexServer.feed.HashTag> asyncResult) ;
		
		EloixClient.IndexServer.FindResult findFirstHashTagRelation(EloixClient.IndexServer.feed.FindHashTagInfo findInfo, int max, EloixClient.IndexServer.feed.HashTagZ hashTagZ);
		void findFirstHashTagRelation(EloixClient.IndexServer.feed.FindHashTagInfo findInfo, int max, EloixClient.IndexServer.feed.HashTagZ hashTagZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		EloixClient.IndexServer.FindResult findNextHashTagRelation(String searchId, int idx, int max, EloixClient.IndexServer.feed.HashTagZ hashTagZ);
		void findNextHashTagRelation(String searchId, int idx, int max, EloixClient.IndexServer.feed.HashTagZ hashTagZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Returns all HashTags which occurs in a given Array of Actions
		/// </summary>
		HashSet<EloixClient.IndexServer.feed.HashTag> findHashTagByActions(String[] actionGuids, EloixClient.IndexServer.feed.HashTagZ hashTagZ);
		void findHashTagByActions(String[] actionGuids, EloixClient.IndexServer.feed.HashTagZ hashTagZ, BAsyncResult<HashSet<EloixClient.IndexServer.feed.HashTag>> asyncResult) ;
		
		/// <summary>
		/// Returns all HashTags.
		/// </summary>
		/// <remarks>
		/// FindHashTagInfo filter the result by, createDateIso, lastUsedIso and minCount
		/// </remarks>
		Dictionary<String,EloixClient.IndexServer.feed.HashTag> findHashTags(EloixClient.IndexServer.feed.FindHashTagInfo findInfo);
		void findHashTags(EloixClient.IndexServer.feed.FindHashTagInfo findInfo, BAsyncResult<Dictionary<String,EloixClient.IndexServer.feed.HashTag>> asyncResult) ;
		
		EloixClient.IndexServer.FindResult findFirstNotification(EloixClient.IndexServer.feed.FindNotificationInfo findInfo, int max);
		void findFirstNotification(EloixClient.IndexServer.feed.FindNotificationInfo findInfo, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		EloixClient.IndexServer.FindResult findNextNotification(String searchId, int idx, int max);
		void findNextNotification(String searchId, int idx, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Creates a HashTag Subscription
		/// </summary>
		EloixClient.IndexServer.Subscription createHashTagSubscription(String hashtagGuidOrName, String userGuidOrId);
		void createHashTagSubscription(String hashtagGuidOrName, String userGuidOrId, BAsyncResult<EloixClient.IndexServer.Subscription> asyncResult) ;
		
		
	}
}  // end namespace

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BStub_FeedService : BStub, FeedServiceAuth, BSerializable {	
		
		public readonly static long serialVersionUID = 1670701039L;
		
		public BStub_FeedService(BTransport transport)
			: base(transport) {}			
		
		public virtual EloixClient.IndexServer.FindResult findFirstActions(EloixClient.IndexServer.feed.FindActionsInfo findInfo, int max, EloixClient.IndexServer.feed.ActionZ actionZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findFirstActions(findInfo, max, actionZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findFirstActions(EloixClient.IndexServer.feed.FindActionsInfo findInfo, int max, EloixClient.IndexServer.feed.ActionZ actionZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_FeedService_findFirstActions req = new BRequest_FeedService_findFirstActions();			
			req.findInfoValue = findInfo;
			req.maxValue = max;
			req.actionZValue = actionZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findNextActions(String searchId, int idx, int max, EloixClient.IndexServer.feed.ActionZ actionZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findNextActions(searchId, idx, max, actionZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findNextActions(String searchId, int idx, int max, EloixClient.IndexServer.feed.ActionZ actionZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_FeedService_findNextActions req = new BRequest_FeedService_findNextActions();			
			req.searchIdValue = searchId;
			req.idxValue = idx;
			req.maxValue = max;
			req.actionZValue = actionZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.feed.Action createAction(EloixClient.IndexServer.feed.EActionType type, String parentGuid) {
			BSyncResult<EloixClient.IndexServer.feed.Action> asyncResult = new BSyncResult<EloixClient.IndexServer.feed.Action>();			
			createAction(type, parentGuid, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.feed.Action>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createAction(EloixClient.IndexServer.feed.EActionType type, String parentGuid, BAsyncResult<EloixClient.IndexServer.feed.Action> asyncResult) {
			BRequest_FeedService_createAction req = new BRequest_FeedService_createAction();			
			req.typeValue = type;
			req.parentGuidValue = parentGuid;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String checkinAction(EloixClient.IndexServer.feed.Action action, EloixClient.IndexServer.feed.ActionZ actionZ) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			checkinAction(action, actionZ, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinAction(EloixClient.IndexServer.feed.Action action, EloixClient.IndexServer.feed.ActionZ actionZ, BAsyncResult<String> asyncResult) {
			BRequest_FeedService_checkinAction req = new BRequest_FeedService_checkinAction();			
			req.actionValue = action;
			req.actionZValue = actionZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.feed.Action checkoutAction(String actionGuid, EloixClient.IndexServer.feed.ActionZ actionZ) {
			BSyncResult<EloixClient.IndexServer.feed.Action> asyncResult = new BSyncResult<EloixClient.IndexServer.feed.Action>();			
			checkoutAction(actionGuid, actionZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.feed.Action>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutAction(String actionGuid, EloixClient.IndexServer.feed.ActionZ actionZ, BAsyncResult<EloixClient.IndexServer.feed.Action> asyncResult) {
			BRequest_FeedService_checkoutAction req = new BRequest_FeedService_checkoutAction();			
			req.actionGuidValue = actionGuid;
			req.actionZValue = actionZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void registerNotify(String feedGuid, EloixClient.IndexServer.feed.FeedNotification notify) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			registerNotify(feedGuid, notify, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void registerNotify(String feedGuid, EloixClient.IndexServer.feed.FeedNotification notify, BAsyncResult<Object> asyncResult) {
			BRequest_FeedService_registerNotify req = new BRequest_FeedService_registerNotify();			
			req.feedGuidValue = feedGuid;
			req.notifyValue = notify;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void unregisterNotify(String feedGuid) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			unregisterNotify(feedGuid, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void unregisterNotify(String feedGuid, BAsyncResult<Object> asyncResult) {
			BRequest_FeedService_unregisterNotify req = new BRequest_FeedService_unregisterNotify();			
			req.feedGuidValue = feedGuid;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.feed.Action internalInsertSystemAction(EloixClient.IndexServer.feed.Action action) {
			BSyncResult<EloixClient.IndexServer.feed.Action> asyncResult = new BSyncResult<EloixClient.IndexServer.feed.Action>();			
			internalInsertSystemAction(action, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.feed.Action>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void internalInsertSystemAction(EloixClient.IndexServer.feed.Action action, BAsyncResult<EloixClient.IndexServer.feed.Action> asyncResult) {
			BRequest_FeedService_internalInsertSystemAction req = new BRequest_FeedService_internalInsertSystemAction();			
			req.actionValue = action;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.feed.HashTag checkoutHashTag(String hashtagGuidOrName, EloixClient.IndexServer.feed.HashTagZ hstgZ) {
			BSyncResult<EloixClient.IndexServer.feed.HashTag> asyncResult = new BSyncResult<EloixClient.IndexServer.feed.HashTag>();			
			checkoutHashTag(hashtagGuidOrName, hstgZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.feed.HashTag>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutHashTag(String hashtagGuidOrName, EloixClient.IndexServer.feed.HashTagZ hstgZ, BAsyncResult<EloixClient.IndexServer.feed.HashTag> asyncResult) {
			BRequest_FeedService_checkoutHashTag req = new BRequest_FeedService_checkoutHashTag();			
			req.hashtagGuidOrNameValue = hashtagGuidOrName;
			req.hstgZValue = hstgZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findFirstHashTagRelation(EloixClient.IndexServer.feed.FindHashTagInfo findInfo, int max, EloixClient.IndexServer.feed.HashTagZ hashTagZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findFirstHashTagRelation(findInfo, max, hashTagZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findFirstHashTagRelation(EloixClient.IndexServer.feed.FindHashTagInfo findInfo, int max, EloixClient.IndexServer.feed.HashTagZ hashTagZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_FeedService_findFirstHashTagRelation req = new BRequest_FeedService_findFirstHashTagRelation();			
			req.findInfoValue = findInfo;
			req.maxValue = max;
			req.hashTagZValue = hashTagZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findNextHashTagRelation(String searchId, int idx, int max, EloixClient.IndexServer.feed.HashTagZ hashTagZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findNextHashTagRelation(searchId, idx, max, hashTagZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findNextHashTagRelation(String searchId, int idx, int max, EloixClient.IndexServer.feed.HashTagZ hashTagZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_FeedService_findNextHashTagRelation req = new BRequest_FeedService_findNextHashTagRelation();			
			req.searchIdValue = searchId;
			req.idxValue = idx;
			req.maxValue = max;
			req.hashTagZValue = hashTagZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual HashSet<EloixClient.IndexServer.feed.HashTag> findHashTagByActions(String[] actionGuids, EloixClient.IndexServer.feed.HashTagZ hashTagZ) {
			BSyncResult<HashSet<EloixClient.IndexServer.feed.HashTag>> asyncResult = new BSyncResult<HashSet<EloixClient.IndexServer.feed.HashTag>>();			
			findHashTagByActions(actionGuids, hashTagZ, BAsyncResultHelper.ToDelegate<HashSet<EloixClient.IndexServer.feed.HashTag>>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findHashTagByActions(String[] actionGuids, EloixClient.IndexServer.feed.HashTagZ hashTagZ, BAsyncResult<HashSet<EloixClient.IndexServer.feed.HashTag>> asyncResult) {
			BRequest_FeedService_findHashTagByActions req = new BRequest_FeedService_findHashTagByActions();			
			req.actionGuidsValue = actionGuids;
			req.hashTagZValue = hashTagZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual Dictionary<String,EloixClient.IndexServer.feed.HashTag> findHashTags(EloixClient.IndexServer.feed.FindHashTagInfo findInfo) {
			BSyncResult<Dictionary<String,EloixClient.IndexServer.feed.HashTag>> asyncResult = new BSyncResult<Dictionary<String,EloixClient.IndexServer.feed.HashTag>>();			
			findHashTags(findInfo, BAsyncResultHelper.ToDelegate<Dictionary<String,EloixClient.IndexServer.feed.HashTag>>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findHashTags(EloixClient.IndexServer.feed.FindHashTagInfo findInfo, BAsyncResult<Dictionary<String,EloixClient.IndexServer.feed.HashTag>> asyncResult) {
			BRequest_FeedService_findHashTags req = new BRequest_FeedService_findHashTags();			
			req.findInfoValue = findInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findFirstNotification(EloixClient.IndexServer.feed.FindNotificationInfo findInfo, int max) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findFirstNotification(findInfo, max, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findFirstNotification(EloixClient.IndexServer.feed.FindNotificationInfo findInfo, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_FeedService_findFirstNotification req = new BRequest_FeedService_findFirstNotification();			
			req.findInfoValue = findInfo;
			req.maxValue = max;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findNextNotification(String searchId, int idx, int max) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findNextNotification(searchId, idx, max, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findNextNotification(String searchId, int idx, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_FeedService_findNextNotification req = new BRequest_FeedService_findNextNotification();			
			req.searchIdValue = searchId;
			req.idxValue = idx;
			req.maxValue = max;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Subscription createHashTagSubscription(String hashtagGuidOrName, String userGuidOrId) {
			BSyncResult<EloixClient.IndexServer.Subscription> asyncResult = new BSyncResult<EloixClient.IndexServer.Subscription>();			
			createHashTagSubscription(hashtagGuidOrName, userGuidOrId, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Subscription>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createHashTagSubscription(String hashtagGuidOrName, String userGuidOrId, BAsyncResult<EloixClient.IndexServer.Subscription> asyncResult) {
			BRequest_FeedService_createHashTagSubscription req = new BRequest_FeedService_createHashTagSubscription();			
			req.hashtagGuidOrNameValue = hashtagGuidOrName;
			req.userGuidOrIdValue = userGuidOrId;
			transport.sendMethod(req, asyncResult);
		}
		
		
	}
}

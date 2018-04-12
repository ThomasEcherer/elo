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
	/// Describes search criteria for
	/// {@link FeedService#findFirstActions(de.elo.ix.client.ClientInfo, FindActionsInfo, int, ActionZ)}.
	/// </summary>
	/// <remarks>
	/// <p>
	/// If only objId is set, userId and createDateIso is empty, the entire
	/// document feed of the given object is returned. The (main) actions are sorted
	/// descending by create date. The answers (child actions) follow immediately
	/// their associated main action. Answers are sorted ascending by create date.
	/// </p>
	/// <p>
	/// If any other member is also set, or if objId is combined with another member, the search combines the elements by logical AND.
	/// The result list contains all actions sorted descending by create date. The ordering does not distinguish between
	/// main actions and child actions.
	/// </p>
	/// </remarks>
	public class FindActionsInfo : BSerializable
	{
	
		#region Constructors
		
		public FindActionsInfo() {
		}		
		
		public FindActionsInfo(String @objId, String @userId, String @createDateIso, IList<EloixClient.IndexServer.feed.EActionType> @actionTypes, bool @findNotifications, bool @findHashTags, bool @findSubscriptions, EloixClient.IndexServer.SordZ @sordZ) {
			this.objIdValue = @objId;
			this.userIdValue = @userId;
			this.createDateIsoValue = @createDateIso;
			this.actionTypesValue = @actionTypes;
			this.findNotificationsValue = @findNotifications;
			this.findHashTagsValue = @findHashTags;
			this.findSubscriptionsValue = @findSubscriptions;
			this.sordZValue = @sordZ;
		}		
		
		public FindActionsInfo(FindActionsInfo rhs)
		{
			this.objIdValue = rhs.objIdValue;
			this.userIdValue = rhs.userIdValue;
			this.createDateIsoValue = rhs.createDateIsoValue;
			this.actionTypesValue = rhs.actionTypesValue;
			this.findNotificationsValue = rhs.findNotificationsValue;
			this.findHashTagsValue = rhs.findHashTagsValue;
			this.findSubscriptionsValue = rhs.findSubscriptionsValue;
			this.sordZValue = rhs.sordZValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Search by Sord ID, GUID, etc.
		/// </summary>
		/// <remarks>
		/// This value can be an ID, a GUID or an expression as defined
		/// in {@link de.elo.ix.client.IXServicePortIF#checkoutSord(de.elo.ix.client.ClientInfo, String, de.elo.ix.client.EditInfoZ, de.elo.ix.client.LockZ)}.
		/// </remarks>
		public String objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Search by user ID, GUID, name.
		/// </summary>
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
		/// Search by action types.
		/// </summary>
		/// <remarks>
		/// If this element is empty, actions of all types are returned.
		/// </remarks>
		public IList<EloixClient.IndexServer.feed.EActionType> actionTypes
		{
			get
			{
				return actionTypesValue;
			}
			set
			{
				this.actionTypesValue = value;
			}
		}
		
		
		/// <summary>
		/// Search for notifications.
		/// </summary>
		/// <remarks>
		/// If this member is true, only those actions are found for which the
		/// user was notified.
		/// </remarks>
		public bool findNotifications
		{
			get
			{
				return findNotificationsValue;
			}
			set
			{
				this.findNotificationsValue = value;
			}
		}
		
		
		/// <summary>
		/// Search for HashTags
		/// If this member is true, all HashTags within the action will be returned
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
		
		
		/// <summary>
		/// Sord element selector.
		/// </summary>
		/// <remarks>
		/// If this member is not null or empty, the returned FindResult object
		/// contains the associated Sord objects in FindResult.sords.
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
		
		
		#endregion
		
		#region Fields
		
		protected String objIdValue;

		protected String userIdValue;

		protected String createDateIsoValue;

		protected IList<EloixClient.IndexServer.feed.EActionType> actionTypesValue;

		protected bool findNotificationsValue;

		protected bool findHashTagsValue;

		protected bool findSubscriptionsValue;

		protected EloixClient.IndexServer.SordZ sordZValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1747180074L;		
	} // end class
}  // end namespace

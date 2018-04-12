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
	/// This class describes a subscription.
	/// </summary>
	/// <remarks>
	/// A user can subscribe for changes to an object.
	/// Currently, the only supported object type is a document feed.
	/// If the feed receives new comments, notification information
	/// is inserted into the database for the user.
	/// By calling FeedService.findFirstActions and setting FindActionsInfo.findNotifications=true,
	/// the user can search for her notifications.
	/// </remarks>
	public class Subscription : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public Subscription() {
		}		
		
		public Subscription(String @userGuid, String @watchGuid, String @createDateIso) {
			this.userGuidValue = @userGuid;
			this.watchGuidValue = @watchGuid;
			this.createDateIsoValue = @createDateIso;
		}		
		
		public Subscription(Subscription rhs) : base(rhs)
		{
			this.userGuidValue = rhs.userGuidValue;
			this.watchGuidValue = rhs.watchGuidValue;
			this.createDateIsoValue = rhs.createDateIsoValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// GUID of user who registered the subscription.
		/// </summary>
		public String userGuid
		{
			get
			{
				return userGuidValue;
			}
			set
			{
				this.userGuidValue = value;
				setChangedMember(SubscriptionC.mbUserGuid);
			}
		}
		
		
		/// <summary>
		/// GUID of Object to be watched.
		/// </summary>
		/// <remarks>
		/// Currently, this can only be a feed guid.
		/// </remarks>
		public String watchGuid
		{
			get
			{
				return watchGuidValue;
			}
			set
			{
				this.watchGuidValue = value;
				setChangedMember(SubscriptionC.mbWatchGuid);
			}
		}
		
		
		/// <summary>
		/// Create date of the subscription.
		/// </summary>
		public String createDateIso
		{
			get
			{
				return createDateIsoValue;
			}
			set
			{
				this.createDateIsoValue = value;
				setChangedMember(SubscriptionC.mbCreateDateIso);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String userGuidValue;

		protected String watchGuidValue;

		protected String createDateIsoValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 323351719L;		
	} // end class
}  // end namespace

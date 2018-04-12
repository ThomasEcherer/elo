//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class FindHashTagInfo : BSerializable
	{
	
		#region Constructors
		
		public FindHashTagInfo() {
		}		
		
		public FindHashTagInfo(String @hashtagGuidOrName, String @createDateIso, String @lastUsedIso, int @minCount, EloixClient.IndexServer.feed.ActionZ @actionZ, EloixClient.IndexServer.SordZ @sordZ, bool @findFeeds, bool @findHashTags, bool @findSubscriptions) {
			this.hashtagGuidOrNameValue = @hashtagGuidOrName;
			this.createDateIsoValue = @createDateIso;
			this.lastUsedIsoValue = @lastUsedIso;
			this.minCountValue = @minCount;
			this.actionZValue = @actionZ;
			this.sordZValue = @sordZ;
			this.findFeedsValue = @findFeeds;
			this.findHashTagsValue = @findHashTags;
			this.findSubscriptionsValue = @findSubscriptions;
		}		
		
		public FindHashTagInfo(FindHashTagInfo rhs)
		{
			this.hashtagGuidOrNameValue = rhs.hashtagGuidOrNameValue;
			this.createDateIsoValue = rhs.createDateIsoValue;
			this.lastUsedIsoValue = rhs.lastUsedIsoValue;
			this.minCountValue = rhs.minCountValue;
			this.actionZValue = rhs.actionZValue;
			this.sordZValue = rhs.sordZValue;
			this.findFeedsValue = rhs.findFeedsValue;
			this.findHashTagsValue = rhs.findHashTagsValue;
			this.findSubscriptionsValue = rhs.findSubscriptionsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// HashTag Guid or Name
		/// </summary>
		public String hashtagGuidOrName
		{
			get
			{
				return hashtagGuidOrNameValue;
			}
			set
			{
				this.hashtagGuidOrNameValue = value;
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
		/// Search by last used.
		/// </summary>
		/// <remarks>
		/// A date range can be specified by using the default range delimiter "..."
		/// or the one defined in {@link de.elo.ix.client.FindOptions#getRangeDelimiter()}.
		/// </remarks>
		public String lastUsedIso
		{
			get
			{
				return lastUsedIsoValue;
			}
			set
			{
				this.lastUsedIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Filter the result by number of use.
		/// </summary>
		/// <remarks>
		/// Only HashTags with >= minCount will be returned
		/// </remarks>
		public int minCount
		{
			get
			{
				return minCountValue;
			}
			set
			{
				this.minCountValue = value;
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
		
		protected String hashtagGuidOrNameValue;

		protected String createDateIsoValue;

		protected String lastUsedIsoValue;

		protected int minCountValue;

		protected EloixClient.IndexServer.feed.ActionZ actionZValue;

		protected EloixClient.IndexServer.SordZ sordZValue;

		protected bool findFeedsValue;

		protected bool findHashTagsValue;

		protected bool findSubscriptionsValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 256103952L;		
	} // end class
}  // end namespace

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
	/// NavigationInfo is used as traversal information for structured bulk
	/// operations restricting specific processsing, e.g. pooled jobs, to scalable amounts.
	/// </summary>
	/// <remarks>
	/// It provides parameters controlling the traversal.
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class NavigationInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public NavigationInfo() {
		}		
		
		public NavigationInfo(bool @ignoreDocuments, int @maxCount, int @maxDepth, int @maxSiblings, String[] @startIDs, EloixClient.IndexServer.FindInfo @findInfo) {
			this.ignoreDocumentsValue = @ignoreDocuments;
			this.maxCountValue = @maxCount;
			this.maxDepthValue = @maxDepth;
			this.maxSiblingsValue = @maxSiblings;
			this.startIDsValue = @startIDs;
			this.findInfoValue = @findInfo;
		}		
		
		public NavigationInfo(NavigationInfo rhs) : base(rhs)
		{
			this.ignoreDocumentsValue = rhs.ignoreDocumentsValue;
			this.maxCountValue = rhs.maxCountValue;
			this.maxDepthValue = rhs.maxDepthValue;
			this.maxSiblingsValue = rhs.maxSiblingsValue;
			this.startIDsValue = rhs.startIDsValue;
			this.findInfoValue = rhs.findInfoValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// ignore the navigation of documents
		/// </summary>
		public bool ignoreDocuments
		{
			get
			{
				return ignoreDocumentsValue;
			}
			set
			{
				this.ignoreDocumentsValue = value;
			}
		}
		
		
		/// <summary>
		/// maxCount is the overall maximum amount of visited nodes and is independent of successful processing.
		/// </summary>
		/// <remarks>
		/// maxCount does not depend on successful processing to be incremented, and it can stop the traversal
		/// before any of the other limits have been reached.
		/// Passing maxCount &lt; 1 will turn off this limit.
		/// </remarks>
		public int maxCount
		{
			get
			{
				return maxCountValue;
			}
			set
			{
				this.maxCountValue = value;
			}
		}
		
		
		/// <summary>
		/// The maximum depth of the tree walk.
		/// </summary>
		/// <remarks>
		/// Passing maxDepth &lt; 1 turns off this limit.
		/// </remarks>
		public int maxDepth
		{
			get
			{
				return maxDepthValue;
			}
			set
			{
				this.maxDepthValue = value;
			}
		}
		
		
		/// <summary>
		/// The maximum number of siblings for one tree level.
		/// </summary>
		/// <remarks>
		/// This limit is most
		/// useful for ignoring the contents of large folders. Passing maxSiblings
		/// &lt; 1 will turn the limit off.
		/// </remarks>
		public int maxSiblings
		{
			get
			{
				return maxSiblingsValue;
			}
			set
			{
				this.maxSiblingsValue = value;
			}
		}
		
		
		/// <summary>
		/// The starting points for the tree walk.
		/// </summary>
		/// <remarks>
		/// Interdepending nodes will only be
		/// traversed once. Providing null causes an invalid parameter exception,
		/// while unresolvable IDs or GUIDs will simply be ignored.
		/// </remarks>
		public String[] startIDs
		{
			get
			{
				return startIDsValue;
			}
			set
			{
				this.startIDsValue = value;
			}
		}
		
		
		/// <summary>
		/// Specify additional filters for the tree walk.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Please note that specifying a custom findInfo always leads to a second
		/// search for each directory decreasing the overall performance. Use this
		/// only if processFindResult is not suitable.
		/// </p>
		/// <p>
		/// Then, not every feature is supported which findInfo offers. Firstly, the
		/// member findChildren will be overwritten during the tree walk. Secondly, as
		/// a fulltext or direct search respectively influence the search for children,
		/// they are unsupported also.
		/// </p>
		/// </remarks>
		public EloixClient.IndexServer.FindInfo findInfo
		{
			get
			{
				return findInfoValue;
			}
			set
			{
				this.findInfoValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool ignoreDocumentsValue;

		protected int maxCountValue;

		protected int maxDepthValue;

		protected int maxSiblingsValue;

		protected String[] startIDsValue;

		protected EloixClient.IndexServer.FindInfo findInfoValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1953181452L;		
	} // end class
}  // end namespace

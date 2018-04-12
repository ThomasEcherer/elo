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
	/// This class is used to search for objects
	/// that have to be indexed by the fulltext
	/// database engine.
	/// </summary>
	/// <remarks>
	/// <p>
	/// The selected objects are ordered by their timestamp.
	/// If the search process is interrupted because of a timeout or
	/// because the FindOptions.totalCount limit is reached,
	/// all the Objects of the lates timestamp second are
	/// discarded.
	/// </p><p>
	/// If the search process is terminated due to breakTotalCount
	/// and the array of results is empty, the search should be
	/// repeated with a greater value for totalCount.
	/// </p><p>
	/// Access checking is performed as in all other searches.
	/// </p><p>
	/// A search of this type can only be combined with
	/// FindOptions.totalCount and FindOptions.timeoutSeconds.
	/// </p><p>
	/// The results are returned in the member FindInfo.fulltextCtrlResultItems.
	/// The Sord objects are available in the member FindInfo.sords too.
	/// </p>
	/// </remarks>
	public class FindByFulltextCtrl : BSerializable
	{
	
		#region Constructors
		
		public FindByFulltextCtrl() {
		}		
		
		public FindByFulltextCtrl(String @startTStamp, String @endTStamp, bool @onlyDocs, String @profileKeyPrefix, bool @reindex) {
			this.startTStampValue = @startTStamp;
			this.endTStampValue = @endTStamp;
			this.onlyDocsValue = @onlyDocs;
			this.profileKeyPrefixValue = @profileKeyPrefix;
			this.reindexValue = @reindex;
		}		
		
		public FindByFulltextCtrl(FindByFulltextCtrl rhs)
		{
			this.startTStampValue = rhs.startTStampValue;
			this.endTStampValue = rhs.endTStampValue;
			this.onlyDocsValue = rhs.onlyDocsValue;
			this.profileKeyPrefixValue = rhs.profileKeyPrefixValue;
			this.reindexValue = rhs.reindexValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Find objects from this date or newer.
		/// </summary>
		/// <remarks>
		/// This value can be null or empty in which case the
		/// time range has no lower limit.
		/// </remarks>
		public String startTStamp
		{
			get
			{
				return startTStampValue;
			}
			set
			{
				this.startTStampValue = value;
			}
		}
		
		
		/// <summary>
		/// Find objects from this date or older.
		/// </summary>
		/// <remarks>
		/// If the value is null or empty, the time range
		/// has no upper limit.
		/// </remarks>
		public String endTStamp
		{
			get
			{
				return endTStampValue;
			}
			set
			{
				this.endTStampValue = value;
			}
		}
		
		
		/// <summary>
		/// Find next documents for textreader.
		/// </summary>
		public bool onlyDocs
		{
			get
			{
				return onlyDocsValue;
			}
			set
			{
				this.onlyDocsValue = value;
			}
		}
		
		
		/// <summary>
		/// Key prefix for loop state.
		/// </summary>
		public String profileKeyPrefix
		{
			get
			{
				return profileKeyPrefixValue;
			}
			set
			{
				this.profileKeyPrefixValue = value;
			}
		}
		
		
		/// <summary>
		/// Re-index processing.
		/// </summary>
		/// <remarks>
		/// If this member is true, a search returns objects from the largest object ID to 2.
		/// If this member is false, a search returns the next objects in a timestamp interval.
		/// </remarks>
		public bool reindex
		{
			get
			{
				return reindexValue;
			}
			set
			{
				this.reindexValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String startTStampValue;

		protected String endTStampValue;

		protected bool onlyDocsValue;

		protected String profileKeyPrefixValue;

		protected bool reindexValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 96165507L;		
	} // end class
}  // end namespace

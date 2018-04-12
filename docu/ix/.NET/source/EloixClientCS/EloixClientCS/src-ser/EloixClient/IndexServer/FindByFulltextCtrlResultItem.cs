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
	/// A search using FindByFulltextCtrl returns this result items
	/// in addition to findResult.sords.
	/// </summary>
	public class FindByFulltextCtrlResultItem : BSerializable
	{
	
		#region Constructors
		
		public FindByFulltextCtrlResultItem() {
		}		
		
		public FindByFulltextCtrlResultItem(EloixClient.IndexServer.Sord @sord, String @TStamp, EloixClient.IndexServer.Note @note) {
			this.sordValue = @sord;
			this.TStampValue = @TStamp;
			this.noteValue = @note;
		}		
		
		public FindByFulltextCtrlResultItem(FindByFulltextCtrlResultItem rhs)
		{
			this.sordValue = rhs.sordValue;
			this.TStampValue = rhs.TStampValue;
			this.noteValue = rhs.noteValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Sord object.
		/// </summary>
		/// <remarks>
		/// Same as in <code>findResult.sords[.]</code>
		/// </remarks>
		public EloixClient.IndexServer.Sord sord
		{
			get
			{
				return sordValue;
			}
			set
			{
				this.sordValue = value;
			}
		}
		
		
		/// <summary>
		/// Timestamp of the last change of either indexing information, note data,
		/// fulltext content or attachment fulltext content.
		/// </summary>
		public String TStamp
		{
			get
			{
				return TStampValue;
			}
			set
			{
				this.TStampValue = value;
			}
		}
		
		
		/// <summary>
		/// Note object.
		/// </summary>
		/// <remarks>
		/// If this member is set, member <code>sord</code> can be ignored.
		/// </remarks>
		public EloixClient.IndexServer.Note note
		{
			get
			{
				return noteValue;
			}
			set
			{
				this.noteValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.Sord sordValue;

		protected String TStampValue;

		protected EloixClient.IndexServer.Note noteValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1755682788L;		
	} // end class
}  // end namespace

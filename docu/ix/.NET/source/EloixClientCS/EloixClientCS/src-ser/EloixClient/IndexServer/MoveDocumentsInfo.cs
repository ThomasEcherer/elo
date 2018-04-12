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
	/// Parameter class of the function {@link IXServicePortIF#moveDocuments(ClientInfo, MoveDocumentsInfo)}.
	/// </summary>
	public class MoveDocumentsInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public MoveDocumentsInfo() {
		}		
		
		public MoveDocumentsInfo(String @sourcePathId, String @targetPathId, String @startDate, String @endDate) {
			this.sourcePathIdValue = @sourcePathId;
			this.targetPathIdValue = @targetPathId;
			this.startDateValue = @startDate;
			this.endDateValue = @endDate;
		}		
		
		public MoveDocumentsInfo(MoveDocumentsInfo rhs) : base(rhs)
		{
			this.sourcePathIdValue = rhs.sourcePathIdValue;
			this.targetPathIdValue = rhs.targetPathIdValue;
			this.startDateValue = rhs.startDateValue;
			this.endDateValue = rhs.endDateValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// ID of the source storage path.
		/// </summary>
		public String sourcePathId
		{
			get
			{
				return sourcePathIdValue;
			}
			set
			{
				this.sourcePathIdValue = value;
			}
		}
		
		
		/// <summary>
		/// ID of the target storage path.
		/// </summary>
		public String targetPathId
		{
			get
			{
				return targetPathIdValue;
			}
			set
			{
				this.targetPathIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Start date.
		/// </summary>
		public String startDate
		{
			get
			{
				return startDateValue;
			}
			set
			{
				this.startDateValue = value;
			}
		}
		
		
		/// <summary>
		/// End date.
		/// </summary>
		public String endDate
		{
			get
			{
				return endDateValue;
			}
			set
			{
				this.endDateValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String sourcePathIdValue;

		protected String targetPathIdValue;

		protected String startDateValue;

		protected String endDateValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2016315141L;		
	} // end class
}  // end namespace

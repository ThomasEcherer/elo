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
	/// This class represents a HashTag
	/// </summary>
	public class HashTag : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public HashTag() {
		}		
		
		public HashTag(String @hstgGuid, String @hstgName, String @createDateIso, String @lastUsedIso, int @counter, String @tStamp, int @status) {
			this.hstgGuidValue = @hstgGuid;
			this.hstgNameValue = @hstgName;
			this.createDateIsoValue = @createDateIso;
			this.lastUsedIsoValue = @lastUsedIso;
			this.counterValue = @counter;
			this.tStampValue = @tStamp;
			this.statusValue = @status;
		}		
		
		public HashTag(HashTag rhs) : base(rhs)
		{
			this.hstgGuidValue = rhs.hstgGuidValue;
			this.hstgNameValue = rhs.hstgNameValue;
			this.createDateIsoValue = rhs.createDateIsoValue;
			this.lastUsedIsoValue = rhs.lastUsedIsoValue;
			this.counterValue = rhs.counterValue;
			this.tStampValue = rhs.tStampValue;
			this.statusValue = rhs.statusValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// HashTag GUID.
		/// </summary>
		/// <remarks>
		/// Unique identifier.
		/// </remarks>
		public String hstgGuid
		{
			get
			{
				return hstgGuidValue;
			}
			set
			{
				this.hstgGuidValue = value;
				setChangedMember(HashTagC.mbHstgGuid);
			}
		}
		
		
		/// <summary>
		/// HashTag Name.
		/// </summary>
		public String hstgName
		{
			get
			{
				return hstgNameValue;
			}
			set
			{
				this.hstgNameValue = value;
				setChangedMember(HashTagC.mbHstgName);
			}
		}
		
		
		/// <summary>
		/// Create date.
		/// </summary>
		/// <remarks>
		/// It holds the ISO formatted create date in the time zone of the client application.
		/// In order to convert this value into a date object, invoke function {@link de.elo.ix.client.IXConnection#isoToDate}.
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
				setChangedMember(HashTagC.mbCreateDateIso);
			}
		}
		
		
		/// <summary>
		/// Last used.
		/// </summary>
		/// <remarks>
		/// It holds the ISO formatted date of the last use of this HashTag
		/// In order to convert this value into a date object, invoke function {@link de.elo.ix.client.IXConnection#isoToDate}.
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
				setChangedMember(HashTagC.mbLastUsedIso);
			}
		}
		
		
		/// <summary>
		/// Counter.
		/// </summary>
		/// <remarks>
		/// Counts how often this HashTag is used.
		/// </remarks>
		public int counter
		{
			get
			{
				return counterValue;
			}
			set
			{
				this.counterValue = value;
			}
		}
		
		
		/// <summary>
		/// Timestamp for replication.
		/// </summary>
		public String tStamp
		{
			get
			{
				return tStampValue;
			}
			set
			{
				this.tStampValue = value;
				setChangedMember(HashTagC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// Status.
		/// </summary>
		public int status
		{
			get
			{
				return statusValue;
			}
			set
			{
				this.statusValue = value;
				setChangedMember(HashTagC.mbStatus);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String hstgGuidValue;

		protected String hstgNameValue;

		protected String createDateIsoValue;

		protected String lastUsedIsoValue;

		protected int counterValue;

		protected String tStampValue;

		protected int statusValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1143177929L;		
	} // end class
}  // end namespace

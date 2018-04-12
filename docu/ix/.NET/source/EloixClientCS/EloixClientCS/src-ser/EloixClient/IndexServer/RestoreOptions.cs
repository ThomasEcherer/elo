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
	/// <p>This class contains several options for undeleting archive SORDs by <code>restoreSord</code></p>
	/// <p>Copyright: Copyright (c) 2004-2006</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class RestoreOptions : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public RestoreOptions() {
		}		
		
		public RestoreOptions(String @minIDate, bool @singleObject, String @minDeleteDate, String @parentId) {
			this.minIDateValue = @minIDate;
			this.singleObjectValue = @singleObject;
			this.minDeleteDateValue = @minDeleteDate;
			this.parentIdValue = @parentId;
		}		
		
		public RestoreOptions(RestoreOptions rhs) : base(rhs)
		{
			this.minIDateValue = rhs.minIDateValue;
			this.singleObjectValue = rhs.singleObjectValue;
			this.minDeleteDateValue = rhs.minDeleteDateValue;
			this.parentIdValue = rhs.parentIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// <p><code>minIDate</code> ist the ISO representation of the local date
		/// used to mark the lower limit for restoring.
		/// </summary>
		/// <remarks>
		/// </p>
		/// </remarks>
		public String minIDate
		{
			get
			{
				return minIDateValue;
			}
			set
			{
				this.minIDateValue = value;
			}
		}
		
		
		/// <summary>
		/// <p><code>singleObject=true</code> restricts the operation to the specified
		/// object not traversing sub trees.
		/// </summary>
		/// <remarks>
		/// </p>
		/// </remarks>
		public bool singleObject
		{
			get
			{
				return singleObjectValue;
			}
			set
			{
				this.singleObjectValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// Restore only document versions that are deleted after
		/// <code>minDeleteDate</code>.
		/// </summary>
		/// <remarks>
		/// Its String representation is the ISO format
		/// in the client's time zone.
		/// </p>
		/// </remarks>
		public String minDeleteDate
		{
			get
			{
				return minDeleteDateValue;
			}
			set
			{
				this.minDeleteDateValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// Since references also got a delete date, they can be restored independently
		/// from their main reference.
		/// </summary>
		/// <remarks>
		/// To restore a reference selectively, set parentId
		/// to the references' parentId. Restoring a reference does not affect the
		/// delete status of its main reference.
		/// </p>
		/// <p>Setting parentId implies singleObject=true.</p>
		/// </remarks>
		public String parentId
		{
			get
			{
				return parentIdValue;
			}
			set
			{
				this.parentIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String minIDateValue;

		protected bool singleObjectValue;

		protected String minDeleteDateValue;

		protected String parentIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 378110234L;		
	} // end class
}  // end namespace

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
	/// This class contains constants for sorting of archive entries and search results.
	/// </summary>
	public class SortOrderC : BSerializable
	{
	
		#region Constructors
		
		public SortOrderC() {
		}		
		
		public SortOrderC(int @dummy) {
			this.dummyValue = @dummy;
		}		
		
		public SortOrderC(SortOrderC rhs)
		{
			this.dummyValue = rhs.dummyValue;
		}		
		
		#endregion
		
		#region Properties
		
		public int dummy
		{
			get
			{
				return dummyValue;
			}
			set
			{
				this.dummyValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Subitems are sorted manually.
		/// </summary>
		public const int MANUAL = 1000;

		/// <summary>
		/// Subitems are sorted by name.
		/// </summary>
		public const int ALPHA = 1001;

		/// <summary>
		/// Subitems are sorted by external date.
		/// </summary>
		public const int XDATE = 1002;

		/// <summary>
		/// Subitems are sorted by internal date.
		/// </summary>
		public const int IDATE = 1003;

		/// <summary>
		/// Subitems are sorted by external date descending.
		/// </summary>
		public const int IXDATE = 1004;

		/// <summary>
		/// Subitems are sorted by internal date descending.
		/// </summary>
		public const int IIDATE = 1005;

		/// <summary>
		/// Subitems are sorted by name descending.
		/// </summary>
		public const int IALPHA = 1006;

		public const int DEFAULT = 1001;

		public const int NONE = 1999;

		/// <summary>
		/// Used for the ascending ordering of threads by username.
		/// </summary>
		/// <remarks>
		/// This value can be used for {@link FindBackgroundThreadOptions#sortOrder}.
		/// </remarks>
		public const int USERNAME = 1001;

		/// <summary>
		/// Used for the descending ordering of threads by username.
		/// </summary>
		/// <remarks>
		/// This value can be used for {@link FindBackgroundThreadOptions#sortOrder}.
		/// </remarks>
		public const int IUSERNAME = 1006;

		protected int dummyValue; // transient

		#endregion
		
		
		public static readonly long serialVersionUID = 1551556842L;		
	} // end class
}  // end namespace

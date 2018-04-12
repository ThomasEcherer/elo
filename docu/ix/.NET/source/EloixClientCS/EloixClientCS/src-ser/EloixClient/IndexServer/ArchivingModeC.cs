//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class ArchivingModeC : BSerializable
	{
	
		#region Constructors
		
		public ArchivingModeC() {
		}		
		
		public ArchivingModeC(int @dummy) {
			this.dummyValue = @dummy;
		}		
		
		public ArchivingModeC(ArchivingModeC rhs)
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
		/// Version flag: no versioning.
		/// </summary>
		public const int READWRITE = 2000;

		/// <summary>
		/// Version flag: version controlled.
		/// </summary>
		public const int VERSION = 2001;

		/// <summary>
		/// Version flag: read only.
		/// </summary>
		public const int READONLY = 2002;

		public const int DEFAULT = 2001;

		public const int NONE = 2999;

		protected int dummyValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1464718703L;		
	} // end class
}  // end namespace

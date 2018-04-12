//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class ArchivValue : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ArchivValue() {
		}		
		
		public ArchivValue(int @year, int @count) {
			this.yearValue = @year;
			this.countValue = @count;
		}		
		
		public ArchivValue(ArchivValue rhs) : base(rhs)
		{
			this.yearValue = rhs.yearValue;
			this.countValue = rhs.countValue;
		}		
		
		#endregion
		
		#region Properties
		
		public int year
		{
			get
			{
				return yearValue;
			}
			set
			{
				this.yearValue = value;
			}
		}
		
		
		public int count
		{
			get
			{
				return countValue;
			}
			set
			{
				this.countValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int yearValue;

		protected int countValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1695870218L;		
	} // end class
}  // end namespace

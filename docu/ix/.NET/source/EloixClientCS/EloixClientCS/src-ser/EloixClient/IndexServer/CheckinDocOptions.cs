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
	/// This class defines options for the API function checkinDocBegin2.
	/// </summary>
	public class CheckinDocOptions : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public CheckinDocOptions() {
		}		
		
		public CheckinDocOptions(bool @keepIds) {
			this.keepIdsValue = @keepIds;
		}		
		
		public CheckinDocOptions(CheckinDocOptions rhs) : base(rhs)
		{
			this.keepIdsValue = rhs.keepIdsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// If <tt>true</tt>, the DocVersion to check-in will use the ID and GUID you specify.
		/// </summary>
		/// <remarks>
		/// In
		/// order to only set the GUID, set the ID to 0.
		/// </remarks>
		public bool keepIds
		{
			get
			{
				return keepIdsValue;
			}
			set
			{
				this.keepIdsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool keepIdsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1433031299L;		
	} // end class
}  // end namespace

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
	/// Type safe element selector for class Action.
	/// </summary>
	public class ActionZ : BSerializable
	{
	
		#region Constructors
		
		public ActionZ() {
		}		
		
		public ActionZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public ActionZ(ActionZ rhs)
		{
			this.bsetValue = rhs.bsetValue;
		}		
		
		#endregion
		
		#region Properties
		
		public long bset
		{
			get
			{
				return bsetValue;
			}
			set
			{
				this.bsetValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected long bsetValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1006784044L;		
	} // end class
}  // end namespace

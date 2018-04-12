//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class SordPath : BSerializable
	{
	
		#region Constructors
		
		public SordPath() {
		}		
		
		public SordPath(IList<EloixClient.IndexServer.Sord> @sords) {
			this.sordsValue = @sords;
		}		
		
		public SordPath(SordPath rhs)
		{
			this.sordsValue = rhs.sordsValue;
		}		
		
		#endregion
		
		#region Properties
		
		public IList<EloixClient.IndexServer.Sord> sords
		{
			get
			{
				return sordsValue;
			}
			set
			{
				this.sordsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected IList<EloixClient.IndexServer.Sord> sordsValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 544862901L;		
	} // end class
}  // end namespace

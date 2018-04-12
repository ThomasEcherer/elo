//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class CheckoutSordPathInfo : BSerializable
	{
	
		#region Constructors
		
		public CheckoutSordPathInfo() {
		}		
		
		public CheckoutSordPathInfo(bool @inclRefPaths) {
			this.inclRefPathsValue = @inclRefPaths;
		}		
		
		public CheckoutSordPathInfo(CheckoutSordPathInfo rhs)
		{
			this.inclRefPathsValue = rhs.inclRefPathsValue;
		}		
		
		#endregion
		
		#region Properties
		
		public bool inclRefPaths
		{
			get
			{
				return inclRefPathsValue;
			}
			set
			{
				this.inclRefPathsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool inclRefPathsValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 730679282L;		
	} // end class
}  // end namespace

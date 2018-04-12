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
	/// This class contains the result return by the method getAclAccess.
	/// </summary>
	public class AclAccessResult : BSerializable
	{
	
		#region Constructors
		
		public AclAccessResult() {
		}		
		
		public AclAccessResult(int @access) {
			this.accessValue = @access;
		}		
		
		public AclAccessResult(AclAccessResult rhs)
		{
			this.accessValue = rhs.accessValue;
		}		
		
		#endregion
		
		#region Properties
		
		public int access
		{
			get
			{
				return accessValue;
			}
			set
			{
				this.accessValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int accessValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 200528028L;		
	} // end class
}  // end namespace

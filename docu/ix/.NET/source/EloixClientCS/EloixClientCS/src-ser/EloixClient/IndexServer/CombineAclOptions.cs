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
	/// This class specifies additional options for compareAcl.
	/// </summary>
	public class CombineAclOptions : BSerializable
	{
	
		#region Constructors
		
		public CombineAclOptions() {
		}		
		
		public CombineAclOptions(String @lhsAclStr, String @rhsAclStr) {
			this.lhsAclStrValue = @lhsAclStr;
			this.rhsAclStrValue = @rhsAclStr;
		}		
		
		public CombineAclOptions(CombineAclOptions rhs)
		{
			this.lhsAclStrValue = rhs.lhsAclStrValue;
			this.rhsAclStrValue = rhs.rhsAclStrValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Left operand for ACL operation in String representation.
		/// </summary>
		public String lhsAclStr
		{
			get
			{
				return lhsAclStrValue;
			}
			set
			{
				this.lhsAclStrValue = value;
			}
		}
		
		
		/// <summary>
		/// Right operand for ACL operation in String representation.
		/// </summary>
		public String rhsAclStr
		{
			get
			{
				return rhsAclStrValue;
			}
			set
			{
				this.rhsAclStrValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String lhsAclStrValue;

		protected String rhsAclStrValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 66519402L;		
	} // end class
}  // end namespace

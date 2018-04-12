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
	/// <p>Types of ACL items.
	/// </summary>
	/// <remarks>
	/// </p>
	/// </remarks>
	public class AclItemC : BSerializable
	{
	
		#region Constructors
		
		public AclItemC() {
		}		
		
		public AclItemC(String @ACL_EVERYONE_RAW, EloixClient.IndexServer.AclItem[] @ACL_EVERYONE) {
			this.ACL_EVERYONE_RAWValue = @ACL_EVERYONE_RAW;
			this.ACL_EVERYONEValue = @ACL_EVERYONE;
		}		
		
		public AclItemC(AclItemC rhs)
		{
			this.ACL_EVERYONE_RAWValue = rhs.ACL_EVERYONE_RAWValue;
			this.ACL_EVERYONEValue = rhs.ACL_EVERYONEValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// String representation of an ACL entry for
		/// group "Everyone" with full access.
		/// </summary>
		public String ACL_EVERYONE_RAW
		{
			get
			{
				return ACL_EVERYONE_RAWValue;
			}
			set
			{
				this.ACL_EVERYONE_RAWValue = value;
			}
		}
		
		
		/// <summary>
		/// ACL items for
		/// group "Everyone" with full access.
		/// </summary>
		public EloixClient.IndexServer.AclItem[] ACL_EVERYONE
		{
			get
			{
				return ACL_EVERYONEValue;
			}
			set
			{
				this.ACL_EVERYONEValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// ACL item for group.
		/// </summary>
		public const int TYPE_GROUP = 0;

		/// <summary>
		/// ACL item for user.
		/// </summary>
		public const int TYPE_USER = 1;

		/// <summary>
		/// ACL item for key.
		/// </summary>
		public const int TYPE_KEY = 10;

		/// <summary>
		/// ACL item to inherit rights.
		/// </summary>
		public const int TYPE_INHERIT = 100;

		/// <summary>
		/// ACL item to set rights for the owner.
		/// </summary>
		public const int TYPE_OWNER = 200;

		protected String ACL_EVERYONE_RAWValue;

		protected EloixClient.IndexServer.AclItem[] ACL_EVERYONEValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1507233874L;		
	} // end class
}  // end namespace

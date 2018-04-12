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
	/// This class contains the option for the methode getAclAccess
	/// </summary>
	public class AclAccessInfo : BSerializable
	{
	
		#region Constructors
		
		public AclAccessInfo() {
		}		
		
		public AclAccessInfo(String @acl, EloixClient.IndexServer.AclItem[] @aclItems, String @objId, String @parentId) {
			this.aclValue = @acl;
			this.aclItemsValue = @aclItems;
			this.objIdValue = @objId;
			this.parentIdValue = @parentId;
		}		
		
		public AclAccessInfo(AclAccessInfo rhs)
		{
			this.aclValue = rhs.aclValue;
			this.aclItemsValue = rhs.aclItemsValue;
			this.objIdValue = rhs.objIdValue;
			this.parentIdValue = rhs.parentIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		public String acl
		{
			get
			{
				return aclValue;
			}
			set
			{
				this.aclValue = value;
			}
		}
		
		
		public EloixClient.IndexServer.AclItem[] aclItems
		{
			get
			{
				return aclItemsValue;
			}
			set
			{
				this.aclItemsValue = value;
			}
		}
		
		
		public String objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Parent's ID of the current object.
		/// </summary>
		/// <remarks>
		/// (Useful to get the inherited ACLs of objects which haven't any ID yet, i.e.
		/// the ones being just added in archive.)
		/// </remarks>
		public String parentId
		{
			get
			{
				return parentIdValue;
			}
			set
			{
				this.parentIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String aclValue;

		protected EloixClient.IndexServer.AclItem[] aclItemsValue;

		protected String objIdValue;

		protected String parentIdValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 11569337L;		
	} // end class
}  // end namespace

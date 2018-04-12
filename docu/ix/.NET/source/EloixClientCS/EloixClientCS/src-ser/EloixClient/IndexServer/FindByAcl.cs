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
	/// Find objects by ACL
	/// </summary>
	public class FindByAcl : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindByAcl() {
		}		
		
		public FindByAcl(bool @distinctAcl, String[] @acls) {
			this.distinctAclValue = @distinctAcl;
			this.aclsValue = @acls;
		}		
		
		public FindByAcl(FindByAcl rhs) : base(rhs)
		{
			this.distinctAclValue = rhs.distinctAclValue;
			this.aclsValue = rhs.aclsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Return a list of unique ACL entries.
		/// </summary>
		/// <remarks>
		/// The ACL entries are wrapped in arbitary Sord objects which
		/// are returned in FindResult.sords.
		/// This functionality can be combinded with a FindChildren object
		/// to return all ACLs used in a sub tree.
		/// </remarks>
		public bool distinctAcl
		{
			get
			{
				return distinctAclValue;
			}
			set
			{
				this.distinctAclValue = value;
			}
		}
		
		
		/// <summary>
		/// Find objects that are protected by one of this ACLs.
		/// </summary>
		/// <remarks>
		/// For access checking, the order of the ACL items is irrelevant.
		/// That means, two ACL lists with the same items in different order are equal.
		/// But for this search option, the order of the items are relevant.
		/// Thus, the ACLs in the database must exactly match the given values.
		/// Wildcard * is supported, if only one ACL is supplied.
		/// This member is ignored, if {@link #distinctAcl} is true.
		/// </remarks>
		public String[] acls
		{
			get
			{
				return aclsValue;
			}
			set
			{
				this.aclsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool distinctAclValue;

		protected String[] aclsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1535514212L;		
	} // end class
}  // end namespace

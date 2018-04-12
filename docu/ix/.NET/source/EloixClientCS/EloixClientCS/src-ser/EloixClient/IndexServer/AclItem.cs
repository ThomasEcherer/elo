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
	/// <p>Human readable ACL entry.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class AclItem : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public AclItem() {
		}		
		
		public AclItem(int @access, int @id, String @name, int @type, EloixClient.IndexServer.IdName[] @andGroups) {
			this.accessValue = @access;
			this.idValue = @id;
			this.nameValue = @name;
			this.typeValue = @type;
			this.andGroupsValue = @andGroups;
		}		
		
		public AclItem(AclItem rhs) : base(rhs)
		{
			this.accessValue = rhs.accessValue;
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
			this.typeValue = rhs.typeValue;
			this.andGroupsValue = rhs.andGroupsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Access mode.
		/// </summary>
		/// <remarks>
		/// Bitset of LUR_*.
		/// </remarks>
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
		
		
		/// <summary>
		/// ID of user, group, key.
		/// </summary>
		public int id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
			}
		}
		
		
		/// <summary>
		/// Name of user, group, key.
		/// </summary>
		public String name
		{
			get
			{
				return nameValue;
			}
			set
			{
				this.nameValue = value;
			}
		}
		
		
		/// <summary>
		/// Item type: user, group, key, ...
		/// </summary>
		public int type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
			}
		}
		
		
		/// <summary>
		/// Only valid for group items.
		/// </summary>
		/// <remarks>
		/// Contains the IDs and names of additional groups. The user has to
		/// be a member in each of this groups to be able to access the object.
		/// </remarks>
		public EloixClient.IndexServer.IdName[] andGroups
		{
			get
			{
				return andGroupsValue;
			}
			set
			{
				this.andGroupsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int accessValue;

		protected int idValue;

		protected String nameValue;

		protected int typeValue;

		protected EloixClient.IndexServer.IdName[] andGroupsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1255072841L;		
	} // end class
}  // end namespace

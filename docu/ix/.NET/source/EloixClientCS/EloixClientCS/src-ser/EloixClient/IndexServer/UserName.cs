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
	/// <p>Contains user name, ID and type (group or user).
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class UserName : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public UserName() {
		}		
		
		public UserName(int @id, String @name, int @type, int @flags, int @flags2) {
			this.idValue = @id;
			this.nameValue = @name;
			this.typeValue = @type;
			this.flagsValue = @flags;
			this.flags2Value = @flags2;
		}		
		
		public UserName(UserName rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
			this.typeValue = rhs.typeValue;
			this.flagsValue = rhs.flagsValue;
			this.flags2Value = rhs.flags2Value;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// User ID
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
		/// User name.
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
		/// User type.
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
		/// User rights.
		/// </summary>
		/// <remarks>
		/// To detect a suspended user, test bit AccessC.FLAG_NOLOGIN.
		/// </remarks>
		public int flags
		{
			get
			{
				return flagsValue;
			}
			set
			{
				this.flagsValue = value;
			}
		}
		
		
		/// <summary>
		/// User rights, second set.
		/// </summary>
		/// <remarks>
		/// This member is a bit set of AccessC.FLAGS2_* constants.
		/// </remarks>
		public int flags2
		{
			get
			{
				return flags2Value;
			}
			set
			{
				this.flags2Value = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int idValue;

		protected String nameValue;

		protected int typeValue;

		protected int flagsValue;

		protected int flags2Value;

		#endregion
		
		
		public static readonly new long serialVersionUID = 123879203L;		
	} // end class
}  // end namespace

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
	/// <p>Data class containing some organizational unit information data:
	/// name and ID</p>
	/// <p>Copyright: Copyright (c) 2013</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class OrgUnitName : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public OrgUnitName() {
		}		
		
		public OrgUnitName(int @id, String @name) {
			this.idValue = @id;
			this.nameValue = @name;
		}		
		
		public OrgUnitName(OrgUnitName rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// OU identifier
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
		/// OU name
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
		
		
		#endregion
		
		#region Fields
		
		protected int idValue;

		protected String nameValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 427676481L;		
	} // end class
}  // end namespace

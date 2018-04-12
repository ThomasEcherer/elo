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
	/// <p>Contains information about a key object: ID and name.
	/// </summary>
	/// <remarks>
	/// </p>
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class KeyInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public KeyInfo() {
		}		
		
		public KeyInfo(int @id, String @name) {
			this.idValue = @id;
			this.nameValue = @name;
		}		
		
		public KeyInfo(KeyInfo rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Key ID.
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
		/// Key name.
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
		
		
		public static readonly new long serialVersionUID = 1537059480L;		
	} // end class
}  // end namespace

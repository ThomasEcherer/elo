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
	/// <p>Contains an numeric ID value, a GUID value in string format and a name.
	/// </summary>
	/// <remarks>
	/// </p>
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class IdName : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public IdName() {
		}		
		
		public IdName(String @guid, int @id, String @name) {
			this.guidValue = @guid;
			this.idValue = @id;
			this.nameValue = @name;
		}		
		
		public IdName(IdName rhs) : base(rhs)
		{
			this.guidValue = rhs.guidValue;
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// GUID.
		/// </summary>
		public String guid
		{
			get
			{
				return guidValue;
			}
			set
			{
				this.guidValue = value;
			}
		}
		
		
		/// <summary>
		/// Numeric ID.
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
		/// Name.
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
		
		protected String guidValue;

		protected int idValue;

		protected String nameValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 381683845L;		
	} // end class
}  // end namespace

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
	/// This class defines an encryption set.
	/// </summary>
	public class CryptInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public CryptInfo() {
		}		
		
		public CryptInfo(int @id, String @name, String @pwd, String @keyInfo) {
			this.idValue = @id;
			this.nameValue = @name;
			this.pwdValue = @pwd;
			this.keyInfoValue = @keyInfo;
		}		
		
		public CryptInfo(CryptInfo rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
			this.pwdValue = rhs.pwdValue;
			this.keyInfoValue = rhs.keyInfoValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Numerical ID of the encryption information.
		/// </summary>
		/// <remarks>
		/// The first ID is 1.
		/// </remarks>
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
		/// <remarks>
		/// Length of the field in database: 16byte.
		/// </remarks>
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
		/// External password used for encrypting documents.
		/// </summary>
		/// <remarks>
		/// It is empty if this object
		/// was returned by <code>checkoutCryptInfos</code>.
		/// </remarks>
		public String pwd
		{
			get
			{
				return pwdValue;
			}
			set
			{
				this.pwdValue = value;
			}
		}
		
		
		/// <summary>
		/// Key material.
		/// </summary>
		/// <remarks>
		/// Contains the external and internal password in serialized and
		/// encrypted format. Only for internal use.
		/// This member is ignored in <code>checkinCryptInfos</code>.
		/// </remarks>
		public String keyInfo
		{
			get
			{
				return keyInfoValue;
			}
			set
			{
				this.keyInfoValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int idValue;

		protected String nameValue;

		protected String pwdValue;

		protected String keyInfoValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1826259804L;		
	} // end class
}  // end namespace

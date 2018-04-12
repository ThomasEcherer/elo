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
	/// Internal class.
	/// </summary>
	public class ObjChange : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ObjChange() {
		}		
		
		public ObjChange(String @objId, String @tStamp, int @code, int @param, String @param2, int @user) {
			this.objIdValue = @objId;
			this.tStampValue = @tStamp;
			this.codeValue = @code;
			this.paramValue = @param;
			this.param2Value = @param2;
			this.userValue = @user;
		}		
		
		public ObjChange(ObjChange rhs) : base(rhs)
		{
			this.objIdValue = rhs.objIdValue;
			this.tStampValue = rhs.tStampValue;
			this.codeValue = rhs.codeValue;
			this.paramValue = rhs.paramValue;
			this.param2Value = rhs.param2Value;
			this.userValue = rhs.userValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: chgobjid
		/// </summary>
		public String objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
				setChangedMember(ObjChangeC.mbObjId);
			}
		}
		
		
		/// <summary>
		/// DB column: chgtstamp
		/// </summary>
		public String tStamp
		{
			get
			{
				return tStampValue;
			}
			set
			{
				this.tStampValue = value;
				setChangedMember(ObjChangeC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// DB column: chgcode
		/// </summary>
		public int code
		{
			get
			{
				return codeValue;
			}
			set
			{
				this.codeValue = value;
				setChangedMember(ObjChangeC.mbCode);
			}
		}
		
		
		/// <summary>
		/// DB column: chgparam
		/// </summary>
		public int param
		{
			get
			{
				return paramValue;
			}
			set
			{
				this.paramValue = value;
				setChangedMember(ObjChangeC.mbParam);
			}
		}
		
		
		/// <summary>
		/// DB column: chgparam2
		/// </summary>
		public String param2
		{
			get
			{
				return param2Value;
			}
			set
			{
				this.param2Value = value;
				setChangedMember(ObjChangeC.mbParam2);
			}
		}
		
		
		/// <summary>
		/// DB column: chguser
		/// </summary>
		public int user
		{
			get
			{
				return userValue;
			}
			set
			{
				this.userValue = value;
				setChangedMember(ObjChangeC.mbUser);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String objIdValue;

		protected String tStampValue;

		protected int codeValue;

		protected int paramValue;

		protected String param2Value;

		protected int userValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 753146L;		
	} // end class
}  // end namespace

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
	public class EloFtOpt : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public EloFtOpt() {
		}		
		
		public EloFtOpt(int @id, String @value, String @remark) {
			this.idValue = @id;
			this.valueValue = @value;
			this.remarkValue = @remark;
		}		
		
		public EloFtOpt(EloFtOpt rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.valueValue = rhs.valueValue;
			this.remarkValue = rhs.remarkValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: optid
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
				setChangedMember(EloFtOptC.mbId);
			}
		}
		
		
		/// <summary>
		/// DB column: optval
		/// </summary>
		public String value
		{
			get
			{
				return valueValue;
			}
			set
			{
				this.valueValue = value;
				setChangedMember(EloFtOptC.mbValue);
			}
		}
		
		
		/// <summary>
		/// DB column: remark
		/// </summary>
		public String remark
		{
			get
			{
				return remarkValue;
			}
			set
			{
				this.remarkValue = value;
				setChangedMember(EloFtOptC.mbRemark);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int idValue;

		protected String valueValue;

		protected String remarkValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 181406923L;		
	} // end class
}  // end namespace

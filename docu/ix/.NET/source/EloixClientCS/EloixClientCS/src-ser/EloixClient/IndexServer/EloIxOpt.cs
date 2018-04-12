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
	public class EloIxOpt : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public EloIxOpt() {
		}		
		
		public EloIxOpt(String @name, String @ixId, String @value) {
			this.nameValue = @name;
			this.ixIdValue = @ixId;
			this.valueValue = @value;
		}		
		
		public EloIxOpt(EloIxOpt rhs) : base(rhs)
		{
			this.nameValue = rhs.nameValue;
			this.ixIdValue = rhs.ixIdValue;
			this.valueValue = rhs.valueValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: optname
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
				setChangedMember(EloIxOptC.mbName);
			}
		}
		
		
		/// <summary>
		/// DB column: ixid
		/// </summary>
		public String ixId
		{
			get
			{
				return ixIdValue;
			}
			set
			{
				this.ixIdValue = value;
				setChangedMember(EloIxOptC.mbIxId);
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
				setChangedMember(EloIxOptC.mbValue);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String nameValue;

		protected String ixIdValue;

		protected String valueValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1454054253L;		
	} // end class
}  // end namespace

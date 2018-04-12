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
	public class EloDmOpt : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public EloDmOpt() {
		}		
		
		public EloDmOpt(int @id, String @value, String @remark, String @instanceName) {
			this.idValue = @id;
			this.valueValue = @value;
			this.remarkValue = @remark;
			this.instanceNameValue = @instanceName;
		}		
		
		public EloDmOpt(EloDmOpt rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.valueValue = rhs.valueValue;
			this.remarkValue = rhs.remarkValue;
			this.instanceNameValue = rhs.instanceNameValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: optno
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
				setChangedMember(EloDmOptC.mbId);
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
				setChangedMember(EloDmOptC.mbValue);
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
				setChangedMember(EloDmOptC.mbRemark);
			}
		}
		
		
		/// <summary>
		/// DB column: instance
		/// </summary>
		public String instanceName
		{
			get
			{
				return instanceNameValue;
			}
			set
			{
				this.instanceNameValue = value;
				setChangedMember(EloDmOptC.mbInstanceName);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int idValue;

		protected String valueValue;

		protected String remarkValue;

		protected String instanceNameValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 353149300L;		
	} // end class
}  // end namespace

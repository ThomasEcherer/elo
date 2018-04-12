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
	/// Additional report information for modified user.
	/// </summary>
	public class ReportInfoUserModified : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ReportInfoUserModified() {
		}		
		
		public ReportInfoUserModified(EloixClient.IndexServer.ReportInfoUserProps @newProps, EloixClient.IndexServer.ReportInfoUserProps @oldProps) {
			this.newPropsValue = @newProps;
			this.oldPropsValue = @oldProps;
		}		
		
		public ReportInfoUserModified(ReportInfoUserModified rhs) : base(rhs)
		{
			this.newPropsValue = rhs.newPropsValue;
			this.oldPropsValue = rhs.oldPropsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Modified properties.
		/// </summary>
		public EloixClient.IndexServer.ReportInfoUserProps newProps
		{
			get
			{
				return newPropsValue;
			}
			set
			{
				this.newPropsValue = value;
			}
		}
		
		
		/// <summary>
		/// Properties before modification.
		/// </summary>
		/// <remarks>
		/// This member is null for new users and for deleted users.
		/// </remarks>
		public EloixClient.IndexServer.ReportInfoUserProps oldProps
		{
			get
			{
				return oldPropsValue;
			}
			set
			{
				this.oldPropsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.ReportInfoUserProps newPropsValue;

		protected EloixClient.IndexServer.ReportInfoUserProps oldPropsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1649121955L;		
	} // end class
}  // end namespace
